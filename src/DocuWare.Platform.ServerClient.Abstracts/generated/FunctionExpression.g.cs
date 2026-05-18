using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FunctionExpression(SDK.FunctionExpression obj) : IFunctionExpression
    {
        internal SDK.FunctionExpression Obj { get; } = obj;

        public List<IAnyExpression> Parameter
        {
            get => Obj.Parameter.Select(x => new AnyExpression(x) as IAnyExpression).ToList();
            set => Obj.Parameter = value.Select(x => ((AnyExpression)x).Obj).ToList();
        }

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }
    }
}
