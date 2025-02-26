﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxofInteger
{
    public class Box<T>
    {
        private T element;
        public Box(T element)
        {
            this.element = element;
        }
        public T Element { get { return this.element; } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{typeof(T)}: {this.element}");
            return sb.ToString().Trim();
        }
    }
}
