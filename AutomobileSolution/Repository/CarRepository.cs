using AutomobileSolution.BussinessObject;
using AutomobileSolution.DataAccess;

namespace AutomobileSolution.Repository
{
    public class CarRepository : ICarRepository
    {
        public Car GetCarByID(int carID) => CarDBContext.Instance.GetCarByID(carID);
        public IEnumerable<Car> GetCars() => CarDBContext.Instance.GetCarList;
        public void InsertCar(Car car) => CarDBContext.Instance.AddNew(car);
        public void DeleteCar(int carId) => CarDBContext.Instance.Remove(carId);
        public void UpdateCar(Car car) => CarDBContext.Instance.Update(car);
    }
}
