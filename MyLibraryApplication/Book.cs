using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApplication
{
    /// <summary>
    /// This class defines a Book
    /// </summary>
     public class Book
    {

        #region Properties

        /// <summary>
        /// ISBN number of the Book
        /// </summary>
        public int IsbnNumber { get; set; }

        /// <summary>
        /// Title of the book
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Author of the Book
        /// </summary>
        public string Author  { get; set; }

        /// <summary>
        /// Genre of the Book
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Publisher of the Book
        /// </summary>
        public string Publisher { get; set; }

        /// <summary>
        /// Date of publication of the book
        /// </summary>
        public DateTime DateOfPublication { get; set; }

        #endregion
    }
}
