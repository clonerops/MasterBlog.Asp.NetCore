using MB.Application.contracts;
using MB.Application.contracts.ArticleCategory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MB.Presentaion.Razor.Areas.Admin.Pages.ArticleCategoryManagment
{
    public class CreateModel : PageModel
    {
        private readonly IArticleCategoryApplication _articleCategoryApplication;

        public CreateModel(IArticleCategoryApplication articleCategoryApplication)
        {
            _articleCategoryApplication = articleCategoryApplication;
        }

        public void OnGet()
        {
        }

        public RedirectToPageResult OnPost(CreateArticleCategory command) 
        {
            _articleCategoryApplication.Create(command);
            return RedirectToPage("./List");
        }
    }
}
