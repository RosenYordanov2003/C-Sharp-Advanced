﻿namespace Bakery.Models.BakedFoods
{
    public class Cake : BakedFood
    {
        private const int InitialCakePortion = 245;
        public Cake(string name,  decimal price) : base(name, InitialCakePortion, price){}
    }
}
