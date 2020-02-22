using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Application.Catalog.Product.Dtos.Manage
{
    public class ProductUpdateRequest
    {
        public int Id { set; get; }
        public string Description { set; get; }
        public string Details { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public string SeoAlias { get; set; }
        public int LanguageId { set; get; }
    }
}
