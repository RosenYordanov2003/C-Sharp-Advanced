﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Tires
    {
        public Tires(double presusre, int age)
        {
            this.Presusre = presusre;
            this.Age = age;
        }

        public double Presusre { get; set; }
        public int Age { get; set; }

    }
}