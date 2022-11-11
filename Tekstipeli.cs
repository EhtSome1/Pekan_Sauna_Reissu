using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            char vastaus;
            bool kirves = false;

            Console.WriteLine("+-----------------------------+");
            Console.WriteLine("|Pekan matka saunomaan        |");
            Console.WriteLine("|Tervetuloa tekstiseikkailuun!|");
            Console.WriteLine("+-----------------------------+");
            Console.WriteLine("Pelin tavoitteena on saada, sinut, Pekka turvallisesti saunaan. Valitse huolellisesti. ");


            Console.WriteLine("Olet hirsimökissä metsän reunalla lähdössä saunomaan, kunnes huomaat polttopuiden olevan loppu. Lähdetkö hakemaan lisää liiteristä? (Y/N) ");
            do
            {
                vastaus = Convert.ToChar(Console.ReadLine());

                if (vastaus != 'Y' && vastaus != 'N')
                {
                    Console.WriteLine("Annoit väärän vastauksen!");
                }
            } while  (vastaus != 'Y' && vastaus != 'N');

                if (vastaus == 'N')
                {
                    Console.WriteLine("Päätit olla menemättä saunaan. \nLoppu");
                Console.ReadLine();
                }

               
               else if (vastaus == 'Y')
                {
                    loop:
                    Console.WriteLine("Lähdet matkaan kohti liiteriä.");
                    Console.WriteLine("Edessäsi on kaksi polkua, yksi vasemmalle ja yksi oikealle. Kumman otat? (Vasen (Y) Oikea(N))");

                do
                {
                    vastaus = Convert.ToChar(Console.ReadLine());

                    if (vastaus != 'Y' && vastaus != 'N')
                    {
                        Console.WriteLine("Annoit väärän vastauksen!");
                    }
                } while (vastaus != 'Y' && vastaus != 'N');

                if (vastaus == 'Y')
                 {
                     Console.WriteLine("Lähdit vasemmalle. Vastaasi tulee kyy. Käännytkö takaisin (N) vai menetkö ohi (Y)?");

                    do
                    {
                        vastaus = Convert.ToChar(Console.ReadLine());

                        if (vastaus != 'Y' && vastaus != 'N')
                        {
                            Console.WriteLine("Annoit väärän vastauksen!");
                        }
                    } while (vastaus != 'Y' && vastaus != 'N');

                    if (vastaus == 'N')
                        {
                            Console.WriteLine("Hyvä valinta. Palaat risteykseen.");
                            goto loop;
                        }
                        else if (vastaus == 'Y')
                       {
                        Console.WriteLine("Koitat mennä ohi, mutta kyy puraisee sinua. \nLoppu");
                        Console.ReadLine();
                       }
                  }
                  else if (vastaus == 'N')
                  {
                    Console.WriteLine("Päätit mennä oikealle. Kävelet muutaman minuutin eteenpäin. \nNäet kirveen. \nMietit: Miksi täällä on kirves? \n Otatko kirveen mukaan? (Y/N)");
                    do
                    {
                        vastaus = Convert.ToChar(Console.ReadLine());

                        if (vastaus != 'Y' && vastaus != 'N')
                        {
                            Console.WriteLine("Annoit väärän vastauksen!");
                        }
                    } while (vastaus != 'Y' && vastaus != 'N');

                    if (vastaus == 'Y')
                    {
                        Console.WriteLine("Päätit ottaa kirveen mukkan.");
                        kirves = true;
                    }
                    else if (vastaus == 'N')
                    {
                        Console.WriteLine("Päätit olla ottamatta kirvestä mukaasi.");
                        kirves = false;
                    }
                    loop2:
                    Console.WriteLine("Jatkat matkaa. Edessäsi on uusi risteys. Käännytkö vasemmalle vai oikealle (Vasen (Y) Oikea(N))");
                    do
                    {
                        vastaus = Convert.ToChar(Console.ReadLine());

                        if (vastaus != 'Y' && vastaus != 'N')
                        {
                            Console.WriteLine("Annoit väärän vastauksen!");
                        }
                    } while (vastaus != 'Y' && vastaus != 'N');

                    if (vastaus == 'N')
                    {
                        Console.WriteLine("Putosit rotkoon. \nLoppu");
                        Console.ReadLine();
                    }
                    else if (vastaus == 'Y')
                    {
                        Console.WriteLine("Käännyit vasemmalle. Vastaan tulee liiteri");
                        if (kirves)
                        {
                            loop3:
                            Console.WriteLine("Liiterillä ei ollut kirvestä, hyvä että otit sen mukaan. Alat pilkkomaan puita. Kuinka monta halkoa teet? (Syötä luku)");
                            int halot = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Menet saunalle puiden kanssa.");

                            if (halot <= 6)
                            {
                                Console.WriteLine("Halot eivät riitä. Palaat hakemaan lisää.");
                                goto loop3;
                            }
                            else if (halot >= 7)
                            {
                                Console.WriteLine("Toit tarpeeksi halkoja ja alat lämmittämään saunaa.");
                                Console.WriteLine("Odotat 15min. Sauna on lämmin.");

                                Console.WriteLine("Läpäisit pelin! \nLoppu");
                                Console.ReadLine();
                            }
                        }
                        else if (!kirves)
                        {
                            Console.WriteLine("Liiterille ei ole kirvestä, muistat että menit kirveen ohi.");
                            Console.WriteLine("Lähdetkö hakemaan kirvestä (Y/N)");
                            do
                            {
                                vastaus = Convert.ToChar(Console.ReadLine());

                                if (vastaus != 'Y' && vastaus != 'N')
                                {
                                    Console.WriteLine("Annoit väärän vastauksen!");
                                }
                            } while (vastaus != 'Y' && vastaus != 'N');

                            if (vastaus == 'Y')
                            {
                                Console.WriteLine("Lähdit hakemaan kirvestä");
                                kirves = true;
                                goto loop2;
                            }
                            else if (vastaus == 'N')
                            {
                                Console.WriteLine("Päätit olla menemättä hakemaan kirvestä ja istut loppuillan kylmässä saunassa. Kun istut saunassa mietit elämän valintojasi");
                                Console.ReadLine();
                            }
                        }
                    }

                }
             }             
        }
    }
}