using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace LearnTwilio
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var accountSid = Secrets.accountSid;
            var authToken = Secrets.authToken;
            var toNumber = Secrets.toNumber;
            var fromNumber = Secrets.fromNumber;

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                to: new PhoneNumber(toNumber),
                from: new PhoneNumber(fromNumber),
                body:"Hi This is Manvish, hope you are having a good day!<3"
                

            );
           
        }
    }
}