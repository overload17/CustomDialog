namespace CustomDialog
{
    partial class CustomDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.driverslist = new System.Windows.Forms.ComboBox();
            this.dirstree = new System.Windows.Forms.TreeView();
            this.fileslist = new System.Windows.Forms.ListView();
            this.filepath = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drivers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Files";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "File Path";
            // 
            // driverslist
            // 
            this.driverslist.FormattingEnabled = true;
            this.driverslist.Location = new System.Drawing.Point(328, 15);
            this.driverslist.Name = "driverslist";
            this.driverslist.Size = new System.Drawing.Size(121, 21);
            this.driverslist.TabIndex = 4;
            this.driverslist.SelectedValueChanged += new System.EventHandler(this.driverslist_SelectedValueChanged);
            // 
            // dirstree
            // 
            this.dirstree.Location = new System.Drawing.Point(37, 60);
            this.dirstree.Name = "dirstree";
            this.dirstree.Size = new System.Drawing.Size(256, 310);
            this.dirstree.TabIndex = 5;
            this.dirstree.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.dirstree_BeforeExpand);
            this.dirstree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.dirstree_AfterSelect);
            // 
            // fileslist
            // 
            this.fileslist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.fileslist.Location = new System.Drawing.Point(429, 60);
            this.fileslist.MultiSelect = false;
            this.fileslist.Name = "fileslist";
            this.fileslist.Size = new System.Drawing.Size(271, 310);
            this.fileslist.TabIndex = 6;
            this.fileslist.UseCompatibleStateImageBehavior = false;
            this.fileslist.View = System.Windows.Forms.View.Details;
            this.fileslist.Click += new System.EventHandler(this.fileslist_Click);
            // 
            // filepath
            // 
            this.filepath.Location = new System.Drawing.Point(24, 419);
            this.filepath.Name = "filepath";
            this.filepath.Size = new System.Drawing.Size(676, 20);
            this.filepath.TabIndex = 7;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(218, 458);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.Close);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(429, 458);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.Close);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Размер";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Изменен";
            this.columnHeader3.Width = 80;
            // 
            // CustomDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 514);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.filepath);
            this.Controls.Add(this.fileslist);
            this.Controls.Add(this.dirstree);
            this.Controls.Add(this.driverslist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomDialog";
            this.Text = "Custom Dialog";
            this.Load += new System.EventHandler(this.CustomDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox driverslist;
        private System.Windows.Forms.TreeView dirstree;
        private System.Windows.Forms.ListView fileslist;
        private System.Windows.Forms.TextBox filepath;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

