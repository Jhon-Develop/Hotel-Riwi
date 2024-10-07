using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel_Riwi.DataBase;
using Hotel_Riwi.Models;
using Hotel_Riwi.Models.DTOs;
using Hotel_Riwi.Repositories.Interfaces;
using Hotel_Riwi.Services.Interfaces;

namespace Hotel_Riwi.Services
{
    public class AuthService : IAuthService
    {
        private readonly ApplicationDbContext _context;
        private readonly IGuestRepository _guestRepository;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IJwtService _jwtService;

        public AuthService(ApplicationDbContext context, IGuestRepository guestRepository, IPasswordHasher passwordHasher, IJwtService jwtService)
        {
            _context = context;
            _guestRepository = guestRepository;
            _passwordHasher = passwordHasher;
            _jwtService = jwtService;
        }

        public async Task<string> LoginAsync(LoginDto loginDto)
        {
            var user = await _guestRepository.GetEmployeeByEmailAsync(loginDto.Email);
            if (user == null || !_passwordHasher.VerifyPassword(loginDto.Password, user.PasswordHash))
            {
                throw new InvalidDataException("the email is not registered");
            }

            return _jwtService.GenerateTokenJwt(user);
        }

        public async Task RegisterAsync(RegisterDto registerDto)
        {
            var guest = new Guest
            {
                FirstName = registerDto.FirstName,
                LastName = registerDto.LastName,
                Email = registerDto.Email,
                IndentificationNumber = registerDto.IndentificationNumber,
                PhoneNumber = registerDto.PhoneNumber,
                Birthdate = registerDto.Birthdate
            };

            await _guestRepository.AddGuestAsync(guest);
        }
    }
}