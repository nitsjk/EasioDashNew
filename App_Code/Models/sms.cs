using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Net;
using System.IO;
using System.Text;
using Nits.Common;
using System.Data.SqlClient;
/// <summary>
/// Summary description for sms
/// </summary>
namespace Nits.SMS
{
    public class sms
    {
        public sms()
        {
            //
            // TODO: Add constructor logic here
            //
        }
       // String Constr = ConfigurationManager.ConnectionStrings["Constr"].ConnectionString.ToString();
        public void SendSMS(string fmobileno, string fmessage)
        {
            try
            {
                //String Url = "http://sms.kashmirclick.com/api/web2sms.php?workingkey=135264yb1xxxxxxxxxxxx&sender=<senderid>&to=<mobilenumber1,mobilenumber2,....>&message=<textmessage>";
                String UserName = "";
                String Password = "";
                //SqlDataReader dr = SqlHelper.ExecuteReader(Constr, CommandType.StoredProcedure, "GetSMSGatewayDetails");
                //if (dr.HasRows)
                //{
                //    while (dr.Read())
                //    {
                //        Url = dr["SMSGatewayUrl"].ToString();
                //        UserName = dr["User"].ToString();
                //        Password = dr["Password"].ToString();
                //    }
                //}
                int Status = 0;
                string StatusMessage = "";
                string str = "";
                string pushURL = "";//"http://push1.maccesssmspush.com/servlet/com.aclwireless.pushconnectivity.listeners.TextListener?userId=idacent&pass=paacent&msgtype=1&contenttype=1&selfid=true&to=@mobileno&from=GrpConcorde&dlrreq=true&text=@message&alert=1";
                ////pushURL = @"url?user=userName&password=Password&sender=SenderName&sendercdma=919860609000&text=This+is+a+sample+sms&PhoneNumber=919822012345,919370119223&track=1";
                //pushURL = @"http://sms.smsportal.in/pushsms.php?username=tanvir&password=your_password&sender=mysenderid&cdmasender=mycdmasenderid&to=myrecipient&message=Hello";
                //pushURL = @"@url?username=@userName&password=@Password&dlr=1&mobile=@mobileno&sender=@SenderName&message=@message";
                //pushURL = @"http://sms.kashmirclick.com/api/web2sms.php?workingkey=http://sms.kashmirclick.com/api/web2sms.php&sender=KCLICK&to=@mobileno&message=@message";
                //pushURL = @"http://sms.kashmirclick.com/api/web2sms.php?workingkey=13526q5n2dm0nqk792135&sender=KCLICK&to=@mobileno&message=@message";
               // pushURL = @"http://sms.nationalitsolutions.com/api/web2sms.php?workingkey=14601a9t88g611087s25j&sender=RPSALC&to=@mobileno&message=@message";
                pushURL = @"http://103.247.98.91/API/SendMsg.aspx?uname=20190028&pass=admin123&send=WELKIN&dest=@mobileno&msg=@message";
                //--pushURL = @"http://softsms.in/app/smsapi/index.php?key=562e1e8ae3238&type=text&contacts=@mobileno&senderid=RPSALC&msg=@message";
              
                 //pushURL = @"http://103.247.98.91/API/SendMsg.aspx?uname=20142948&pass=admin123&send=RPSALC&dest=@mobileno&msg=@message";
                //http://sms.nationalitsolutions.com/api/web2sms.php?workingkey=14601a9t8xxxxxxxxxxxx&sender=<senderid>&to=<mobilenumber1,mobilenumber2,....>&message=<textmessage>
                //pushURL = pushURL.Replace("@url", Url);
                //pushURL = pushURL.Replace("@userName", UserName);
                //pushURL = pushURL.Replace("@Password", Password);
                //pushURL = pushURL.Replace("@SenderName", "CMS");
                //pushURL = pushURL.Replace("@message", fmessage);
                //pushURL = pushURL.Replace("@mobileno", fmobileno);
                ////*********************
                //pushURL = pushURL.Replace("@url", Url);
                // pushURL = pushURL.Replace("@userName", UserName);
                // pushURL = pushURL.Replace("@Password", Password);
                // pushURL = pushURL.Replace("@SenderName", "CMS");
                pushURL = pushURL.Replace("@message", fmessage);
                pushURL = pushURL.Replace("@mobileno", fmobileno);
                // Get HTML data
                WebClient client = new WebClient();
                Stream data = client.OpenRead(pushURL);
                StreamReader reader = new StreamReader(data);
                str = reader.ReadToEnd();
                data.Close();
                if (str.StartsWith("0,"))
                    Status = 0;
                else
                    Status = 1;
                StatusMessage = str;
                str = StatusMessage.Substring(StatusMessage.IndexOf("Sent") + "Sent".Length + 1).Trim();
            }
            catch (Exception eee)
            {

            }
        }
    }
}