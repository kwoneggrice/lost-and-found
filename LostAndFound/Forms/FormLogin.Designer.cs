namespace LostAndFound.Forms
{
	partial class FormLogin
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
			tableLayoutPanel1 = new TableLayoutPanel();
			tableLayoutPanel2 = new TableLayoutPanel();
			tbPassword = new TextBox();
			btnLogin = new Button();
			btnSignup = new Button();
			label1 = new Label();
			label2 = new Label();
			tbUserId = new TextBox();
			label3 = new Label();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 304F));
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
			tableLayoutPanel1.Controls.Add(label3, 0, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel1.Size = new Size(800, 450);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 1;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.Controls.Add(tbPassword, 0, 3);
			tableLayoutPanel2.Controls.Add(btnLogin, 0, 4);
			tableLayoutPanel2.Controls.Add(btnSignup, 0, 5);
			tableLayoutPanel2.Controls.Add(label1, 0, 0);
			tableLayoutPanel2.Controls.Add(label2, 0, 2);
			tableLayoutPanel2.Controls.Add(tbUserId, 0, 1);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(499, 3);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 6;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanel2.Size = new Size(298, 444);
			tableLayoutPanel2.TabIndex = 0;
			// 
			// tbPassword
			// 
			tbPassword.Dock = DockStyle.Fill;
			tbPassword.Location = new Point(10, 232);
			tbPassword.Margin = new Padding(10);
			tbPassword.Name = "tbPassword";
			tbPassword.Size = new Size(278, 23);
			tbPassword.TabIndex = 5;
			// 
			// btnLogin
			// 
			btnLogin.Dock = DockStyle.Fill;
			btnLogin.Location = new Point(10, 306);
			btnLogin.Margin = new Padding(10);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(278, 54);
			btnLogin.TabIndex = 0;
			btnLogin.Text = "로그인";
			btnLogin.UseVisualStyleBackColor = true;
			// 
			// btnSignup
			// 
			btnSignup.Dock = DockStyle.Fill;
			btnSignup.Location = new Point(10, 380);
			btnSignup.Margin = new Padding(10);
			btnSignup.Name = "btnSignup";
			btnSignup.Size = new Size(278, 54);
			btnSignup.TabIndex = 1;
			btnSignup.Text = "회원가입";
			btnSignup.UseVisualStyleBackColor = true;
			btnSignup.Click += btnSignup_Click;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Left;
			label1.AutoSize = true;
			label1.Location = new Point(10, 29);
			label1.Margin = new Padding(10);
			label1.Name = "label1";
			label1.Size = new Size(19, 15);
			label1.TabIndex = 2;
			label1.Text = "ID";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Left;
			label2.AutoSize = true;
			label2.Location = new Point(10, 177);
			label2.Margin = new Padding(10);
			label2.Name = "label2";
			label2.Size = new Size(57, 15);
			label2.TabIndex = 3;
			label2.Text = "Password";
			// 
			// tbUserId
			// 
			tbUserId.Dock = DockStyle.Fill;
			tbUserId.Location = new Point(10, 84);
			tbUserId.Margin = new Padding(10);
			tbUserId.Name = "tbUserId";
			tbUserId.Size = new Size(278, 23);
			tbUserId.TabIndex = 4;
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.None;
			label3.AutoSize = true;
			label3.Font = new Font("맑은 고딕", 20F);
			label3.Location = new Point(167, 206);
			label3.Name = "label3";
			label3.Size = new Size(161, 37);
			label3.TabIndex = 1;
			label3.Text = "기업 이미지";
			// 
			// FormLogin
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(tableLayoutPanel1);
			Name = "FormLogin";
			Text = "로그인";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel2;
		private TextBox tbPassword;
		private Button btnLogin;
		private Button btnSignup;
		private Label label1;
		private Label label2;
		private TextBox tbUserId;
		private Label label3;
	}
}