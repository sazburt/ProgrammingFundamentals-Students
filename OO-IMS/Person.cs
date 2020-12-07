﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OO_IMS
{
    public class Person
    {
        public string Name { get; set; }
        protected DateTime Birth { get; set; }

        public Person()
        {
            Name = "John Doe";
            Birth = new DateTime(2000,1,1);
        }

        public Person(string name, DateTime birth)
        {
            Name = name;
            Birth = birth;
        }

        public int Age()
        {
            int age = DateTime.Now.Year - Birth.Year;
            return age;
        }

        public void Print()
        {
            Console.WriteLine("HELLO " + Name + " " + Birth);
        }

        public override string ToString()
        {
            return Name + " is " + Age() + " jaar oud";
        }
    }
}
