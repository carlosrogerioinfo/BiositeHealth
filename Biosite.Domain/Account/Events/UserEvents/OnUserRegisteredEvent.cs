using DomainNotificationHelper.Events.Contracts;
using Biosite.Domain.Account.Entities;
using Biosite.SharedKernel.Resources;
using System;

namespace Biosite.Domain.Account.Events.UserEvents
{
    public class OnUserRegisteredEvent : IDomainEvent
    {
        public OnUserRegisteredEvent(User user)
        {
            Date = DateTime.Now;
            User = user;
            EmailTitle = EmailTemplates.WelcomeEmailTitle;
            EmailBody = EmailTemplates.WelcomeEmailBody;
        }

        public User User { get; private set; }
        public string EmailTitle { get; private set; }
        public string EmailBody { get; private set; }
        public DateTime Date { get; set; }
    }
}
