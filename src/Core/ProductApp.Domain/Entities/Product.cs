using ProductApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Domain.Entities
{
    // Veri Tabanındaki Product class'ını temsil edicek.
    // Bütün entitylerimizi de bu BaseEntityden üretiyoruz.
    // Böylelikle BaseEntitiy'deki tanımlı alanları ekstradan oluşturmaya gerek kalmayacak. Buradaki class yapıları daha özgün olucak.
    public class Product : BaseEntity
    {
        public String Name { get; set; }
        public decimal Value { get; set; }
        public int Quantity { get; set; }
        public Guid Id { get; set; }
    }
}
