﻿namespace Bakery.Models.Drinks
{
    using System;
    using Contracts;
    using Utilities.Messages;

    public abstract class Drink : IDrink
    {
        private string name;

        private int portion;

        private decimal price;

        private string brand;

        protected Drink(string name, int portion, decimal price, string brand)
        {
            Name = name;
            Portion = portion;
            Price = price;
            Brand = brand;
        }
        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidName);
                }
                name = value;
            }
        }

        public int Portion
        {
            get => portion;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPortion);
                }

                portion = value;
            }
        }

        public decimal Price
        {
            get => price;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPrice);
                }

                price = value;
            }
        }

        public string Brand
        {
            get => brand;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidBrand);
                }

                brand = value;
            }
        }

        public override string ToString()
        {
            return $"{Name} {Brand} - {Portion}ml - {Price:F2}lv";
        }
    }
}
