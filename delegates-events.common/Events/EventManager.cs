using delegates_events.common.Class;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace delegates_events.common.Events
{
    public static class EventManager
    {
        public static event Func<List<RecargaCelular>, Task<RecargaCelular>> OnSolicitaSelecaoRecarga;

        public static async Task<RecargaCelular> SolicitaRecargaCelular(List<RecargaCelular> dadosRecarga)
        {
            return await OnSolicitaSelecaoRecarga?.Invoke(dadosRecarga);
        }
    }
}
