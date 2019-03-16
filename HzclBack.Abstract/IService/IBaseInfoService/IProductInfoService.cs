using System;
using System.Collections.Generic;
using HzclBack.Abstract.Models.BaseInfoTable;

namespace HzclBack.Abstract.IService.IBaseInfoService
{
    public interface IProductInfoService
    {
        int AddProductInfo(ProductInfo productInfo);
        int AddProductInfos(List<ProductInfo> productInfos);
        int UpdateProductInfo(ProductInfo productInfo);
        int UpdateProductInfos(List<ProductInfo> productInfos);
        ProductInfo GetProductInfo(Func<ProductInfo, bool> where);
        IEnumerable<ProductInfo> GProductInfos(Func<ProductInfo, bool> where);
    }
}