using Microsoft.EntityFrameworkCore;
using TheHybridWatchStore.Server.Data.Models;

namespace TheHybridWatchStore.Server.Data
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Watch>().HasData(
            new Watch
            {
                Id = 1,
                Name = "Tissot T-Classic",
                Brand = "Tissot",
                Gender = "Unisex",
                Movement = "Automatic",
                Price = 899.99M,
                Description = "A classic watch with a modern touch.",
                Features = new List<string> { "23 Jewels", "Date Display", "Water Resistant" }
            },
            new Watch
            {
                Id = 2,
                Name = "Rolex Submariner",
                Brand = "Rolex",
                Gender = "Men",
                Movement = "Automatic",
                Price = 12500.00M,
                Description = "The Rolex Submariner is an iconic timepiece.",
                Features = new List<string> { "Water Resistant", "Chronometer", "Cerachrom Bezel" }
            },
            new Watch
            {
                Id = 3,
                Name = "Omega Speedmaster",
                Brand = "Omega",
                Gender = "Men",
                Movement = "Manual",
                Price = 5200.00M,
                Description = "The first watch worn on the moon.",
                Features = new List<string> { "Chronograph", "Tachymeter", "Hesalite Crystal" }
            },
            new Watch
            {
                Id = 4,
                Name = "Tag Heuer Carrera",
                Brand = "Tag Heuer",
                Gender = "Men",
                Movement = "Automatic",
                Price = 4500.00M,
                Description = "A racing-inspired watch with a contemporary design.",
                Features = new List<string> { "Chronograph", "Sapphire Crystal", "Water Resistant" }
            },
            new Watch
            {
                Id = 5,
                Name = "Cartier Tank",
                Brand = "Cartier",
                Gender = "Women",
                Movement = "Quartz",
                Price = 3100.00M,
                Description = "An elegant and timeless piece.",
                Features = new List<string> { "Sapphire Crystal", "Water Resistant", "Diamond Bezel" }
            }
        );
            modelBuilder.Entity<WatchSpecs>().HasData(
            new WatchSpecs
            {
                SpecsId = 1,
                WatchId = 1,
                CaseMaterial = "Stainless Steel",
                StrapMaterial = "Leather",
                DialColor = "Blue",
                CaseShape = "Round",
                CaseDiameter = 40.0,
                CaseThickness = 10.0,
                WaterResistanceDepth = 50,
                Engine = "Caliber: ETA C07.111",
                PowerReserve = 80
            },
            new WatchSpecs
            {
                SpecsId = 2,
                WatchId = 2,
                CaseMaterial = "Stainless Steel",
                StrapMaterial = "Oyster Steel",
                DialColor = "Black",
                CaseShape = "Round",
                CaseDiameter = 41.0,
                CaseThickness = 12.5,
                WaterResistanceDepth = 300,
                Engine = "Caliber 3230",
                PowerReserve = 70
            },
            new WatchSpecs
            {
                SpecsId = 3,
                WatchId = 3,
                CaseMaterial = "Stainless Steel",
                StrapMaterial = "Stainless Steel",
                DialColor = "Black",
                CaseShape = "Round",
                CaseDiameter = 42.0,
                CaseThickness = 14.3,
                WaterResistanceDepth = 50,
                Engine = "Caliber 1861",
                PowerReserve = 48
            },
            new WatchSpecs
            {
                SpecsId = 4,
                WatchId = 4,
                CaseMaterial = "Stainless Steel",
                StrapMaterial = "Leather",
                DialColor = "Black",
                CaseShape = "Round",
                CaseDiameter = 43.0,
                CaseThickness = 15.0,
                WaterResistanceDepth = 100,
                Engine = "Caliber Heuer 02",
                PowerReserve = 80
            },
            new WatchSpecs
            {
                SpecsId = 5,
                WatchId = 5,
                CaseMaterial = "18K Yellow Gold",
                StrapMaterial = "Leather",
                DialColor = "White",
                CaseShape = "Square",
                CaseDiameter = 29.5,
                CaseThickness = 6.6,
                WaterResistanceDepth = 30,
                Engine = "Caliber 076",
                PowerReserve = 36
            }
        );
            modelBuilder.Entity<WatchImage>().HasData(
                // Multiple images for Watch 1
                new WatchImage
                {
                    ImagesId = 1,
                    WatchId = 1,
                    ImagePath = "assets/imgs/watches/1-1.jpg"
                },
                new WatchImage
                {
                    ImagesId = 2,
                    WatchId = 1,
                    ImagePath = "assets/imgs/watches/1-2.jpg"
                },
                // Multiple images for Watch 2
                new WatchImage
                {
                    ImagesId = 3,
                    WatchId = 2,
                    ImagePath = "assets/imgs/watches/2-1.jpg"
                },
                new WatchImage
                {
                    ImagesId = 4,
                    WatchId = 2,
                    ImagePath = "assets/imgs/watches/2-2.jpg"
                },
                new WatchImage
                {
                    ImagesId = 5,
                    WatchId = 3,
                    ImagePath = "assets/imgs/watches/3-1.jpg"
                },
                new WatchImage
                {
                    ImagesId = 6,
                    WatchId = 3,
                    ImagePath = "assets/imgs/watches/3-2.jpg"
                },
                new WatchImage
                {
                    ImagesId = 7,
                    WatchId = 4,
                    ImagePath = "assets/imgs/watches/4-1.jpg"
                },
                new WatchImage
                {
                    ImagesId = 8,
                    WatchId = 4,
                    ImagePath = "assets/imgs/watches/4-2.jpg"
                },
                new WatchImage
                {
                    ImagesId = 9,
                    WatchId = 5,
                    ImagePath = "assets/imgs/watches/5-1.jpg"
                },
                new WatchImage
                {
                    ImagesId = 10,
                    WatchId = 5,
                    ImagePath = "assets/imgs/watches/5-2.jpg"
                }
            );

            modelBuilder.Entity<Watch>().HasData(
    new Watch
    {
        Id = 6,
        Name = "Breitling Navitimer",
        Brand = "Breitling",
        Gender = "Men",
        Movement = "Automatic",
        Price = 7000.00M,
        Description = "A classic aviation-inspired timepiece.",
        Features = new List<string> { "Chronograph", "Slide Rule Bezel", "Water Resistant" }
    },
    new Watch
    {
        Id = 7,
        Name = "IWC Portugieser",
        Brand = "IWC",
        Gender = "Men",
        Movement = "Automatic",
        Price = 12500.00M,
        Description = "A sophisticated dress watch with a modern design.",
        Features = new List<string> { "Chronograph", "Sapphire Crystal", "Water Resistant" }
    },
    new Watch
    {
        Id = 8,
        Name = "Panerai Luminor",
        Brand = "Panerai",
        Gender = "Men",
        Movement = "Automatic",
        Price = 8500.00M,
        Description = "A bold and rugged timepiece with Italian flair.",
        Features = new List<string> { "Power Reserve Indicator", "Date Display", "Water Resistant" }
    },
    new Watch
    {
        Id = 9,
        Name = "Jaeger-LeCoultre Reverso",
        Brand = "Jaeger-LeCoultre",
        Gender = "Men",
        Movement = "Manual",
        Price = 10000.00M,
        Description = "An iconic watch with a reversible case.",
        Features = new List<string> { "Sapphire Crystal", "Water Resistant", "Reversible Case" }
    },
    new Watch
    {
        Id = 10,
        Name = "Audemars Piguet Royal Oak",
        Brand = "Audemars Piguet",
        Gender = "Men",
        Movement = "Automatic",
        Price = 22000.00M,
        Description = "A luxury sports watch with an iconic design.",
        Features = new List<string> { "Sapphire Crystal", "Chronograph", "Water Resistant" }
    },
    new Watch
    {
        Id = 11,
        Name = "Chanel J12",
        Brand = "Chanel",
        Gender = "Women",
        Movement = "Automatic",
        Price = 5000.00M,
        Description = "A stylish and modern ceramic watch.",
        Features = new List<string> { "Ceramic Case", "Sapphire Crystal", "Water Resistant" }
    },
    new Watch
    {
        Id = 12,
        Name = "Bulgari Serpenti",
        Brand = "Bulgari",
        Gender = "Women",
        Movement = "Quartz",
        Price = 8000.00M,
        Description = "An elegant and distinctive watch with a snake motif.",
        Features = new List<string> { "Diamond Bezel", "Sapphire Crystal", "Water Resistant" }
    },
    new Watch
    {
        Id = 13,
        Name = "Rolex Lady-Datejust",
        Brand = "Rolex",
        Gender = "Women",
        Movement = "Automatic",
        Price = 9000.00M,
        Description = "A timeless and elegant watch for women.",
        Features = new List<string> { "Date Display", "Sapphire Crystal", "Water Resistant" }
    },
    new Watch
    {
        Id = 14,
        Name = "Omega Constellation",
        Brand = "Omega",
        Gender = "Women",
        Movement = "Automatic",
        Price = 7500.00M,
        Description = "A luxurious and refined timepiece.",
        Features = new List<string> { "Diamond Bezel", "Sapphire Crystal", "Water Resistant" }
    },
    new Watch
    {
        Id = 15,
        Name = "Cartier Ballon Bleu",
        Brand = "Cartier",
        Gender = "Women",
        Movement = "Automatic",
        Price = 6000.00M,
        Description = "A graceful and iconic watch with a unique shape.",
        Features = new List<string> { "Sapphire Crystal", "Water Resistant", "Diamond Markers" }
    },
    new Watch
    {
        Id = 16,
        Name = "Apple Watch Series 7",
        Brand = "Apple",
        Gender = "Unisex",
        Movement = "Smart",
        Price = 399.99M,
        Description = "The latest Apple Watch with advanced health features.",
        Features = new List<string> { "Heart Rate Monitor", "GPS", "Water Resistant" }
    },
    new Watch
    {
        Id = 17,
        Name = "Samsung Galaxy Watch 5",
        Brand = "Samsung",
        Gender = "Unisex",
        Movement = "Smart",
        Price = 349.99M,
        Description = "A powerful smartwatch with fitness tracking.",
        Features = new List<string> { "Sleep Tracking", "GPS", "Water Resistant" }
    },
    new Watch
    {
        Id = 18,
        Name = "Garmin Fenix 6",
        Brand = "Garmin",
        Gender = "Unisex",
        Movement = "Smart",
        Price = 599.99M,
        Description = "A rugged smartwatch for outdoor adventures.",
        Features = new List<string> { "GPS", "Pulse Ox Sensor", "Water Resistant" }
    },
    new Watch
    {
        Id = 19,
        Name = "Fitbit Sense",
        Brand = "Fitbit",
        Gender = "Unisex",
        Movement = "Smart",
        Price = 329.99M,
        Description = "A smartwatch with advanced health and fitness features.",
        Features = new List<string> { "Heart Rate Monitor", "ECG App", "Water Resistant" }
    },
    new Watch
    {
        Id = 20,
        Name = "Fossil Gen 6",
        Brand = "Fossil",
        Gender = "Unisex",
        Movement = "Smart",
        Price = 299.99M,
        Description = "A stylish smartwatch with Wear OS.",
        Features = new List<string> { "Google Assistant", "GPS", "Water Resistant" }
    }
);
            modelBuilder.Entity<WatchSpecs>().HasData(
    // Specs for Men's Watches
    new WatchSpecs
    {
        SpecsId = 6,
        WatchId = 6,
        CaseMaterial = "Stainless Steel",
        StrapMaterial = "Leather",
        DialColor = "Black",
        CaseShape = "Round",
        CaseDiameter = 43.0,
        CaseThickness = 14.5,
        WaterResistanceDepth = 30,
        Engine = "Caliber Breitling 01",
        PowerReserve = 70
    },
    new WatchSpecs
    {
        SpecsId = 7,
        WatchId = 7,
        CaseMaterial = "18K Rose Gold",
        StrapMaterial = "Leather",
        DialColor = "Silver",
        CaseShape = "Round",
        CaseDiameter = 41.0,
        CaseThickness = 12.3,
        WaterResistanceDepth = 30,
        Engine = "Caliber 69355",
        PowerReserve = 46
    },
    new WatchSpecs
    {
        SpecsId = 8,
        WatchId = 8,
        CaseMaterial = "Titanium",
        StrapMaterial = "Rubber",
        DialColor = "Black",
        CaseShape = "Cushion",
        CaseDiameter = 44.0,
        CaseThickness = 15.6,
        WaterResistanceDepth = 300,
        Engine = "Caliber P.9010",
        PowerReserve = 72
    },
    new WatchSpecs
    {
        SpecsId = 9,
        WatchId = 9,
        CaseMaterial = "Stainless Steel",
        StrapMaterial = "Leather",
        DialColor = "Silver",
        CaseShape = "Rectangle",
        CaseDiameter = 28.8,
        CaseThickness = 9.5,
        WaterResistanceDepth = 30,
        Engine = "Caliber 822",
        PowerReserve = 45
    },
    new WatchSpecs
    {
        SpecsId = 10,
        WatchId = 10,
        CaseMaterial = "Stainless Steel",
        StrapMaterial = "Stainless Steel",
        DialColor = "Blue",
        CaseShape = "Octagonal",
        CaseDiameter = 41.0,
        CaseThickness = 10.4,
        WaterResistanceDepth = 50,
        Engine = "Caliber 2385",
        PowerReserve = 40
    },
    // Specs for Women's Watches
    new WatchSpecs
    {
        SpecsId = 11,
        WatchId = 11,
        CaseMaterial = "Ceramic",
        StrapMaterial = "Ceramic",
        DialColor = "White",
        CaseShape = "Round",
        CaseDiameter = 38.0,
        CaseThickness = 11.5,
        WaterResistanceDepth = 200,
        Engine = "Caliber 12.1",
        PowerReserve = 70
    },
    new WatchSpecs
    {
        SpecsId = 12,
        WatchId = 12,
        CaseMaterial = "18K Rose Gold",
        StrapMaterial = "Leather",
        DialColor = "Pink",
        CaseShape = "Teardrop",
        CaseDiameter = 35.0,
        CaseThickness = 7.5,
        WaterResistanceDepth = 30,
        Engine = "Caliber B033",
        PowerReserve = 42
    },
    new WatchSpecs
    {
        SpecsId = 13,
        WatchId = 13,
        CaseMaterial = "Stainless Steel",
        StrapMaterial = "Oyster Steel",
        DialColor = "Silver",
        CaseShape = "Round",
        CaseDiameter = 28.0,
        CaseThickness = 10.5,
        WaterResistanceDepth = 100,
        Engine = "Caliber 2235",
        PowerReserve = 48
    },
    new WatchSpecs
    {
        SpecsId = 14,
        WatchId = 14,
        CaseMaterial = "Stainless Steel",
        StrapMaterial = "Leather",
        DialColor = "Mother of Pearl",
        CaseShape = "Round",
        CaseDiameter = 32.0,
        CaseThickness = 10.5,
        WaterResistanceDepth = 100,
        Engine = "Caliber 8800",
        PowerReserve = 55
    },
    new WatchSpecs
    {
        SpecsId = 15,
        WatchId = 15,
        CaseMaterial = "Stainless Steel",
        StrapMaterial = "Leather",
        DialColor = "Silver",
        CaseShape = "Round",
        CaseDiameter = 36.6,
        CaseThickness = 12.1,
        WaterResistanceDepth = 30,
        Engine = "Caliber 076",
        PowerReserve = 36
    },
    // Specs for Smart Watches
    new WatchSpecs
    {
        SpecsId = 16,
        WatchId = 16,
        CaseMaterial = "Aluminum",
        StrapMaterial = "Fluoroelastomer",
        DialColor = "Black",
        CaseShape = "Rectangle",
        CaseDiameter = 45.0,
        CaseThickness = 10.7,
        WaterResistanceDepth = 50,
        Engine = "Apple S7",
        PowerReserve = 18
    },
    new WatchSpecs
    {
        SpecsId = 17,
        WatchId = 17,
        CaseMaterial = "Stainless Steel",
        StrapMaterial = "Leather",
        DialColor = "Silver",
        CaseShape = "Round",
        CaseDiameter = 44.0,
        CaseThickness = 11.1,
        WaterResistanceDepth = 50,
        Engine = "Exynos W920",
        PowerReserve = 40
    },
    new WatchSpecs
    {
        SpecsId = 18,
        WatchId = 18,
        CaseMaterial = "Fiber-reinforced polymer",
        StrapMaterial = "Silicone",
        DialColor = "Black",
        CaseShape = "Round",
        CaseDiameter = 47.0,
        CaseThickness = 15.8,
        WaterResistanceDepth = 100,
        Engine = "Garmin",
        PowerReserve = 336
    },
    new WatchSpecs
    {
        SpecsId = 19,
        WatchId = 19,
        CaseMaterial = "Stainless Steel",
        StrapMaterial = "Silicone",
        DialColor = "Black",
        CaseShape = "Square",
        CaseDiameter = 40.5,
        CaseThickness = 12.4,
        WaterResistanceDepth = 50,
        Engine = "Fitbit OS",
        PowerReserve = 72
    },
    new WatchSpecs
    {
        SpecsId = 20,
        WatchId = 20,
        CaseMaterial = "Stainless Steel",
        StrapMaterial = "Leather",
        DialColor = "Black",
        CaseShape = "Round",
        CaseDiameter = 44.0,
        CaseThickness = 12.5,
        WaterResistanceDepth = 30,
        Engine = "Snapdragon Wear 4100+",
        PowerReserve = 24
    }
);
            modelBuilder.Entity<WatchImage>().HasData(
    // Images for Men's Watches
    new WatchImage
    {
        ImagesId = 11,
        WatchId = 6,
        ImagePath = "assets/imgs/watches/6-1.jpg"
    },
    new WatchImage
    {
        ImagesId = 12,
        WatchId = 6,
        ImagePath = "assets/imgs/watches/6-2.jpg"
    },
    new WatchImage
    {
        ImagesId = 13,
        WatchId = 7,
        ImagePath = "assets/imgs/watches/7-1.jpg"
    },
    new WatchImage
    {
        ImagesId = 14,
        WatchId = 7,
        ImagePath = "assets/imgs/watches/7-2.jpg"
    },
    new WatchImage
    {
        ImagesId = 15,
        WatchId = 8,
        ImagePath = "assets/imgs/watches/8-1.jpg"
    },
    new WatchImage
    {
        ImagesId = 16,
        WatchId = 8,
        ImagePath = "assets/imgs/watches/8-2.jpg"
    },
    new WatchImage
    {
        ImagesId = 17,
        WatchId = 9,
        ImagePath = "assets/imgs/watches/9-1.jpg"
    },
    new WatchImage
    {
        ImagesId = 18,
        WatchId = 9,
        ImagePath = "assets/imgs/watches/9-2.jpg"
    },
    new WatchImage
    {
        ImagesId = 19,
        WatchId = 10,
        ImagePath = "assets/imgs/watches/10-1.jpg"
    },
    new WatchImage
    {
        ImagesId = 20,
        WatchId = 10,
        ImagePath = "assets/imgs/watches/10-2.jpg"
    },
    // Images for Women's Watches
    new WatchImage
    {
        ImagesId = 21,
        WatchId = 11,
        ImagePath = "assets/imgs/watches/11-1.jpg"
    },
    new WatchImage
    {
        ImagesId = 22,
        WatchId = 11,
        ImagePath = "assets/imgs/watches/11-2.jpg"
    },
    new WatchImage
    {
        ImagesId = 23,
        WatchId = 12,
        ImagePath = "assets/imgs/watches/12-1.jpg"
    },
    new WatchImage
    {
        ImagesId = 24,
        WatchId = 12,
        ImagePath = "assets/imgs/watches/12-2.jpg"
    },
    new WatchImage
    {
        ImagesId = 25,
        WatchId = 13,
        ImagePath = "assets/imgs/watches/13-1.jpg"
    },
    new WatchImage
    {
        ImagesId = 26,
        WatchId = 13,
        ImagePath = "assets/imgs/watches/13-2.jpg"
    },
    new WatchImage
    {
        ImagesId = 27,
        WatchId = 14,
        ImagePath = "assets/imgs/watches/14-1.jpg"
    },
    new WatchImage
    {
        ImagesId = 28,
        WatchId = 14,
        ImagePath = "assets/imgs/watches/14-2.jpg"
    },
    new WatchImage
    {
        ImagesId = 29,
        WatchId = 15,
        ImagePath = "assets/imgs/watches/15-1.jpg"
    },
    new WatchImage
    {
        ImagesId = 30,
        WatchId = 15,
        ImagePath = "assets/imgs/watches/15-2.jpg"
    },
    // Images for Smart Watches
    new WatchImage
    {
        ImagesId = 31,
        WatchId = 16,
        ImagePath = "assets/imgs/watches/16-1.jpg"
    },
    new WatchImage
    {
        ImagesId = 32,
        WatchId = 16,
        ImagePath = "assets/imgs/watches/16-2.jpg"
    },
    new WatchImage
    {
        ImagesId = 33,
        WatchId = 17,
        ImagePath = "assets/imgs/watches/17-1.jpg"
    },
    new WatchImage
    {
        ImagesId = 34,
        WatchId = 17,
        ImagePath = "assets/imgs/watches/17-2.jpg"
    },
    new WatchImage
    {
        ImagesId = 35,
        WatchId = 18,
        ImagePath = "assets/imgs/watches/18-1.jpg"
    },
    new WatchImage
    {
        ImagesId = 36,
        WatchId = 18,
        ImagePath = "assets/imgs/watches/18-2.jpg"
    },
    new WatchImage
    {
        ImagesId = 37,
        WatchId = 19,
        ImagePath = "assets/imgs/watches/19-1.jpg"
    },
    new WatchImage
    {
        ImagesId = 38,
        WatchId = 19,
        ImagePath = "assets/imgs/watches/19-2.jpg"
    },
    new WatchImage
    {
        ImagesId = 39,
        WatchId = 20,
        ImagePath = "assets/imgs/watches/20-1.jpg"
    },
    new WatchImage
    {
        ImagesId = 40,
        WatchId = 20,
        ImagePath = "assets/imgs/watches/20-1.jpg"

    }
    );
        }
    }

}
