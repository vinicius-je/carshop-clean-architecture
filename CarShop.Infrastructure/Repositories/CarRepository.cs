using CarShop.Domain.Abstractions;
using CarShop.Domain.Entities;
using CarShop.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Infrastructure.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly ApplicationDbContext _context;

        public CarRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task deleteById(int id)
        {
            var car = await getById(id);

            if (car is not null)
            {
                _context.Cars.Remove(car);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("Dados inválidos...");
            }
        }

        public async Task<IEnumerable<Car>> GetAll()
        {
            if (_context is not null && _context.Cars is not null)
            {
                var cars = await _context.Cars.ToListAsync();
                return cars;
            }
            else
            {
                return new List<Car>();
            }
        }

        public async Task<Car?> getById(int id)
        {
            var car = await _context.Cars.SingleOrDefaultAsync(c => c.CarId == id);

            if (car is  null)
            {
                throw new InvalidOperationException($"Vaeículo com ID {id} não encontrado");
            }

            return car;
        }

        public async Task<Car> save(Car car)
        {
            if (_context is not null && car is not null && _context.Cars is not null)
            {
                _context.Cars.Add(car);
                await _context.SaveChangesAsync();
                return car;
            }
            else
            {
                throw new InvalidOperationException("Dados inválidos...");
            }
        }

        public async Task update(Car car)
        {
            if (car is not null)
            {
                _context.Entry(car).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException("Dados inválidos...");
            }
        }
    }
}
