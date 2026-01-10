using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface ITaskTextField : ICommonFormField
    {
		IFieldMask FieldMask { get; set; }
		int Length { get; set; }
    }
}
