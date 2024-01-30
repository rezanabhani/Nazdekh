using System.Collections.Generic;

namespace ShopManagement.Application.Contracts.ProductCategory
{
    public class EditProductCategory : CreateProductCategory
    {
        public long Id { get; set; }
        public List<ProductCategoryViewModel> ParentCategories { get; set; }
    }

}
