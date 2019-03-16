using Microsoft.EntityFrameworkCore;
using HzclBack.Abstract.Models.BaseInfoTable;
using HzclBack.Abstract.Models.CategoryInfoTable;
using HzclBack.Abstract.Models.OrderInfoTable;

namespace HzclBack.EntityFramework
{
    public sealed class MariaDbContext : DbContext
    {
        public DbSet<ProductInfo> ProductInfos { get; set; }
        public DbSet<EmployeeInfo> EmployeeInfos { get; set; }
        public DbSet<ProductCategoryInfo> ProductCategoryInfos { get; set; }
        public DbSet<WarehouseInfo> WarehouseInfos { get; set; }
        public DbSet<InboundOrderInfo> InboundOrders { get; set; }
        public DbSet<RequisitionOrderInfo> RequisitionOrders { get; set; }

        public MariaDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}