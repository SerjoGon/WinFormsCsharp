namespace Class19_10_22_WinFormsStart
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
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(12, 321);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(657, 117);
            this.btn_Open.TabIndex = 0;
            this.btn_Open.Text = "Открыть";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // btn_Play
            // 
            this.btn_Play.Location = new System.Drawing.Point(12, 12);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(255, 303);
            this.btn_Play.TabIndex = 1;
            this.btn_Play.Text = "Играть";
            this.btn_Play.UseVisualStyleBackColor = true;
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.SystemColors.Info;
            this.btn_Stop.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Stop.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Stop.Location = new System.Drawing.Point(675, 12);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(113, 426);
            this.btn_Stop.TabIndex = 2;
            this.btn_Stop.Text = "Стоп";
            this.btn_Stop.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.btn_Open);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Open;
        private Button btn_Play;
        private Button btn_Stop;
        private OpenFileDialog OFD;
    }
}