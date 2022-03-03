using Layihe.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Layihe
{
    class Group
    {
        public static int count = 1;
        public string No;
        public Student[,] Students;

        public Group(Student[,] students)
        {
            Students = students;
        }

        public Category Category;
        public bool IsOnline;

        public Group(bool isOnline)
        {
            IsOnline = isOnline;
        }

        public int Limit;

        public Group(int limit)
        {
            Limit = limit;
        }
        

        

        public Group(Category category,int limit,string fullname,string groupNo,string type,Student students)
        {
            switch (category)
            {
                case Category.Programming:
                    No = "P-{count}";
                    break;
                case Category.Design:
                    No = "D-{count}";
                    break;
                case Category.System_administration:
                    No = "SA-{count}";
                    break;
                default:
                    break;
            }
            //Category = category;


            //Students = new Student[];
            //for (int i = 0; i < .Length; i++) ;
            //for (int j = 0; j <.Length ; j++)
            //{

            //}

            

        }
    }
}
