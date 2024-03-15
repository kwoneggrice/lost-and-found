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
		#region FEILDES

		private readonly FormSignup _formSignup;

		#endregion

		#region CONSTRUCTOR

		public FormLogin(FormSignup formSignup)
		{
			InitializeComponent();
			_formSignup = formSignup;
		}

		#endregion

		private void btnSignup_Click(object sender, EventArgs e)
		{
			_formSignup.ShowDialog();
		}
	}
}
