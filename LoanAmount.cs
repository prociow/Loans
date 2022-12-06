using Loans.Domain;
using System;
using System.Collections.Generic;

namespace Loans.Domain.Applications
{
    public class LoanAmount
    {
        public string CurrencyCode { get; }
        public decimal Principal { get; }

        // Explicitly stating to hide dealt constructor to indicate immutability
        private LoanAmount(){}

        public LoanAmount(string currencyCode, decimal principal)
        {
            CurrencyCode = currencyCode;
            Principal = principal;
        }

       
    }
}
