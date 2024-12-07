using System.ComponentModel.DataAnnotations;
using InstantRemote.Core.Messages;

namespace InstantRemote.Core.Dtos.Common.Request
{
   public class SingInDtoTeChreo
    {
        [Required(ErrorMessageResourceName = nameof(MessagesDataAnnotations.Required), ErrorMessageResourceType = typeof(MessagesDataAnnotations))]
        public string Seed { get; set; }
    }
}
