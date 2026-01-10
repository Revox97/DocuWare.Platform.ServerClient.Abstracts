using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class MinimalVersionAttribute(DocuWare.Platform.ServerClient.MinimalVersionAttribute obj) : IMinimalVersionAttribute
    {
        internal DocuWare.Platform.ServerClient.MinimalVersionAttribute Obj { get; } = obj;

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
