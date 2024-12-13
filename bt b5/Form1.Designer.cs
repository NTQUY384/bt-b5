namespace bt_b5
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taoVanBanMoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moTapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luuNoiDungVanBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dinhDangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.cbxFont = new System.Windows.Forms.ToolStripComboBox();
            this.cbxSize = new System.Windows.Forms.ToolStripComboBox();
            this.indam = new System.Windows.Forms.ToolStripButton();
            this.innghieng = new System.Windows.Forms.ToolStripButton();
            this.gachchan = new System.Windows.Forms.ToolStripButton();
            this.richText = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThongToolStripMenuItem,
            this.dinhDangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // heThongToolStripMenuItem
            // 
            this.heThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taoVanBanMoiToolStripMenuItem,
            this.moTapToolStripMenuItem,
            this.luuNoiDungVanBanToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            this.heThongToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.heThongToolStripMenuItem.Text = "he thong";
            // 
            // taoVanBanMoiToolStripMenuItem
            // 
            this.taoVanBanMoiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("taoVanBanMoiToolStripMenuItem.Image")));
            this.taoVanBanMoiToolStripMenuItem.Name = "taoVanBanMoiToolStripMenuItem";
            this.taoVanBanMoiToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.taoVanBanMoiToolStripMenuItem.Text = "tao van ban moi";
            this.taoVanBanMoiToolStripMenuItem.Click += new System.EventHandler(this.taoVanBanMoiToolStripMenuItem_Click);
            // 
            // moTapToolStripMenuItem
            // 
            this.moTapToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("moTapToolStripMenuItem.Image")));
            this.moTapToolStripMenuItem.Name = "moTapToolStripMenuItem";
            this.moTapToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.moTapToolStripMenuItem.Text = "mo tap tin";
            this.moTapToolStripMenuItem.Click += new System.EventHandler(this.moTapToolStripMenuItem_Click);
            // 
            // luuNoiDungVanBanToolStripMenuItem
            // 
            this.luuNoiDungVanBanToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("luuNoiDungVanBanToolStripMenuItem.Image")));
            this.luuNoiDungVanBanToolStripMenuItem.Name = "luuNoiDungVanBanToolStripMenuItem";
            this.luuNoiDungVanBanToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.luuNoiDungVanBanToolStripMenuItem.Text = "luu noi dung van ban";
            this.luuNoiDungVanBanToolStripMenuItem.Click += new System.EventHandler(this.luuNoiDungVanBanToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.thoatToolStripMenuItem.Text = "thoat";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // dinhDangToolStripMenuItem
            // 
            this.dinhDangToolStripMenuItem.Name = "dinhDangToolStripMenuItem";
            this.dinhDangToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.dinhDangToolStripMenuItem.Text = "dinh dang";
            this.dinhDangToolStripMenuItem.Click += new System.EventHandler(this.dinhDangToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.cbxFont,
            this.cbxSize,
            this.indam,
            this.innghieng,
            this.gachchan});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // cbxFont
            // 
            this.cbxFont.Name = "cbxFont";
            this.cbxFont.Size = new System.Drawing.Size(121, 25);
            this.cbxFont.Click += new System.EventHandler(this.cbxFont_Click);
            // 
            // cbxSize
            // 
            this.cbxSize.Name = "cbxSize";
            this.cbxSize.Size = new System.Drawing.Size(121, 25);
            this.cbxSize.Click += new System.EventHandler(this.cbxSize_Click);
            // 
            // indam
            // 
            this.indam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.indam.Image = ((System.Drawing.Image)(resources.GetObject("indam.Image")));
            this.indam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.indam.Name = "indam";
            this.indam.Size = new System.Drawing.Size(23, 22);
            this.indam.Text = "toolStripButton3";
            this.indam.Click += new System.EventHandler(this.indam_Click);
            // 
            // innghieng
            // 
            this.innghieng.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.innghieng.Image = ((System.Drawing.Image)(resources.GetObject("innghieng.Image")));
            this.innghieng.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.innghieng.Name = "innghieng";
            this.innghieng.Size = new System.Drawing.Size(23, 22);
            this.innghieng.Text = "toolStripButton4";
            this.innghieng.Click += new System.EventHandler(this.innghieng_Click);
            // 
            // gachchan
            // 
            this.gachchan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gachchan.Image = ((System.Drawing.Image)(resources.GetObject("gachchan.Image")));
            this.gachchan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.gachchan.Name = "gachchan";
            this.gachchan.Size = new System.Drawing.Size(23, 22);
            this.gachchan.Text = "toolStripButton5";
            this.gachchan.Click += new System.EventHandler(this.gachchan_Click);
            // 
            // richText
            // 
            this.richText.Location = new System.Drawing.Point(0, 52);
            this.richText.Name = "richText";
            this.richText.Size = new System.Drawing.Size(800, 400);
            this.richText.TabIndex = 3;
            this.richText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richText);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem heThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taoVanBanMoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dinhDangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moTapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem luuNoiDungVanBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripComboBox cbxFont;
        private System.Windows.Forms.ToolStripComboBox cbxSize;
        private System.Windows.Forms.ToolStripButton indam;
        private System.Windows.Forms.ToolStripButton innghieng;
        private System.Windows.Forms.ToolStripButton gachchan;
        private System.Windows.Forms.RichTextBox richText;
    }
}

