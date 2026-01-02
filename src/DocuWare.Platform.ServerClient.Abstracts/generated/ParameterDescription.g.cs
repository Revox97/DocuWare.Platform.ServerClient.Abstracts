using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ParameterDescription(DocuWare.Platform.ServerClient.ParameterDescription obj) : IParameterDescription
    {
        internal DocuWare.Platform.ServerClient.ParameterDescription Obj { get; } = obj;

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }

        public string Description
        {
            get => Obj.Description;
            set => Obj.Description = value;
        }
    }
}
