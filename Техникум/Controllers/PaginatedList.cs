using System;
using System.Linq;
using System.Threading.Tasks;
using Техникум.Models;

namespace техникум.Controllers
{
    internal class PaginatedList<T>
    {
        internal static Task<object> CreateAsync(IQueryable<Student> queryable, int v, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}