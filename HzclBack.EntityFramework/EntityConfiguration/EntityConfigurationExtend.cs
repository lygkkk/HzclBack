using HzclBack.Abstract.Models.BaseInfoTable;
using HzclBack.Abstract.Models.CategoryInfoTable;
using Microsoft.EntityFrameworkCore;

namespace HzclBack.EntityFramework.EntityConfiguration
{
    public static class EntityConfigurationExtend
    {
        public static void ProductInfoConfig(this ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<ProductInfo>();
            entity.Property(e => e.BarCode).HasMaxLength(20);
            entity.Property(e => e.ModelSpecification).HasMaxLength(20);
            entity.Property(e => e.Code).HasMaxLength(20).IsRequired();
            entity.Property(e => e.Name).HasMaxLength(50).IsRequired();
            entity.Property(e => e.Remark).HasMaxLength(255);

            //entity.HasMany(e => e.)
        }

        public static void ProductCategoryInfoConfig(this ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<ProductCategoryInfo>();

            //entity.HasOne(e => e.ProductInfos).WithMany(e => e.)
        }

        public static void WarehouseInfoConfig(this ModelBuilder modelBuilder)
        {

        }


    }
}