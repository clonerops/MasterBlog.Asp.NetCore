using MB.Domain.ArticleCategoryAgg;

namespace MB.Infrastructure.EFCore.Repository
{
    public class ArticleCategoryRepository : IArticleCategoryRepository
    {
        private readonly MasterBlogContext _context;

        public ArticleCategoryRepository(MasterBlogContext context)
        {
            _context = context;
        }

        public void Create(ArticleCategory entity)
        {
            throw new NotImplementedException();
            
        }

        public List<ArticleCategory> GetAll()
        {
            return _context.ArticleCategories.ToList();
        }
    }
}
