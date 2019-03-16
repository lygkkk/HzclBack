using System;
using System.Collections.Generic;
using HzclBack.Abstract.IService.IBaseInfoService;
using HzclBack.Abstract.Models.BaseInfoTable;
using HzclBack.EntityFramework;

namespace HzclBack.ServiceRealize.BaseInfoService
{
    public class EmployeeInfoService : IEmployeeInfoService
    {
        private readonly MariaDbContext _mariaDb;

        public EmployeeInfoService(MariaDbContext mariaDbContext)
        {
            this._mariaDb = mariaDbContext;
        }

        public int AddEmployeeInfo(EmployeeInfo employeeInfo)
        {
            throw new NotImplementedException();
        }

        public int AddEmployeeInfos(List<EmployeeInfo> employeeInfos)
        {
            throw new NotImplementedException();
        }

        public int UpdateEmployeeInfo(EmployeeInfo employeeInfo)
        {
            throw new NotImplementedException();
        }

        public int UpdateEmployeeInfos(List<EmployeeInfo> employeeInfos)
        {
            throw new NotImplementedException();
        }

        public EmployeeInfo GetEmployeeInfo(Func<EmployeeInfo, bool> @where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeInfo> GetEmployeeInfos(Func<EmployeeInfo, bool> @where)
        {
            throw new NotImplementedException();
        }
    }
}