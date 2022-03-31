﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_zadanie
{
    abstract class Person: IThing

    {
        protected string name;
        protected int age;

        public string Name { get { return name; }  }
        public int Age { get { return age;} }
        
        public Person (string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public bool Equals(Person obj)
        { return obj.name == this.name && obj.age == this.age; }
        public abstract void Print(string prefix);
    }
}
