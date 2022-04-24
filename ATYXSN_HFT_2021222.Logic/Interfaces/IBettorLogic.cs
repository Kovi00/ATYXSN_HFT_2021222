﻿using ATYXSN_HFT_2021222.Models;
using System.Linq;

namespace ATYXSN_HFT_2021222.Logic
{
    public interface IBettorLogic
    {
        void Create(Bettor item);
        void Delete(int id);
        Bettor Read(int id);
        IQueryable<Bettor> ReadAll();
        void Update(Bettor item);
    }
}