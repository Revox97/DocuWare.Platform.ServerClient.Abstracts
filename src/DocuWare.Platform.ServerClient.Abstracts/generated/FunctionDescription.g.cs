using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FunctionDescription(SDK.FunctionDescription obj) : IFunctionDescription
    {
        internal SDK.FunctionDescription Obj { get; } = obj;

        public List<IParameterDescription> Parameter
        {
            get => Obj.Parameter.Select(x => new ParameterDescription(x) as IParameterDescription).ToList();
            set => Obj.Parameter = value.Select(x => ((ParameterDescription)x).Obj).ToList();
        }

        public string Description
        {
            get => Obj.Description;
            set => Obj.Description = value;
        }

        public string Name
        {
            get => Obj.Name;
            set => Obj.Name = value;
        }

        public int MinParameters
        {
            get => Obj.MinParameters;
            set => Obj.MinParameters = value;
        }

        public string MaxParameters
        {
            get => Obj.MaxParameters;
            set => Obj.MaxParameters = value;
        }
    }
}
