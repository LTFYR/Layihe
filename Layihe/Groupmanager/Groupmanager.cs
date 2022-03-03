
using Layihe.Enum;
using Layihe.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Layihe.Groupmanager
{
    class Groupmanager : IGroupmanager
    {
        private List<Group> groups = new List<Group>();
        public List<Group> Group => groups;

        public string QrupYarat(Category category, int limit, string fullname, string groupNo, string type, Student student)
        {
            Group group=new Group(category,limit,fullname,groupNo,type,student);

            groups.Add(group);

            return groupNo;

            
        }

        public void ButunTelebelerinSiyahisi()
        {
            throw new NotImplementedException();
        }

        public string DuzelisEt()
        {
            throw new NotImplementedException();
        }

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
            throw new NotImplementedException();
        }

        public string TelebeYarat()
        {
            throw new NotImplementedException();
        }
    }
}
