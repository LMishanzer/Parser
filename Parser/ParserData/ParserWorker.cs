using System;
using AngleSharp.Html.Parser;
using Parser.Classes;
using Parser.Interfaces;

namespace Parser.ParserData
{
    public class ParserWorker<T> where T : class
    {
        private HtmlLoader loader;
        private bool isWorking;

        private IParser<T> parser;
        private IParserConfig config;

        public IParser<T> Parser
        {
            get
            {
                return parser;
            }
            set
            {
                parser = value;
            }
        }

        public IParserConfig Config
        {
            get
            {
                return config;
            }
            set
            {
                config = value;
                loader = new HtmlLoader(value);
            }
        }

        public Action<object, T> OnIterationAction;
        public Action<object> OnEndAction;

        public ParserWorker(IParser<T> parser, IParserConfig config)
        {
            Parser = parser;
            Config = config;
        }

        public void Start()
        {
            isWorking = true;
            Worker();
        }

        public void Abort()
        {
            isWorking = false;
        }

        private async void Worker()
        {
            for (int i = Config.StartPoint; i <= Config.EndPoint; i++)
            {
                if (!isWorking)
                {
                    OnEndAction(this);
                    return;
                }

                var source = await loader.GetSourceByPageId(i);

                var localParser = new HtmlParser();
                var document = await localParser.ParseDocumentAsync(source);

                var result = Parser.Parse(document);

                OnIterationAction?.Invoke(this, result);
            }

            OnEndAction?.Invoke(this);
            isWorking = false;
        }
    }
}
