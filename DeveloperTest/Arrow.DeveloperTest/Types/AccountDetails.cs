namespace Arrow.DeveloperTest.Types
{
    public class AccountDetails
    {
        public AccountDetails(string accountNumber, decimal accountBalance, AccountStatus statusOfAccount, AllowedPaymentSchemes allowedPaymentSchemes)
        {
            AccountNumber = accountNumber;
            AccountBalance = accountBalance;
            StatusOfAccount = statusOfAccount;
            AllowedPaymentSchemes = allowedPaymentSchemes;

        }
        public string AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }
        public AccountStatus StatusOfAccount { get; set; }
        public AllowedPaymentSchemes AllowedPaymentSchemes { get; set; }
    }
}
