using delegates_events.common.Class;
using delegates_events.common.Events;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace delegates_events.implementationA.Class
{
    public class ContinuaTransacaoSitef
    {
        public async void Recarga()
        {
            var dadosRecarga = new List<RecargaCelular>
            {
                new RecargaCelular { Codigo = 1, Descricao = "Recarga celular"},
                new RecargaCelular { Codigo = 2, Descricao = "Recarga celular pela administradora"}
            };

            var selecionado = await EventManager.SolicitaRecargaCelular(dadosRecarga); //OnSolicitaSelecaoRecarga(dadosRecarga);
            Console.WriteLine(selecionado.Descricao);

            dadosRecarga = new List<RecargaCelular>
            {
                new RecargaCelular { Codigo = 1, Descricao = "Claro"},
                new RecargaCelular { Codigo = 2, Descricao = "Tim"}
            };

            var selecionado2 = await EventManager.SolicitaRecargaCelular(dadosRecarga); //OnSolicitaSelecaoRecarga(dadosRecarga);
            Console.WriteLine(selecionado2.Descricao);
        }
    }
}
