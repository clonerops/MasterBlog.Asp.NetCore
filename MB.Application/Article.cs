using MB.Application.contracts.Article;
using MB.Domain.ArticleAgg;

namespace MB.Application
{
    public class ArticleApplication : IArticleApplication
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleApplication(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public void Create(CreateArticle command)
        {
            var article = new Article(command.Title, command.ShortDescription, command.Image, command.Content, command.ArticleCategoryId);
            _articleRepository.Create(article);
        }

        public List<ArticleViewModel> List()
        {
            var articles = _articleRepository.GetAll();
            var result = new List<ArticleViewModel>();
            foreach(var article in articles)
            {
                result.Add(new ArticleViewModel
                {
                    Title = article.Title,
                    ShortDescription = article.ShortDescription,
                    Image = article.Image,
                    Content = article.Content,
                    CreationDate = article.CreationDate.ToString(),
                    IsDeleted = article.IsDeleted,
                });
            }
            return result;
 
        }
    }
}
