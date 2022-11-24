using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using static TOTP.Totp;
using OtpNet;
using WebApplication16.Model;
//namespace TOTP
namespace WebApplication16
{
    public class OTP
    {

        public string GenarateOTP()
        {
            var bytes = Base32Encoding.ToBytes("JBSWY3DPEHPK3PXPLKLKL");


            //var totp = new Totp(bytes);
            // var totps = new Totp(bytes);

            var totp = new Totp(bytes, mode: OtpHashMode.Sha512, step: 60 ,totpSize: 6);

            var GenarateOTP = totp.ComputeTotp();
            var remainingTime = totp.RemainingSeconds();
            return GenarateOTP;
            


        }
        public bool ValidOTP(string OTP)
        {
            var bytes = Base32Encoding.ToBytes("JBSWY3DPEHPK3PXPLKLKL");
            var totp = new Totp(bytes, mode: OtpHashMode.Sha512, step: 60, totpSize: 6);
            var GenarateOTP = totp.ComputeTotp();

            //{

            //    //long mathctime = remainingTime;
            //VerificationWindow verificationWindow = new VerificationWindow();// null;
            //    verificationWindow.ValidationCandidates(2);
            bool otptest = totp.VerifyTotp(OTP, out long mathctime);

            //public bool VerifyTotp(string totp, out long timeWindowUsed, VerificationWindow window = null);
            //public bool VerifyTotp(DateTime timestamp, string totp, out long timeWindowUsed, VerificationWindow window = null)
            // return result;
           
            return otptest;
        }
       
    }

}
        
    

