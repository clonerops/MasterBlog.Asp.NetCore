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
        public List<SelectListItem> ArticleCategories { get; set; }
        [BindProperty] public EditArticle Article { get; set; }
        private readonly IArticleCategoryApplication articleCategoryApplication;
        private readonly IArticleApplication articleApplication;

        public EditModel(IArticleCategoryApplication articleCategoryApplication, IArticleApplication articleApplication)
        {
            this.articleCategoryApplication = articleCategoryApplication;
            this.articleApplication = articleApplication;
        }

        public void OnGet(long id)
        {
            ArticleCategories = articleCategoryApplication
                .List()
                .Select(x => new SelectListItem(x.Title, x.Id.ToString())).ToList();

            Article = articleApplication.GetBy(id);
        }
    }
}
