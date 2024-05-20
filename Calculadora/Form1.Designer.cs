namespace Calculadora
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
            visorResultado = new TextBox();
            btn0 = new Button();
            btn1 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn9 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn2 = new Button();
            btnVirgula = new Button();
            btnIgual = new Button();
            btnDivisao = new Button();
            btnMultiplicacao = new Button();
            btnSubtracao = new Button();
            btnSoma = new Button();
            btnLimpar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // visorResultado
            // 
            visorResultado.Location = new Point(20, 12);
            visorResultado.Name = "visorResultado";
            visorResultado.ReadOnly = true;
            visorResultado.Size = new Size(250, 23);
            visorResultado.TabIndex = 0;
            visorResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.ActiveCaption;
            btn0.ForeColor = Color.Cornsilk;
            btn0.Location = new Point(84, 241);
            btn0.Name = "btn0";
            btn0.Size = new Size(58, 45);
            btn0.TabIndex = 1;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ActiveCaption;
            btn1.ForeColor = Color.Cornsilk;
            btn1.Location = new Point(20, 190);
            btn1.Name = "btn1";
            btn1.Size = new Size(58, 45);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ActiveCaption;
            btn3.ForeColor = Color.Cornsilk;
            btn3.Location = new Point(148, 190);
            btn3.Name = "btn3";
            btn3.Size = new Size(58, 45);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.ActiveCaption;
            btn6.ForeColor = Color.Cornsilk;
            btn6.Location = new Point(148, 139);
            btn6.Name = "btn6";
            btn6.Size = new Size(58, 45);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ActiveCaption;
            btn4.ForeColor = Color.Cornsilk;
            btn4.Location = new Point(20, 139);
            btn4.Name = "btn4";
            btn4.Size = new Size(58, 45);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ActiveCaption;
            btn5.ForeColor = Color.Cornsilk;
            btn5.Location = new Point(84, 139);
            btn5.Name = "btn5";
            btn5.Size = new Size(58, 45);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ActiveCaption;
            btn9.ForeColor = Color.Cornsilk;
            btn9.Location = new Point(148, 88);
            btn9.Name = "btn9";
            btn9.Size = new Size(58, 45);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ActiveCaption;
            btn7.ForeColor = Color.Cornsilk;
            btn7.Location = new Point(20, 88);
            btn7.Name = "btn7";
            btn7.Size = new Size(58, 45);
            btn7.TabIndex = 8;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ActiveCaption;
            btn8.ForeColor = Color.Cornsilk;
            btn8.Location = new Point(84, 88);
            btn8.Name = "btn8";
            btn8.Size = new Size(58, 45);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ActiveCaption;
            btn2.ForeColor = Color.Cornsilk;
            btn2.Location = new Point(84, 190);
            btn2.Name = "btn2";
            btn2.Size = new Size(58, 45);
            btn2.TabIndex = 10;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.BackColor = Color.Chocolate;
            btnVirgula.ForeColor = Color.Cornsilk;
            btnVirgula.Location = new Point(20, 241);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(58, 45);
            btnVirgula.TabIndex = 11;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.Chocolate;
            btnIgual.ForeColor = Color.Cornsilk;
            btnIgual.Location = new Point(148, 241);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(58, 45);
            btnIgual.TabIndex = 12;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.BackColor = Color.Chocolate;
            btnDivisao.ForeColor = Color.Cornsilk;
            btnDivisao.Location = new Point(212, 88);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(58, 45);
            btnDivisao.TabIndex = 13;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = false;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.BackColor = Color.Chocolate;
            btnMultiplicacao.ForeColor = Color.Cornsilk;
            btnMultiplicacao.Location = new Point(212, 139);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(58, 45);
            btnMultiplicacao.TabIndex = 14;
            btnMultiplicacao.Text = "x";
            btnMultiplicacao.UseVisualStyleBackColor = false;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnSubtracao
            // 
            btnSubtracao.BackColor = Color.Chocolate;
            btnSubtracao.ForeColor = Color.Cornsilk;
            btnSubtracao.Location = new Point(212, 190);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(58, 45);
            btnSubtracao.TabIndex = 15;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = false;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnSoma
            // 
            btnSoma.BackColor = Color.Chocolate;
            btnSoma.ForeColor = Color.Cornsilk;
            btnSoma.Location = new Point(212, 241);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(58, 45);
            btnSoma.TabIndex = 16;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = false;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = SystemColors.AppWorkspace;
            btnLimpar.ForeColor = Color.Cornsilk;
            btnLimpar.Location = new Point(212, 54);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(58, 32);
            btnLimpar.TabIndex = 17;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 16);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 299);
            Controls.Add(label1);
            Controls.Add(btnLimpar);
            Controls.Add(btnSoma);
            Controls.Add(btnSubtracao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnDivisao);
            Controls.Add(btnIgual);
            Controls.Add(btnVirgula);
            Controls.Add(btn2);
            Controls.Add(btn9);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn6);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn3);
            Controls.Add(btn1);
            Controls.Add(btn0);
            Controls.Add(visorResultado);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox visorResultado;
        private Button btn0;
        private Button btn1;
        private Button btn3;
        private Button btn6;
        private Button btn4;
        private Button btn5;
        private Button btn9;
        private Button btn7;
        private Button btn8;
        private Button btn2;
        private Button btnVirgula;
        private Button btnIgual;
        private Button btnDivisao;
        private Button btnMultiplicacao;
        private Button btnSubtracao;
        private Button btnSoma;
        private Button btnLimpar;
        private Label label1;
    }
}
