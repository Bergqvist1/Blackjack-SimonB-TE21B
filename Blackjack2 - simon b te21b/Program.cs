using System;
using System.Globalization;

namespace Blackjack_21
{
    class Program
    {
        static void Main(string[] args)
        {

            Random slumpkort = new Random();

            Console.WriteLine("Välkommen till blackajack");

            string senastevinnare = " ";
            string menyVal = "0";
            while (menyVal != "4")
            {
                Console.WriteLine("Välj ett alternativ");
                Console.WriteLine("1: Spela Blackjack");
                Console.WriteLine("2: Visa senaste vinnaren");
                Console.WriteLine("3: Visa spelets regler");
                Console.WriteLine("4: Avsluta programmet");

                menyVal = Console.ReadLine();
                switch (menyVal)
                {
                    case "1":


                        int datornsPoäng = 0;
                        int spelarensPoäng = 0;
                        string spelareVal = "";
                        Console.WriteLine("Välkommen till BlackJack, du och datorn kommer att få 2 slumpmässiga kort.");
                        datornsPoäng += slumpkort.Next(1, 11);
                        datornsPoäng += slumpkort.Next(1, 11);
                        spelarensPoäng += slumpkort.Next(1, 11);
                        spelarensPoäng += slumpkort.Next(1, 11);

                        while (spelareVal != "n" && spelarensPoäng <= 21)
                        {

                            Console.WriteLine("Datorns poäng är:" + " " + datornsPoäng);
                            Console.WriteLine("Dina poäng är:" + " " + spelarensPoäng);
                            Console.WriteLine("Vill du dra ett till kort? svara med j eller n");
                            spelareVal = Console.ReadLine();

                            switch (spelareVal)
                            {



                                case "j":
                                    int extrakort = slumpkort.Next(1, 11);
                                    spelarensPoäng += extrakort;
                                    Console.WriteLine("Du drog en:" + " " + extrakort + "a");
                                    Console.WriteLine("Ditt nya totala poäng är:" + spelarensPoäng);
                                    break;


                                case "n":

                                  if (spelarensPoäng > 21)
                                  {

                                    Console.WriteLine("Du har tyvärr förlorat");
                                    break;
                                  }

                                 while (datornsPoäng < spelarensPoäng && datornsPoäng <= 18)
                                 {

                                      int datorextrakort = slumpkort.Next(1, 11);
                                      datornsPoäng += datorextrakort;
                                      Console.WriteLine("Datorn drog en" + " " + datorextrakort + "a");
                                 }

                                 Console.WriteLine("Dina poäng är:" + " " + spelarensPoäng);
                                 Console.WriteLine("Datorns poäng är:" + " " + datornsPoäng);

                                    if (datornsPoäng > 21)
                                    {
                                       Console.WriteLine("Grattis du har vunnit över datorn ");
                                       Console.WriteLine("Skriv ditt namn så vi man kan se vem senaste vinnaren är");
                                       senastevinnare = Console.ReadLine();
                                       
                                    }


                                    if (spelarensPoäng >= datornsPoäng && spelarensPoäng <= 21)
                                    {
                                        Console.WriteLine("Grattis du har vunnit mot datorn xd");
                                        Console.WriteLine("Skriv ditt namn så vi man kan se vem senaste vinnaren är");
                                        senastevinnare = Console.ReadLine();
                                    }

                                    if (spelarensPoäng == datornsPoäng)
                                    {
                                        Console.WriteLine("Det blev lika sämst");
                                    }

                                    if (datornsPoäng >= spelarensPoäng && datornsPoäng <= 21)
                                        Console.WriteLine("Du förlorade mot en datorn din NPC");
                                    break;

                                   
                                default:
                                    Console.WriteLine("Välj ett av alternativen");
                                    break;
                            }


                        }
                        break;
                       
                        
                      
                    case "2":
                        Console.WriteLine("Senaste vinnaren är"+ " " + senastevinnare);
                        break;

                    case "3":
                        Console.WriteLine("Spelets regler är:");
                        Console.WriteLine("Ditt mål är att få 21 poäng eller under.");
                        Console.WriteLine("Du ska också få mer än datorns poäng fast måste vara under 21 poäng");
                        Console.WriteLine("Allt över 21 poäng = förlust");
                        Console.WriteLine("Både du och datorn kommer att få 2 kort i början därefter får du välja om du vill fortsätta dra kort");
                        Console.WriteLine("När du inte vill dra mer kort är det datorns tur att dra kort");
                        Console.WriteLine("Datorn kommer att dra kort tills den har mer poäng än dig, över 21 eller om datorns poäng är mellan 18-21 ");
                        break;

                    case "4":
                        Console.WriteLine("Hejdå :)");
                        break;

                    default:
                        Console.WriteLine("Du valde inte ett av alternativen");
                        break;
                }
            }

        }
    }
}