using System;
using System.Collections.Generic;
using HzclBack.Abstract.Models.BaseInfoTable;
using HzclBack.Abstract.Models.CategoryInfoTable;

namespace HzclBack.Abstract.IService.ICategoryInfoService
{
    public interface IProductCategoryInfoService
    {
        int AddEmployeeInfo(ProductCategoryInfo productCategoryInfo);
        int AddEmployeeInfos(List<ProductCategoryInfo> productCategoryInfos);
        int UpdateEmployeeInfo(ProductCategoryInfo productCategoryInfo);
        int UpdateEmployeeInfos(List<ProductCategoryInfo> productCategoryInfos);
        ProductCategoryInfo GetEmployeeInfo(Func<ProductCategoryInfo, bool> where);
        IEnumerable<ProductCategoryInfo> GetEmployeeInfos(Func<ProductCategoryInfo, bool> where);
    }
}