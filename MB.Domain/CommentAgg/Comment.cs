using MB.Domain.ArticleAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB.Domain.CommentAgg
{
    public class Comment
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }
        public DateTime CreationDate { get; set; }
        public long ArticleId { get; set; }
        public Article Article { get; set; }

        protected Comment()
        {
        }

        public Comment(string name, string message, string email, long articleId)
        {
            Name = name;
            Message = message;
            Email = email;
            ArticleId = articleId;
            Status = (int)Statuses.New;
            CreationDate = DateTime.Now;
        }


    }
}
