using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTracking
{
    internal class General
    {
        public static bool IsNumber(KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
