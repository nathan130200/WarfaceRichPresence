namespace WarfaceRichPresence.Forms
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
			this.tbAppId = new System.Windows.Forms.TextBox();
			this.gbStatus = new System.Windows.Forms.GroupBox();
			this.tbState = new System.Windows.Forms.TextBox();
			this.tbDetails = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.ckbEnableStopTime = new System.Windows.Forms.CheckBox();
			this.mtbStopTime = new System.Windows.Forms.MaskedTextBox();
			this.ckbMostrarTempo = new System.Windows.Forms.CheckBox();
			this.ckbReplaceTimestamp = new System.Windows.Forms.CheckBox();
			this.tbLargeImageKey = new System.Windows.Forms.TextBox();
			this.tbLargeImageText = new System.Windows.Forms.TextBox();
			this.tbSmallImageKey = new System.Windows.Forms.TextBox();
			this.tbSmallImageText = new System.Windows.Forms.TextBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.gbStatus.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbAppId
			// 
			this.tbAppId.Location = new System.Drawing.Point(22, 12);
			this.tbAppId.Name = "tbAppId";
			this.tbAppId.Size = new System.Drawing.Size(323, 22);
			this.tbAppId.TabIndex = 1;
			this.tbAppId.Text = "479021344625917953";
			this.tbAppId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbAppId_KeyUp);
			// 
			// gbStatus
			// 
			this.gbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbStatus.Controls.Add(this.tbSmallImageText);
			this.gbStatus.Controls.Add(this.tbSmallImageKey);
			this.gbStatus.Controls.Add(this.tbLargeImageText);
			this.gbStatus.Controls.Add(this.tbLargeImageKey);
			this.gbStatus.Controls.Add(this.ckbReplaceTimestamp);
			this.gbStatus.Controls.Add(this.tbState);
			this.gbStatus.Controls.Add(this.tbDetails);
			this.gbStatus.Controls.Add(this.btnOK);
			this.gbStatus.Controls.Add(this.ckbEnableStopTime);
			this.gbStatus.Controls.Add(this.mtbStopTime);
			this.gbStatus.Controls.Add(this.ckbMostrarTempo);
			this.gbStatus.Enabled = false;
			this.gbStatus.Location = new System.Drawing.Point(16, 45);
			this.gbStatus.Name = "gbStatus";
			this.gbStatus.Size = new System.Drawing.Size(329, 286);
			this.gbStatus.TabIndex = 2;
			this.gbStatus.TabStop = false;
			this.gbStatus.Text = "Status";
			// 
			// tbState
			// 
			this.tbState.Location = new System.Drawing.Point(6, 49);
			this.tbState.Name = "tbState";
			this.tbState.Size = new System.Drawing.Size(317, 22);
			this.tbState.TabIndex = 25;
			this.tbState.Text = "Canal: Experientes 1";
			// 
			// tbDetails
			// 
			this.tbDetails.Location = new System.Drawing.Point(6, 21);
			this.tbDetails.Name = "tbDetails";
			this.tbDetails.Size = new System.Drawing.Size(317, 22);
			this.tbDetails.TabIndex = 24;
			this.tbDetails.Text = "No Lobby";
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(6, 246);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(317, 34);
			this.btnOK.TabIndex = 21;
			this.btnOK.Text = "Confirmar";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// ckbEnableStopTime
			// 
			this.ckbEnableStopTime.AutoSize = true;
			this.ckbEnableStopTime.Enabled = false;
			this.ckbEnableStopTime.Location = new System.Drawing.Point(6, 81);
			this.ckbEnableStopTime.Name = "ckbEnableStopTime";
			this.ckbEnableStopTime.Size = new System.Drawing.Size(15, 14);
			this.ckbEnableStopTime.TabIndex = 18;
			this.ckbEnableStopTime.UseVisualStyleBackColor = true;
			this.ckbEnableStopTime.CheckedChanged += new System.EventHandler(this.ckbEnableStopTime_CheckedChanged);
			// 
			// mtbStopTime
			// 
			this.mtbStopTime.Enabled = false;
			this.mtbStopTime.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
			this.mtbStopTime.Location = new System.Drawing.Point(27, 77);
			this.mtbStopTime.Mask = "99:99:99";
			this.mtbStopTime.Name = "mtbStopTime";
			this.mtbStopTime.Size = new System.Drawing.Size(296, 22);
			this.mtbStopTime.TabIndex = 16;
			this.mtbStopTime.Text = "001000";
			// 
			// ckbMostrarTempo
			// 
			this.ckbMostrarTempo.AutoSize = true;
			this.ckbMostrarTempo.Checked = true;
			this.ckbMostrarTempo.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ckbMostrarTempo.Enabled = false;
			this.ckbMostrarTempo.Location = new System.Drawing.Point(180, 105);
			this.ckbMostrarTempo.Name = "ckbMostrarTempo";
			this.ckbMostrarTempo.Size = new System.Drawing.Size(109, 18);
			this.ckbMostrarTempo.TabIndex = 14;
			this.ckbMostrarTempo.Text = "Mostrar Tempo";
			this.ckbMostrarTempo.UseVisualStyleBackColor = true;
			this.ckbMostrarTempo.CheckedChanged += new System.EventHandler(this.ckbMostrarTempo_CheckedChanged);
			// 
			// ckbReplaceTimestamp
			// 
			this.ckbReplaceTimestamp.AutoSize = true;
			this.ckbReplaceTimestamp.Location = new System.Drawing.Point(58, 105);
			this.ckbReplaceTimestamp.Name = "ckbReplaceTimestamp";
			this.ckbReplaceTimestamp.Size = new System.Drawing.Size(116, 18);
			this.ckbReplaceTimestamp.TabIndex = 26;
			this.ckbReplaceTimestamp.Text = "Substitui Tempo";
			this.ckbReplaceTimestamp.UseVisualStyleBackColor = true;
			// 
			// tbLargeImageKey
			// 
			this.tbLargeImageKey.Location = new System.Drawing.Point(6, 129);
			this.tbLargeImageKey.Name = "tbLargeImageKey";
			this.tbLargeImageKey.Size = new System.Drawing.Size(317, 22);
			this.tbLargeImageKey.TabIndex = 27;
			this.tbLargeImageKey.Text = "warface";
			this.toolTip1.SetToolTip(this.tbLargeImageKey, "Large Image Key");
			// 
			// tbLargeImageText
			// 
			this.tbLargeImageText.Location = new System.Drawing.Point(6, 157);
			this.tbLargeImageText.Name = "tbLargeImageText";
			this.tbLargeImageText.Size = new System.Drawing.Size(317, 22);
			this.tbLargeImageText.TabIndex = 28;
			this.tbLargeImageText.Text = "Warface";
			this.toolTip1.SetToolTip(this.tbLargeImageText, "Large Image Text");
			// 
			// tbSmallImageKey
			// 
			this.tbSmallImageKey.Location = new System.Drawing.Point(6, 185);
			this.tbSmallImageKey.Name = "tbSmallImageKey";
			this.tbSmallImageKey.Size = new System.Drawing.Size(317, 22);
			this.tbSmallImageKey.TabIndex = 29;
			this.toolTip1.SetToolTip(this.tbSmallImageKey, "Small Image Key");
			// 
			// tbSmallImageText
			// 
			this.tbSmallImageText.Location = new System.Drawing.Point(6, 213);
			this.tbSmallImageText.Name = "tbSmallImageText";
			this.tbSmallImageText.Size = new System.Drawing.Size(317, 22);
			this.tbSmallImageText.TabIndex = 30;
			this.toolTip1.SetToolTip(this.tbSmallImageText, "Small Image Text");
			// 
			// MainForm
			// 
			this.AcceptButton = this.btnOK;
			this.ClientSize = new System.Drawing.Size(357, 343);
			this.Controls.Add(this.gbStatus);
			this.Controls.Add(this.tbAppId);
			this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Warface Rich Presence";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.gbStatus.ResumeLayout(false);
			this.gbStatus.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox tbAppId;
		private System.Windows.Forms.GroupBox gbStatus;
		private System.Windows.Forms.CheckBox ckbMostrarTempo;
		private System.Windows.Forms.MaskedTextBox mtbStopTime;
		private System.Windows.Forms.CheckBox ckbEnableStopTime;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.TextBox tbDetails;
		private System.Windows.Forms.TextBox tbState;
		private System.Windows.Forms.CheckBox ckbReplaceTimestamp;
		private System.Windows.Forms.TextBox tbSmallImageText;
		private System.Windows.Forms.TextBox tbSmallImageKey;
		private System.Windows.Forms.TextBox tbLargeImageText;
		private System.Windows.Forms.TextBox tbLargeImageKey;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}
