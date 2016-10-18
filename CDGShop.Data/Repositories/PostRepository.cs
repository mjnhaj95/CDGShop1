using CDGShop.Data.Infrastructure;
using CDGShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDGShop.Data.Repositories
{
    //public interface IPostRepository : IRepository<Post>
    //{
    //    IEnumerable<Post> GetMultiPaging(Func<Post, bool> p, out int totalRow, int page, int pageSize);
    //}

    //public class PostRepository : RepositoryBase<Post>, IPostRepository
    //{
    //    public PostRepository(IDbFactory dbFactory) : base(dbFactory)
    //    {
    //    }
    //}
    public interface IPostRepository : IRepository<Post>
    {
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
