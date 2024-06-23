namespace MB.Application.contracts
{
    public interface IArticleCategoryApplication
    {
        List<ArticleCategoryViewModel> List();
        void Create(CreateArticleCategory command);
        void Edit(EditArticleCategory command);
        EditArticleCategory GetBy(long id);
    }
}