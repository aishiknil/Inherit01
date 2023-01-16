using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Application
{
    public class Inherit1
    {
        public string firstName = "Aishik";
        public string lastName = "Bera";
        public void FName()
        {
            System.Console.WriteLine("First Name: "+firstName);
        }
    }
    public class Inherit2 : Inherit1
    {
        public void Lname()
        {
            System.Console.WriteLine("Last Name: "+lastName);
        }
    }
    public class Inherit3 : Inherit2
    {
        public void Fullname()
        {
            System.Console.WriteLine("Full Name: "+firstName+" "+lastName);
        }
    }
}