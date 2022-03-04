using Layihe.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Layihe.Groupmanager
{
    static class ManagerSer
    {
    public static Groupmanager groupmanager = new Groupmanager();
        public static void QrupYarat(Category category)
        {
            Console.WriteLine("Zehmet olmasa qrup secin");
            int Nostr;
            string No = Console.ReadLine();
            bool resultNo = int.TryParse(No, out Nostr);


            Console.WriteLine("Zehmet olmasa Ad ve Soyad daxil edin");
            int Fullname;
            string FullnameStr = Console.ReadLine();
            bool resultFullname = int.TryParse(FullnameStr, out Fullname);


            if (resultNo && resultFullname)
            {
                Console.WriteLine("Secin");
                foreach (Category categ in System.Enum.GetValues(typeof(Category)))
                {
                    Console.WriteLine($"{(int)categ}. {categ}");
                }
                
                {
                    switch (category)
                    {
                        case (Category)(int) Category.Programming:
                            string no  = groupmanager.QrupYarat(No, Fullname, Category.Programming);
                            Console.WriteLine($"{No} yaradildi");
                            break;
                        case Category.Design:
                            break;
                        case Category.System_administration:
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Yalnis melumat daxil edildi");
            }
        }


    }
}
