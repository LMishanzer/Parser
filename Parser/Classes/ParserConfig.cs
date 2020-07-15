using Parser.Interfaces;

namespace Parser.Classes
{
    public class ParserConfig : IParserConfig
    {
        public string Url { get; set; }
        public string Prefix { get; set; }
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
    }
}
