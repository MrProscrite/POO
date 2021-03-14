using System.Collections.Generic;

namespace POO.Herança
{
    public interface IBaseRepositary<Tentity>
    {
        void Save(Tentity tentity);
        void Update(int id);
        void Delete(int id);
        List<Tentity> ObterTodos();
    }
}
