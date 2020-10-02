using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempClassLibrary
{
    public class Room
    {
        //Variables
        private int roomNumber;
        private string hallIndicator;
        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }
        public string HallIndicator
        {
            get { return hallIndicator; }
            set { hallIndicator = value; }
        }
        public Room(int roomNumber, string hallIndicator)
        {
            RoomNumber = roomNumber;
            HallIndicator = hallIndicator;
        }
    }
}
