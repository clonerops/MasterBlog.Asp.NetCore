using MB.Application.contracts;
using MB.Domain.ArticleCategoryAgg;

namespace MB.Application
{
    public class ArticleCategoryApplication : IArticleCategoryApplication
    {
        private readonly IArticleCategoryRepository _articleCategoryRepository;

        public ArticleCategoryApplication(IArticleCategoryRepository articleCategoryRepository)
        {
           _articleCategoryRepository = articleCategoryRepository;
        }

        public void Create(CreateArticleCategory command)
        {
            var articleCategory = new ArticleCategory(command.Title);
            _articleCategoryRepository.Create(articleCategory);
        }

        public void Edit(EditArticleCategory command)
        {
            var articleCategory = _articleCategoryRepository.GetBy(command.Id);
            articleCategory.Edit(command.Title);
            _articleCategoryRepository.SaveChanges();

        }

        public EditArticleCategory GetBy(long id)
        {
            var articleCategory = _articleCategoryRepository.GetBy(id);
            return new EditArticleCategory
            {
                Id = articleCategory.Id,
                Title = articleCategory.Title,
            };
        }

        public List<ArticleCategoryViewModel> List()
        {
            var articleCategories = _articleCategoryRepository.GetAll();
            var result = new List<ArticleCategoryViewModel>();
            foreach (var articleCategory in articleCategories)
            {
                result.Add(new ArticleCategoryViewModel
                {
                    Id = articleCategory.Id,
                    Title = articleCategory.Title,
                    CreationDate = articleCategory.CreationDate.ToString(),

                });
            }
            return result;
        }
    }
}