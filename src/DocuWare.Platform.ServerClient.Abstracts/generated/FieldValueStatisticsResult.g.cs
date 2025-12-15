using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FieldValueStatisticsResult(SDK.FieldValueStatisticsResult obj) : IFieldValueStatisticsResult
    {
        internal SDK.FieldValueStatisticsResult Obj { get; } = obj;

		public List<IFieldValueStatistics> Item
		{
			get => Obj.Item.Select(x => new FieldValueStatistics(x) as IFieldValueStatistics).ToList();
			set => Obj.Item = value.Select(x => ((FieldValueStatistics)x).Obj).ToList();
		}
    }
}
