using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Application.contracts.Article
{
    public class ArticleViewModel
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
        public long ArticleCategoryId { get; set; }
        public string CreationDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
