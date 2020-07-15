using System.Linq;
using AngleSharp.Html.Dom;
using Parser.Interfaces;

namespace Parser.Classes
{
    class Parser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            var items = document.QuerySelectorAll("a")
                .Where(item => item.ClassName != null && item.ClassName.Contains("post__title_link"))
                .Select(item => item.TextContent);

            return items.ToArray();
        }
    }
}
