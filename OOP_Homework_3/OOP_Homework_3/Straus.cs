﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Homework_3
{
    public class Straus : Bird
    {
        public Straus(string lengthOfWing, bool isFly, string maxTall, int legs, string color, bool isBreastfeeding)
            : base(lengthOfWing, isFly, maxTall, legs, color, isBreastfeeding) { }

        public string StrausInfo()
        {
            return "Tuyaqush yaratildi";
        }
    }
}
