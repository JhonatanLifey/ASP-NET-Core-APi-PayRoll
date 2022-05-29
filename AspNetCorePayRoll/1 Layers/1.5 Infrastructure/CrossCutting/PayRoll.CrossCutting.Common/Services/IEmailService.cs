using PayRoll.CrossCutting.Common.Models;
using System.Threading.Tasks;

namespace PayRoll.CrossCutting.Common.Services
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
