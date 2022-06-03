using PayRoll.CrossCutting.Common.Models;
using System.Threading.Tasks;

namespace PayRoll.CrossCutting.Common.Interfaces
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
