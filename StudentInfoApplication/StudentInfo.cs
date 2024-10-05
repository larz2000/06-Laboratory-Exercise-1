using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentNamespace
{
    internal class StudentInfo
    {
        //Instance variables
        private string student_ID;
        private string last_name;
        private string first_name;

        //Constructor
        public StudentInfo() 
        {
            this.student_ID = "Invalid";
            this.last_name = "Invalid";
            this.first_name = "Invalid";
        }
        //Overloaded Constructor
        public StudentInfo(string student_ID, string last_name, string first_name) 
        {
            this.StudentID = student_ID;
            this.StudentLastName = last_name;
            this.StudentFirstName = first_name;
        }

        //getter and setter
        public string StudentID 
        {
            get { return student_ID; }
            set { student_ID = value; }
        }

        public string StudentLastName
        {
            get { return last_name; }
            set { last_name = value; }
        }

        public string StudentFirstName
        {
            get { return first_name; }
            set { first_name = value; }
        }
    }
}
