using System;
using System.Collections.Generic;
using Hotel_Riwi.Models;
using Hotel_Riwi.Services;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Riwi.Seeders
{
    public class RoomSeeder
    {
        private readonly RoomValidationService _roomValidationService;

        public RoomSeeder()
        {
            _roomValidationService = new RoomValidationService();
        }

        public static void Seed(ModelBuilder modelBuilder)
        {
            var validationService = new RoomValidationService();
            var rooms = new List<Room>();
            var random = new Random();

            // Crear una lista de números de habitación del 1 al 50
            var roomNumbers = new List<int>();
            for (int i = 1; i <= 50; i++)
            {
                roomNumbers.Add(i);
            }

            // Mezclar la lista de números de habitación
            for (int i = roomNumbers.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                int temp = roomNumbers[i];
                roomNumbers[i] = roomNumbers[j];
                roomNumbers[j] = temp;
            }

            // Asignar habitaciones mezcladas
            foreach (var roomId in roomNumbers)
            {
                try
                {
                    var roomTypeId = validationService.GetRoomTypeForRoomNumber(roomId);
                    var price = validationService.GetPriceByRoomType(roomTypeId);
                    var maxOccupancy = validationService.GetMaxOccupancyByRoomType(roomTypeId);

                    var room = new Room
                    {
                        Id = roomId,
                        RoomNumber = $"R{(roomId - 1) / 10 + 1}-{(roomId - 1) % 10 + 1}", // Mantener el formato de piso
                        RoomTypeId = roomTypeId,
                        PricePerNight = price,
                        Availability = true,
                        MaxOccupancyPersons = maxOccupancy
                    };

                    if (validationService.ValidateRoom(room))
                    {
                        rooms.Add(room);
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"Error: {ex.Message} - Room Number: {roomId}");
                }
            }

            modelBuilder.Entity<Room>().HasData(rooms);
        }
    }
}
