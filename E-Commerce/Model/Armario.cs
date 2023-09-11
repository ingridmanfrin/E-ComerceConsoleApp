using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model
{
    public class Armario : Mobilia
    {
        private int quantidadePortas;

        public Armario(int id, int tipo, string nome, decimal preco, int quantidadePortas) : base(id, tipo, nome, preco)
        {
            this.quantidadePortas = quantidadePortas;
        }

        public int GetQuantidadePortas() 
        { 
            return quantidadePortas; 
        }

        public void SetQuantidadePortas(int quantidadePortas)
        {
            this.quantidadePortas = quantidadePortas;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Quantidade de Portas do Armário: {this.quantidadePortas}");
        }
    }
}
