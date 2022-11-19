namespace FileExplorerWF
{
    partial class FormFileExplorer
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_forward = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textboxfilePath = new System.Windows.Forms.TextBox();
            this.label_FN = new System.Windows.Forms.Label();
            this.lb_FileName = new System.Windows.Forms.Label();
            this.label_FT = new System.Windows.Forms.Label();
            this.lb_FileType = new System.Windows.Forms.Label();
            this.lb_path = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(45, 23);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "<<";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // btn_forward
            // 
            this.btn_forward.Location = new System.Drawing.Point(748, 5);
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Size = new System.Drawing.Size(40, 23);
            this.btn_forward.TabIndex = 1;
            this.btn_forward.Text = ">>";
            this.btn_forward.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 340);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textboxfilePath.Location = new System.Drawing.Point(151, 5);
            this.textboxfilePath.Name = "textBox1";
            this.textboxfilePath.Size = new System.Drawing.Size(591, 23);
            this.textboxfilePath.TabIndex = 3;
            // 
            // label_FN
            // 
            this.label_FN.AutoSize = true;
            this.label_FN.Location = new System.Drawing.Point(12, 415);
            this.label_FN.Name = "label_FN";
            this.label_FN.Size = new System.Drawing.Size(69, 15);
            this.label_FN.TabIndex = 4;
            this.label_FN.Text = "Имя Файла";
            // 
            // lb_FileName
            // 
            this.lb_FileName.AutoSize = true;
            this.lb_FileName.Location = new System.Drawing.Point(87, 415);
            this.lb_FileName.Name = "lb_FileName";
            this.lb_FileName.Size = new System.Drawing.Size(17, 15);
            this.lb_FileName.TabIndex = 5;
            this.lb_FileName.Text = "--";
            // 
            // label_FT
            // 
            this.label_FT.AutoSize = true;
            this.label_FT.Location = new System.Drawing.Point(677, 415);
            this.label_FT.Name = "label_FT";
            this.label_FT.Size = new System.Drawing.Size(65, 15);
            this.label_FT.TabIndex = 6;
            this.label_FT.Text = "Тип Файла";
            // 
            // lb_FileType
            // 
            this.lb_FileType.AutoSize = true;
            this.lb_FileType.Location = new System.Drawing.Point(748, 415);
            this.lb_FileType.Name = "lb_FileType";
            this.lb_FileType.Size = new System.Drawing.Size(17, 15);
            this.lb_FileType.TabIndex = 7;
            this.lb_FileType.Text = "--";
            // 
            // lb_path
            // 
            this.lb_path.AutoSize = true;
            this.lb_path.Location = new System.Drawing.Point(112, 9);
            this.lb_path.Name = "lb_path";
            this.lb_path.Size = new System.Drawing.Size(33, 15);
            this.lb_path.TabIndex = 8;
            this.lb_path.Text = "Путь";
            // 
            // FormFileExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_path);
            this.Controls.Add(this.lb_FileType);
            this.Controls.Add(this.label_FT);
            this.Controls.Add(this.lb_FileName);
            this.Controls.Add(this.label_FN);
            this.Controls.Add(this.textboxfilePath);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_forward);
            this.Controls.Add(this.btn_back);
            this.Name = "FormFileExplorer";
            this.Text = "FileExplorer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_back;
        private Button btn_forward;
        private ListView listView1;
        private TextBox textboxfilePath;
        private Label label_FN;
        private Label lb_FileName;
        private Label label_FT;
        private Label lb_FileType;
        private Label lb_path;
    }
}