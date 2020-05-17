using System;
using System.Collections.Generic;
using System.Text;

namespace BlueOrange.Test
{
    public enum tagEnumerator {instruction, constant, variables, main, method, assignment, variableget, input, output, methodcall, algebricoperation, other, tobewritten}
   
    public struct IstructionSet
    {
        public List<string> constantTags; // il primo ed il secondo elemento verranno usati per l' apertura e la chiusura delle aree dedicate
        
        public List<string> variablesTags;
        public List<string> mainTags;
        public List<string> methodTags;
        
        public List<string> assignementTags;
        public List<string> variableGetTags;
        public List<string> inputTags;
        public List<string> outputTags;
        public List<string> methodCallTags;
        public List<string> algebricOperationTags;
        public List<string> otherTags;
    }

    class Language
    {

        public IstructionSet istructionTags;
        

        public void setLanguage(string newLanguage)  // divide il linguaggio nei suoi elementi utili
        {
            istructionTags = new IstructionSet();
            string[] arrayLanguage = newLanguage.Split(' ', ':', ',', ';', '\n') ;
            int sectionList = 0;
            int toBeWrittenIn = 0;          

            foreach (string word in arrayLanguage)
            {
                if (word != "") 
                {
                    sectionList = (int) isTag(word);
                    if (sectionList <= 12)
                    {
                        toBeWrittenIn = sectionList;
                    }
                    else
                    {
                        insertInCategory(word, toBeWrittenIn);
                    }

                }
            }

        }

        public void insertInCategory(string word, int category) 
        {
            switch (category)
            {
                case 0:
                    break;
                case 1:
                    istructionTags.constantTags.Add(word);
                    break;
                case 2:
                    istructionTags.variablesTags.Add(word);
                    break;
                case 3:
                    istructionTags.mainTags.Add(word);
                    break;
                case 4:
                    istructionTags.methodTags.Add(word);
                    break;
                case 5:
                    istructionTags.assignementTags.Add(word);
                    break;
                case 6:
                    istructionTags.variableGetTags.Add(word);
                    break;
                case 7:
                    istructionTags.inputTags.Add(word);
                    break;
                case 8:
                    istructionTags.outputTags.Add(word);
                    break;
                case 9:
                    istructionTags.methodCallTags.Add(word);
                    break;
                case 10:
                    istructionTags.algebricOperationTags.Add(word);
                    break;               

                default:
                    break;
            }
        }

        public tagEnumerator isTag(string word) 
        {
            int n = 0;
            if (word == ((tagEnumerator)n).ToString()) //0
            {
                return (tagEnumerator)n;
            }
            n++;
            if (word == ((tagEnumerator)n).ToString()) //1
            {
                return (tagEnumerator)n;
            }
            n++;
            if (word == ((tagEnumerator)n).ToString()) //2
            {
                return (tagEnumerator)n;
            }
            n++;
            if (word == ((tagEnumerator)n).ToString()) //3
            {
                return (tagEnumerator)n;
            }
            n++;
            if (word == ((tagEnumerator)n).ToString()) //4
            {
                return (tagEnumerator)n;
            }
            n++;
            if (word == ((tagEnumerator)n).ToString()) //5
            {
                return (tagEnumerator)n;
            }
            n++;
            if (word == ((tagEnumerator)n).ToString()) //6
            {
                return (tagEnumerator)n;
            }
            n++;
            if (word == ((tagEnumerator)n).ToString()) //7
            {
                return (tagEnumerator)n;
            }
            n++;
            if (word == ((tagEnumerator)n).ToString()) //8
            {
                return (tagEnumerator)n;
            }
            n++;
            if (word == ((tagEnumerator)n).ToString()) //9
            {
                return (tagEnumerator)n;
            }
            n++;
            if (word == ((tagEnumerator)n).ToString()) //10
            {
                return (tagEnumerator)n;
            }
            n++;
            if (word == ((tagEnumerator)n).ToString()) //11
            {
                return (tagEnumerator)n;
            }
            n++;
            if (word == ((tagEnumerator)n).ToString()) //12
            {
                return (tagEnumerator)n;
            }
            n++;

            return (tagEnumerator)n;
           

        }

        public void setLanguageFromXML(string newLanguage)
        {

        }

    }
}
