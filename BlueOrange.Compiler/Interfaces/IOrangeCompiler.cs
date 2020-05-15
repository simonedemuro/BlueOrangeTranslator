using System;
using System.Collections.Generic;
using System.Text;

namespace BlueOrange.Compiler.Interfaces
{
    interface IOrangeCompiler
    {
        string processInstruction(string instruction);
        string processStatement(string stat);
        string translateCode(string code);
    }
}
