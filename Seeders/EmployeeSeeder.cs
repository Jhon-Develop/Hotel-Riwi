using Hotel_Riwi.Models;
using Microsoft.EntityFrameworkCore;
using Hotel_Riwi.Services.Interfaces;

namespace Hotel_Riwi.Seeders
{
    public class EmployeeSeeder
    {
        private readonly IPasswordHasher _passwordHasher;

        public EmployeeSeeder(IPasswordHasher passwordHasher)
        {
            _passwordHasher = passwordHasher;
        }

        public void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee 
                { 
                    Id = 1, 
                    FirstName = "John", 
                    LastName = "Doe", 
                    Email = "john.doe@example.com", 
                    IndentificationNumber = "123456", 
                    PasswordHash = _passwordHasher.HashPassword("John123!") 
                },
                new Employee 
                { 
                    Id = 2, 
                    FirstName = "Jane", 
                    LastName = "Smith", 
                    Email = "jane.smith@example.com", 
                    IndentificationNumber = "654321", 
                    PasswordHash = _passwordHasher.HashPassword("Jane123!") 
                },
                new Employee 
                { 
                    Id = 3, 
                    FirstName = "Robert", 
                    LastName = "Brown", 
                    Email = "robert.brown@example.com", 
                    IndentificationNumber = "789012", 
                    PasswordHash = _passwordHasher.HashPassword("Robert123!") 
                },
                new Employee 
                { 
                    Id = 4, 
                    FirstName = "Emily", 
                    LastName = "Davis", 
                    Email = "emily.davis@example.com", 
                    IndentificationNumber = "345678", 
                    PasswordHash = _passwordHasher.HashPassword("Emily123!") 
                },
                new Employee 
                { 
                    Id = 5, 
                    FirstName = "Jhon", 
                    LastName = "Asprilla", 
                    Email = "asprillajhon73@gmail.com", 
                    IndentificationNumber = "1013456232", 
                    PasswordHash = _passwordHasher.HashPassword("Asprilla1.") 
                }
            );
        }
    }
}
