using System;
using System.Collections.Generic;
using System.Text;

namespace BFFPACrossPlatform
{
    public class Getränk
    {
        int ml;
        int vol;
        static double alcweight = 0.8;
        public double alcInGramm;

        public Getränk(int ml, int vol)
        {
            this.ml = ml;
            this.vol = vol;
            alcInGramm = ml * (vol / 100) * alcweight;
        }

    }
}
