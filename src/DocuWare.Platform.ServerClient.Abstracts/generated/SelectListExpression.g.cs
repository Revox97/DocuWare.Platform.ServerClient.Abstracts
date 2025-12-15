using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SelectListExpression(SDK.SelectListExpression obj) : ISelectListExpression
    {
        internal SDK.SelectListExpression Obj { get; } = obj;

		public IDialogExpression DialogExpression
		{
			get => new DialogExpression(Obj.DialogExpression);
			set => Obj.DialogExpression = ((DialogExpression)value).Obj;
		}

		public string ValuePrefix
		{
			get => Obj.ValuePrefix;
			set => Obj.ValuePrefix = value;
		}

		public string FieldName
		{
			get => Obj.FieldName;
			set => Obj.FieldName = value;
		}

		public int Count
		{
			get => Obj.Count;
			set => Obj.Count = value;
		}

		public int Start
		{
			get => Obj.Start;
			set => Obj.Start = value;
		}

		public int Limit
		{
			get => Obj.Limit;
			set => Obj.Limit = value;
		}

		public SortDirection SortDirection
		{
			get => new ortDirection(Obj.SortDirection);
			set => Obj.SortDirection = ((ortDirection)value).Obj;
		}

		public bool ExcludeExternal
		{
			get => Obj.ExcludeExternal;
			set => Obj.ExcludeExternal = value;
		}

		public bool Typed
		{
			get => Obj.Typed;
			set => Obj.Typed = value;
		}
    }
}
