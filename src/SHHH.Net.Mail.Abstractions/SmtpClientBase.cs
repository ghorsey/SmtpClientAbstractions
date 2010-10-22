using System;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;

namespace SHHH.Net.Mail.Abstractions
{
    public abstract class SmtpClientBase :IDisposable
    {
        #region Properties
        public abstract X509CertificateCollection ClientCertificates { get; }
        public abstract ICredentialsByHost Credentials { get; set; }
        public abstract SmtpDeliveryMethod DeliveryMethod { get; set; }
        public abstract bool EnableSsl { get; set; }
        public abstract string Host { get; set; }
        public abstract string PickupDirectoryLocation { get; set; }
        public abstract int Port { get; set; }
        public abstract ServicePoint ServicePoint { get; }
        public abstract string TargetName { get; set; }
        public abstract int Timeout { get; set; }
        public abstract bool UseDefaultCredentials { get; set; }
        #endregion


        #region Methods
        public abstract void Send(MailMessage message);
        public abstract void Send(string from, string recipients, string subject, string body);

        [HostProtectionAttribute(SecurityAction.LinkDemand, ExternalThreading = true)]
        public abstract void SendAsync(MailMessage message, Object userToken);

        [HostProtectionAttribute(SecurityAction.LinkDemand, ExternalThreading = true)]
        public abstract void SendAsync(string from, string recipients, string subject, string body, Object userToken);

        public abstract void SendAsyncCancel();
        #endregion

        #region IDisposable Members
        public abstract void Dispose();
        #endregion
    }
}
