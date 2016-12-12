using CDGShop.Data.Infrastructure;
using CDGShop.Data.Migrations;
using CDGShop.Model.Models;

namespace CDGShop.Data.Repositories
{
    public interface IContactDetailRepository : IRepository<ContactDetail>
    {
    }

    public class ContactDetailRepository : RepositoryBase<ContactDetail>, IContactDetailRepository
    {
        public ContactDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}