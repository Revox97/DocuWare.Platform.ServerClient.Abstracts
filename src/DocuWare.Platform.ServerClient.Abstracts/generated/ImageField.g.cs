using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ImageField(DocuWare.Platform.ServerClient.ImageField obj) : IImageField
    {
        internal DocuWare.Platform.ServerClient.ImageField Obj { get; } = obj;
    }
}
