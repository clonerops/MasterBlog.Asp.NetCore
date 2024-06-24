
namespace MB.Application.contracts.ArticleCategory
{
    public interface IArticleCategoryApplication
    {
        List<ArticleCategoryViewModel> List();
        void Create(CreateArticleCategory command);
        void Edit(EditArticleCategory command);
        EditArticleCategory GetBy(long id);
        void Remove(long id);
        void Activate(long id);
    }
}