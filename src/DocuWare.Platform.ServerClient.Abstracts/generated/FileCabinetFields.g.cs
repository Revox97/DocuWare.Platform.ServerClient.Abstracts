using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FileCabinetFields(SDK.FileCabinetFields obj) : IFileCabinetFields
    {
        internal SDK.FileCabinetFields Obj { get; } = obj;

        public List<IFileCabinetField> Field
        {
            get => Obj.Field.Select(x => new FileCabinetField(x) as IFileCabinetField).ToList();
            set => Obj.Field = value.Select(x => ((FileCabinetField)x).Obj).ToList();
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
