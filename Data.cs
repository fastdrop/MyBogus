using System.Collections.Generic;

namespace MyBogus
{
    public class Data<T>
    {
        public IList<T> List = new List<T>();
        public const string Characters = "abcdefghijklmnopqrstuvwxyz0123456789";

        public static List<string> Domains() => new()
        {
            "@hotmail.com",
            "@hotmail.se",
            "@hotmail.co.uk",
            "@live.com",
            "@live.se",
            "@gmail.com",
            "@facebook.com",
            "@mail.com",
            "@yahoo.com",
            "@aol.com",
            "@gmx.com",
            "@gmx.net",
            "@mac.com",
            "@outlook.com",
            "@msn.com",
            "@outlook.com",
            "@comcast.net",
            "@verizon.net"
        };
    }
}