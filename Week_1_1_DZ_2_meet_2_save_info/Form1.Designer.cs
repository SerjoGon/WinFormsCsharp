namespace Week_1_1_DZ_2_meet_2_save_info
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name_lbl = new System.Windows.Forms.Label();
            this.lastname_lbl = new System.Windows.Forms.Label();
            this.patronymic_lbl = new System.Windows.Forms.Label();
            this.other_gender_lbl = new System.Windows.Forms.Label();
            this.date_lbl = new System.Windows.Forms.Label();
            this.famaly_status_lbl = new System.Windows.Forms.Label();
            this.Save_btn = new System.Windows.Forms.Button();
            this.name_tbox = new System.Windows.Forms.TextBox();
            this.lastname_tbox = new System.Windows.Forms.TextBox();
            this.patronymic_tbox = new System.Windows.Forms.TextBox();
            this.gender_choice_gbox = new System.Windows.Forms.GroupBox();
            this.female_chbox = new System.Windows.Forms.CheckBox();
            this.male_chbox = new System.Windows.Forms.CheckBox();
            this.other_gender_tbox = new System.Windows.Forms.TextBox();
            this.date_tbox = new System.Windows.Forms.TextBox();
            this.Family_status_cbox = new System.Windows.Forms.ComboBox();
            this.dopinfo_rtbox = new System.Windows.Forms.RichTextBox();
            this.info_lbl = new System.Windows.Forms.Label();
            this.gender_choice_gbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(12, 11);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(31, 15);
            this.name_lbl.TabIndex = 0;
            this.name_lbl.Text = "Имя";
            // 
            // lastname_lbl
            // 
            this.lastname_lbl.AutoSize = true;
            this.lastname_lbl.Location = new System.Drawing.Point(237, 11);
            this.lastname_lbl.Name = "lastname_lbl";
            this.lastname_lbl.Size = new System.Drawing.Size(58, 15);
            this.lastname_lbl.TabIndex = 1;
            this.lastname_lbl.Text = "Фамилия";
            // 
            // patronymic_lbl
            // 
            this.patronymic_lbl.AutoSize = true;
            this.patronymic_lbl.Location = new System.Drawing.Point(463, 11);
            this.patronymic_lbl.Name = "patronymic_lbl";
            this.patronymic_lbl.Size = new System.Drawing.Size(58, 15);
            this.patronymic_lbl.TabIndex = 2;
            this.patronymic_lbl.Text = "Отчество";
            // 
            // other_gender_lbl
            // 
            this.other_gender_lbl.AutoSize = true;
            this.other_gender_lbl.Location = new System.Drawing.Point(6, 91);
            this.other_gender_lbl.Name = "other_gender_lbl";
            this.other_gender_lbl.Size = new System.Drawing.Size(127, 15);
            this.other_gender_lbl.TabIndex = 3;
            this.other_gender_lbl.Text = "Другое, вписать ниже";
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Location = new System.Drawing.Point(236, 79);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(90, 15);
            this.date_lbl.TabIndex = 4;
            this.date_lbl.Text = "Дата рождения";
            // 
            // famaly_status_lbl
            // 
            this.famaly_status_lbl.AutoSize = true;
            this.famaly_status_lbl.Location = new System.Drawing.Point(237, 170);
            this.famaly_status_lbl.Name = "famaly_status_lbl";
            this.famaly_status_lbl.Size = new System.Drawing.Size(129, 15);
            this.famaly_status_lbl.TabIndex = 5;
            this.famaly_status_lbl.Text = "Семейное положение";
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(617, 406);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(75, 23);
            this.Save_btn.TabIndex = 7;
            this.Save_btn.Text = "Сохранить";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // name_tbox
            // 
            this.name_tbox.Location = new System.Drawing.Point(12, 38);
            this.name_tbox.Name = "name_tbox";
            this.name_tbox.Size = new System.Drawing.Size(220, 23);
            this.name_tbox.TabIndex = 8;
            // 
            // lastname_tbox
            // 
            this.lastname_tbox.Location = new System.Drawing.Point(237, 38);
            this.lastname_tbox.Name = "lastname_tbox";
            this.lastname_tbox.Size = new System.Drawing.Size(220, 23);
            this.lastname_tbox.TabIndex = 9;
            // 
            // patronymic_tbox
            // 
            this.patronymic_tbox.Location = new System.Drawing.Point(463, 38);
            this.patronymic_tbox.Name = "patronymic_tbox";
            this.patronymic_tbox.Size = new System.Drawing.Size(230, 23);
            this.patronymic_tbox.TabIndex = 10;
            // 
            // gender_choice_gbox
            // 
            this.gender_choice_gbox.Controls.Add(this.female_chbox);
            this.gender_choice_gbox.Controls.Add(this.male_chbox);
            this.gender_choice_gbox.Controls.Add(this.other_gender_tbox);
            this.gender_choice_gbox.Controls.Add(this.other_gender_lbl);
            this.gender_choice_gbox.Location = new System.Drawing.Point(12, 79);
            this.gender_choice_gbox.Name = "gender_choice_gbox";
            this.gender_choice_gbox.Size = new System.Drawing.Size(218, 151);
            this.gender_choice_gbox.TabIndex = 11;
            this.gender_choice_gbox.TabStop = false;
            this.gender_choice_gbox.Text = "Пол";
            // 
            // female_chbox
            // 
            this.female_chbox.AutoSize = true;
            this.female_chbox.Location = new System.Drawing.Point(6, 65);
            this.female_chbox.Name = "female_chbox";
            this.female_chbox.Size = new System.Drawing.Size(53, 19);
            this.female_chbox.TabIndex = 17;
            this.female_chbox.Text = "Жен.";
            this.female_chbox.UseVisualStyleBackColor = true;
            this.female_chbox.CheckedChanged += new System.EventHandler(this.female_chbox_CheckedChanged);
            // 
            // male_chbox
            // 
            this.male_chbox.AutoSize = true;
            this.male_chbox.Location = new System.Drawing.Point(6, 24);
            this.male_chbox.Name = "male_chbox";
            this.male_chbox.Size = new System.Drawing.Size(55, 19);
            this.male_chbox.TabIndex = 16;
            this.male_chbox.Text = "Муж.";
            this.male_chbox.UseVisualStyleBackColor = true;
            this.male_chbox.CheckedChanged += new System.EventHandler(this.male_chbox_CheckedChanged);
            // 
            // other_gender_tbox
            // 
            this.other_gender_tbox.Location = new System.Drawing.Point(6, 109);
            this.other_gender_tbox.Name = "other_gender_tbox";
            this.other_gender_tbox.Size = new System.Drawing.Size(206, 23);
            this.other_gender_tbox.TabIndex = 15;
            // 
            // date_tbox
            // 
            this.date_tbox.Location = new System.Drawing.Point(236, 103);
            this.date_tbox.Name = "date_tbox";
            this.date_tbox.Size = new System.Drawing.Size(220, 23);
            this.date_tbox.TabIndex = 20;
            // 
            // Family_status_cbox
            // 
            this.Family_status_cbox.FormattingEnabled = true;
            this.Family_status_cbox.Items.AddRange(new object[] {
            "В браке",
            "Гражданский брак",
            "Не замужем",
            "Холост",
            "Отец одиночка ",
            "Мать одиночка"});
            this.Family_status_cbox.Location = new System.Drawing.Point(237, 188);
            this.Family_status_cbox.Name = "Family_status_cbox";
            this.Family_status_cbox.Size = new System.Drawing.Size(219, 23);
            this.Family_status_cbox.TabIndex = 21;
            // 
            // dopinfo_rtbox
            // 
            this.dopinfo_rtbox.Location = new System.Drawing.Point(463, 103);
            this.dopinfo_rtbox.Name = "dopinfo_rtbox";
            this.dopinfo_rtbox.Size = new System.Drawing.Size(229, 108);
            this.dopinfo_rtbox.TabIndex = 22;
            this.dopinfo_rtbox.Text = "";
            // 
            // info_lbl
            // 
            this.info_lbl.AutoSize = true;
            this.info_lbl.Location = new System.Drawing.Point(463, 79);
            this.info_lbl.Name = "info_lbl";
            this.info_lbl.Size = new System.Drawing.Size(175, 15);
            this.info_lbl.TabIndex = 23;
            this.info_lbl.Text = "Дополнительная информация";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.info_lbl);
            this.Controls.Add(this.dopinfo_rtbox);
            this.Controls.Add(this.Family_status_cbox);
            this.Controls.Add(this.date_tbox);
            this.Controls.Add(this.gender_choice_gbox);
            this.Controls.Add(this.famaly_status_lbl);
            this.Controls.Add(this.patronymic_tbox);
            this.Controls.Add(this.date_lbl);
            this.Controls.Add(this.lastname_tbox);
            this.Controls.Add(this.name_tbox);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.patronymic_lbl);
            this.Controls.Add(this.lastname_lbl);
            this.Controls.Add(this.name_lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gender_choice_gbox.ResumeLayout(false);
            this.gender_choice_gbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label name_lbl;
        private Label lastname_lbl;
        private Label patronymic_lbl;
        private Label other_gender_lbl;
        private Label date_lbl;
        private Label famaly_status_lbl;
        private Button Save_btn;
        private TextBox name_tbox;
        private TextBox lastname_tbox;
        private TextBox patronymic_tbox;
        private GroupBox gender_choice_gbox;
        private CheckBox female_chbox;
        private CheckBox male_chbox;
        private TextBox other_gender_tbox;
        private TextBox date_tbox;
        private ComboBox Family_status_cbox;
        private RichTextBox dopinfo_rtbox;
        private Label info_lbl;
    }
}