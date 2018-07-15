using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worldexalted.PrivateClass
{
    class uAttribute
    {
        String mName = "";
        int mLevelDot = 0;

        public void addOneDot()
        {
            mLevelDot += 1;
        }
        public void removeOneDot()
        {
            mLevelDot -= 1;
        }
        public void addDot( int nbDot)
        {
            mLevelDot += nbDot;
        }
        public void removeDot(int nbDot)
        {
            mLevelDot -= nbDot;
        }
    }

}
