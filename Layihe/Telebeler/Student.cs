
using Layihe.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Layihe.Telebeler
{
    class Student
    {
        public string Fullname, GroupNo, No;
        public Odenis Odenis { get; }
        public static int count = 1;
        public Student(string no)
        {
            No=no;
        }

        public Student(Odenis odenis)
        {
            switch (odenis)
            {
                case Odenis.Odenisli:
                     No = $"Odenisli-{count}";
                    break;
                case Odenis.Odenissiz:
                    No = $"Odenissiz-{count}";
                    break;
                default:
                    Console.WriteLine("Zehmet olmasa Odenisli yaxud Odenissiz bolmelerinden birini secin");
                    break;
            }
            Odenis = odenis;
            count++;
        }
         
        public Student(string fullname, string groupNo)
        {
            Fullname = fullname;
            GroupNo = groupNo;
        }
        //public void Display()
        //{
        //    Console.WriteLine("Ad ve soyadi" + Fullname);
        //    Console.WriteLine("Qrup nomresi" + GroupNo);
        //    Console.WriteLine("Odenisli ve ya Odenissiz" );
        //}
        public override string ToString()
        {
            return $"Fullname: {Fullname} GroupNo: {GroupNo} Tyoe{Odenis}";
        }
       
    }
}
