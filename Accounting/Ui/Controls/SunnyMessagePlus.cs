using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Ui.Controls
{
    public class SunnyMessagePlus : Sunny.UI.UIForm
    {
        private Sunny.UI.UIStyleManager uiStyleManager1;
        private System.ComponentModel.IContainer components;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Sunny.UI.UISymbolButton uiSymbolButton3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UIContextMenuStrip uiContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem بلهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem خیرToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem انصرافToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem کپیمتنپیامToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem جستجومتنپیامToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIToolTip uiToolTip1;
        private Sunny.UI.UISymbolButton uiSymbolButton1;

        public SunnyMessagePlus()
        {
            InitializeComponent();
            this.uiStyleManager1.Style = Sunny.UI.UIStyle.Red;

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.uiStyleManager1 = new Sunny.UI.UIStyleManager(this.components);
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton3 = new Sunny.UI.UISymbolButton();
            this.label1 = new System.Windows.Forms.Label();
            this.uiContextMenuStrip1 = new Sunny.UI.UIContextMenuStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.بلهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خیرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.انصرافToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.کپیمتنپیامToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.جستجومتنپیامToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uiToolTip1 = new Sunny.UI.UIToolTip(this.components);
            this.uiContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiSymbolButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiSymbolButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiSymbolButton1.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.uiSymbolButton1.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiSymbolButton1.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiSymbolButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolButton1.LightColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.uiSymbolButton1.Location = new System.Drawing.Point(390, 352);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Radius = 10;
            this.uiSymbolButton1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiSymbolButton1.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.uiSymbolButton1.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiSymbolButton1.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiSymbolButton1.Size = new System.Drawing.Size(178, 50);
            this.uiSymbolButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton1.TabIndex = 0;
            this.uiSymbolButton1.Text = "بله";
            this.uiSymbolButton1.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // uiSymbolButton2
            // 
            this.uiSymbolButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiSymbolButton2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiSymbolButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiSymbolButton2.FillHoverColor = System.Drawing.Color.DimGray;
            this.uiSymbolButton2.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiSymbolButton2.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiSymbolButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolButton2.Location = new System.Drawing.Point(202, 352);
            this.uiSymbolButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.Radius = 10;
            this.uiSymbolButton2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiSymbolButton2.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.uiSymbolButton2.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiSymbolButton2.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiSymbolButton2.Size = new System.Drawing.Size(178, 50);
            this.uiSymbolButton2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton2.Symbol = 61453;
            this.uiSymbolButton2.TabIndex = 0;
            this.uiSymbolButton2.Text = "خیر";
            this.uiSymbolButton2.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiSymbolButton2.Click += new System.EventHandler(this.uiSymbolButton2_Click);
            // 
            // uiSymbolButton3
            // 
            this.uiSymbolButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiSymbolButton3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiSymbolButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiSymbolButton3.FillHoverColor = System.Drawing.Color.DimGray;
            this.uiSymbolButton3.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiSymbolButton3.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiSymbolButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolButton3.Location = new System.Drawing.Point(13, 352);
            this.uiSymbolButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton3.Name = "uiSymbolButton3";
            this.uiSymbolButton3.Radius = 10;
            this.uiSymbolButton3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiSymbolButton3.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.uiSymbolButton3.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiSymbolButton3.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiSymbolButton3.Size = new System.Drawing.Size(178, 50);
            this.uiSymbolButton3.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton3.Symbol = 61534;
            this.uiSymbolButton3.TabIndex = 0;
            this.uiSymbolButton3.Text = "انصراف";
            this.uiSymbolButton3.TipsFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.uiSymbolButton3.Click += new System.EventHandler(this.uiSymbolButton3_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(190, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 64);
            this.label1.TabIndex = 2;
            this.label1.Text = "موضوع پیام";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiContextMenuStrip1
            // 
            this.uiContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.uiContextMenuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.uiContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.uiContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.بلهToolStripMenuItem,
            this.خیرToolStripMenuItem,
            this.toolStripSeparator1,
            this.انصرافToolStripMenuItem,
            this.toolStripSeparator2,
            this.کپیمتنپیامToolStripMenuItem,
            this.جستجومتنپیامToolStripMenuItem});
            this.uiContextMenuStrip1.Name = "uiContextMenuStrip1";
            this.uiContextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiContextMenuStrip1.Size = new System.Drawing.Size(265, 289);
            this.uiContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.uiContextMenuStrip1_Opening);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(238, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(238, 6);
            // 
            // بلهToolStripMenuItem
            // 
            this.بلهToolStripMenuItem.Image = global::Accounting.Properties.Resources.icons8_tick_40;
            this.بلهToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.بلهToolStripMenuItem.Name = "بلهToolStripMenuItem";
            this.بلهToolStripMenuItem.Size = new System.Drawing.Size(241, 48);
            this.بلهToolStripMenuItem.Text = "بله";
            this.بلهToolStripMenuItem.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // خیرToolStripMenuItem
            // 
            this.خیرToolStripMenuItem.Image = global::Accounting.Properties.Resources.icons8_exit_40_1_;
            this.خیرToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.خیرToolStripMenuItem.Name = "خیرToolStripMenuItem";
            this.خیرToolStripMenuItem.Size = new System.Drawing.Size(241, 48);
            this.خیرToolStripMenuItem.Text = "خیر";
            this.خیرToolStripMenuItem.Click += new System.EventHandler(this.uiSymbolButton2_Click);
            // 
            // انصرافToolStripMenuItem
            // 
            this.انصرافToolStripMenuItem.Image = global::Accounting.Properties.Resources.icons8_unavailable_40;
            this.انصرافToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.انصرافToolStripMenuItem.Name = "انصرافToolStripMenuItem";
            this.انصرافToolStripMenuItem.Size = new System.Drawing.Size(241, 48);
            this.انصرافToolStripMenuItem.Text = "انصراف";
            this.انصرافToolStripMenuItem.Click += new System.EventHandler(this.uiSymbolButton3_Click);
            // 
            // کپیمتنپیامToolStripMenuItem
            // 
            this.کپیمتنپیامToolStripMenuItem.Image = global::Accounting.Properties.Resources.icons8_copy_40;
            this.کپیمتنپیامToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.کپیمتنپیامToolStripMenuItem.Name = "کپیمتنپیامToolStripMenuItem";
            this.کپیمتنپیامToolStripMenuItem.Size = new System.Drawing.Size(264, 48);
            this.کپیمتنپیامToolStripMenuItem.Text = "کپی متن پیام";
            this.کپیمتنپیامToolStripMenuItem.Click += new System.EventHandler(this.کپیمتنپیامToolStripMenuItem_Click);
            // 
            // جستجومتنپیامToolStripMenuItem
            // 
            this.جستجومتنپیامToolStripMenuItem.Image = global::Accounting.Properties.Resources.icons8_google_40;
            this.جستجومتنپیامToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.جستجومتنپیامToolStripMenuItem.Name = "جستجومتنپیامToolStripMenuItem";
            this.جستجومتنپیامToolStripMenuItem.Size = new System.Drawing.Size(264, 48);
            this.جستجومتنپیامToolStripMenuItem.Text = "جستجو متن پیام";
            this.جستجومتنپیامToolStripMenuItem.Click += new System.EventHandler(this.جستجومتنپیامToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Accounting.Properties.Resources.icons8_info_100;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(13, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(190, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 176);
            this.label2.TabIndex = 2;
            this.label2.Text = "متن پیام";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // uiToolTip1
            // 
            this.uiToolTip1.BackColor = System.Drawing.Color.White;
            this.uiToolTip1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.uiToolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiToolTip1.OwnerDraw = true;
            this.uiToolTip1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.uiToolTip1.TitleFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // SunnyMessagePlus
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(579, 414);
            this.ContextMenuStrip = this.uiContextMenuStrip1;
            this.ControlBoxCloseFillHoverColor = System.Drawing.Color.Red;
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uiSymbolButton3);
            this.Controls.Add(this.uiSymbolButton2);
            this.Controls.Add(this.uiSymbolButton1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SunnyMessagePlus";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "سوال";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 800, 480);
            this.Load += new System.EventHandler(this.SunnyMessagePlus_Load);
            this.uiContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        public enum Types { Error, Warning, Info, Successful }
        public enum MessageButtons { YesNo, Ok, YesNoCancel }

        private Types types = Types.Error;
        private MessageButtons buttons = MessageButtons.Ok;

        public MessageButtons Buttons
        {
            get { return buttons; }
            set
            {
                this.buttons = value;
                switch (value)
                {
                    case MessageButtons.Ok:
                        this.uiSymbolButton1.Visible = true;
                        this.uiSymbolButton2.Visible = false;
                        this.uiSymbolButton3.Visible = false;
                        this.uiSymbolButton1.Text = "باشه";
                        break;

                    case MessageButtons.YesNoCancel:
                        this.uiSymbolButton1.Visible = true;
                        this.uiSymbolButton2.Visible = true;
                        this.uiSymbolButton3.Visible = true;
                        this.uiSymbolButton1.Text = "بله";
                        break;

                    case MessageButtons.YesNo:
                        this.uiSymbolButton1.Visible = true;
                        this.uiSymbolButton2.Visible = true;
                        this.uiSymbolButton3.Visible = false;
                        this.uiSymbolButton1.Text = "بله";
                        break;
                }
            }
        }

        public Types Type
        {
            get { return types; }
            set
            {
                types = value;
                switch (value)
                {
                    case Types.Error:
                        this.pictureBox1.BackgroundImage = Properties.Resources.icons8_warning_100;
                        break;
                    case Types.Warning:
                        this.pictureBox1.BackgroundImage = Properties.Resources.icons8_warning_100_1_;
                        break;
                    case Types.Info:
                        this.pictureBox1.BackgroundImage = Properties.Resources.icons8_info_100;
                        break;
                    case Types.Successful:
                        this.pictureBox1.BackgroundImage = Properties.Resources.icons8_tick_100;
                        break;
                }
            }
        }

        public string MainText
        {
            get { return this.label2.Text; }
            set
            {
                this.label2.Text = value;
            }
        }

        public string Subject
        {
            get { return this.label1.Text; }
            set
            {
                this.label1.Text = value;
            }
        }

        public string Title
        {
            get { return this.Title; }
            set { this.Title = value; }
        }

        private void uiSymbolButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SunnyMessagePlus_Load(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {

        }

        private void کپیمتنپیامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(this.label2.Text);

            WFAlert.AlertMessage.Style = WFAlert.Styles.Fill;
            WFAlert.AlertMessage.AlertSounds.Success = WFAlert.Sounds.ESound;

            WFAlert.AlertMessage.Show("متن پیام کپی شد", WFAlert.Types.Success, false);

        }

        private void جستجومتنپیامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=" + this.label2.Text);
        }

        private void uiContextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            بلهToolStripMenuItem.Visible = this.uiSymbolButton1.Visible;
            خیرToolStripMenuItem.Visible = this.uiSymbolButton2.Visible;
            انصرافToolStripMenuItem.Visible = this.uiSymbolButton3.Visible;
        }
    }
}
