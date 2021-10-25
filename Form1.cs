using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CW1_GUI
{
    public partial class Form1 : Form
    {
        public int HistoryEnumInd;

        // History variables
        public List<String> HistoryList = new List<string>();

        public string Path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        private Dictionary<string, string> CurrentFavourites = new Dictionary<string, string>();

        private List<String> _currentHistory = new List<string>();

        public Form1()
        {
            InitializeComponent();

            HistoryInitialiaser();
            HomeInitialiser();
        }

        // Favourites variable
        public string BulkFile { get; private set; }

        public string home { get; set; }

        public void bulk_download_Click(object sender, EventArgs e)
        {
            List<string> downloadText = new List<string>();
            List<string> urlsList = new List<string>();

            if (bulk_box.Text == "")
            {
                BulkFile = "bulk.txt";
            }
            else
            {
                BulkFile = bulk_box.Text;
            }

            try
            {
                using (StreamReader r = new StreamReader(BulkFile))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        urlsList.Add(line);
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                throw new ArgumentException("file not found", ex);
            }

            foreach (string url in urlsList)
            {
                try
                {
                    // Creates an HttpWebRequest for the specified URL.
                    HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                    // Sends the HttpWebRequest and waits for a response.
                    HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

                    downloadText.Add(myHttpWebResponse.StatusCode.ToString() + " " + myHttpWebResponse.ContentLength +
                                      " " + url);
                }
                catch (Exception ex)
                {
                    downloadText.Add(ex.Message + " 0" + " " + url);
                }
            }

            Display.Text = downloadText[0];
            foreach (string urlInfo in downloadText)
            {
                if (urlInfo == downloadText[0])
                {
                    Display.Text = urlInfo;
                }
                else
                {
                    Display.Text += Environment.NewLine + urlInfo;
                }
            }
        }

        public ToolStripItem[] FavButtonCreator(Dictionary<string, string> urls)
        {
            ToolStripItem[] nItems = new ToolStripItem[urls.Count];
            int i = 0;
            foreach (KeyValuePair<string, string> url in urls)
            {
                nItems[i] = new ToolStripMenuItem();
                nItems[i].Font = new System.Drawing.Font("Segoe UI", 9F);
                nItems[i].Name = url.Value;
                nItems[i].Size = new System.Drawing.Size(100, 23);
                nItems[i].Visible = true;
                nItems[i].Text = url.Key;
                nItems[i].Click += DynamicButtonSearch;
                i++;
            }
            return nItems;
        }

        public ToolStripItem[] HistButtonCreator(List<string> urls)
        {
            ToolStripItem[] nItems = new ToolStripItem[urls.Count];

            for (int i = 0; i < urls.Count; i++)
            {
                nItems[i] = new ToolStripMenuItem();
                nItems[i].Font = new System.Drawing.Font("Segoe UI", 9F);
                nItems[i].Name = urls[i];
                nItems[i].Size = new System.Drawing.Size(100, 23);
                nItems[i].Visible = true;
                nItems[i].Text = urls[i];
                nItems[i].Click += DynamicButtonSearch;
            }
            return nItems;
        }

        public void HistoryInitialiaser()
        {
            _currentHistory = SaveSystem.ReadFromJsonFile<List<string>>(Path + "History.txt");
            ToolStripItem[] newArray = HistButtonCreator(_currentHistory).ToArray();
            History.DropDownItems.Clear();
            History.DropDownItems.AddRange(newArray);
            ToolStrip.ResumeLayout(false);
            ToolStrip.PerformLayout();
        }

        public void HomeInitialiser()
        {
            List<String> currentHome =
                SaveSystem.ReadFromJsonFile<List<String>>(Path + "home.txt");
            if (currentHome[0].Length != 0)
            {
                search(currentHome[0]);
            }
            else
            {
                search("https://www.hw.ac.uk/");
            }
        }

        public void search(string source)
        {
            try
            {
                // Creates an HttpWebRequest for the specified URL.
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(source);
                // Sends the HttpWebRequest and waits for a response.
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
                if (myHttpWebResponse.StatusCode == HttpStatusCode.OK)
                    Console.WriteLine(format: @"
Response Status Code is OK and StatusDescription is: {0}",
                        arg0: myHttpWebResponse.StatusDescription);
                // Display the contents of the page to the console.
                Stream streamResponse = myHttpWebResponse.GetResponseStream();

                // Get stream object
                StreamReader streamRead = new StreamReader(streamResponse ?? throw new InvalidOperationException());

                // Find title in html document
                String page = streamRead.ReadToEnd();
                string title = Regex
                    .Match(page, @"\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>", RegexOptions.IgnoreCase)
                    .Groups["Title"].Value;
                String text = title + " Status code: 200 (OK) \n";

                // Display page
                Display.Text = text + page;

                // Release the response object resources.
                streamRead.Close();
                streamResponse.Close();

                // Close response
                myHttpWebResponse.Close();
            }
            catch (Exception e)
            {
                Display.Text = e.Message;
            }
        }

        private void addtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CurrentFavourites.ContainsValue(url_box.Text))
            {
                CurrentFavourites.Add(label_box.Text, url_box.Text);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (HistoryEnumInd > 0)
            {
                // Move index
                HistoryEnumInd--;
                // Display previous
                search(_currentHistory[HistoryEnumInd]);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentFavourites.ContainsValue(label_box.Text))
            {
                CurrentFavourites.Remove(label_box.Text);
            }
            else if (CurrentFavourites.ContainsValue(url_box.Text))
            {
                var item = CurrentFavourites.First(kvp => kvp.Value == url_box.Text);
                CurrentFavourites.Remove(item.Key);
            }
        }

        private void DynamicButtonSearch(object sender, EventArgs e)
        {
            search(((ToolStripMenuItem)sender).Name);
        }

        private void editNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item = CurrentFavourites.First(kvp => kvp.Value == url_box.Text);
            CurrentFavourites.Remove(item.Key);
            CurrentFavourites.Add(label_box.Text, url_box.Text);
        }

        private void editUrlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentFavourites.Remove(label_box.Text);
            CurrentFavourites.Add(label_box.Text, url_box.Text);
        }

        private void Favourites_ButtonClick(object sender, EventArgs e)
        {
            if (CurrentFavourites.Count != 0)
            {
                ToolStripItem[] newArray = FavButtonCreator(CurrentFavourites).ToArray();

                Favourites.DropDownItems.Clear();

                Favourites.DropDownItems.AddRange(newArray);
            }
            ToolStrip.ResumeLayout(false);
            ToolStrip.PerformLayout();
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            if (HistoryEnumInd < _currentHistory.Count - 1)
            {
                // Move index
                HistoryEnumInd++;
                //Display next
                search(_currentHistory[HistoryEnumInd]);
            }
        }

        private void History_ButtonClick(object sender, EventArgs e)
        {
            if (_currentHistory.Count != 0)
            {
                ToolStripItem[] newArray = HistButtonCreator(_currentHistory).ToArray();

                History.DropDownItems.Clear();
                History.DropDownItems.AddRange(newArray);
            }
            ToolStrip.ResumeLayout(false);
            ToolStrip.PerformLayout();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            List<String> currentHome =
                SaveSystem.ReadFromJsonFile<List<String>>(Path + "home.txt");
            if (currentHome[0] != null)
            {
                search(currentHome[0]);
            }
            else
            {
                Display.Text = @"Home is not set.";
            }
        }

        private void Refresh_Click_1(object sender, EventArgs e)
        {
            search(Search_box.Text);
        }

        private void Search_button_Click(object sender, EventArgs f)
        {
            // Add url to history
            HistoryList.Add(Search_box.Text);

            // set new index
            HistoryEnumInd = HistoryList.Count - 1;

            // Serialiase new History list
            SaveSystem.WriteToJsonFile(Path + "History.txt", HistoryList);

            // Assign the response object of 'HttpWebRequest' to a 'HttpWebResponse' variable.
            try
            {
                // Creates an HttpWebRequest for the specified URL.
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(Search_box.Text);
                // Sends the HttpWebRequest and waits for a response.
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
                if (myHttpWebResponse.StatusCode == HttpStatusCode.OK)
                    Console.WriteLine(@"
Response Status Code is OK and StatusDescription is: {0}",
                        myHttpWebResponse.StatusDescription);
                // Display the contents of the page to the console.
                Stream streamResponse = myHttpWebResponse.GetResponseStream();

                // Get stream object
                StreamReader streamRead = new StreamReader(streamResponse ?? throw new InvalidOperationException());

                // Find title in html document
                String source = streamRead.ReadToEnd();
                string title = Regex
                    .Match(source, @"\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>", RegexOptions.IgnoreCase)
                    .Groups["Title"].Value;
                String text = title + " Status code: 200 (OK)";

                // Display title and status code
                Display.Text = text;

                // Release the response object resources.
                streamRead.Close();
                streamResponse.Close();

                // Close response
                myHttpWebResponse.Close();
            }
            catch (Exception e)
            {
                Display.Text = e.Message;
            }

            _currentHistory =
                SaveSystem.ReadFromJsonFile<List<string>>(Path + "History.txt");
        }

        private void Set_home_Click(object sender, EventArgs e)
        {
            home = Search_box.Text;
            List<String> currentHome = new List<string>();
            currentHome.Add(home);
            SaveSystem.WriteToJsonFile(Path + "home.txt", currentHome);
        }

        public static class SaveSystem
        {
            public static T ReadFromJsonFile<T>(string filePath) where T : new()
            {
                TextReader reader = null;
                try
                {
                    reader = new StreamReader(filePath);
                    var fileContents = reader.ReadToEnd();
                    return JsonConvert.DeserializeObject<T>(fileContents);
                }
                catch (FileNotFoundException ex)
                {
                    throw new ArgumentException("file not found", ex);
                }
                finally
                {
                    if (reader != null)
                        reader.Close();
                }
            }

            public static void WriteToJsonFile<T>(string filePath, T objectToWrite, bool append = false) where T : new()
            {
                TextWriter writer = null;
                try
                {
                    var contentsToWriteToFile = JsonConvert.SerializeObject(objectToWrite);
                    writer = new StreamWriter(filePath, append);
                    writer.Write(contentsToWriteToFile);
                }
                finally
                {
                    if (writer != null)
                        writer.Close();
                }
            }
        }
    }
}