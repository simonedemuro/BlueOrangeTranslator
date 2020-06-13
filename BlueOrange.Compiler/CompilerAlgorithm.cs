using BlueOrange.Compiler.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;
using BlueOrange.Compiler.Exceptions;
using BlueOrange.Compiler.Langs;
using System.Text.RegularExpressions;

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

        public string Compile(IOrangeLanguage lang, string code)
        {

            ClanguageCompiler cl = new ClanguageCompiler();


            // PARSING

            // CALLING IOrangeLanguage METHODS IN ORDER TO PROCESS THE CODE 
            string str = " °°";
            string pattern = @"[^\n\}].*\((([^()]+)|)\)";
            string input = code;
                 
            RegexOptions options = RegexOptions.Multiline;

            //str = Regex.Matches(input, pattern, options).ToString();
            foreach (Match m in Regex.Matches(input, pattern, options))
            {
                str = str + m.Value +" °° ";
            }




            bool cazzivari =  false;
            while (cazzivari)
            {
               // lang.processInstruction("in a = 6;");
            }

            cl.originalCode = code;
            cl.toXML();

            
            
            return "Blue Orange Compiler at Work " + (new Random().Next(0,100)).ToString() + "\n\n" + cl.xmlCode  ;
        }
    }
}
