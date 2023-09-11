using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model
{
    public abstract class Mobilia
    {
        private int id, tipo;
        private string nome;
        private decimal preco;

        public Mobilia(int id, string nome, decimal preco)
        {
            this.id = id;
            this.nome = nome;
            this.preco = preco;
        }

        public Mobilia() { }

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public decimal GetPreco()
        {
            return preco;
        }

        public void SetPreco(decimal preco)
        {
            this.preco = preco;
        }

        public virtual void Visualizar()
        {
            string tipo = "";

            switch (this.tipo)
            {
                case 1:
                    tipo = "Sofá";
                    break;
                case 2:
                    tipo = "Armário";
                    break;
            }

            Console.WriteLine("**************************************************");
            Console.WriteLine("Dados do Mobília");
            Console.WriteLine("**************************************************");
            Console.WriteLine($"Id do Mobília: {this.id}");
            Console.WriteLine($"Tipo do Mobília: {tipo}"); 
            Console.WriteLine($"Nome do Mobília: {this.nome}");
            Console.WriteLine($"Preço do Mobília: {(this.preco).ToString("C")}");
        }
    }
}