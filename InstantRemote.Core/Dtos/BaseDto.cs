using System.ComponentModel.DataAnnotations;
using InstantRemote.Core.Messages;

namespace InstantRemote.Core.Dtos
{
    public class BaseDto
    {
/*        [Required(ErrorMessageResourceName = nameof(MessagesDataAnnotations.Required), ErrorMessageResourceType = typeof(MessagesDataAnnotations))]
        [EnumDataType(typeof(Towers), ErrorMessageResourceName = nameof(MessagesDataAnnotations.EnumTypeProcess), ErrorMessageResourceType = typeof(MessagesDataAnnotations))]
        public string Tower { get; set; }

        [Required(ErrorMessageResourceName = nameof(MessagesDataAnnotations.Required), ErrorMessageResourceType = typeof(MessagesDataAnnotations))]
        [EnumDataType(typeof(Products), ErrorMessageResourceName = nameof(MessagesDataAnnotations.ProcessTypeEnum), ErrorMessageResourceType = typeof(MessagesDataAnnotations))]
        public string ProductId { get; set; }*/

        [Required(ErrorMessageResourceName = nameof(MessagesDataAnnotations.Required), ErrorMessageResourceType = typeof(MessagesDataAnnotations))]
        public string Seed { get; set; }
    }
}
