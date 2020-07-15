namespace Parser.Interfaces
{
    public interface IParserConfig
    {
        string Url { get; set; }
        string Prefix { get; set; }
        int StartPoint { get; set; }
        int EndPoint { get; set; }
    }
}
