using MB.Application.contracts.Article;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentaion.Razor.Areas.Admin.Pages.ArticleManagment
{
    public class ListModel : PageModel
    {
        public List<ArticleViewModel> Articles { get; set; }

        private readonly IArticleApplication articleApplication;

        public ListModel(IArticleApplication articleApplication)
        {
            this.articleApplication = articleApplication;
        }

        public void OnGet()
        {
            Articles = articleApplication.List();
        }

        public RedirectToPageResult OnPostRemove(long id)
        {
            articleApplication.Remove(id);
            return RedirectToPage("./List");
        }

        public RedirectToPageResult OnPostActivate(long id)
        {
            articleApplication.Activate(id);
            return RedirectToPage("./List");
        }
    }
}
