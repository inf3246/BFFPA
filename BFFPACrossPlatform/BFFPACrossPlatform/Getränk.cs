using System;
using System.Collections.Generic;
using System.Text;

namespace BFFPACrossPlatform
{
    class Getränk
    {
        int ml;
        int vol;
        static double alcweight = 0.8;
        public double calcalc;

        public Getränk(int ml, int vol)
        {
            this.ml = ml;
            this.vol = vol;
            calcalc = ml * (vol / 100) * alcweight;
        }

    }
}
