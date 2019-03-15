using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using HzclBack.Abstract.IBaseInfoService;
using HzclBack.Abstract.Models.BaseInfoTable;
using HzclBack.EntityFramework;

namespace HzclBack.ServiceRealize
{
    public class ProductInfoService : IProductInfoService
    {
        private readonly MariaDbContext _mariaDb;

        public ProductInfoService(MariaDbContext mariaDbContext)
        {
            this._mariaDb = mariaDbContext;
        }

        public int AddProductInfo(ProductInfo productInfo)
        {
            _mariaDb.ProductInfos.Add(productInfo);
            return _mariaDb.SaveChanges();
        }

        public int AddProductInfos(List<ProductInfo> productInfos)
        {
            _mariaDb.ProductInfos.AddRange(productInfos);
            return _mariaDb.SaveChanges();
        }

        public int UpdateProductInfo(ProductInfo productInfo)
        {
            _mariaDb.ProductInfos.Update(productInfo);
            return _mariaDb.SaveChanges();
        }

        public int UpdateProductInfos(List<ProductInfo> productInfos)
        {
            _mariaDb.ProductInfos.UpdateRange(productInfos);
            return _mariaDb.SaveChanges();
        }

        public ProductInfo GetProductInfo(Func<ProductInfo, bool> @where)
        {
            return _mariaDb.ProductInfos.Single(where);
        }

        public IEnumerable<ProductInfo> GProductInfos(Func<ProductInfo, bool> @where)
        {
            return _mariaDb.ProductInfos.Where(where);
        }
    }
}