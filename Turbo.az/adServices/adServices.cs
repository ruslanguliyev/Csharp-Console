using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.az.adMain;

namespace Turbo.az.adServices
{
    public class adServices
    {
        List<Ad> Ads = new()
        {
            new Ad
            {
                Id = 1,
                Name = "Mercedes amg",
                Model = "S class",
                City = "Baku",
                Engine = 3.0,
                Mileage = 0,
                Year = 2020,
                Price = 270000,
                PublishDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                View = 150,
            },
            new Ad
            {
                Id = 2,
                Name = "Mercedes",
                Model = "S class",
                City = "Baku",
                Engine = 3.0,
                Mileage = 0,
                Year = 2021,
                Price = 280000,
                PublishDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                View = 150,
            },
            new Ad
            {
                Id = 3,
                Name = "Mercedes amg",
                Model = "G class",
                City = "Baku",
                Engine = 4.0,
                Mileage = 0,
                Year = 2020,
                Price = 290000,
                PublishDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                View = 150,
            },
            new Ad
            {
                Id = 4,
                Name = "Mercedes amg",
                Model = "G class",
                City = "Baku",
                Engine = 4.0,
                Mileage = 0,
                Year = 2021,
                Price = 310000,
                PublishDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                View = 150,
            },
            new Ad
            {
                Id = 5,
                Name = "BMW",
                Model = "M5",
                City = "Baku",
                Engine = 4.4,
                Mileage = 10000,
                Year = 2020,
                Price = 140000,
                PublishDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                View = 150,

            },
            new Ad
            {
                Id = 6,
                Name = "BMW",
                Model = "M8",
                City = "Baku",
                Engine = 4.4,
                Mileage = 2500,
                Year = 2020,
                Price = 180000,
                PublishDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                View = 150,
            },

        };

        public List<Ad> GetAds()
        {
            return Ads;
        }

        public Ad GetOne(int Id)
        {
            var ad = Ads.FirstOrDefault(a => a.Id == Id);
            ad.View += 1;
            return ad;
        }

        public List<Ad> GetName(string Name)
        {
            return Ads.FindAll(x => x.Name.Contains(Name) || x.Model.Contains(Name)).ToList();
        }

        public void AddAd(Ad ad)
        {
            Ads.Add(ad);
        }

        public void RemoveAd(int id)
        {
            var Ad = Ads.FirstOrDefault(x => x.Id == id);
            Ads.Remove(Ad);
        }
    }
}
