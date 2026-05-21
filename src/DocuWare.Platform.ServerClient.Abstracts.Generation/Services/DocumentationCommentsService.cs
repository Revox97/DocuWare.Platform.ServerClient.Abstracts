using System.Reflection;
using System.Xml.Linq;
using System.Xml.XPath;

namespace DocuWare.Platform.ServerClient.Abstracts.Generation.Services
{
    internal class DocumentationCommentsService
    {
        private const char ReturnTypeMethodNameSeperator = ' ';
        private const int MethodNameIndex = 1;
        private static readonly string s_documentationPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DocuWare.Platform.ServerClient.xml");
        private static XDocument? s_documentationXmlTree;

        internal static string GetDocumentationCommentOfType(Type t)
        {
            ReadDocumentationFile();
            string xmlName = $"T:{t.FullName}";

            XElement? element = s_documentationXmlTree!.XPathSelectElement($"doc/members/member[@name='{xmlName}']");
            return GenerateCommentFromXElement(element, "\t");
        }

        internal static string GetDocumentationCommentOfProperty(PropertyInfo p)
        {
            ReadDocumentationFile();
            string xmlName = $"P:{p.DeclaringType}.{p.Name}";

            XElement? element = s_documentationXmlTree!.XPathSelectElement($"doc/members/member[@name='{xmlName}']");
            return GenerateCommentFromXElement(element, "\t\t");
        }

        internal static string GetDocumentationCommentOfMethod(MethodInfo m)
        {
            ReadDocumentationFile();
            string xmlName = $"M:{m.DeclaringType}.{m.ToString()!.Split(ReturnTypeMethodNameSeperator, 2)[MethodNameIndex]}";

            XElement? element = s_documentationXmlTree!.XPathSelectElement($"doc/members/member[@name='{xmlName}']");
            return GenerateCommentFromXElement(element, "\t\t");
        }

        private static void ReadDocumentationFile()
        {
            if (s_documentationXmlTree is null)
            {
                string documentationContent = File.ReadAllText(s_documentationPath);
                s_documentationXmlTree = XDocument.Parse(documentationContent);
            }
        }

        private static string GenerateCommentFromXElement(XElement? element, string? prefix = "")
        {
            if (element is null)
                return string.Empty;

            string documentationComment = string.Empty;
            element.Nodes().ToList().ForEach(x =>
            {
                string elementContent = x.ToString().Trim();

                List<string> subElements = [.. elementContent.Split("\r\n")];

                foreach (string subElement in subElements)
                {
                    string subElementValue = subElement.Trim(' ');
                    documentationComment += $"{prefix}/// {subElementValue.Trim(' ')}\r\n";
                }
            });

            return documentationComment != $"{prefix}/// <remarks />\r\n" ? documentationComment : string.Empty;
        }
    }
}
