using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryApplication
{
    /// <summary>
    /// This class defines a Member
    /// </summary>
    public class Member
    {
        #region Properties
        /// <summary>
        /// MemberID
        /// </summary>
        public int MemberId { get; set; }

        /// <summary>
        /// Member Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Member's Email address
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Memeber's Address
        /// </summary>
        public string Address  { get; set; }

        /// <summary>
        /// Member's PhoneNumber
        /// </summary>
        public int PhoneNumber { get; set; }

        #endregion

    }
}
