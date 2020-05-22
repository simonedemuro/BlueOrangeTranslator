using System;
using System.Collections.Generic;
using System.Text;

namespace BlueOrange.Compiler.Interfaces
{
    interface IOrangeLanguage
    {
/*
        string stringCode;
        string resultingCode;
        string[] arrayCode;
        int arrayCodeIndex;


        public string getStringCode()
        {
            return stringCode;
        }

        private void setStringCode(string newString)
        {
            stringCode = newString;
        }

        public string getResultingCode()
        {
            return resultingCode;
        }

        private void setResultingCode(string newString)
        {
            resultingCode = newString;
        }

        public void addToResultingCode(string newString)
        {
            resultingCode = resultingCode + newString;
        }


        private void setArrayCode(string[] newString)
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
        } */

        public string codeDefinition(string codeToBeDefine);

        public string variablesDefinition(string variablesToBeTranslated, IOrangeLanguage language);


        public string constantDefinition(string codeToBeDefine);

        public string assignament(string codeToBeDefine);

        public string ifCostruct(string codeToBeDefine);

        public string whileCostruct(string codeToBeDefine);

        public string methodImplementation(string codeToBeDefine);

        public string methodCall(string codeToBeDefine);
        public string blockAnalizer(string codeToBeDefine);
    }
}
