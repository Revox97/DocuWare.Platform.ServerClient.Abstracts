using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class QueryParamatersList(DocuWare.Platform.ServerClient.QueryParamatersList obj) : IQueryParamatersList
    {
        internal DocuWare.Platform.ServerClient.QueryParamatersList Obj { get; } = obj;

        public List<IQueryParamater> Parameter
        {
            get => Obj.Parameter.Select(x => new QueryParamater(x) as IQueryParamater).ToList();
            set => Obj.Parameter = value.Select(x => ((QueryParamater)x).Obj).ToList();
        }
    }
}
