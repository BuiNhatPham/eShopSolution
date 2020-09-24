using eShopSolution.Application.Catalog.DtoCommon;

namespace eShopSolution.Application.Catalog.Products.Dtos.Public
{
   public class GetProductPagingRequest :PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
