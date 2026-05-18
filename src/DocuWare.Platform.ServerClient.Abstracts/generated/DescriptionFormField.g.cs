using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DescriptionFormField(SDK.DescriptionFormField obj) : IDescriptionFormField
    {
        internal SDK.DescriptionFormField Obj { get; } = obj;

        public List<ILinkParameter> LinkParameters
        {
            get => Obj.LinkParameters.Select(x => new LinkParameter(x) as ILinkParameter).ToList();
            set => Obj.LinkParameters = value.Select(x => ((LinkParameter)x).Obj).ToList();
        }

        public string DescriptionText
        {
            get => Obj.DescriptionText;
            set => Obj.DescriptionText = value;
        }

        public FormTypeEnum FormFieldType
        {
            get => (FormTypeEnum)Obj.FormFieldType;
            set => Obj.FormFieldType = (DocuWare.Platform.ServerClient.FormTypeEnum)value;
        }

        public string Label
        {
            get => Obj.Label;
            set => Obj.Label = value;
        }

        public int Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }
    }
}
