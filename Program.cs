using System;

namespace dz_04_02_zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  • Задание 4
             *      A. Создать проект по шаблону Console Application.
             *      B. Требуется: создать класс которое описывает состояние и поведение некой сущности.
             *      C. Сущность возьмите из обыденности.
             */

            double h_width = double.Parse(Console.ReadLine());
            double h_height = double.Parse(Console.ReadLine());
            double h_depth = double.Parse(Console.ReadLine());
            
            Room newHouse = new Room(h_width, h_depth, h_height);
            newHouse.GetRoom();
            
            Console.ReadKey();
        }

        class Room                                                 // Класс Дом
        {
            private double room_width;
            private double room_height;
            private double room_depth;
            public double Volume
            {
                get 
                {
                    return volumeRoom();
                }
            }

            public Room(double room_width, double room_height, double room_depth)
            {
                this.room_width = room_width;
                this.room_height = room_height;
                this.room_depth = room_depth; 
            }
            
            public void GetRoom()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine($"Объем комнаты: {Volume}");
            }

            public double volumeRoom()
            {
                return room_width * room_height * room_depth;
            }
        }
    }
}