
using MB.Application.contracts.Article;

namespace MB.Domain.ArticleAgg
{
    public interface IArticleRepository
    {
        Article GetBy(long id);
        List<ArticleViewModel> GetAll();
        void Create(Article entity);
        void SaveChanges();

    }
}
