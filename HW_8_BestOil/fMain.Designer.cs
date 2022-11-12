namespace HW_8_BestOil
{
    partial class fMain
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
            this.components = new System.ComponentModel.Container();
            this.gbxCafe = new System.Windows.Forms.GroupBox();
            this.cbxHotDog = new System.Windows.Forms.CheckBox();
            this.cbxHamburger = new System.Windows.Forms.CheckBox();
            this.cbxFrenchFries = new System.Windows.Forms.CheckBox();
            this.cbxCocaCola = new System.Windows.Forms.CheckBox();
            this.tbxHotDogPrice = new System.Windows.Forms.TextBox();
            this.tbxHamburgerPrice = new System.Windows.Forms.TextBox();
            this.tbxFrenchFriesPrice = new System.Windows.Forms.TextBox();
            this.tbxCocaColaPrice = new System.Windows.Forms.TextBox();
            this.nudHamburger = new System.Windows.Forms.NumericUpDown();
            this.nudFrenchFries = new System.Windows.Forms.NumericUpDown();
            this.nudCocaCola = new System.Windows.Forms.NumericUpDown();
            this.nudHotDog = new System.Windows.Forms.NumericUpDown();
            this.gbxToPayCafe = new System.Windows.Forms.GroupBox();
            this.tbxToPayCafe = new System.Windows.Forms.TextBox();
            this.lblUah4 = new System.Windows.Forms.Label();
            this.lblPriceCafe = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxToPayStation = new System.Windows.Forms.GroupBox();
            this.tbxToPayStation = new System.Windows.Forms.TextBox();
            this.lblUah3 = new System.Windows.Forms.Label();
            this.gbxTotalToPay = new System.Windows.Forms.GroupBox();
            this.tbxToPayTotal = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblUah5 = new System.Windows.Forms.Label();
            this.gbxStation = new System.Windows.Forms.GroupBox();
            this.cbxFuel = new System.Windows.Forms.ComboBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxAmount = new System.Windows.Forms.TextBox();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.gbxVariants = new System.Windows.Forms.GroupBox();
            this.rbtnAmount = new System.Windows.Forms.RadioButton();
            this.rbtnQuantity = new System.Windows.Forms.RadioButton();
            this.lblUah2 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblUah = new System.Windows.Forms.Label();
            this.lblLiter = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbxCafe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHamburger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrenchFries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCocaCola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHotDog)).BeginInit();
            this.gbxToPayCafe.SuspendLayout();
            this.gbxToPayStation.SuspendLayout();
            this.gbxTotalToPay.SuspendLayout();
            this.gbxStation.SuspendLayout();
            this.gbxVariants.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCafe
            // 
            this.gbxCafe.Controls.Add(this.cbxHotDog);
            this.gbxCafe.Controls.Add(this.cbxHamburger);
            this.gbxCafe.Controls.Add(this.cbxFrenchFries);
            this.gbxCafe.Controls.Add(this.cbxCocaCola);
            this.gbxCafe.Controls.Add(this.tbxHotDogPrice);
            this.gbxCafe.Controls.Add(this.tbxHamburgerPrice);
            this.gbxCafe.Controls.Add(this.tbxFrenchFriesPrice);
            this.gbxCafe.Controls.Add(this.tbxCocaColaPrice);
            this.gbxCafe.Controls.Add(this.nudHamburger);
            this.gbxCafe.Controls.Add(this.nudFrenchFries);
            this.gbxCafe.Controls.Add(this.nudCocaCola);
            this.gbxCafe.Controls.Add(this.nudHotDog);
            this.gbxCafe.Controls.Add(this.gbxToPayCafe);
            this.gbxCafe.Controls.Add(this.lblPriceCafe);
            this.gbxCafe.Controls.Add(this.label3);
            this.gbxCafe.Location = new System.Drawing.Point(324, 12);
            this.gbxCafe.Name = "gbxCafe";
            this.gbxCafe.Size = new System.Drawing.Size(289, 503);
            this.gbxCafe.TabIndex = 0;
            this.gbxCafe.TabStop = false;
            this.gbxCafe.Text = "Мини Кафе";
            // 
            // cbxHotDog
            // 
            this.cbxHotDog.AutoSize = true;
            this.cbxHotDog.Location = new System.Drawing.Point(12, 54);
            this.cbxHotDog.Name = "cbxHotDog";
            this.cbxHotDog.Size = new System.Drawing.Size(67, 17);
            this.cbxHotDog.TabIndex = 24;
            this.cbxHotDog.Text = "Хот-Дог";
            this.cbxHotDog.UseVisualStyleBackColor = true;
            this.cbxHotDog.CheckedChanged += new System.EventHandler(this.cbxCocaCola_CheckedChanged);
            // 
            // cbxHamburger
            // 
            this.cbxHamburger.AutoSize = true;
            this.cbxHamburger.Location = new System.Drawing.Point(12, 83);
            this.cbxHamburger.Name = "cbxHamburger";
            this.cbxHamburger.Size = new System.Drawing.Size(80, 17);
            this.cbxHamburger.TabIndex = 23;
            this.cbxHamburger.Text = "Гамбургер";
            this.cbxHamburger.UseVisualStyleBackColor = true;
            this.cbxHamburger.CheckedChanged += new System.EventHandler(this.cbxCocaCola_CheckedChanged);
            // 
            // cbxFrenchFries
            // 
            this.cbxFrenchFries.AutoSize = true;
            this.cbxFrenchFries.Location = new System.Drawing.Point(12, 106);
            this.cbxFrenchFries.Name = "cbxFrenchFries";
            this.cbxFrenchFries.Size = new System.Drawing.Size(76, 17);
            this.cbxFrenchFries.TabIndex = 22;
            this.cbxFrenchFries.Text = "Карт.Фри";
            this.cbxFrenchFries.UseVisualStyleBackColor = true;
            this.cbxFrenchFries.CheckedChanged += new System.EventHandler(this.cbxCocaCola_CheckedChanged);
            // 
            // cbxCocaCola
            // 
            this.cbxCocaCola.AutoSize = true;
            this.cbxCocaCola.Location = new System.Drawing.Point(12, 132);
            this.cbxCocaCola.Name = "cbxCocaCola";
            this.cbxCocaCola.Size = new System.Drawing.Size(79, 17);
            this.cbxCocaCola.TabIndex = 21;
            this.cbxCocaCola.Text = "Кока-Кола";
            this.cbxCocaCola.UseVisualStyleBackColor = true;
            this.cbxCocaCola.CheckedChanged += new System.EventHandler(this.cbxCocaCola_CheckedChanged);
            // 
            // tbxHotDogPrice
            // 
            this.tbxHotDogPrice.Location = new System.Drawing.Point(154, 51);
            this.tbxHotDogPrice.Name = "tbxHotDogPrice";
            this.tbxHotDogPrice.Size = new System.Drawing.Size(68, 20);
            this.tbxHotDogPrice.TabIndex = 13;
            this.tbxHotDogPrice.Text = "100";
            // 
            // tbxHamburgerPrice
            // 
            this.tbxHamburgerPrice.Location = new System.Drawing.Point(154, 77);
            this.tbxHamburgerPrice.Name = "tbxHamburgerPrice";
            this.tbxHamburgerPrice.Size = new System.Drawing.Size(68, 20);
            this.tbxHamburgerPrice.TabIndex = 12;
            this.tbxHamburgerPrice.Text = "125";
            // 
            // tbxFrenchFriesPrice
            // 
            this.tbxFrenchFriesPrice.Location = new System.Drawing.Point(154, 103);
            this.tbxFrenchFriesPrice.Name = "tbxFrenchFriesPrice";
            this.tbxFrenchFriesPrice.Size = new System.Drawing.Size(68, 20);
            this.tbxFrenchFriesPrice.TabIndex = 11;
            this.tbxFrenchFriesPrice.Text = "65";
            // 
            // tbxCocaColaPrice
            // 
            this.tbxCocaColaPrice.Location = new System.Drawing.Point(154, 129);
            this.tbxCocaColaPrice.Name = "tbxCocaColaPrice";
            this.tbxCocaColaPrice.Size = new System.Drawing.Size(68, 20);
            this.tbxCocaColaPrice.TabIndex = 10;
            this.tbxCocaColaPrice.Text = "40";
            // 
            // nudHamburger
            // 
            this.nudHamburger.Location = new System.Drawing.Point(228, 77);
            this.nudHamburger.Name = "nudHamburger";
            this.nudHamburger.Size = new System.Drawing.Size(49, 20);
            this.nudHamburger.TabIndex = 9;
            this.nudHamburger.ValueChanged += new System.EventHandler(this.nudCocaCola_ValueChanged);
            // 
            // nudFrenchFries
            // 
            this.nudFrenchFries.Location = new System.Drawing.Point(228, 103);
            this.nudFrenchFries.Name = "nudFrenchFries";
            this.nudFrenchFries.Size = new System.Drawing.Size(49, 20);
            this.nudFrenchFries.TabIndex = 8;
            this.nudFrenchFries.ValueChanged += new System.EventHandler(this.nudCocaCola_ValueChanged);
            // 
            // nudCocaCola
            // 
            this.nudCocaCola.Location = new System.Drawing.Point(228, 129);
            this.nudCocaCola.Name = "nudCocaCola";
            this.nudCocaCola.Size = new System.Drawing.Size(49, 20);
            this.nudCocaCola.TabIndex = 7;
            this.nudCocaCola.ValueChanged += new System.EventHandler(this.nudCocaCola_ValueChanged);
            // 
            // nudHotDog
            // 
            this.nudHotDog.Location = new System.Drawing.Point(228, 51);
            this.nudHotDog.Name = "nudHotDog";
            this.nudHotDog.Size = new System.Drawing.Size(49, 20);
            this.nudHotDog.TabIndex = 6;
            this.nudHotDog.ValueChanged += new System.EventHandler(this.nudCocaCola_ValueChanged);
            // 
            // gbxToPayCafe
            // 
            this.gbxToPayCafe.Controls.Add(this.tbxToPayCafe);
            this.gbxToPayCafe.Controls.Add(this.lblUah4);
            this.gbxToPayCafe.Location = new System.Drawing.Point(6, 397);
            this.gbxToPayCafe.Name = "gbxToPayCafe";
            this.gbxToPayCafe.Size = new System.Drawing.Size(277, 100);
            this.gbxToPayCafe.TabIndex = 1;
            this.gbxToPayCafe.TabStop = false;
            this.gbxToPayCafe.Text = "К оплате";
            // 
            // tbxToPayCafe
            // 
            this.tbxToPayCafe.BackColor = System.Drawing.SystemColors.Control;
            this.tbxToPayCafe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxToPayCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxToPayCafe.Location = new System.Drawing.Point(6, 38);
            this.tbxToPayCafe.Name = "tbxToPayCafe";
            this.tbxToPayCafe.Size = new System.Drawing.Size(224, 31);
            this.tbxToPayCafe.TabIndex = 17;
            this.tbxToPayCafe.Text = "0";
            this.tbxToPayCafe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblUah4
            // 
            this.lblUah4.AutoSize = true;
            this.lblUah4.Location = new System.Drawing.Point(236, 53);
            this.lblUah4.Name = "lblUah4";
            this.lblUah4.Size = new System.Drawing.Size(29, 13);
            this.lblUah4.TabIndex = 9;
            this.lblUah4.Text = "РУБ";
            // 
            // lblPriceCafe
            // 
            this.lblPriceCafe.AutoSize = true;
            this.lblPriceCafe.Location = new System.Drawing.Point(151, 16);
            this.lblPriceCafe.Name = "lblPriceCafe";
            this.lblPriceCafe.Size = new System.Drawing.Size(33, 13);
            this.lblPriceCafe.TabIndex = 5;
            this.lblPriceCafe.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество";
            // 
            // gbxToPayStation
            // 
            this.gbxToPayStation.Controls.Add(this.tbxToPayStation);
            this.gbxToPayStation.Controls.Add(this.lblUah3);
            this.gbxToPayStation.Location = new System.Drawing.Point(6, 397);
            this.gbxToPayStation.Name = "gbxToPayStation";
            this.gbxToPayStation.Size = new System.Drawing.Size(294, 100);
            this.gbxToPayStation.TabIndex = 1;
            this.gbxToPayStation.TabStop = false;
            this.gbxToPayStation.Text = "К оплате";
            // 
            // tbxToPayStation
            // 
            this.tbxToPayStation.BackColor = System.Drawing.SystemColors.Control;
            this.tbxToPayStation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxToPayStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxToPayStation.Location = new System.Drawing.Point(6, 38);
            this.tbxToPayStation.Name = "tbxToPayStation";
            this.tbxToPayStation.Size = new System.Drawing.Size(241, 31);
            this.tbxToPayStation.TabIndex = 18;
            this.tbxToPayStation.Text = "0";
            this.tbxToPayStation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblUah3
            // 
            this.lblUah3.AutoSize = true;
            this.lblUah3.Location = new System.Drawing.Point(253, 53);
            this.lblUah3.Name = "lblUah3";
            this.lblUah3.Size = new System.Drawing.Size(29, 13);
            this.lblUah3.TabIndex = 10;
            this.lblUah3.Text = "РУБ";
            // 
            // gbxTotalToPay
            // 
            this.gbxTotalToPay.Controls.Add(this.tbxToPayTotal);
            this.gbxTotalToPay.Controls.Add(this.btnCheck);
            this.gbxTotalToPay.Controls.Add(this.lblUah5);
            this.gbxTotalToPay.Location = new System.Drawing.Point(12, 521);
            this.gbxTotalToPay.Name = "gbxTotalToPay";
            this.gbxTotalToPay.Size = new System.Drawing.Size(601, 100);
            this.gbxTotalToPay.TabIndex = 1;
            this.gbxTotalToPay.TabStop = false;
            this.gbxTotalToPay.Text = "Итого к оплате";
            // 
            // tbxToPayTotal
            // 
            this.tbxToPayTotal.BackColor = System.Drawing.SystemColors.Control;
            this.tbxToPayTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxToPayTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxToPayTotal.Location = new System.Drawing.Point(87, 47);
            this.tbxToPayTotal.Name = "tbxToPayTotal";
            this.tbxToPayTotal.Size = new System.Drawing.Size(461, 31);
            this.tbxToPayTotal.TabIndex = 16;
            this.tbxToPayTotal.Text = "0";
            this.tbxToPayTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(6, 26);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 52);
            this.btnCheck.TabIndex = 15;
            this.btnCheck.Text = "Чек";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblUah5
            // 
            this.lblUah5.AutoSize = true;
            this.lblUah5.Location = new System.Drawing.Point(560, 65);
            this.lblUah5.Name = "lblUah5";
            this.lblUah5.Size = new System.Drawing.Size(29, 13);
            this.lblUah5.TabIndex = 8;
            this.lblUah5.Text = "РУБ";
            // 
            // gbxStation
            // 
            this.gbxStation.Controls.Add(this.cbxFuel);
            this.gbxStation.Controls.Add(this.tbxPrice);
            this.gbxStation.Controls.Add(this.tbxAmount);
            this.gbxStation.Controls.Add(this.tbxQuantity);
            this.gbxStation.Controls.Add(this.gbxVariants);
            this.gbxStation.Controls.Add(this.lblUah2);
            this.gbxStation.Controls.Add(this.lblPrice);
            this.gbxStation.Controls.Add(this.lblUah);
            this.gbxStation.Controls.Add(this.lblLiter);
            this.gbxStation.Controls.Add(this.lblFuel);
            this.gbxStation.Controls.Add(this.gbxToPayStation);
            this.gbxStation.Location = new System.Drawing.Point(12, 12);
            this.gbxStation.Name = "gbxStation";
            this.gbxStation.Size = new System.Drawing.Size(306, 503);
            this.gbxStation.TabIndex = 1;
            this.gbxStation.TabStop = false;
            this.gbxStation.Text = "Заправочная станция";
            // 
            // cbxFuel
            // 
            this.cbxFuel.DisplayMember = "32";
            this.cbxFuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFuel.FormattingEnabled = true;
            this.cbxFuel.Items.AddRange(new object[] {
            "A92",
            "A95"});
            this.cbxFuel.Location = new System.Drawing.Point(68, 32);
            this.cbxFuel.Name = "cbxFuel";
            this.cbxFuel.Size = new System.Drawing.Size(121, 21);
            this.cbxFuel.TabIndex = 18;
            this.cbxFuel.SelectedIndexChanged += new System.EventHandler(this.cbFuel_SelectedIndexChanged);
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(68, 72);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(121, 20);
            this.tbxPrice.TabIndex = 15;
            this.tbxPrice.Text = "0";
            // 
            // tbxAmount
            // 
            this.tbxAmount.Location = new System.Drawing.Point(121, 207);
            this.tbxAmount.Name = "tbxAmount";
            this.tbxAmount.Size = new System.Drawing.Size(68, 20);
            this.tbxAmount.TabIndex = 16;
            this.tbxAmount.Text = "0";
            this.tbxAmount.TextChanged += new System.EventHandler(this.tbxQuantity_TextChanged);
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(121, 170);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(68, 20);
            this.tbxQuantity.TabIndex = 17;
            this.tbxQuantity.Text = "0";
            this.tbxQuantity.TextChanged += new System.EventHandler(this.tbxQuantity_TextChanged);
            // 
            // gbxVariants
            // 
            this.gbxVariants.Controls.Add(this.rbtnAmount);
            this.gbxVariants.Controls.Add(this.rbtnQuantity);
            this.gbxVariants.Location = new System.Drawing.Point(6, 152);
            this.gbxVariants.Name = "gbxVariants";
            this.gbxVariants.Size = new System.Drawing.Size(109, 99);
            this.gbxVariants.TabIndex = 9;
            this.gbxVariants.TabStop = false;
            // 
            // rbtnAmount
            // 
            this.rbtnAmount.AutoSize = true;
            this.rbtnAmount.Location = new System.Drawing.Point(6, 58);
            this.rbtnAmount.Name = "rbtnAmount";
            this.rbtnAmount.Size = new System.Drawing.Size(63, 17);
            this.rbtnAmount.TabIndex = 1;
            this.rbtnAmount.Text = "Деньги";
            this.rbtnAmount.UseVisualStyleBackColor = true;
            this.rbtnAmount.CheckedChanged += new System.EventHandler(this.rbtnAmount_CheckedChanged);
            // 
            // rbtnQuantity
            // 
            this.rbtnQuantity.AutoSize = true;
            this.rbtnQuantity.Checked = true;
            this.rbtnQuantity.Location = new System.Drawing.Point(6, 19);
            this.rbtnQuantity.Name = "rbtnQuantity";
            this.rbtnQuantity.Size = new System.Drawing.Size(84, 17);
            this.rbtnQuantity.TabIndex = 0;
            this.rbtnQuantity.TabStop = true;
            this.rbtnQuantity.Text = "Количество";
            this.rbtnQuantity.UseVisualStyleBackColor = true;
            this.rbtnQuantity.CheckedChanged += new System.EventHandler(this.rbtnAmount_CheckedChanged);
            // 
            // lblUah2
            // 
            this.lblUah2.AutoSize = true;
            this.lblUah2.Location = new System.Drawing.Point(245, 212);
            this.lblUah2.Name = "lblUah2";
            this.lblUah2.Size = new System.Drawing.Size(29, 13);
            this.lblUah2.TabIndex = 8;
            this.lblUah2.Text = "РУБ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(6, 75);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 13);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Цена";
            // 
            // lblUah
            // 
            this.lblUah.AutoSize = true;
            this.lblUah.Location = new System.Drawing.Point(245, 79);
            this.lblUah.Name = "lblUah";
            this.lblUah.Size = new System.Drawing.Size(29, 13);
            this.lblUah.TabIndex = 6;
            this.lblUah.Text = "РУБ";
            // 
            // lblLiter
            // 
            this.lblLiter.AutoSize = true;
            this.lblLiter.Location = new System.Drawing.Point(245, 173);
            this.lblLiter.Name = "lblLiter";
            this.lblLiter.Size = new System.Drawing.Size(15, 13);
            this.lblLiter.TabIndex = 3;
            this.lblLiter.Text = "Л";
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Location = new System.Drawing.Point(6, 35);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(50, 13);
            this.lblFuel.TabIndex = 2;
            this.lblFuel.Text = "Топливо";
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(457, 627);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 23);
            this.btnCompute.TabIndex = 12;
            this.btnCompute.Text = "Расчитать";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSettings.Location = new System.Drawing.Point(538, 627);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 14;
            this.btnSettings.Text = "Настройки";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 659);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(625, 22);
            this.statusStrip1.TabIndex = 15;
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
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(625, 681);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.gbxTotalToPay);
            this.Controls.Add(this.gbxStation);
            this.Controls.Add(this.gbxCafe);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "fMain";
            this.Text = "BestOil";
            this.TransparencyKey = System.Drawing.Color.Blue;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
            this.Load += new System.EventHandler(this.fMain_Load);
            this.gbxCafe.ResumeLayout(false);
            this.gbxCafe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHamburger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrenchFries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCocaCola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHotDog)).EndInit();
            this.gbxToPayCafe.ResumeLayout(false);
            this.gbxToPayCafe.PerformLayout();
            this.gbxToPayStation.ResumeLayout(false);
            this.gbxToPayStation.PerformLayout();
            this.gbxTotalToPay.ResumeLayout(false);
            this.gbxTotalToPay.PerformLayout();
            this.gbxStation.ResumeLayout(false);
            this.gbxStation.PerformLayout();
            this.gbxVariants.ResumeLayout(false);
            this.gbxVariants.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCafe;
        private System.Windows.Forms.CheckBox cbxHotDog;
        private System.Windows.Forms.CheckBox cbxHamburger;
        private System.Windows.Forms.CheckBox cbxFrenchFries;
        private System.Windows.Forms.CheckBox cbxCocaCola;
        private System.Windows.Forms.TextBox tbxHotDogPrice;
        private System.Windows.Forms.TextBox tbxHamburgerPrice;
        private System.Windows.Forms.TextBox tbxFrenchFriesPrice;
        private System.Windows.Forms.TextBox tbxCocaColaPrice;
        private System.Windows.Forms.NumericUpDown nudHamburger;
        private System.Windows.Forms.NumericUpDown nudFrenchFries;
        private System.Windows.Forms.NumericUpDown nudCocaCola;
        private System.Windows.Forms.NumericUpDown nudHotDog;
        private System.Windows.Forms.GroupBox gbxToPayCafe;
        private System.Windows.Forms.TextBox tbxToPayCafe;
        private System.Windows.Forms.Label lblUah4;
        private System.Windows.Forms.Label lblPriceCafe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxToPayStation;
        private System.Windows.Forms.TextBox tbxToPayStation;
        private System.Windows.Forms.Label lblUah3;
        private System.Windows.Forms.GroupBox gbxTotalToPay;
        private System.Windows.Forms.TextBox tbxToPayTotal;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblUah5;
        private System.Windows.Forms.GroupBox gbxStation;
        private System.Windows.Forms.ComboBox cbxFuel;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.TextBox tbxAmount;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.GroupBox gbxVariants;
        private System.Windows.Forms.RadioButton rbtnAmount;
        private System.Windows.Forms.RadioButton rbtnQuantity;
        private System.Windows.Forms.Label lblUah2;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblUah;
        private System.Windows.Forms.Label lblLiter;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}

