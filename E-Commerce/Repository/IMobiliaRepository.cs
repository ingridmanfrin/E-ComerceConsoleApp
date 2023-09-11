using E_Commerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Repository
{
    public interface IMobiliaRepository
    {
        public void CriarMobilia(Mobilia mobilia);
        public void ListarMobilia();
        public void ConsultarMobiliaPorId(int id);
        public void AtualizarMobilia(Mobilia mobilia);
        public void DeletarMobilia(int id);
    }
}
