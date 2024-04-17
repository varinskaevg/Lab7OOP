namespace Lab7OOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            sdadwToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            mnuSaveAs = new ToolStripMenuItem();
            saveRTFToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            wdawdToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            saveAllToolStripMenuItem = new ToolStripMenuItem();
            wdawToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            alignToolStripMenuItem = new ToolStripMenuItem();
            LeftText = new ToolStripMenuItem();
            CenterText = new ToolStripMenuItem();
            RightText = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            mnuFind = new ToolStripMenuItem();
            awdawToolStripMenuItem = new ToolStripMenuItem();
            arrangeToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            tieHorizontalToolStripMenuItem = new ToolStripMenuItem();
            tieVerticalToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            aboutProgrammToolStripMenuItem = new ToolStripMenuItem();
            languageToolStripMenuItem = new ToolStripMenuItem();
            ukraineToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            toolStrip1 = new ToolStrip();
            tbNew = new ToolStripButton();
            tbOpen = new ToolStripButton();
            tbSave = new ToolStripButton();
            tbCut = new ToolStripButton();
            tbCopy = new ToolStripButton();
            tbPaste = new ToolStripButton();
            Images = new ToolStripButton();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { sdadwToolStripMenuItem, wdawdToolStripMenuItem, wdawToolStripMenuItem, awdawToolStripMenuItem, toolStripMenuItem1, languageToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(816, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sdadwToolStripMenuItem
            // 
            sdadwToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, mnuSaveAs, toolStripSeparator1, exitToolStripMenuItem });
            sdadwToolStripMenuItem.Name = "sdadwToolStripMenuItem";
            sdadwToolStripMenuItem.Size = new Size(46, 24);
            sdadwToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(233, 26);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(233, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(233, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // mnuSaveAs
            // 
            mnuSaveAs.DropDownItems.AddRange(new ToolStripItem[] { saveRTFToolStripMenuItem });
            mnuSaveAs.Name = "mnuSaveAs";
            mnuSaveAs.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            mnuSaveAs.Size = new Size(233, 26);
            mnuSaveAs.Text = "Save As";
            mnuSaveAs.Click += mnuSaveAs_Click;
            // 
            // saveRTFToolStripMenuItem
            // 
            saveRTFToolStripMenuItem.Name = "saveRTFToolStripMenuItem";
            saveRTFToolStripMenuItem.Size = new Size(150, 26);
            saveRTFToolStripMenuItem.Text = "Save RTF";
            saveRTFToolStripMenuItem.Click += saveRTFToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(230, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(233, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // wdawdToolStripMenuItem
            // 
            wdawdToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, deleteToolStripMenuItem, saveAllToolStripMenuItem });
            wdawdToolStripMenuItem.Name = "wdawdToolStripMenuItem";
            wdawdToolStripMenuItem.Size = new Size(49, 24);
            wdawdToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(197, 26);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(197, 26);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(197, 26);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.ShortcutKeys = Keys.Delete;
            deleteToolStripMenuItem.Size = new Size(197, 26);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // saveAllToolStripMenuItem
            // 
            saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            saveAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            saveAllToolStripMenuItem.Size = new Size(197, 26);
            saveAllToolStripMenuItem.Text = "Save All";
            saveAllToolStripMenuItem.Click += saveAllToolStripMenuItem_Click;
            // 
            // wdawToolStripMenuItem
            // 
            wdawToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem, colorToolStripMenuItem, alignToolStripMenuItem, toolStripSeparator2, mnuFind });
            wdawToolStripMenuItem.Name = "wdawToolStripMenuItem";
            wdawToolStripMenuItem.Size = new Size(70, 24);
            wdawToolStripMenuItem.Text = "Format";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(169, 26);
            fontToolStripMenuItem.Text = "Font";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(169, 26);
            colorToolStripMenuItem.Text = "Color";
            colorToolStripMenuItem.Click += colorToolStripMenuItem_Click;
            // 
            // alignToolStripMenuItem
            // 
            alignToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { LeftText, CenterText, RightText });
            alignToolStripMenuItem.Name = "alignToolStripMenuItem";
            alignToolStripMenuItem.Size = new Size(169, 26);
            alignToolStripMenuItem.Text = "Align";
            // 
            // LeftText
            // 
            LeftText.Name = "LeftText";
            LeftText.Size = new Size(135, 26);
            LeftText.Text = "Left";
            LeftText.Click += LeftText_Click;
            // 
            // CenterText
            // 
            CenterText.Name = "CenterText";
            CenterText.Size = new Size(135, 26);
            CenterText.Text = "Center";
            CenterText.Click += CenterText_Click;
            // 
            // RightText
            // 
            RightText.Name = "RightText";
            RightText.Size = new Size(135, 26);
            RightText.Text = "Right";
            RightText.Click += RightText_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(166, 6);
            // 
            // mnuFind
            // 
            mnuFind.Name = "mnuFind";
            mnuFind.ShortcutKeys = Keys.Control | Keys.F;
            mnuFind.Size = new Size(169, 26);
            mnuFind.Text = "Find";
            mnuFind.Click += mnuFind_Click;
            // 
            // awdawToolStripMenuItem
            // 
            awdawToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { arrangeToolStripMenuItem, cascadeToolStripMenuItem, tieHorizontalToolStripMenuItem, tieVerticalToolStripMenuItem });
            awdawToolStripMenuItem.Name = "awdawToolStripMenuItem";
            awdawToolStripMenuItem.Size = new Size(78, 24);
            awdawToolStripMenuItem.Text = "Window";
            // 
            // arrangeToolStripMenuItem
            // 
            arrangeToolStripMenuItem.Name = "arrangeToolStripMenuItem";
            arrangeToolStripMenuItem.Size = new Size(186, 26);
            arrangeToolStripMenuItem.Text = "Arrange Icons";
            arrangeToolStripMenuItem.Click += arrangeToolStripMenuItem_Click;
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(186, 26);
            cascadeToolStripMenuItem.Text = "Cascade";
            cascadeToolStripMenuItem.Click += cascadeToolStripMenuItem_Click;
            // 
            // tieHorizontalToolStripMenuItem
            // 
            tieHorizontalToolStripMenuItem.Name = "tieHorizontalToolStripMenuItem";
            tieHorizontalToolStripMenuItem.Size = new Size(186, 26);
            tieHorizontalToolStripMenuItem.Text = "Tie Horizontal";
            tieHorizontalToolStripMenuItem.Click += tieHorizontalToolStripMenuItem_Click;
            // 
            // tieVerticalToolStripMenuItem
            // 
            tieVerticalToolStripMenuItem.Name = "tieVerticalToolStripMenuItem";
            tieVerticalToolStripMenuItem.Size = new Size(186, 26);
            tieVerticalToolStripMenuItem.Text = "Tie Vertical";
            tieVerticalToolStripMenuItem.Click += tieVerticalToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { aboutProgrammToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(30, 24);
            toolStripMenuItem1.Text = "?";
            // 
            // aboutProgrammToolStripMenuItem
            // 
            aboutProgrammToolStripMenuItem.Name = "aboutProgrammToolStripMenuItem";
            aboutProgrammToolStripMenuItem.Size = new Size(207, 26);
            aboutProgrammToolStripMenuItem.Text = "About Programm";
            aboutProgrammToolStripMenuItem.Click += aboutProgrammToolStripMenuItem_Click;
            // 
            // languageToolStripMenuItem
            // 
            languageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ukraineToolStripMenuItem });
            languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            languageToolStripMenuItem.Size = new Size(88, 24);
            languageToolStripMenuItem.Text = "Language";
            // 
            // ukraineToolStripMenuItem
            // 
            ukraineToolStripMenuItem.Name = "ukraineToolStripMenuItem";
            ukraineToolStripMenuItem.Size = new Size(142, 26);
            ukraineToolStripMenuItem.Text = "Ukraine";
            ukraineToolStripMenuItem.Click += ukraineToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "Текстові файли";
            openFileDialog1.Filter = "Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tbNew, tbOpen, tbSave, tbCut, tbCopy, tbPaste, Images });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(816, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // tbNew
            // 
            tbNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbNew.Image = (Image)resources.GetObject("tbNew.Image");
            tbNew.ImageTransparentColor = Color.Magenta;
            tbNew.MergeIndex = 1;
            tbNew.Name = "tbNew";
            tbNew.Size = new Size(29, 24);
            tbNew.Text = "New";
            // 
            // tbOpen
            // 
            tbOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbOpen.Image = (Image)resources.GetObject("tbOpen.Image");
            tbOpen.ImageTransparentColor = Color.Magenta;
            tbOpen.MergeIndex = 2;
            tbOpen.Name = "tbOpen";
            tbOpen.Size = new Size(29, 24);
            tbOpen.Text = "Open";
            // 
            // tbSave
            // 
            tbSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbSave.Image = (Image)resources.GetObject("tbSave.Image");
            tbSave.ImageTransparentColor = Color.Magenta;
            tbSave.MergeIndex = 3;
            tbSave.Name = "tbSave";
            tbSave.Size = new Size(29, 24);
            tbSave.Text = "Save";
            // 
            // tbCut
            // 
            tbCut.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbCut.Image = (Image)resources.GetObject("tbCut.Image");
            tbCut.ImageTransparentColor = Color.Magenta;
            tbCut.MergeIndex = 4;
            tbCut.Name = "tbCut";
            tbCut.Size = new Size(29, 24);
            tbCut.Text = "Cut";
            // 
            // tbCopy
            // 
            tbCopy.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbCopy.Image = (Image)resources.GetObject("tbCopy.Image");
            tbCopy.ImageTransparentColor = Color.Magenta;
            tbCopy.MergeIndex = 5;
            tbCopy.Name = "tbCopy";
            tbCopy.Size = new Size(29, 24);
            tbCopy.Text = "Copy";
            // 
            // tbPaste
            // 
            tbPaste.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tbPaste.Image = (Image)resources.GetObject("tbPaste.Image");
            tbPaste.ImageTransparentColor = Color.Magenta;
            tbPaste.MergeIndex = 6;
            tbPaste.Name = "tbPaste";
            tbPaste.Size = new Size(29, 24);
            tbPaste.Text = "Paste";
            // 
            // Images
            // 
            Images.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Images.Image = (Image)resources.GetObject("Images.Image");
            Images.ImageTransparentColor = Color.Magenta;
            Images.Name = "Images";
            Images.Size = new Size(29, 24);
            Images.Text = "toolStripButton1";
            Images.Click += Images_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 456);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "NotepadCSharp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sdadwToolStripMenuItem;
        private ToolStripMenuItem wdawdToolStripMenuItem;
        private ToolStripMenuItem wdawToolStripMenuItem;
        private ToolStripMenuItem awdawToolStripMenuItem;
        private ToolStripMenuItem arrangeToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem saveAllToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem tieHorizontalToolStripMenuItem;
        private ToolStripMenuItem tieVerticalToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem aboutProgrammToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem mnuSaveAs;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mnuFind;
        private ToolStrip toolStrip1;
        private ToolStripButton tbNew;
        private ToolStripButton tbOpen;
        private ToolStripButton tbSave;
        private ToolStripButton tbCut;
        private ToolStripButton tbCopy;
        private ToolStripButton tbPaste;
        private ToolStripMenuItem alignToolStripMenuItem;
        private ToolStripMenuItem LeftText;
        private ToolStripMenuItem CenterText;
        private ToolStripMenuItem RightText;
        private ToolStripButton Images;
        private ToolStripMenuItem saveRTFToolStripMenuItem;
        private ToolStripMenuItem languageToolStripMenuItem;
        private ToolStripMenuItem ukraineToolStripMenuItem;
    }
}
