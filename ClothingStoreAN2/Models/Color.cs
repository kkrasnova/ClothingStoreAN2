﻿namespace ClothingStoreAN2.Models
{
    public class Color
    {
        public int Id { get; set; }

        public string? ColorName { get; set; }

        public virtual ICollection<Products> Products { get; set; } = new List<Products>();//багато (сюди йде)
    }
}
