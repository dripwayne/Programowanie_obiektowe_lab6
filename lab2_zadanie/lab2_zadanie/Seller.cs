﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_zadanie
{
     class Seller: Person
    {
        public Seller( string name, int age): base(name,age)
        {
            
        }
        public override void Print(string prefix)
        {
            Console.WriteLine($"{prefix}Seller: {this.name} ({this.age} y.o. )");
        }
    }
}
