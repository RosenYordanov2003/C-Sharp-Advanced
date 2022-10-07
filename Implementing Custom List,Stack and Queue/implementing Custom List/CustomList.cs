﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Implementing_Stack_and_Queue
{
    internal class CustomList
    {
        private int startCapacity = 2;
        private int[] array;
        private int count;
        public CustomList()
        {
            this.array = new int[startCapacity];
        }
        public int Count { get { return this.count; } }
        public void Add(int element)
        {
            if (this.count == this.array.Length)
            {
                Resize(this.array);
                this.array[this.count] = element;
                this.count++;
            }
            else
            {
                this.array[count] = element;
                this.count++;
            }
        }
        public int RemoveAt(int index)
        {
            if (ValidateIndex(index))
            {
                int elementToRemove = this.array[index];
                this.array[index] = default(int);
                Shift(this.array);
                this.count--;
                if (this.count <= this.array.Length / 4)
                {
                    Shrink();
                }
                return elementToRemove;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Invalid Index");
            }
        }
        public void Swap(int firstIndex, int secondIndex)
        {
            if (ValidateIndex(firstIndex) && ValidateIndex(secondIndex))
            {
                int currentFirstIndex = this.array[firstIndex];
                this.array[firstIndex] = this.array[secondIndex];
                this.array[secondIndex] = currentFirstIndex;
            }
            else
            {
                throw new ArgumentException("invalid index");
            }
        }
        public bool Contains(int element)
        {
            bool isExist = false;
            for (int i = 0; i < this.array.Length; i++)
            {
                if (this.array[i] == element)
                {
                    isExist = true;
                    break;
                }
            }
            return isExist;
        }
        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < this.count; i++)
            {
                action(this.array[i]);
            }
        }
        public void Insert(int index, int value)
        {
            if (ValidateIndex(index))
            {
                ShiftRight(index);
                this.array[index] = value;
                this.count++;
            }
            else
            {
                throw new ArgumentException("invalid index");
            }
        }
        public int Remove(int element)
        {
            for (int i = 0; i < this.count; i++)
            {
                if (this.array[i] == element)
                {
                    this.array[i] = default(int);
                    ShiftByIndex(i);
                    this.count--;
                    i--;
                }
            }
            return element;
        }
        public void AddRange(int[] array)
        {
            if (this.Count == this.array.Length)
            {
                Resize(this.array);
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    this.array[count] = array[i];
                    count++;
                }
            }
        }
        public void RemoveRange(int index, int count)
        {
            if (ValidateIndex(index) && index + count < this.count)
            {
                for (int i = 0; i < count; i++)
                {
                    this.array[index] = default(int);
                    ShiftRemoveRange(this.array, index);
                    this.count--;
                }
            }
            else
            {
                throw new ArgumentException("Index was outside from the range");
            }
        }

        private void ShiftRemoveRange(int[] array, int index)
        {
            for (int i = index; i < index + this.count; i++)
            {
                this.array[i] = this.array[i + 1];
            }
        }

        private void ShiftByIndex(int index)
        {
            for (int i = index; i < this.count; i++)
            {
                this.array[i] = this.array[i + 1];
            }
        }

        private void ShiftRight(int index)
        {
            for (int i = count - 1; i >= index; i--)
            {
                this.array[i + 1] = this.array[i];
            }
        }

        private void Resize(int[] array)
        {
            int[] coppyArray = new int[this.array.Length * 2];
            for (int i = 0; i < this.count; i++)
            {
                coppyArray[i] = this.array[i];
            }
            this.array = coppyArray;
        }
        private void Shift(int[] array)
        {
            for (int i = 0; i < this.count; i++)
            {
                this.array[i] = this.array[i + 1];
            }
        }
        private bool ValidateIndex(int index)
        {
            if (index >= 0 && index < this.count)
            {
                return true;
            }
            return false;
        }
        private void Shrink()
        {
            int[] newArray = new int[this.array.Length / 2];
            for (int i = 0; i < this.count; i++)
            {
                newArray[i] = this.array[i];
            }
            this.array = newArray;
        }
    }
}
