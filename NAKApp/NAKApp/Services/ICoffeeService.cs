using NAKApp.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NAKApp.Services
{
    public interface ICoffeeService
    {
        Task AddCoffee(string name, string roaster);
        Task<IEnumerable<Coffee>> GetCoffee();
        Task<Coffee> GetCoffee(int id);
        Task RemoveCoffee(int id);
    }
}