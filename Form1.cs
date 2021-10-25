using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDev.HtmlRenderer.WinForms;
using System.Text.RegularExpressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
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
        public List<String> History_list = new List<string>();
        public List<String> current_history = new List<string>();
        public int History_enum_ind = 0;


        public Dictionary<String,String> Favourites_list { get; set; }
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
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(source);
                // Sends the HttpWebRequest and waits for a response.
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
                if (myHttpWebResponse.StatusCode == HttpStatusCode.OK)
                    Console.WriteLine("\r\nResponse Status Code is OK and StatusDescription is: {0}",
                                         myHttpWebResponse.StatusDescription);
                // Display the contents of the page to the console.
                Stream streamResponse = myHttpWebResponse.GetResponseStream();

                // Get stream object
                StreamReader streamRead = new StreamReader(streamResponse);

                // Find title in html document
                String page = streamRead.ReadToEnd();
                string title = Regex.Match(page, @"\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>", RegexOptions.IgnoreCase).Groups["Title"].Value;
                String text = title + " Status code: 200 (OK) \n";

                // Display page
                this.Display.Text = text + page;


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
            this.History_list.Add(this.Search_box.Text);

            // set new index
            History_enum_ind = this.History_list.Count-1 ;

            // Serialiase new History list
            SaveSystem.WriteToJsonFile<List<string>>("C:/Users/youss/source/repos/CW1_GUI/History.txt", History_list);



            // Assign the response object of 'HttpWebRequest' to a 'HttpWebResponse' variable.
            try
            {
                // Creates an HttpWebRequest for the specified URL.
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(this.Search_box.Text);
                // Sends the HttpWebRequest and waits for a response.
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
                if (myHttpWebResponse.StatusCode == HttpStatusCode.OK)
                    Console.WriteLine("\r\nResponse Status Code is OK and StatusDescription is: {0}",
                                         myHttpWebResponse.StatusDescription);
                // Display the contents of the page to the console.
                Stream streamResponse = myHttpWebResponse.GetResponseStream();

                // Get stream object
                StreamReader streamRead = new StreamReader(streamResponse);

                // Find title in html document
                String source = streamRead.ReadToEnd();
                string title = Regex.Match(source, @"\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>", RegexOptions.IgnoreCase).Groups["Title"].Value;
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
            current_history = SaveSystem.ReadFromJsonFile<List<String>>("C:/Users/youss/source/repos/CW1_GUI/History.txt");
        }

        private void Refresh_Click_1(object sender, EventArgs e)
        {
            search(this.Search_box.Text);
                
        }

        private void Home_Click(object sender, EventArgs e)
        {
            List<String> current_home = SaveSystem.ReadFromJsonFile<List<String>>("C:/Users/youss/source/repos/CW1_GUI/home.txt");
            if (current_home[0] != null)
            {
                search(current_home[0]);
            }
            else { Display.Text = @"Home is not set."; }
        }

        private void Set_home_Click(object sender, EventArgs e)
        {
            home = this.Search_box.Text;
            List<String> current_home = new List<string>();
            current_home.Add(home);
            SaveSystem.WriteToJsonFile<List<String>>("C:/Users/youss/source/repos/CW1_GUI/home.txt", current_home);
        }
        

        private void Favourites_ButtonClick(object sender, EventArgs e)
        {

        }

        private void History_ButtonClick(object sender, EventArgs e)
        {
        }
        

        private void Back_Click(object sender, EventArgs e)
        {
            if (History_enum_ind > 0)
            {
                // Move index
                History_enum_ind--;
                // Display previous
                search(current_history[History_enum_ind]);
            }
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            if (History_enum_ind < current_history.Count - 1)
            {
                // Move index
                History_enum_ind++;
                //Display next
                search(current_history[History_enum_ind]);
            }
        }
    }
}
