namespace MB.Domain.ArticleCategoryAgg
{
    public class ArticleCategory
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }

        public ArticleCategory(string title)
        {
            Title = title;
            IsDeleted = false;
            CreationDate = DateTime.Now;
        }
    }
}