using Layihe.Enum;
using Layihe.Groupmanager;
using Layihe.Telebeler;
using System;
using System.Collections.Generic;
using System.Text;

namespace Layihe.Interface
{
    class GroupManager1
    {
        private List<Group> groups = new List<Group>();
        public List<Group> Group => groups;

        public string QrupYarat(Category category)
        {
            Group group = new Group(category);

            groups.Add(group);

            return group.No;


        }

        public void ButunTelebelerinSiyahisi(string no)
        {            
            if(telebeler.Count == 0)
            {
                Console.WriteLine("Sistemde hec bir telebe yoxdur");
            }
            foreach (Student telebe in telebeler)
            {
                Console.WriteLine(telebe);
               
            }
        }

        public void DuzelisEt(string no, string newNo)
        {
            Group movcudQrup = SearchGroup(no);
            
            if (movcudQrup == null)
            {
                Console.WriteLine("Yanlis qrup nomresi daxil edildi");
                return;
            }
            foreach (Group qrup in groups)
            {
                if (qrup.No.ToLower().Trim() == newNo.ToLower().Trim())
                {
                    Console.WriteLine("Bele bir qrup hazirda var");
                    return;
                }
            }
            movcudQrup.No = newNo.ToUpper();
            Console.WriteLine($"{no} {newNo}-a deyisdirildi");
        }
        public Group SearchGroup(string no)
        {
            foreach (Group qrup in groups)
            {
                if (qrup.No.ToLower().Trim() == no.ToLower().Trim())
                {
                    return qrup;
                }
            }
            return null;
        }
        //public Group SearchForStudent(string no,string newNo)
        //{
        //    Group movcudQrup = Group;
        //    foreach (Group qrup in groups)
        //    {
        //        if (qrup.No.ToLower().Trim() == no.ToLower().Trim())
        //        {
        //            return qrup;
        //        }
        //    }
        //    if (movcudQrup == null)
        //    {
        //        Console.WriteLine("Yanlis qrup nomresi daxil edildi");
        //        return;
        //    }
        //    foreach (Group qrup in groups)
        //    {
        //        if (qrup.No.ToLower().Trim() == newNo.ToLower().Trim())
        //        {
        //            Console.WriteLine("Bele bir qrup hazirda var");
        //            return;
        //        }
        //    }
            //movcudQrup.No = newNo.ToUpper();
            //Console.WriteLine($"{no} {newNo}-a deyisdirildi");
            ////}



            public string ProqramdanCixis()
        {
            throw new NotImplementedException();
        }

        public void QrupdakiTelebelerinSiyahisi()
        {
            throw new NotImplementedException();
        }

        public void Qruplarinsiyahisi()
        {
            if (groups.Count == 0)
            {
                Console.WriteLine("Hazirda her hansi bir qrup movcud deyil");
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
            return fullname + groupno + odenis;
        }

        internal string TelebeYarat(Odenis odenisli)
        {
            throw new NotImplementedException();
        }
    }
}
