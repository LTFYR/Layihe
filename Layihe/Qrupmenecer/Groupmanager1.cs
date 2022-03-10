
using Layihe.Enum;
using Layihe.Interface;
using Layihe.Telebeler;
using System;
using System.Collections.Generic;
using System.Text;

namespace Layihe.Groupmanager
{
    class Groupmanager : IGroupmanager1
    {
        private List<Group> groups = new List<Group>();
        public List<Group> Group => groups;

        public string QrupYarat(Category category)
        {
            Group group=new Group(category);

            groups.Add(group);

            return group.No;

            
        }

        public void ButunTelebelerinSiyahisi(string no)
        {
            if (telebeler.Count == 0)
            {
                Console.WriteLine("Telebe yaradilarken xeta bas verdi");

            }
            foreach (Student telebe in telebeler)
            {
                Console.WriteLine(telebe);
                
               
            }
        }

        public void DuzelisEt()
        {
            
        }

        public string ProqramdanCixis()
        {
            throw new NotImplementedException();
        }

        public void QrupdakiTelebelerinSiyahisi()
        {
            

        }

        public void Qruplarinsiyahisi()
        {
            if (groups.Count == 0)
            {
                Console.WriteLine("Hazirda hec bir qrup movcud deyil");
                return;
            }
           
            
            foreach (Group qrup in groups)
            {
                Console.WriteLine(qrup);
            }
        }
        private List<Student> telebeler = new List<Student>();
        public List<Student> Students => telebeler;

        public string TelebeYarat(string fullname, string groupno,Odenis odenis)
        {
            Student student = new Student(odenis);
            telebeler.Add(student);
            return fullname + groupno+ odenis;
        }





     
        public string QrupYarat(Category category, int limit, string fullname, string groupNo, string type, Student student)
        {
            throw new NotImplementedException();
        }

        public string TelebeYarat(string fullname, string groupNo)
        {
            throw new NotImplementedException();
        }

        public void ButunTelebelerinSiyahisi()
        {
            throw new NotImplementedException();
        }

        //public void ButunTelebelerinSiyahisi(string no)
        //{
        //    if (telebeler.Count == 0)
        //    {
        //        Console.WriteLine("Telebe yaradilarken xeta bas verdi");
        //        return;
        //    }
        //    foreach (Student telebe in telebeler)
        //    {
        //        Console.WriteLine(telebe);
        //        return;
        //    }
        //}




        //internal string QrupYarat(string no, int fullname, Category programming)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
