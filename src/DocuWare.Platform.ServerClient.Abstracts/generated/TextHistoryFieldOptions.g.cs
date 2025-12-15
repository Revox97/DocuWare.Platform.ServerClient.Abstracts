using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TextHistoryFieldOptions(SDK.TextHistoryFieldOptions obj) : ITextHistoryFieldOptions
    {
        internal SDK.TextHistoryFieldOptions Obj { get; } = obj;

		public int Length
		{
			get => Obj.Length;
			set => Obj.Length = value;
		}
    }
}
