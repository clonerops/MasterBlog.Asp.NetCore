namespace MB.Domain.ArticleAgg
{
    public interface IArticleRepository
    {
        List<Article> GetAll();
        void Create(Article entity);
    }
}
