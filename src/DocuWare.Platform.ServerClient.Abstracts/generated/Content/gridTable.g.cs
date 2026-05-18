using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts.Content
{
    public class gridTable(SDK.Content.gridTable obj) : IgridTable
    {
        internal SDK.Content.gridTable Obj { get; } = obj;

        public List<int> gridCol
        {
            get => Obj.gridCol;
            set => Obj.gridCol = value;
        }

        public List<int> gridRow
        {
            get => Obj.gridRow;
            set => Obj.gridRow = value;
        }
    }
}
