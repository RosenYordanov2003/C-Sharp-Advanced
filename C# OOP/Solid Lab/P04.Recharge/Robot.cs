﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P04.Recharge
{
    public class Robot : Worker, IRechargeable
    {
        private int capacity;
        private int currentPower;

        public Robot(string id,int capacity) : base(id)
        {
            this.capacity = capacity;
        }
        public void Work(int hours)
        {
            if (hours > this.currentPower)
            {
                hours = currentPower;
            }
            base.Work(hours);
            this.currentPower -= hours;
        }

        public void Recharge()
        {
            this.currentPower = this.capacity;
        }
    }

}