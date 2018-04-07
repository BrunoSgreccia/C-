using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco.Contas;


namespace Banco
{
    public partial class FormCadastroConta : Form
        
    {
        private Form1 formPrincipal;
        
        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
            comboTipoDeConta.Items.Add("Conta Corrente");
            comboTipoDeConta.Items.Add("Conta Poupanca");
        }

        
        

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            Conta NovaConta = null;
           if (comboTipoDeConta.SelectedIndex == 0)
            {
                 NovaConta = new ContaCorrente();
            
            }
           else { NovaConta = new ContaPoupanca(); }
             
            NovaConta.Titutar = new Cliente(textBox2.Text);
            NovaConta.numero = Convert.ToInt32(textBox1.Text);

            this.formPrincipal.AdicionaConta(NovaConta);
            Close();
        }

        private void comboTipoDeConta_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
