﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Adrestia
{
    public class Security
    {
        public static string ConnectionString = @"Data Source=alberts-pc;User ID=albert;Password=sql123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=true";
        // @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Adrestia\Adrestia\Adrestia\Database5.mdf;Integrated Security=True;MultipleActiveResultSets=true";
        // LAPTOP-C3G7RSU6
        //public static string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Marné\Documents\NWU\CMPG 223\Assignment\Adrestia\Adrestia\Adrestia\Database4.mdf;Integrated Security=True;MultipleActiveResultSets=true";
        // @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Marné\Documents\NWU\CMPG 223\Assignment\GitHub\Adrestia\Adrestia\Adrestia\Database2.mdf;Integrated Security=True";
        // @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Git\Adrestia\Adrestia\Adrestia\res\DatabaseAJ.mdf;Integrated Security=True";
        //@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Adrestia\Adrestia\Adrestia\Database5.mdf;Integrated Security=True";

        public static string GetSHA1Hash(string pw)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(pw));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }
    }
}
