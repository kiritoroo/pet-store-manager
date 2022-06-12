using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    public static class VoucherService
    {
        private static readonly ThreadLocal<Random> _random = new ThreadLocal<Random>(() => new Random());
        public static string GenerateCode(int VoucherCodeLength)
        {
            char[] chars = "ACDEFGHJKLMNPQRTUVWXYZ234679".ToCharArray(); 

            var sb = new StringBuilder();
            for (int i = 0; i < VoucherCodeLength; i++)
            {
                int num = _random.Value.Next(0, chars.Length);
                sb.Append(chars[num]);
            }
            return sb.ToString();
        }
    }
}
