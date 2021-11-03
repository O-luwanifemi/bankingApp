using System;

namespace BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var wema = new Bank();
            Console.WriteLine(wema.contactUser("Joseph Oloba"));
        }
    }

    class Bank
    {
        public Bank()
        {

        }

        public string Name { get; set; }
        private uint numberOfStaffs { get; set; }
        public string headOfficeAddress { get; set; }

        public string receiveMoney(string sender, int amountSaved)
        {
            string transactionDetails = $"{amountSaved} by {sender}";
            return transactionDetails;
        }

        public string sendMoney(string sender, string recipient, int amount)
        {
            string transactionDetails = $"{amount} sent by {sender} to {recipient}";
            return transactionDetails;
        }

        public string contactUser(string user)
        {
            return user;
        }
    }
}
