using Arrow.DeveloperTest.Data;
using Arrow.DeveloperTest.Types;
using System;


namespace Arrow.DeveloperTest.Services
{
    public class PaymentService : IPaymentService
    {
        private IAccountDataStore _iaccountDetails;
        public PaymentService(IAccountDataStore iAccountDetails)
        {
            _iaccountDetails = iAccountDetails;
        }
        public MakePaymentResult MakePayment(MakePaymentRequest makePayementRequest)
        {
            try
            {
                if (makePayementRequest == null)
                    throw new ArgumentNullException("NullPaymentRequestObject");
                var result = new MakePaymentResult();
                AccountDetails accountDetails = _iaccountDetails.GetAccount(makePayementRequest.DebtorAccountNumber);

                if (accountDetails != null && accountDetails.AllowedPaymentSchemes.HasFlag(makePayementRequest.PaymentScheme)
                    && accountDetails.AccountBalance >= makePayementRequest.AmountPaid && accountDetails.StatusOfAccount == AccountStatus.Live)
                {
                    result.Success = true;
                }

                if (result.Success)
                {

                    _iaccountDetails.UpdateAccount(accountDetails, makePayementRequest.AmountPaid);
                }
                return result;
            }
            catch
            {
                throw;
            }
        }

    }
}
