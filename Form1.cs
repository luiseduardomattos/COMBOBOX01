using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMBOBOX01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(cmbEscolha.SelectedItem))
            {
                    case 1:
                    lblMensagem.Text = "O mês 1 é equivalente a Janeiro";
                    break;

                    case 2:
                    lblMensagem.Text = "O mês 2 é equivalente a Fevereiro";
                    break;

                    case 3:
                    lblMensagem.Text = "O mês 3 é equivalente a Março";
                    break;

                    case 4:
                    lblMensagem.Text = "O mês 4 é equivalente a Abril";
                    break;

                    case 5:
                    lblMensagem.Text = " O mês 5 é equivalente a Maio";
                    break;

                    case 6:
                    lblMensagem.Text = "O mês 6 é equivalente a Junho";
                    break;

                    case 7:
                    lblMensagem.Text = "O mês 7 é equivalente a julho";
                    break;

                    case 8:
                    lblMensagem.Text = "O mês 8 é equivalente a Agosto";
                    break;

                    case 9:
                    lblMensagem.Text = "O mês 9 é equivalente a Setembro";
                    break;

                    case 10:
                    lblMensagem.Text = "O mês 10 é equivalente a Outubro";
                    break;

                    case 11:
                    lblMensagem.Text = "O mês 11 é equivalente a Novembro";
                    break;

                    case 12:
                    lblMensagem.Text = "O mês   " + cmbEscolha+ " é equivalente a Dezembro";
                    break;

                default:
                    lblMensagem.Text = "Por favor escolha uma opção de números; Mês não encontrado";
                    break;
            }
        }
    }
}
