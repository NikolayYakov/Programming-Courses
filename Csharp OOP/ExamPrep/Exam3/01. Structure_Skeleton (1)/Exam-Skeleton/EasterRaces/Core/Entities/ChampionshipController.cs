using EasterRaces.Core.Contracts;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Cars.Entities;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Drivers.Entities;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Models.Races.Entities;
using EasterRaces.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasterRaces.Core.Entities
{
    class ChampionshipController : IChampionshipController
    {
        private DriverRepository drivers;
        private CarRepository cars;
        private RaceRepository races;
        public ChampionshipController()
        {
            drivers = new DriverRepository();
            cars = new CarRepository();
            races = new RaceRepository();
        }
        public string AddCarToDriver(string driverName, string carModel)
        {
            var driver = drivers.GetByName(driverName);
            var car = cars.GetByName(carModel);
            if (driver == null)
            {
                throw new InvalidOperationException($"Driver {driverName} could not be found.");
            }
            if (car == null)
            {
                throw new InvalidOperationException($"Car {carModel} could not be found.");

            }
            driver.AddCar(car);
            return $"Driver {driver.Name} received car {carModel}.";
        }

        public string AddDriverToRace(string raceName, string driverName)
        {
            var driver = drivers.GetByName(driverName);
            var race = races.GetByName(raceName);
            if (race == null)
            {
                throw new InvalidOperationException($"Race { raceName } could not be found.");
            }
            if (driver == null)
            {
                throw new InvalidOperationException($"Driver {driverName} could not be found.");

            }
            race.AddDriver(driver);
            return $"Driver {driverName} added in {raceName} race.";
        }

        public string CreateCar(string type, string model, int horsePower)
        {
            ICar car = null;
            if(type== "Muscle")
            {
                car = new MuscleCar(model, horsePower);

            }
            else
            {
                car = new SportsCar(model, horsePower);
            }
            if (cars.GetByName(model) == null)
            {
                cars.Add(car);
                return $"{car.GetType().Name} {model} is created.";
            }
            else
            {
                throw new ArgumentException($"Car {model} is already created.");

            }
        }

        public string CreateDriver(string driverName)
        {
            if (drivers.GetByName(driverName) == null)
            {
                IDriver driver = new Driver(driverName);
                drivers.Add(driver);
                return $"Driver {driverName} is created.";
            }
            else
            {
                throw new ArgumentException($"Driver {driverName} is already created.");
            }
        }

        public string CreateRace(string name, int laps)
        {
            var race = races.GetByName(name);
            if (race==null)
            {
                IRace newRace = new Race(name,laps);
                races.Add(newRace);
                return $"Race {name} is created.";
            }
            else
            {
                throw new InvalidOperationException($"Race { name } is already create.");
            }
        }

        public string StartRace(string raceName)
        {
            var race = races.GetByName(raceName);
            StringBuilder sb = new StringBuilder();
            if(race == null)
            {
                throw new InvalidOperationException($"Race {raceName} could not be found.");
            }
            if (race.Drivers.Count < 3)
            {
                throw new InvalidOperationException($"Race {raceName} cannot start with less than 3 participants.");
            }
            else
            {
                int count = 0;
                foreach (var item in race.Drivers.OrderByDescending(r=>r.Car.CalculateRacePoints(race.Laps)))
                {
                    if (count == 0)
                    {
                        sb.AppendLine($"Driver {item.Name} wins {raceName} race.");
                        item.WinRace();
                    }
                    else if(count == 1)
                    {
                        sb.AppendLine($"Driver {item.Name} is second in {raceName} race.");
                    }
                    else if (count == 2)
                    {
                        sb.AppendLine($"Driver {item.Name} is third in {raceName} race.");
                        break;
                    }
                    count++;
                }
                races.Remove(race);
                return sb.ToString().Trim();
            }


        }
    }
}
