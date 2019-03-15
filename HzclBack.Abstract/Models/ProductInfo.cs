using System;
using System.Collections.Generic;

namespace HzclBack.Abstract.Models
{
    public class ProductInfo :BaseInfoFiled
    {
        public string ModelSpecification { get; set; }
        public string BarCode { get; set; }
        public Guid ProductCategoryId { get; set; }
        public virtual ProductCategoryInfo ProductCategoryInfo { get; set; }
    }
}