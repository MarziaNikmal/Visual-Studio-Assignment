using System;
using System.Collections.Generic;
using System.Text;

namespace EFEasyExample.DataModels
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; }
        public List<Class> StudentClasses { get; set; }
    }
}