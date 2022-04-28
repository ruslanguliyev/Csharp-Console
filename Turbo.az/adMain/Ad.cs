using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.az.adMain
{
    public class Ad
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string City { get; set; }
        public double Engine { get; set; }
        public int Mileage { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int View { get; set; }
    }
}
