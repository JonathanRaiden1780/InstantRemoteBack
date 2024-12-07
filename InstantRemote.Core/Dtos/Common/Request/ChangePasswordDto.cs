using System.ComponentModel.DataAnnotations;
using InstantRemote.Core.Messages;

namespace InstantRemote.Core.Dtos.Common.Request
{
    public class ChangePasswordDto
    {
        [Required(ErrorMessageResourceName = nameof(MessagesDataAnnotations.Required), ErrorMessageResourceType = typeof(MessagesDataAnnotations))]
        public string Email { get; set; }
        [Required(ErrorMessageResourceName = nameof(MessagesDataAnnotations.Required), ErrorMessageResourceType = typeof(MessagesDataAnnotations))]
        public string Contrasenia { get; set; }
    }
}
