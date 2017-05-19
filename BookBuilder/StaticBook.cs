﻿using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BookBuilder
{
    /// <summary>
    /// Stores the book we're creating and associated data, like the SetupForm and MainForm.
    /// This makes it easy to share data between forms.
    /// </summary>
    public static class StaticBook
    {
        /// <summary>
        /// The BB_Book we're creating.
        /// </summary>
        public static BB_Book Book = new BB_Book();

        /// <summary>
        /// The main form. This is where the book building takes place.
        /// Should be hidden until the user finishes the SetupForm.
        /// Should be initialized by main function.
        /// </summary>
        public static MainForm mainForm;

        /// <summary>
        /// The setup form where the user chooses the number of pages and enters book information like the authors.
        /// Should be initialized and shown immediately when the user creates the MainForm.
        /// </summary>
        public static SetupForm setupForm;

        /// <summary>
        /// True if the BB_Book was opened from a file or has already been saved
        /// </summary>
        public static bool hasBeenSaved = false;

        /// <summary>
        /// Allowed audio file types.
        /// </summary>
        public const string audioFileFilter = "Audio files (*.mp3, *.m4a, *.wma, *.wav) | *.mp3; *.m4a; *.wma; *.wav";
        /// <summary>
        /// Allowed image file types.
        /// </summary>
        public const string imageFileFilter = "Image files (*.jpg, *.jpeg, *.gif, *.png, *.tiff)| *.jpg; *.jpeg; *.gif; *.png; *.tiff";
        /// <summary>
        /// Allowed video file types.
        /// </summary>
        public const string videoFileFilter = "Video files (*.avi, *.mp4, *.wmv, *.m4v, *.avi)| *.avi; *.mp4; *.wmv; *.m4v; *.avi";
        /// <summary>
        /// Filter for ARMB file type.
        /// </summary>
        public const string armbFilter = "ARMB files (*.armb)| *.armb";

        /// <summary>
        /// The path where the book is saved to or opened from.
        /// </summary>
        public static string savePath = "";

        /// <summary>
        /// Opens a book. Loads it into Book and opens it in mainForm.
        /// </summary>
        /// <param name="filePath">Full path of the book to open.</param>
        public static void OpenBook(string filePath)
        {
            //Extract zip into temp folder
            String tempFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "../Local/ARMB/temp/bookbuilder/building");

            if (Directory.Exists(tempFolder))
            {
                //Release resources being held by the imagebox so we can delete the temp folder
                mainForm.DisposeImage();
                Directory.Delete(tempFolder, true);
            }

            Directory.CreateDirectory(tempFolder);
            ZipFile.ExtractToDirectory(filePath, tempFolder);
            //Parse the serialized BB_Book and copy it into our book.
            StaticBook.Book.DeserializeBook(tempFolder);
            ParseBook(Path.Combine(tempFolder,"config.xml"));
            foreach (BB_Page p in StaticBook.Book.Pages)
            {
                if (p.PageImageFileName != null && p.PageImageFileName != "")
                {
                    p.SourcePageImageFileName = Path.Combine(tempFolder, "images", p.PageImageFileName);
                }
                if (p.AudioFileName != null && p.AudioFileName != "")
                {
                    p.SourceAudioFileName = Path.Combine(tempFolder, "audio", p.AudioFileName);
                }
                if (p.VideoFileName != null && p.VideoFileName != "")
                {
                    p.SourceVideoFileName = Path.Combine(tempFolder, "video", p.VideoFileName);
                }
            }
        }

        //Returns true if config.xml was successfully parsed
        static bool ParseBook(String fileName)
        {
            XmlDocument config = new XmlDocument();
            try
            {
                config.Load(fileName);
            }
            catch
            {
                return false;
            }
            XmlNodeList bookNodeList = config.GetElementsByTagName("book");
            XmlNode bookNode = null;
            foreach (XmlNode n in bookNodeList)//there should only be one
            {
                bookNode = n;
            }
            XmlAttribute fileVersionAttr = null;
            foreach (XmlAttribute attr in bookNode.Attributes)//should only be one
            {
                fileVersionAttr = attr;
            }

            Book.FileVersion = fileVersionAttr.Value;

            XmlElement titleElement = bookNode["title"];
            Book.Title = titleElement.InnerText;

            //Iterate over child nodes
            foreach (XmlNode n in bookNode.ChildNodes)
            {
                
                if (n.Name == "author")
                {
                    Book.Authors.Add(n.InnerText);
                } else if (n.Name == "creation_date")
                {
                    Book.CreationDate = n.InnerText;
                } else if (n.Name == "Description")
                {
                    Book.Description = n..InnerText;
                }
            }

            return true;
        }


        //public static void SaveBook(string )

        [STAThread]
        static void Main(string[] args)
        {
            //This starts the MainForm.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //The MainForm starts as invisible and SetupForm starts as visible.
            mainForm = new MainForm();
            mainForm.Visible = false;
            setupForm = new SetupForm();
            setupForm.Visible = true;
            Application.Run();
        }
    }
}