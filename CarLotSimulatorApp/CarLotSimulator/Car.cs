using System;

namespace CarLotSimulator
{
    public class Car
    {
        //Completed- Create a seperate class file called Car 
        //Completed- Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Completed- Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //Completed- The methods should take one string parameter: the respective noise property

        public Car()
        {

        }

        //Construct initializor syntax
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
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string engineSound)
        {
            Console.WriteLine(engineSound);
        }

        public void MakeHonkNoise(string honkSound)
        {
            Console.WriteLine(honkSound);
        }

  
    }
}
