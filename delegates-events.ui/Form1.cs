using delegates_events.common.Class;
using delegates_events.common.Events;
using delegates_events.implementationA.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace delegates_events.ui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EventManager.OnSolicitaSelecaoRecarga += ContinuaTransacaoSitef_OnSolicitaSelecaoRecarga;

            var sitef = new SitefClient();
            sitef.ContinuaTransacaoSitef();
        }

        private async Task<RecargaCelular> ContinuaTransacaoSitef_OnSolicitaSelecaoRecarga(List<RecargaCelular> arg)
        {
            label1.Text = (label1.Text + 1).ToString();
            frmRecarga frmRecarga = new frmRecarga(arg)
            {
                TopLevel = false
            };

            this.Controls.Clear();
            this.Controls.Add(frmRecarga);
            this.Controls.Add(label1);
            this.Width = frmRecarga.Width;
            this.Height = frmRecarga.Height;
            frmRecarga.Show();

            while (ReferenceEquals(frmRecarga.RecargaSelecionada, null))
            {
                await Task.Delay(100);
            }

            return frmRecarga.RecargaSelecionada;
        }
    }
}
