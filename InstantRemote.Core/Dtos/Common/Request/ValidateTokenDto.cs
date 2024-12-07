using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using InstantRemote.Core.Messages;

namespace InstantRemote.Core.Dtos.Common.Request
{
    public class ValidateTokenDto
    {
        [JsonIgnore]        
        public string Token { get; set; }
        [Required(ErrorMessageResourceName = nameof(MessagesDataAnnotations.Required), ErrorMessageResourceType = typeof(MessagesDataAnnotations))]
        public string Seed { get; set; }
    }
}
