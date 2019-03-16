using System;
using System.Collections.Generic;
using HzclBack.Abstract.Models.BaseInfoTable;

namespace HzclBack.Abstract.IService.IBaseInfoService
{
    public interface IWarehouseInfoService
    {
        int AddEmployeeInfo(WarehouseInfo warehouseInfo);
        int AddEmployeeInfos(List<WarehouseInfo> warehouseInfos);
        int UpdateEmployeeInfo(WarehouseInfo warehouseInfo);
        int UpdateEmployeeInfos(List<WarehouseInfo> warehouseInfos);
        WarehouseInfo GetEmployeeInfo(Func<WarehouseInfo, bool> where);
        IEnumerable<WarehouseInfo> GetEmployeeInfos(Func<WarehouseInfo, bool> where);
    }
}