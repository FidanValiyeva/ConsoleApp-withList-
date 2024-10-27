using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Models
{
   internal class Room
   {
        public int RoomId;
        private int roomId { get; }
        public string Name;       
        public int Price;
        public double PersonCapacity;
        public bool IsAvaliable;
        private bool isAvaliable;

        public override string ToString()
        {
             return ShowInfo();
        }
       






    }
}
