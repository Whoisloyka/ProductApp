using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Wrappers
{
    // Servisimizden geriye her zaman bunun objesini döndüreceğüz.
    public class BaseResponse
    {
        public Guid Id { get; set; }
        public bool Success { get; set; }

        // Success false ise bu mesajı döndüreceğiz.
        public String Message { get; set; }
    }
}
