using System;
using System.Windows.Forms;
using Parser.Classes;
using Parser.ParserData;

namespace Parser
{
    public partial class MainForm : Form
    {
        private ParserWorker<string[]> parserWorker;

        public MainForm()
        {
            InitializeComponent();
            parserWorker = new ParserWorker<string[]>(
                new Classes.Parser(), 
                new ParserConfig() {Url = "https://habr.com/ru/", Prefix = "page"});
            parserWorker.OnIterationAction += AddData;
            parserWorker.OnEndAction += o => MessageBox.Show("All work done!");
        }

        private void AddData(object obj, string[] lines)
        {
            ResultBox.Items.AddRange(lines);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            parserWorker.Config.StartPoint = (int)StartPage.Value;
            parserWorker.Config.EndPoint = (int)EndPage.Value;
            parserWorker.Start();
        }

        private void AbortButton_Click(object sender, EventArgs e)
        {
            parserWorker.Abort();
        }
    }
}
