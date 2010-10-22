using System.Net.Mail;

namespace SHHH.Net.Mail.Abstractions
{
    public class SmtpClientWrapper : SmtpClientBase
    {

        private SmtpClient Client{ get; set;}
        public SmtpClientWrapper() : this(new SmtpClient()) { }

        public SmtpClientWrapper(SmtpClient client)
        {
            Client = client;
        }

        public override System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates
        {
            get { return Client.ClientCertificates; }
        }

        public override System.Net.ICredentialsByHost Credentials
        {
            get { return Client.Credentials; }
            set { Client.Credentials = value; }
        }

        public override SmtpDeliveryMethod DeliveryMethod
        {
            get  { return Client.DeliveryMethod;  }
            set { Client.DeliveryMethod = value; }
        }

        public override bool EnableSsl
        {
            get { return Client.EnableSsl; }
            set { Client.EnableSsl = value; }
        }

        public override string Host
        {
            get { return Client.Host; }
            set { Client.Host = value; }
        }

        public override string PickupDirectoryLocation
        {
            get {  return Client.PickupDirectoryLocation; }
            set { Client.PickupDirectoryLocation = value; }
        }

        public override int Port
        {
            get { return Client.Port; }
            set { Client.Port = value; }
        }

        public override System.Net.ServicePoint ServicePoint
        {
            get { return Client.ServicePoint; }
        }

        public override string TargetName
        {
            get { return Client.TargetName; }
            set { Client.TargetName = value; }
        }

        public override int Timeout
        {
            get { return Client.Timeout; }
            set { Client.Timeout = value; }
        }

        public override bool UseDefaultCredentials
        {
            get { return Client.UseDefaultCredentials; }
            set { Client.UseDefaultCredentials = value; }
        }

        public override void Send(MailMessage message)
        {
            Client.Send(message);
        }

        public override void Send(string from, string recipients, string subject, string body)
        {
            Client.Send(from, recipients, subject, body);
        }

        public override void SendAsync(MailMessage message, object userToken)
        {
            Client.SendAsync(message, userToken);
        }

        public override void SendAsync(string from, string recipients, string subject, string body, object userToken)
        {
            Client.SendAsync(from, recipients, subject, body, userToken);
        }

        public override void SendAsyncCancel()
        {
            Client.SendAsyncCancel();
        }

        public override void Dispose()
        {
            Client.Dispose();
        }
    }
}
