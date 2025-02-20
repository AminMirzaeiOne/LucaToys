using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Sunny.UI;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SunnyMessagePlus));
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.uiStyleManager1 = new Sunny.UI.UIStyleManager(this.components);
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton3 = new Sunny.UI.UISymbolButton();
            this.label1 = new System.Windows.Forms.Label();
            this.uiContextMenuStrip1 = new Sunny.UI.UIContextMenuStrip();
            this.بلهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.خیرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.انصرافToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
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
            this.uiSymbolButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolButton1.Location = new System.Drawing.Point(389, 351);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Radius = 10;
            this.uiSymbolButton1.Size = new System.Drawing.Size(178, 50);
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
            this.uiSymbolButton2.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.uiSymbolButton2.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.uiSymbolButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolButton2.Location = new System.Drawing.Point(201, 351);
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
            this.uiSymbolButton3.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.uiSymbolButton3.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.uiSymbolButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSymbolButton3.Location = new System.Drawing.Point(12, 351);
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
            this.انصرافToolStripMenuItem,
            this.toolStripSeparator2,
            this.کپیمتنپیامToolStripMenuItem,
            this.جستجومتنپیامToolStripMenuItem});
            this.uiContextMenuStrip1.Name = "uiContextMenuStrip1";
            this.uiContextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiContextMenuStrip1.Size = new System.Drawing.Size(242, 250);
            this.uiContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.uiContextMenuStrip1_Opening);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(238, 6);
            // 
            // کپیمتنپیامToolStripMenuItem
            // 
            this.کپیمتنپیامToolStripMenuItem.Image = global::Accounting.Properties.Resources.icons8_copy_40;
            this.کپیمتنپیامToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.کپیمتنپیامToolStripMenuItem.Name = "کپیمتنپیامToolStripMenuItem";
            this.کپیمتنپیامToolStripMenuItem.Size = new System.Drawing.Size(241, 48);
            this.کپیمتنپیامToolStripMenuItem.Text = "کپی متن پیام";
            this.کپیمتنپیامToolStripMenuItem.Click += new System.EventHandler(this.کپیمتنپیامToolStripMenuItem_Click);
            // 
            // جستجومتنپیامToolStripMenuItem
            // 
            this.جستجومتنپیامToolStripMenuItem.Image = global::Accounting.Properties.Resources.icons8_google_40;
            this.جستجومتنپیامToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.جستجومتنپیامToolStripMenuItem.Name = "جستجومتنپیامToolStripMenuItem";
            this.جستجومتنپیامToolStripMenuItem.Size = new System.Drawing.Size(241, 48);
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
            this.AcceptButton = this.uiSymbolButton1;
            this.ClientSize = new System.Drawing.Size(579, 414);
            this.ContextMenuStrip = this.uiContextMenuStrip1;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uiSymbolButton3);
            this.Controls.Add(this.uiSymbolButton2);
            this.Controls.Add(this.uiSymbolButton1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SunnyMessagePlus";
            this.Text = "سوال";
            this.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 800, 480);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SunnyMessagePlus_FormClosed);
            this.Load += new System.EventHandler(this.SunnyMessagePlus_Load);
            this.uiContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        public enum Types { Error, Warning, Info, Successful }
        public enum MessageButtons { YesNo, Ok, YesNoCancel }
        public enum Results { None, Ok, Yes, No, Cancel }

        private Types types = Types.Error;
        private MessageButtons buttons = MessageButtons.Ok;
        private Results result = Results.None;

        public Results Result
        {
            get { return result; }
            private set
            {
                this.result = value;
            }
        }

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
                        if (this.TitleText == string.Empty)
                            this.TitleText = "خطا ناموفق";
                        break;
                    case Types.Warning:
                        this.pictureBox1.BackgroundImage = Properties.Resources.icons8_warning_100_1_;

                        if (this.TitleText == string.Empty)
                            this.TitleText = "اخطار";

                        break;
                    case Types.Info:
                        this.pictureBox1.BackgroundImage = Properties.Resources.icons8_info_100;

                        if (this.TitleText == string.Empty)
                            this.TitleText = "اطلاع";

                        break;
                    case Types.Successful:
                        this.pictureBox1.BackgroundImage = Properties.Resources.icons8_tick_100;

                        if (this.TitleText == string.Empty)
                            this.TitleText = "موفقیت";

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

        public string TitleText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public UIStyle StyleColor
        {
            get { return this.uiStyleManager1.Style; }
            set
            {
                this.uiStyleManager1.Style = value;
                switch (value)
                {
                    case UIStyle.Blue:
                        this.label1.ForeColor = Color.FromArgb(64, 128, 204);
                        break;
                    case UIStyle.Red:
                        this.label1.ForeColor = Color.FromArgb(230, 80, 80);
                        break;
                    case UIStyle.Purple:
                        this.label1.ForeColor = Color.FromArgb(102, 58, 183);
                        break;
                    case UIStyle.LayuiRed:
                        this.label1.ForeColor = Color.FromArgb(255, 87, 34);
                        break;
                    case UIStyle.DarkBlue:
                        this.label1.ForeColor = Color.FromArgb(64, 128, 204);
                        break;
                    case UIStyle.Green:
                        this.label1.ForeColor = Color.FromArgb(88, 152, 32);
                        break;
                    case UIStyle.Gray:
                        this.label1.ForeColor = Color.FromArgb(112, 112, 112);
                        break;
                    case UIStyle.Orange:
                        this.label1.ForeColor = Color.FromArgb(220, 155, 40);
                        break;
                    case UIStyle.LayuiGreen:
                        this.label1.ForeColor = Color.FromArgb(0, 120, 109);
                        break;
                    case UIStyle.LayuiOrange:
                        this.label1.ForeColor = Color.FromArgb(204, 148, 0);
                        break;
                    case UIStyle.Black:
                        this.label1.ForeColor = Color.DodgerBlue;
                        break;
                }
                this.uiSymbolButton2.RectColor = this.label1.ForeColor;
                this.uiSymbolButton3.RectColor = this.label1.ForeColor;
                this.uiSymbolButton2.RectHoverColor = this.label1.ForeColor;
                this.uiSymbolButton3.RectHoverColor = this.label1.ForeColor;
                this.uiSymbolButton2.RectPressColor = this.label1.ForeColor;
                this.uiSymbolButton3.RectPressColor = this.label1.ForeColor;
            }
        }

        private void uiSymbolButton3_Click(object sender, EventArgs e)
        {
            switch (this.Buttons)
            {
                case MessageButtons.YesNo:
                case MessageButtons.YesNoCancel:
                    this.Result = Results.Cancel;
                    break;
            }
            this.Close();
        }

        private void SunnyMessagePlus_Load(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            switch (this.Buttons)
            {
                case MessageButtons.Ok:
                    this.Result = Results.Ok;
                    break;

                case MessageButtons.YesNo:
                case MessageButtons.YesNoCancel:
                    this.Result = Results.Yes;
                    break;
            }
            this.Close();
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            switch (this.Buttons)
            {
                case MessageButtons.YesNo:
                case MessageButtons.YesNoCancel:
                    this.Result = Results.No;
                    break;
            }
            this.Close();
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

        private Results sendResult = Results.None;

        public static Results ShowMessage(UIForm parent,string title, string subject, string maintext, Ui.Controls.SunnyMessagePlus.Types type, Ui.Controls.SunnyMessagePlus.MessageButtons buttons, UIStyle style)
        {
            SunnyMessagePlus msg = new SunnyMessagePlus();
            msg.StyleColor = style;
            msg.TitleText = title;
            msg.Subject = subject;
            msg.MainText = maintext;
            msg.Type = type;
            msg.Buttons = buttons;
            msg.Show();
            return msg.sendResult;


        }

        private void SunnyMessagePlus_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            this.sendResult = this.Result;
        }
    }
}
