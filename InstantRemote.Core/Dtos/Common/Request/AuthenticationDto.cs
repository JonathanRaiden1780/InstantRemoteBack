using System.ComponentModel.DataAnnotations;
using InstantRemote.Core.Messages;

namespace InstantRemote.Core.Dtos.Common.Request
{
    public class AuthenticationDto
    {
        [Required(ErrorMessageResourceName = nameof(MessagesDataAnnotations.Required), ErrorMessageResourceType = typeof(MessagesDataAnnotations))]
        public string Email { get; set; }
        [Required(ErrorMessageResourceName = nameof(MessagesDataAnnotations.Required), ErrorMessageResourceType = typeof(MessagesDataAnnotations))]
        public string Password { get; set; }
    }
}
