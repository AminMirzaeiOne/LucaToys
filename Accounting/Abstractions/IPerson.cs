using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Abstractions
{
    internal interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Phone { get; set; }
        string LandlinePhone { get; set; }
        string Email { get; set; }
        string Address { get; set; }
        string NationalCode { get; set; }


    }
}
