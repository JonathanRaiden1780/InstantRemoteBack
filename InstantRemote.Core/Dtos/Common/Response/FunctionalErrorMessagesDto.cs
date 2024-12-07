using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InstantRemote.Core.Dtos.Common.Response
{
    public class FunctionalErrorMessagesDto
    {
        [Required]
        public string Origin { get; set; }
     
        [Required]
        public IEnumerable<string> Message { get; set; }

        [Required]
        public string TrackingCode { get; set; }
    }
}
