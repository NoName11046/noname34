namespace Adyga_bot
{
	// Token: 0x0200000E RID: 14
	public partial class MainForm 
	{
		// Token: 0x0600004D RID: 77 RVA: 0x000046E4 File Offset: 0x000028E4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			bool flag2 = flag;
			bool flag3 = flag2;
			if (flag3)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00004720 File Offset: 0x00002920
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.LogTimer = new System.Windows.Forms.Timer(this.components);
            this.ManualCaptTimer = new System.Windows.Forms.Timer(this.components);
            this.targetsGridFLText = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numericDelayTextFL = new System.Windows.Forms.NumericUpDown();
            this.CurrAccComboBox = new System.Windows.Forms.ComboBox();
            this.fl_bLogClear = new System.Windows.Forms.Button();
            this.fl_cmdLog = new System.Windows.Forms.ComboBox();
            this.fl_bTextUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fl_bStart = new System.Windows.Forms.Button();
            this.fl_bGetToken = new System.Windows.Forms.Button();
            this.fl_Auto2 = new System.Windows.Forms.TextBox();
            this.fl_Auto1 = new System.Windows.Forms.TextBox();
            this.fl_AutoDeleteText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fl_bAutoDelete = new System.Windows.Forms.Button();
            this.AccEnabledFL = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fl_bAuto = new System.Windows.Forms.Button();
            this.fl_bSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fl_b_kChange = new System.Windows.Forms.Button();
            this.fl_b_kGet = new System.Windows.Forms.Button();
            this.fl_b_kSave = new System.Windows.Forms.Button();
            this.fl_b_kSend = new System.Windows.Forms.Button();
            this.ApiKeyTextBox = new System.Windows.Forms.MaskedTextBox();
            this.fl_lkey = new System.Windows.Forms.Label();
            this.fl_lBalance = new System.Windows.Forms.Label();
            this.CurrBalance = new System.Windows.Forms.Label();
            this.ManualCaptBox = new System.Windows.Forms.MaskedTextBox();
            this.CaptPic = new System.Windows.Forms.PictureBox();
            this.MemoryCleaner = new System.Windows.Forms.Timer(this.components);
            this.button_exit = new System.Windows.Forms.Button();
            this.button_minimaze = new System.Windows.Forms.Button();
            this.Флудер = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.targetsGridFLText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDelayTextFL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaptPic)).BeginInit();
            this.Флудер.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(18, 56);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(396, 130);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // LogTimer
            // 
            this.LogTimer.Enabled = true;
            this.LogTimer.Interval = 1000;
            this.LogTimer.Tick += new System.EventHandler(this.LogTimer_Tick);
            // 
            // ManualCaptTimer
            // 
            this.ManualCaptTimer.Enabled = true;
            this.ManualCaptTimer.Interval = 1000;
            this.ManualCaptTimer.Tick += new System.EventHandler(this.ManualCaptTimer_Tick);
            // 
            // targetsGridFLText
            // 
            this.targetsGridFLText.AllowUserToResizeColumns = false;
            this.targetsGridFLText.AllowUserToResizeRows = false;
            this.targetsGridFLText.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.targetsGridFLText.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.targetsGridFLText.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.targetsGridFLText.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.targetsGridFLText.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.targetsGridFLText.DefaultCellStyle = dataGridViewCellStyle4;
            this.targetsGridFLText.GridColor = System.Drawing.Color.Black;
            this.targetsGridFLText.Location = new System.Drawing.Point(15, 9);
            this.targetsGridFLText.Name = "targetsGridFLText";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.targetsGridFLText.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.targetsGridFLText.RowHeadersVisible = false;
            this.targetsGridFLText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.targetsGridFLText.Size = new System.Drawing.Size(404, 159);
            this.targetsGridFLText.TabIndex = 16;
            this.targetsGridFLText.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TargetsGridFLText_CellContentClick);
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.HeaderText = "Обращение";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn4.HeaderText = "Ссылка";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 214;
            // 
            // numericDelayTextFL
            // 
            this.numericDelayTextFL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.numericDelayTextFL.ForeColor = System.Drawing.Color.White;
            this.numericDelayTextFL.Location = new System.Drawing.Point(117, 177);
            this.numericDelayTextFL.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.numericDelayTextFL.Name = "numericDelayTextFL";
            this.numericDelayTextFL.Size = new System.Drawing.Size(214, 20);
            this.numericDelayTextFL.TabIndex = 12;
            // 
            // CurrAccComboBox
            // 
            this.CurrAccComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.CurrAccComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrAccComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CurrAccComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrAccComboBox.ForeColor = System.Drawing.Color.White;
            this.CurrAccComboBox.FormattingEnabled = true;
            this.CurrAccComboBox.Location = new System.Drawing.Point(19, 27);
            this.CurrAccComboBox.Name = "CurrAccComboBox";
            this.CurrAccComboBox.Size = new System.Drawing.Size(395, 23);
            this.CurrAccComboBox.TabIndex = 23;
            this.CurrAccComboBox.SelectedIndexChanged += new System.EventHandler(this.CurrAccComboBox_SelectedIndexChanged);
            // 
            // fl_bLogClear
            // 
            this.fl_bLogClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.fl_bLogClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fl_bLogClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fl_bLogClear.Location = new System.Drawing.Point(288, 221);
            this.fl_bLogClear.Name = "fl_bLogClear";
            this.fl_bLogClear.Size = new System.Drawing.Size(126, 30);
            this.fl_bLogClear.TabIndex = 51;
            this.fl_bLogClear.Text = "Отчистить лог";
            this.fl_bLogClear.UseVisualStyleBackColor = false;
            this.fl_bLogClear.Click += new System.EventHandler(this.Fl_bLogClear_Click);
            // 
            // fl_cmdLog
            // 
            this.fl_cmdLog.AutoCompleteCustomSource.AddRange(new string[] {
            "Отключить",
            "Авто",
            "Вручную"});
            this.fl_cmdLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.fl_cmdLog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fl_cmdLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fl_cmdLog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fl_cmdLog.ForeColor = System.Drawing.Color.White;
            this.fl_cmdLog.FormattingEnabled = true;
            this.fl_cmdLog.Items.AddRange(new object[] {
            "Вручную",
            "Отключить"});
            this.fl_cmdLog.Location = new System.Drawing.Point(18, 192);
            this.fl_cmdLog.Name = "fl_cmdLog";
            this.fl_cmdLog.Size = new System.Drawing.Size(396, 23);
            this.fl_cmdLog.TabIndex = 50;
            this.fl_cmdLog.SelectedIndexChanged += new System.EventHandler(this.Fl_cmdLog_SelectedIndexChanged);
            // 
            // fl_bTextUpdate
            // 
            this.fl_bTextUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.fl_bTextUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fl_bTextUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fl_bTextUpdate.Location = new System.Drawing.Point(19, 257);
            this.fl_bTextUpdate.Name = "fl_bTextUpdate";
            this.fl_bTextUpdate.Size = new System.Drawing.Size(395, 30);
            this.fl_bTextUpdate.TabIndex = 49;
            this.fl_bTextUpdate.Text = "Обновить контент";
            this.fl_bTextUpdate.UseVisualStyleBackColor = false;
            this.fl_bTextUpdate.Click += new System.EventHandler(this.Fl_bTextUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Текущий аккаунт:";
            // 
            // fl_bStart
            // 
            this.fl_bStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.fl_bStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fl_bStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fl_bStart.Location = new System.Drawing.Point(19, 221);
            this.fl_bStart.Name = "fl_bStart";
            this.fl_bStart.Size = new System.Drawing.Size(126, 30);
            this.fl_bStart.TabIndex = 48;
            this.fl_bStart.Text = "Запуск";
            this.fl_bStart.UseVisualStyleBackColor = false;
            this.fl_bStart.Click += new System.EventHandler(this.Fl_bStart_Click);
            // 
            // fl_bGetToken
            // 
            this.fl_bGetToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.fl_bGetToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fl_bGetToken.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fl_bGetToken.Location = new System.Drawing.Point(151, 221);
            this.fl_bGetToken.Name = "fl_bGetToken";
            this.fl_bGetToken.Size = new System.Drawing.Size(131, 30);
            this.fl_bGetToken.TabIndex = 47;
            this.fl_bGetToken.Text = "Получить токены";
            this.fl_bGetToken.UseVisualStyleBackColor = false;
            this.fl_bGetToken.Click += new System.EventHandler(this.Fl_bGetToken_Click);
            // 
            // fl_Auto2
            // 
            this.fl_Auto2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.fl_Auto2.ForeColor = System.Drawing.Color.White;
            this.fl_Auto2.Location = new System.Drawing.Point(148, 275);
            this.fl_Auto2.Name = "fl_Auto2";
            this.fl_Auto2.Size = new System.Drawing.Size(62, 20);
            this.fl_Auto2.TabIndex = 160;
            // 
            // fl_Auto1
            // 
            this.fl_Auto1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.fl_Auto1.ForeColor = System.Drawing.Color.White;
            this.fl_Auto1.Location = new System.Drawing.Point(51, 275);
            this.fl_Auto1.Name = "fl_Auto1";
            this.fl_Auto1.Size = new System.Drawing.Size(62, 20);
            this.fl_Auto1.TabIndex = 159;
            // 
            // fl_AutoDeleteText
            // 
            this.fl_AutoDeleteText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.fl_AutoDeleteText.ForeColor = System.Drawing.Color.White;
            this.fl_AutoDeleteText.Location = new System.Drawing.Point(357, 275);
            this.fl_AutoDeleteText.Name = "fl_AutoDeleteText";
            this.fl_AutoDeleteText.Size = new System.Drawing.Size(62, 20);
            this.fl_AutoDeleteText.TabIndex = 158;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(333, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 15);
            this.label5.TabIndex = 157;
            this.label5.Text = "ID:";
            // 
            // fl_bAutoDelete
            // 
            this.fl_bAutoDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.fl_bAutoDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fl_bAutoDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fl_bAutoDelete.Location = new System.Drawing.Point(215, 239);
            this.fl_bAutoDelete.Name = "fl_bAutoDelete";
            this.fl_bAutoDelete.Size = new System.Drawing.Size(204, 30);
            this.fl_bAutoDelete.TabIndex = 155;
            this.fl_bAutoDelete.Text = "Очистить";
            this.fl_bAutoDelete.UseVisualStyleBackColor = false;
            this.fl_bAutoDelete.Click += new System.EventHandler(this.Fl_bAutoDelete_Click);
            // 
            // AccEnabledFL
            // 
            this.AccEnabledFL.AutoSize = true;
            this.AccEnabledFL.BackColor = System.Drawing.Color.Transparent;
            this.AccEnabledFL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AccEnabledFL.ForeColor = System.Drawing.Color.White;
            this.AccEnabledFL.Location = new System.Drawing.Point(341, 177);
            this.AccEnabledFL.Name = "AccEnabledFL";
            this.AccEnabledFL.Size = new System.Drawing.Size(71, 19);
            this.AccEnabledFL.TabIndex = 154;
            this.AccEnabledFL.Text = "Активен";
            this.AccEnabledFL.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(119, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 153;
            this.label4.Text = "До:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 151;
            this.label3.Text = "От:";
            // 
            // fl_bAuto
            // 
            this.fl_bAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.fl_bAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fl_bAuto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fl_bAuto.Location = new System.Drawing.Point(15, 239);
            this.fl_bAuto.Name = "fl_bAuto";
            this.fl_bAuto.Size = new System.Drawing.Size(195, 30);
            this.fl_bAuto.TabIndex = 50;
            this.fl_bAuto.Text = "Заполнить";
            this.fl_bAuto.UseVisualStyleBackColor = false;
            this.fl_bAuto.Click += new System.EventHandler(this.Fl_bAuto_Click);
            // 
            // fl_bSave
            // 
            this.fl_bSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.fl_bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fl_bSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fl_bSave.Location = new System.Drawing.Point(15, 203);
            this.fl_bSave.Name = "fl_bSave";
            this.fl_bSave.Size = new System.Drawing.Size(404, 30);
            this.fl_bSave.TabIndex = 49;
            this.fl_bSave.Text = "Сохранить";
            this.fl_bSave.UseVisualStyleBackColor = false;
            this.fl_bSave.Click += new System.EventHandler(this.Fl_bSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Задержка (мс):";
            // 
            // fl_b_kChange
            // 
            this.fl_b_kChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.fl_b_kChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fl_b_kChange.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fl_b_kChange.Location = new System.Drawing.Point(19, 256);
            this.fl_b_kChange.Name = "fl_b_kChange";
            this.fl_b_kChange.Size = new System.Drawing.Size(396, 30);
            this.fl_b_kChange.TabIndex = 153;
            this.fl_b_kChange.Text = "RuCaptcha";
            this.fl_b_kChange.UseVisualStyleBackColor = false;
            this.fl_b_kChange.Click += new System.EventHandler(this.Fl_b_kChange_Click);
            // 
            // fl_b_kGet
            // 
            this.fl_b_kGet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.fl_b_kGet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fl_b_kGet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fl_b_kGet.Location = new System.Drawing.Point(19, 93);
            this.fl_b_kGet.Name = "fl_b_kGet";
            this.fl_b_kGet.Size = new System.Drawing.Size(396, 30);
            this.fl_b_kGet.TabIndex = 152;
            this.fl_b_kGet.Text = "Узнать баланс";
            this.fl_b_kGet.UseVisualStyleBackColor = false;
            this.fl_b_kGet.Click += new System.EventHandler(this.Fl_b_kGet_Click);
            // 
            // fl_b_kSave
            // 
            this.fl_b_kSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.fl_b_kSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fl_b_kSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fl_b_kSave.Location = new System.Drawing.Point(19, 57);
            this.fl_b_kSave.Name = "fl_b_kSave";
            this.fl_b_kSave.Size = new System.Drawing.Size(396, 30);
            this.fl_b_kSave.TabIndex = 151;
            this.fl_b_kSave.Text = "Сохранить";
            this.fl_b_kSave.UseVisualStyleBackColor = false;
            this.fl_b_kSave.Click += new System.EventHandler(this.Fl_b_kSave_Click);
            // 
            // fl_b_kSend
            // 
            this.fl_b_kSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.fl_b_kSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fl_b_kSend.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fl_b_kSend.Location = new System.Drawing.Point(165, 57);
            this.fl_b_kSend.Name = "fl_b_kSend";
            this.fl_b_kSend.Size = new System.Drawing.Size(250, 30);
            this.fl_b_kSend.TabIndex = 150;
            this.fl_b_kSend.Text = "Отправить";
            this.fl_b_kSend.UseVisualStyleBackColor = false;
            this.fl_b_kSend.Click += new System.EventHandler(this.Fl_b_kSend_Click);
            // 
            // ApiKeyTextBox
            // 
            this.ApiKeyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ApiKeyTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ApiKeyTextBox.ForeColor = System.Drawing.Color.White;
            this.ApiKeyTextBox.Location = new System.Drawing.Point(19, 28);
            this.ApiKeyTextBox.Name = "ApiKeyTextBox";
            this.ApiKeyTextBox.Size = new System.Drawing.Size(396, 23);
            this.ApiKeyTextBox.TabIndex = 149;
            // 
            // fl_lkey
            // 
            this.fl_lkey.AutoSize = true;
            this.fl_lkey.BackColor = System.Drawing.Color.Transparent;
            this.fl_lkey.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fl_lkey.ForeColor = System.Drawing.Color.White;
            this.fl_lkey.Location = new System.Drawing.Point(16, 12);
            this.fl_lkey.Name = "fl_lkey";
            this.fl_lkey.Size = new System.Drawing.Size(46, 15);
            this.fl_lkey.TabIndex = 146;
            this.fl_lkey.Text = "API key";
            // 
            // fl_lBalance
            // 
            this.fl_lBalance.AutoSize = true;
            this.fl_lBalance.BackColor = System.Drawing.Color.Transparent;
            this.fl_lBalance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fl_lBalance.ForeColor = System.Drawing.Color.White;
            this.fl_lBalance.Location = new System.Drawing.Point(16, 126);
            this.fl_lBalance.Name = "fl_lBalance";
            this.fl_lBalance.Size = new System.Drawing.Size(63, 15);
            this.fl_lBalance.TabIndex = 147;
            this.fl_lBalance.Text = "Баланс   - ";
            this.fl_lBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrBalance
            // 
            this.CurrBalance.AutoSize = true;
            this.CurrBalance.BackColor = System.Drawing.Color.Transparent;
            this.CurrBalance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrBalance.ForeColor = System.Drawing.Color.White;
            this.CurrBalance.Location = new System.Drawing.Point(79, 126);
            this.CurrBalance.Name = "CurrBalance";
            this.CurrBalance.Size = new System.Drawing.Size(22, 15);
            this.CurrBalance.TabIndex = 148;
            this.CurrBalance.Text = "0 ₽";
            this.CurrBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManualCaptBox
            // 
            this.ManualCaptBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ManualCaptBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManualCaptBox.ForeColor = System.Drawing.Color.White;
            this.ManualCaptBox.Location = new System.Drawing.Point(165, 28);
            this.ManualCaptBox.Name = "ManualCaptBox";
            this.ManualCaptBox.Size = new System.Drawing.Size(250, 23);
            this.ManualCaptBox.TabIndex = 145;
            this.ManualCaptBox.Visible = false;
            // 
            // CaptPic
            // 
            this.CaptPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.CaptPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CaptPic.Location = new System.Drawing.Point(29, 28);
            this.CaptPic.Name = "CaptPic";
            this.CaptPic.Size = new System.Drawing.Size(130, 59);
            this.CaptPic.TabIndex = 144;
            this.CaptPic.TabStop = false;
            this.CaptPic.Visible = false;
            // 
            // MemoryCleaner
            // 
            this.MemoryCleaner.Interval = 3600000;
            this.MemoryCleaner.Tick += new System.EventHandler(this.MemoryCleaner_Tick);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.ForeColor = System.Drawing.Color.Red;
            this.button_exit.Location = new System.Drawing.Point(444, 3);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(21, 23);
            this.button_exit.TabIndex = 45;
            this.button_exit.Text = "X";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.Button_exit_Click);
            // 
            // button_minimaze
            // 
            this.button_minimaze.FlatAppearance.BorderSize = 0;
            this.button_minimaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimaze.Location = new System.Drawing.Point(414, 3);
            this.button_minimaze.Name = "button_minimaze";
            this.button_minimaze.Size = new System.Drawing.Size(24, 23);
            this.button_minimaze.TabIndex = 46;
            this.button_minimaze.Text = "—";
            this.button_minimaze.UseVisualStyleBackColor = true;
            this.button_minimaze.Click += new System.EventHandler(this.Button_minimaze_Click);
            // 
            // Флудер
            // 
            this.Флудер.Controls.Add(this.tabPage1);
            this.Флудер.Controls.Add(this.tabPage2);
            this.Флудер.Controls.Add(this.tabPage3);
            this.Флудер.Location = new System.Drawing.Point(12, 32);
            this.Флудер.Name = "Флудер";
            this.Флудер.SelectedIndex = 0;
            this.Флудер.Size = new System.Drawing.Size(442, 333);
            this.Флудер.TabIndex = 161;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tabPage1.Controls.Add(this.targetsGridFLText);
            this.tabPage1.Controls.Add(this.fl_Auto2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.numericDelayTextFL);
            this.tabPage1.Controls.Add(this.fl_Auto1);
            this.tabPage1.Controls.Add(this.AccEnabledFL);
            this.tabPage1.Controls.Add(this.fl_bSave);
            this.tabPage1.Controls.Add(this.fl_AutoDeleteText);
            this.tabPage1.Controls.Add(this.fl_bAutoDelete);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.fl_bAuto);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(434, 307);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Флудер";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tabPage2.Controls.Add(this.fl_bLogClear);
            this.tabPage2.Controls.Add(this.CurrAccComboBox);
            this.tabPage2.Controls.Add(this.fl_bTextUpdate);
            this.tabPage2.Controls.Add(this.fl_cmdLog);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.fl_bStart);
            this.tabPage2.Controls.Add(this.fl_bGetToken);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(434, 307);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Информация";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.tabPage3.Controls.Add(this.fl_b_kChange);
            this.tabPage3.Controls.Add(this.fl_b_kSave);
            this.tabPage3.Controls.Add(this.fl_b_kGet);
            this.tabPage3.Controls.Add(this.fl_b_kSend);
            this.tabPage3.Controls.Add(this.CurrBalance);
            this.tabPage3.Controls.Add(this.ApiKeyTextBox);
            this.tabPage3.Controls.Add(this.fl_lBalance);
            this.tabPage3.Controls.Add(this.fl_lkey);
            this.tabPage3.Controls.Add(this.CaptPic);
            this.tabPage3.Controls.Add(this.ManualCaptBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(434, 307);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Капча";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(466, 386);
            this.Controls.Add(this.Флудер);
            this.Controls.Add(this.button_minimaze);
            this.Controls.Add(this.button_exit);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adyga bot";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.targetsGridFLText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDelayTextFL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CaptPic)).EndInit();
            this.Флудер.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

		}

		// Token: 0x04000047 RID: 71
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.Timer LogTimer;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.Timer ManualCaptTimer;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.DataGridView targetsGridFLText;

		// Token: 0x0400004E RID: 78
		public global::System.Windows.Forms.NumericUpDown numericDelayTextFL;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.ComboBox CurrAccComboBox;
        private System.Windows.Forms.Button fl_bStart;
        private System.Windows.Forms.Button fl_bGetToken;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button fl_bAuto;
        private System.Windows.Forms.Button fl_bSave;
        private System.Windows.Forms.Button fl_b_kGet;
        private System.Windows.Forms.Button fl_b_kSave;
        private System.Windows.Forms.Button fl_b_kSend;
        private System.Windows.Forms.MaskedTextBox ApiKeyTextBox;
        private System.Windows.Forms.Label fl_lkey;
        private System.Windows.Forms.Label fl_lBalance;
        private System.Windows.Forms.Label CurrBalance;
        private System.Windows.Forms.MaskedTextBox ManualCaptBox;
        private System.Windows.Forms.PictureBox CaptPic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button fl_b_kChange;
        private System.Windows.Forms.CheckBox AccEnabledFL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button fl_bAutoDelete;
        private System.Windows.Forms.Button fl_bTextUpdate;
        private System.Windows.Forms.ComboBox fl_cmdLog;
        private System.Windows.Forms.Timer MemoryCleaner;
        private System.Windows.Forms.Button fl_bLogClear;
        private System.Windows.Forms.TextBox fl_Auto2;
        private System.Windows.Forms.TextBox fl_Auto1;
        private System.Windows.Forms.TextBox fl_AutoDeleteText;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_minimaze;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TabControl Флудер;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}
