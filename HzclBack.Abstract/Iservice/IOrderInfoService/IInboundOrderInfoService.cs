using System;
using System.Collections.Generic;
using HzclBack.Abstract.Models.CategoryInfoTable;
using HzclBack.Abstract.Models.OrderInfoTable;

namespace HzclBack.Abstract.IService.IOrderInfoService
{
    public interface IInboundOrderInfoService
    {
        int AddEmployeeInfo(InboundOrderInfo inboundOrderInfo);
        int AddEmployeeInfos(List<InboundOrderInfo> inboundOrderInfos);
        int UpdateEmployeeInfo(InboundOrderInfo inboundOrderInfo);
        int UpdateEmployeeInfos(List<InboundOrderInfo> inboundOrderInfos);
        InboundOrderInfo GetEmployeeInfo(Func<InboundOrderInfo, bool> where);
        IEnumerable<InboundOrderInfo> GetEmployeeInfos(Func<InboundOrderInfo, bool> where);
    }
}