using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ParameterDescription(SDK.ParameterDescription obj) : IParameterDescription
    {
        internal SDK.ParameterDescription Obj { get; } = obj;

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
