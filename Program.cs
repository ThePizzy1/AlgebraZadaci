using System.Collections;

namespace AlgebraZadaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //projekt za izradu zadataka
            #region 19.03
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
            #endregion
            #region 24.3
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
            /*  ArrayList polaznici = new ArrayList();
              //unos imena polaznika
              for (int i = 1; i < 10; i++)
              {
                  Console.WriteLine("Upiši ime {0} polaznika: ",i);
                  polaznici.Add(Console.ReadLine());
              }
              //koliko sad ima polaznika
                  Console.WriteLine("Imamo {0} polaznika u seminaru, a polaznici su: ", polaznici.Count);
              //Prolazimo kroz sve polaznike i gledamo dali su prisutni
                  for (int i = 0; i < polaznici.Count; i++)
                  {
                      Console.WriteLine("Jeli {0} prisutna?",polaznici[i]);
                  var polaznik=polaznici[i];
                      ConsoleKeyInfo van = Console.ReadKey();
                      if (van.Key == ConsoleKey.F)//ako nisu kliknemo f false i izbriše ih
                      {
                          polaznici.Remove(polaznik);
                      //polaznici.RemoceAt(i);
                      /*Brišemo Marka u svakoj
                       * Standard     ReamoveAt(i)     Remove(obj)    
                       1 Marko        Ivana             -----  
                       2 Ivana        Pero             Ivana   
                       3 pero                          Pero   

                      }
                  }
               //ponovno koliko ih ima
                  Console.WriteLine("Imamo {0} polaznika u seminaru, a prisutni polaznici su: ", polaznici.Count);
              //ispis prisutnih
                  for (int i = 0; i < polaznici.Count; i++)
                  {
                      Console.Write( polaznici[i]+", ");

                  }
            */




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

            #endregion
            #region 26.03
            //26.03.2026
            /*
             1.Petlja koja uspoređuje nizove životinja
            2.Prikažite obrazac poput piramide s brojevima uvećanima za 1
            3.Poredaj unešeni niz u rastućem redosljedu
            4.Ispis naprednih brojeva koji su veći od 1,a manji od 20
            5.Ispis brojeva iz intervala [1,300] koji su djeljivi sa pet

             */
            //1 radi
            /*string[] zivotinjaA = { "kornjača", "mačka", "miš" };
            string[] zivotinjaB = { "pas", "mačka", "miš" };
            List<string> iste=new List<string>();
            foreach (var a in zivotinjaA) 
            { 
                foreach(var b in zivotinjaB)
                {
                    if(a == b) { iste.Add(b); }
                }
            }
            foreach (var i in iste)
            { 
                Console.WriteLine(i);
            }*/
            //2 radi
            /*
            Console.WriteLine("Upiši broj ponavljanja:");
            int max= int.Parse(Console.ReadLine());
           List<int> lista = new List<int>();
            for (int i = 1; i <= max; i++) 
            {
                lista.Add(i);
                foreach(var x in lista)
                {
                   
                    Console.Write(x);
                    
                }
                Console.Write("\n");
            }*/
            //3
            /* int[] niz = {2,5,8,1,6 };
             /* niz.Sort();
              foreach (int i in niz) {
                  Console.WriteLine(i);
              }
             for (int i = 0; i < niz.Length; i++) 
             {

                 for (int j = 0; j < niz.Length; j++)
                 {

                     int iVar = niz[i];
                     int jVar = niz[j];
                     if (iVar < jVar)
                     {

                         int temp = niz[j];
                         niz[j] = niz[i];
                         niz [i] = temp;

                     }
                 }
             }
             foreach (int i in niz)
             {
                 Console.WriteLine(i);
             }*/
            /*
             * Korak	i	j	Uvjet	Novi niz
                1	0	1	2 < 5	[5, 2, 8, 1, 6]
                2	0	2	5 < 8	[8, 2, 5, 1, 6]
                3	1	0	2 < 8	[2, 8, 5, 1, 6]
                4	2	1	5 < 8	[2, 5, 8, 1, 6]
                5	3	0	1 < 2	[1, 5, 8, 2, 6]
                6	3	1	2 < 5	[1, 2, 8, 5, 6]
                7	3	2	5 < 8	[1, 2, 5, 8, 6]
                8	4	3	6 < 8	[1, 2, 5, 6, 8]
             */
            //4 radi
            /*
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0 && i != 2)
                {
                    Console.Write(", " + i);
                }
                else if (i % 2 == 0 && i == 2) { Console.Write(i); }

            }*/
            //5 radi
            /*
             for (int i = 1; i <= 300; i++) 
             {
                 if (i % 5 == 0 &&i!=5)
                 {
                     Console.Write(", "+i);
                 }
                 else if(i % 5 == 0 && i == 5) {  Console.Write(i); }

             }*/
            #endregion
            #region 31.3
            /*
             1.Primjer metode koja broji razmake izmešu riječi. Unos nekoliko rečenica.
            2.Primjer metode koja barata sa kolekcijama za ispis riječi u rečenici obrnuto.
            3. Primjer metode za zamjenu mjesta najvećeg i najmanjeg broja
            4.Primjer metode koja određuje da li je broj djeljiv sa nekim brojem
             */
            //1 radi
            /* Console.WriteLine("Upiši rečenicu:");
             string recenica=Console.ReadLine();
             BrojanjeRazmakaUnutarRecenice(recenica);*/
            //2 radi
            /* List<string> rijeci=new List<string>();
              rijeci.Add("Ovo");
              rijeci.Add("je");
              rijeci.Add("Ivin");
              rijeci.Add("Projekt");
              rijeci.Add("!");
              IspisRijeciObrnuto(rijeci);*/
            //4
            /*Console.WriteLine("Upiši broj:");
            int broj = int.Parse(Console.ReadLine());
            Console.WriteLine("Upiši djeljitelj:");
            int djeljitelj = int.Parse(Console.ReadLine());
            DaliJeBrojDjeljiv(broj, djeljitelj);
           */


            //3. radi
            /*   List<int> list = new List<int>();
                   list.Add(1);
                   list.Add(5);
                   list.Add(7);
                   list.Add(4);
                   list.Add(10);
                 List<int> result= new List<int>();
                 result= ReplaceNumberPlaces(list);
                 foreach (int i in result) 
                 {
                     Console.WriteLine(i);
                 }*/
            #endregion
            #region 2.4
            /*
             1. Primjer istoimene metode sa različitim tipovima podataka i/ili parametrima
             2. Primjer metode koja otkriva da li je neka riječ palindrom(isto se piše odostraga
             3. Primjer rekurzivne metode za iscrtavanje obiteljskog stabla
             */
            //1
            /*
            IstoimenaMetoda(word: "Pero");
            IstoimenaMetoda(1, 2);
            IstoimenaMetoda(1F, 3F);
            */
            //2
           /* string word = "iva";
            IsTheWordPalindrome(word);*/
            //3
            FamilyTree("pero", 3);
            #endregion
            #region 7.4


            #endregion
        }
        //1.
        static void IstoimenaMetoda(string word) 
        {
            Console.WriteLine(word);
        }
        static void IstoimenaMetoda(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        static float IstoimenaMetoda(float a, float b)
        {
            return a + b;
        }
        //2.
        static void IsTheWordPalindrome(string word)
        {
            char element=' ';
           
            for (int i = word.Length - 1; i >= 0; i--) 
            {
                element = word[i];
                
            }
            Console.WriteLine(element);
        }
        //3.
        //name - ime prve osobe u stablu
        static void FamilyTree(string name,int nuberofbranches)
        {
            List<string> list = new List<string>();
            List<int> numberOfPeople= new List<int>();
            do
            {
               
                Console.WriteLine("Broj rodbine: ");
                int numberOfAncesstors = int.Parse(Console.ReadLine());
                numberOfPeople.Add(numberOfAncesstors);
                for (int i = 0; i < numberOfAncesstors; i++)
                {
                    Console.WriteLine("Upiši ime osobe: ");
                    string nameOfAncesstor = Console.ReadLine();
                    list.Add(nameOfAncesstor);
                }
                nuberofbranches--;

            }
            while (nuberofbranches > 0);
           
            int offset = 0;

            Console.Write(name+"\n");
            
            for (int i=0; i < numberOfPeople.Count; i++)
            {
                for (int j = 0; j < numberOfPeople[i]; j++)
                {   
                        Console.Write(" ");
                    
                    Console.Write(list[offset + j] + " ");
                }
                offset += numberOfPeople[i];
                Console.WriteLine();
            }
            
        }
        //3
        static List<int> ReplaceNumberPlaces(List<int> list)
        {
            List<int> result = new List<int>();
            result = list;
            int maxValue = result.Max();
            int minValue = result.Min();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == minValue)
                {
                    result[i] = maxValue;
                }
                else if (list[i] == maxValue)
                {
                    result[i] = minValue;
                }
            }


            return result;
        }
        //1
        static void BrojanjeRazmakaUnutarRecenice(string recenica)
        {
            int brojac = 0;
            for(int i = 0; i < recenica.Length; i++)
            {
                if (recenica[i]== ' ')
                {
                    brojac++;
                }
            }
            Console.WriteLine("Broj ponavljanja: " + brojac);
        }
        //2
        static void IspisRijeciObrnuto(List<string> rijeci)
        {
            List<string> obrnutaLista=new List<string>();
            for(int i=rijeci.Count-1; i>=0; i--)
            {
                obrnutaLista.Add(rijeci[i]);
            }
            foreach(var l in obrnutaLista)
            {
                Console.WriteLine(l);
            }
        }
        //4
        static void DaliJeBrojDjeljiv(int broj, int djelitelj)
        {
            if (broj % djelitelj == 0)
            {
                Console.WriteLine($"{broj} je djeljiv sa {djelitelj}.");
            }
            else
            {
                Console.WriteLine($"{broj} je djeljiv sa {djelitelj}.");
            }
        }
        static List<int> GenarateNumersInRange(int start, int end, int iterator)
        {
            List<int> numberList=new List<int>();
            for(int i = 0; i <= iterator; i++)
            {
                numberList.Add(new Random().Next(start,end));
            }
            return numberList;
        }
    }
}
