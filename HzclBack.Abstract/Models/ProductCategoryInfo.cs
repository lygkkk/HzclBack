using System;
using System.Collections.Generic;

namespace HzclBack.Abstract.Models
{
    public class ProductCategoryInfo : BaseInfoFiled
    {
        public Guid ProductInfoId { get; set; }
        public virtual List<ProductInfo> ProductInfos { get; set; }
    }
}