using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrviZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            string recenica, sVelika, sMala, sPrvaTri, sZadnjihPet, s8_11; 
         
            Console.Write("Upisite recenicu: ");
            recenica = Console.ReadLine();
            sVelika = recenica.ToUpper();
            sMala = recenica.ToLower();
            sPrvaTri = recenica.Substring(0, 3);
            sZadnjihPet = recenica.Substring(poruka.Length - 5);
            s8_11 = recenica.Substring(8, 3);

            Console.WriteLine("sVelika = " + sVelika + "\nsMala = " + sMala + "\nsPrvaTri = " + sPrvaTri + "\nsZadnjihPet = " + sZadnjihPet + "\ns8_11 = "+ s8_11);

            Console.ReadKey();
        }

       
    }
    


}
