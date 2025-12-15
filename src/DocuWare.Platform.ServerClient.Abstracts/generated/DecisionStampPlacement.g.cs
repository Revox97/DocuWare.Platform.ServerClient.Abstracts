using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DecisionStampPlacement(SDK.DecisionStampPlacement obj) : IDecisionStampPlacement
    {
        internal SDK.DecisionStampPlacement Obj { get; } = obj;

		public string WorkflowId
		{
			get => Obj.WorkflowId;
			set => Obj.WorkflowId = value;
		}

		public string InstanceId
		{
			get => Obj.InstanceId;
			set => Obj.InstanceId = value;
		}

		public string TaskId
		{
			get => Obj.TaskId;
			set => Obj.TaskId = value;
		}

		public int DecisionId
		{
			get => Obj.DecisionId;
			set => Obj.DecisionId = value;
		}

		public bool IsController
		{
			get => Obj.IsController;
			set => Obj.IsController = value;
		}

		public IPolyLineEntry Strokes
		{
			get => new PolyLineEntry(Obj.Strokes);
			set => Obj.Strokes = ((PolyLineEntry)value).Obj;
		}

		public IDWPoint Location
		{
			get => new DWPoint(Obj.Location);
			set => Obj.Location = ((DWPoint)value).Obj;
		}

		public List<IFormFieldValue> Field
		{
			get => Obj.Field.Select(x => new FormFieldValue(x) as IFormFieldValue).ToList();
			set => Obj.Field = value.Select(x => ((FormFieldValue)x).Obj).ToList();
		}

		public string StampId
		{
			get => Obj.StampId;
			set => Obj.StampId = value;
		}

		public int Rotation
		{
			get => Obj.Rotation;
			set => Obj.Rotation = value;
		}

		public int Layer
		{
			get => Obj.Layer;
			set => Obj.Layer = value;
		}

		public string Password
		{
			get => Obj.Password;
			set => Obj.Password = value;
		}
    }
}
