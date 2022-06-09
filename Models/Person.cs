using System;

namespace proga_2_lab_2_1.Models
{
    public class Person
    {
        public string Name { get; set; }
        public TShirt TShirt { get; set; }
        public Pants Pants { get; set; }
        public Jaket Jaket { get; set; }
        public Shoes Shoes { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public void ToWear(Clothing cl)
        {
            if (cl.GetType().Name.ToString() == "TShirt")
            {
                if (TShirt == null)
                {
                    this.TShirt = (TShirt)cl;
                    Console.WriteLine(cl.Color + " " + cl.Name + " одягнута!");
                }
                else Weared(cl);
            }
            else if (cl.GetType().Name.ToString() == "Jaket")
            {
                if (Jaket == null)
                {
                    this.Jaket = (Jaket)cl;
                    Console.WriteLine(cl.Color + " " + cl.Name + " одягнута!");
                }
                else Weared(cl);
            }
            else if (cl.GetType().Name.ToString() == "Pants")
            {
                if (Pants == null)
                {
                    this.Pants = (Pants)cl;
                    Console.WriteLine(cl.Color + " " + cl.Name + " одягнуті!");
                }
                else Weared(cl);
            }
            else if (cl.GetType().Name.ToString() == "Shoes")
            {
                if (Shoes == null)
                {
                    this.Shoes = (Shoes)cl;
                    Console.WriteLine(cl.Color + " " + cl.Name + " одягнуті!");
                }
                else Weared(cl);
            }
        }

        private void Weared(Clothing cl)
        {
            Console.WriteLine(cl.Name + " вже надягнут(а/і)! Зняти? (1/0)");
            int confirm = Convert.ToInt32(Console.ReadLine());
            if (confirm == 1)
            {
                if (cl.GetType().Name.ToString() == "TShirt") this.TShirt = null;
                else if (cl.GetType().Name.ToString() == "Jaket") this.Jaket = null;
                else if (cl.GetType().Name.ToString() == "Pants") this.Pants = null;
                else if (cl.GetType().Name.ToString() == "Shoes") this.Shoes = null;
                this.ToWear(cl);
            }
        }

        public override string ToString()
        {
            return ("\n" + Name + (TShirt == null ? "" : "\nФутболка: " + TShirt.Color) + (Pants == null ? "" : "\nШтани: " + Pants.Color)
                + (Jaket == null ? "" : "\nКуртка: " + Jaket.Color) + (Shoes == null ? "" : "\nВзуття: " + Shoes.Color));
        }
    }
}
