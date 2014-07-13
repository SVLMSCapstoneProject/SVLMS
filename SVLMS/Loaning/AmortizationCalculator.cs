using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SVLMS.Loaning.Model;
using System.Data;
using System.Data.SqlClient;

namespace SVLMS.Loaning
{
    class AmortizationCalculator
    {
        public double loanAmount { get; set; }
        public int paymentIntervalDays { get; set; }
        public int termsOfPayment { get; set; }
        public int termsOfPaymentDays { get; set; }
        public string loanDate { get; set; }
        public double interestRate { get; set; }
        //public double savingsRate { get; set; }
        public double capitalRate { get; set; }
        //public int isPercentageSavings { get; set; }
        public int isPercentageInterest { get; set; }
        public int isPercentageShare{ get; set; }
        public double totalInterest { get; set; }
        //public double totalSavings { get; set; }
        public double totalShare { get; set; }
        public double paymentTotalAmount { get; set; }
        public double amortizationAmount { get; set; }
        public int noOfAmortization { get; set; }

        public string[,] getAmortizationSchedule(string approvedAmount)
        {
            this.loanAmount = Convert.ToDouble(approvedAmount);

            //Counter for Date
            string date = Convert.ToDateTime(loanDate).AddDays(paymentIntervalDays).ToShortDateString();

            //Fields
            double principal = 0;
            double interest = 0;
            //double savings = 0;
            double shareCapital = 0;
            double totalAmount = 0;

            double principalLess = 0;
            double interestLess = 0;
            //double savingsLess = 0;
            double shareCapitalLess = 0;
            double totalAmountLess = 0;

            double noOfPaymentsDouble = termsOfPaymentDays / paymentIntervalDays;
            int noOfPayment = Convert.ToInt32(noOfPaymentsDouble);
            string[,] amortizationSchedule = new string[noOfPayment,6];

            //Compute the Total Rates
            //totalSavings = this.getRateAmount(isPercentageSavings,savingsRate);
            totalInterest = this.getRateAmount(isPercentageInterest, (interestRate*termsOfPayment));
            totalShare = this.getRateAmount(isPercentageShare, capitalRate);
            //paymentTotalAmount = loanAmount + totalSavings + totalShare + totalInterest;
            paymentTotalAmount = loanAmount + totalShare + totalInterest;

            //Compute the fields
            principal = loanAmount / noOfPayment;
            //savings = totalSavings / noOfPayment;
            shareCapital = totalShare / noOfPayment;
            interest = totalInterest / noOfPayment;
            //totalAmount = principal + savings + shareCapital + interest;
            totalAmount = principal + shareCapital + interest;
            string text = "";

            amortizationAmount = 0;
            for (int x = 0; x < noOfPayment-1; x++)
            {
                amortizationSchedule[x, 0] = date;
                amortizationSchedule[x, 1] = Validator.truncateNumber(principal.ToString()).ToString(); 
                amortizationSchedule[x, 2] = Validator.truncateNumber(interest.ToString()).ToString(); 
                //amortizationSchedule[x, 3] = Validator.truncateNumber(savings.ToString()).ToString(); 
                amortizationSchedule[x, 3] = Validator.truncateNumber(shareCapital.ToString()).ToString(); 
                amortizationSchedule[x, 4] = Validator.truncateNumber(totalAmount.ToString()).ToString(); 
                text += amortizationSchedule[x, 0] + "---" + amortizationSchedule[x, 1] + amortizationSchedule[x, 2] + amortizationSchedule[x, 3] + amortizationSchedule[x, 4] + amortizationSchedule[x, 5] + "\n";
                date = Convert.ToDateTime(date).AddDays(paymentIntervalDays).ToShortDateString();

                amortizationAmount += totalAmount;
                principalLess += Validator.truncateNumber(principal.ToString());
                interestLess += Validator.truncateNumber(interest.ToString());
                //savingsLess += Validator.truncateNumber(savings.ToString());
                shareCapitalLess += Validator.truncateNumber(shareCapital.ToString());
                totalAmountLess += Validator.truncateNumber(totalAmount.ToString());
                noOfAmortization += 1;
            }
            date = Convert.ToDateTime(date).AddDays(paymentIntervalDays).ToShortDateString();
            amortizationSchedule[noOfPayment - 1, 0] = date;
            amortizationSchedule[noOfPayment - 1, 1] = (loanAmount - principalLess).ToString();
            amortizationSchedule[noOfPayment - 1, 2] = (totalInterest - interestLess).ToString();
            //amortizationSchedule[noOfPayment - 1, 3] = (totalSavings - savingsLess).ToString();
            amortizationSchedule[noOfPayment - 1, 3] = (totalShare - shareCapitalLess).ToString();
            amortizationSchedule[noOfPayment - 1, 4] = (paymentTotalAmount - totalAmountLess).ToString();
            amortizationAmount += (paymentTotalAmount - totalAmountLess);
            noOfAmortization += 1;
            return amortizationSchedule;
        }

        private double getRateAmount(int isPercentage, double amount)
        {
            double rateAmount = 0;
            if (isPercentage == 1)
            {
                rateAmount = (amount / 100)*loanAmount;
            }

            else
            {
                rateAmount = amount;
            }
            return rateAmount;
        }

        private string amountFormatter(string text)
        {
            double deduction = Convert.ToDouble(text);
            double truncated = Math.Truncate(deduction * 100) / 100;
            text = String.Format("{0:0.00}", truncated);
            return text;
        }

        //public double getTotalSavings()
        //{
        //    return totalSavings;
        //}

        public double getTotalShares()
        {
            return totalShare;
        }

        public double getTotalInterest()
        {
            return totalInterest;
        }

        public double getLoanAmount()
        {
            return loanAmount;
        }

        public double getTotalAmount()
        {
            return paymentTotalAmount;
        }
    }
}
