using System.Collections.Generic;
using EPlayers_Asp.Models;

namespace EPlayers_Asp.Interfaces
{
    public interface IEquipe
    {
        void Create(Equipe e);
        List<Equipe> ReadAll();
        void Update(Equipe e);
        void Delete(int id);
    }
}