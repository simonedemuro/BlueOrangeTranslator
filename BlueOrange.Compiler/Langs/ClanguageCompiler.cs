using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlueOrange.Compiler.Interfaces;
using BlueOrange.Compiler.modelli;

namespace BlueOrange.Compiler.Langs
{
    public class ClanguageCompiler: IOrangeLanguage
    {
        public string originalCode { get; set; }
        public string xmlCode { get; private set; }
        

        public void toXML() 
        {
            string[] tmp;
            int costruct = -1;
            List<int> parentesis = new List<int>();

            string[] result;
            string xmltranslation = "";

            result = originalCode.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = result[i].Trim();               
                costruct = costructSelection(result[i]);
                if (result[i].Contains('{')) 
                {
                    parentesis.Insert(0,costruct);
                }
                

                xmltranslation = construcAction(result[i], costruct);


                if (result[i].Contains('}'))
                {
                    result[i] = textInjector(xmltranslation.Split('}')) + " " + costructEnding(parentesis.ElementAt(0));
                    if (parentesis.ElementAt(0) == 1) 
                    {
                        result[i] = result[i] + '\n';
                    }
                    parentesis.RemoveAt(0);

                }
                else
                {
                    result[i] = xmltranslation;
                }
            }

            xmltranslation = "";

            foreach (var item in result)
            {
                xmltranslation = xmltranslation + '\n' + item;
            }
            xmlCode = xmltranslation;
        }


        int costructSelection(string code)
        {
            if (code.StartsWith("#define"))
            {
                return 0;
            }
            if (code.StartsWith("int"))
            {
                return 1;
            }
            

            if (code.StartsWith("if"))
            {
                //result[i] = ifToXML(result[i]);
            }
            if (code.Contains('=')) {
                return 2;
            }
            return -1;
        }

        string construcAction(string code, int construct) 
        {
            switch (construct)
            {
                case 0:
                    return code = macroToXML(code);
                    break;
                case 1:
                    return code = intCommand(code);
                    break;
                case 2:
                    return code = assignmentToXML(code);
                    break;

            }

            return code;
        }


        string costructEnding(int costruct) 
        {
            switch (costruct) 
            {
                case 1:
                    return "</function>";
            }
            return " < error! > ";
        }

        string macroToXML(string code) 
        {
            string[] tmp;
            tmp = code.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            code = "<macro> " + tmp[1] + " " + tmp[2] + " </macro>";
            return code;
        }

        string intCommand(string code) 
        {
            string[] tmp;
            string declarationTmp;
            if (code.Contains('='))
            {
                tmp = code.Split('=', StringSplitOptions.RemoveEmptyEntries);
                declarationTmp = declarationToXML(tmp[0]);
                tmp = code.Split("int", StringSplitOptions.RemoveEmptyEntries);
                tmp[0] = assignmentToXML(tmp[0]);
                code = declarationTmp + "\n" + tmp[0];
                
            }
            else if (code.Contains('('))
            {
                code = functionToXML(code);
            }
            else
            {
                code = declarationToXML(code);
            }

            return code;
        }


        string declarationToXML(string code)
        {
            string[] tmp;

            if (code.Contains('('))
            {
            }
            else
            {
                tmp = code.Split(' ', '=', ';');
                code = "<declaration> " + textInjector(tmp) + " </declaration>";
            }
            return code;
        }

        string functionToXML(string code)
        {
            string[] tmp;
            tmp = code.Split(' ', '(', ')', ',', '{');
            int j = 0;

            code = "<function ";
            code = code + textInjector(tmp);

            code = code + " >";

            return code;
        }

        string assignmentToXML(string code)
        {
            string[] tmp;
            tmp = code.Split(' ', ';', StringSplitOptions.RemoveEmptyEntries);
            code = "<assignement> " + tmp[0] + " " + tmp[2] + " </assignement>";
            return code;
        }


        string ifToXML(string code) // devo definire prima gli assegnamenti, le condizioni e gli incrementi           
        {
            string[] tmp;
            tmp = code.Split('(', ';',')'); ;
            code = "<if> " + tmp[1] + " " + tmp[2] + " </if>"; 
            return code;
        }

        string textInjector(string[] splittedText) 
        {
            string text = "";
            int j = 0;

            for (int i = 0; i < splittedText.Length; i++)
            {
                if (splittedText[i] != "")
                {
                    if ( j!=0 && j % 2 == 0 )
                    {
                        text = text + ", ";
                    }
                    text = text + splittedText[i] + " ";
                    j++;
                }
            }

            return text;
        }

    }
        
}
    