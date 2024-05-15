using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace avaliacao2703.ViewModels
{
    internal class DadoViewModel
    {
        [ObservableProperty]
        private int quantidadeDeLados;

        [ObservableProperty]
        private int numeroSorteado;
    }
}
