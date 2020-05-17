using System;
using System.Collections.Generic;
using System.Text;

namespace BlueOrange.Test
{
    class CodeTranslation
    {
        string stringCode = "";
        string resultingCode = "";
        string[] arrayCode;
        int arrayCodeIndex = 0;

        public string getStringCode() 
        {
            return stringCode;
        }

        public void setStringCode(string newString)
        {
            stringCode = newString;
        }

        public string getResultingCode()
        {
            return resultingCode;
        }

        public void setResultingCode(string newString)
        {
            resultingCode = newString;
        }

        public void addToResultingCode(string newString)
        {
            resultingCode = resultingCode + newString;
        }


        public void setArrayCode(string[] newString)
        {
            arrayCode = newString;
        }

        public int getArrayCodeIndex()
        {
            return arrayCodeIndex;
        }

        public void setArrayCodeIndex(int newIndex)
        {
            arrayCodeIndex = newIndex;
        }

        public string[] getArrayCode()
        {
            return arrayCode;
        }

        public string codeDefinition(string codeToBeDefine)
        {
            throw new NotImplementedException();
            return "";
        }

        public string variablesDefinition(string variablesToBeTranslated, Language language)
        {
            string startVariables = language.istructionTags.variablesTags[0]; // ".var";
            string endVariables = language.istructionTags.variablesTags[0]; //".end-var";

            string[] variablesArray = variablesToBeTranslated.Split(' ', ',', ';');
            string resultingVariables;

            resultingVariables = startVariables;


            foreach (var word in variablesArray)
            {
                if (word != "int" && word != "")
                {
                    resultingVariables = resultingVariables + "\n\t" + word;
                }
            }
            resultingVariables = resultingVariables + "\n" + endVariables;

            return resultingVariables;
        }

        public string constantDefinition(string codeToBeDefine)
        {
            throw new NotImplementedException();
            return "";
        }

        public string assignament(string codeToBeDefine)
        {
            throw new NotImplementedException();
            return "";
        }

        public string ifCostruct(string codeToBeDefine)
        {
            throw new NotImplementedException();
            return "";
        }

        public string whileCostruct(string codeToBeDefine)
        {
            throw new NotImplementedException();
            return "";
        }

        public string methodImplementation(string codeToBeDefine)
        {
            throw new NotImplementedException();
            return "";
        }

        public string methodCall(string codeToBeDefine)
        {
            throw new NotImplementedException();
            return "";
        }

        public string blockAnalizer(string codeToBeDefine)
        {
            throw new NotImplementedException();
            return "";
        }

    }
}
