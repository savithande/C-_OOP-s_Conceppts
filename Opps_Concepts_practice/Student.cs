using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Opps_Concepts_practice
{
    class Student
    {
        private string studentName;
        private string studentPlace;
        private string phNumber;
        private string section;

        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }

        public string StudentPlace
        {
            get { return studentPlace; }
            set { studentPlace = value; }
        }

        public string PhoneNumber
        {
            get { return phNumber; }
            set { phNumber = value; }
        }

        public string Section
        {
            get { return section; }
            set { section = value; }
        }

    }
}
