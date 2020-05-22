using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using BlueOrange.Compiler.Interfaces;
using BlueOrange.Compiler.modelli;

namespace BlueOrange.Compiler.Langs
{
    public class IjvmCompiler //: IOrangeLanguage
    {
        private string[] TagEnumerators;

        private Dictionary<string, string> statements;
        public IjvmCompiler()
        {

            statements = new Dictionary<string, string>()
            {
                {TagEnumerators[0], ""}, // instruction 
                {TagEnumerators[1], ""},
                {TagEnumerators[2], ""},

                {TagEnumerators[5], ".constant"}, // constant
                {TagEnumerators[6], ".end-constant"},
                {TagEnumerators[7], " "},
                {TagEnumerators[8], "\n"},

                {TagEnumerators[10], ".var"}, // variables
                {TagEnumerators[11], ".end-var"},
                {TagEnumerators[12], "\n"},
                {TagEnumerators[13], "\n\t"}

            };
            _ = statements["cat"];
        }


        public string VariablesDefinition(string variablesToBeTranslated)
        {
            string startVariables = statements[TagEnumerators[10]];
            string endVariables = statements[TagEnumerators[11]];

            string[] variablesArray = variablesToBeTranslated.Split(' ', ',', ';');
            string resultingVariables;

            resultingVariables = startVariables;


            foreach (var word in variablesArray)
            {
                if (word != "int" && word != "")
                {
                    resultingVariables = resultingVariables + statements[TagEnumerators[13]] + word;
                }
            }
            resultingVariables = resultingVariables + statements[TagEnumerators[12]] + endVariables;

            return resultingVariables;

        }
    }
}
