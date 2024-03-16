using LostAndFound.Interfaces;
using LostAndFound.Models;
using LostAndFound.Utils;

namespace LostAndFound.Forms
{
	public partial class FormLogin : Form
	{
		#region FIELDS

		private readonly FormSignup _formSignup;
		private readonly IUserService<User> _userService;

		#endregion

		#region CONSTRUCTOR

		public FormLogin(FormSignup formSignup, IUserService<User> userService)
		{
			InitializeComponent();
			_formSignup = formSignup;
			_userService = userService;
		}

		#endregion

		#region EVENTS

		/// <summary>
		/// 로그인 폼에서 로그인 버튼 눌렀을 때 이벤트 로직
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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

		/// <summary>
		/// 로그인 폼에서 회원가입 버튼 눌렀을 때 이벤트 로직
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSignup_Click(object sender, EventArgs e)
		{
			_formSignup.ShowDialog();
		}

		#endregion
	}
}
