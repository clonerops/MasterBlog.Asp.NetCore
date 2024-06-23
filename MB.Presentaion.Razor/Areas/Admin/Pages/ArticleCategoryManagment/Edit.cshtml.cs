using MB.Application.contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentaion.Razor.Areas.Admin.Pages.ArticleCategoryManagment
{
    public class EditModel : PageModel
    {
        [BindProperty] public EditArticleCategory  ArticleCategory { get; set; }
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public EditModel(IArticleCategoryApplication articleCategoryApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet(long id)
        {
            ArticleCategory = _articleCategoryApplication.GetBy(id);
        }

        public RedirectToPageResult OnPost()
        {
            _articleCategoryApplication.Edit(ArticleCategory);
            return RedirectToPage("./List");
        }
    }
}
