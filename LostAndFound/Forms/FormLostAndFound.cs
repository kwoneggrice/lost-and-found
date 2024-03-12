using LostAndFound.Interfaces;
using LostAndFound.Models;
using System.Data;

namespace LostAndFound.Forms
{
	public partial class FormLostAndFound : Form
	{
		#region FIELDS

		private readonly IQuery<LostInfo> _iQuery;
		private readonly LostAndFoundContext _lostAndFoundContext;

		#endregion

		#region CONSTRUCT

		public FormLostAndFound(IQuery<LostInfo> iQuery, LostAndFoundContext lostAndFoundContext)
		{
			InitializeComponent();

			_iQuery = iQuery;
			_lostAndFoundContext = lostAndFoundContext;

			pieChartByLocation.Titles.Add("지역별 분실물 비율");
			pieChartByLostItem.Titles.Add("분실물 종류 비율");
			pieChartByFoundOrNot.Titles.Add("분실물 회수 비율");

			ShowPieChartByLocation();
			ShowPieChartByLostItem();
			ShowPieChartByFoundOrNot();
		}

		#endregion

		#region METHODS

		/// <summary>
		/// 선택한 행의 id 컬럼 값을 가져오는 메소드
		/// </summary>
		/// <returns></returns>
		public long? GetRowId()
		{
			if (dgvLostInfos.SelectedRows.Count == 0)
			{
				MessageBox.Show("분실물 정보를 선택하세요.");

				return null;
			}
			else
			{
				long targetId = Convert.ToInt64(dgvLostInfos.SelectedRows[0].Cells["id"].Value.ToString());

				return targetId;
			}
		}

		/// <summary>
		/// 모든 input 요소를 빈 값으로 초기화
		/// </summary>
		public void ClearInputElement()
		{
			tbAcquirerName.Text = "";
			tbLostItem.Text = "";
			tbOwnerName.Text = "";
			cbLostLocation.SelectedIndex = -1;
			dtpLostDate.Value = DateTime.Today.Date;
		}

		/// <summary>
		/// 테이블 값을 모두 읽어와 DataGridView에 바인딩
		/// </summary>
		public void RefreshDataGridView()
		{
			var datas = _iQuery.GetAll();
			dgvLostInfos.DataSource = datas;
		}

		/// <summary>
		/// 지역별 분실물 비용 원형차트 그리는 메소드
		/// </summary>
		private void ShowPieChartByLocation()
		{
			var datas = _lostAndFoundContext.LostInfos
				.GroupBy(x => x.LostLocation)
				.Select(x => new
				{
					Location = x.Key,
					Count = x.Count()
				})
				.ToList();

			pieChartByLocation.Series.Clear();
			pieChartByLocation.Series.Add("지역별 분실물 비율");
			pieChartByLocation.Series["지역별 분실물 비율"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

			int totaldatas = datas.Sum(x => x.Count);

			foreach (var count in datas)
			{
				double percentage = (count.Count / (double)totaldatas) * 100;
				pieChartByLocation.Series["지역별 분실물 비율"].Points.AddXY(count.Location, percentage);
			}
		}

		/// <summary>
		/// 분실물 종류 비율 원형차트 그리는 메소드
		/// </summary>
		public void ShowPieChartByLostItem()
		{
			var datas = _lostAndFoundContext.LostInfos
				.GroupBy(x => x.LostItem)
				.Select(x => new
				{
					LostItem = x.Key,
					Count = x.Count()
				})
				.ToList();

			pieChartByLostItem.Series.Clear();
			pieChartByLostItem.Series.Add("분실물 종류 비율");
			pieChartByLostItem.Series["분실물 종류 비율"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

			int totaldatas = datas.Sum(x => x.Count);

			foreach (var count in datas)
			{
				double percentage = (count.Count / (double)totaldatas) * 100;
				pieChartByLostItem.Series["분실물 종류 비율"].Points.AddXY(count.LostItem, percentage);
			}
		}

		/// <summary>
		/// 분실물 회수 비율 원형차트 그리는 메소드
		/// </summary>
		public void ShowPieChartByFoundOrNot()
		{
			var datas = _lostAndFoundContext.LostInfos
				.GroupBy(x => x.FoundDate == null ? "미회수" : "회수")
				.Select(x => new
				{
					FoundDate = x.Key,
					Count = x.Count()
				})
				.ToList();

			pieChartByFoundOrNot.Series.Clear();
			pieChartByFoundOrNot.Series.Add("분실물 회수 비율");
			pieChartByFoundOrNot.Series["분실물 회수 비율"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

			int totaldatas = datas.Sum(x => x.Count);

			foreach (var count in datas)
			{
				double percentage = (count.Count / (double)totaldatas) * 100;
				pieChartByFoundOrNot.Series["분실물 회수 비율"].Points.AddXY(count.FoundDate, percentage);
			}
		}

		#endregion

		#region EVENTS

		/// <summary>
		/// 테이블의 모든 값 읽어와 DataGridView에 바인딩하는 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSearchAll_Click(object sender, EventArgs e)
		{
			ClearInputElement();
			RefreshDataGridView();
		}

		/// <summary>
		/// 해당 날짜에 등록된 값을 읽어와 DataGridView에 바인딩하는 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSearchByDate_Click(object sender, EventArgs e)
		{
			var datas = _iQuery.GetAllByDateTime(dtpLostDate.Value.Date);
			dgvLostInfos.DataSource = datas;
		}

		/// <summary>
		/// DataGridView의 행을 선택해 행의 값을 input 요소에 바인딩하는 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dgvLostInfos_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow selectedRow = dgvLostInfos.Rows[e.RowIndex];

				string? lostItem = selectedRow.Cells["LostItem"].Value.ToString();
				string? lostLocation = selectedRow.Cells["LostLocation"].Value.ToString();
				string? acquirerName = selectedRow.Cells["AcquirerName"].Value.ToString();
				string? ownerName = selectedRow.Cells["OwnerName"].Value?.ToString();
				DateTime lostDate = Convert.ToDateTime(selectedRow.Cells["LostDate"].Value);

				tbLostItem.Text = lostItem;
				cbLostLocation.Text = lostLocation;
				tbAcquirerName.Text = acquirerName;
				tbOwnerName.Text = ownerName;
				dtpLostDate.Value = lostDate;
			}
		}

		/// <summary>
		/// input 요소를 기본값으로 초기화하는 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnClear_Click(object sender, EventArgs e)
		{
			ClearInputElement();
		}

		/// <summary>
		/// 분실물 등록 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnCreate_Click(object sender, EventArgs e)
		{


			if (!string.IsNullOrWhiteSpace(tbLostItem.Text) && !string.IsNullOrWhiteSpace(cbLostLocation.Text)
				&& !string.IsNullOrWhiteSpace(tbAcquirerName.Text) && string.IsNullOrWhiteSpace(tbOwnerName.Text))
			{
				DialogResult result = MessageBox.Show("분실물 정보를 등록하시겠습니까?", "알림", MessageBoxButtons.OKCancel);

				if (result == DialogResult.OK)
				{
					string lostItem = tbLostItem.Text;
					string lostLocation = cbLostLocation.Text;
					string acquirerName = tbAcquirerName.Text;
					DateTime lostDate = dtpLostDate.Value.Date;

					LostInfo entity = new()
					{
						LostItem = lostItem,
						LostLocation = lostLocation,
						AcquirerName = acquirerName,
						LostDate = lostDate
					};

					_iQuery.Create(entity);

					ClearInputElement();
					RefreshDataGridView();
				}
			}
			else
			{
				MessageBox.Show("수령자 이름을 제외한 모든 값을 입력해 주세요.", "알림");
			}
		}

		/// <summary>
		/// 분실물 정보 업데이트 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			long? targetId = GetRowId();

			if (targetId != null)
			{
				DialogResult result = MessageBox.Show("분실물 정보를 수정하시겠습니까?", "알림", MessageBoxButtons.OKCancel);

				if (result == DialogResult.OK)
				{
					var data = _iQuery.GetDetail(targetId);

					data.LostItem = tbLostItem.Text;
					data.LostLocation = cbLostLocation.Text;
					data.AcquirerName = tbAcquirerName.Text;
					data.LostDate = dtpLostDate.Value.Date;
					data.OwnerName = tbOwnerName.Text;

					_iQuery.Update(data);

					ClearInputElement();
					RefreshDataGridView();
				}
			}
		}

		/// <summary>
		/// 분실물 정보 삭제 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnDelete_Click(object sender, EventArgs e)
		{
			long? targetId = GetRowId();

			if (targetId != null)
			{
				DialogResult result = MessageBox.Show("분실물 정보를 삭제하시겠습니까?", "알림", MessageBoxButtons.OKCancel);

				if (result == DialogResult.OK)
				{
					_iQuery.Delete(targetId);

					ClearInputElement();
					RefreshDataGridView();
				}
			}
		}

		/// <summary>
		/// 분실물 주인이 분실물을 회수했을 때 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnReturnToOwner_Click(object sender, EventArgs e)
		{
			long? targetId = GetRowId();

			if (targetId != null)
			{
				if (!string.IsNullOrWhiteSpace(tbOwnerName.Text))
				{
					DialogResult result = MessageBox.Show("분실물 주인이 확실합니까?", "알림", MessageBoxButtons.OKCancel);

					if (result == DialogResult.OK)
					{
						var data = _iQuery.GetDetail(targetId);

						data.LostItem = tbLostItem.Text;
						data.LostLocation = cbLostLocation.Text;
						data.AcquirerName = tbAcquirerName.Text;
						data.LostDate = dtpLostDate.Value.Date;
						data.OwnerName = tbOwnerName.Text;
						data.FoundDate = DateTime.Now.Date;

						_iQuery.Update(data);

						ClearInputElement();
						RefreshDataGridView();
					}
				}
				else
				{
					MessageBox.Show("수령자 이름을 입력해주세요.", "알림");
				}
			}
		}

		/// <summary>
		/// DB의 값이 변경된 경우 원형차트를 갱신하는 이벤트
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			ShowPieChartByLocation();
			ShowPieChartByLostItem();
			ShowPieChartByFoundOrNot();
		}

		#endregion
	}
}
