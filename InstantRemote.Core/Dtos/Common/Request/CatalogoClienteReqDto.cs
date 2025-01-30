using InstantRemote.Core.Messages;
using System.ComponentModel.DataAnnotations;

namespace InstantRemote.Core.Dtos.Common.Request
{
    public class CatalogoClienteReqDto
    {
        [Required(ErrorMessageResourceName = nameof(MessagesDataAnnotations.Required), ErrorMessageResourceType = typeof(MessagesDataAnnotations))]
        public string cliente { get; set; }
        [Required(ErrorMessageResourceName = nameof(MessagesDataAnnotations.Required), ErrorMessageResourceType = typeof(MessagesDataAnnotations))]
        public string responsable { get; set; }
    }
    public class CatalogoClientUpdateeReqDto : CatalogoClienteReqDto
    {
        [Required(ErrorMessageResourceName = nameof(MessagesDataAnnotations.Required), ErrorMessageResourceType = typeof(MessagesDataAnnotations))]
        public int id { get; set; }

    }

}
