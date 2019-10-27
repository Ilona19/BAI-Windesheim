using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAIcollege3
{
    class HuiswerkMethode
    {
        public static void TestFunction()
        {
            bool valide;
            string kleur;
            string gender;
            int cijfer;

            int datastream;

            for (datastream = 0; datastream < 256; datastream++)
            {
                //datastream = Convert.ToInt32(input, 2);

                int valideWaarde = datastream & 0x80;
                int kleurWaarde = (datastream & 0x60) >> 5;
                int genderWaarde = datastream & 0x10;
                int cijferWaarde = datastream & 0x0F;


                // valide true/false
                if (valideWaarde == 0)
                {
                    valide = true;
                }
                else
                {
                    valide = false;
                }

                // kleur
                switch (kleurWaarde)
                {
                    case 0:
                        kleur = "Wit";
                        break;
                    case 1:
                        kleur = "Groen";
                        break;
                    case 2:
                        kleur = "Oranje";
                        break;
                    case 3:
                        kleur = "Rood";
                        break;
                    default:
                        kleur = "Onbekend";
                        break;
                }

                // gender
                if (genderWaarde == 0)
                {
                    gender = "Man";
                }
                else
                {
                    gender = "Vrouw";
                }

                //cijfer doet raar bij 1110 en 1111
                cijfer = cijferWaarde;

                Console.WriteLine($"Valide: {valide}; Kleur: {kleur}; Gender: {gender}; Cijfer: {cijfer}");
            }
        }
    }
}
