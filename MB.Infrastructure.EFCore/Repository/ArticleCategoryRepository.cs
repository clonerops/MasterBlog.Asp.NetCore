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
            _context.ArticleCategories.Add(entity);
            SaveChanges();


        }

        public List<ArticleCategory> GetAll()
        {
            return _context.ArticleCategories.OrderByDescending(x => x.Id).ToList();
        }

        public ArticleCategory GetBy(long id)
        {
            return _context.ArticleCategories.FirstOrDefault(x => x.Id == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
