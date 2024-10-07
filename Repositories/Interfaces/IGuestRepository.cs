using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_Riwi.Models;

namespace Hotel_Riwi.Repositories.Interfaces
{
    public interface IGuestRepository
    {
        Task<IEnumerable<Guest>> GetAllGuestsAsync();
        Task<Guest> GetGuestByIdAsync(int id);
        Task<Employee> GetEmployeeByEmailAsync(string email);
        Task<Guest> GetGuestByIdentificationNumberAsync(string identificationNumber);
        Task<IEnumerable<Guest>> SearchGuestAsync(string keyword);
        Task<Guest> AddGuestAsync(Guest guest);
        Task<Guest> UpdateGuestAsync(Guest guest);
        Task<bool> DeleteGuestAsync(int id);
    }
}