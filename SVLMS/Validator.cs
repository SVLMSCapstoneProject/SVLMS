using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;

namespace SVLMS
{
    class Validator
    {
        public static bool isAlphanumeric(string text)
        {
            bool check = true;
            try
            {
                double num = Convert.ToDouble(text);
                check = false;
            }
            catch (Exception)
            {
                check = true;
            }
            return check;
        }

        public static bool isValidAmount(string text)
        {
            bool check = true;
            try
            {
                double num = Convert.ToDouble(text);
                if (num <= 0)
                {
                    check = false;
                }
            }
            catch (Exception)
            {
                check = false;
            }
            return check;
        }

        public static bool isValidRate(string text)
        {
            bool check = true;
            try
            {
                double num = Convert.ToDouble(text);
                if (num < 0)
                {
                    check = false;
                }
            }
            catch (Exception)
            {
                check = false;
            }
            return check;
        }

        public static bool isValidDigit(string text)
        {
            bool check = true;
            try
            {
                int num = Convert.ToInt32(text);
                if (num <= 0)
                {
                    check = false;
                }
            }
            catch (Exception)
            {
                check = false;
            }
            return check;
        }

        public static string amountFormatter(string text)
        {
            double deduction = Convert.ToDouble(text);
            double truncated = Math.Round(deduction,2);
            //double truncated = Math.Truncate(deduction * 100) / 100;
            text = String.Format("{0:0.00}", truncated);
            return text;
        }

        public static double truncateNumber(string text)
        {
            double deduction = Convert.ToDouble(text);
            double truncated = Math.Truncate(deduction * 10000) / 10000;
            return truncated;
        }

        public static bool isValidEmail(string text)
        {
            bool check = false;
            try
            {
                var email = new System.Net.Mail.MailAddress(text);
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }
            return check;
        }
    }
}
