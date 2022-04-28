using proga_2_lab_2_1.Models;
using System;

namespace proga_2_lab_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Clothing[] clothings =
            {
                new TShirt ("Біла"),
                new TShirt ("Рожева"),
                new Jaket ("Зелена"),
                new Pants ("Сині"),
                new Shoes ("Білі"),
                new Shoes ("Синьо-жовті")
            };

            Console.WriteLine("ГАРДЕРОБ:");
            for (int i = 0; i < clothings.Length; i++)
                Console.WriteLine("\t" + clothings[i].Color + " " + clothings[i].Name);

            while (true)
                clothings[ToChose()].ToWear();
        }

        static int ToChose()
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
