namespace LostAndFound.Forms
{
	partial class FormSignup
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			btnSignup = new Button();
			btnCancle = new Button();
			tbUserId = new TextBox();
			tbPassword = new TextBox();
			tbCompanyCode = new TextBox();
			tableLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 1;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel1.Controls.Add(tbPassword, 0, 3);
			tableLayoutPanel1.Controls.Add(label1, 0, 0);
			tableLayoutPanel1.Controls.Add(label2, 0, 2);
			tableLayoutPanel1.Controls.Add(label3, 0, 4);
			tableLayoutPanel1.Controls.Add(tbUserId, 0, 1);
			tableLayoutPanel1.Controls.Add(btnCancle, 0, 7);
			tableLayoutPanel1.Controls.Add(btnSignup, 0, 6);
			tableLayoutPanel1.Controls.Add(tbCompanyCode, 0, 5);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(0, 0);
			tableLayoutPanel1.Margin = new Padding(10);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 8;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
			tableLayoutPanel1.Size = new Size(341, 415);
			tableLayoutPanel1.TabIndex = 0;
			tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Left;
			label1.AutoSize = true;
			label1.Location = new Point(10, 18);
			label1.Margin = new Padding(10);
			label1.Name = "label1";
			label1.Size = new Size(19, 15);
			label1.TabIndex = 0;
			label1.Text = "ID";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Left;
			label2.AutoSize = true;
			label2.Location = new Point(10, 120);
			label2.Margin = new Padding(10);
			label2.Name = "label2";
			label2.Size = new Size(57, 15);
			label2.TabIndex = 1;
			label2.Text = "Password";
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Left;
			label3.AutoSize = true;
			label3.Location = new Point(10, 222);
			label3.Margin = new Padding(10);
			label3.Name = "label3";
			label3.Size = new Size(55, 15);
			label3.TabIndex = 2;
			label3.Text = "기업코드";
			// 
			// btnSignup
			// 
			btnSignup.Dock = DockStyle.Fill;
			btnSignup.Location = new Point(10, 316);
			btnSignup.Margin = new Padding(10);
			btnSignup.Name = "btnSignup";
			btnSignup.Size = new Size(321, 31);
			btnSignup.TabIndex = 3;
			btnSignup.Text = "회원가입";
			btnSignup.UseVisualStyleBackColor = true;
			// 
			// btnCancle
			// 
			btnCancle.Dock = DockStyle.Fill;
			btnCancle.Location = new Point(10, 367);
			btnCancle.Margin = new Padding(10);
			btnCancle.Name = "btnCancle";
			btnCancle.Size = new Size(321, 38);
			btnCancle.TabIndex = 4;
			btnCancle.Text = "취소";
			btnCancle.UseVisualStyleBackColor = true;
			// 
			// tbUserId
			// 
			tbUserId.BackColor = Color.AliceBlue;
			tbUserId.Dock = DockStyle.Fill;
			tbUserId.Location = new Point(10, 61);
			tbUserId.Margin = new Padding(10);
			tbUserId.Name = "tbUserId";
			tbUserId.Size = new Size(321, 23);
			tbUserId.TabIndex = 5;
			// 
			// tbPassword
			// 
			tbPassword.Dock = DockStyle.Fill;
			tbPassword.Location = new Point(10, 163);
			tbPassword.Margin = new Padding(10);
			tbPassword.Name = "tbPassword";
			tbPassword.Size = new Size(321, 23);
			tbPassword.TabIndex = 6;
			// 
			// tbCompanyCode
			// 
			tbCompanyCode.Dock = DockStyle.Fill;
			tbCompanyCode.Location = new Point(10, 265);
			tbCompanyCode.Margin = new Padding(10);
			tbCompanyCode.Name = "tbCompanyCode";
			tbCompanyCode.Size = new Size(321, 23);
			tbCompanyCode.TabIndex = 7;
			// 
			// FormSignup
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(341, 415);
			Controls.Add(tableLayoutPanel1);
			Name = "FormSignup";
			Text = "회원가입";
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox tbPassword;
		private TextBox tbUserId;
		private Button btnCancle;
		private Button btnSignup;
		private TextBox tbCompanyCode;
	}
}