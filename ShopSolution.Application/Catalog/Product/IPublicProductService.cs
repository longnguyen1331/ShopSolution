using ShopSolution.Application.Catalog.Product.Dtos;
using ShopSolution.Application.Catalog.Product.Dtos.Public;
using ShopSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Application.Catalog.Product
{
    public interface IPublicProductService
    {
        PagedResult<ProductViewModel> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
