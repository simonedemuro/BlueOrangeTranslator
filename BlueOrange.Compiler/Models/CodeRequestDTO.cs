using System;
using System.Collections.Generic;
using System.Text;

namespace BlueOrange.Compiler.Models
{
    public class CodeRequestDTO
    {
        public string Code { get; set; }
        public string SrcLanguage { get; set; }
        public string DstLanguage { get; set; }

    }
}
