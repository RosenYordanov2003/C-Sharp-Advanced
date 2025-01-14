﻿namespace Template_Pattern.Models
{
    using System;
    public abstract class Bread
    {
        public abstract void MixIngredients();
        public abstract void Bake();

        public virtual void Slice()
        {
            Console.WriteLine("Slicing the:" + this.GetType().Name + "bread!");
        }
        //TemplateMethod
        public void Make()
        {
            MixIngredients();
            Bake();
            Slice();
        }
    }
}
