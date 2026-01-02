using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class QueryParamater(DocuWare.Platform.ServerClient.QueryParamater obj) : IQueryParamater
    {
        internal DocuWare.Platform.ServerClient.QueryParamater Obj { get; } = obj;

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

        public DocuWare.Platform.ServerClient.QueryParamaterType Type
        {
            get => Obj.Type;
            set => Obj.Type = value;
        }
    }
}
