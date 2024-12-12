using System.ComponentModel.DataAnnotations;

namespace InstantRemote.Core.Dtos.Common.Response
{
    public class CriticalErrorMessageDto : FunctionalErrorMessageDto
    {
        [Required]
        public string Exception { get; set; }
    }
}
