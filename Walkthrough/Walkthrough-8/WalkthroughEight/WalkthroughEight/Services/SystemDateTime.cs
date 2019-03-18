using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WalkthroughEight.Interfaces;

namespace WalkthroughEight.Services
{
    public class SystemDateTime : IDateTime
    {
        public DateTime Now { get; }
    }
}
