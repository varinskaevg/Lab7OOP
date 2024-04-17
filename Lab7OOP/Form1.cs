using System.Drawing.Imaging;
using System.Globalization;
using System.Text;
using System.Windows.Forms;



namespace Lab7OOP
{
    public partial class Form1 : Form
    {
        private int openDocuments = 0;
        private RichTextBox richTextBox1;

        public Form1()
        {
            InitializeComponent();
            saveToolStripMenuItem.Enabled = false;
            this.richTextBox1 = new RichTextBox();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = new blank();
            frm.DocName = "Untitled " + ++openDocuments;
            frm.Text = frm.DocName;
            frm.MdiParent = this;
            frm.Show();
        }


        private void arrangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tieHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tieVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.Delete();
        }

        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.SelectAll();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem.Enabled = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                blank frm = new blank();
                frm.Open(openFileDialog1.FileName);
                frm.MdiParent = this;
                frm.DocName = openFileDialog1.FileName;
                frm.Text = frm.DocName;
                frm.Show();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                blank frm = (blank)this.ActiveMdiChild;
                frm.Save(saveFileDialog1.FileName);
                frm.MdiParent = this;
                frm.DocName = saveFileDialog1.FileName;
                frm.Text = frm.DocName;
                frm.IsSaved = true;
                frm.Close();
            }
        }

        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                blank frm = (blank)this.ActiveMdiChild;
                frm.Save(saveFileDialog1.FileName);
                frm.MdiParent = this;
                frm.DocName = saveFileDialog1.FileName;
                frm.Text = frm.DocName;
                frm.IsSaved = true;
                frm.Close();
            }
            saveToolStripMenuItem.Enabled = true;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            fontDialog1.ShowColor = true;
            fontDialog1.Font = frm.richTextBox1.SelectionFont;
            fontDialog1.Color = frm.richTextBox1.SelectionColor;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.richTextBox1.SelectionFont = fontDialog1.Font;
                frm.richTextBox1.SelectionColor = fontDialog1.Color;
            }
            frm.Show();

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.MdiParent = this;
            colorDialog1.Color = frm.richTextBox1.SelectionColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                frm.richTextBox1.SelectionColor = colorDialog1.Color;
            }
            frm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuFind_Click(object sender, EventArgs e)
        {
            FindForm frm = new FindForm();
            if (frm.ShowDialog(this) == DialogResult.Cancel) return;
            blank form = (blank)this.ActiveMdiChild;
            form.MdiParent = this;
            int start = form.richTextBox1.SelectionStart;
            form.richTextBox1.Find(frm.FindText, start, frm.FindCondition);
        }

        private void aboutProgrammToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem clickedItem = e.ClickedItem;

            if (clickedItem == tbNew)
            {
                newToolStripMenuItem_Click(this, EventArgs.Empty);
            }
            else if (clickedItem == tbOpen)
            {
                openToolStripMenuItem_Click(this, EventArgs.Empty);
            }
            else if (clickedItem == tbSave)
            {
                saveToolStripMenuItem_Click(this, EventArgs.Empty);
            }
            else if (clickedItem == tbCut)
            {
                cutToolStripMenuItem_Click(this, EventArgs.Empty);
            }
            else if (clickedItem == tbCopy)
            {
                copyToolStripMenuItem_Click(this, EventArgs.Empty);
            }
            else if (clickedItem == tbPaste)
            {
                pasteToolStripMenuItem_Click(this, EventArgs.Empty);
            }

        }

        private void LeftText_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.AlignTextLeft();
        }

        private void CenterText_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.AlignTextCenter();
        }

        private void RightText_Click(object sender, EventArgs e)
        {
            blank frm = (blank)this.ActiveMdiChild;
            frm.AlignTextRight();
        }

        private void Images_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.png;*.gif)|*.bmp;*.jpg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                try
                {
                    // Зчитуємо зображення з файлу
                    Image image = Image.FromFile(imagePath);

                    // Створюємо новий PictureBox з розміром 200 на 200
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = image;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Size = new Size(200, 200); // Встановлюємо розмір

                    // Додаємо PictureBox до форми
                    this.Controls.Add(pictureBox);

                    // Встановлюємо режим перетягування
                    pictureBox.MouseDown += PictureBox_MouseDown;
                    pictureBox.MouseMove += PictureBox_MouseMove;
                    pictureBox.MouseUp += PictureBox_MouseUp;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка завантаження зображення: " + ex.Message);
                }
            }
        }
        private bool isDragging = false;
        private Point lastLocation;

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastLocation = e.Location;
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                PictureBox pictureBox = sender as PictureBox;
                pictureBox.Left += e.X - lastLocation.X;
                pictureBox.Top += e.Y - lastLocation.Y;
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }


        private void saveRTFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                blank frm = (blank)this.ActiveMdiChild;
                if (frm != null)
                {
                    frm.richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);

                    frm.DocName = saveFileDialog1.FileName;
                    frm.Text = frm.DocName;
                    frm.IsSaved = true;
                    frm.Close();
                }
            }
        }

        private void ukraineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("uk-UA");
            UpdateTexts();
        }

        private void UpdateTexts()
        {
            sdadwToolStripMenuItem.Text = ResourceUa.Menu;
            newToolStripMenuItem.Text = ResourceUa.New;
            openToolStripMenuItem.Text = ResourceUa.Open;
            saveToolStripMenuItem.Text = ResourceUa.Save;
            mnuSaveAs.Text = ResourceUa.Save_As;
            saveRTFToolStripMenuItem.Text = ResourceUa.Save_FRT;
            exitToolStripMenuItem.Text = ResourceUa.Exit;
            wdawdToolStripMenuItem.Text = ResourceUa.Edit;
            cutToolStripMenuItem.Text = ResourceUa.Cut;
            copyToolStripMenuItem.Text = ResourceUa.Copy;
            pasteToolStripMenuItem.Text = ResourceUa.Paste;
            deleteToolStripMenuItem.Text = ResourceUa.Delete;
            saveAllToolStripMenuItem.Text = ResourceUa.Save_All;
            wdawToolStripMenuItem.Text = ResourceUa.Format;
            fontToolStripMenuItem.Text = ResourceUa.Font;
            colorToolStripMenuItem.Text = ResourceUa.Color;
            alignToolStripMenuItem.Text = ResourceUa.Align;
            LeftText.Text = ResourceUa.Left;
            RightText.Text = ResourceUa.Right;
            CenterText.Text = ResourceUa.Center;
            mnuFind.Text = ResourceUa.Find;
            awdawToolStripMenuItem.Text = ResourceUa.Window;
            arrangeToolStripMenuItem.Text = ResourceUa.Arrange;
            cascadeToolStripMenuItem.Text = ResourceUa.Cascade;
            tieHorizontalToolStripMenuItem.Text = ResourceUa.Horizontal;
            tieVerticalToolStripMenuItem.Text = ResourceUa.Vertikal;
            aboutProgrammToolStripMenuItem.Text = ResourceUa.About;
            languageToolStripMenuItem.Text = ResourceUa.Lenguage;
        }
    }
}
