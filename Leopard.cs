﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6_OOP_Arv
{
    internal class Leopard : Cat
    {
        //Variable for holding leopard count
        static int _leopardCount = 0;

        //Constructor
        public Leopard(string name, string sex, int age, bool isWild)
        {
            AnimalType = GetAnimalType();
            AnimalFamily = GetAnimalFamily();
            WhatAnimal = GetAnimal();
            Name = name;
            Sex = sex;
            Age = age;
            IsWild = isWild;

            //Add 1 for each leopard created
            _leopardCount++;
            //Shortname for the id
            AnimalId = "LEP" + _leopardCount;

        }

        public override string MakeSound()
        {
            Status = $"{Name} meows";
            return Status;
        }
    }
}
