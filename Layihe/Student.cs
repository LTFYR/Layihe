using Layihe.StudentInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Layihe
{
    class Student : Students    
    {
        public Student(string fullname, string groupno, string type) : base(fullname, groupno, type)
        {
        }

        public string Fullname { get =>  Fullname; set => Fullname=value; }
        public string GroupNo { get => GroupNo; set => GroupNo=value; }
        public string Type { get => Type; set => Type=value; }

        public void Display()
        {
            Console.WriteLine("Full Name"+ Fullname);
            Console.WriteLine("Group Number"+ GroupNo);
            Console.WriteLine("Odenisli ve ya Odenissiz"+ Type);
        }
    }


}
