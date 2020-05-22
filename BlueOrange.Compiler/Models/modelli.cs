using System;
using System.Collections.Generic;
using System.Text;

namespace BlueOrange.Compiler.Models
{
    public enum tagEnumerator { instruction, constant, variables, main, method, assignment, variableget, input, output, methodcall, algebricoperation, other, tobewritten }

    public enum actualConstruct { empty, program, IF, WHILE, method, MAIN, blocco }

    public class modelli
    {
        public string[] TagEnumerators;

        

    }
}
