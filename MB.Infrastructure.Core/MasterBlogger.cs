using MB.Application;
using MB.Application.contracts.Article;
using MB.Application.contracts.ArticleCategory;
using MB.Domain.ArticleAgg;
using MB.Domain.ArticleCategoryAgg;
using MB.Infrastructure.EFCore;
using MB.Infrastructure.EFCore.Repository;
using MB.Infrastructure.Query;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MB.Infrastructure.Core
{
    public static class MasterBlogger
    {
        public static void Config(IServiceCollection services, string connectionString)
        {

            services.AddTransient<IArticleApplication, ArticleApplication>();
            services.AddTransient<IArticleRepository, ArticleRepository>();

            services.AddTransient<IArticleCategoryApplication, ArticleCategoryApplication>();
            services.AddTransient<IArticleCategoryRepository, ArticleCategoryRepository>();

            services.AddTransient<IArticleQuery, ArticleQuery>();

            services.AddDbContext<MasterBlogContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
