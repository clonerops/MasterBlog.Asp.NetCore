using MB.Infrastructure.Query;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentation.MVCCore.Pages
{
    public class ArticleDetailsModel : PageModel
    {
        public ArticleQueryView Article { get; set; }

        private readonly IArticleQuery articleQuery;

        public ArticleDetailsModel(IArticleQuery articleQuery)
        {
            this.articleQuery = articleQuery;
        }

        public void OnGet(long id)
        {
            Article = articleQuery.GetArticle(id);
        }

       
    }
}