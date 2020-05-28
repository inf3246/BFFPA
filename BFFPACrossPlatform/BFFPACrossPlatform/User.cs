using System;
using System.Collections.Generic;
using System.Text;

namespace BFFPACrossPlatform
{
    class User
    {
        public double weight;
        public String genderFaktor; //Reduktionsfaktor 0,7 oder 0,6 wird von der Form übergeben
        public static double akfm = 0.68;
        public static double akfw = 0.55;
        public String name;
        public double bak;
        public Getränk[] getränke;
        public double bakUG;
        public double bakOG;
        


        public User(double weight, String name, String gender, double bakUG, double bakOG)
        {
            this.weight = weight;
            this.genderFaktor = gender;
            this.name = name;
            this.bakUG = bakUG;
            this.bakOG = bakOG;
            bak = 0;
        }

        public void addDrink(Getränk getränk)
        {
            getränke[getränke.Length] = getränk;

        }

        public void calcBAK(Getränk getränk)
        { double reductFaktor;

            //bak += getränk.alcInGramm/(weight * )
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
