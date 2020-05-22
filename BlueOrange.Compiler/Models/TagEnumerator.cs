namespace BlueOrange.Compiler.modelli
{
    public enum tagEnumeratore { instruction, constant, variables, main, method, assignment, variableget, input, output, methodcall, algebricoperation, other, tobewritten }

    class TagEnumerator
    {
        private string[] TagEnumerators { get; set; }

        public TagEnumerator()
        {
            TagEnumerators = new string[]
            {
                "instructionStart",
                "instructionEnd",
                "istructionBetween",
                "instructionNewLine",
                "1",
                "constantStart",//5
                "constantEnd",
                "constantBetween",
                "constantNewLine",
                "2",
                "variablesStart",//10
                "variablesEnd",
                "variablesBetween",
                "variablesEndLine",
                "4",
                "main",
               "method",
                "assignment",
                "variableget",
                "input",
                "output",
                "methodcall",
                "algebricoperation",
                "other",
                "tobewritten"
            };
        }
    }
}
