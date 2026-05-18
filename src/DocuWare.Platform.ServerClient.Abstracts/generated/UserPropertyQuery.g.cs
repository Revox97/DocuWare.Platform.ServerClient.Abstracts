using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class UserPropertyQuery(SDK.UserPropertyQuery obj) : IUserPropertyQuery
    {
        internal SDK.UserPropertyQuery Obj { get; } = obj;

        public IOutOfOffice OutOfOffice
        {
            get => new OutOfOffice(Obj.OutOfOffice);
            set => Obj.OutOfOffice = ((OutOfOffice)value).Obj;
        }

        public string Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }

        public bool Active
        {
            get => Obj.Active;
            set => Obj.Active = value;
        }

        public string FirstName
        {
            get => Obj.FirstName;
            set => Obj.FirstName = value;
        }

        public string LastName
        {
            get => Obj.LastName;
            set => Obj.LastName = value;
        }

        public string Salutation
        {
            get => Obj.Salutation;
            set => Obj.Salutation = value;
        }
    }
}
