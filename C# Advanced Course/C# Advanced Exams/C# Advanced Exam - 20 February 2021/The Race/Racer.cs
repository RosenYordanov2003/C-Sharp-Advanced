﻿using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Xml.Linq;

namespace TheRace
{
    public class Racer
    {
        public Racer(string name, int age, string country, Car car)
        {
            this.Name = name;
            this.Age = age;
            this.Country = country;
            this.Car = car;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public Car Car { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Racer: {this.Name}, {this.Age} ({this.Country})");
            return sb.ToString().Trim();
        }
    }
}
