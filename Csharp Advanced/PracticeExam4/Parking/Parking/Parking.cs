using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        public Parking(string type,int capacity)
        {
            Type = type;
            Capacity = capacity;
            data = new List<Car>();
        }
        public string Type { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return data.Count; } }
        List<Car> data;
        public void Add(Car car)
        {
            if (data.Count < Capacity)
            {
                data.Add(car);
            }
        }
        public bool Remove(string manufacturer, string model)
        {
            var car = data.FirstOrDefault(c => c.Manufacturer == manufacturer && c.Model == model);
            if (car == null)
            {
                return false;
            }
            else
            {
                data.Remove(car);
                return true;
            }
        }
        public Car GetLatestCar()
        {
            List<Car> filler = data.OrderByDescending(c => c.Year).ToList();
            var car = filler.FirstOrDefault(c => c.Year>0);
            return car;
        }
        public Car GetCar(string manufacturer, string model)
        {
            var car = data.FirstOrDefault(c => c.Manufacturer == manufacturer && c.Model == model);
            return car;
        }
        public string GetStatistics()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"The cars are parked in {Type}:");
            foreach (var car in data)
            {
                output.AppendLine(car.ToString());
            }
            return output.ToString().Trim();
        }
    }
}
