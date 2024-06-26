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

        public void Activate(long id)
        {
            var article = _articleRepository.GetBy(id);
            article.Activate();
            _articleRepository.SaveChanges();
        }

        public void Create(CreateArticle command)
        {
            var article = new Article(command.Title, command.ShortDescription, command.Image, command.Content, command.ArticleCategoryId);
            _articleRepository.Create(article);
        }

        public void Edit(EditArticle command)
        {
            var article = _articleRepository.GetBy(command.Id);
            article.Edit(command.Title, command.ShortDescription, command.Image, command.Content, command.ArticleCategoryId);
            _articleRepository.SaveChanges();
        }

        public EditArticle GetBy(long id)
        {
            var article = _articleRepository.GetBy(id);
            return new EditArticle
            {
                Id  = article.Id,
                Title = article.Title,
                ShortDescription = article.ShortDescription,
                Image = article.Image,
                Content = article.Content,
                ArticleCategoryId = article.ArticleCategoryId
            };
        }

        public List<ArticleViewModel> List()
        {
            var articles = _articleRepository.GetAll();
            var result = new List<ArticleViewModel>();
            foreach(var article in articles)
            {
                result.Add(new ArticleViewModel
                {
                    Id = article.Id,
                    Title = article.Title,
                    ShortDescription = article.ShortDescription,
                    Image = article.Image,
                    ArticleCategory = article.ArticleCategory,
                    ArticleCategoryId = article.ArticleCategoryId,
                    Content = article.Content,
                    CreationDate = article.CreationDate.ToString(),
                    IsDeleted = article.IsDeleted,
                });
            }
            return result;
 
        }

        public void Remove(long id)
        {
            var article = _articleRepository.GetBy(id);
            article.Remove();
            _articleRepository.SaveChanges();
        }
    }
}
