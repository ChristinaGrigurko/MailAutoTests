using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailAutoTests.helper
{
    class RandomNumeric
    {
        public static int getRandomNumber()
        {
            Random random = new Random();
            return random.Next(100, 1000);
        }
    }
}
