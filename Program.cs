using proga_2_lab_2_1.Models;
using System;

namespace proga_2_lab_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Person[] persons =
            {
                new Person ("Стів Джобс"),
                new Person ("Анджеліна Джолі"),
                new Person ("Джеф Безос")
            };

            Clothing[] clothings =
            {
                new TShirt ("Біла"),
                new TShirt ("Рожева"),
                new Jaket ("Зелена"),
                new Pants ("Сині"),
                new Shoes ("Білі"),
                new Shoes ("Синьо-жовті")
            };

            Console.WriteLine("ЛЮДИ:");
            for (int i = 0; i < persons.Length; i++)
                Console.WriteLine("\t" + persons[i].Name);

            Console.WriteLine("\n\nГАРДЕРОБ:");
            for (int i = 0; i < clothings.Length; i++)
                Console.WriteLine("\t" + clothings[i].Color + " " + clothings[i].Name);

            while (true)
            {
                var p = persons[PersonToChose()];
                var cl = clothings[ClothingToChose()];
                p.ToWear(cl);
                Console.WriteLine(p.ToString());
            }
        }

        static int PersonToChose()
        {
            int num;
            Console.WriteLine("\nОбери людину (0/1/2): ");
            num = Convert.ToInt32(Console.ReadLine());
            while (num > 2 || num < 0)
            {
                Console.WriteLine("Такої людини немає!");
                Console.WriteLine("\nОбери людину (0/1/2): ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            return num;
        }
        static int ClothingToChose()
        {
            int num;
            Console.WriteLine("\nОбери річ (0/.../5): ");
            num = Convert.ToInt32(Console.ReadLine());
            while (num > 5 || num < 0)
            {
                Console.WriteLine("Такої речі немає!");
                Console.WriteLine("\nОбери річ (0/.../5): ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            return num;
        }
    }
}
