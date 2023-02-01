using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhosNext_Dto.Response.Base
{
    public class BaseResponseDto
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public DateTime? DeletedAt { get; set; }

        //todo: adicionar author do insert
    }
}
