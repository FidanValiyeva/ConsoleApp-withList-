using CORE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class AppDbContext
    {
        private static List<Room> rooms = new List<Room>();
        private static List<Hotel> hotel = new List<Hotel>();

        public static void AddRoom(Room room)
        {
            rooms.Add(room);
        }
        public static void FindAllRoom(double roomId)
        {
            if (roomId >= 325 && roomId <= 332)
            {
                return;
            }
            else
            {

                Console.WriteLine("axtardiginiz otaq yoxdur");

            }

        }
            static void MakeReservation(int? roomId, int? customerNumber)
            { 

             
            }
            
    






    


        

    }
}
