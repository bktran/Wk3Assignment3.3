using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3Assignment3._3
{
    enum MonthOfAdmission
    { 
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December,
    }

    enum Grade
    { 
        A = 1,
        B,
        C,
        D,
        F,
    }
    internal class Student
    {
        private static int IDcounter = 0;
        public  int ID{ get; }
        public Student()
        { 
            ID = IDcounter + 1;
            IDcounter++;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public Grade Grade { get; set; }
        public MonthOfAdmission AdmissionMonth { get; set; }
    }
}
