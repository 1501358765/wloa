using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Web.Script.Serialization;
using System.Security.Cryptography;

namespace Common
{
    public class KIts
    {
        public static string ToMD5(string line)
        {
            byte[] b = Encoding.Default.GetBytes(line);
            MD5 md5 = MD5.Create();
            byte[] c = md5.ComputeHash(b);
            StringBuilder sb = new StringBuilder();
            foreach (byte s in c)
            {
                sb.Append(s.ToString("X2"));
            }
            return sb.ToString();
        }
        public static List<T> ConvertToList<T>(IQueryable query)
        {
            return query.Cast<T>().ToList();
        }
        public static string ToJson(object o)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            return jss.Serialize(o);
        }
    }
}
