using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Herança
{
    public interface IContaCorrenteRepositary : IBaseRepositary<ContaCorrente>
    {
        void TransferirPix(string chave);
        void CadastrarPix(string chave);
        void DeletarPix(string chave);
    }
}
