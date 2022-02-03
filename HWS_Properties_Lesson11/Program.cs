using System;

namespace HWS_Properties_Lesson11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string custName = "Mika";
            double[] sumLines = { 113.5, 159, 252, 999 };
            DateTime validDate = DateTime.Now.AddDays(4);
            Quotation quotation = new Quotation(custName, sumLines, validDate);
            //quotation.CustomerName = "newMika";
            //quotation.ValidUntil = quotation.ValidUntil.AddDays(3);
            quotation.SumLines[3] = 734;
            quotation.ChangeMainDetails("newMika", quotation.ValidUntil.AddDays(3));
            sumLines[3] = 144;
        }
    }
}
