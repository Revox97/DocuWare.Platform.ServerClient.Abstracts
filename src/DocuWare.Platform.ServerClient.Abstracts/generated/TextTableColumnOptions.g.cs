using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class TextTableColumnOptions(SDK.TextTableColumnOptions obj) : ITextTableColumnOptions
    {
        internal SDK.TextTableColumnOptions Obj { get; } = obj;

		public int Length
		{
			get => Obj.Length;
			set => Obj.Length = value;
		}
    }
}
