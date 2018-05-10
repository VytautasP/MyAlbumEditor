using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Extensions.PhotoAlbum;

namespace MyAlbumEditor
{
    public partial class MainForm : Form
    {

        #region Fields

        private PhotoAlbum _album;
        private bool _albumChanged = false;
        private static Rectangle _drawRect = new Rectangle(0,0,45,45);
        private static SolidBrush _textBrush = new SolidBrush(SystemColors.WindowText);

        #endregion

        #region Constructors

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties



        #endregion

        #region Methods

        private void CloseAlbum()
        {
            if (_albumChanged)
            {
                _albumChanged = false;

                DialogResult result = MessageBox.Show("Do you want to save changes to " + _album.FileName + "?",
                    "Save changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _album.Save();
                }

            }

            _album.Clear();
        }

        protected void UpdateList()
        {
            lstPhotos.BeginUpdate();
            lstPhotos.Items.Clear();
            foreach (Photograph photograph in _album)
            {
                lstPhotos.Items.Add(photograph);
            }

            lstPhotos.EndUpdate();
        }

        protected void UpdateList(string displayMember)
        {
            lstPhotos.DisplayMember = displayMember;
            UpdateList();
        }

        private void OpenAlbum(string fileName)
        {
            CloseAlbum();
            _album.Open(fileName);
            Text = _album.FileName;

            UpdateList();
        }

        #endregion

        #region Event handlers

        #region Context menu PhotoList

        private void menuThumbs_Click(object sender, EventArgs e)
        {
            menuThumbs.Checked = !menuThumbs.Checked;

            if (menuThumbs.Checked)
            {
                lstPhotos.DrawMode = DrawMode.OwnerDrawVariable;
            }
            else
            {
                lstPhotos.DrawMode = DrawMode.Normal;
                lstPhotos.ItemHeight = lstPhotos.Font.Height + 2;
            }
        }

        private void menuFileName_Click(object sender, EventArgs e)
        {
            lstPhotos.DisplayMember = "FileName";
            lstPhotos.Invalidate();
        }

        private void menuCaption_Click(object sender, EventArgs e)
        {
            lstPhotos.DisplayMember = "Caption";
            lstPhotos.Invalidate();
        }

        private void menuPhotographer_Click(object sender, EventArgs e)
        {
            lstPhotos.DisplayMember = "Photographer";
            lstPhotos.Invalidate();
        }

        #endregion

        #region lstPhotos

        private void lstPhotos_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Photograph p = _album[e.Index];

            Rectangle scaledRect = p.ScaleToFit(_drawRect);
            Rectangle imageRect = e.Bounds;

            imageRect.Y += 1;
            imageRect.Height = scaledRect.Height;
            imageRect.X += 2;
            imageRect.Width = scaledRect.Width;

            g.DrawImage(p.ThumbNail, imageRect);
            g.DrawRectangle(Pens.Black, imageRect);

            Rectangle textRect = new Rectangle(
                imageRect.Right + 2, 
                imageRect.Y + ((imageRect.Height - e.Font.Height) / 2),
                e.Bounds.Width - imageRect.Width - 4,
                e.Font.Height);

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                _textBrush.Color = SystemColors.Highlight;
                g.FillRectangle(_textBrush, textRect);
                _textBrush.Color = SystemColors.HighlightText;
            }
            else
            {
                _textBrush.Color = SystemColors.Window;
                g.FillRectangle(_textBrush, textRect);
                _textBrush.Color = SystemColors.WindowText;
            }

            string displayMember = String.IsNullOrWhiteSpace(lstPhotos.DisplayMember)
                ? "FileName"
                : lstPhotos.DisplayMember;

            PropertyInfo pi = typeof(Photograph).GetProperty(displayMember);
            object propValue = pi.GetValue(p, null);

            g.DrawString(propValue.ToString(), e.Font, _textBrush, textRect);
        }

        private void lstPhotos_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            Photograph p = _album[e.Index];

            Rectangle scaledRect = p.ScaleToFit(_drawRect);

            e.ItemHeight = Math.Max(scaledRect.Height, lstPhotos.Font.Height) + 2;
            e.ItemWidth = scaledRect.Width + (int)e.Graphics.MeasureString(p.Caption, lstPhotos.Font).Width + 2;
        }

        private void lstPhotos_DoubleClick(object sender, EventArgs e)
        {
            btnPhotoProp.PerformClick();
        }

        private void lstPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var numSelected = lstPhotos.SelectedIndices.Count;
            var someSelected = numSelected > 0;

            btnMoveUp.Enabled = someSelected && !lstPhotos.GetSelected(0);

            btnMoveDown.Enabled = someSelected && !lstPhotos.GetSelected(lstPhotos.Items.Count - 1);

            btnRemove.Enabled = someSelected;

            btnPhotoProp.Enabled = numSelected == 1;
        }

        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAbmProp_Click(object sender, EventArgs e)
        {
            using (AlbumEditDlg dlg = new AlbumEditDlg(_album))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _albumChanged = true;
                    UpdateList();
                }
            }
        }

        private void btnPhotoProp_Click(object sender, EventArgs e)
        {
            if (_album.Count == 0)
                return;

            if (lstPhotos.SelectedIndex >= 0)
                _album.CurrentPosition = lstPhotos.SelectedIndex;

            using (PhotoEditDlg dlg = new PhotoEditDlg(_album))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _albumChanged = true;
                    UpdateList();
                }
            }
        }

        #region lstPhotos items rearengement buttons

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            var indices = lstPhotos.SelectedIndices;
            int[] newIndices = new int[indices.Count];

            for (int i = 0; i < indices.Count; i++)
            {
                var index = indices[i];
                _album.MoveBefore(index);
                newIndices[i] = index - 1;
            }

            _albumChanged = true;

            UpdateList();

            lstPhotos.ClearSelected();
            foreach (var newIndex in newIndices)
            {
                lstPhotos.SetSelected(newIndex, true);
            }
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            var indices = lstPhotos.SelectedIndices;
            int[] newIndices = new int[indices.Count];

            for (int i = indices.Count - 1; i >= 0; i--)
            {
                var index = indices[i];
                _album.MoveAfter(index);
                newIndices[i] = index + 1;
            }

            _albumChanged = true;

            UpdateList();

            lstPhotos.ClearSelected();
            foreach (var newIndex in newIndices)
            {
                lstPhotos.SetSelected(newIndex, true);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var n = lstPhotos.SelectedIndices.Count;
            var msg = n == 1
                ? "Do you realy want to remove selected photo?"
                : "Do you realy want to remove " + n + " selected photos?";

            DialogResult result =
                MessageBox.Show(msg, "Remove photo?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var indices = lstPhotos.SelectedIndices;

                for (int i = indices.Count - 1; i >= 0; i--)
                {
                    _album.RemoveAt(indices[i]);
                }

                _albumChanged = true;

                UpdateList();
            }
        }

        #endregion

        private void cmbAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            var albumPath = cmbAlbums.SelectedItem.ToString();

            if (albumPath == _album.FileName)
                return;

            try
            {
                CloseAlbum();
                OpenAlbum(albumPath);

                btnAbmProp.Enabled = true;
                lstPhotos.BackColor = SystemColors.Window;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open selected album.\nError: " + ex.Message, "Unable to open album",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnAbmProp.Enabled = false;
                lstPhotos.Items.Clear();
                lstPhotos.BackColor = SystemColors.Control;

            }
        }

        private void menuImages_Click(object sender, EventArgs e)
        {
            Form imagesDlg = new Form();
            TabControl tcImages = new TabControl();

            imagesDlg.SuspendLayout();
            tcImages.SuspendLayout();

            foreach (Photograph photograph in _album)
            {
                var shortFileName = Path.GetFileName(photograph.FileName);

                TabPage newPage = new TabPage(shortFileName);
                newPage.SuspendLayout();

                newPage.ToolTipText = photograph.FileName;
                newPage.Tag = photograph;
                newPage.Paint += (o, args) =>
                {
                    args.Graphics.DrawImage(photograph.Image, photograph.ScaleToFit(newPage.DisplayRectangle));
                };

                tcImages.Controls.Add(newPage);
                newPage.ResumeLayout();
            }

            tcImages.Dock = DockStyle.Fill;
            tcImages.HotTrack = true;
            tcImages.ShowToolTips = true;

            imagesDlg.Controls.Add(tcImages);
            imagesDlg.ShowInTaskbar = false;
            imagesDlg.Size = new Size(400,300);
            imagesDlg.Text = "Images in " + Path.GetFileName(_album.FileName);

            tcImages.ResumeLayout();
            imagesDlg.ResumeLayout();

            imagesDlg.ShowDialog();
            imagesDlg.Dispose();
        }

        #endregion

        #region Overrides

        protected override void OnLoad(EventArgs e)
        {
            _album = new PhotoAlbum();

            cmbAlbums.DataSource = Directory.GetFiles(PhotoAlbum.DefaultDir, "*.abm");

            base.OnLoad(e);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            CloseAlbum();
        }

        #endregion
        
    }
}
