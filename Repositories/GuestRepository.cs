using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_Riwi.DataBase;
using Hotel_Riwi.Models;
using Hotel_Riwi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Riwi.Repositories
{
    public class GuestRepository(ApplicationDbContext context) : IGuestRepository
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<IEnumerable<Guest>> GetAllGuestsAsync()
        {
            return await _context.Guests.AsNoTracking().ToListAsync();
        }

        public async Task<Guest> GetGuestByIdAsync(int id)
        {
            return await _context.Guests.FirstOrDefaultAsync(g => g.Id == id);
        }

        public async Task<Employee> GetEmployeeByEmailAsync(string email)
        {
            return await _context.Employees.FirstOrDefaultAsync(e => e.Email == email);
        }

        public async Task<IEnumerable<Guest>> SearchGuestAsync(string keyword)
        {
            return await _context.Guests.Where(g => g.FirstName.Contains(keyword) || g.LastName.Contains(keyword)).ToListAsync();
        }        

        public async Task<Guest> AddGuestAsync(Guest guest) 
        {
            _context.Guests.Add(guest);
            await _context.SaveChangesAsync();
            return guest;
        }

        public async Task<Guest> UpdateGuestAsync(Guest guest)
        {
            _context.Guests.Update(guest);
            await _context.SaveChangesAsync();
            return guest;
        }

        public async Task<bool> DeleteGuestAsync(int id)
        {
            var guest = await _context.Guests.FirstOrDefaultAsync(g => g.Id == id);
            if (guest == null)
            {
                return false;
            }
            _context.Guests.Remove(guest);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}