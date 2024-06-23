using MB.Domain.ArticleCategoryAgg;
using MB.Infrastructure.EFCore.Mapping;
using Microsoft.EntityFrameworkCore;

namespace MB.Infrastructure.EFCore
{
    public class MasterBlogContext : DbContext
    {
        public DbSet<ArticleCategory> ArticleCategories { get; set; }
        public MasterBlogContext(DbContextOptions<MasterBlogContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleCategoryMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}