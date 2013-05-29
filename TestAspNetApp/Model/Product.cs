﻿namespace TestAspNetApp.Model
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }         
    }

    internal class Category 
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}