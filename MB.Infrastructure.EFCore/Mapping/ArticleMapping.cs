using MB.Domain.ArticleAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MB.Infrastructure.EFCore.Mapping
{
    public class ArticleMapping : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.ToTable("Articles");
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.ArticleCategory)
                .WithMany(x => x.Articles)
                .HasForeignKey(x => x.ArticleCategoryId);
        }
    }
}
