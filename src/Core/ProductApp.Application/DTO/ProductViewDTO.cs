using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.DTO
{
    // Bu kısım ise Entitylerimizi doğrudan kullanıcaya sunmak istemidiğimiz için bir DTO oluşturduğumuz kısım.
    // Interface'de bir comboBox içine ya da bir dropDownList içine buradaki verilerimizi sunuyoruz.
    public class ProductViewDTO
    {
        public Guid Id { get; set; }
        public String Name { get; set; }

    }
}
