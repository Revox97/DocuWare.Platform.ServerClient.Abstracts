using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SelectListValuesQuery(SDK.SelectListValuesQuery obj) : ISelectListValuesQuery
    {
        internal SDK.SelectListValuesQuery Obj { get; } = obj;

		public int Start
		{
			get => Obj.Start;
			set => Obj.Start = value;
		}

		public int Count
		{
			get => Obj.Count;
			set => Obj.Count = value;
		}

		public string ValuePrefix
		{
			get => Obj.ValuePrefix;
			set => Obj.ValuePrefix = value;
		}

		public string ReturnType
		{
			get => Obj.ReturnType;
			set => Obj.ReturnType = value;
		}
    }
}
