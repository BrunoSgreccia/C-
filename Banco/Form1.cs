using System;
using System.Windows.Forms;
using Banco.Contas;

namespace Banco
{
    public partial class Form1 : Form
    {
        
        
        private int numeroDeContas;
        public Conta[] contas;
        

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {


            /* c = new Conta();
             c.numero = 1;
             Cliente cliente = new Cliente("Lucas");
             c.Titutar = cliente;

             textTitular.Text = c.Titutar.Nome;
             textNumero.Text = Convert.ToString(c.numero);
             textSaldo.Text = Convert.ToString(c.saldo);
            
            c1 = new ContaPoupanca();
             c1.numero = 2;
             Cliente clientep = new Cliente("Saulo");
             c1.Titutar = clientep;

             textTitular.Text = c1.Titutar.Nome;
             textNumero.Text = Convert.ToString(c1.numero);
             textSaldo.Text = Convert.ToString(c1.saldo);
             */
            contas = new Conta[1000];
       
            Conta c1 = new Conta();
            c1.Titutar = new Cliente("Lucas");
            c1.numero = 1;
            this.AdicionaConta(c1);

            Conta c2 = new Conta();
            c2.Titutar = new Cliente("Roberto");
            c2.numero = 1;
            this.AdicionaConta(c2);

            Conta c3 = new Conta();
            c3.Titutar = new Cliente("Pablo");
            c3.numero = 1;
            this.AdicionaConta(c3);

            
            

        }

        private void btnDeposita_Click(object sender, EventArgs e)
        {
            int indice = ComboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            string valorDigitado = textValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            selecionada.Deposita(valorOperacao);
            textSaldo.Text = Convert.ToString(selecionada.saldo);

           /* string valorDigitado = textValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            c1.Deposita(valorOperacao);
            textSaldo.Text = Convert.ToString(this.c1.saldo);
            */
           MessageBox.Show("Deposito feito com sucesso");
        }

        private void btnSaca_Click(object sender, EventArgs e)
        {
            int indice = ComboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            string valorDigitado = textValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            selecionada.Saca(valorOperacao);
            textSaldo.Text = Convert.ToString(selecionada.saldo);
            /*string valorDigitado = textValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            c1.Saca(valorOperacao);
            textSaldo.Text = Convert.ToString(this.c1.saldo);*/
            MessageBox.Show("Saque feito com sucesso");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int indice = ComboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            textNumero.Text = Convert.ToString(selecionada.numero);
            textTitular.Text = Convert.ToString(selecionada.Titutar.Nome);
            textSaldo.Text = Convert.ToString(selecionada.saldo);
        }

        private void ComboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = ComboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            textTitular.Text = selecionada.Titutar.Nome;
            textNumero.Text = Convert.ToString(selecionada.numero);
            textSaldo.Text = Convert.ToString(selecionada.saldo);

        }

        private void comboDestinoTransferencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TransferContas_Click(object sender, EventArgs e)
        {
            int indice = ComboContas.SelectedIndex;
            Conta origem = this.contas[indice];
            indice = comboDestinoTransferencia.SelectedIndex;
            Conta Destino = Origem(indice);
            string valorDigitado = textValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            origem.Saca(valorOperacao);
            Destino.Deposita(valorOperacao);
            textTitular2.Text = Destino.Titutar.Nome;
            textBox2.Text = Convert.ToString(Destino.numero);
            textBox3.Text = Convert.ToString(Destino.saldo);

        }

        private Conta Origem(int indice)
        {
            return this.contas[indice];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioDecadastro = new FormCadastroConta(this);
            formularioDecadastro.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void AdicionaConta(Conta conta)
        {
            this.contas[this.numeroDeContas] = conta;
            this.numeroDeContas++;
            ComboContas.Items.Add("Titular: " + conta.Titutar.Nome);
            comboDestinoTransferencia.Items.Add("Titular: " + conta.Titutar.Nome);
                }
    }
}
