using System;
using System.Collections.Generic;
using System.Text;

namespace BFFPACrossPlatform
{
    public class User
    {
        double weight;
        String genderFaktor; //Reduktionsfaktor 0,7 oder 0,6 wird von der Form übergeben
        static double akfm = 0.68;
        static double akfw = 0.55;
        String name;
        double bak;
        Getränk[] getränke;
        double bakUG;
        double bakOG;
        


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
