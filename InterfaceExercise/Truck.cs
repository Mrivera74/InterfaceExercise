using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }


        public int NumberOfWheels { get; set; } = 4;
        public string Model { get; set; } = "1500";
        public string Make { get; set; } = "Ram";
        public int SeatCount { get; set; } = 5;
        public string CompanyName { get; set; } = "Ram";
        public string Motto { get; set; } = "Guts. Glory. Ram ";
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; } = true;

        public void Drive()
        {
            if (HasFourWheelDrive)
            {
                Console.WriteLine($"{GetType().Name} now driving forward with 4 wheel drive!");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} now driving forward!");
            }
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now driving Reverse!");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }
        }
        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park!");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park until we change gears");
            }
        }
        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}
