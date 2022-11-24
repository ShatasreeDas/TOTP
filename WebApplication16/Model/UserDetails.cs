namespace WebApplication16.Model
{
    public class UserDetails
    {
       public string EmailId { get; set; }
    }
    public class response
    {
        public string GenarateOTP { get; set; }
       // public bool otptest { get; set; }
       public string StatusCode { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
    }
    public class Validresponse
    {
        
        public bool otptest { get; internal set; }
        public string StatusCode { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
    }
}


