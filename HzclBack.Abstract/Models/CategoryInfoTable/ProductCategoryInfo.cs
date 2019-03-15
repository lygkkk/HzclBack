using System;
using System.Collections.Generic;
using HzclBack.Abstract.Models.BaseFieldTable;
using HzclBack.Abstract.Models.BaseInfoTable;

namespace HzclBack.Abstract.Models.CategoryInfoTable
{
    public class ProductCategoryInfo : BaseInfoFiled
    {
        public Guid ProductInfoId { get; set; }
        public virtual List<ProductInfo> ProductInfos { get; set; }
    }
}