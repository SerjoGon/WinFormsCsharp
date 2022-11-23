namespace FileExplorerWinForm
{
    partial class FileExplorerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileExplorerForm));
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_forward = new System.Windows.Forms.Button();
            this.lb_fn = new System.Windows.Forms.Label();
            this.lb_filename = new System.Windows.Forms.Label();
            this.label_ft = new System.Windows.Forms.Label();
            this.lb_filetype = new System.Windows.Forms.Label();
            this.lbl_path = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(0, 0);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "<<";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_forward
            // 
            this.btn_forward.Location = new System.Drawing.Point(723, 0);
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Size = new System.Drawing.Size(75, 23);
            this.btn_forward.TabIndex = 1;
            this.btn_forward.Text = ">>";
            this.btn_forward.UseVisualStyleBackColor = true;
            this.btn_forward.Click += new System.EventHandler(this.btn_forward_Click);
            // 
            // lb_fn
            // 
            this.lb_fn.AutoSize = true;
            this.lb_fn.Location = new System.Drawing.Point(12, 415);
            this.lb_fn.Name = "lb_fn";
            this.lb_fn.Size = new System.Drawing.Size(69, 15);
            this.lb_fn.TabIndex = 2;
            this.lb_fn.Text = "Имя файла";
            // 
            // lb_filename
            // 
            this.lb_filename.AutoSize = true;
            this.lb_filename.Location = new System.Drawing.Point(87, 415);
            this.lb_filename.Name = "lb_filename";
            this.lb_filename.Size = new System.Drawing.Size(17, 15);
            this.lb_filename.TabIndex = 3;
            this.lb_filename.Text = "--";
            // 
            // label_ft
            // 
            this.label_ft.AutoSize = true;
            this.label_ft.Location = new System.Drawing.Point(553, 415);
            this.label_ft.Name = "label_ft";
            this.label_ft.Size = new System.Drawing.Size(65, 15);
            this.label_ft.TabIndex = 4;
            this.label_ft.Text = "Тип файла";
            // 
            // lb_filetype
            // 
            this.lb_filetype.AutoSize = true;
            this.lb_filetype.Location = new System.Drawing.Point(634, 415);
            this.lb_filetype.Name = "lb_filetype";
            this.lb_filetype.Size = new System.Drawing.Size(17, 15);
            this.lb_filetype.TabIndex = 5;
            this.lb_filetype.Text = "--";
            // 
            // lbl_path
            // 
            this.lbl_path.AutoSize = true;
            this.lbl_path.Location = new System.Drawing.Point(81, 4);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(33, 15);
            this.lbl_path.TabIndex = 6;
            this.lbl_path.Text = "Путь";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(125, 1);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(592, 23);
            this.textBoxPath.TabIndex = 7;
            // 
            // listView
            // 
            this.listView.LargeImageList = this.iconList;
            this.listView.Location = new System.Drawing.Point(227, 30);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(571, 370);
            this.listView.SmallImageList = this.iconList;
            this.listView.TabIndex = 8;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_ItemSelectionChanged);
            this.listView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDoubleClick);
            // 
            // iconList
            // 
            this.iconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "Actionsdocument.ico");
            this.iconList.Images.SetKeyName(1, "Documents.ico");
            this.iconList.Images.SetKeyName(2, "DOC.ico");
            this.iconList.Images.SetKeyName(3, "DOCXXX.ico");
            this.iconList.Images.SetKeyName(4, "Images.ico");
            this.iconList.Images.SetKeyName(5, "Movies.ico");
            this.iconList.Images.SetKeyName(6, "MPtree.ico");
            this.iconList.Images.SetKeyName(7, "PDFEE.ico");
            this.iconList.Images.SetKeyName(8, "Exe-file.ico");
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 30);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(221, 370);
            this.treeView1.TabIndex = 9;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // FileExplorerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.lbl_path);
            this.Controls.Add(this.lb_filetype);
            this.Controls.Add(this.label_ft);
            this.Controls.Add(this.lb_filename);
            this.Controls.Add(this.lb_fn);
            this.Controls.Add(this.btn_forward);
            this.Controls.Add(this.btn_back);
            this.Name = "FileExplorerForm";
            this.Text = "FileExplorer";
            this.Load += new System.EventHandler(this.FileExplorerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_back;
        private Button btn_forward;
        private Label lb_fn;
        private Label lb_filename;
        private Label label_ft;
        private Label lb_filetype;
        private Label lbl_path;
        private TextBox textBoxPath;
        private ListView listView;
        private ImageList iconList;
        private TreeView treeView1;
    }
}