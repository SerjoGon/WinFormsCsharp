namespace HW_8_BestOil
{
    partial class fSettings
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
            this.btnReset = new System.Windows.Forms.Button();
            this.tbxGain = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxCurrency = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPause = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxEditGasPrice = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxA92Price = new System.Windows.Forms.TextBox();
            this.tbxA95Price = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.gbxEditCafePrice = new System.Windows.Forms.GroupBox();
            this.lblCocaCola = new System.Windows.Forms.Label();
            this.lblFrenchFries = new System.Windows.Forms.Label();
            this.lblHamburger = new System.Windows.Forms.Label();
            this.lblHotDog = new System.Windows.Forms.Label();
            this.tbxCocaColaPrice = new System.Windows.Forms.TextBox();
            this.tbxFrenchFriesPrice = new System.Windows.Forms.TextBox();
            this.tbxHotDogPrice = new System.Windows.Forms.TextBox();
            this.tbxHamburgerPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPause)).BeginInit();
            this.gbxEditGasPrice.SuspendLayout();
            this.gbxEditCafePrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(231, 103);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 20);
            this.btnReset.TabIndex = 35;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tbxGain
            // 
            this.tbxGain.Enabled = false;
            this.tbxGain.Location = new System.Drawing.Point(263, 77);
            this.tbxGain.Name = "tbxGain";
            this.tbxGain.Size = new System.Drawing.Size(60, 20);
            this.tbxGain.TabIndex = 34;
            this.tbxGain.Text = "0,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Общ.Итог";
            // 
            // tbxCurrency
            // 
            this.tbxCurrency.Location = new System.Drawing.Point(231, 51);
            this.tbxCurrency.Name = "tbxCurrency";
            this.tbxCurrency.Size = new System.Drawing.Size(92, 20);
            this.tbxCurrency.TabIndex = 32;
            this.tbxCurrency.Text = "РУБ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Валюта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "s";
            // 
            // nudPause
            // 
            this.nudPause.Location = new System.Drawing.Point(271, 25);
            this.nudPause.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudPause.Name = "nudPause";
            this.nudPause.Size = new System.Drawing.Size(34, 20);
            this.nudPause.TabIndex = 29;
            this.nudPause.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Время до очистки";
            // 
            // gbxEditGasPrice
            // 
            this.gbxEditGasPrice.Controls.Add(this.label3);
            this.gbxEditGasPrice.Controls.Add(this.label4);
            this.gbxEditGasPrice.Controls.Add(this.tbxA92Price);
            this.gbxEditGasPrice.Controls.Add(this.tbxA95Price);
            this.gbxEditGasPrice.Location = new System.Drawing.Point(11, 12);
            this.gbxEditGasPrice.Name = "gbxEditGasPrice";
            this.gbxEditGasPrice.Size = new System.Drawing.Size(156, 81);
            this.gbxEditGasPrice.TabIndex = 27;
            this.gbxEditGasPrice.TabStop = false;
            this.gbxEditGasPrice.Text = "Установка цены топлива";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "A95";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "A92";
            // 
            // tbxA92Price
            // 
            this.tbxA92Price.Location = new System.Drawing.Point(90, 24);
            this.tbxA92Price.Name = "tbxA92Price";
            this.tbxA92Price.Size = new System.Drawing.Size(54, 20);
            this.tbxA92Price.TabIndex = 20;
            this.tbxA92Price.Text = "48,80";
            // 
            // tbxA95Price
            // 
            this.tbxA95Price.Location = new System.Drawing.Point(90, 50);
            this.tbxA95Price.Name = "tbxA95Price";
            this.tbxA95Price.Size = new System.Drawing.Size(54, 20);
            this.tbxA95Price.TabIndex = 19;
            this.tbxA95Price.Text = "54,20";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(165, 336);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(246, 336);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 25;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // gbxEditCafePrice
            // 
            this.gbxEditCafePrice.Controls.Add(this.lblCocaCola);
            this.gbxEditCafePrice.Controls.Add(this.lblFrenchFries);
            this.gbxEditCafePrice.Controls.Add(this.lblHamburger);
            this.gbxEditCafePrice.Controls.Add(this.lblHotDog);
            this.gbxEditCafePrice.Controls.Add(this.tbxCocaColaPrice);
            this.gbxEditCafePrice.Controls.Add(this.tbxFrenchFriesPrice);
            this.gbxEditCafePrice.Controls.Add(this.tbxHotDogPrice);
            this.gbxEditCafePrice.Controls.Add(this.tbxHamburgerPrice);
            this.gbxEditCafePrice.Location = new System.Drawing.Point(11, 99);
            this.gbxEditCafePrice.Name = "gbxEditCafePrice";
            this.gbxEditCafePrice.Size = new System.Drawing.Size(156, 135);
            this.gbxEditCafePrice.TabIndex = 24;
            this.gbxEditCafePrice.TabStop = false;
            this.gbxEditCafePrice.Text = "Установка цен кафе";
            // 
            // lblCocaCola
            // 
            this.lblCocaCola.AutoSize = true;
            this.lblCocaCola.Location = new System.Drawing.Point(6, 105);
            this.lblCocaCola.Name = "lblCocaCola";
            this.lblCocaCola.Size = new System.Drawing.Size(60, 13);
            this.lblCocaCola.TabIndex = 26;
            this.lblCocaCola.Text = "Кока-Кола";
            // 
            // lblFrenchFries
            // 
            this.lblFrenchFries.AutoSize = true;
            this.lblFrenchFries.Location = new System.Drawing.Point(6, 79);
            this.lblFrenchFries.Name = "lblFrenchFries";
            this.lblFrenchFries.Size = new System.Drawing.Size(57, 13);
            this.lblFrenchFries.TabIndex = 25;
            this.lblFrenchFries.Text = "Карт.Фри";
            // 
            // lblHamburger
            // 
            this.lblHamburger.AutoSize = true;
            this.lblHamburger.Location = new System.Drawing.Point(6, 53);
            this.lblHamburger.Name = "lblHamburger";
            this.lblHamburger.Size = new System.Drawing.Size(61, 13);
            this.lblHamburger.TabIndex = 24;
            this.lblHamburger.Text = "Гамбургер";
            // 
            // lblHotDog
            // 
            this.lblHotDog.AutoSize = true;
            this.lblHotDog.Location = new System.Drawing.Point(6, 27);
            this.lblHotDog.Name = "lblHotDog";
            this.lblHotDog.Size = new System.Drawing.Size(48, 13);
            this.lblHotDog.TabIndex = 23;
            this.lblHotDog.Text = "Хот-Дог";
            // 
            // tbxCocaColaPrice
            // 
            this.tbxCocaColaPrice.Location = new System.Drawing.Point(90, 102);
            this.tbxCocaColaPrice.Name = "tbxCocaColaPrice";
            this.tbxCocaColaPrice.Size = new System.Drawing.Size(54, 20);
            this.tbxCocaColaPrice.TabIndex = 22;
            this.tbxCocaColaPrice.Text = "40";
            // 
            // tbxFrenchFriesPrice
            // 
            this.tbxFrenchFriesPrice.Location = new System.Drawing.Point(90, 76);
            this.tbxFrenchFriesPrice.Name = "tbxFrenchFriesPrice";
            this.tbxFrenchFriesPrice.Size = new System.Drawing.Size(54, 20);
            this.tbxFrenchFriesPrice.TabIndex = 21;
            this.tbxFrenchFriesPrice.Text = "65";
            // 
            // tbxHotDogPrice
            // 
            this.tbxHotDogPrice.Location = new System.Drawing.Point(90, 24);
            this.tbxHotDogPrice.Name = "tbxHotDogPrice";
            this.tbxHotDogPrice.Size = new System.Drawing.Size(54, 20);
            this.tbxHotDogPrice.TabIndex = 20;
            this.tbxHotDogPrice.Text = "100";
            // 
            // tbxHamburgerPrice
            // 
            this.tbxHamburgerPrice.Location = new System.Drawing.Point(90, 50);
            this.tbxHamburgerPrice.Name = "tbxHamburgerPrice";
            this.tbxHamburgerPrice.Size = new System.Drawing.Size(54, 20);
            this.tbxHamburgerPrice.TabIndex = 19;
            this.tbxHamburgerPrice.Text = "125";
            // 
            // fSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 371);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tbxGain);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxCurrency);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudPause);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxEditGasPrice);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbxEditCafePrice);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.fSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPause)).EndInit();
            this.gbxEditGasPrice.ResumeLayout(false);
            this.gbxEditGasPrice.PerformLayout();
            this.gbxEditCafePrice.ResumeLayout(false);
            this.gbxEditCafePrice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbxGain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxCurrency;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPause;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxEditGasPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxA92Price;
        private System.Windows.Forms.TextBox tbxA95Price;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox gbxEditCafePrice;
        private System.Windows.Forms.Label lblCocaCola;
        private System.Windows.Forms.Label lblFrenchFries;
        private System.Windows.Forms.Label lblHamburger;
        private System.Windows.Forms.Label lblHotDog;
        private System.Windows.Forms.TextBox tbxCocaColaPrice;
        private System.Windows.Forms.TextBox tbxFrenchFriesPrice;
        private System.Windows.Forms.TextBox tbxHotDogPrice;
        private System.Windows.Forms.TextBox tbxHamburgerPrice;
    }
}