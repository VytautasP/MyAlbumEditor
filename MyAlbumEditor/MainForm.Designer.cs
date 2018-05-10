namespace MyAlbumEditor
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbAlbums = new System.Windows.Forms.ComboBox();
            this.btnAbmProp = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnPhotoProp = new System.Windows.Forms.Button();
            this.lstPhotos = new System.Windows.Forms.ListBox();
            this.ctxPhotoList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuThumbs = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileName = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCaption = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPhotographer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuImages = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabPhotos = new System.Windows.Forms.TabPage();
            this.tcPhotos = new System.Windows.Forms.TabControl();
            this.tabDates = new System.Windows.Forms.TabPage();
            this.monthCalDates = new System.Windows.Forms.MonthCalendar();
            this.groupBox1.SuspendLayout();
            this.ctxPhotoList.SuspendLayout();
            this.tabPhotos.SuspendLayout();
            this.tcPhotos.SuspendLayout();
            this.tabDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbAlbums);
            this.groupBox1.Controls.Add(this.btnAbmProp);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Albums";
            // 
            // cmbAlbums
            // 
            this.cmbAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAlbums.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlbums.FormattingEnabled = true;
            this.cmbAlbums.Location = new System.Drawing.Point(7, 20);
            this.cmbAlbums.Name = "cmbAlbums";
            this.cmbAlbums.Size = new System.Drawing.Size(319, 21);
            this.cmbAlbums.TabIndex = 5;
            this.cmbAlbums.SelectedIndexChanged += new System.EventHandler(this.cmbAlbums_SelectedIndexChanged);
            // 
            // btnAbmProp
            // 
            this.btnAbmProp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbmProp.Enabled = false;
            this.btnAbmProp.Location = new System.Drawing.Point(344, 19);
            this.btnAbmProp.Name = "btnAbmProp";
            this.btnAbmProp.Size = new System.Drawing.Size(75, 23);
            this.btnAbmProp.TabIndex = 4;
            this.btnAbmProp.Text = "Properties";
            this.btnAbmProp.UseVisualStyleBackColor = true;
            this.btnAbmProp.Click += new System.EventHandler(this.btnAbmProp_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(319, 67);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveDown.Enabled = false;
            this.btnMoveDown.Location = new System.Drawing.Point(319, 38);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(75, 23);
            this.btnMoveDown.TabIndex = 7;
            this.btnMoveDown.Text = "Move Down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveUp.Enabled = false;
            this.btnMoveUp.Location = new System.Drawing.Point(319, 9);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(75, 23);
            this.btnMoveUp.TabIndex = 6;
            this.btnMoveUp.Text = "Move Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnPhotoProp
            // 
            this.btnPhotoProp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPhotoProp.Enabled = false;
            this.btnPhotoProp.Location = new System.Drawing.Point(319, 96);
            this.btnPhotoProp.Name = "btnPhotoProp";
            this.btnPhotoProp.Size = new System.Drawing.Size(75, 23);
            this.btnPhotoProp.TabIndex = 5;
            this.btnPhotoProp.Text = "Properties";
            this.btnPhotoProp.UseVisualStyleBackColor = true;
            this.btnPhotoProp.Click += new System.EventHandler(this.btnPhotoProp_Click);
            // 
            // lstPhotos
            // 
            this.lstPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPhotos.ContextMenuStrip = this.ctxPhotoList;
            this.lstPhotos.FormattingEnabled = true;
            this.lstPhotos.Location = new System.Drawing.Point(6, 9);
            this.lstPhotos.Name = "lstPhotos";
            this.lstPhotos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstPhotos.Size = new System.Drawing.Size(295, 186);
            this.lstPhotos.TabIndex = 0;
            this.lstPhotos.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstPhotos_DrawItem);
            this.lstPhotos.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lstPhotos_MeasureItem);
            this.lstPhotos.SelectedIndexChanged += new System.EventHandler(this.lstPhotos_SelectedIndexChanged);
            this.lstPhotos.DoubleClick += new System.EventHandler(this.lstPhotos_DoubleClick);
            // 
            // ctxPhotoList
            // 
            this.ctxPhotoList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuThumbs,
            this.displayAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.menuImages});
            this.ctxPhotoList.Name = "ctxPhotoList";
            this.ctxPhotoList.Size = new System.Drawing.Size(138, 76);
            // 
            // menuThumbs
            // 
            this.menuThumbs.Name = "menuThumbs";
            this.menuThumbs.Size = new System.Drawing.Size(137, 22);
            this.menuThumbs.Text = "Thumbnails";
            this.menuThumbs.Click += new System.EventHandler(this.menuThumbs_Click);
            // 
            // displayAsToolStripMenuItem
            // 
            this.displayAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileName,
            this.menuCaption,
            this.menuPhotographer});
            this.displayAsToolStripMenuItem.Name = "displayAsToolStripMenuItem";
            this.displayAsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.displayAsToolStripMenuItem.Text = "Display as";
            // 
            // menuFileName
            // 
            this.menuFileName.Name = "menuFileName";
            this.menuFileName.Size = new System.Drawing.Size(147, 22);
            this.menuFileName.Text = "File name";
            this.menuFileName.Click += new System.EventHandler(this.menuFileName_Click);
            // 
            // menuCaption
            // 
            this.menuCaption.Name = "menuCaption";
            this.menuCaption.Size = new System.Drawing.Size(147, 22);
            this.menuCaption.Text = "Caption";
            this.menuCaption.Click += new System.EventHandler(this.menuCaption_Click);
            // 
            // menuPhotographer
            // 
            this.menuPhotographer.Name = "menuPhotographer";
            this.menuPhotographer.Size = new System.Drawing.Size(147, 22);
            this.menuPhotographer.Text = "Photographer";
            this.menuPhotographer.Click += new System.EventHandler(this.menuPhotographer_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(134, 6);
            // 
            // menuImages
            // 
            this.menuImages.Name = "menuImages";
            this.menuImages.Size = new System.Drawing.Size(137, 22);
            this.menuImages.Text = "Images...";
            this.menuImages.Click += new System.EventHandler(this.menuImages_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.Location = new System.Drawing.Point(185, 317);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabPhotos
            // 
            this.tabPhotos.BackColor = System.Drawing.SystemColors.Control;
            this.tabPhotos.Controls.Add(this.btnRemove);
            this.tabPhotos.Controls.Add(this.lstPhotos);
            this.tabPhotos.Controls.Add(this.btnMoveDown);
            this.tabPhotos.Controls.Add(this.btnPhotoProp);
            this.tabPhotos.Controls.Add(this.btnMoveUp);
            this.tabPhotos.Location = new System.Drawing.Point(23, 4);
            this.tabPhotos.Name = "tabPhotos";
            this.tabPhotos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhotos.Size = new System.Drawing.Size(396, 203);
            this.tabPhotos.TabIndex = 0;
            this.tabPhotos.Text = "Photos";
            // 
            // tcPhotos
            // 
            this.tcPhotos.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcPhotos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcPhotos.Controls.Add(this.tabPhotos);
            this.tcPhotos.Controls.Add(this.tabDates);
            this.tcPhotos.Location = new System.Drawing.Point(13, 89);
            this.tcPhotos.Multiline = true;
            this.tcPhotos.Name = "tcPhotos";
            this.tcPhotos.SelectedIndex = 0;
            this.tcPhotos.Size = new System.Drawing.Size(423, 211);
            this.tcPhotos.TabIndex = 3;
            this.tcPhotos.SelectedIndexChanged += new System.EventHandler(this.tcPhotos_SelectedIndexChanged);
            // 
            // tabDates
            // 
            this.tabDates.Controls.Add(this.monthCalDates);
            this.tabDates.Location = new System.Drawing.Point(23, 4);
            this.tabDates.Name = "tabDates";
            this.tabDates.Padding = new System.Windows.Forms.Padding(3);
            this.tabDates.Size = new System.Drawing.Size(396, 203);
            this.tabDates.TabIndex = 1;
            this.tabDates.Text = "Dates";
            this.tabDates.UseVisualStyleBackColor = true;
            // 
            // monthCalDates
            // 
            this.monthCalDates.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthCalDates.Location = new System.Drawing.Point(3, 3);
            this.monthCalDates.MaxSelectionCount = 1;
            this.monthCalDates.Name = "monthCalDates";
            this.monthCalDates.ShowToday = false;
            this.monthCalDates.TabIndex = 0;
            this.monthCalDates.MouseDown += new System.Windows.Forms.MouseEventHandler(this.monthCalDates_MouseDown);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 352);
            this.Controls.Add(this.tcPhotos);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "MyAlbumEditor";
            this.groupBox1.ResumeLayout(false);
            this.ctxPhotoList.ResumeLayout(false);
            this.tabPhotos.ResumeLayout(false);
            this.tcPhotos.ResumeLayout(false);
            this.tabDates.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lstPhotos;
        private System.Windows.Forms.Button btnAbmProp;
        private System.Windows.Forms.Button btnPhotoProp;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.ComboBox cmbAlbums;
        private System.Windows.Forms.ContextMenuStrip ctxPhotoList;
        private System.Windows.Forms.ToolStripMenuItem menuThumbs;
        private System.Windows.Forms.ToolStripMenuItem displayAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuFileName;
        private System.Windows.Forms.ToolStripMenuItem menuCaption;
        private System.Windows.Forms.ToolStripMenuItem menuPhotographer;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuImages;
        private System.Windows.Forms.TabPage tabPhotos;
        private System.Windows.Forms.TabControl tcPhotos;
        private System.Windows.Forms.TabPage tabDates;
        private System.Windows.Forms.MonthCalendar monthCalDates;
    }
}

