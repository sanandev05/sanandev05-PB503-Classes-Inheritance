using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB503_Classes
{
    public class Student : Human
    {
        public double Grant;

        public Student(string name, string surname) : base(name, surname)
        {
        }
       
        public Student(string name, string surname, double grant) : this(name, surname)
        {
            Grant=grant;
        }
      
    }
}
