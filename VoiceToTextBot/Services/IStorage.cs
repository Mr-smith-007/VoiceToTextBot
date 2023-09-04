using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoiceToTextBot.Models;

namespace VoiceToTextBot.Services
{
    public interface IStorage
    {
        Session GetSession(long chatId);
    }
}
