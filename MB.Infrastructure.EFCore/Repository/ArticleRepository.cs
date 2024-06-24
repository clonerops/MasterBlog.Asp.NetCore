using MB.Domain.ArticleAgg;

namespace MB.Infrastructure.EFCore.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly MasterBlogContext _context;

        public ArticleRepository(MasterBlogContext context)
        {
            _context = context;
        }

        public void Create(Article entity)
        {
            _context.Articles.Add(entity);
            _context.SaveChanges();
        }

        public List<Article> GetAll()
        {
            return _context.Articles.OrderByDescending(a => a.Id).ToList();
        }
    }
}
