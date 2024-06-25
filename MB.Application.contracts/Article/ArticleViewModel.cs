namespace MB.Application.contracts.Article
{
    public class ArticleViewModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
        public long ArticleCategoryId { get; set; }
        public string ArticleCategory { get; set; }
        public string CreationDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
