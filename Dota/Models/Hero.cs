namespace Dota.Models
{
    public class Hero
    {
        public string Name { get; set; }

        public string Lane { get; set; }

        public string Description { get; set; }

        public string MainImage { get; set; }

        public string[] Spells { get; set; }
    }
}