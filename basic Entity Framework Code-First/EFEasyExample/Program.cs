using System;
using System.Linq;
using System.Collections.Generic;
using EFEasyExample.DataModels;
using EFEasyExample.Enums;
using System.Security.Claims;

namespace EFEasyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using Context myContext = new Context();
            AddClasses(myContext);
            var myClasses = GetClasses(myContext);
            UpdateClass(myContext);
        }

        private static void UpdateClass(Context myContext)
        {
            var myClass = myContext
                .Classes
                .FirstOrDefault(c => c.MaxClassSize > 0);
            myClass.ClassName = "changed Name!";
            myContext.SaveChanges();
        }

        private static void AddClasses(Context myContext)
        {
            myContext.Students.Add(new Student()
            {
                StudentName = "Joe Smith",
                StudentClasses = new List<Class>()
                {
                     new Class()
                     {
                          ClassLanguage = Language.French,
                          ClassName = "myFirstClass",
                          MaxClassSize = 12
                     },
                     new Class()
                     {
                         ClassLanguage = Language.English,
                         ClassName = "mySecondClass",
                         MaxClassSize = 25
                     }
                 }
            });
            myContext.SaveChanges();
        }

        private static List<Class> GetClasses(Context myContext)
        {
            return myContext
                .Classes
                .Where(c => c.MaxClassSize > 0)
                .ToList();
            myContext.SaveChanges();
        }
    }
}