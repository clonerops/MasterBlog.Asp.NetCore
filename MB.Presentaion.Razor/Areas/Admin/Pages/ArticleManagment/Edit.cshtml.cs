using MB.Application.contracts.Article;
using MB.Application.contracts.ArticleCategory;
using MB.Domain.ArticleAgg;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MB.Presentaion.Razor.Areas.Admin.Pages.ArticleManagment
{
    public class EditModel : PageModel
    {
        [BindProperty] public EditArticle Article { get; set; }
        public List<SelectListItem> ArticleCategories { get; set; }

        private readonly IArticleCategoryApplication articleCategoryApplication;
        private readonly IArticleApplication articleApplication;

        public EditModel(IArticleCategoryApplication articleCategoryApplication, IArticleApplication articleApplication)
        {
            this.articleCategoryApplication = articleCategoryApplication;
            this.articleApplication = articleApplication;
        }

        public void OnGet(long id)
        {
            Article = articleApplication.GetBy(id);

            ArticleCategories = articleCategoryApplication
                .List()
                .Select(x => new SelectListItem(x.Title, x.Id.ToString())).ToList();

        }

        public RedirectToPageResult OnPost()
        {
            articleApplication.Edit(Article);
            return RedirectToPage("./List");
        }
    }
}
