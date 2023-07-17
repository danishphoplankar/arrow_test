using System;
using System.Linq;
using Arrow.DeveloperTest.Services;
using Arrow.DeveloperTest.Types;
using Arrow.DeveloperTest.Data;


namespace Arrow.DeveloperTest.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MakePaymentRequest makePaymentRequest = new MakePaymentRequest();
            makePaymentRequest.DebtorAccountNumber = "AZ123";
            makePaymentRequest.AmountPaid =100;
            makePaymentRequest.PaymentScheme = AllowedPaymentSchemes.Chaps;
            PaymentService paymentService = new PaymentService(new AccountDataStore());
            bool paymentsuccess = paymentService.MakePayment(makePaymentRequest).Success;
            if(paymentsuccess)
            {
                Console.WriteLine("Payment Successful");
            }
            else
            {
                Console.WriteLine("Payment Unsuccessful");
            }

        }
        
    }
}
