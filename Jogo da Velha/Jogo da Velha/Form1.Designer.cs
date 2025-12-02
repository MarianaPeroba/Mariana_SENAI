namespace Jogo_da_Velha
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtJogador2 = new TextBox();
            txtJogador1 = new TextBox();
            panel1 = new Panel();
            btnReiniciar = new Button();
            btnSair = new Button();
            btnIniciar = new Button();
            groupBox4 = new GroupBox();
            rdbO = new RadioButton();
            rdbX = new RadioButton();
            groupBox2 = new GroupBox();
            lblPlacar1 = new Label();
            lblPlacar2 = new Label();
            groupBox3 = new GroupBox();
            lblEmpate = new Label();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtJogador2);
            groupBox1.Controls.Add(txtJogador1);
            groupBox1.Font = new Font("BankGothic Md BT", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 92);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Jogadores";
            // 
            // txtJogador2
            // 
            txtJogador2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            txtJogador2.Location = new Point(10, 63);
            txtJogador2.Multiline = true;
            txtJogador2.Name = "txtJogador2";
            txtJogador2.Size = new Size(184, 23);
            txtJogador2.TabIndex = 1;
            // 
            // txtJogador1
            // 
            txtJogador1.Font = new Font("Verdana", 12F, FontStyle.Bold);
            txtJogador1.Location = new Point(10, 35);
            txtJogador1.Multiline = true;
            txtJogador1.Name = "txtJogador1";
            txtJogador1.Size = new Size(184, 22);
            txtJogador1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Controls.Add(btnReiniciar);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnIniciar);
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 179);
            panel1.TabIndex = 1;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Font = new Font("BankGothic Md BT", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReiniciar.ForeColor = Color.LightSeaGreen;
            btnReiniciar.Location = new Point(368, 140);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(90, 31);
            btnReiniciar.TabIndex = 5;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("BankGothic Md BT", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.LightSeaGreen;
            btnSair.Location = new Point(464, 140);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(86, 31);
            btnSair.TabIndex = 4;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Font = new Font("BankGothic Md BT", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.ForeColor = Color.LightSeaGreen;
            btnIniciar.Location = new Point(277, 140);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(85, 31);
            btnIniciar.TabIndex = 3;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(rdbO);
            groupBox4.Controls.Add(rdbX);
            groupBox4.Font = new Font("BankGothic Md BT", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = SystemColors.ButtonFace;
            groupBox4.Location = new Point(3, 101);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(146, 66);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Opções";
            // 
            // rdbO
            // 
            rdbO.AutoSize = true;
            rdbO.Location = new Point(74, 28);
            rdbO.Name = "rdbO";
            rdbO.Size = new Size(55, 32);
            rdbO.TabIndex = 1;
            rdbO.TabStop = true;
            rdbO.Text = "O";
            rdbO.UseVisualStyleBackColor = true;
            rdbO.CheckedChanged += rdbO_CheckedChanged;
            // 
            // rdbX
            // 
            rdbX.AutoSize = true;
            rdbX.Location = new Point(18, 28);
            rdbX.Name = "rdbX";
            rdbX.Size = new Size(50, 32);
            rdbX.TabIndex = 0;
            rdbX.TabStop = true;
            rdbX.Text = "X";
            rdbX.UseVisualStyleBackColor = true;
            rdbX.CheckedChanged += rdbX_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblPlacar1);
            groupBox2.Controls.Add(lblPlacar2);
            groupBox2.Font = new Font("BankGothic Md BT", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ButtonFace;
            groupBox2.Location = new Point(209, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 92);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Placar";
            // 
            // lblPlacar1
            // 
            lblPlacar1.AutoSize = true;
            lblPlacar1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlacar1.Location = new Point(6, 35);
            lblPlacar1.Name = "lblPlacar1";
            lblPlacar1.Size = new Size(0, 18);
            lblPlacar1.TabIndex = 2;
            // 
            // lblPlacar2
            // 
            lblPlacar2.AutoSize = true;
            lblPlacar2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlacar2.Location = new Point(6, 63);
            lblPlacar2.Name = "lblPlacar2";
            lblPlacar2.Size = new Size(0, 18);
            lblPlacar2.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblEmpate);
            groupBox3.Font = new Font("BankGothic Md BT", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.ButtonFace;
            groupBox3.Location = new Point(415, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(180, 92);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Empate";
            // 
            // lblEmpate
            // 
            lblEmpate.AutoSize = true;
            lblEmpate.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmpate.Location = new Point(51, 45);
            lblEmpate.Name = "lblEmpate";
            lblEmpate.Size = new Size(0, 18);
            lblEmpate.TabIndex = 2;
            // 
            // btn1
            // 
            btn1.BackColor = Color.LightSeaGreen;
            btn1.Font = new Font("BankGothic Md BT", 20.25F, FontStyle.Bold);
            btn1.Location = new Point(178, 185);
            btn1.Name = "btn1";
            btn1.Size = new Size(67, 59);
            btn1.TabIndex = 2;
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += Botao_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.LightSeaGreen;
            btn2.Font = new Font("BankGothic Md BT", 20.25F, FontStyle.Bold);
            btn2.Location = new Point(251, 185);
            btn2.Name = "btn2";
            btn2.Size = new Size(67, 59);
            btn2.TabIndex = 3;
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += Botao_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.LightSeaGreen;
            btn3.Font = new Font("BankGothic Md BT", 20.25F, FontStyle.Bold);
            btn3.Location = new Point(324, 185);
            btn3.Name = "btn3";
            btn3.Size = new Size(67, 59);
            btn3.TabIndex = 4;
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += Botao_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.LightSeaGreen;
            btn4.Font = new Font("BankGothic Md BT", 20.25F, FontStyle.Bold);
            btn4.Location = new Point(178, 250);
            btn4.Name = "btn4";
            btn4.Size = new Size(67, 59);
            btn4.TabIndex = 5;
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += Botao_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.LightSeaGreen;
            btn5.Font = new Font("BankGothic Md BT", 20.25F, FontStyle.Bold);
            btn5.Location = new Point(251, 250);
            btn5.Name = "btn5";
            btn5.Size = new Size(67, 59);
            btn5.TabIndex = 6;
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += Botao_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.LightSeaGreen;
            btn6.Font = new Font("BankGothic Md BT", 20.25F, FontStyle.Bold);
            btn6.Location = new Point(324, 250);
            btn6.Name = "btn6";
            btn6.Size = new Size(67, 59);
            btn6.TabIndex = 7;
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += Botao_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.LightSeaGreen;
            btn7.Font = new Font("BankGothic Md BT", 20.25F, FontStyle.Bold);
            btn7.Location = new Point(178, 315);
            btn7.Name = "btn7";
            btn7.Size = new Size(67, 59);
            btn7.TabIndex = 8;
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += Botao_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.LightSeaGreen;
            btn8.Font = new Font("BankGothic Md BT", 20.25F, FontStyle.Bold);
            btn8.Location = new Point(251, 315);
            btn8.Name = "btn8";
            btn8.Size = new Size(67, 59);
            btn8.TabIndex = 9;
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += Botao_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.LightSeaGreen;
            btn9.Font = new Font("BankGothic Md BT", 20.25F, FontStyle.Bold);
            btn9.Location = new Point(324, 315);
            btn9.Name = "btn9";
            btn9.Size = new Size(67, 59);
            btn9.TabIndex = 10;
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += Botao_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 390);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox txtJogador2;
        private TextBox txtJogador1;
        private GroupBox groupBox4;
        private Label lblPlacar1;
        private Label lblPlacar2;
        private Label lblEmpate;
        private RadioButton rdbO;
        private RadioButton rdbX;
        private Button btnReiniciar;
        private Button btnSair;
        private Button btnIniciar;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
    }
}
