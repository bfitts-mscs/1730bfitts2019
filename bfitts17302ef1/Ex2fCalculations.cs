﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bfitts17302ef1
{
    public class Ex2fCalculations
    {
        public static string Calc01(string input)
        {
            //#1: if
            decimal subtotal = 0.0m;
            decimal discountPercent = 0.0m;
            subtotal = Decimal.Parse(input);
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            return discountPercent.ToString("n2");
        }

        public static string Calc02(string input)
        {
            // #2: if {block}
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            string status = "Standard rate: ";
            if (subtotal >= 100m)
            {
                discountPercent = 0.2m;
                status = "Bulk rate: " + discountPercent.ToString("n2");
            }
            return status;
        }

        public static string Calc03(string input)
        {
            // #3: if else
            decimal subtotal = 0m;
            decimal discountPercent = 0.0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 100)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc04(string input)
        {
            // #4 if else if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0.0m;
            if (subtotal >= 100m && subtotal < 200m)
                discountPercent = 0.2m;
            else if (subtotal >= 200m && subtotal < 300m)
                discountPercent = 0.3m;
            else if (subtotal >= 300m)
                discountPercent = 0.4m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc05(string input)
        {
            // #5 Better range test
            decimal subtotal = 0m;
            decimal discountPercent = 0;
            subtotal = Decimal.Parse(input);
            discountPercent = 0.0m;
            if (subtotal >= 300)
                discountPercent = 0.4m;
            else if (subtotal >= 200m)
                discountPercent = 0.3m;
            else if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc06(string inputA, string inputB)
        {
            // #6 Nested if
            decimal subtotal = 0m;
            decimal discountPercent = 0;
            subtotal = Decimal.Parse(inputA);
            string customerType = inputB;
            discountPercent = 0.0m;
            if (customerType == "R")
            {
                if (subtotal >= 100m)
                    discountPercent = 0.2m;
                else
                    discountPercent = 0.1m;
            }
            else discountPercent = 0.4m;
            return discountPercent.ToString("n2");
        }

        public static string Calc07(string input)
        {
            // #7 Validate input: non-empty string  input converted to decimal * 200.ToString("n2");
            decimal ethereum = 0m;
            if (input != "")
            {
                decimal subtotal = Decimal.Parse(input);
                ethereum = (subtotal * 200);
                return ethereum.ToString("n2");
            }
            return "Invalid input";
        }

        public static string Calc08(string inputA, string inputB)
        {
            // #8 Validate input, calculate quantity * price, shipping     a = price b = quantity
            decimal totalPrice = 0m;
            if (inputA != "" & inputB != "")
            {
                decimal price = Decimal.Parse(inputA);
                decimal quantity = Decimal.Parse(inputB);
                decimal shipping = 0m;
                totalPrice = (price * quantity);
                if (totalPrice >= 50)
                {
                    shipping = totalPrice;
                }
                else shipping = totalPrice + 5m;
                return shipping.ToString("n2");
            }
            return "Invalid input";
        }

        public static string Calc09(string inputA, string inputB)
        {
            // #9 Validate input, calculate difference * rate
            decimal meterA = Decimal.Parse(inputA);
            decimal meterB = Decimal.Parse(inputB);
            if (inputA != "" & inputB != "")
            {
                if (meterA < meterB)
                {
                    decimal used = meterB - meterA;
                    decimal total = used * .1m;
                    return total.ToString("n2");
                }
            }
                return "Invalid input";
        }

        public static string Calc10(string inputA, string inputB)
        {
            // #10 Validate input, divide large num by small
            //     Both numbers must be > 0
            
            decimal result = 0m;
            if (inputA != "" & inputB != "")
            {
                decimal input1 = Decimal.Parse(inputA);
                decimal input2 = Decimal.Parse(inputB);
                if (input1 > 0 & input2 > 0)
                    {
                        if (input1 > input2)
                        {
                            result = input1 / input2;
                            return result.ToString("n2");
                        }
                        else result = input2 / input1;
                        return result.ToString("n2");
                    }
            }
            return "Invalid input";
            
        } 
    }
}
