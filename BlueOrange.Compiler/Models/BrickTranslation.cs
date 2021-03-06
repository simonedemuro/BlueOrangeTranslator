﻿namespace BlueOrange.Compiler.modelli
{
    public enum actualConstruct { empty, program, IF, WHILE, method, MAIN, blocco }

    class BrickTranslation
    {        
        actualConstruct Construct { get; set; }
        string localText { get; set; }
        BrickTranslation firstConstruct { get; set; }
        BrickTranslation middleConstruct { get; set; }
        BrickTranslation lastConstruct { get; set; }

        public BrickTranslation() 
        {
            Construct = (actualConstruct) 0;
            localText = null;
            firstConstruct = null;
            middleConstruct = null;
            lastConstruct = null;
        }

    }
}
