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

namespace CW1_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public System.Collections.Generic.List<Uri>.Enumerator History { get; }
        public System.Collections.Generic.List<Uri>.Enumerator Favourites { get; }

        public String home { get; set; }

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

        public void Goback()
        {

        }
        public void GoForward()
        {

        }


        private void Search_Click(object sender, EventArgs f)
        {

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
            
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            search(this.Search_box.Text);
                
        }

        private void Home_Click(object sender, EventArgs e)
        {
            if ( this.home != null)
            {
                search(this.home);
            }
            else { Display.Text = "Home is not set."; }
        }

        private void Set_home_Click(object sender, EventArgs e)
        {
            this.home = this.Search_box.Text;
        }
    }
}
