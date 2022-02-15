using System;
using System.Text.RegularExpressions;
/// <summary>
/// /// FFX- Assignment 
///  Postcode parser
/// Developer: S.Sathiyan 15-02-2022
/// </summary>
namespace FFX_PostCode_Parser
{
    public class PostCodeParser
    {
        static void Main(string[] args)
        {
            // Type your Postcode and press enter
            Console.WriteLine("Enter The Postcode Here:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string postcode = Console.ReadLine();

            if (CheckPostCodeValidation(postcode))
            {
                var result = ParseStringToPostcode(postcode);

                Console.WriteLine(Indent(0) + "#POSTCODE:" + result.postCode);
                Console.WriteLine(Indent(3) + "OUTWARD CODE:" + result.outwardCode);
                Console.WriteLine(Indent(6) + "OUTWARD LETTER:" + result.outwardLetter);
                Console.WriteLine(Indent(6) + "OUTWARD NUMBER:" + result.outwardNumber);
                Console.WriteLine(Indent(3) + "INWARD CODE:" + result.inwardCode);
            }
            else
            {
                Console.WriteLine("Invalid PostCode");
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Check Postcode Validation 
        /// </summary>
        /// <param name="postcode"></param>
        /// <returns></returns>
        public static bool CheckPostCodeValidation(string postcode)
        {
            postcode = postcode.Replace(" ", "").Trim();
            Regex regCode = new Regex("^[A-Za-z]{1,2}[0-9A-Za-z]{1,2}[ ]?[0-9]{0,1}[A-Za-z]{2}$");
            return regCode.Match(postcode).Success;
        }

        /// <summary>
        /// Assign to model 
        /// </summary>
        /// <param name="inputPostcode"></param>
        /// <returns></returns>
        private static PostcodeBO ParseStringToPostcode(string inputPostcode)
        {
            PostcodeBO postcodeBO = new PostcodeBO();
            postcodeBO.postCode = inputPostcode;

            postcodeBO.outwardCode = postcodeBO.postCode.Substring(0, postcodeBO.postCode.Length - 3);
            postcodeBO.outwardLetter = postcodeBO.outwardCode.Substring(0, Regex.Match(postcodeBO.outwardCode, @"\d+").Index);
            postcodeBO.outwardNumber = postcodeBO.outwardCode.Substring(Regex.Match(postcodeBO.outwardCode, @"\d+").Index);

            postcodeBO.inwardCode = postcodeBO.postCode.Substring(Math.Max(0, postcodeBO.postCode.Length - 3));
            postcodeBO.postCode = string.Format("{0}{1}", postcodeBO.outwardCode, postcodeBO.inwardCode);

            return postcodeBO;
        }

        /// <summary>
        ///For Making Space 
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        private static string Indent(int count)
        {
            return "".PadLeft(count);
        }
    }
}
