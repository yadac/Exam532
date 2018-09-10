using System;

namespace Exam532Libs
{
    public class RateManager
    {

        public double LookupTaxRate(string region)
        {
            if (region == null)
            {
                throw new ArgumentException("Region can not be blank");
            }

            double taxRate = 0.3;

            if (region == "Alberta")
            {
                taxRate = 0.2;
            }

            if (region == "Saskatchewan")
            {
                taxRate = 0.2;
            }

            return taxRate;

        }
    }
}
