using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class Year
{

    internal static bool IsLeap(int p)
    {
        bool isLeap = false;

        if (p % 4 == 0) {
            if (!(p % 100 == 0))
            {
                isLeap = true;
            }
            else 
            {
                if (p % 400 == 0)
                {
                    isLeap = true;        
                }
            }
        }

        return isLeap;
    }
}
