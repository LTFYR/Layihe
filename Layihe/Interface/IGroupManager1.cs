using Layihe.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Layihe.Interface
{
    internal interface IGroupManager1
    {
        List<Group> Group { get; }
        public string QrupYarat(Category category,string fullname, string groupNo);
        public void Qruplarinsiyahisi();
        public void DuzelisEt();
        public void QrupdakiTelebelerinSiyahisi();
        public void ButunTelebelerinSiyahisi();
        public string TelebeYarat(string fullname, string groupno);
        public string ProqramdanCixis();
    }
}
