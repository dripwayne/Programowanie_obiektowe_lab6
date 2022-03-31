﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_zadanie
{
    abstract class Product: IThing
    {
        protected string name;
        public string Name { get { return name; }  }

       public Product( string name)
        {
            this.name = name;
        }

        public abstract void Print(string prefix);

    }
}
