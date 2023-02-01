using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WhosNext_Dto.Response
{
    public class AccountSuggestedNextResponseDto
    {
        public int Id { get; set; }

        [JsonPropertyName("FatherAccount")]
        public string Name { get; set; }

        [JsonPropertyName("FatherAccountCode")]
        public string ExternalCode { get; set; }

        [JsonPropertyName("RecomendedChildCode")]
        public string SuggestedCode { get; set; }

    }
}
