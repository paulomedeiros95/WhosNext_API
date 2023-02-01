using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhosNext_Domain.Base;

namespace WhosNext_Domain.Account
{
    public class AccountDomain : BasePlan<AccountDomain>
    {
        public bool AcceptIncommings { get; set; } = true;
    }
}
