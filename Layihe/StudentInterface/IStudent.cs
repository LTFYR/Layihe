using System;
using System.Collections.Generic;
using System.Text;

namespace Layihe.StudentInterface
{
     class Students
    {
        
        public string Fullname { get; set; }
        public string GroupNo { get; set; }
        public string Type { get; set; }


        public Students(string fullname,string groupNo,string type)
        {
            Fullname = fullname;
            GroupNo = groupNo;
            Type = type;

        }

        
    }



}

