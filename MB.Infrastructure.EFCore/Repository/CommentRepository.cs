using MB.Domain.CommentAgg;

namespace MB.Infrastructure.EFCore.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly MasterBlogContext _context;

        public CommentRepository(MasterBlogContext context)
        {
            _context = context;
        }


    }
}
