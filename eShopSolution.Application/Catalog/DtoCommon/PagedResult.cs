using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Application.Catalog.DtoCommon
{
   public class PagedResult<T>
    {
       public List<T> Items { set; get; }
        public int TotalRecord { get; set; }
    }
}
