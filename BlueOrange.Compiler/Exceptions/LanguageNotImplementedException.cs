using System;
using System.Collections.Generic;
using System.Text;

namespace BlueOrange.Compiler.Exceptions
{
    [Serializable]
    class LanguageNotImplementedException : Exception
    {
        public LanguageNotImplementedException()
        {

        }

        public LanguageNotImplementedException(string lang)
            : base(String.Format("Invalid SrcLanguage Provider: {0}", lang))
        {

        }
    }
}
