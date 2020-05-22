using System;
using System.Collections.Generic;
using System.Text;

namespace BlueOrange.Compiler.Interfaces
{
    public interface IOrangeLanguage
    {
        string CodeDefinition(string codeToBeDefine);

        string VariablesDefinition(string variablesToBeTranslated, IOrangeLanguage language);


        string ConstantDefinition(string codeToBeDefine);

        string Assignament(string codeToBeDefine);

        string IfCostruct(string codeToBeDefine);

        string WhileCostruct(string codeToBeDefine);

        string MethodImplementation(string codeToBeDefine);

        string MethodCall(string codeToBeDefine);
        string BlockAnalizer(string codeToBeDefine);
    }
}
