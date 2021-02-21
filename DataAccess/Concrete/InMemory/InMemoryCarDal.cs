using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=2,ColorId=3,DailyPrice=170,ModelYear=2011,Description="Renault Fluence" },
                new Car{Id=2,BrandId=2,ColorId=1,DailyPrice=150,ModelYear=2016,Description="Renault Symbol" },
                new Car{Id=3,BrandId=2,ColorId=3,DailyPrice=210,ModelYear=2018,Description="Renault Megan" },
                new Car{Id=4,BrandId=1,ColorId=2,DailyPrice=350,ModelYear=2020,Description="Audi A5" }

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=> c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int _brandId)
        {
            return _cars.Where(c => c.BrandId == _brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
