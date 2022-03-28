using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Wrappers
{
    public class PagedResponse<T> : ServiceResponse<T>
    {
        public int PageNumber { get; set; }
        public int PagedSize{ get; set; }

        public PagedResponse(T value): base(value)
        {

        }
        public PagedResponse()
        {
            PageNumber = 1;
            PagedSize = 10;
        }
        public PagedResponse(int pageNumber, int pagedSize)
        {
            PageNumber = pageNumber;
            PagedSize = pagedSize;
        }
    }
}
