using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeadsSMSPro;
using KamplapurSMSExpress;

namespace AdapterPattern
{
    class SMSCore : ISMS
    {

        private string message;
        public string ComposeSMS()
        {
            var oSMS = new SMSExpress();
            message = oSMS.SMSCreation();
            return message;



        }

        public string SendSMS()
        {
            var oSMS = new SMSExpress();
            message = oSMS.SMSSend();
            return message;
        }
    }
}
