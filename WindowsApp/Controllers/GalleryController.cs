using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WindowsApp.Models;

namespace WindowsApp.Controllers
{
    public class GalleryController : Controller
    {
        private static List<Photo> photos = new List<Photo>
        {
            // city lights
            new Photo { Id = 1, Location = "New York, United States", Description = "Blurred Shot of a City at Night.", ImageUrl = "https://images.pexels.com/photos/1668928/pexels-photo-1668928.jpeg" },
            new Photo { Id = 2, Location = "Dubai, Dubai, United Arab Emirates", Description = "Timelapse Cityscape Photography during Night Time.", ImageUrl = "https://images.pexels.com/photos/599982/pexels-photo-599982.jpeg" },
            new Photo { Id = 3, Location = "Ho Chi Minh City, Vietnam", Description = "Photography of a City at night", ImageUrl = "https://images.pexels.com/photos/1137525/pexels-photo-1137525.jpeg" },
            new Photo { Id = 4, Location = "Dubai, Dubai, United Arab Emirates", Description = "City Buildings With Lights", ImageUrl = "https://images.pexels.com/photos/809060/pexels-photo-809060.jpeg" },
            
            // sea images
            new Photo { Id = 5, Location = "Laamu Atoll, South Central Province, Maldives", Description = "Green Trees Near Seashore Under Blue Sky.", ImageUrl = "https://images.pexels.com/photos/457878/pexels-photo-457878.jpeg" },
            new Photo { Id = 6, Location = "Zakynthos, Greece", Description = "Blue Sea Under Clear Blue Sky.", ImageUrl = "https://images.pexels.com/photos/50594/sea-bay-waterfront-beach-50594.jpeg" },
            new Photo { Id = 7, Location = "Bol, Croatia", Description = "Bird's Eye View Photo Of Island", ImageUrl = "https://images.pexels.com/photos/1433052/pexels-photo-1433052.jpeg" },
            new Photo { Id = 8, Location = "Positano, Italy", Description = "High-angle Photography of Sailing Boats", ImageUrl = "https://images.pexels.com/photos/919234/pexels-photo-919234.jpeg" },
            
            //forest images
            new Photo { Id = 9, Location = "Cappadocia, Turkey", Description = "Hot Air Balloon", ImageUrl = "https://images.pexels.com/photos/2325447/pexels-photo-2325447.jpeg" },
            new Photo { Id = 10, Location = "Iceland", Description = "Empty Highway Overlooking Mountain Under Dark Skies.", ImageUrl = "https://images.pexels.com/photos/1955134/pexels-photo-1955134.jpeg" },
            new Photo { Id = 11, Location = "Los Angeles, United State", Description = "Road in City during Sunset", ImageUrl = "https://images.pexels.com/photos/248159/pexels-photo-248159.jpeg" },
            new Photo { Id = 12, Location = "Colibița, BN, Romania", Description = "Lit Bonfire Outdoors during Nighttime", ImageUrl = "https://images.pexels.com/photos/1368382/pexels-photo-1368382.jpeg" },

        };

        public ActionResult Index()
        {
            return View(photos);
        }

        public ActionResult Details(int id)
        {
            var photo = photos.FirstOrDefault(p => p.Id == id);
            if (photo == null) return HttpNotFound();
            return View(photo);
        }
    }
}