using MB.Application.contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentaion.Razor.Areas.Admin.Pages.ArticleCategoryManagment
{
    public class ListModel : PageModel
    {
        public List<ArticleCategoryViewModel> ArticleCategories { get; set; }
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public ListModel(IArticleCategoryApplication articleCategoryApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet()
        {
           ArticleCategories = _articleCategoryApplication.List();
        }

        public RedirectToPageResult OnPostRemove(long id)
        {
            _articleCategoryApplication.Remove(id);
            return RedirectToPage("./List");
        }

        public RedirectToPageResult OnPostActivate(long id)
        {
            _articleCategoryApplication.Activate(id);
            return RedirectToPage("./List");
        }
    }
}
