using MB.Domain.ArticleCategoryAgg;
using MB.Domain.CommentAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domain.ArticleAgg
{
    public class Article
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }
        public long ArticleCategoryId { get; set; }
        public ArticleCategory ArticleCategory { get; set; }
        public ICollection<Comment> Comments { get; set; }
        protected Article()
        {

        }

        public Article(string title, string shortDescription, string image, string content, long articleCategoryId)
        {
            Title = title;
            ShortDescription = shortDescription;
            Image = image;
            Content = content;
            ArticleCategoryId = articleCategoryId;
            IsDeleted = false;
            CreationDate = DateTime.Now;
        }

        public void Edit(string title, string shortDescription, string image, string content, long articleCategoryId)
        {
            Title = title;
            ShortDescription = shortDescription;
            Image = image;
            Content = content;
            ArticleCategoryId = articleCategoryId;
        }

        public void Remove()
        {
            IsDeleted = true;
        }

        public void Activate()
        {
            IsDeleted = false;
        }
    }
}
