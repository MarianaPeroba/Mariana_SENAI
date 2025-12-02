namespace Jogo_da_Velha
{
    public partial class Form1 : Form
    {
        bool turno = true;
        int jogadas = 0;
        int pontos1 = 0;
        int pontos2 = 0;
        int empates = 0;
        string simboloJogador1 = "X";
        string simboloJogador2 = "O";
        private Button[] cells;
        private bool gameStarted = false;

        public Form1()
        {
            InitializeComponent();
        }
         
        private void InitializeCelss()
        {
            cells = new Button[] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9};
            foreach( var b in cells)
            {
                b.Enabled = false;
                b.Click += Botao_Click;
            }
        }

        private void rdbX_CheckedChanged(object sender, EventArgs e)
        {
            rdbX.Checked = true;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtJogador1.Text) || string.IsNullOrWhiteSpace(txtJogador2.Text))
            {
                MessageBox.Show("Digite os nomes dos jogadores!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            simboloJogador1 = rdbX.Checked ? "X" : "O";
            simboloJogador2 = rdbX.Checked ? "O" : "X";
            LimparBotoes();
            turno = true;
            jogadas = 0;


        }

        private void LimparBotoes()
        {
            foreach (Control c in Controls)
            {
                if (c is Button btn && btn.Name.StartsWith("btn") && btn.Name.Length == 4)
                {
                    btn.Text = "";
                }
            }
            jogadas = 0;
            turno = true;

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            pontos1 = 0;
            pontos2 = 0;
            empates = 0;
            AtualizarPlacar();
            LimparBotoes();

        }

        private void AtualizarPlacar()
        {
            lblPlacar1.Text = pontos1.ToString();
            lblPlacar2.Text = pontos2.ToString();
            lblEmpate.Text = empates.ToString();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void Botao_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;

            if (btn.Text == "")
            {
                btn.Text = turno ? simboloJogador1 : simboloJogador2;
                jogadas++;
                if (VerificarVencedor())
                {
                    if (turno)
                    {
                        pontos1++;
                        MessageBox.Show($"{txtJogador1.Text} venceu!", "Vitória");
                    }
                    else
                    {
                        pontos2++;
                        MessageBox.Show($"{txtJogador2.Text} venceu!", "Vitória");
                    }

                    AtualizarPlacar();
                    LimparBotoes();
                    return;
                }

                if (jogadas == 9)
                {
                    empates++;
                    MessageBox.Show("Empate!", "Fim de jogo");
                    AtualizarPlacar();
                    LimparBotoes();
                }

                turno = !turno;
            }


        }

        private bool VerificarVencedor()
        {
            if (ChecarBotoes(btn1, btn2, btn3)) return true;
            if (ChecarBotoes(btn4, btn5, btn6)) return true;
            if (ChecarBotoes(btn7, btn8, btn9)) return true;
            // Colunas
            if (ChecarBotoes(btn1, btn4, btn7)) return true;
            if (ChecarBotoes(btn2, btn5, btn8)) return true;
            if (ChecarBotoes(btn3, btn6, btn9)) return true;
            // Diagonais
            if (ChecarBotoes(btn1, btn5, btn9)) return true;
            if (ChecarBotoes(btn3, btn5, btn7)) return true;

            return false;

        }
        private bool ChecarBotoes(Button b1, Button b2, Button b3)
        {
            return b1.Text != "" && b1.Text == b2.Text && b2.Text == b3.Text;
        }

        private void rdbO_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
