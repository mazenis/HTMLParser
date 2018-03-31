using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Net;   //for Method 1 (Bad)
using System.IO;
using System.Xml;       //Method Bad, Bad1
using HtmlAgilityPack; //Method "Best" HtmlAgilityPack.1.6.12
using WatiN.MsHtmlBrowser; //WatiN Lib for (Method "Better")
using System.Text.RegularExpressions;
using System.Collections.Generic; // Dictionary
namespace HTMLParser
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        public DataTable TheWebsites = new DataTable();
        //The WebBrowser control
        public WebBrowser wb = new WebBrowser();
        //The extracted text
        public string TheTXT="";
        //For swich between lbl and textBox
        public bool ShowTxtLbl = false;
        //Result Longest Word
        public string TheLongestWord = "";
        //Results Common Char
        public char TheCommonChar;
        public int TheCountofComChar = 0;

        public void button1_Click(object sender, EventArgs e)
        {
            //Bad Method
            if (txtURL.Text == "")
                return;
            string urlAddress = txtURL.Text;
           

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }

                 string data = readStream.ReadToEnd();
                data = HtmlRemoval.StripTagsRegex(data);
                Regex rRemScript = new Regex(@"<script[^>]*>[\s\S]*?</script>");
                data = rRemScript.Replace(data, "");
                CleanText(data);
                response.Close();
                readStream.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {   //Method "Better"
            using (WebClient client = new WebClient())
            {
                if (txtURL.Text == "")
                    return;
                string htmlCode = client.DownloadString(txtURL.Text);
                //HtmlAgilityPack.1.6.12 library used in this method
                HtmlAgilityPack.HtmlDocument doc1 = new HtmlAgilityPack.HtmlDocument();
                doc1.LoadHtml(htmlCode);
                var nodes = doc1.DocumentNode.SelectNodes("//script|//style|//meta|//head|//title|//footer");
                //Remove the elements (Nodes):   //script|//style|//meta|//head|//title|//footer
                foreach (var node in nodes)
                    node.ParentNode.RemoveChild(node);
                Regex rRemScript = new Regex(@"<script[^>]*>[\s\S]*?</script>");
                 string TXT = rRemScript.Replace(doc1.DocumentNode.OuterHtml.ToString(),"");
                TXT=  HtmlRemoval.StripTagsRegex(TXT);
                CleanText(TXT);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResulte.Text = "";
            lblResult.Text = "";
            TheTXT = "";
            TheLongestWord = "";
            TheCountofComChar = 0;
    }

        private void button4_Click(object sender, EventArgs e)
        {
            //Method "Best" HtmlAgilityPack.1.6.12 library used in this method
            if (txtURL.Text == "")
                return;
            var url = txtURL.Text;
            var web = new HtmlWeb(); //object from HtmlAgilityPack class
            var doc = web.Load(url);
            var nodes = doc.DocumentNode.SelectNodes("//script|//style|//meta|//header|//title|//footer|//Template|//core");
            //Remove the elements (Nodes):   //script|//style|//meta|//head|//title|//footer
            foreach (var node in nodes)
                node.ParentNode.RemoveChild(node);

            Regex rRemScript = new Regex(@"<script[^>]*>[\s\S]*?</script>");
             string TXT = HtmlRemoval.StripTagsRegex(doc.DocumentNode.OuterHtml.ToString());
            //HtmlRemoval Class used here
            TXT = rRemScript.Replace(TXT, " ").Trim();
            CleanText(TXT);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // "Show (Limited)" method used class "MsHtmlBrowser" here
            // The limitation came from that in many sites using the frame browser is forbidden 
            //This content cannot be displayed in a frame; To help protect the security of information you enter into this website, the publisher of this content does not allow it to be displayed in a frame.
            var browser = new MsHtmlBrowser();
            browser.GoTo(cmbBox.SelectedValue.ToString()); 
             TheTXT= browser.Text.Trim();
            //The method is active in wikibedia
            TheTXT = CleanText(TheTXT);
            label1.Text = cmbBox.SelectedValue.ToString();
        }

        private string CleanText(string OrigenalText)
        {
          //filtering method Used in most of my methods
            string EditedText = Regex.Replace(OrigenalText, @"[:.?!$%^+&*;=,\t\r]/[\n]{2}","");
            int TheTextLength = EditedText.Length;
            int CountOfDigit = 0;
           // int CountOfSpace = 0;
            for (int i =1; i<TheTextLength; i++)
            {
                try
                {
                    //if (char.IsUpper(EditedText[i]))
                    //{
                    //    if (EditedText[i - 1] != ' ')
                    //    {
                    //        //string rightPart = EditedText.Substring(i - 1, TheTextLength - i - 1);
                    //        //string leftPart = EditedText.Substring(0, i - 1);
                    //        //EditedText = leftPart + " " + rightPart;
                    //        //i++;
                    //        //CountOfSpace++;
                    //    }
                    //}
                    
                    // Delete numbers
                    if (char.IsNumber(EditedText[i]))
                    {
                        string rightPart = EditedText.Substring(i+1, TheTextLength - i -1);//- CountOfSpace
                        string leftPart = EditedText.Substring(0, i-1);
                        EditedText = leftPart + "  " + rightPart;
                        CountOfDigit++;
                    }
                }
                catch (InvalidCastException e)
                {
                    e.Message.ToString();
                }
                TheTXT = EditedText.Trim();
                lblResult.Text = TheTXT;
                txtResulte.Text = TheTXT;
                
                butViewInTxt.Visible = true;
                butFWords.Visible = true;
            }
            return EditedText;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //public  string[,] TheWebsites = new string [4,2] {{"Wiki", "https://en.wikipedia.org" }, {"Att", "https://en.wikipedia.org/wiki/AT%26T" }, { "Yahoo", "https://en.wikipedia.org/wiki/Yahoo!" }, { "Google", "https://en.wikipedia.org/wiki/Google" } };
            TheWebsites.Columns.Add("WebSName");
            TheWebsites.Columns.Add("WebSURL");

            TheWebsites.Rows.Add("Wiki", "https://en.wikipedia.org");

            TheWebsites.Rows.Add("AT&T", "https://en.wikipedia.org/wiki/AT%26T");

            TheWebsites.Rows.Add("Yahoo", "https://en.wikipedia.org/wiki/Yahoo!");

            TheWebsites.Rows.Add("Google", "https://en.wikipedia.org/wiki/Google");
            cmbBox.DataSource = TheWebsites;
            cmbBox.DisplayMember = "WebSName";
            cmbBox.ValueMember = "WebSURL";
        }

        private void butViewInTxt_Click(object sender, EventArgs e)
        {
            if (ShowTxtLbl == true)
                lblResult.BringToFront();
            else
                txtResulte.BringToFront();
            ShowTxtLbl = !ShowTxtLbl;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Method Bad1
            butViewInTxt.Visible = true;
            XmlDocument document = new XmlDocument();
            document.Load(txtURL.Text);
            CleanText(document.InnerText);
        }

        private void button7_Click(object sender, EventArgs e)
        {   //Method "The Best" and this is my official answer
            //Download the webpage
            Uri TargetURL = new Uri(txtURL.Text);
            wb.Url = TargetURL;
            //Requesting method    "DisplayText"
            wb.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(DisplayText);
         }
        private void DisplayText(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            wb.Document.ExecCommand("SelectAll", false, null);
            wb.Document.ExecCommand("Copy", false, null);
            CleanText(Clipboard.GetText());
        }

        private void butFWords_Click(object sender, EventArgs e)
        {
            //Method for words Frequancy
            var words = new Dictionary<string, int>(StringComparer.CurrentCultureIgnoreCase);
        
            var wordPattern = new Regex(@"\w+");

            foreach (Match match in wordPattern.Matches(TheTXT))
            {
                int currentCount = 0;
                words.TryGetValue(match.Value, out currentCount);

                currentCount++;
                words[match.Value] = currentCount;
                
                DGViewFrequancy.DataSource = new BindingSource(words,null);
                butLonWord.Visible = true;
            }
                //DGViewFrequancy.Sort(DGViewFrequancy.Columns["Value"], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void butLonWord_Click(object sender, EventArgs e)
        {
            //Method for the longest word
            if (DGViewFrequancy.Rows.Count!=0)
            {
              for (int i=1;i< DGViewFrequancy.Rows.Count;i++)
                {
                    string TestedValue = DGViewFrequancy.Rows[i].Cells["Key"].Value.ToString();
                    if (TestedValue.Length>TheLongestWord.Length)
                        TheLongestWord = TestedValue;
                }
                lblTheLongestWord.Text = "The Longest Word in the Page is: /"+TheLongestWord+"/";
            }
        }

        private void butLetterFrequency_Click(object sender, EventArgs e)
        {
            //Method for the most common letter
            var charCount = new Dictionary<char, int>();
            foreach (var c in TheTXT)
            {
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    if (charCount.ContainsKey(c))
                        charCount[c]++;
                    else
                        charCount[c] = 1;
                }
            }

            DGViewFrequancy.DataSource = new BindingSource(charCount, null);
            if (DGViewFrequancy.Rows.Count != 0)
            {
                for (int i = 1; i < DGViewFrequancy.Rows.Count; i++)
                {
                    int TestedValue = int.Parse(DGViewFrequancy.Rows[i].Cells["Value"].Value.ToString());
                    if (TestedValue > TheCountofComChar)
                    {
                        TheCountofComChar = TestedValue;
                        TheCommonChar = DGViewFrequancy.Rows[i].Cells["Key"].Value.ToString().ToCharArray()[0];
                    }
                        
                }
                lblTheLongestWord.Text = "The most common letter in the Page is: /"+ TheCommonChar +"/ and repeted for:"+ TheCountofComChar;
            }
        }
    }
}
