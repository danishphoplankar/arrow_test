using Arrow.DeveloperTest.Types;
using System.Collections.Generic;
using System.Linq;

namespace Arrow.DeveloperTest.Data
{
    public class AccountDataStore :IAccountDataStore
    {
        private List<AccountDetails> accountDetails;
        public AccountDataStore()
        {
            accountDetails = new List<AccountDetails>()
            { new AccountDetails("AZ123",12000,AccountStatus.Live,AllowedPaymentSchemes.Chaps),
              new AccountDetails("AZ124",25000,AccountStatus.Live,AllowedPaymentSchemes.Bacs),
              new AccountDetails("AZ125",15000,AccountStatus.Disabled,AllowedPaymentSchemes.Chaps),
              new AccountDetails("AZ126",35000,AccountStatus.InboundPaymentsOnly,AllowedPaymentSchemes.Chaps),
              new AccountDetails("AZ127",25000,AccountStatus.Live,AllowedPaymentSchemes.FasterPayments),
            };

        }
        public AccountDetails GetAccount(string accountNumber)
        {
            // Access database to retrieve account, code removed for brevity 
            return accountDetails.FirstOrDefault(p => p.AccountNumber.Equals(accountNumber));
        }

        public void UpdateAccount(AccountDetails updateAccountDetails,decimal paidAmount)
        {
            // Update account in database, code removed for brevity
            accountDetails.FirstOrDefault(p => p.AccountNumber.Equals(updateAccountDetails.AccountNumber)).AccountBalance -= paidAmount;


        }
       
    }
}
