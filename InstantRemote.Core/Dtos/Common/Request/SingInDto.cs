using System.ComponentModel.DataAnnotations;
using InstantRemote.Core.Messages;

namespace InstantRemote.Core.Dtos.Common.Request
{
   public class SingInDto
    {
        [Required(ErrorMessageResourceName = nameof(MessagesDataAnnotations.Required), ErrorMessageResourceType = typeof(MessagesDataAnnotations))]
        public string Username { get; set; }
        [Required(ErrorMessageResourceName = nameof(MessagesDataAnnotations.Required), ErrorMessageResourceType = typeof(MessagesDataAnnotations))]
        public string Password { get; set; }
    }
}
