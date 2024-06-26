using MB.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;

namespace MB.Infrastructure.Query
{
    public class ArticleQuery : IArticleQuery
    {
        private readonly MasterBlogContext _context;

        public ArticleQuery(MasterBlogContext context)
        {
            _context = context;
        }

        public ArticleQueryView GetArticle(long id)
        {
            return _context.Articles.Include(x => x.ArticleCategory).Select(x => new ArticleQueryView
            {
                Id = x.Id,
                Title = x.Title,
                Image = x.Image,
                ShortDescription = x.ShortDescription,
                CreationDate = x.CreationDate.ToString(),
                Content = x.Content,
                ArticleCategory = x.ArticleCategory.Title

            }).FirstOrDefault(x => x.Id == id);
        }

        public List<ArticleQueryView> GetArticles()
        {
            return _context.Articles.Include(x => x.ArticleCategory).Select(x => new ArticleQueryView
            {
                Id = x.Id,
                Title = x.Title,
                Image = x.Image,
                ShortDescription = x.ShortDescription,
                CreationDate = x.CreationDate.ToString(),
                ArticleCategory = x.ArticleCategory.Title

            }).ToList();
        }
    }
}
