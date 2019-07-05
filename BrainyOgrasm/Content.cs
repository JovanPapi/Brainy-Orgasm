using System.Drawing;
using System.IO;

namespace BrainyOgrasm
{
    /// <summary>
    /// Class that stores the content needed for the ContentForm
    /// </summary>
    public class Content
    {
        /// <summary>
        /// Gets or sets the name of the file which the main content is held
        /// </summary>
        public string NameOfFile { get; set; }
        /// <summary>
        /// Gets or sets the main content (text) that is going to be shows on the ContentForm
        /// </summary>
        public string MainContent { get; set; }
        /// <summary>
        /// Gets or sets the title of the current topic that is going to be displayed on the ContentForm
        /// </summary>
        public string SubDomainTitle { get; set; }
        /// <summary>
        /// Gets or sets the first image that is going to be displayed of the ContentForm
        /// </summary>
        public Bitmap Image1 { get; set; }
        /// <summary>
        /// Gets or sets the second image that is going to be displayed of the ContentForm
        /// </summary>
        public Bitmap Image2 { get; set; }

        /// <summary>
        /// The current mode that is going to be displayed on the ContentForm
        /// </summary>
        public static string MAIN_TITLE;
        
        /// <summary>
        /// Constructor for Content class
        /// </summary>
        /// <param name="nameOfFile">The name of the file that contains the info about the topic</param>
        /// <param name="image1">First image for the topic</param>
        /// <param name="image2">Second image for the topic</param>
        public Content(string nameOfFile, Bitmap image1, Bitmap image2)
        {
            NameOfFile = nameOfFile;
            Image1 = image1;
            Image2 = image2;
            MainContent = ContentFromFile();
            SubDomainTitle = NameOfFile.Split(".".ToCharArray())[0];
            
        }

        /// <summary>
        /// Method that reads the content from a file
        /// </summary>
        /// <returns>The whole file as one string</returns>
        private string ContentFromFile()
        {
            return File.ReadAllText(@".\..\..\Content\"+NameOfFile);
        }
    }
}
