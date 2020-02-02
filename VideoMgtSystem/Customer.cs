using System;
using System.Collections.Generic;
using System.Text;

namespace VideoMgtSystem
{
    enum TypeOfAccounts
    {
        Invididual,
        Subscription
    }
    class Customer
    { public static int lastAccountId = 0;
        #region properties
        public int AccountId { get; set; }
        public String AccountName { get; set; }
        public TypeOfAccounts AccountType { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CreatedDate { get; set; }
        #endregion
        #region Constructor
        public Customer()
        {
            AccountId = ++lastAccountId;
            CreatedDate = DateTime.UtcNow;
        }
        #endregion

        #region Methods
        ///Checkout and Return
        ///
        
        public void CheckOut(string Name)
        {
            
        }
        public void Return(string Name)
        {

        }
        public void SearchMovie()
        {

        }
        #endregion

    }
}

