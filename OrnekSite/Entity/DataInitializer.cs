using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrnekSite.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    { 
  
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>
            {
                new Category(){Name="KAMERA",Description="Kamera Ürünleri"},
                new Category(){Name="TELEFON",Description="Telefon Ürünleri"},
                new Category(){Name="BİLGİSAYAR",Description="Bilgisayar Ürünleri"}
            };
            foreach (var kategori in kategoriler)
            {
                context.Categoris.Add(kategori);
            }
            context.SaveChanges();
            var urunler = new List<Product>()
            {
                new Product(){Name="Canon", Description="Kamera Ürünleri", Price=2500,Stock=125, IsHome=true, IsApproved=true,IsFeatured=false, Slider=true, CategoryId=1, image="1.jpg"},
                new Product(){Name="Asus", Description="Bilgisayar Ürünleri", Price=2000,Stock=100, IsHome=true, IsApproved=true,IsFeatured=true, Slider=true, CategoryId=3, image="2.jpg"},
                new Product(){Name="Lenovo", Description="Bilgisayar Ürünleri", Price=3500,Stock=50, IsHome=false, IsApproved=true,IsFeatured=true, Slider=false, CategoryId=3, image="3.jpg"},
                new Product(){Name="Samsung 6s", Description="Telefon Ürünleri", Price=5000,Stock=150, IsHome=true, IsApproved=true,IsFeatured=true, Slider=true, CategoryId=2, image="4.jpg"},
            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}