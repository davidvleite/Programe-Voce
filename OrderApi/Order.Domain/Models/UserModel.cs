using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.Models
{
    public class UserModel : EntityBase
    {
        public string Name { get; set; }
        public string login { get; set; }
        public string PassordHash { get; set; }
    }
}
