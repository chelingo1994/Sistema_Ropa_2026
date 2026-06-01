using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CapaRN
{
    public static class xgeneral
    {
        public static bool emailIsValid(String emaialAddress)
        {
            try
            {
                MailAddress email = new MailAddress(emaialAddress);
                return true;
            }
            catch (FormatException e) { 
                return false;
            }
        }
    }
}
