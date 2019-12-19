using System.Collections.Generic;
using PlayCade.Common.Models;

namespace PlayCade.Common.Interfaces
{
    public interface Core
    {
        void Run(string rom);
        MetaData MetaData();
    }
}