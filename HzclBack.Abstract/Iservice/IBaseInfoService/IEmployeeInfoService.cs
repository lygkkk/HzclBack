using System;
using System.Collections.Generic;
using HzclBack.Abstract.Models.BaseInfoTable;

namespace HzclBack.Abstract.IService.IBaseInfoService
{
    public interface IEmployeeInfoService
    {
        int AddEmployeeInfo(EmployeeInfo employeeInfo);
        int AddEmployeeInfos(List<EmployeeInfo> employeeInfos);
        int UpdateEmployeeInfo(EmployeeInfo employeeInfo);
        int UpdateEmployeeInfos(List<EmployeeInfo> employeeInfos);
        EmployeeInfo GetEmployeeInfo(Func<EmployeeInfo, bool> where);
        IEnumerable<EmployeeInfo> GetEmployeeInfos(Func<EmployeeInfo, bool> where);
    }
}