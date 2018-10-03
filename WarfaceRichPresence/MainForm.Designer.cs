namespace WarfaceRichPresence
{
	partial class MainForm
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

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.tbApplicationId = new System.Windows.Forms.TextBox();
			this.btnConnect = new System.Windows.Forms.Button();
			this.btnDisconnect = new System.Windows.Forms.Button();
			this.pboxAvatar = new System.Windows.Forms.PictureBox();
			this.lbUsername = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pboxAvatar)).BeginInit();
			this.SuspendLayout();
			// 
			// tbApplicationId
			// 
			this.tbApplicationId.Location = new System.Drawing.Point(12, 12);
			this.tbApplicationId.Name = "tbApplicationId";
			this.tbApplicationId.Size = new System.Drawing.Size(182, 22);
			this.tbApplicationId.TabIndex = 0;
			this.tbApplicationId.Text = "479021344625917953";
			this.tbApplicationId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(12, 40);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(88, 23);
			this.btnConnect.TabIndex = 1;
			this.btnConnect.Text = "Conectar";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// btnDisconnect
			// 
			this.btnDisconnect.Location = new System.Drawing.Point(106, 40);
			this.btnDisconnect.Name = "btnDisconnect";
			this.btnDisconnect.Size = new System.Drawing.Size(88, 23);
			this.btnDisconnect.TabIndex = 2;
			this.btnDisconnect.Text = "Desconectar";
			this.btnDisconnect.UseVisualStyleBackColor = true;
			this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
			// 
			// pboxAvatar
			// 
			this.pboxAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pboxAvatar.Location = new System.Drawing.Point(12, 69);
			this.pboxAvatar.Name = "pboxAvatar";
			this.pboxAvatar.Size = new System.Drawing.Size(48, 48);
			this.pboxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pboxAvatar.TabIndex = 3;
			this.pboxAvatar.TabStop = false;
			// 
			// lbUsername
			// 
			this.lbUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lbUsername.Location = new System.Drawing.Point(12, 69);
			this.lbUsername.Name = "lbUsername";
			this.lbUsername.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
			this.lbUsername.Size = new System.Drawing.Size(182, 48);
			this.lbUsername.TabIndex = 4;
			this.lbUsername.Text = "Indisponível#0000";
			this.lbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(206, 123);
			this.Controls.Add(this.pboxAvatar);
			this.Controls.Add(this.btnDisconnect);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.tbApplicationId);
			this.Controls.Add(this.lbUsername);
			this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Warface Rich Presence";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pboxAvatar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbApplicationId;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Button btnDisconnect;
		private System.Windows.Forms.PictureBox pboxAvatar;
		private System.Windows.Forms.Label lbUsername;
	}
}

