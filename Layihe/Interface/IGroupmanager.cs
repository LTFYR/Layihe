using Layihe.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Layihe.Interface
{
    interface IGroupmanager
    {
        List<Group> Group { get; }
        public string QrupYarat(Category category, int limit, string fullname, string groupNo, string type, Student student);
        public void Qruplarinsiyahisi();
        public string DuzelisEt();
        public void QrupdakiTelebelerinSiyahisi();
        public void ButunTelebelerinSiyahisi();
        public string TelebeYarat();
        public string ProqramdanCixis();
    }
}
