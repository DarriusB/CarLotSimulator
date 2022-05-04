using System;
namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {

            CarLot.numberOfCars++;

        }

        //public Car(int year, string make, string model, bool engineNoise, bool honkNoise, bool isDrivable);



        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool EngineNoise { get; set; }
        public bool HonkNoise { get; set; }
        public bool IsDrivable { get; set; }

        public string MakeEngineNoise(bool EngineNoise)
        {
            string hasNoise = true ? $"Yes\a" : $"No";
            {
                
                return hasNoise;
            }
         
        }

        public string MakeHonkNoise(bool HonkNoise)
        {
            string hasNoise = true ? $"Yes\a" : $"No";
            {
                return hasNoise;
            }
        }

        public string IsTheCarDrivable(bool IsDrivable)
        {
            string canDrive = true ? $"Yes\a" : $"No";
            {
                return canDrive;
            }
        }


    }
}
