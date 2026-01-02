using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class Decision(SDK.Decision obj) : IDecision
    {
        internal SDK.Decision Obj { get; } = obj;

        public List<ITaskFormField> TaskFormField
        {
            get => Obj.TaskFormField.Select(x => new TaskFormField(x) as ITaskFormField).ToList();
            set => Obj.TaskFormField = value.Select(x => ((TaskFormField)x).Obj).ToList();
        }

        public Link[] Links
        {
            get => Obj.Links;
            set => Obj.Links = value;
        }

        public int Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }

        public string Description
        {
            get => Obj.Description;
            set => Obj.Description = value;
        }

        public string Label
        {
            get => Obj.Label;
            set => Obj.Label = value;
        }

        public string Color
        {
            get => Obj.Color;
            set => Obj.Color = value;
        }

		public void SetProxy(HttpClientProxy proxy) => Obj.SetProxy(proxy);
    }
}
