using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Wrappers
{
    // Generic typeta olucak bu sınıfımız dışarıdan bir value alacak.
    public class ServiceResponse<T>
    {
        public T Value { get; set; }
        public ServiceResponse(T value)
        {
            Value = Value;
        }
        public ServiceResponse()
        {

        }
    }
}
