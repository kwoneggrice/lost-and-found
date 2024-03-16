using LostAndFound.Interfaces;
using LostAndFound.Models;
using LostAndFound.Utils;

namespace LostAndFound.Forms
{
	public partial class FormSignup : Form
	{

		#region FIELDS

		private const string COMPANY_CODE = "ADMIN";
		private readonly IUserService<User> _userService;

		#endregion

		#region CONSTRUCTOR

		public FormSignup(IUserService<User> userService)
		{
			InitializeComponent();
			_userService = userService;
		}

		#endregion

		#region EVENTS

		/// <summary>
		/// 회원가입 폼에서 회원가입 버튼을 눌렀을 때 이벤트 로직
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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

						_userService.CreateUser(user);
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

		/// <summary>
		/// 회원가입 폼에서 취소 버튼 눌렀을 때 이벤트 로직
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnCancle_Click(object sender, EventArgs e)
		{
			Close();
		}

		#endregion
	}
}
