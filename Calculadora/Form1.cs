namespace Calculadora
{
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }

        public decimal Valor { get; set; }

        private Operacao OperacaoSelecionada { get; set; }

        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void btn0_Click(object sender, EventArgs e)
        {
            visorResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            visorResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            visorResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            visorResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            visorResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            visorResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            visorResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            visorResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            visorResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            visorResultado.Text += "9";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(visorResultado.Text);
            visorResultado.Text = "";
            label1.Text = "/";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(visorResultado.Text);
            visorResultado.Text = "";
            label1.Text = "*";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(visorResultado.Text);
            visorResultado.Text = "";
            label1.Text = "-";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(visorResultado.Text);
            visorResultado.Text = "";
            label1.Text = "+";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(visorResultado.Text);
                    ;
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(visorResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(visorResultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(visorResultado.Text);
                    break;
            }
            visorResultado.Text = Convert.ToString(Resultado);
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!visorResultado.Text.Contains(","))
                visorResultado.Text += ",";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            visorResultado.Text = "";
            label1.Text = "";
        }
    }
}
