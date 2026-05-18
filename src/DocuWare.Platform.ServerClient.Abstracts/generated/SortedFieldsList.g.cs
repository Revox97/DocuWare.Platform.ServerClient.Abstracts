using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SortedFieldsList(SDK.SortedFieldsList obj) : ISortedFieldsList
    {
        internal SDK.SortedFieldsList Obj { get; } = obj;

        public List<ISortedField> OrderBy
        {
            get => Obj.OrderBy.Select(x => new SortedField(x) as ISortedField).ToList();
            set => Obj.OrderBy = value.Select(x => ((SortedField)x).Obj).ToList();
        }
    }
}
