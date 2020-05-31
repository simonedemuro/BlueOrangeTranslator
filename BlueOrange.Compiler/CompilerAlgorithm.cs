using BlueOrange.Compiler.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;
using BlueOrange.Compiler.Exceptions;
using BlueOrange.Compiler.Langs;

namespace BlueOrange.Compiler
{
    public class CompilerAlgorithm
    {
        public IOrangeLanguage GetConcreteLanguageImplementation(string language)
        {
            if (language == "IJVM")
                return new IjvmCompiler();
            if (language == "8086")
                return new A8086Compiler();
            else
                throw new LanguageNotImplementedException(language);
        }

        public string Compile(IOrangeLanguage lang)
        {
            bool cazzivari =  false;
            while (cazzivari)
            {
               // lang.processInstruction("in a = 6;");
            }

            return "Blue Orange Compiler at Work " + (new Random().Next(0,100)).ToString() ;
        }
    }
}
