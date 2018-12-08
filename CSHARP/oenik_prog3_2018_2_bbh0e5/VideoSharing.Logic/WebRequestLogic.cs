// <copyright file="WebRequestLogic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace VideoSharing.Logic
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Includes web endpoint queries.
    /// </summary>
    public class WebRequestLogic
    {
        private WebClient client;

        /// <summary>
        /// Initializes a new instance of the <see cref="WebRequestLogic"/> class.
        /// </summary>
        public WebRequestLogic()
        {
            this.client = new WebClient();
        }

        /// <summary>
        /// Gets contains the response text from Java Endpoint.
        /// </summary>
        public string ResponseString { get; private set; }

        /// <summary>
        /// Download the date from Java Endpont and calls the SaveToFile method.
        /// </summary>
        /// <param name="gender">Contains the type of gender.</param>
        public void ListenWeb(string gender)
        {
            try
            {
                byte[] temp = this.client.DownloadData($"http://localhost:8080/VideoSharing.JavaWeb/XMLSender?gender={gender}");
                this.ResponseString = Encoding.ASCII.GetString(temp);
                this.SaveToFile();
            }
            catch (WebException e)
            {
                Console.WriteLine("Webes hiba! {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Általános hiba! {0}", e.Message);
            }
        }

        /// <summary>
        /// Writes out the contents of the response text to output.xml prints the contents of the box.
        /// </summary>
        public void SaveToFile()
        {
            using (StreamWriter streamWriter = new StreamWriter("output.txt", false, Encoding.ASCII))
            {
                streamWriter.WriteLine(this.ResponseString);
            }
        }
    }
}
