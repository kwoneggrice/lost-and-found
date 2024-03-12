namespace LostAndFound.Forms
{
	partial class FormLostAndFound
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
			tabControl1 = new TabControl();
			tabPage1 = new TabPage();
			tableLayoutPanel6 = new TableLayoutPanel();
			tableLayoutPanel7 = new TableLayoutPanel();
			pieChartByLostItem = new System.Windows.Forms.DataVisualization.Charting.Chart();
			pieChartByLocation = new System.Windows.Forms.DataVisualization.Charting.Chart();
			pieChartByFoundOrNot = new System.Windows.Forms.DataVisualization.Charting.Chart();
			tableLayoutPanel9 = new TableLayoutPanel();
			btnRefresh = new Button();
			tabPage2 = new TabPage();
			tableLayoutPanel4 = new TableLayoutPanel();
			tableLayoutPanel1 = new TableLayoutPanel();
			tableLayoutPanel2 = new TableLayoutPanel();
			tbOwnerName = new TextBox();
			label5 = new Label();
			label2 = new Label();
			label3 = new Label();
			tbLostItem = new TextBox();
			cbLostLocation = new ComboBox();
			label1 = new Label();
			dtpLostDate = new DateTimePicker();
			label4 = new Label();
			tbAcquirerName = new TextBox();
			btnClear = new Button();
			tableLayoutPanel3 = new TableLayoutPanel();
			dgvLostInfos = new DataGridView();
			tableLayoutPanel5 = new TableLayoutPanel();
			btnSearchAll = new Button();
			btnReturnToOwner = new Button();
			btnDelete = new Button();
			btnUpdate = new Button();
			btnCreate = new Button();
			btnSearchByDate = new Button();
			tableLayoutPanel8 = new TableLayoutPanel();
			tabControl1.SuspendLayout();
			tabPage1.SuspendLayout();
			tableLayoutPanel6.SuspendLayout();
			tableLayoutPanel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pieChartByLostItem).BeginInit();
			((System.ComponentModel.ISupportInitialize)pieChartByLocation).BeginInit();
			((System.ComponentModel.ISupportInitialize)pieChartByFoundOrNot).BeginInit();
			tableLayoutPanel9.SuspendLayout();
			tabPage2.SuspendLayout();
			tableLayoutPanel4.SuspendLayout();
			tableLayoutPanel1.SuspendLayout();
			tableLayoutPanel2.SuspendLayout();
			tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvLostInfos).BeginInit();
			tableLayoutPanel5.SuspendLayout();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(tabPage1);
			tabControl1.Controls.Add(tabPage2);
			tabControl1.Dock = DockStyle.Fill;
			tabControl1.Location = new Point(0, 0);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(984, 561);
			tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(tableLayoutPanel6);
			tabPage1.Location = new Point(4, 24);
			tabPage1.Name = "tabPage1";
			tabPage1.Padding = new Padding(3);
			tabPage1.Size = new Size(976, 533);
			tabPage1.TabIndex = 0;
			tabPage1.Text = "대시보드";
			tabPage1.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel6
			// 
			tableLayoutPanel6.ColumnCount = 1;
			tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 16F));
			tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 16F));
			tableLayoutPanel6.Controls.Add(tableLayoutPanel7, 0, 0);
			tableLayoutPanel6.Controls.Add(tableLayoutPanel9, 0, 1);
			tableLayoutPanel6.Dock = DockStyle.Fill;
			tableLayoutPanel6.Location = new Point(3, 3);
			tableLayoutPanel6.Margin = new Padding(2);
			tableLayoutPanel6.Name = "tableLayoutPanel6";
			tableLayoutPanel6.RowCount = 2;
			tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
			tableLayoutPanel6.Size = new Size(970, 527);
			tableLayoutPanel6.TabIndex = 0;
			// 
			// tableLayoutPanel7
			// 
			tableLayoutPanel7.ColumnCount = 3;
			tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
			tableLayoutPanel7.Controls.Add(pieChartByLostItem, 0, 0);
			tableLayoutPanel7.Controls.Add(pieChartByLocation, 1, 0);
			tableLayoutPanel7.Controls.Add(pieChartByFoundOrNot, 2, 0);
			tableLayoutPanel7.Dock = DockStyle.Fill;
			tableLayoutPanel7.Location = new Point(2, 2);
			tableLayoutPanel7.Margin = new Padding(2);
			tableLayoutPanel7.Name = "tableLayoutPanel7";
			tableLayoutPanel7.RowCount = 1;
			tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 454F));
			tableLayoutPanel7.Size = new Size(966, 451);
			tableLayoutPanel7.TabIndex = 0;
			// 
			// pieChartByLostItem
			// 
			chartArea4.Name = "ChartArea1";
			pieChartByLostItem.ChartAreas.Add(chartArea4);
			pieChartByLostItem.Dock = DockStyle.Fill;
			legend4.Name = "Legend1";
			pieChartByLostItem.Legends.Add(legend4);
			pieChartByLostItem.Location = new Point(8, 8);
			pieChartByLostItem.Margin = new Padding(8);
			pieChartByLostItem.Name = "pieChartByLostItem";
			series4.ChartArea = "ChartArea1";
			series4.Legend = "Legend1";
			series4.Name = "Series1";
			pieChartByLostItem.Series.Add(series4);
			pieChartByLostItem.Size = new Size(305, 435);
			pieChartByLostItem.TabIndex = 0;
			pieChartByLostItem.Text = "chart1";
			// 
			// pieChartByLocation
			// 
			chartArea5.Name = "ChartArea1";
			pieChartByLocation.ChartAreas.Add(chartArea5);
			pieChartByLocation.Dock = DockStyle.Fill;
			legend5.Name = "Legend1";
			pieChartByLocation.Legends.Add(legend5);
			pieChartByLocation.Location = new Point(329, 8);
			pieChartByLocation.Margin = new Padding(8);
			pieChartByLocation.Name = "pieChartByLocation";
			series5.ChartArea = "ChartArea1";
			series5.Legend = "Legend1";
			series5.Name = "Series1";
			pieChartByLocation.Series.Add(series5);
			pieChartByLocation.Size = new Size(305, 435);
			pieChartByLocation.TabIndex = 1;
			pieChartByLocation.Text = "chart2";
			// 
			// pieChartByFoundOrNot
			// 
			chartArea6.Name = "ChartArea1";
			pieChartByFoundOrNot.ChartAreas.Add(chartArea6);
			pieChartByFoundOrNot.Dock = DockStyle.Fill;
			legend6.Name = "Legend1";
			pieChartByFoundOrNot.Legends.Add(legend6);
			pieChartByFoundOrNot.Location = new Point(650, 8);
			pieChartByFoundOrNot.Margin = new Padding(8);
			pieChartByFoundOrNot.Name = "pieChartByFoundOrNot";
			series6.ChartArea = "ChartArea1";
			series6.Legend = "Legend1";
			series6.Name = "Series1";
			pieChartByFoundOrNot.Series.Add(series6);
			pieChartByFoundOrNot.Size = new Size(308, 435);
			pieChartByFoundOrNot.TabIndex = 2;
			pieChartByFoundOrNot.Text = "chart3";
			// 
			// tableLayoutPanel9
			// 
			tableLayoutPanel9.ColumnCount = 1;
			tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel9.Controls.Add(btnRefresh, 0, 0);
			tableLayoutPanel9.Dock = DockStyle.Fill;
			tableLayoutPanel9.Location = new Point(2, 457);
			tableLayoutPanel9.Margin = new Padding(2);
			tableLayoutPanel9.Name = "tableLayoutPanel9";
			tableLayoutPanel9.RowCount = 1;
			tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel9.Size = new Size(966, 68);
			tableLayoutPanel9.TabIndex = 1;
			// 
			// btnRefresh
			// 
			btnRefresh.Dock = DockStyle.Fill;
			btnRefresh.Location = new Point(8, 8);
			btnRefresh.Margin = new Padding(8);
			btnRefresh.Name = "btnRefresh";
			btnRefresh.Size = new Size(950, 52);
			btnRefresh.TabIndex = 0;
			btnRefresh.Text = "새로고침";
			btnRefresh.UseVisualStyleBackColor = true;
			btnRefresh.Click += btnRefresh_Click;
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(tableLayoutPanel4);
			tabPage2.Location = new Point(4, 24);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(976, 533);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "분실물 관리";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel4
			// 
			tableLayoutPanel4.ColumnCount = 1;
			tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel4.Controls.Add(tableLayoutPanel1, 0, 0);
			tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 1);
			tableLayoutPanel4.Dock = DockStyle.Fill;
			tableLayoutPanel4.Location = new Point(3, 3);
			tableLayoutPanel4.Name = "tableLayoutPanel4";
			tableLayoutPanel4.RowCount = 2;
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 91F));
			tableLayoutPanel4.Size = new Size(970, 527);
			tableLayoutPanel4.TabIndex = 1;
			// 
			// tableLayoutPanel1
			// 
			tableLayoutPanel1.ColumnCount = 2;
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.80916F));
			tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.19084F));
			tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
			tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
			tableLayoutPanel1.Dock = DockStyle.Fill;
			tableLayoutPanel1.Location = new Point(3, 3);
			tableLayoutPanel1.Name = "tableLayoutPanel1";
			tableLayoutPanel1.RowCount = 1;
			tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89.56357F));
			tableLayoutPanel1.Size = new Size(964, 430);
			tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 1;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel2.Controls.Add(tbOwnerName, 0, 9);
			tableLayoutPanel2.Controls.Add(label5, 0, 8);
			tableLayoutPanel2.Controls.Add(label2, 0, 0);
			tableLayoutPanel2.Controls.Add(label3, 0, 2);
			tableLayoutPanel2.Controls.Add(tbLostItem, 0, 1);
			tableLayoutPanel2.Controls.Add(cbLostLocation, 0, 3);
			tableLayoutPanel2.Controls.Add(label1, 0, 6);
			tableLayoutPanel2.Controls.Add(dtpLostDate, 0, 7);
			tableLayoutPanel2.Controls.Add(label4, 0, 4);
			tableLayoutPanel2.Controls.Add(tbAcquirerName, 0, 5);
			tableLayoutPanel2.Controls.Add(btnClear, 0, 10);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(724, 3);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 11;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
			tableLayoutPanel2.Size = new Size(237, 424);
			tableLayoutPanel2.TabIndex = 0;
			// 
			// tbOwnerName
			// 
			tbOwnerName.Dock = DockStyle.Fill;
			tbOwnerName.Location = new Point(6, 348);
			tbOwnerName.Margin = new Padding(6);
			tbOwnerName.Name = "tbOwnerName";
			tbOwnerName.Size = new Size(225, 23);
			tbOwnerName.TabIndex = 9;
			// 
			// label5
			// 
			label5.Anchor = AnchorStyles.Left;
			label5.AutoSize = true;
			label5.Location = new Point(6, 315);
			label5.Margin = new Padding(6, 0, 6, 0);
			label5.Name = "label5";
			label5.Size = new Size(71, 15);
			label5.TabIndex = 8;
			label5.Text = "수령자 이름";
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Left;
			label2.AutoSize = true;
			label2.Location = new Point(6, 11);
			label2.Margin = new Padding(6, 0, 6, 0);
			label2.Name = "label2";
			label2.Size = new Size(71, 15);
			label2.TabIndex = 0;
			label2.Text = "분실물 종류";
			// 
			// label3
			// 
			label3.Anchor = AnchorStyles.Left;
			label3.AutoSize = true;
			label3.Location = new Point(6, 87);
			label3.Margin = new Padding(6, 0, 6, 0);
			label3.Name = "label3";
			label3.Size = new Size(59, 15);
			label3.TabIndex = 1;
			label3.Text = "분실 위치";
			// 
			// tbLostItem
			// 
			tbLostItem.Dock = DockStyle.Fill;
			tbLostItem.Location = new Point(6, 44);
			tbLostItem.Margin = new Padding(6);
			tbLostItem.Name = "tbLostItem";
			tbLostItem.Size = new Size(225, 23);
			tbLostItem.TabIndex = 2;
			// 
			// cbLostLocation
			// 
			cbLostLocation.Dock = DockStyle.Fill;
			cbLostLocation.DropDownStyle = ComboBoxStyle.DropDownList;
			cbLostLocation.FormattingEnabled = true;
			cbLostLocation.Items.AddRange(new object[] { "동천동", "상현1동", "상현2동", "상현3동", "신봉동", "성복동", "죽전1동", "죽전2동", "죽전3동", "풍덕천1동", "풍덕천2동" });
			cbLostLocation.Location = new Point(6, 120);
			cbLostLocation.Margin = new Padding(6);
			cbLostLocation.Name = "cbLostLocation";
			cbLostLocation.Size = new Size(225, 23);
			cbLostLocation.TabIndex = 3;
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Left;
			label1.AutoSize = true;
			label1.Location = new Point(6, 239);
			label1.Margin = new Padding(6, 0, 6, 0);
			label1.Name = "label1";
			label1.Size = new Size(59, 15);
			label1.TabIndex = 4;
			label1.Text = "습득 날짜";
			// 
			// dtpLostDate
			// 
			dtpLostDate.CustomFormat = "";
			dtpLostDate.Dock = DockStyle.Fill;
			dtpLostDate.Location = new Point(6, 272);
			dtpLostDate.Margin = new Padding(6);
			dtpLostDate.Name = "dtpLostDate";
			dtpLostDate.Size = new Size(225, 23);
			dtpLostDate.TabIndex = 5;
			// 
			// label4
			// 
			label4.Anchor = AnchorStyles.Left;
			label4.AutoSize = true;
			label4.Location = new Point(6, 163);
			label4.Margin = new Padding(6, 0, 6, 0);
			label4.Name = "label4";
			label4.Size = new Size(71, 15);
			label4.TabIndex = 6;
			label4.Text = "습득자 이름";
			// 
			// tbAcquirerName
			// 
			tbAcquirerName.Dock = DockStyle.Fill;
			tbAcquirerName.Location = new Point(6, 196);
			tbAcquirerName.Margin = new Padding(6);
			tbAcquirerName.Name = "tbAcquirerName";
			tbAcquirerName.Size = new Size(225, 23);
			tbAcquirerName.TabIndex = 7;
			// 
			// btnClear
			// 
			btnClear.Dock = DockStyle.Fill;
			btnClear.Location = new Point(6, 386);
			btnClear.Margin = new Padding(6);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(225, 32);
			btnClear.TabIndex = 10;
			btnClear.Text = "입력값 초기화";
			btnClear.UseVisualStyleBackColor = true;
			btnClear.Click += btnClear_Click;
			// 
			// tableLayoutPanel3
			// 
			tableLayoutPanel3.ColumnCount = 1;
			tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Controls.Add(dgvLostInfos, 0, 0);
			tableLayoutPanel3.Dock = DockStyle.Fill;
			tableLayoutPanel3.Location = new Point(3, 3);
			tableLayoutPanel3.Name = "tableLayoutPanel3";
			tableLayoutPanel3.RowCount = 1;
			tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel3.Size = new Size(715, 424);
			tableLayoutPanel3.TabIndex = 1;
			// 
			// dgvLostInfos
			// 
			dgvLostInfos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvLostInfos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvLostInfos.Dock = DockStyle.Fill;
			dgvLostInfos.Location = new Point(10, 10);
			dgvLostInfos.Margin = new Padding(10);
			dgvLostInfos.Name = "dgvLostInfos";
			dgvLostInfos.RowHeadersWidth = 51;
			dgvLostInfos.Size = new Size(695, 404);
			dgvLostInfos.TabIndex = 0;
			dgvLostInfos.CellClick += dgvLostInfos_CellClick;
			// 
			// tableLayoutPanel5
			// 
			tableLayoutPanel5.ColumnCount = 6;
			tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
			tableLayoutPanel5.Controls.Add(btnSearchAll, 0, 0);
			tableLayoutPanel5.Controls.Add(btnReturnToOwner, 5, 0);
			tableLayoutPanel5.Controls.Add(btnDelete, 4, 0);
			tableLayoutPanel5.Controls.Add(btnUpdate, 3, 0);
			tableLayoutPanel5.Controls.Add(btnCreate, 2, 0);
			tableLayoutPanel5.Controls.Add(btnSearchByDate, 1, 0);
			tableLayoutPanel5.Dock = DockStyle.Fill;
			tableLayoutPanel5.Location = new Point(3, 439);
			tableLayoutPanel5.Name = "tableLayoutPanel5";
			tableLayoutPanel5.RowCount = 1;
			tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			tableLayoutPanel5.Size = new Size(964, 85);
			tableLayoutPanel5.TabIndex = 1;
			// 
			// btnSearchAll
			// 
			btnSearchAll.Dock = DockStyle.Fill;
			btnSearchAll.Location = new Point(10, 10);
			btnSearchAll.Margin = new Padding(10);
			btnSearchAll.Name = "btnSearchAll";
			btnSearchAll.Size = new Size(140, 65);
			btnSearchAll.TabIndex = 6;
			btnSearchAll.Text = "전체 분실물 조회";
			btnSearchAll.UseVisualStyleBackColor = true;
			btnSearchAll.Click += btnSearchAll_Click;
			// 
			// btnReturnToOwner
			// 
			btnReturnToOwner.Dock = DockStyle.Fill;
			btnReturnToOwner.Location = new Point(808, 8);
			btnReturnToOwner.Margin = new Padding(8);
			btnReturnToOwner.Name = "btnReturnToOwner";
			btnReturnToOwner.Size = new Size(148, 69);
			btnReturnToOwner.TabIndex = 9;
			btnReturnToOwner.Text = "주인 품으로~";
			btnReturnToOwner.UseVisualStyleBackColor = true;
			btnReturnToOwner.Click += btnReturnToOwner_Click;
			// 
			// btnDelete
			// 
			btnDelete.Dock = DockStyle.Fill;
			btnDelete.Location = new Point(648, 8);
			btnDelete.Margin = new Padding(8);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(144, 69);
			btnDelete.TabIndex = 10;
			btnDelete.Text = "분실물 정보 삭제";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnUpdate
			// 
			btnUpdate.Dock = DockStyle.Fill;
			btnUpdate.Location = new Point(490, 10);
			btnUpdate.Margin = new Padding(10);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(140, 65);
			btnUpdate.TabIndex = 8;
			btnUpdate.Text = "분실물 정보 수정";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// btnCreate
			// 
			btnCreate.Dock = DockStyle.Fill;
			btnCreate.Location = new Point(330, 10);
			btnCreate.Margin = new Padding(10);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new Size(140, 65);
			btnCreate.TabIndex = 7;
			btnCreate.Text = "분실물 등록";
			btnCreate.UseVisualStyleBackColor = true;
			btnCreate.Click += btnCreate_Click;
			// 
			// btnSearchByDate
			// 
			btnSearchByDate.Dock = DockStyle.Fill;
			btnSearchByDate.Location = new Point(170, 10);
			btnSearchByDate.Margin = new Padding(10);
			btnSearchByDate.Name = "btnSearchByDate";
			btnSearchByDate.Size = new Size(140, 65);
			btnSearchByDate.TabIndex = 11;
			btnSearchByDate.Text = "날짜별 분실물 조회";
			btnSearchByDate.UseVisualStyleBackColor = true;
			btnSearchByDate.Click += btnSearchByDate_Click;
			// 
			// tableLayoutPanel8
			// 
			tableLayoutPanel8.ColumnCount = 1;
			tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
			tableLayoutPanel8.Location = new Point(0, 0);
			tableLayoutPanel8.Name = "tableLayoutPanel8";
			tableLayoutPanel8.RowCount = 2;
			tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel8.Size = new Size(200, 100);
			tableLayoutPanel8.TabIndex = 0;
			// 
			// FormLostAndFound
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			ClientSize = new Size(984, 561);
			Controls.Add(tabControl1);
			Name = "FormLostAndFound";
			Text = "수지구 분실물 센터";
			tabControl1.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			tableLayoutPanel6.ResumeLayout(false);
			tableLayoutPanel7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pieChartByLostItem).EndInit();
			((System.ComponentModel.ISupportInitialize)pieChartByLocation).EndInit();
			((System.ComponentModel.ISupportInitialize)pieChartByFoundOrNot).EndInit();
			tableLayoutPanel9.ResumeLayout(false);
			tabPage2.ResumeLayout(false);
			tableLayoutPanel4.ResumeLayout(false);
			tableLayoutPanel1.ResumeLayout(false);
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			tableLayoutPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvLostInfos).EndInit();
			tableLayoutPanel5.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel2;
		private TableLayoutPanel tableLayoutPanel3;
		private DataGridView dgvLostInfos;
		private Label label2;
		private Label label3;
		private TextBox tbLostItem;
		private ComboBox cbLostLocation;
		private Button btnReturnToOwner;
		private Label label1;
		private DateTimePicker dtpLostDate;
		private Button btnSearchAll;
		private Button btnCreate;
		private Button btnUpdate;
		private TableLayoutPanel tableLayoutPanel4;
		private TextBox tbOwnerName;
		private Label label5;
		private Label label4;
		private TextBox tbAcquirerName;
		private TableLayoutPanel tableLayoutPanel5;
		private Button btnDelete;
		private Button btnClear;
		private TableLayoutPanel tableLayoutPanel6;
		private TableLayoutPanel tableLayoutPanel8;
		private TableLayoutPanel tableLayoutPanel7;
		private System.Windows.Forms.DataVisualization.Charting.Chart pieChartByLostItem;
		private System.Windows.Forms.DataVisualization.Charting.Chart pieChartByLocation;
		private System.Windows.Forms.DataVisualization.Charting.Chart pieChartByFoundOrNot;
		private TableLayoutPanel tableLayoutPanel9;
		private Button btnRefresh;
		private Button btnSearchByDate;
	}
}