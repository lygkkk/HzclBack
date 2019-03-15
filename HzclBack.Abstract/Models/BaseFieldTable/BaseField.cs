using System;

namespace HzclBack.Abstract.Models.BaseFieldTable
{
    public class BaseField
    {
        public Guid Id { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
    }
}