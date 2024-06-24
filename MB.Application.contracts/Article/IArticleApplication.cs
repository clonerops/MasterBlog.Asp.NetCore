namespace MB.Application.contracts.Article
{
    public interface IArticleApplication
    {
        List<ArticleViewModel> List();
        void Create(CreateArticle command);
    }
}
