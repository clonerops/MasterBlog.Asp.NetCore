namespace MB.Domain.ArticleCategoryAgg
{
    public interface IArticleCategoryRepository
    {
        List<ArticleCategory> GetAll();
        ArticleCategory GetBy(long id);
        void SaveChanges();
        void Create(ArticleCategory entity);
    }
}
