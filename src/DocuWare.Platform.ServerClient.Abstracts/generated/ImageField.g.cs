using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ImageField(SDK.ImageField obj) : IImageField
    {
        internal SDK.ImageField Obj { get; } = obj;
    }
}
