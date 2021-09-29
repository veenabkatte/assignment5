using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace assignment5
{
   
    
        class Hotel
        {
            
                public string HotelName { get; set; }

                public Hotel()
                {
                    Console.WriteLine("Enter the name of hotel:");
                    HotelName = Console.ReadLine();
                }
            }
            class Room : Hotel
            {
                public int Number { get; set; }
                public int Floor { get; set; }
                public string Type { get; set; }
                public int Capacity { get; set; }
                public string BookedTime { get; set; }
                public double Price { get; set; }

                public Room()
                {

                }

                public Room(int number, int floor, string type, int capacity, string bookedTime, double price)
                {
                    this.Number = number;
                    this.Floor = floor;
                    this.Type = type;
                    this.Capacity = capacity;
                    this.BookedTime = bookedTime;
                    this.Price = price;
                }

                public override string ToString()
                {
                    return string.Format("Number:{0}\nFloor:{1}\nType:{2}\nCapacity:{3}\nBooked Time:{4}\nPrice:{5}", this.Number, Floor, Type, Capacity, BookedTime, Price);
                }

            }
        }

        namespace OOPS
        {


        }
   


