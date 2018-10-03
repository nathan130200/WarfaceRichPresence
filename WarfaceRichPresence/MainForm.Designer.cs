namespace WarfaceRichPresence
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			this.tbApplicationId = new System.Windows.Forms.TextBox();
			this.btnToggle = new System.Windows.Forms.Button();
			this.pbAvatarImage = new System.Windows.Forms.PictureBox();
			this.lbUsername = new System.Windows.Forms.Label();
			this.panelTopInfo = new System.Windows.Forms.Panel();
			this.RunCallbacksTimer = new System.Windows.Forms.Timer(this.components);
			this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
			this.inLobbyControl1 = new WarfaceRichPresence.Controls.InLobbyControl();
			this.separatorLineTopM = new WarfaceRichPresence.Controls.SeparatorLine();
			this.btnLimparPresenca = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbAvatarImage)).BeginInit();
			this.panelTopInfo.SuspendLayout();
			this.flpMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbApplicationId
			// 
			this.tbApplicationId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbApplicationId.BackColor = System.Drawing.Color.Black;
			this.tbApplicationId.ForeColor = System.Drawing.Color.White;
			this.tbApplicationId.Location = new System.Drawing.Point(528, 12);
			this.tbApplicationId.Name = "tbApplicationId";
			this.tbApplicationId.Size = new System.Drawing.Size(181, 26);
			this.tbApplicationId.TabIndex = 0;
			this.tbApplicationId.Text = "479021344625917953";
			this.tbApplicationId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnToggle
			// 
			this.btnToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnToggle.AutoSize = true;
			this.btnToggle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnToggle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnToggle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnToggle.Font = new System.Drawing.Font("Titillium Web", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnToggle.Location = new System.Drawing.Point(528, 44);
			this.btnToggle.Name = "btnToggle";
			this.btnToggle.Size = new System.Drawing.Size(181, 37);
			this.btnToggle.TabIndex = 1;
			this.btnToggle.Text = "Conectar";
			this.btnToggle.UseVisualStyleBackColor = true;
			this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
			// 
			// pbAvatarImage
			// 
			this.pbAvatarImage.Dock = System.Windows.Forms.DockStyle.Left;
			this.pbAvatarImage.Location = new System.Drawing.Point(0, 0);
			this.pbAvatarImage.Name = "pbAvatarImage";
			this.pbAvatarImage.Size = new System.Drawing.Size(69, 69);
			this.pbAvatarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbAvatarImage.TabIndex = 2;
			this.pbAvatarImage.TabStop = false;
			// 
			// lbUsername
			// 
			this.lbUsername.AutoEllipsis = true;
			this.lbUsername.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbUsername.Font = new System.Drawing.Font("Titillium Web", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbUsername.Location = new System.Drawing.Point(69, 0);
			this.lbUsername.Name = "lbUsername";
			this.lbUsername.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.lbUsername.Size = new System.Drawing.Size(441, 69);
			this.lbUsername.TabIndex = 3;
			this.lbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panelTopInfo
			// 
			this.panelTopInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelTopInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.panelTopInfo.Controls.Add(this.lbUsername);
			this.panelTopInfo.Controls.Add(this.pbAvatarImage);
			this.panelTopInfo.Location = new System.Drawing.Point(12, 12);
			this.panelTopInfo.Name = "panelTopInfo";
			this.panelTopInfo.Size = new System.Drawing.Size(510, 69);
			this.panelTopInfo.TabIndex = 4;
			// 
			// RunCallbacksTimer
			// 
			this.RunCallbacksTimer.Enabled = true;
			this.RunCallbacksTimer.Interval = 1000;
			this.RunCallbacksTimer.Tick += new System.EventHandler(this.RunCallbacksTimer_Tick);
			// 
			// flpMain
			// 
			this.flpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.flpMain.AutoScroll = true;
			this.flpMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.flpMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.flpMain.Controls.Add(this.inLobbyControl1);
			this.flpMain.Enabled = false;
			this.flpMain.Location = new System.Drawing.Point(12, 93);
			this.flpMain.Name = "flpMain";
			this.flpMain.Padding = new System.Windows.Forms.Padding(10);
			this.flpMain.Size = new System.Drawing.Size(696, 396);
			this.flpMain.TabIndex = 9;
			this.flpMain.WrapContents = false;
			// 
			// inLobbyControl1
			// 
			this.inLobbyControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.inLobbyControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.inLobbyControl1.Font = new System.Drawing.Font("Titillium Web", 9F);
			this.inLobbyControl1.ForeColor = System.Drawing.Color.White;
			this.inLobbyControl1.Location = new System.Drawing.Point(13, 14);
			this.inLobbyControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.inLobbyControl1.Name = "inLobbyControl1";
			this.inLobbyControl1.Size = new System.Drawing.Size(189, 317);
			this.inLobbyControl1.TabIndex = 0;
			// 
			// separatorLineTopM
			// 
			this.separatorLineTopM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.separatorLineTopM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.separatorLineTopM.Location = new System.Drawing.Point(12, 88);
			this.separatorLineTopM.MaximumSize = new System.Drawing.Size(2147483647, 2);
			this.separatorLineTopM.MinimumSize = new System.Drawing.Size(1, 2);
			this.separatorLineTopM.Mode = WarfaceRichPresence.Controls.SeparatorLineMode.Horizontal;
			this.separatorLineTopM.Name = "separatorLineTopM";
			this.separatorLineTopM.Size = new System.Drawing.Size(697, 2);
			this.separatorLineTopM.TabIndex = 7;
			// 
			// btnLimparPresenca
			// 
			this.btnLimparPresenca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLimparPresenca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnLimparPresenca.Enabled = false;
			this.btnLimparPresenca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnLimparPresenca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnLimparPresenca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.btnLimparPresenca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLimparPresenca.Font = new System.Drawing.Font("Titillium Web", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimparPresenca.Location = new System.Drawing.Point(585, 495);
			this.btnLimparPresenca.Name = "btnLimparPresenca";
			this.btnLimparPresenca.Size = new System.Drawing.Size(123, 30);
			this.btnLimparPresenca.TabIndex = 10;
			this.btnLimparPresenca.Text = "Limpar Presença";
			this.btnLimparPresenca.UseVisualStyleBackColor = false;
			this.btnLimparPresenca.Click += new System.EventHandler(this.btnLimparPresenca_Click);
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.ControlText;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(720, 537);
			this.Controls.Add(this.btnLimparPresenca);
			this.Controls.Add(this.flpMain);
			this.Controls.Add(this.separatorLineTopM);
			this.Controls.Add(this.panelTopInfo);
			this.Controls.Add(this.btnToggle);
			this.Controls.Add(this.tbApplicationId);
			this.Font = new System.Drawing.Font("Titillium Web", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.Icon = global::WarfaceRichPresence.Properties.Resources.App;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Warface Rich Presence";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbAvatarImage)).EndInit();
			this.panelTopInfo.ResumeLayout(false);
			this.flpMain.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbApplicationId;
		private System.Windows.Forms.Button btnToggle;
		private System.Windows.Forms.PictureBox pbAvatarImage;
		private System.Windows.Forms.Label lbUsername;
		private System.Windows.Forms.Panel panelTopInfo;
		private System.Windows.Forms.Timer RunCallbacksTimer;
		private Controls.SeparatorLine separatorLineTopM;
		private System.Windows.Forms.FlowLayoutPanel flpMain;
		private Controls.InLobbyControl inLobbyControl1;
		private System.Windows.Forms.Button btnLimparPresenca;
	}
}