using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class QueryParamater(SDK.QueryParamater obj) : IQueryParamater
    {
        internal SDK.QueryParamater Obj { get; } = obj;

		public string Name
		{
			get => Obj.Name;
			set => Obj.Name = value;
		}

		public string IsRequired
		{
			get => Obj.IsRequired;
			set => Obj.IsRequired = value;
		}

		public QueryParamaterType Type
		{
			get => new ueryParamaterType(Obj.Type);
			set => Obj.Type = ((ueryParamaterType)value).Obj;
		}
    }
}
