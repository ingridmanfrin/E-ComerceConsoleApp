using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model
{
    public class Sofa : Mobilia
    {
        private int quantidadeLugares;

        public Sofa(int id, int tipo, string nome, decimal preco, int quantidadeLugares) : base(id, tipo, nome, preco)
        {
            this.quantidadeLugares = quantidadeLugares;
        }

        public int GetQuantidadeLugares()
        {
            return this.quantidadeLugares;
        }

        public void SetQuantidadeLugares(int quantidadeLugares)
        {
            this.quantidadeLugares = quantidadeLugares;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Quantidade de lugares do Sofá: {this.quantidadeLugares}");
        }
    }
     
}
