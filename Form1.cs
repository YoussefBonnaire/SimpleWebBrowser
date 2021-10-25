using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace CW1_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string home { get; set; }

        // History variables
        public List<String> HistoryList = new List<string>();
        public List<String> CurrentHistory = new List<string>();

        public int HistoryEnumInd;

        // History tool strip
        public ToolStripItem[] histButtons ;
        private ToolStripTextBox newitem = new ToolStripTextBox();



        public Dictionary<String, String> Favourites_list { get; set; }

        public static class SaveSystem
        {
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

            public static T ReadFromJsonFile<T>(string filePath) where T : new()
            {
                TextReader reader = null;
                try
                {
                    reader = new StreamReader(filePath);
                    var fileContents = reader.ReadToEnd();
                    return JsonConvert.DeserializeObject<T>(fileContents);
                }
                finally
                {
                    if (reader != null)
                        reader.Close();
                }
            }

        }

        public void search(string source)
        {
            try
            {
                // Creates an HttpWebRequest for the specified URL.
                HttpWebRequest myHttpWebRequest = (HttpWebRequest) WebRequest.Create(source);
                // Sends the HttpWebRequest and waits for a response.
                HttpWebResponse myHttpWebResponse = (HttpWebResponse) myHttpWebRequest.GetResponse();
                if (myHttpWebResponse.StatusCode == HttpStatusCode.OK)
                    Console.WriteLine("\r\nResponse Status Code is OK and StatusDescription is: {0}",
                        myHttpWebResponse.StatusDescription);
                // Display the contents of the page to the console.
                Stream streamResponse = myHttpWebResponse.GetResponseStream();

                // Get stream object
                StreamReader streamRead = new StreamReader(streamResponse);

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

        private void Search_button_Click(object sender, EventArgs f)
        {
            // Add url to history 
            HistoryList.Add(Search_box.Text);

            // set new index
            HistoryEnumInd = HistoryList.Count - 1;

            // Serialiase new History list
            SaveSystem.WriteToJsonFile<List<string>>("C:/Users/youss/source/repos/CW1_GUI/History.txt", HistoryList);



            // Assign the response object of 'HttpWebRequest' to a 'HttpWebResponse' variable.
            try
            {
                // Creates an HttpWebRequest for the specified URL.
                HttpWebRequest myHttpWebRequest = (HttpWebRequest) WebRequest.Create(Search_box.Text);
                // Sends the HttpWebRequest and waits for a response.
                HttpWebResponse myHttpWebResponse = (HttpWebResponse) myHttpWebRequest.GetResponse();
                if (myHttpWebResponse.StatusCode == HttpStatusCode.OK)
                    Console.WriteLine("\r\nResponse Status Code is OK and StatusDescription is: {0}",
                        myHttpWebResponse.StatusDescription);
                // Display the contents of the page to the console.
                Stream streamResponse = myHttpWebResponse.GetResponseStream();

                // Get stream object
                StreamReader streamRead = new StreamReader(streamResponse);

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

            CurrentHistory =
                SaveSystem.ReadFromJsonFile<List<String>>("C:/Users/youss/source/repos/CW1_GUI/History.txt");
        }

        private void Refresh_Click_1(object sender, EventArgs e)
        {
            search(Search_box.Text);

        }

        private void Home_Click(object sender, EventArgs e)
        {
            List<String> current_home =
                SaveSystem.ReadFromJsonFile<List<String>>("C:/Users/youss/source/repos/CW1_GUI/home.txt");
            if (current_home[0] != null)
            {
                search(current_home[0]);
            }
            else
            {
                Display.Text = @"Home is not set.";
            }
        }

        private void Set_home_Click(object sender, EventArgs e)
        {
            home = Search_box.Text;
            List<String> currentHome = new List<string>();
            currentHome.Add(home);
            SaveSystem.WriteToJsonFile("C:/Users/youss/source/repos/CW1_GUI/home.txt", currentHome);
        }


        private void Favourites_ButtonClick(object sender, EventArgs e)
        {

        }

        public ToolStripItem[] HistButtonCreator(List<string> urls)
        {
            foreach(string url in urls)
            {
                newitem.Font = new System.Drawing.Font("Segoe UI", 9F);
                newitem.Name = url;
                newitem.Size = new System.Drawing.Size(100, 23);
                histButtons.Append(newitem);
            }

            return histButtons;
        }

        
    

    private void History_ButtonClick(object sender, EventArgs e)
        {

        }
        

        private void Back_Click(object sender, EventArgs e)
        {
            if (HistoryEnumInd > 0)
            {
                // Move index
                HistoryEnumInd--;
                // Display previous
                search(CurrentHistory[HistoryEnumInd]);
            }
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            if (HistoryEnumInd < CurrentHistory.Count - 1)
            {
                // Move index
                HistoryEnumInd++;
                //Display next
                search(CurrentHistory[HistoryEnumInd]);
            }
        }
    }
    }
