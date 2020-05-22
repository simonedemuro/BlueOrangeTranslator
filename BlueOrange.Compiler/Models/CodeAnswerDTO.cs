using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BlueOrange.Compiler.Models
{
    public class CodeAnswerDTO 
    { 
        // This Field is populated ONLY in case of error
        public string Error { get; set; }
        // This Field will contain the result code or the error message in case of error
        public string Code { get; set; }

        public CodeAnswerDTO(string error, string code)
        {
            Error = error;
            Code = code;
        }

        public CodeAnswerDTO(string code)
        {
            Code = code;
        }
    }
}
