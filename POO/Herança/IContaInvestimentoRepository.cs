using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Herança
{
    public interface IContaInvestimentoRepository : IBaseRepositary<ContaInvestimento>
    {
        void RegastarTituloRendaFixa(ContaInvestimento contaInvestimento);
        void ComprarAcao(int id);
        void VenderAcao(int id);
        List<ContaInvestimento> ObterTodosOsInvestimentosPorData(DateTime dataInicio, DateTime dataFim);
    }
}
