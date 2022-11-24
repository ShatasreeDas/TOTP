using OtpNet;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static TOTP.Totp;
//using OtpNet;
namespace TOTP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bytes = Base32Encoding.ToBytes("JBSWY3DPEHPK3PXP");


            //var totp = new Totp(bytes);
            var totps = new Totp(bytes);

            var totp = new Totp(bytes, mode: OtpHashMode.Sha512);

            var result = totp.ComputeTotp();
            var remainingTime = totp.RemainingSeconds();
            long mathctime = remainingTime;
            VerificationWindow verificationWindow = new VerificationWindow();// null;
            verificationWindow.ValidationCandidates(2);
            bool otptest = totp.VerifyTotp(result, out mathctime);

            //public bool VerifyTotp(string totp, out long timeWindowUsed, VerificationWindow window = null);
            //public bool VerifyTotp(DateTime timestamp, string totp, out long timeWindowUsed, VerificationWindow window = null)
        }
    }
}
