using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SortedField(SDK.SortedField obj) : ISortedField
    {
        internal SDK.SortedField Obj { get; } = obj;

		public string Field
		{
			get => Obj.Field;
			set => Obj.Field = value;
		}

		public SortDirection Direction
		{
			get => new ortDirection(Obj.Direction);
			set => Obj.Direction = ((ortDirection)value).Obj;
		}
    }
}
