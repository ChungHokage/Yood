using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X.Ulitilities.Shared
{
    public static class GenarateCode
    {
        private static readonly Random random = new Random();
        private static string numberousSet = "0123456789";
        private static string upperCaseSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static string lowerCaseSet = "abcdefghijklmnopqrstuvwxyz";
        private static string charSet = numberousSet + upperCaseSet;

        public static string ProductCode()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                if (i < 3)
                {
                    int viTriNgauNhien = random.Next(0, upperCaseSet.Length);
                    char kyTuNgauNhien = upperCaseSet[viTriNgauNhien];
                    sb.Append(kyTuNgauNhien);
                }
                else
                {
                    int viTriNgauNhien = random.Next(0, charSet.Length);
                    char kyTuNgauNhien = charSet[viTriNgauNhien];
                    sb.Append(kyTuNgauNhien);
                }
            }
            return sb.ToString();
        }

        public static string ColorCode()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 5; i++)
            {
                if (i < 2)
                {
                    int viTriNgauNhien = random.Next(0, upperCaseSet.Length);
                    char kyTuNgauNhien = upperCaseSet[viTriNgauNhien];
                    sb.Append(kyTuNgauNhien);
                }
                else
                {
                    int viTriNgauNhien = random.Next(0, numberousSet.Length);
                    char kyTuNgauNhien = upperCaseSet[viTriNgauNhien];
                    sb.Append(kyTuNgauNhien);
                }
            }
            return sb.ToString();
        }
    }
}