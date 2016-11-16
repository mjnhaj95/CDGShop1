using System.Collections.Generic;
using System.Linq;

namespace CDGShop.Web.Infrastructure.Core
{
    public class PaginationSet<T>
    {
        public int Page { set; get; } //

        public int Count                        //
        {
            get                                 // Chỉ get
            {
                return (Items != null) ? Items.Count() : 0;
            }
        }

        public int TotalPages { set; get; }         // Số trang
        public int TotalCount { set; get; }         // Tổng số bản ghi
        public IEnumerable<T> Items { set; get; }   // Lưu Items
    }
}