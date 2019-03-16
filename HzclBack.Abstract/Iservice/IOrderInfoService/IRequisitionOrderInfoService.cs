using System;
using System.Collections.Generic;
using HzclBack.Abstract.Models.OrderInfoTable;

namespace HzclBack.Abstract.IService.IOrderInfoService
{
    public interface IRequisitionOrderInfoService
    {
        int AddEmployeeInfo(RequisitionOrderInfo requisitionOrderInfo);
        int AddEmployeeInfos(List<RequisitionOrderInfo> requisitionOrderInfos);
        int UpdateEmployeeInfo(RequisitionOrderInfo requisitionOrderInfo);
        int UpdateEmployeeInfos(List<RequisitionOrderInfo> requisitionOrderInfos);
        RequisitionOrderInfo GetEmployeeInfo(Func<RequisitionOrderInfo, bool> where);
        IEnumerable<RequisitionOrderInfo> GetEmployeeInfos(Func<RequisitionOrderInfo, bool> where);
    }
}