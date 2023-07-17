using Arrow.DeveloperTest.Types;


namespace Arrow.DeveloperTest.Data
{
    public interface IAccountDataStore
    {
        public AccountDetails GetAccount(string accountNumber);
        public void UpdateAccount(AccountDetails updateAccountDetails, decimal paidAmount);
    }
}
