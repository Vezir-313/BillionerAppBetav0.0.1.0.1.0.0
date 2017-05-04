using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillionerAppBeta
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] SuallarArr =
            {
                "Ilin en yaxwi startupi???",
                "Ayin en yaxwi startupi",
                "Gunun en yaxwi startupi???",
                "Saatin en yaxwi startupi?",
                "Heftenin en yaxwi startupi??",
                "Esrin en yaxwi startupi?",
                "Kainatin en yaxwi startupi?",
                "Eranin en yaxwi startupi?",
                "Eradan evvelki en yaxwi startup?",
                "ImagineCup-in en yaxwi startupi?"
            };
            string[] Cavablar = 
                {
                   
                    "ZoomX,Jabda,WakeMeUp,Fazil,Jessy"
                   ,

                    "Jabda,WakeMeUp,Fazil,Jessy,ZoomX"
                   ,

                    "ZoomX,Jabda,WakeMeUp,Fazil,Jessy"
                   ,

                    "ZoomX,Jabda,WakeMeUp,Fazil,Jessy"
                   ,

                    "ZoomX,Jabda,WakeMeUp,Fazil,Jessy"
                   ,

                    "ZoomX,Jabda,WakeMeUp,Fazil,Jessy"
                   ,

                    "ZoomX,Jabda,WakeMeUp,Fazil,Jessy"
                   ,

                   "ZoomX,Jabda,WakeMeUp,Fazil,Jessy"
                   ,

                    "ZoomX,Jabda,WakeMeUp,Fazil,Jessy"
                   ,

                    "ZoomX,Jabda,WakeMeUp,Fazil,Jessy"

                };
            string[] duzgunCavablar =
            {
                "ZoomX","ZoomX","ZoomX","ZoomX","ZoomX","ZoomX","ZoomX","ZoomX","ZoomX","ZoomX"
            };
            int xal = 0;
            for (int i = 0; i < duzgunCavablar.Length; i++)
            {
                bool next = true;
                var task = new Suallar(i + 1, SuallarArr[i], Cavablar[i], duzgunCavablar[i]);
                //task.qatisdir();
                Console.WriteLine(task.id + ") " + task.sual + "\n");
                for (int j = 0; j < task.cavablar.Length; j++)
                {
                    Console.WriteLine((char)((int)'a' + j)+") "+task.cavablar[j]);
                    
                }
                Console.Write("Duzgun cavabi daxil et:");
                string a;
                int cem = 0;
                while (true)
                {
                    a = Console.ReadLine();
                    if (((int)'a' <= (int)a[0]) && ((int)'e' >= (int)a[0]))
                    {
                        break;
                    }
                    else
                    {
                        cem++;
                        Console.WriteLine();
                        if (cem<3)
                        {
                            Console.WriteLine("Duzgun formatda varianti daxil edin..Mes:\" a , b, c, d, e \"");
                        }
                        else
                        {      
                            Console.WriteLine("Sen nece adamsan ala herfleri tanimirsan??? cix proqramnan...");
                            next = false;
                            break;
                        }
                        
                        Console.Write("Duzgun cavabi daxil et:");

                    }
                }
                if (next == false) break;
                int index = (int)a[0] - (int)'a';

                if(task.cavablar[index] == task.duzgunCavab)
                {
                    xal=xal+10;
                }
                Console.WriteLine("\n");                
            }
            Console.Write("SIZIN XALINIZ: " + xal +" ");
            switch (xal)
            {
                case 0: Console.WriteLine("COXXXX PISSS");
                    break;
                case 10:
                    Console.WriteLine("BERBADDD");
                    break;
                case 20:
                    Console.WriteLine("COXX ZEIF");
                    break;
                case 30:
                    Console.WriteLine("ZEIF");
                    break;
                case 40:
                    Console.WriteLine("COXXXX PISSS");
                    break;
                case 50:
                    Console.WriteLine("PISSS");
                    break;
                case 60:
                    Console.WriteLine("BIRAZ PISSS");
                    break;
                case 70:
                    Console.WriteLine("NARMAL");
                    break;
                case 80:
                    Console.WriteLine("YAXWIIII");
                    break;
                case 90:
                    Console.WriteLine("BABATTTTT");
                    break;
                case 100:
                    Console.WriteLine("ITDIDEEE BU UWAGGG");
                    break;
                default:
                    break;
            }


        }
    }
    class Suallar
    {
        public int id;
        public string sual;
        public string[] cavablar;
        public string duzgunCavab;
        public Suallar(int id,string sual,string cavablar,string duzgunCavab)
        {
            this.id = id;
            this.sual = sual;
             this.cavablar= cavablar.Split(',');
            Qarisdir(this.cavablar);
            this.duzgunCavab = duzgunCavab;


         
        }

        static Random _random = new Random();

        static void Qarisdir<T>(T[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {

                int r = i + (int)(_random.NextDouble() * (n - i));
                T t = array[r];
                array[r] = array[i];
                array[i] = t;
            }
        }

    }

}
