using delegates_events.common.Class;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace delegates_events.ui
{
    public partial class frmRecarga : Form
    {
        public RecargaCelular RecargaSelecionada { get; set; }

        private readonly List<RecargaCelular> _dadosRecarga;

        public frmRecarga(List<RecargaCelular> dadosRecarga)
        {
            InitializeComponent();
            _dadosRecarga = dadosRecarga;
        }

        private void FrmRecarga_Load(object sender, System.EventArgs e)
        {
            listBox1.DataSource = _dadosRecarga;
            listBox1.DisplayMember = "Descricao";
        }

        private void ListBox1_DoubleClick(object sender, System.EventArgs e)
        {
            RecargaSelecionada = (RecargaCelular)listBox1.SelectedItem;
        }
    }
}
