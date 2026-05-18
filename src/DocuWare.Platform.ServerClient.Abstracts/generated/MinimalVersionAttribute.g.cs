using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class MinimalVersionAttribute(SDK.MinimalVersionAttribute obj) : IMinimalVersionAttribute
    {
        internal SDK.MinimalVersionAttribute Obj { get; } = obj;

        public string MinumumVersion
        {
            get => Obj.MinumumVersion;
            set => Obj.MinumumVersion = value;
        }

        public object TypeId => Obj.TypeId;

		public bool Equals(object obj) => Obj.Equals(obj);

		public int GetHashCode() => Obj.GetHashCode();

		public bool Match(object obj) => Obj.Match(obj);

		public bool IsDefaultAttribute() => Obj.IsDefaultAttribute();
    }
}
