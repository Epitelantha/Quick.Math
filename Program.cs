using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi");
            Console.WriteLine("would");
            Console.WriteLine("you");

            while (true)
            {
                Console.WriteLine("like"); Console.WriteLine("to");
                Console.WriteLine("do");
                break;
            }

            Console.WriteLine("some");
            Console.WriteLine("mafs? y/n");

            string hjkl = Console.ReadLine();

            while (true)            {
                if (hjkl == "y")
                {
                    Console.WriteLine("Alright, insert first value");
                    break;
                }
                else if(hjkl == "n") { 
                    while (true)
                    {
                        Console.WriteLine("Yes you do");
                        hjkl = "y";
                        break;
                    }
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine("You meant y");
                        hjkl = "y";
                        break;
                    }
                }
            }
             
            string theFirstInputPiece = Console.ReadLine();
            int first = Convert.ToInt32(theFirstInputPiece);
            if (int.TryParse(theFirstInputPiece, out first))
            {
                Console.WriteLine(theFirstInputPiece + ", okay, what's next?");
                string second = Console.ReadLine();
                int snd = Convert.ToInt32(second);
                if (int.TryParse(second, out snd))
                {
                    Console.WriteLine(theFirstInputPiece + " " + "and" + " " + second + "," + " " + "okay");

                    if (theFirstInputPiece == second)
                    {
                        while (true)
                        {

                        
                        int further = int.Parse(theFirstInputPiece);
                        int further2 = int.Parse(second);

                        int further3 = further + further2;
                        int multiplier = 10;
                        int khjdfg = further3 * multiplier;
                        Console.WriteLine(khjdfg);
                        int tkhjdfg = (khjdfg / 10) * 3;
                        Console.WriteLine(tkhjdfg);
                        Console.ReadLine();   break;
                            }
                    }
                    if (theFirstInputPiece != second){
                        while (true)
                        {
                            int trist = int.Parse(theFirstInputPiece);
                            int trister = int.Parse(second);

                            string resultmaybe = theFirstInputPiece + second;
                            Console.WriteLine(resultmaybe);
                            Console.WriteLine("no thats not it");

                            int hjfdk = (trist + 0) + trister + 0;
                            Console.WriteLine(hjfdk + ". This be the result.");
                            Console.WriteLine("Exiting app");
                            Console.WriteLine("Restart to go again");
                            Console.ReadLine();      break;
                        }
                    }
                }
            }

        }
    }


}