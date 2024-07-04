namespace HerançaForms
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
            txtMontante = new TextBox();
            txtPrazo = new TextBox();
            txtTaxaJuro = new TextBox();
            lblMontante = new Label();
            lblPrazo = new Label();
            lblTaxaJuro = new Label();
            btnCalcular = new Button();
            lblResultado = new Label();
            cbTipoFinanciamento = new ComboBox();
            lblTipoFinanciamento = new Label();
            panelFiador = new Panel();
            label1 = new Label();
            lblTitulo = new Label();
            txtFiadorRendimento = new TextBox();
            txtFiadorNIF = new TextBox();
            txtFiadorTelefone = new TextBox();
            txtFiadorMorada = new TextBox();
            txtFiadorNome = new TextBox();
            lblFiadorRendimento = new Label();
            lblFiadorNIF = new Label();
            lblFiadorTelefone = new Label();
            lblFiadorMorada = new Label();
            lblFiadorNome = new Label();
            panelFiador.SuspendLayout();
            SuspendLayout();
            // 
            // txtMontante
            // 
            txtMontante.Location = new Point(25, 80);
            txtMontante.Name = "txtMontante";
            txtMontante.PlaceholderText = "Montante";
            txtMontante.Size = new Size(86, 23);
            txtMontante.TabIndex = 2;
            txtMontante.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPrazo
            // 
            txtPrazo.Location = new Point(133, 80);
            txtPrazo.Name = "txtPrazo";
            txtPrazo.PlaceholderText = "Prazo";
            txtPrazo.Size = new Size(85, 23);
            txtPrazo.TabIndex = 3;
            txtPrazo.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTaxaJuro
            // 
            txtTaxaJuro.Location = new Point(245, 80);
            txtTaxaJuro.Name = "txtTaxaJuro";
            txtTaxaJuro.PlaceholderText = "Taxa Juro";
            txtTaxaJuro.Size = new Size(78, 23);
            txtTaxaJuro.TabIndex = 4;
            txtTaxaJuro.TextAlign = HorizontalAlignment.Center;
            // 
            // lblMontante
            // 
            lblMontante.AutoSize = true;
            lblMontante.Location = new Point(42, 62);
            lblMontante.Name = "lblMontante";
            lblMontante.Size = new Size(59, 15);
            lblMontante.TabIndex = 12;
            lblMontante.Text = "Montante";
            // 
            // lblPrazo
            // 
            lblPrazo.AutoSize = true;
            lblPrazo.Location = new Point(158, 62);
            lblPrazo.Name = "lblPrazo";
            lblPrazo.Size = new Size(36, 15);
            lblPrazo.TabIndex = 13;
            lblPrazo.Text = "Prazo";
            // 
            // lblTaxaJuro
            // 
            lblTaxaJuro.AutoSize = true;
            lblTaxaJuro.Location = new Point(258, 62);
            lblTaxaJuro.Name = "lblTaxaJuro";
            lblTaxaJuro.Size = new Size(55, 15);
            lblTaxaJuro.TabIndex = 14;
            lblTaxaJuro.Text = "Taxa Juro";
            // 
            // btnCalcular
            // 
            btnCalcular.FlatAppearance.BorderColor = Color.Black;
            btnCalcular.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            btnCalcular.Location = new Point(123, 392);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(95, 32);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(42, 416);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(66, 17);
            lblResultado.TabIndex = 10;
            lblResultado.Text = "Resultado";
            // 
            // cbTipoFinanciamento
            // 
            cbTipoFinanciamento.FormattingEnabled = true;
            cbTipoFinanciamento.Items.AddRange(new object[] { "Carro", "Casa" });
            cbTipoFinanciamento.Location = new Point(107, 155);
            cbTipoFinanciamento.Name = "cbTipoFinanciamento";
            cbTipoFinanciamento.Size = new Size(157, 23);
            cbTipoFinanciamento.TabIndex = 1;
            cbTipoFinanciamento.Text = "Tipo Financiamento";
            // 
            // lblTipoFinanciamento
            // 
            lblTipoFinanciamento.AutoSize = true;
            lblTipoFinanciamento.Location = new Point(107, 137);
            lblTipoFinanciamento.Name = "lblTipoFinanciamento";
            lblTipoFinanciamento.Size = new Size(112, 15);
            lblTipoFinanciamento.TabIndex = 21;
            lblTipoFinanciamento.Text = "Tipo Financiamento";
            // 
            // panelFiador
            // 
            panelFiador.BackColor = Color.Black;
            panelFiador.Controls.Add(label1);
            panelFiador.Controls.Add(lblTitulo);
            panelFiador.Controls.Add(lblResultado);
            panelFiador.ForeColor = Color.White;
            panelFiador.Location = new Point(400, 0);
            panelFiador.Name = "panelFiador";
            panelFiador.Size = new Size(316, 482);
            panelFiador.TabIndex = 11;
            panelFiador.Click += cbTipoFinanciamento_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 373);
            label1.Name = "label1";
            label1.Size = new Size(219, 21);
            label1.TabIndex = 23;
            label1.Text = "Vê aqui quanto vais pagar:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(28, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(262, 28);
            lblTitulo.TabIndex = 22;
            lblTitulo.Text = "Trabalho Herança - POO";
            // 
            // txtFiadorRendimento
            // 
            txtFiadorRendimento.Location = new Point(133, 301);
            txtFiadorRendimento.Name = "txtFiadorRendimento";
            txtFiadorRendimento.PlaceholderText = "Rendimento Fiador";
            txtFiadorRendimento.Size = new Size(150, 23);
            txtFiadorRendimento.TabIndex = 9;
            txtFiadorRendimento.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFiadorNIF
            // 
            txtFiadorNIF.Location = new Point(25, 301);
            txtFiadorNIF.Name = "txtFiadorNIF";
            txtFiadorNIF.PlaceholderText = "NIF Fiador";
            txtFiadorNIF.Size = new Size(86, 23);
            txtFiadorNIF.TabIndex = 8;
            txtFiadorNIF.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFiadorTelefone
            // 
            txtFiadorTelefone.Location = new Point(245, 231);
            txtFiadorTelefone.Name = "txtFiadorTelefone";
            txtFiadorTelefone.PlaceholderText = "Telefone Fiador";
            txtFiadorTelefone.Size = new Size(101, 23);
            txtFiadorTelefone.TabIndex = 7;
            txtFiadorTelefone.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFiadorMorada
            // 
            txtFiadorMorada.Location = new Point(132, 231);
            txtFiadorMorada.Name = "txtFiadorMorada";
            txtFiadorMorada.PlaceholderText = "Morada Fiador";
            txtFiadorMorada.Size = new Size(86, 23);
            txtFiadorMorada.TabIndex = 6;
            txtFiadorMorada.TextAlign = HorizontalAlignment.Center;
            // 
            // txtFiadorNome
            // 
            txtFiadorNome.Location = new Point(25, 231);
            txtFiadorNome.Name = "txtFiadorNome";
            txtFiadorNome.PlaceholderText = "Nome Fiador";
            txtFiadorNome.Size = new Size(86, 23);
            txtFiadorNome.TabIndex = 5;
            txtFiadorNome.TextAlign = HorizontalAlignment.Center;
            // 
            // lblFiadorRendimento
            // 
            lblFiadorRendimento.AutoSize = true;
            lblFiadorRendimento.Location = new Point(158, 283);
            lblFiadorRendimento.Name = "lblFiadorRendimento";
            lblFiadorRendimento.Size = new Size(108, 15);
            lblFiadorRendimento.TabIndex = 20;
            lblFiadorRendimento.Text = "Rendimento Fiador";
            // 
            // lblFiadorNIF
            // 
            lblFiadorNIF.AutoSize = true;
            lblFiadorNIF.Location = new Point(25, 283);
            lblFiadorNIF.Name = "lblFiadorNIF";
            lblFiadorNIF.Size = new Size(61, 15);
            lblFiadorNIF.TabIndex = 19;
            lblFiadorNIF.Text = "NIF Fiador";
            // 
            // lblFiadorTelefone
            // 
            lblFiadorTelefone.AutoSize = true;
            lblFiadorTelefone.Location = new Point(245, 213);
            lblFiadorTelefone.Name = "lblFiadorTelefone";
            lblFiadorTelefone.Size = new Size(87, 15);
            lblFiadorTelefone.TabIndex = 16;
            lblFiadorTelefone.Text = "Telefone Fiador";
            // 
            // lblFiadorMorada
            // 
            lblFiadorMorada.AutoSize = true;
            lblFiadorMorada.Location = new Point(132, 213);
            lblFiadorMorada.Name = "lblFiadorMorada";
            lblFiadorMorada.Size = new Size(84, 15);
            lblFiadorMorada.TabIndex = 17;
            lblFiadorMorada.Text = "Morada Fiador";
            // 
            // lblFiadorNome
            // 
            lblFiadorNome.AutoSize = true;
            lblFiadorNome.Location = new Point(25, 213);
            lblFiadorNome.Name = "lblFiadorNome";
            lblFiadorNome.Size = new Size(76, 15);
            lblFiadorNome.TabIndex = 18;
            lblFiadorNome.Text = "Nome Fiador";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 482);
            Controls.Add(lblTipoFinanciamento);
            Controls.Add(lblFiadorRendimento);
            Controls.Add(lblFiadorNIF);
            Controls.Add(lblFiadorNome);
            Controls.Add(lblFiadorMorada);
            Controls.Add(lblFiadorTelefone);
            Controls.Add(lblTaxaJuro);
            Controls.Add(lblPrazo);
            Controls.Add(lblMontante);
            Controls.Add(panelFiador);
            Controls.Add(txtFiadorRendimento);
            Controls.Add(txtFiadorNIF);
            Controls.Add(txtFiadorTelefone);
            Controls.Add(txtFiadorMorada);
            Controls.Add(txtFiadorNome);
            Controls.Add(txtTaxaJuro);
            Controls.Add(txtPrazo);
            Controls.Add(txtMontante);
            Controls.Add(cbTipoFinanciamento);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "FormHerança - Eduardo M";
            panelFiador.ResumeLayout(false);
            panelFiador.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private ComboBox cbTipoFinanciamento;
        private TextBox txtMontante;
        private TextBox txtPrazo;
        private TextBox txtTaxaJuro;
        private TextBox txtFiadorNome;
        private TextBox txtFiadorMorada;
        private TextBox txtFiadorTelefone;
        private TextBox txtFiadorNIF;
        private TextBox txtFiadorRendimento;
        private Label lblResultado;
        private Panel panelFiador;
        private Label lblMontante;
        private Label lblPrazo;
        private Label lblTaxaJuro;
        private Label lblTipoFinancimento;
        private Label lblFiadorTelefone;
        private Label lblFiadorMorada;
        private Label lblFiadorNome;
        private Label lblFiadorNIF;
        private Label lblFiadorRendimento;
        private Label lblTipoFinanciamento;
        private Label label1;
        private Label lblTitulo;
    }
}
