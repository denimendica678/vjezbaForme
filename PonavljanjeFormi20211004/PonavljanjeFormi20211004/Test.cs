﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonavljanjeFormi20211004
{
    class Test
    {
        string tekst;

        public Test(string tekst)
        {
            this.Tekst = tekst;
        }

        public string Tekst { get => tekst; set => tekst = value; }

        public override string ToString()
        {
            return "tekst: " + Tekst;
        }
    }
}
