﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    interface IOperacje:ISprawdzanie
    {
        void Dodaj(string nazwa, int powierzchnia, string nazwaStolicy, bool lotnisko);
        void Usun();
        void Usun(string p1);
    }
}
