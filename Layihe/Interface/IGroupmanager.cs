using Layihe.Enum;
using Layihe.Telebeler;
using System;
using System.Collections.Generic;
using System.Text;

namespace Layihe.Interface
{
    interface IGroupmanager1
    {
        List<Group> Group { get; }
        public string QrupYarat(Category category, int limit, string fullname, string groupNo, string type,Student student);
        public void Qruplarinsiyahisi();
        public void DuzelisEt();
        public void QrupdakiTelebelerinSiyahisi();
        public void ButunTelebelerinSiyahisi();
        public string TelebeYarat(string fullname, string groupNo,Odenis odenis);
        public string ProqramdanCixis();
    }
}
