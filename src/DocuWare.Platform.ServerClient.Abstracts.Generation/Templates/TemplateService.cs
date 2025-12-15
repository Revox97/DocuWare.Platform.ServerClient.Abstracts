namespace DocuWare.Platform.ServerClient.Abstracts.Generation.Templates
{
    internal static class TemplateService
    {
        public static string SyncDocuWareMethod
        {
            get
            {
                return field ??= File.ReadAllText("Templates/SyncDocuWareMethodTemplate.tmp");
            }
        } = null!;

        public static string AsyncDocuWareMethod
        {
            get
            {
                return field ??= File.ReadAllText("Templates/AsyncDocuWareMethodTemplate.tmp");
            }
        } = null!;
    }
}
