using System;
using System.Linq;
using System.Text;

namespace KnuthMP
{
    public class MP
    {
        // arithmetic base
        private readonly int b = 10;
        public string AddInt(string strInt1, string strInt2)
        {
           

            int LengthInt1 = strInt1.Length;
            int LengthInt2 = strInt2.Length;

            StringBuilder sbFixLengths = new StringBuilder();

            if (strInt2.Length < strInt1.Length)
            {

                int pad0 = strInt1.Length - strInt2.Length;
                for (int x = 0; x < pad0; x++)
                {
                    sbFixLengths.Append("0");
                }
                sbFixLengths.Append(strInt2);

                strInt2 = sbFixLengths.ToString();

            }


            if (strInt1.Length < strInt2.Length)
            {

                int pad0 = strInt2.Length - strInt1.Length;
                for (int x = 0; x < pad0; x++)
                {
                    sbFixLengths.Append("0");
                }
                sbFixLengths.Append(strInt1);
                strInt1 = sbFixLengths.ToString();

            }


            // Both strInt1 ad strInt2 should be at same length
            // here
       
            int k = 0;

            StringBuilder sb1 = new StringBuilder();

            for (int j = strInt1.Length; j > 0; j = j - 1)
            {
                sb1.Append(((Int32.Parse(strInt1[j - 1].ToString()) + Int32.Parse(strInt2[j - 1].ToString()) + k) % b).ToString()[0]);
                k = (int)Math.Floor((Decimal.Parse(strInt1[j - 1].ToString()) + Decimal.Parse(strInt2[j - 1].ToString()) + Decimal.Parse(k.ToString())) / Decimal.Parse(b.ToString()));
            }
            if (k != 0)
            {
                sb1.Append(k.ToString());
            }

            string result = new string(sb1.ToString().Reverse().ToList().ToArray());
            return result;
        }
    }
}
