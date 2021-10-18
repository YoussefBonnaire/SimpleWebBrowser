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

namespace CW1_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Browser mybrowser = Browser.Search("https://docs.microsoft.com/");
        }

        
    }
    public class Browser
    {
        public System.Collections.Generic.List<Uri>.Enumerator History { get; }
        public System.Collections.Generic.List<Uri>.Enumerator Favourites { get; }

        public void Search(string source)
        {

            // Create a request for the URL.
            WebRequest request = WebRequest.Create(
              "source");
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;

            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            // Get the stream containing content returned by the server.
            // The using block ensures the stream is automatically closed.
            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Display the content.
                Console.WriteLine(responseFromServer);
            }

            // Close the response.
            response.Close();
        }

        public void Goback()
        {

        }
        public void GoForward()
        {

        }

        public void refresh()
        {

        }

    }
}
