namespace proga_2_lab_2_1.Models
{
    public class Clothing
    {
        public string Color { get; set; }
        public string Name { get; set; }

        protected Clothing(string color, string name)
        {
            Color = color;
            Name = name;
        }

        public override string ToString()
        {
            return Name + " " + Color;
        }
    }
}
