using System.Collections;

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
            // Console.WriteLine("Upiši niz znamenki:");
            // string niz=Console.ReadLine();
            // var brojZnaova = niz.Count();
            //var brojZnaova2 = niz.Length;

            //  int brojac = 0;
            // int posebni = 0;

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
            //----------------------------------------------------------------------------------
            //24.03.2026
            /*
             1.kopirajte jedan niz u drugi niz, uz unos pojedinih riječi, sastavljene rečenica
            2. Pronađite broj ponavljanja određenog niza u nizu riječi
              3. Provjerit e korisničko ime i lozinku, za unos imate tri pokušaja
              4.Ispiši polaznike seminara( koliko nas ima), od broja 1 do 10- ecvidencija polaznika/seminaru
              5. Izradite program koji  izračunava prosijek ocijena za unesen broj predmeta

             */
            //1
            // string[] recenica = { "Ovo","rečenica","neka","je"};
            //string[] dobarNiz = {recenica.S } ;
            /*Console.WriteLine("Upiši korisničko ime: ");
            int velicina= int.Parse(Console.ReadLine());
            string[] prviNiz=new string[velicina];
            string[] drugiNiz=new string[velicina];

            for (int i = 0; i < velicina; i++)
            {
                Console.WriteLine("unesi prvi niz ");
               string rijec= Console.ReadLine();
                prviNiz[i] = rijec;
                for (int j = 0; j < velicina; j++)
                {
                    drugiNiz[j] = prviNiz[i];
                }
                }*/
            //2
           /* string niz="";
            Console.WriteLine("Upiši niz znakova: ");
            niz= Console.ReadLine();
            string nizRjeci = "Ovo je nes";
            int brojPonavljanja = 0;
            int brojZnakova = nizRjeci.Length;
            for (int i = 0; i <= brojZnakova; i++)
            {
                if(nizRjeci.Substring(i, brojZnakova.Len))
            }*/

            //3 radi
                /*  Console.WriteLine("Upiši korisničko ime: ");
                  string korisnickoIme = Console.ReadLine();
                  Console.WriteLine("Upiši lozinku: ");
                  string lozinka = Console.ReadLine();

                  //zapravo dva prolaza kroz petlju ali pita tri puta
                  for(int i = 1; i <3; i++)
                  {
                      if(korisnickoIme=="iva" && lozinka=="12345")
                      {
                          Console.WriteLine("Logirani!!");
                          break;
                      }
                      else
                      {

                          Console.WriteLine("Greška!!");

                          Console.WriteLine("Upiši korisničko ime: ");
                          korisnickoIme = Console.ReadLine();
                          Console.WriteLine("Upiši lozinku: ");
                          lozinka = Console.ReadLine();

                      }
                  }*/

                //4
                ArrayList polaznici = new ArrayList();
            /* polaznici.Add("Pero");
             polaznici.Add("Petar");
             polaznici.Add("Marko");
             polaznici.Add("Marija");
             polaznici.Add("Darko");
             polaznici.Add("Zdenko");
             polaznici.Add("Zara");
             polaznici.Add("Mara");
             polaznici.Add("Bubamara");
             polaznici.Add("Ivanka");*/
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Upiši ime {0} polaznika: ",i);
                polaznici.Add(Console.ReadLine());
            }
            {
                Console.WriteLine("Imamo {0} polaznika u seminaru, a polaznici su: ", polaznici.Count);

                for (int i = 0; i < polaznici.Count; i++)
                {
                    Console.WriteLine(polaznici[i]);
                }

                //5 radi
                /*int ocjna = 0;
                Console.WriteLine("Upiši broj predmeta: ");
                int brojPredmeta = int.Parse(Console.ReadLine());

                for (int i = 1; i <= brojPredmeta; i++)
                {
                    Console.WriteLine("Upiši ocjenu za {0} predmet: ", i);
                    ocjna += int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Zbroj ocjena je: {0}", ocjna);
                double prosjek = ocjna / brojPredmeta;
                Console.WriteLine("Prosjek ocjena je: {0}", prosjek);
                */




            }
        }
    }
}
