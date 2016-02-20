using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            BankAccount myAccount = new BankAccount();

            // Test the BankAccount - make some deposits and withdrawals,
            // and check that the balance behaves as expected
            myAccount.GetBalance();
            Console.WriteLine("Balance is now : {0}", myAccount.GetBalance());


            // The LAST line of code should be ABOVE this line
        }
    }
}
