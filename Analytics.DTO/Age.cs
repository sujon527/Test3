using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analytics.DTO
{
    public class Age
    {
        public int LessThanTwenty { get; set; }
        public int TwentyToThirty { get; set; }
        public int ThirtyToFourty { get; set; }
        public int FourtyToFifty { get; set; }
        public int Others { get; set; }
    }
}
