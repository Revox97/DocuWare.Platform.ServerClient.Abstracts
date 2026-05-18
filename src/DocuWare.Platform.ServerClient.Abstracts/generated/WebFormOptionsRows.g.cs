using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WebFormOptionsRows(SDK.WebFormOptionsRows obj) : IWebFormOptionsRows
    {
        internal SDK.WebFormOptionsRows Obj { get; } = obj;

        public List<List<IWebFormOption>> WebFormOptions
        {
            get
            {
                List<List<IWebFormOption>> result = new();

                foreach (var outer in Obj.WebFormOptions)
                    result.Add(new(from inner in outer select new WebFormOption(inner)));

                return result;
            }
            set
            {
                List<List<SDK.WebFormOption>> result = new();

                foreach (var outer in value)
                    result.Add(new(from inner in outer select ((WebFormOption)inner).Obj));

                Obj.WebFormOptions = result;
            }
        }
    }
}
