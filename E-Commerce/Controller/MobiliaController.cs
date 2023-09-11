using E_Commerce.Model;
using E_Commerce.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Controller
{
    public class MobiliaController : IMobiliaRepository
    {
        private readonly List<Mobilia> listaMobilia = new();
        int id = 0;

        public void AtualizarMobilia(Mobilia mobilia)
        {
            var buscaProduto = BuscarNaCollection(mobilia.GetId());
            if (buscaProduto != null)
            {
                var index = listaMobilia.IndexOf(buscaProduto);
                listaMobilia[index] = mobilia;
                Console.WriteLine($"A Mobília de código {mobilia.GetId()} foi atualizada com sucesso!");
            }
            else
            {
                Console.WriteLine($"A Mobília  de código {mobilia.GetId()} não foi encontrada!");
            }
        }

        public void ConsultarMobiliaPorId(int id)
        {
            var mobilia = BuscarNaCollection(id);

            if (mobilia is not null)
            {
                mobilia.Visualizar();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A Mobília de código {id} não foi encontrada!");
                Console.ResetColor();
            }
        }

        public void CriarMobilia(Mobilia mobilia)
        {
            listaMobilia.Add(mobilia);
            Console.WriteLine($"A Mobília de código {mobilia.GetId()} foi criada com sucesso!");
        }

        public void DeletarMobilia(int id)
        {
            var mobilia = BuscarNaCollection(id);

            if (mobilia != null)
            {
                if (listaMobilia.Remove(mobilia) == true)
                {
                    Console.WriteLine($"A Mobília de código {id} foi apagada com sucesso!");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A Mobília de código {id} não foi encontrada!");
                Console.ResetColor();
            }
        }

        public void ListarMobilias()
        {
            foreach (var mobilia in listaMobilia)
            {
                mobilia.Visualizar();
            }
        }
        
        public int GerarId()
        {
            return ++id;
        }

        public Mobilia? BuscarNaCollection(int id)
        {
            foreach (var mobilia in listaMobilia)
            {
                if (mobilia.GetId() == id)
                {
                    return mobilia;
                }
            }
            return null;
        }
    }
}
