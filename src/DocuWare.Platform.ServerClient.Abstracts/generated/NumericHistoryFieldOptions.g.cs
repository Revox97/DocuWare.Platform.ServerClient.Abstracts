using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class NumericHistoryFieldOptions(SDK.NumericHistoryFieldOptions obj) : INumericHistoryFieldOptions
    {
        internal SDK.NumericHistoryFieldOptions Obj { get; } = obj;

		public int Precision
		{
			get => Obj.Precision;
			set => Obj.Precision = value;
		}
    }
}
