using System.ComponentModel.DataAnnotations;

namespace InstantRemote.Core.Dtos.Common.Response
{
   public class SignInDto
    {
        [Required]
        public string Url { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public string Seed { get; set; }
        [Required]
        public long Ticks { get; set; }
    }
}
