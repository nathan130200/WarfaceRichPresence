namespace WarfaceRichPresence.Controls
{
	partial class InLobbyControl
	{
		/// <summary> 
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Designer de Componentes

		/// <summary> 
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.grpChannel = new System.Windows.Forms.GroupBox();
			this.rbSobrevivencia = new System.Windows.Forms.RadioButton();
			this.rbCoop = new System.Windows.Forms.RadioButton();
			this.rbProfissionais = new System.Windows.Forms.RadioButton();
			this.rbNovatos = new System.Windows.Forms.RadioButton();
			this.rbExperientes = new System.Windows.Forms.RadioButton();
			this.nudCanal = new System.Windows.Forms.NumericUpDown();
			this.btnOk = new System.Windows.Forms.Button();
			this.lbDescription = new System.Windows.Forms.Label();
			this.chkbResetarTempo = new System.Windows.Forms.CheckBox();
			this.grpChannel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCanal)).BeginInit();
			this.SuspendLayout();
			// 
			// grpChannel
			// 
			this.grpChannel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpChannel.BackColor = System.Drawing.Color.Transparent;
			this.grpChannel.Controls.Add(this.rbSobrevivencia);
			this.grpChannel.Controls.Add(this.rbCoop);
			this.grpChannel.Controls.Add(this.rbProfissionais);
			this.grpChannel.Controls.Add(this.rbNovatos);
			this.grpChannel.Controls.Add(this.rbExperientes);
			this.grpChannel.ForeColor = System.Drawing.Color.White;
			this.grpChannel.Location = new System.Drawing.Point(3, 36);
			this.grpChannel.Name = "grpChannel";
			this.grpChannel.Size = new System.Drawing.Size(183, 183);
			this.grpChannel.TabIndex = 0;
			this.grpChannel.TabStop = false;
			this.grpChannel.Text = "Canal";
			// 
			// rbSobrevivencia
			// 
			this.rbSobrevivencia.AutoSize = true;
			this.rbSobrevivencia.Location = new System.Drawing.Point(47, 143);
			this.rbSobrevivencia.Name = "rbSobrevivencia";
			this.rbSobrevivencia.Size = new System.Drawing.Size(97, 23);
			this.rbSobrevivencia.TabIndex = 5;
			this.rbSobrevivencia.Text = "Sobrevivência";
			this.rbSobrevivencia.UseVisualStyleBackColor = true;
			this.rbSobrevivencia.CheckedChanged += new System.EventHandler(this.rbSobrevivencia_CheckedChanged);
			// 
			// rbCoop
			// 
			this.rbCoop.AutoSize = true;
			this.rbCoop.Checked = true;
			this.rbCoop.Location = new System.Drawing.Point(47, 114);
			this.rbCoop.Name = "rbCoop";
			this.rbCoop.Size = new System.Drawing.Size(52, 23);
			this.rbCoop.TabIndex = 4;
			this.rbCoop.TabStop = true;
			this.rbCoop.Text = "Coop";
			this.rbCoop.UseVisualStyleBackColor = true;
			this.rbCoop.CheckedChanged += new System.EventHandler(this.rbCoop_CheckedChanged);
			// 
			// rbProfissionais
			// 
			this.rbProfissionais.AutoSize = true;
			this.rbProfissionais.Location = new System.Drawing.Point(47, 85);
			this.rbProfissionais.Name = "rbProfissionais";
			this.rbProfissionais.Size = new System.Drawing.Size(93, 23);
			this.rbProfissionais.TabIndex = 3;
			this.rbProfissionais.Text = "Profissionais";
			this.rbProfissionais.UseVisualStyleBackColor = true;
			this.rbProfissionais.CheckedChanged += new System.EventHandler(this.rbProfissionais_CheckedChanged);
			// 
			// rbNovatos
			// 
			this.rbNovatos.AutoSize = true;
			this.rbNovatos.Location = new System.Drawing.Point(47, 27);
			this.rbNovatos.Name = "rbNovatos";
			this.rbNovatos.Size = new System.Drawing.Size(69, 23);
			this.rbNovatos.TabIndex = 1;
			this.rbNovatos.Text = "Novatos";
			this.rbNovatos.UseVisualStyleBackColor = true;
			this.rbNovatos.CheckedChanged += new System.EventHandler(this.rbNovatos_CheckedChanged);
			// 
			// rbExperientes
			// 
			this.rbExperientes.AutoSize = true;
			this.rbExperientes.Location = new System.Drawing.Point(47, 56);
			this.rbExperientes.Name = "rbExperientes";
			this.rbExperientes.Size = new System.Drawing.Size(86, 23);
			this.rbExperientes.TabIndex = 2;
			this.rbExperientes.Text = "Experientes";
			this.rbExperientes.UseVisualStyleBackColor = true;
			this.rbExperientes.CheckedChanged += new System.EventHandler(this.rbExperientes_CheckedChanged);
			// 
			// nudCanal
			// 
			this.nudCanal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nudCanal.BackColor = System.Drawing.SystemColors.ControlText;
			this.nudCanal.Enabled = false;
			this.nudCanal.ForeColor = System.Drawing.Color.White;
			this.nudCanal.Location = new System.Drawing.Point(3, 223);
			this.nudCanal.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudCanal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudCanal.Name = "nudCanal";
			this.nudCanal.Size = new System.Drawing.Size(183, 26);
			this.nudCanal.TabIndex = 2;
			this.nudCanal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOk.Font = new System.Drawing.Font("Titillium Web", 9F, System.Drawing.FontStyle.Bold);
			this.btnOk.Location = new System.Drawing.Point(3, 285);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(183, 29);
			this.btnOk.TabIndex = 3;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// lbDescription
			// 
			this.lbDescription.AutoSize = true;
			this.lbDescription.BackColor = System.Drawing.Color.Transparent;
			this.lbDescription.Font = new System.Drawing.Font("Titillium Web", 14F, System.Drawing.FontStyle.Bold);
			this.lbDescription.Location = new System.Drawing.Point(47, 4);
			this.lbDescription.Name = "lbDescription";
			this.lbDescription.Size = new System.Drawing.Size(96, 29);
			this.lbDescription.TabIndex = 4;
			this.lbDescription.Text = "No Lobby";
			// 
			// chkbResetarTempo
			// 
			this.chkbResetarTempo.AutoSize = true;
			this.chkbResetarTempo.BackColor = System.Drawing.Color.Transparent;
			this.chkbResetarTempo.Checked = true;
			this.chkbResetarTempo.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkbResetarTempo.Location = new System.Drawing.Point(3, 255);
			this.chkbResetarTempo.Name = "chkbResetarTempo";
			this.chkbResetarTempo.Size = new System.Drawing.Size(102, 23);
			this.chkbResetarTempo.TabIndex = 6;
			this.chkbResetarTempo.Text = "Zerar Contador";
			this.chkbResetarTempo.UseVisualStyleBackColor = false;
			// 
			// InLobbyControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.chkbResetarTempo);
			this.Controls.Add(this.lbDescription);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.nudCanal);
			this.Controls.Add(this.grpChannel);
			this.Font = new System.Drawing.Font("Titillium Web", 9F);
			this.ForeColor = System.Drawing.Color.White;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "InLobbyControl";
			this.Size = new System.Drawing.Size(189, 317);
			this.Load += new System.EventHandler(this.InLobbyControl_Load);
			this.grpChannel.ResumeLayout(false);
			this.grpChannel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCanal)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox grpChannel;
		private System.Windows.Forms.RadioButton rbProfissionais;
		private System.Windows.Forms.RadioButton rbNovatos;
		private System.Windows.Forms.RadioButton rbExperientes;
		private System.Windows.Forms.RadioButton rbCoop;
		private System.Windows.Forms.RadioButton rbSobrevivencia;
		private System.Windows.Forms.NumericUpDown nudCanal;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Label lbDescription;
		private System.Windows.Forms.CheckBox chkbResetarTempo;
	}
}
