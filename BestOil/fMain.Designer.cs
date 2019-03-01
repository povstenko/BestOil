namespace BestOil
{
	partial class fMain
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.gbxStation = new System.Windows.Forms.GroupBox();
			this.gbxToPayStation = new System.Windows.Forms.GroupBox();
			this.tbxToPayStation = new System.Windows.Forms.TextBox();
			this.lblUah3 = new System.Windows.Forms.Label();
			this.lblUah2 = new System.Windows.Forms.Label();
			this.tbxAmount = new System.Windows.Forms.TextBox();
			this.lblLiter = new System.Windows.Forms.Label();
			this.tbxQuantity = new System.Windows.Forms.TextBox();
			this.gbxVariants = new System.Windows.Forms.GroupBox();
			this.rbtnAmount = new System.Windows.Forms.RadioButton();
			this.rbtnQuantity = new System.Windows.Forms.RadioButton();
			this.lblUah = new System.Windows.Forms.Label();
			this.tbxPrice = new System.Windows.Forms.TextBox();
			this.cbxFuel = new System.Windows.Forms.ComboBox();
			this.lblPrice = new System.Windows.Forms.Label();
			this.lblFuel = new System.Windows.Forms.Label();
			this.gbxCafe = new System.Windows.Forms.GroupBox();
			this.nudCocaCola = new System.Windows.Forms.NumericUpDown();
			this.nudFrenchFries = new System.Windows.Forms.NumericUpDown();
			this.nudHamburger = new System.Windows.Forms.NumericUpDown();
			this.nudHotDog = new System.Windows.Forms.NumericUpDown();
			this.lblQuantityCafe = new System.Windows.Forms.Label();
			this.lblPriceCafe = new System.Windows.Forms.Label();
			this.gbxToPayCafe = new System.Windows.Forms.GroupBox();
			this.tbxToPayCafe = new System.Windows.Forms.TextBox();
			this.lblUah4 = new System.Windows.Forms.Label();
			this.cbxCocaCola = new System.Windows.Forms.CheckBox();
			this.tbxCocaColaPrice = new System.Windows.Forms.TextBox();
			this.tbxFrenchFriesPrice = new System.Windows.Forms.TextBox();
			this.cbxFrenchFries = new System.Windows.Forms.CheckBox();
			this.tbxHotDogPrice = new System.Windows.Forms.TextBox();
			this.tbxHamburgerPrice = new System.Windows.Forms.TextBox();
			this.cbxHamburger = new System.Windows.Forms.CheckBox();
			this.cbxHotDog = new System.Windows.Forms.CheckBox();
			this.gbxTotalToPay = new System.Windows.Forms.GroupBox();
			this.tbxToPayTotal = new System.Windows.Forms.TextBox();
			this.btnCompute = new System.Windows.Forms.Button();
			this.lblUah5 = new System.Windows.Forms.Label();
			this.btnSettings = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.btnCheck = new System.Windows.Forms.Button();
			this.gbxStation.SuspendLayout();
			this.gbxToPayStation.SuspendLayout();
			this.gbxVariants.SuspendLayout();
			this.gbxCafe.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCocaCola)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudFrenchFries)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudHamburger)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudHotDog)).BeginInit();
			this.gbxToPayCafe.SuspendLayout();
			this.gbxTotalToPay.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbxStation
			// 
			this.gbxStation.Controls.Add(this.gbxToPayStation);
			this.gbxStation.Controls.Add(this.lblUah2);
			this.gbxStation.Controls.Add(this.tbxAmount);
			this.gbxStation.Controls.Add(this.lblLiter);
			this.gbxStation.Controls.Add(this.tbxQuantity);
			this.gbxStation.Controls.Add(this.gbxVariants);
			this.gbxStation.Controls.Add(this.lblUah);
			this.gbxStation.Controls.Add(this.tbxPrice);
			this.gbxStation.Controls.Add(this.cbxFuel);
			this.gbxStation.Controls.Add(this.lblPrice);
			this.gbxStation.Controls.Add(this.lblFuel);
			this.gbxStation.Location = new System.Drawing.Point(12, 12);
			this.gbxStation.Name = "gbxStation";
			this.gbxStation.Size = new System.Drawing.Size(233, 243);
			this.gbxStation.TabIndex = 0;
			this.gbxStation.TabStop = false;
			this.gbxStation.Text = "Gas Station";
			// 
			// gbxToPayStation
			// 
			this.gbxToPayStation.Controls.Add(this.tbxToPayStation);
			this.gbxToPayStation.Controls.Add(this.lblUah3);
			this.gbxToPayStation.Location = new System.Drawing.Point(6, 173);
			this.gbxToPayStation.Name = "gbxToPayStation";
			this.gbxToPayStation.Size = new System.Drawing.Size(219, 62);
			this.gbxToPayStation.TabIndex = 10;
			this.gbxToPayStation.TabStop = false;
			this.gbxToPayStation.Text = "To Pay";
			// 
			// tbxToPayStation
			// 
			this.tbxToPayStation.BackColor = System.Drawing.SystemColors.Control;
			this.tbxToPayStation.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbxToPayStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbxToPayStation.Location = new System.Drawing.Point(7, 22);
			this.tbxToPayStation.Name = "tbxToPayStation";
			this.tbxToPayStation.Size = new System.Drawing.Size(176, 31);
			this.tbxToPayStation.TabIndex = 11;
			this.tbxToPayStation.Text = "0";
			this.tbxToPayStation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblUah3
			// 
			this.lblUah3.AutoSize = true;
			this.lblUah3.Location = new System.Drawing.Point(183, 35);
			this.lblUah3.Name = "lblUah3";
			this.lblUah3.Size = new System.Drawing.Size(30, 13);
			this.lblUah3.TabIndex = 10;
			this.lblUah3.Text = "UAH";
			// 
			// lblUah2
			// 
			this.lblUah2.AutoSize = true;
			this.lblUah2.Location = new System.Drawing.Point(195, 129);
			this.lblUah2.Name = "lblUah2";
			this.lblUah2.Size = new System.Drawing.Size(30, 13);
			this.lblUah2.TabIndex = 9;
			this.lblUah2.Text = "UAH";
			// 
			// tbxAmount
			// 
			this.tbxAmount.Enabled = false;
			this.tbxAmount.Location = new System.Drawing.Point(104, 126);
			this.tbxAmount.Name = "tbxAmount";
			this.tbxAmount.Size = new System.Drawing.Size(85, 20);
			this.tbxAmount.TabIndex = 8;
			this.tbxAmount.Text = "0";
			this.tbxAmount.TextChanged += new System.EventHandler(this.tbxQuantity_TextChanged);
			// 
			// lblLiter
			// 
			this.lblLiter.AutoSize = true;
			this.lblLiter.Location = new System.Drawing.Point(195, 103);
			this.lblLiter.Name = "lblLiter";
			this.lblLiter.Size = new System.Drawing.Size(13, 13);
			this.lblLiter.TabIndex = 7;
			this.lblLiter.Text = "L";
			// 
			// tbxQuantity
			// 
			this.tbxQuantity.Location = new System.Drawing.Point(104, 100);
			this.tbxQuantity.Name = "tbxQuantity";
			this.tbxQuantity.Size = new System.Drawing.Size(85, 20);
			this.tbxQuantity.TabIndex = 6;
			this.tbxQuantity.Text = "0";
			this.tbxQuantity.TextChanged += new System.EventHandler(this.tbxQuantity_TextChanged);
			// 
			// gbxVariants
			// 
			this.gbxVariants.Controls.Add(this.rbtnAmount);
			this.gbxVariants.Controls.Add(this.rbtnQuantity);
			this.gbxVariants.Location = new System.Drawing.Point(6, 81);
			this.gbxVariants.Name = "gbxVariants";
			this.gbxVariants.Size = new System.Drawing.Size(92, 76);
			this.gbxVariants.TabIndex = 5;
			this.gbxVariants.TabStop = false;
			// 
			// rbtnAmount
			// 
			this.rbtnAmount.AutoSize = true;
			this.rbtnAmount.Location = new System.Drawing.Point(6, 46);
			this.rbtnAmount.Name = "rbtnAmount";
			this.rbtnAmount.Size = new System.Drawing.Size(61, 17);
			this.rbtnAmount.TabIndex = 1;
			this.rbtnAmount.Text = "Amount";
			this.rbtnAmount.UseVisualStyleBackColor = true;
			this.rbtnAmount.CheckedChanged += new System.EventHandler(this.rbtnAmount_CheckedChanged);
			// 
			// rbtnQuantity
			// 
			this.rbtnQuantity.AutoSize = true;
			this.rbtnQuantity.Checked = true;
			this.rbtnQuantity.Location = new System.Drawing.Point(7, 20);
			this.rbtnQuantity.Name = "rbtnQuantity";
			this.rbtnQuantity.Size = new System.Drawing.Size(64, 17);
			this.rbtnQuantity.TabIndex = 0;
			this.rbtnQuantity.TabStop = true;
			this.rbtnQuantity.Text = "Quantity";
			this.rbtnQuantity.UseVisualStyleBackColor = true;
			this.rbtnQuantity.CheckedChanged += new System.EventHandler(this.rbtnAmount_CheckedChanged);
			// 
			// lblUah
			// 
			this.lblUah.AutoSize = true;
			this.lblUah.Location = new System.Drawing.Point(195, 58);
			this.lblUah.Name = "lblUah";
			this.lblUah.Size = new System.Drawing.Size(30, 13);
			this.lblUah.TabIndex = 4;
			this.lblUah.Text = "UAH";
			// 
			// tbxPrice
			// 
			this.tbxPrice.Enabled = false;
			this.tbxPrice.Location = new System.Drawing.Point(68, 55);
			this.tbxPrice.Name = "tbxPrice";
			this.tbxPrice.Size = new System.Drawing.Size(121, 20);
			this.tbxPrice.TabIndex = 3;
			this.tbxPrice.Text = "0";
			// 
			// cbxFuel
			// 
			this.cbxFuel.DisplayMember = "32";
			this.cbxFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxFuel.FormattingEnabled = true;
			this.cbxFuel.Items.AddRange(new object[] {
            "A92",
            "A95"});
			this.cbxFuel.Location = new System.Drawing.Point(68, 28);
			this.cbxFuel.Name = "cbxFuel";
			this.cbxFuel.Size = new System.Drawing.Size(121, 21);
			this.cbxFuel.TabIndex = 2;
			this.cbxFuel.SelectedIndexChanged += new System.EventHandler(this.cbFuel_SelectedIndexChanged);
			// 
			// lblPrice
			// 
			this.lblPrice.AutoSize = true;
			this.lblPrice.Location = new System.Drawing.Point(6, 58);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(31, 13);
			this.lblPrice.TabIndex = 1;
			this.lblPrice.Text = "Price";
			// 
			// lblFuel
			// 
			this.lblFuel.AutoSize = true;
			this.lblFuel.Location = new System.Drawing.Point(6, 31);
			this.lblFuel.Name = "lblFuel";
			this.lblFuel.Size = new System.Drawing.Size(27, 13);
			this.lblFuel.TabIndex = 0;
			this.lblFuel.Text = "Fuel";
			// 
			// gbxCafe
			// 
			this.gbxCafe.Controls.Add(this.nudCocaCola);
			this.gbxCafe.Controls.Add(this.nudFrenchFries);
			this.gbxCafe.Controls.Add(this.nudHamburger);
			this.gbxCafe.Controls.Add(this.nudHotDog);
			this.gbxCafe.Controls.Add(this.lblQuantityCafe);
			this.gbxCafe.Controls.Add(this.lblPriceCafe);
			this.gbxCafe.Controls.Add(this.gbxToPayCafe);
			this.gbxCafe.Controls.Add(this.cbxCocaCola);
			this.gbxCafe.Controls.Add(this.tbxCocaColaPrice);
			this.gbxCafe.Controls.Add(this.tbxFrenchFriesPrice);
			this.gbxCafe.Controls.Add(this.cbxFrenchFries);
			this.gbxCafe.Controls.Add(this.tbxHotDogPrice);
			this.gbxCafe.Controls.Add(this.tbxHamburgerPrice);
			this.gbxCafe.Controls.Add(this.cbxHamburger);
			this.gbxCafe.Controls.Add(this.cbxHotDog);
			this.gbxCafe.Location = new System.Drawing.Point(251, 12);
			this.gbxCafe.Name = "gbxCafe";
			this.gbxCafe.Size = new System.Drawing.Size(233, 243);
			this.gbxCafe.TabIndex = 1;
			this.gbxCafe.TabStop = false;
			this.gbxCafe.Text = "Mini Cafe";
			// 
			// nudCocaCola
			// 
			this.nudCocaCola.Enabled = false;
			this.nudCocaCola.Location = new System.Drawing.Point(163, 111);
			this.nudCocaCola.Name = "nudCocaCola";
			this.nudCocaCola.Size = new System.Drawing.Size(54, 20);
			this.nudCocaCola.TabIndex = 31;
			this.nudCocaCola.ValueChanged += new System.EventHandler(this.nudCocaCola_ValueChanged);
			// 
			// nudFrenchFries
			// 
			this.nudFrenchFries.Enabled = false;
			this.nudFrenchFries.Location = new System.Drawing.Point(163, 85);
			this.nudFrenchFries.Name = "nudFrenchFries";
			this.nudFrenchFries.Size = new System.Drawing.Size(54, 20);
			this.nudFrenchFries.TabIndex = 32;
			this.nudFrenchFries.ValueChanged += new System.EventHandler(this.nudCocaCola_ValueChanged);
			// 
			// nudHamburger
			// 
			this.nudHamburger.Enabled = false;
			this.nudHamburger.Location = new System.Drawing.Point(163, 59);
			this.nudHamburger.Name = "nudHamburger";
			this.nudHamburger.Size = new System.Drawing.Size(54, 20);
			this.nudHamburger.TabIndex = 31;
			this.nudHamburger.ValueChanged += new System.EventHandler(this.nudCocaCola_ValueChanged);
			// 
			// nudHotDog
			// 
			this.nudHotDog.Enabled = false;
			this.nudHotDog.Location = new System.Drawing.Point(163, 33);
			this.nudHotDog.Name = "nudHotDog";
			this.nudHotDog.Size = new System.Drawing.Size(54, 20);
			this.nudHotDog.TabIndex = 30;
			this.nudHotDog.ValueChanged += new System.EventHandler(this.nudCocaCola_ValueChanged);
			// 
			// lblQuantityCafe
			// 
			this.lblQuantityCafe.AutoSize = true;
			this.lblQuantityCafe.Location = new System.Drawing.Point(166, 16);
			this.lblQuantityCafe.Name = "lblQuantityCafe";
			this.lblQuantityCafe.Size = new System.Drawing.Size(46, 13);
			this.lblQuantityCafe.TabIndex = 29;
			this.lblQuantityCafe.Text = "Quantity";
			// 
			// lblPriceCafe
			// 
			this.lblPriceCafe.AutoSize = true;
			this.lblPriceCafe.Location = new System.Drawing.Point(113, 16);
			this.lblPriceCafe.Name = "lblPriceCafe";
			this.lblPriceCafe.Size = new System.Drawing.Size(31, 13);
			this.lblPriceCafe.TabIndex = 28;
			this.lblPriceCafe.Text = "Price";
			// 
			// gbxToPayCafe
			// 
			this.gbxToPayCafe.Controls.Add(this.tbxToPayCafe);
			this.gbxToPayCafe.Controls.Add(this.lblUah4);
			this.gbxToPayCafe.Location = new System.Drawing.Point(6, 175);
			this.gbxToPayCafe.Name = "gbxToPayCafe";
			this.gbxToPayCafe.Size = new System.Drawing.Size(219, 62);
			this.gbxToPayCafe.TabIndex = 11;
			this.gbxToPayCafe.TabStop = false;
			this.gbxToPayCafe.Text = "To Pay";
			// 
			// tbxToPayCafe
			// 
			this.tbxToPayCafe.BackColor = System.Drawing.SystemColors.Control;
			this.tbxToPayCafe.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbxToPayCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbxToPayCafe.Location = new System.Drawing.Point(6, 20);
			this.tbxToPayCafe.Name = "tbxToPayCafe";
			this.tbxToPayCafe.Size = new System.Drawing.Size(176, 31);
			this.tbxToPayCafe.TabIndex = 12;
			this.tbxToPayCafe.Text = "0";
			this.tbxToPayCafe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblUah4
			// 
			this.lblUah4.AutoSize = true;
			this.lblUah4.Location = new System.Drawing.Point(183, 35);
			this.lblUah4.Name = "lblUah4";
			this.lblUah4.Size = new System.Drawing.Size(30, 13);
			this.lblUah4.TabIndex = 10;
			this.lblUah4.Text = "UAH";
			// 
			// cbxCocaCola
			// 
			this.cbxCocaCola.AutoSize = true;
			this.cbxCocaCola.Location = new System.Drawing.Point(6, 112);
			this.cbxCocaCola.Name = "cbxCocaCola";
			this.cbxCocaCola.Size = new System.Drawing.Size(75, 17);
			this.cbxCocaCola.TabIndex = 23;
			this.cbxCocaCola.Text = "Coca Cola";
			this.cbxCocaCola.UseVisualStyleBackColor = true;
			this.cbxCocaCola.CheckedChanged += new System.EventHandler(this.cbxCocaCola_CheckedChanged);
			// 
			// tbxCocaColaPrice
			// 
			this.tbxCocaColaPrice.Enabled = false;
			this.tbxCocaColaPrice.Location = new System.Drawing.Point(103, 111);
			this.tbxCocaColaPrice.Name = "tbxCocaColaPrice";
			this.tbxCocaColaPrice.Size = new System.Drawing.Size(54, 20);
			this.tbxCocaColaPrice.TabIndex = 18;
			this.tbxCocaColaPrice.Text = "4,4";
			// 
			// tbxFrenchFriesPrice
			// 
			this.tbxFrenchFriesPrice.Enabled = false;
			this.tbxFrenchFriesPrice.Location = new System.Drawing.Point(103, 85);
			this.tbxFrenchFriesPrice.Name = "tbxFrenchFriesPrice";
			this.tbxFrenchFriesPrice.Size = new System.Drawing.Size(54, 20);
			this.tbxFrenchFriesPrice.TabIndex = 16;
			this.tbxFrenchFriesPrice.Text = "7,2";
			// 
			// cbxFrenchFries
			// 
			this.cbxFrenchFries.AutoSize = true;
			this.cbxFrenchFries.Location = new System.Drawing.Point(6, 86);
			this.cbxFrenchFries.Name = "cbxFrenchFries";
			this.cbxFrenchFries.Size = new System.Drawing.Size(81, 17);
			this.cbxFrenchFries.TabIndex = 22;
			this.cbxFrenchFries.Text = "French fries";
			this.cbxFrenchFries.UseVisualStyleBackColor = true;
			this.cbxFrenchFries.CheckedChanged += new System.EventHandler(this.cbxCocaCola_CheckedChanged);
			// 
			// tbxHotDogPrice
			// 
			this.tbxHotDogPrice.Enabled = false;
			this.tbxHotDogPrice.Location = new System.Drawing.Point(103, 33);
			this.tbxHotDogPrice.Name = "tbxHotDogPrice";
			this.tbxHotDogPrice.Size = new System.Drawing.Size(54, 20);
			this.tbxHotDogPrice.TabIndex = 15;
			this.tbxHotDogPrice.Text = "4";
			// 
			// tbxHamburgerPrice
			// 
			this.tbxHamburgerPrice.Enabled = false;
			this.tbxHamburgerPrice.Location = new System.Drawing.Point(103, 59);
			this.tbxHamburgerPrice.Name = "tbxHamburgerPrice";
			this.tbxHamburgerPrice.Size = new System.Drawing.Size(54, 20);
			this.tbxHamburgerPrice.TabIndex = 14;
			this.tbxHamburgerPrice.Text = "5,4";
			// 
			// cbxHamburger
			// 
			this.cbxHamburger.AutoSize = true;
			this.cbxHamburger.Location = new System.Drawing.Point(6, 60);
			this.cbxHamburger.Name = "cbxHamburger";
			this.cbxHamburger.Size = new System.Drawing.Size(78, 17);
			this.cbxHamburger.TabIndex = 21;
			this.cbxHamburger.Text = "Hamburger";
			this.cbxHamburger.UseVisualStyleBackColor = true;
			this.cbxHamburger.CheckedChanged += new System.EventHandler(this.cbxCocaCola_CheckedChanged);
			// 
			// cbxHotDog
			// 
			this.cbxHotDog.AutoSize = true;
			this.cbxHotDog.Location = new System.Drawing.Point(6, 34);
			this.cbxHotDog.Name = "cbxHotDog";
			this.cbxHotDog.Size = new System.Drawing.Size(66, 17);
			this.cbxHotDog.TabIndex = 20;
			this.cbxHotDog.Text = "Hot Dog";
			this.cbxHotDog.UseVisualStyleBackColor = true;
			this.cbxHotDog.CheckedChanged += new System.EventHandler(this.cbxCocaCola_CheckedChanged);
			// 
			// gbxTotalToPay
			// 
			this.gbxTotalToPay.Controls.Add(this.btnCheck);
			this.gbxTotalToPay.Controls.Add(this.tbxToPayTotal);
			this.gbxTotalToPay.Controls.Add(this.lblUah5);
			this.gbxTotalToPay.Location = new System.Drawing.Point(13, 261);
			this.gbxTotalToPay.Name = "gbxTotalToPay";
			this.gbxTotalToPay.Size = new System.Drawing.Size(471, 96);
			this.gbxTotalToPay.TabIndex = 11;
			this.gbxTotalToPay.TabStop = false;
			this.gbxTotalToPay.Text = "Total To Pay";
			// 
			// tbxToPayTotal
			// 
			this.tbxToPayTotal.BackColor = System.Drawing.SystemColors.Control;
			this.tbxToPayTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbxToPayTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbxToPayTotal.Location = new System.Drawing.Point(108, 45);
			this.tbxToPayTotal.Name = "tbxToPayTotal";
			this.tbxToPayTotal.Size = new System.Drawing.Size(318, 31);
			this.tbxToPayTotal.TabIndex = 12;
			this.tbxToPayTotal.Text = "0";
			this.tbxToPayTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnCompute
			// 
			this.btnCompute.Location = new System.Drawing.Point(328, 363);
			this.btnCompute.Name = "btnCompute";
			this.btnCompute.Size = new System.Drawing.Size(75, 23);
			this.btnCompute.TabIndex = 11;
			this.btnCompute.Text = "Compute";
			this.btnCompute.UseVisualStyleBackColor = true;
			this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
			// 
			// lblUah5
			// 
			this.lblUah5.AutoSize = true;
			this.lblUah5.Location = new System.Drawing.Point(427, 63);
			this.lblUah5.Name = "lblUah5";
			this.lblUah5.Size = new System.Drawing.Size(30, 13);
			this.lblUah5.TabIndex = 10;
			this.lblUah5.Text = "UAH";
			// 
			// btnSettings
			// 
			this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSettings.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnSettings.Location = new System.Drawing.Point(409, 363);
			this.btnSettings.Name = "btnSettings";
			this.btnSettings.Size = new System.Drawing.Size(75, 23);
			this.btnSettings.TabIndex = 13;
			this.btnSettings.Text = "Settings";
			this.btnSettings.UseVisualStyleBackColor = true;
			this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripProgressBar1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 396);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(494, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(38, 17);
			this.toolStripStatusLabel1.Text = "00:00";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(61, 17);
			this.toolStripStatusLabel2.Text = "00.00.0000";
			// 
			// toolStripProgressBar1
			// 
			this.toolStripProgressBar1.Enabled = false;
			this.toolStripProgressBar1.Maximum = 10;
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
			this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.toolStripProgressBar1.Value = 10;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// btnCheck
			// 
			this.btnCheck.Location = new System.Drawing.Point(6, 24);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(75, 52);
			this.btnCheck.TabIndex = 13;
			this.btnCheck.Text = "Check";
			this.btnCheck.UseVisualStyleBackColor = true;
			this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
			// 
			// fMain
			// 
			this.AcceptButton = this.btnCheck;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnSettings;
			this.ClientSize = new System.Drawing.Size(494, 418);
			this.Controls.Add(this.btnSettings);
			this.Controls.Add(this.gbxTotalToPay);
			this.Controls.Add(this.btnCompute);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.gbxStation);
			this.Controls.Add(this.gbxCafe);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "fMain";
			this.Text = "BestOil";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
			this.Load += new System.EventHandler(this.fMain_Load);
			this.gbxStation.ResumeLayout(false);
			this.gbxStation.PerformLayout();
			this.gbxToPayStation.ResumeLayout(false);
			this.gbxToPayStation.PerformLayout();
			this.gbxVariants.ResumeLayout(false);
			this.gbxVariants.PerformLayout();
			this.gbxCafe.ResumeLayout(false);
			this.gbxCafe.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCocaCola)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudFrenchFries)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudHamburger)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudHotDog)).EndInit();
			this.gbxToPayCafe.ResumeLayout(false);
			this.gbxToPayCafe.PerformLayout();
			this.gbxTotalToPay.ResumeLayout(false);
			this.gbxTotalToPay.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gbxStation;
		private System.Windows.Forms.GroupBox gbxToPayStation;
		private System.Windows.Forms.Label lblUah3;
		private System.Windows.Forms.Label lblUah2;
		private System.Windows.Forms.TextBox tbxAmount;
		private System.Windows.Forms.Label lblLiter;
		private System.Windows.Forms.TextBox tbxQuantity;
		private System.Windows.Forms.GroupBox gbxVariants;
		private System.Windows.Forms.RadioButton rbtnAmount;
		private System.Windows.Forms.RadioButton rbtnQuantity;
		private System.Windows.Forms.Label lblUah;
		private System.Windows.Forms.TextBox tbxPrice;
		private System.Windows.Forms.ComboBox cbxFuel;
		private System.Windows.Forms.Label lblPrice;
		private System.Windows.Forms.Label lblFuel;
		private System.Windows.Forms.GroupBox gbxCafe;
		private System.Windows.Forms.GroupBox gbxToPayCafe;
		private System.Windows.Forms.Label lblUah4;
		private System.Windows.Forms.Label lblQuantityCafe;
		private System.Windows.Forms.Label lblPriceCafe;
		private System.Windows.Forms.CheckBox cbxCocaCola;
		private System.Windows.Forms.TextBox tbxCocaColaPrice;
		private System.Windows.Forms.TextBox tbxFrenchFriesPrice;
		private System.Windows.Forms.CheckBox cbxFrenchFries;
		private System.Windows.Forms.TextBox tbxHotDogPrice;
		private System.Windows.Forms.TextBox tbxHamburgerPrice;
		private System.Windows.Forms.CheckBox cbxHamburger;
		private System.Windows.Forms.CheckBox cbxHotDog;
		private System.Windows.Forms.GroupBox gbxTotalToPay;
		private System.Windows.Forms.Label lblUah5;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.Button btnCompute;
		private System.Windows.Forms.NumericUpDown nudCocaCola;
		private System.Windows.Forms.NumericUpDown nudFrenchFries;
		private System.Windows.Forms.NumericUpDown nudHamburger;
		private System.Windows.Forms.NumericUpDown nudHotDog;
		private System.Windows.Forms.TextBox tbxToPayStation;
		private System.Windows.Forms.TextBox tbxToPayCafe;
		private System.Windows.Forms.TextBox tbxToPayTotal;
		private System.Windows.Forms.Button btnSettings;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btnCheck;
	}
}

