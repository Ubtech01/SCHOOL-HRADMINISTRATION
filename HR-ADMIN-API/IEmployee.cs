using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_ADMIN_API
{
    public interface IEmployee
    {

        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        public decimal Salary { get; set; }
    }
}
