using System.Collections.Generic;
using PlayCade.Common.Models;

namespace PlayCade.Common.Interfaces
{
    public interface ICore
    {
        void Run(byte[] rom);
        MetaData MetaData();
    }
}