using Layihe.Enum;
using Layihe.Telebeler;
using System;
using System.Collections.Generic;
using System.Text;

namespace Layihe
{
    class Group
    {
        public static int count=1;
        public string No;
        

       
        public Category Category;
        public bool IsOnline;
        public int Limit;

     
        public Group(int limit,bool isOnline,string no)
        {
          
            Limit = limit;
            No = no;
            IsOnline = false;
        }

        public Group(Category category)
        {
            switch (category)
            {
                case
                    Category.Programming:
                    No = $"P-{count}";
                    break;
                case 
                    Category.Design:
                    No = $"D-{count}";
                    break;
                case
                    Category.System_administration:
                    No = $"SA-{count}";
                    break;
                default:
                    break;
                    
            }
            
             Category = category;
             count++;

            //if (limit >= 15)
            //{
            //    IsOnline = true;
            //}
            //else if (limit <= 10)
            //{
            //    IsOnline = false;
            //}
                
            //else
            //{
            //    Console.WriteLine("Xeta bas verdi");
            //}
    }
            public override string ToString()
        {
            string status = IsOnline ? "Online" : "Offline";
            return $"Nomre: {No}, Kateqoriya: {Category} , Status: {status}";
        }
        
    }
}
