using LostAndFound.Models;
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
	public partial class FormSignup : Form
	{

		#region FIELDS

		private const string COMPANY_CODE = "ADMIN";
		private readonly UserService _userService;

		#endregion


		#region CONSTRUCTOR

		public FormSignup(UserService userService)
		{
			InitializeComponent();
			_userService = userService;
		}

		#endregion

		#region EVENTS

		private void btnSignup_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(tbUserId.Text) && !string.IsNullOrWhiteSpace(tbPassword.Text)
			&& !string.IsNullOrWhiteSpace(tbCompanyCode.Text))
			{
				if (tbCompanyCode.Text.Equals(COMPANY_CODE))
				{
					string userId = tbUserId.Text;
					string password = PasswordUtil.HasingPassword(tbPassword.Text);

					var data = _userService.GetUser(userId);

					if (data == null)
					{
						User user = new()
						{
							UserId = userId,
							Password = password
						};

						_userService.Signup(user);
					}
					else
					{
						MessageBox.Show("해당 ID는 이미 존재합니다.");
					}
				}
				else
				{
					MessageBox.Show("기업코드가 일치하지 않습니다.", "알림");
				}
			}
			else
			{
				MessageBox.Show("모든 항목을 입력해주세요.", "알림");
			}
		}

		#endregion

		private void btnCancle_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
