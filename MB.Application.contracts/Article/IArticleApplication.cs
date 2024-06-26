namespace MB.Application.contracts.Article
{
    public interface IArticleApplication
    {
        EditArticle GetBy(long id);
        List<ArticleViewModel> List();
        void Create(CreateArticle command);
        void Edit(EditArticle command);
        void Remove(long id);
        void Activate(long id);
    }
}
