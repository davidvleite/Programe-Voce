using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Models
{
    public class OrderModel : EntityBase
    {
        public ClientCertificateOption Client { get; set; }
        public UserModel User { get; set; }
        public List<OrderItemModel> Items { get; set; }
    }
}
