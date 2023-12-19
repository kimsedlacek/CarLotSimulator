﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{//Create a seperate class file called Car
 //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
 //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
 //The methods should take one string parameter: the respective noise property

    public class Car
    {
        public Car()
        {

        }



        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;

        }


        public int Year { get; set; }
        public string Make {  get; set; }
        public string Model {  get; set; }
        public string EngineNoise {  get; set; }
        public string HonkNoise {  get; set; }
        public bool IsDriveable {  get; set; }


        public void MakeEngineNoise(string EngineNoise)
        {
            EngineNoise = EngineNoise;
            Console.WriteLine($"This car has an engine that sounds {EngineNoise}.");
        }


        public void MakeHonkNoise(string HonkNoise)
        {
            HonkNoise = HonkNoise;
            Console.WriteLine($"This car has a honk noise that sounds {HonkNoise}.");
        }
    }
}
