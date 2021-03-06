using Microsoft.AspNetCore.Http;
using MimeKit;

namespace TutorHelper_v2.Business.Helper.EmailHelper;

public abstract class Message
{
    protected Message(IEnumerable<string> to, string subject, string context, IFormFileCollection attachments)
    {
        To = new List<MailboxAddress>();

        To.AddRange(to.Select(x => new MailboxAddress("", x)));

        Subject = subject;
        Content = context;
        Attachments = attachments;
    }

    public List<MailboxAddress> To { get; set; }
    public string Subject { get; set; }
    public string Content { get; set; }
    public IFormFileCollection Attachments { get; set; }
}