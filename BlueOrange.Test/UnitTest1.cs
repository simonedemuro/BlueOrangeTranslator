using System;
using Xunit;

namespace BlueOrange.Test
{
    public class UnitTest1
    {

        int mul(int a, int b)
        {
            int c=0;
            for (int i = 0; i < b; i++)
            {
                c += a;
            }

            return c;
        }

        [Fact]
        public void Test1()
        {
            // SETUP
            int expectedRes = 2*3;

            // OPERATIONS
            int myResult = mul(2, 3);

            // ASSERT 
            Assert.Equal(expectedRes, myResult);
        }

        
        [Fact]
        public string constantTest()
        {
            // SETUP
            var expectedRes = ".constant\n\tOBJREF 0x40\n\tENDLINE 0xa\n.end-constant";
            string s = "#define OBJREF 0x40\n#define ENDLINE 0xa";

            // OPERATIONS
            var myResult = constantDefinition(s);


            // ASSERT 
            Assert.Equal(expectedRes, myResult);
            return s;
        }

        
        public string constantDefinition(string constantsToBeTranslated)
        {
            bool isLabel = false;

            string startConstants = ".constant";
            string endConstants = ".end-constant";

            string[] constantArray = constantsToBeTranslated.Split(' ','\n');
            string resultingConstant;

            resultingConstant = startConstants;


            foreach (var word in constantArray)
            {
                if (word == "#define" )
                {
                    isLabel = true;
                }
                else if (isLabel)
                {
                    resultingConstant = resultingConstant + "\n\t" + word;
                    isLabel = false;
                }
                else
                {
                    resultingConstant = resultingConstant + " " + word;
                }
            }
            resultingConstant = resultingConstant + "\n" + endConstants;            

            return resultingConstant;
        }


        [Fact]
        public string variablesTest()
        {
            // SETUP
            var expectedRes = ".var\n\ta\n\tb\n.end-var";
            string s = "int a, b;";

            // OPERATIONS
            var myResult = variablesDefinition(s);


            // ASSERT 
            Assert.Equal(expectedRes, myResult);
            return s;
        }


        public string variablesDefinition(string variablesToBeTranslated)
        {
            bool isLabel = false;

            string startVariables = ".var";
            string endVariables = ".end-var";

            string[] variablesArray = variablesToBeTranslated.Split(' ',',',';');
            string resultingVariables;

            resultingVariables = startVariables;


            foreach (var word in variablesArray)
            {
                if (word != "int" && word != "")
                {
                    resultingVariables = resultingVariables + "\n\t" + word;
                    isLabel = false;
                }                
            }
            resultingVariables = resultingVariables + "\n" + endVariables;

            return resultingVariables;
        }

        

    }
}
