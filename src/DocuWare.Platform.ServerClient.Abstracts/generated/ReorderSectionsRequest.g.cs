using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ReorderSectionsRequest(DocuWare.Platform.ServerClient.ReorderSectionsRequest obj) : IReorderSectionsRequest
    {
        internal DocuWare.Platform.ServerClient.ReorderSectionsRequest Obj { get; } = obj;

        public List<string> SectionId
        {
            get => Obj.SectionId;
            set => Obj.SectionId = value;
        }
    }
}
