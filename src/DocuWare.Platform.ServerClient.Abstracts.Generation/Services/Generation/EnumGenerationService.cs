using System.Collections;
using System.Text;
using DocuWare.Platform.ServerClient.Abstracts.Generation.Contracts;

namespace DocuWare.Platform.ServerClient.Abstracts.Generation.Services.Generation
{
    internal class EnumGenerationService : IGenerationService
    {
        public void Generate(Type type)
        {
            string enumName = type.Name;
            Console.WriteLine($"Generating {enumName}.g.cs");

            string result = GenerateEnumValues(type);
            string template = File.ReadAllText("Templates/Enum.template");
            template = template.Replace("{0}", enumName).Replace("{1}", result);

            using FileStream fStream = File.Create(Path.Combine(Paths.GenerationFolder, $"{enumName}.g.cs"));
            fStream.Write(Encoding.UTF8.GetBytes(template ?? string.Empty));
        }

        private static string GenerateEnumValues(Type type)
        {
            string result = string.Empty;

            Array enumValues = type.GetEnumValues();
            IEnumerator enumerator = enumValues.GetEnumerator();
            bool hasNext = enumerator.MoveNext();

            while (hasNext)
            {
                result += $"{StringConstants.LineEndingWithTwoTabs}{enumerator.Current} = {(int)enumerator.Current}";
                hasNext = enumerator.MoveNext();

                if (hasNext)
                    result += ',';
            }

            return result;
        }
    }
}
