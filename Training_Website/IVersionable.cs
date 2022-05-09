using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Website
{
    public interface IVersionable
    {
        public void AddVersion()
        {
            int[] version = new int[8];
            version[7] = 1;
        }
        public void UpdateVersion()
        {

        }
    }
}
