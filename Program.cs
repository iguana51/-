using System;
using System.ComponentModel;

namespace date
{
    class Program
    {
        static void Main(string[] args)
        {

            int day, month, year;
            // имя пользвателя
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();


            //день рождения
            Console.Write("Введите день: ");
            day = Convert.ToInt32(Console.ReadLine());
            while (day > 31 || day <= 0)
            {
                Console.WriteLine("неверно");
                Console.Write("Введите день: ");
                day = Convert.ToInt32(Console.ReadLine());

            }

            //при феврале
            Console.Write("Введите месяц:");
            month = Convert.ToInt32(Console.ReadLine());
            while (month== 2 && (day > 29 || day > 30))
            {
                Console.WriteLine("неверно");
                Console.Write("Введите месяц:");
                month = Convert.ToInt32(Console.ReadLine());
            }


            //месяц рождения
             
            while (month > 12 || month <= 0)
            {
                Console.WriteLine("неверно");
                Console.Write("Введите месяц:");
               
            }
            

            //год рождеения
             Console.Write("Введите год: ");
             year= Convert.ToInt32(Console.ReadLine());

            //Высчет возраста пользователя
            DateTime date = new DateTime(year, month, day);
            DateTime dateNow = DateTime.Today;
            TimeSpan age_person = dateNow - date;


            //хиханьки хаханьки
            if (Math.Floor(age_person.TotalDays / 365) == 0)
            {
                Console.WriteLine("соболезную..");
            }

            if (Math.Floor(age_person.TotalDays / 365) > 2 && Math.Floor(age_person.TotalDays / 365) < 6)
            {
                Console.WriteLine("иди спать, завтра в садик");
            }

            if (Math.Floor(age_person.TotalDays / 365)>6 && Math.Floor(age_person.TotalDays / 365)<16)
            {
              Console.WriteLine("иди спать, завтра в школу");
            }
                
            if (Math.Floor(age_person.TotalDays / 365)> 27 && Math.Floor(age_person.TotalDays / 365)<45)
            {
                Console.WriteLine("ого,ты еще с нами");
            }

            if (Math.Floor(age_person.TotalDays / 365) > 45)
            {
                Console.WriteLine("подмети песок");
            }   

            //вывод фразы
                Console.WriteLine($"Привет,{name}. Ваш возраст равен {Math.Floor(age_person.TotalDays / 365)} лет . Приятно познакомиться.");
        }
    }
}
