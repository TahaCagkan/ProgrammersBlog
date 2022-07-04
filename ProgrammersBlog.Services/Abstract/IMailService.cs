using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgrammersBlog.Entities.Dtos;
using ProgrammersBlog.Shared.Utilities.Results.Abstract;

namespace ProgrammersBlog.Services.Abstract
{
    public interface IMailService
    {
        IResult Send(EmailSendDto emailSendDto); // taha@mail.dev
        IResult SendContactEmail(EmailSendDto emailSendDto); //  taha@mail.dev info@programmersblog.com iletisim@programmersblog.com
    }
}
