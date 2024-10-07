using System;
using Hotel_Riwi.Models;

namespace Hotel_Riwi.Services
{
    public class RoomValidationService
    {
        public bool ValidateRoom(Room room)
        {
            return ValidatePrice(room.PricePerNight, room.RoomTypeId) && ValidateOccupancy(room.MaxOccupancyPersons, room.RoomTypeId);
        }

        private bool ValidatePrice(double price, int roomTypeId)
        {
            double expectedPrice = roomTypeId switch
            {
                1 => 50,
                2 => 80,
                3 => 150,
                4 => 200,
                _ => throw new ArgumentOutOfRangeException("Invalid RoomTypeId")
            };

            return price == expectedPrice;
        }

        private bool ValidateOccupancy(byte occupancy, int roomTypeId)
        {
            byte expectedOccupancy = roomTypeId switch
            {
                1 => 1,
                2 => 2,
                3 => 2,
                4 => 4,
                _ => throw new ArgumentOutOfRangeException("Invalid RoomTypeId")
            };

            return occupancy == expectedOccupancy;
        }

        public int GetRoomTypeForRoomNumber(int roomNumber)
        {
            if (roomNumber >= 1 && roomNumber <= 10)
                return 1;
            else if (roomNumber >= 11 && roomNumber <= 20)
                return 2;
            else if (roomNumber >= 21 && roomNumber <= 30)
                return 3;
            else if (roomNumber >= 31 && roomNumber <= 50)
                return 4;
            else
                throw new ArgumentOutOfRangeException("Invalid Room Number");
        }



        public double GetPriceByRoomType(int roomTypeId)
        {
            return roomTypeId switch
            {
                1 => 50,
                2 => 80,
                3 => 150,
                4 => 200,
                _ => throw new ArgumentOutOfRangeException("Invalid RoomTypeId")
            };
        }

        public byte GetMaxOccupancyByRoomType(int roomTypeId)
        {
            return roomTypeId switch
            {
                1 => 1,
                2 => 2,
                3 => 2,
                4 => 4,
                _ => throw new ArgumentOutOfRangeException("Invalid RoomTypeId")
            };
        }
    }
}
