﻿namespace ShopManagement.Application.Contracts.Product
{
    public class CreateProduct
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public double UnitPrice { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string Seller { get; set; }
        public string PreparationTime { get; set; }
        public long CategoryId { get; set; }
        public string Slug { get; set; }
        public string Keywords { get; set; }
        public string MetaDescription { get; set; }
    }
}
