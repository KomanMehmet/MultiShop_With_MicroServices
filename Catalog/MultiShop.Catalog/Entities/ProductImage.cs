﻿namespace MultiShop.Catalog.Entities
{
    public class ProductImage
    {
        public string ProductImagesID { get; set; }

        public string ProductImage1 { get; set;}

        public string ProductImage2 { get; set;}

        public string ProductImage3 { get; set;}

        public string ProductID { get; set; }

        public Product Product { get; set; }
    }
}