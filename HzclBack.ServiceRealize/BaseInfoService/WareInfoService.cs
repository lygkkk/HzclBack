using System;
using System.Collections.Generic;
using HzclBack.Abstract.IService.IBaseInfoService;
using HzclBack.Abstract.Models.BaseInfoTable;
using HzclBack.EntityFramework;

namespace HzclBack.ServiceRealize.BaseInfoService
{
    public class WareInfoService : IWarehouseInfoService
    {
        private readonly MariaDbContext _mariaDb;

        public WareInfoService(MariaDbContext mariaDbContext)
        {
            this._mariaDb = mariaDbContext;
        }

        public int AddEmployeeInfo(WarehouseInfo warehouseInfo)
        {
            throw new NotImplementedException();
        }

        public int AddEmployeeInfos(List<WarehouseInfo> warehouseInfos)
        {
            throw new NotImplementedException();
        }

        public int UpdateEmployeeInfo(WarehouseInfo warehouseInfo)
        {
            throw new NotImplementedException();
        }

        public int UpdateEmployeeInfos(List<WarehouseInfo> warehouseInfos)
        {
            throw new NotImplementedException();
        }

        public WarehouseInfo GetEmployeeInfo(Func<WarehouseInfo, bool> @where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WarehouseInfo> GetEmployeeInfos(Func<WarehouseInfo, bool> @where)
        {
            throw new NotImplementedException();
        }
    }
}