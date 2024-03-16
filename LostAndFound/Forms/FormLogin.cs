using LostAndFound.Services;
using LostAndFound.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LostAndFound.Forms
{
	public partial class FormLogin : Form
	{
		#region FIELDS

		private readonly FormSignup _formSignup;
		private readonly UserService _userService;

		#endregion

		#region CONSTRUCTOR

		public FormLogin(FormSignup formSignup, UserService userService)
		{
			InitializeComponent();
			_formSignup = formSignup;
			_userService = userService;
		}

		#endregion

		#region EVENTS

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string userId = tbUserId.Text;
			string password = PasswordUtil.HasingPassword(tbPassword.Text);

			var data = _userService.GetUser(userId);

			if (!string.IsNullOrWhiteSpace(tbUserId.Text) && !string.IsNullOrWhiteSpace(tbPassword.Text))
			{
				if (data != null)
				{
					if (data.Password != password)
					{
						MessageBox.Show("Password를 다시 확인해주세요.", "알림");
					}
					else
					{
						if (data.UserId.Equals(userId) && data.Password.Equals(password))
						{
							Program.IsLogin = true;
							Close();
						}
					}
				}
				else
				{
					MessageBox.Show("해당 ID는 존재하지 않습니다.", "알림");
				}
			}
			else
			{
				MessageBox.Show("모든 항목을 입력해주세요.", "알림");
			}
		}

		private void btnSignup_Click(object sender, EventArgs e)
		{
			_formSignup.ShowDialog();
		}

		#endregion
	}
}
