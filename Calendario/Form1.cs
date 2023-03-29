using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPegarData_Click(object sender, EventArgs e)
        {
            textBoxDataInicial.Text = monthCalendar1.SelectionStart.ToShortDateString();
            textBoxDataFinal.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            textBoxDataAtual.Text = monthCalendar1.TodayDate.ToShortDateString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBoxDataInicial.Clear();
            textBoxDataFinal.Clear();
            textBoxDataAtual.Clear();

            textBoxAutoInicial.Clear();
            textBoxAutoFinal.Clear();
            textBoxAutoAtual.Clear();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBoxAutoInicial.Text = monthCalendar1.SelectionStart.ToShortDateString();
            textBoxAutoFinal.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            textBoxAutoAtual.Text = monthCalendar1.TodayDate.ToShortDateString();
        }

        private void MenuNotificacoes_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.ToString() == "Fechar")
            {
                this.Close();
            }
            else if (e.ClickedItem.Name.ToString() == "Restaurar")
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (e.ClickedItem.Name.ToString() == "Mensagem")
            {
                MessageBox.Show("Você está lendo essa mensagem!!!");
            }
        }
    }
}
