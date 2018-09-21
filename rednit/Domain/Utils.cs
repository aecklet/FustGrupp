using System;
using System.Threading;

namespace rednit.Domain
{
    class Utils
    {
        public HashCode GetID(string strInput)
        {
            Random rnd = new Random(strInput.GetHashCode());
            return rnd;
        }
    }
}
