using AutomobileSolution.BussinessObject;
using System.Collections;

namespace AutomobileSolution.Repository
{
    public interface ICarRepository
    {
        public IEnumerable<Car> GetCars();
        Car GetCarByID(int carId);
        void InsertCar(Car car);
        void DeleteCar(int carId);
        void UpdateCar(Car car);
    }
}

