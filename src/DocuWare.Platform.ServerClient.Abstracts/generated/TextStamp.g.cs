using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TextStamp(SDK.TextStamp obj) : ITextStamp
    {
        internal SDK.TextStamp Obj { get; } = obj;

		public IFont Font
		{
			get => new Font(Obj.Font);
			set => Obj.Font = ((Font)value).Obj;
		}

		public string Content
		{
			get => Obj.Content;
			set => Obj.Content = value;
		}
    }
}
