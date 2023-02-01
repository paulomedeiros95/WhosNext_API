using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhosNext_Dto.Response.Base;
using WhosNext_Dto.ValueObjects;

namespace WhosNext_Dto.Response
{
    public class AccountResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ExternalCode { get; set; }
        public List<ChildVO> Lowers { get; set; } //TODO: Ajustar para funcionar com auto mapper.
    }
}
