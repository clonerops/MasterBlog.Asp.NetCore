namespace MB.Domain.ArticleCategoryAgg
{
    public interface IArticleCategoryRepository
    {
        ArticleCategory GetBy(long id);
        List<ArticleCategory> GetAll();
        void SaveChanges();
        void Create(ArticleCategory entity);
    }
}
