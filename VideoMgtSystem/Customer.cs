using System;
using System.Collections.Generic;
using System.Text;

namespace VideoMgtSystem
{
    class Customer
    {
        #region properties
        public int AccountId { get; set; }
        public String AccountName { get; set; }
        public string AccountType { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CreatedDate { get; set; }
        #endregion
    }
}

