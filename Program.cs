namespace AlgebraZadaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //projekt za izradu zadataka
            /*
             * CIKLIČNE PETLJE:
             * TURA 1:
             * 1. Primjer konačne while petlje koja ima uvijet ako je x manji od 10
             * 2. Primjer konačne while petlje koja ima uvijet ako je y veći od 0.
             * 3.Beskonačna petlja, ali uz pomoć naredbe break; je mogući izaći iz petlje.
             * 4.Primijer while petlje za unos ocjena. Ocjene moraju biit brojevi između 1 i 5.
             * 5. Program za brojanje ukupnog broja slova, znamenki, posebnih znakova niza
             *     
             */

            //1. radi
            /* Console.WriteLine("Upiši x:");
             int x= int.Parse(Console.ReadLine());
             while (x<10)
             {
                 Console.WriteLine("X je manji od 10.");
            x++;
                 b*/
            //2 radi
            /*Console.WriteLine("Upiši y:");
            int y = int.Parse(Console.ReadLine());
            while(y < 0)
            {
                Console.WriteLine("Y je manji od 0.");
            y++;
                break;
            }*/
            //3
          /* int a = 0;
            while (a == 0)
            {
             
                Console.WriteLine("Ovo je beskoonačna petlja, ovo je ");
                ConsoleKeyInfo van = Console.ReadKey();
                if (van.Key == ConsoleKey.V)
                {
                    break;
                }
                


            }*/
            //4 radi
          /*  Console.WriteLine("Upiši ocjenu:");
            int ocijena = int.Parse(Console.ReadLine());
            while (ocijena > 0 && ocijena <= 5)
            {
                Console.WriteLine("Ocjena je: " + ocijena);
                Console.WriteLine("Upiši ocjenu:");
                ocijena = int.Parse(Console.ReadLine());

            }*/

            //5 radi
           Console.WriteLine("Upiši niz znamenki:");
            string niz=Console.ReadLine();
           // var brojZnaova = niz.Count();
            //var brojZnaova2 = niz.Length;
            
            int brojac = 0;
            int posebni = 0;

            /* for (int i = 1; i <= niz.Count(); i++)
             {
                 Console.WriteLine("Ovo je {0} prolaz.", i);
                 brojac++;
                // Console.WriteLine("Brojac " + brojac);

             }
             Console.WriteLine("Ovaj niz ima {0} znamenki.", brojac);
            */

          /*  char[] lista= niz.ToCharArray();
            int znak=0;
            int slova=0;
            int posebnzi=0;
            for (int i = 1; i <= lista.Length; i++)
            {
                Console.WriteLine("Ovo je {0} prolaz.", i);
                if (char.IsDigit(niz[i]))
                {
                    znak++;
                }
                if (char.IsLetter(niz[i]))
                {
                    slova++;
                }
                if(char.IsSymbol(niz[i]))
                {
                    posebnzi++;
                }
            }*/


        }
    }
}
