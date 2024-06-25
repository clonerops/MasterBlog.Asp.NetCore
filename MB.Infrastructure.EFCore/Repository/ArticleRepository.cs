using MB.Application.contracts.Article;
using MB.Domain.ArticleAgg;
using Microsoft.EntityFrameworkCore;

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
            SaveChanges();
        }

        public List<ArticleViewModel> GetAll()
        {
            return _context.Articles.Include(x => x.ArticleCategory).Select(x => new ArticleViewModel
            {
                Id = x.Id,
                ArticleCategoryId = x.ArticleCategory.Id,
                Title = x.Title,
                Image = x.Image,
                ArticleCategory = x.ArticleCategory.Title,
                Content = x.Content,
                CreationDate = x.CreationDate.ToString(),
                IsDeleted = x.IsDeleted,
            }).ToList();
        }

        public Article GetBy(long id)
        {
            return _context.Articles.FirstOrDefault(x => x.Id == id);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}
