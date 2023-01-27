using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyBogus
{
    /*
     *  Autogenerate random emails
     */
    
    public class MyBogus
    {
        public static async Task<IList<string>> RandomEmailAddress(int count, int length)
        {
            // Initialize our list to type string
            var lst = new Data<string>().List;

            // Create our random object
            var rnd = new Random();

            // Get list of characters
            var chr = Data<string>.Characters;

            // Get domain names
            var dmn = Data<List<string>>.Domains();

            // Build up the list of email addresses
            for (var i = 0; i < count; i++)
            {
                lst.Add(
                    // Add random data before the @
                    new string(Enumerable.Repeat(chr, length).Select(s => s[rnd.Next(s.Length)]).ToArray()) +

                    // Add random domain names
                    dmn[rnd.Next(dmn.Count)]);
            }

            return await Task.FromResult(lst);
        }
    }
}