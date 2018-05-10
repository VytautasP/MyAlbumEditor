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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.btnClose = new System.Windows.Forms.Button();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuImages = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ctxPhotoList.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(352, 60);
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
            this.cmbAlbums.Size = new System.Drawing.Size(246, 21);
            this.cmbAlbums.TabIndex = 5;
            this.cmbAlbums.SelectedIndexChanged += new System.EventHandler(this.cmbAlbums_SelectedIndexChanged);
            // 
            // btnAbmProp
            // 
            this.btnAbmProp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbmProp.Enabled = false;
            this.btnAbmProp.Location = new System.Drawing.Point(271, 19);
            this.btnAbmProp.Name = "btnAbmProp";
            this.btnAbmProp.Size = new System.Drawing.Size(75, 23);
            this.btnAbmProp.TabIndex = 4;
            this.btnAbmProp.Text = "Properties";
            this.btnAbmProp.UseVisualStyleBackColor = true;
            this.btnAbmProp.Click += new System.EventHandler(this.btnAbmProp_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnMoveDown);
            this.groupBox2.Controls.Add(this.btnMoveUp);
            this.groupBox2.Controls.Add(this.btnPhotoProp);
            this.groupBox2.Controls.Add(this.lstPhotos);
            this.groupBox2.Location = new System.Drawing.Point(13, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 145);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Photographs";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(271, 77);
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
            this.btnMoveDown.Location = new System.Drawing.Point(271, 48);
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
            this.btnMoveUp.Location = new System.Drawing.Point(271, 19);
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
            this.btnPhotoProp.Location = new System.Drawing.Point(271, 108);
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
            this.lstPhotos.Location = new System.Drawing.Point(7, 23);
            this.lstPhotos.Name = "lstPhotos";
            this.lstPhotos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstPhotos.Size = new System.Drawing.Size(246, 108);
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
            this.ctxPhotoList.Size = new System.Drawing.Size(181, 98);
            // 
            // menuThumbs
            // 
            this.menuThumbs.Name = "menuThumbs";
            this.menuThumbs.Size = new System.Drawing.Size(180, 22);
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
            this.displayAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.displayAsToolStripMenuItem.Text = "Display as";
            // 
            // menuFileName
            // 
            this.menuFileName.Name = "menuFileName";
            this.menuFileName.Size = new System.Drawing.Size(180, 22);
            this.menuFileName.Text = "File name";
            this.menuFileName.Click += new System.EventHandler(this.menuFileName_Click);
            // 
            // menuCaption
            // 
            this.menuCaption.Name = "menuCaption";
            this.menuCaption.Size = new System.Drawing.Size(180, 22);
            this.menuCaption.Text = "Caption";
            this.menuCaption.Click += new System.EventHandler(this.menuCaption_Click);
            // 
            // menuPhotographer
            // 
            this.menuPhotographer.Name = "menuPhotographer";
            this.menuPhotographer.Size = new System.Drawing.Size(180, 22);
            this.menuPhotographer.Text = "Photographer";
            this.menuPhotographer.Click += new System.EventHandler(this.menuPhotographer_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.Location = new System.Drawing.Point(148, 281);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuImages
            // 
            this.menuImages.Name = "menuImages";
            this.menuImages.Size = new System.Drawing.Size(180, 22);
            this.menuImages.Text = "Images...";
            this.menuImages.Click += new System.EventHandler(this.menuImages_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 316);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "MyAlbumEditor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ctxPhotoList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
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
    }
}

