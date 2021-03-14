using System;
using System.Collections.Generic;

namespace POO.Herança
{
    class ContaInvestimentoRepository : IContaInvestimentoRepository
    {
        public void ComprarAcao(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContaInvestimento> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public List<ContaInvestimento> ObterTodosOsInvestimentosPorData(DateTime dataInicio, DateTime dataFim)
        {
            throw new NotImplementedException();
        }

        public void RegastarTituloRendaFixa(ContaInvestimento contaInvestimento)
        {
            throw new NotImplementedException();
        }

        public void Save(ContaInvestimento tentity)
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }

        public void VenderAcao(int id)
        {
            throw new NotImplementedException();
        }
    }
}
