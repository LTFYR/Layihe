using Layihe.Enum;
using Layihe.Groupmanager;
using Layihe.Interface;
using System;

namespace Layihe
{
    internal class Program
    {
        private static string fullname;
        private static string groupNo;
        private static string no;
        private static string newNo;
        static void Main(string[] args)
        {
            


            int selection;

            do
            {
                Console.WriteLine("+--------------------------------+");
                Console.WriteLine("| Course Managment Application   |");
                Console.WriteLine("+--------------------------------+");
                Console.WriteLine("|1. Yeni qrup yarat              |");
                Console.WriteLine("|2. Qruplarin siyahisini goster  |");
                Console.WriteLine("|3. Qrupa duzelis etmek          |");
                Console.WriteLine("|4. Qrupdaki telebelerin siyahisi|");
                Console.WriteLine("|5. Butun telebelerin siyahisi   |");
                Console.WriteLine("|6. Telebe yarat                 |");
                Console.WriteLine("|0. Cixis                        |");
                Console.WriteLine("+--------------------------------+");
                Console.Write("Seciminiz: \n");





                string strSelection = Console.ReadLine();
                bool result = int.TryParse(strSelection, out selection);

                if (result)
                {
                    switch (selection)
                    {
                        case 1:
                            ManagerSer.QrupYaratMenu();
                            break;
                        case 2:
                            ManagerSer.Qruplarinsiyahisi();
                            break;
                        case 3:
                            ManagerSer.DuzelisEtMenu();

                            break;
                        case 4:

                            break;
                        case 5:
                            ManagerSer.ButunTelebelerinSiyahisiMenu();

                            break;
                        case 6:
                            ManagerSer.TelebeYaratMenu();
                            break;
                        case 0:
                            break;
                        default:
                            Console.WriteLine("Yanlis melumat daxil edildi");
                            break;
                    }
                }
            }

            while (selection != 0);

        }
    }
    
}
