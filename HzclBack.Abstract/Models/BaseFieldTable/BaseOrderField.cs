using System;
using System.Collections.Generic;
using HzclBack.Abstract.Models.BaseInfoTable;

namespace HzclBack.Abstract.Models.BaseFieldTable
{
    public class BaseOrderField : BaseField
    {
        public DateTime OrderDateTime { get; set; }
        public string OrderNumber { get; set; }
        public int Quantity { get; set; }
        public string OrderSummary { get; set; }
        public string Remark { get; set; }


        public Guid ProductInfoId { get; set; }
        public virtual List<ProductInfo> ProductInfos { get; set; }
        public Guid WarehouseInfoId { get; set; }
        public virtual List<WarehouseInfo> WarehouseInfos { get; set; }
    }
}