using System;
using System.Collections.Generic;
using System.Text;

namespace BFFPACrossPlatform
{
    class User
    {
        double weight;
        bool gender;
        static double akfm = 0.68;
        static double akfw = 0.55;
        String name;
        double bak;
        Getränk[] getränke;
        double bakUG;
        double bakOG;
        bool currentState;


        public User(double weight, String name, Boolean gender, double bakUG, double bakOG)
        {
            this.weight = weight;
            this.gender = gender;
            this.name = name;
            this.bakUG = bakUG;
            this.bakOG = bakOG;
        }

        public void addDrink(Getränk getränk)
        {
            getränke[getränke.Length] = getränk;

        }

        public void calcBAK(Getränk getränk)
        {
            bak += getränk.calcalc;
           currentState = checkBAK(bak, bakUG, bakOG);
        }

        public bool checkBAK(double bak, double bakUG, double bakOG)
        {
            if(bak < bakOG && bak > bakUG)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
