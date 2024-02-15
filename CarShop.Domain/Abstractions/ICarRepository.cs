using CarShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Domain.Abstractions
{
    public interface ICarRepository
    {
        Task<IEnumerable<Car>> GetAll();
        Task<Car?> getById(int id);
        Task<Car> save(Car car);
        Task update(Car car);
        Task deleteById(int id);
    }
}
