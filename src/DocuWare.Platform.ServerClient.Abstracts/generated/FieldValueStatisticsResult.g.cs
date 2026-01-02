using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FieldValueStatisticsResult(DocuWare.Platform.ServerClient.FieldValueStatisticsResult obj) : IFieldValueStatisticsResult
    {
        internal DocuWare.Platform.ServerClient.FieldValueStatisticsResult Obj { get; } = obj;

        public List<IFieldValueStatistics> Item
        {
            get => Obj.Item.Select(x => new FieldValueStatistics(x) as IFieldValueStatistics).ToList();
            set => Obj.Item = value.Select(x => ((FieldValueStatistics)x).Obj).ToList();
        }
    }
}
