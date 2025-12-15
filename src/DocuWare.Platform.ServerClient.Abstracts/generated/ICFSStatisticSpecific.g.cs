using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ICFSStatisticSpecific
    {
		List<ICFSSpecificValue> SpecificValue { get; set; }
		DocuWare.Platform.ServerClient.CFSTableNames Category { get; set; }
		string ObjectID { get; set; }
    }
}
