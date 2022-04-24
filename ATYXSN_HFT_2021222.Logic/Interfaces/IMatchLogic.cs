﻿using ATYXSN_HFT_2021222.Models;
using System.Linq;

namespace ATYXSN_HFT_2021222.Logic
{
    public interface IMatchLogic
    {
        void Create(Match item);
        void Delete(int id);
        Match Read(int id);
        IQueryable<Match> ReadAll();
        void Update(Match item);
    }
}