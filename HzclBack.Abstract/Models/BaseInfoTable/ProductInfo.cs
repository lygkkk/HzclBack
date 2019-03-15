using System;
using HzclBack.Abstract.Models.BaseFieldTable;
using HzclBack.Abstract.Models.CategoryInfoTable;

namespace HzclBack.Abstract.Models.BaseInfoTable
{
    public class ProductInfo :BaseInfoFiled
    {
        public string ModelSpecification { get; set; }
        public string BarCode { get; set; }
        public Guid ProductCategoryId { get; set; }
        public virtual ProductCategoryInfo ProductCategoryInfo { get; set; }
    }
}