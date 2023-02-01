using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhosNext_Dto.Request
{
    public class AccountRequestDto
    {
        public int FatherId { get; set; }
        public string Name { get; set; }
        public string ExternalCode { get; set; }
    }
}
