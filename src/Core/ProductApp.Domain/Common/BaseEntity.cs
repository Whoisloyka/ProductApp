using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Domain.Common
{
    public class BaseEntity
    {
        // Veri Tabınındaki tüm tablolarda bulunacak alanları tanımlıyoruz. 
        // Bütün entitylerimizi de bu BaseEntityden üretiyoruz.
        public Guid id { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
