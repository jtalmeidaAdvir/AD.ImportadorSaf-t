
namespace AD.ImportadorSaf_t
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpFicheiro = new System.Windows.Forms.GroupBox();
            this.btnSelecionarFicheiro = new System.Windows.Forms.Button();
            this.txtFicheiro = new System.Windows.Forms.TextBox();
            this.lblFicheiro = new System.Windows.Forms.Label();
            this.grpParametros = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.lblNIF = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.grpOperacao = new System.Windows.Forms.GroupBox();
            this.rbEnviar = new System.Windows.Forms.RadioButton();
            this.rbValidar = new System.Windows.Forms.RadioButton();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.grpFicheiro.SuspendLayout();
            this.grpParametros.SuspendLayout();
            this.grpOperacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFicheiro
            // 
            this.grpFicheiro.Controls.Add(this.btnSelecionarFicheiro);
            this.grpFicheiro.Controls.Add(this.txtFicheiro);
            this.grpFicheiro.Controls.Add(this.lblFicheiro);
            this.grpFicheiro.Location = new System.Drawing.Point(12, 12);
            this.grpFicheiro.Name = "grpFicheiro";
            this.grpFicheiro.Size = new System.Drawing.Size(760, 80);
            this.grpFicheiro.TabIndex = 0;
            this.grpFicheiro.TabStop = false;
            this.grpFicheiro.Text = "Ficheiro SAF-T";
            // 
            // btnSelecionarFicheiro
            // 
            this.btnSelecionarFicheiro.Location = new System.Drawing.Point(650, 35);
            this.btnSelecionarFicheiro.Name = "btnSelecionarFicheiro";
            this.btnSelecionarFicheiro.Size = new System.Drawing.Size(100, 25);
            this.btnSelecionarFicheiro.TabIndex = 2;
            this.btnSelecionarFicheiro.Text = "Selecionar...";
            this.btnSelecionarFicheiro.UseVisualStyleBackColor = true;
            this.btnSelecionarFicheiro.Click += new System.EventHandler(this.btnSelecionarFicheiro_Click);
            // 
            // txtFicheiro
            // 
            this.txtFicheiro.Location = new System.Drawing.Point(80, 37);
            this.txtFicheiro.Name = "txtFicheiro";
            this.txtFicheiro.Size = new System.Drawing.Size(560, 22);
            this.txtFicheiro.TabIndex = 1;
            // 
            // lblFicheiro
            // 
            this.lblFicheiro.AutoSize = true;
            this.lblFicheiro.Location = new System.Drawing.Point(15, 40);
            this.lblFicheiro.Name = "lblFicheiro";
            this.lblFicheiro.Size = new System.Drawing.Size(59, 16);
            this.lblFicheiro.TabIndex = 0;
            this.lblFicheiro.Text = "Ficheiro:";
            // 
            // grpParametros
            // 
            this.grpParametros.Controls.Add(this.txtPassword);
            this.grpParametros.Controls.Add(this.lblPassword);
            this.grpParametros.Controls.Add(this.txtNIF);
            this.grpParametros.Controls.Add(this.lblNIF);
            this.grpParametros.Controls.Add(this.txtMes);
            this.grpParametros.Controls.Add(this.lblMes);
            this.grpParametros.Controls.Add(this.txtAno);
            this.grpParametros.Controls.Add(this.lblAno);
            this.grpParametros.Location = new System.Drawing.Point(12, 98);
            this.grpParametros.Name = "grpParametros";
            this.grpParametros.Size = new System.Drawing.Size(760, 100);
            this.grpParametros.TabIndex = 1;
            this.grpParametros.TabStop = false;
            this.grpParametros.Text = "Parâmetros";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(550, 30);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(190, 22);
            this.txtPassword.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(470, 33);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 16);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password:";
            // 
            // txtNIF
            // 
            this.txtNIF.Location = new System.Drawing.Point(80, 30);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(150, 22);
            this.txtNIF.TabIndex = 5;
            // 
            // lblNIF
            // 
            this.lblNIF.AutoSize = true;
            this.lblNIF.Location = new System.Drawing.Point(15, 33);
            this.lblNIF.Name = "lblNIF";
            this.lblNIF.Size = new System.Drawing.Size(31, 16);
            this.lblNIF.TabIndex = 4;
            this.lblNIF.Text = "NIF:";
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(320, 60);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(80, 22);
            this.txtMes.TabIndex = 3;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(270, 63);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(36, 16);
            this.lblMes.TabIndex = 2;
            this.lblMes.Text = "Mês:";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(80, 60);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(80, 22);
            this.txtAno.TabIndex = 1;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(15, 63);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(34, 16);
            this.lblAno.TabIndex = 0;
            this.lblAno.Text = "Ano:";
            // 
            // grpOperacao
            // 
            this.grpOperacao.Controls.Add(this.rbEnviar);
            this.grpOperacao.Controls.Add(this.rbValidar);
            this.grpOperacao.Location = new System.Drawing.Point(12, 204);
            this.grpOperacao.Name = "grpOperacao";
            this.grpOperacao.Size = new System.Drawing.Size(300, 80);
            this.grpOperacao.TabIndex = 2;
            this.grpOperacao.TabStop = false;
            this.grpOperacao.Text = "Operação";
            // 
            // rbEnviar
            // 
            this.rbEnviar.AutoSize = true;
            this.rbEnviar.Location = new System.Drawing.Point(150, 35);
            this.rbEnviar.Name = "rbEnviar";
            this.rbEnviar.Size = new System.Drawing.Size(66, 20);
            this.rbEnviar.TabIndex = 1;
            this.rbEnviar.Text = "Enviar";
            this.rbEnviar.UseVisualStyleBackColor = true;
            // 
            // rbValidar
            // 
            this.rbValidar.AutoSize = true;
            this.rbValidar.Checked = true;
            this.rbValidar.Location = new System.Drawing.Point(20, 35);
            this.rbValidar.Name = "rbValidar";
            this.rbValidar.Size = new System.Drawing.Size(72, 20);
            this.rbValidar.TabIndex = 0;
            this.rbValidar.TabStop = true;
            this.rbValidar.Text = "Validar";
            this.rbValidar.UseVisualStyleBackColor = true;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.Location = new System.Drawing.Point(320, 220);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(450, 50);
            this.btnExecutar.TabIndex = 3;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(12, 315);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(760, 200);
            this.txtResultado.TabIndex = 4;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 295);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(73, 16);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado:";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 527);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.grpOperacao);
            this.Controls.Add(this.grpParametros);
            this.Controls.Add(this.grpFicheiro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importador SAF-T (Ficheiros >40MB)";
            this.grpFicheiro.ResumeLayout(false);
            this.grpFicheiro.PerformLayout();
            this.grpParametros.ResumeLayout(false);
            this.grpParametros.PerformLayout();
            this.grpOperacao.ResumeLayout(false);
            this.grpOperacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFicheiro;
        private System.Windows.Forms.Button btnSelecionarFicheiro;
        private System.Windows.Forms.TextBox txtFicheiro;
        private System.Windows.Forms.Label lblFicheiro;
        private System.Windows.Forms.GroupBox grpParametros;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.Label lblNIF;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.GroupBox grpOperacao;
        private System.Windows.Forms.RadioButton rbEnviar;
        private System.Windows.Forms.RadioButton rbValidar;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblResultado;
    }
}
