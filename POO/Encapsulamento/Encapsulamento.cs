using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Encapsulamento
{
     public class Encapsulamento
    {
        private int Login { get; set; }
        public string Nome { get; set; }
        public decimal Senha { get; private set; }
    }
    
    
    public class TentandoEncapsulamento
    {
        Encapsulamento dados = new Encapsulamento()
        {
            Nome = "Tristana",
        };
         

    }
}
