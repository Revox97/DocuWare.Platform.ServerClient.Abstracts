using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class NumberColumn(SDK.NumberColumn obj) : INumberColumn
    {
        internal SDK.NumberColumn Obj { get; } = obj;

		public int Precision
		{
			get => Obj.Precision;
			set => Obj.Precision = value;
		}
    }
}
