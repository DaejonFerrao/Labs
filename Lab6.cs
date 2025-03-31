using System;
using System.IO;
using System.Collections.Generic;

namespace CS0603;

class Lab6

{
    public static void TestLab6()
    {}
    public struct CarInfo
    {
        public string CarName { get; }
        public int CarPrice { get; }

        public CarInfo(string carNameIn, int carPriceIn)
        {
            CarName = carNameIn;
            CarPrice = carPriceIn;
        }
    }

    class Program

    {
        public static void Lab6Function()
        {
            List<CarInfo> carlist = new List<CarInfo>();

            try
            {
                using (StreamReader sr = new StreamReader("carPrices.csv"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] tempStrings = line.Split(",");
                        string carName = tempStrings[0];
                        int carPrice;

                        if (int.TryParse(tempStrings[1], out carPrice))
                        {
                            CarInfo car = new CarInfo(carName, carPrice);
                            carlist.Add(car);
                        }
                        else
                        {
                            Console.WriteLine($"Warning: Could not price in line: {line}");
                        }
                    }
                }
            }    

                catch (FileNotFoundException)
            {
                Console.WriteLine("Error: carPrices.csv not found!");
                return;
            }
            catch (IOException e)
            {
                Console.WriteLine($"Error reading file:  {e.Message}");
                return;
            }

            if (carlist.Count > 0)
            {
                CarInfo carBMW = carlist[0];
                Console.WriteLine($"Car Name: {carBMW.CarName}");
                Console.WriteLine($"Car Name: {carBMW.CarPrice}");
            }
        }
    }
}

