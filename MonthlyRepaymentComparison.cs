using System.Collections.Generic;

namespace Loans.Domain.Applications
{
    public class MonthlyRepaymentComparison
    {
        public string ProductName { get; }
        public decimal InterestRate { get; }
        public decimal MonthlyRepayment { get; }

        private MonthlyRepaymentComparison(){}

        public MonthlyRepaymentComparison(string productName, decimal interestRate, decimal monthlyRepayemt)
        {
            ProductName = productName;
            InterestRate = interestRate;
            MonthlyRepayment = monthlyRepayemt;
        }

    }
}