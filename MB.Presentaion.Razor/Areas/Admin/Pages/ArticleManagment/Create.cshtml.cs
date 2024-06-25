using MB.Application.contracts.Article;
using MB.Application.contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MB.Presentaion.Razor.Areas.Admin.Pages.ArticleManagment
{
    public class CreateModel : PageModel
    {
        public List<SelectListItem> ArticleCategories { get; set; }

        private readonly IArticleCategoryApplication articleCategoryApplication;
        private readonly IArticleApplication articleApplication;

        public CreateModel(IArticleCategoryApplication articleCategoryApplication, IArticleApplication articleApplication)
        {
            this.articleCategoryApplication = articleCategoryApplication;
            this.articleApplication = articleApplication;
        }

        public void OnGet()
        {
            ArticleCategories = articleCategoryApplication.List().Select(x => new SelectListItem(x.Title, x.Id.ToString())).ToList();
        }

        public RedirectToPageResult OnPost(CreateArticle command)
        {
            articleApplication.Create(command);
            return RedirectToPage("./List");
        }
    }
}
