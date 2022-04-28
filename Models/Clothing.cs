using System;

namespace proga_2_lab_2_1.Models
{
    class Clothing
    {
        public bool Weared { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }

        public int confirm;

        protected Clothing(string color, string name)
        {
            Color = color;
            Name = name;
        }

        public virtual void ToWear()
        {
            if (!Weared)
            {
                Console.WriteLine(Color + " " + Name + " одягнут(а/і)!");
                Weared = true;
            }
            else
            {
                Console.WriteLine(Color + " " + Name + " вже надягнут(а/і)! Зняти? (1/0)");
                confirm = Convert.ToInt32(Console.ReadLine());
                if (confirm == 1)
                    Weared = false;
            }
        }

        public override string ToString()
        {
            return (Name + " " + Color + "\tНадіто: " + (Weared ? "так" : "ні"));
        }

        public override int GetHashCode()
        {
            return (Name + Color).GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is Clothing clothing) 
                return Name == clothing.Name && Color == clothing.Color;
            return false;
        }
    }
}
