namespace HowToTrainTapirDoDo
{
    partial class TLUControl
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TLUControl));
            this.XY_Panel = new System.Windows.Forms.Panel();
            this.XY_Point_Panel = new System.Windows.Forms.Panel();
            this.XY_Line_Panel = new System.Windows.Forms.Panel();
            this.XY_Tip = new System.Windows.Forms.ToolTip(this.components);
            this.ResetBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.TrainBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Tb1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Tb2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Tb3 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Tb4 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.error = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ErrorAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Tb5 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.Log = new System.Windows.Forms.RichTextBox();
            this.XY_Panel.SuspendLayout();
            this.XY_Point_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // XY_Panel
            // 
            this.XY_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.XY_Panel.Controls.Add(this.XY_Point_Panel);
            this.ErrorAnimator.SetDecoration(this.XY_Panel, BunifuAnimatorNS.DecorationType.None);
            this.XY_Panel.Location = new System.Drawing.Point(56, 109);
            this.XY_Panel.Name = "XY_Panel";
            this.XY_Panel.Size = new System.Drawing.Size(401, 401);
            this.XY_Panel.TabIndex = 5;
            this.XY_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.XY_Panel_Paint);
            // 
            // XY_Point_Panel
            // 
            this.XY_Point_Panel.BackColor = System.Drawing.Color.Transparent;
            this.XY_Point_Panel.Controls.Add(this.XY_Line_Panel);
            this.ErrorAnimator.SetDecoration(this.XY_Point_Panel, BunifuAnimatorNS.DecorationType.None);
            this.XY_Point_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XY_Point_Panel.Location = new System.Drawing.Point(0, 0);
            this.XY_Point_Panel.Name = "XY_Point_Panel";
            this.XY_Point_Panel.Size = new System.Drawing.Size(401, 401);
            this.XY_Point_Panel.TabIndex = 0;
            this.XY_Point_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.XY_Panel_Paint);
            this.XY_Point_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.XY_Point_Panel_MouseDown);
            this.XY_Point_Panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.XY_Point_Panel_MouseMove);
            // 
            // XY_Line_Panel
            // 
            this.XY_Line_Panel.BackColor = System.Drawing.Color.Transparent;
            this.ErrorAnimator.SetDecoration(this.XY_Line_Panel, BunifuAnimatorNS.DecorationType.None);
            this.XY_Line_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XY_Line_Panel.Location = new System.Drawing.Point(0, 0);
            this.XY_Line_Panel.Name = "XY_Line_Panel";
            this.XY_Line_Panel.Size = new System.Drawing.Size(401, 401);
            this.XY_Line_Panel.TabIndex = 1;
            // 
            // XY_Tip
            // 
            this.XY_Tip.AutomaticDelay = 100;
            this.XY_Tip.AutoPopDelay = 1000;
            this.XY_Tip.InitialDelay = 100;
            this.XY_Tip.ReshowDelay = 20;
            // 
            // ResetBtn
            // 
            this.ResetBtn.ActiveBorderThickness = 1;
            this.ResetBtn.ActiveCornerRadius = 20;
            this.ResetBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(80)))));
            this.ResetBtn.ActiveForecolor = System.Drawing.Color.White;
            this.ResetBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(80)))));
            this.ResetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ResetBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ResetBtn.BackgroundImage")));
            this.ResetBtn.ButtonText = "Reset";
            this.ResetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ErrorAnimator.SetDecoration(this.ResetBtn, BunifuAnimatorNS.DecorationType.None);
            this.ResetBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.ResetBtn.IdleBorderThickness = 1;
            this.ResetBtn.IdleCornerRadius = 20;
            this.ResetBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.ResetBtn.IdleForecolor = System.Drawing.Color.AliceBlue;
            this.ResetBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.ResetBtn.Location = new System.Drawing.Point(501, 427);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(91, 41);
            this.ResetBtn.TabIndex = 6;
            this.ResetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // TrainBtn
            // 
            this.TrainBtn.ActiveBorderThickness = 1;
            this.TrainBtn.ActiveCornerRadius = 20;
            this.TrainBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(80)))));
            this.TrainBtn.ActiveForecolor = System.Drawing.Color.White;
            this.TrainBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(80)))));
            this.TrainBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.TrainBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TrainBtn.BackgroundImage")));
            this.TrainBtn.ButtonText = "Train";
            this.TrainBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ErrorAnimator.SetDecoration(this.TrainBtn, BunifuAnimatorNS.DecorationType.None);
            this.TrainBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.TrainBtn.IdleBorderThickness = 1;
            this.TrainBtn.IdleCornerRadius = 20;
            this.TrainBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.TrainBtn.IdleForecolor = System.Drawing.Color.AliceBlue;
            this.TrainBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.TrainBtn.Location = new System.Drawing.Point(627, 427);
            this.TrainBtn.Margin = new System.Windows.Forms.Padding(5);
            this.TrainBtn.Name = "TrainBtn";
            this.TrainBtn.Size = new System.Drawing.Size(91, 41);
            this.TrainBtn.TabIndex = 7;
            this.TrainBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TrainBtn.Click += new System.EventHandler(this.TrainBtn_Click);
            // 
            // Tb1
            // 
            this.Tb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Tb1.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(0)))), ((int)(((byte)(88)))));
            this.Tb1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Tb1.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(0)))), ((int)(((byte)(88)))));
            this.Tb1.BorderThickness = 3;
            this.Tb1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ErrorAnimator.SetDecoration(this.Tb1, BunifuAnimatorNS.DecorationType.None);
            this.Tb1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb1.ForeColor = System.Drawing.Color.White;
            this.Tb1.isPassword = false;
            this.Tb1.Location = new System.Drawing.Point(615, 268);
            this.Tb1.Margin = new System.Windows.Forms.Padding(4);
            this.Tb1.Name = "Tb1";
            this.Tb1.Size = new System.Drawing.Size(103, 44);
            this.Tb1.TabIndex = 10;
            this.Tb1.Text = "1";
            this.Tb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Tb1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Tb3_MouseClick);
            // 
            // Tb2
            // 
            this.Tb2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Tb2.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(0)))), ((int)(((byte)(88)))));
            this.Tb2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Tb2.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(0)))), ((int)(((byte)(88)))));
            this.Tb2.BorderThickness = 3;
            this.Tb2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ErrorAnimator.SetDecoration(this.Tb2, BunifuAnimatorNS.DecorationType.None);
            this.Tb2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb2.ForeColor = System.Drawing.Color.White;
            this.Tb2.isPassword = false;
            this.Tb2.Location = new System.Drawing.Point(501, 268);
            this.Tb2.Margin = new System.Windows.Forms.Padding(4);
            this.Tb2.Name = "Tb2";
            this.Tb2.Size = new System.Drawing.Size(83, 44);
            this.Tb2.TabIndex = 11;
            this.Tb2.Text = "1.5";
            this.Tb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Tb2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Tb3_MouseClick);
            // 
            // Tb3
            // 
            this.Tb3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Tb3.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(0)))), ((int)(((byte)(88)))));
            this.Tb3.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Tb3.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(0)))), ((int)(((byte)(88)))));
            this.Tb3.BorderThickness = 3;
            this.Tb3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ErrorAnimator.SetDecoration(this.Tb3, BunifuAnimatorNS.DecorationType.None);
            this.Tb3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb3.ForeColor = System.Drawing.Color.White;
            this.Tb3.isPassword = false;
            this.Tb3.Location = new System.Drawing.Point(501, 351);
            this.Tb3.Margin = new System.Windows.Forms.Padding(4);
            this.Tb3.Name = "Tb3";
            this.Tb3.Size = new System.Drawing.Size(91, 44);
            this.Tb3.TabIndex = 12;
            this.Tb3.Text = "80";
            this.Tb3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Tb3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Tb3_MouseClick);
            // 
            // Tb4
            // 
            this.Tb4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Tb4.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(0)))), ((int)(((byte)(88)))));
            this.Tb4.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Tb4.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(0)))), ((int)(((byte)(88)))));
            this.Tb4.BorderThickness = 3;
            this.Tb4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ErrorAnimator.SetDecoration(this.Tb4, BunifuAnimatorNS.DecorationType.None);
            this.Tb4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb4.ForeColor = System.Drawing.Color.White;
            this.Tb4.isPassword = false;
            this.Tb4.Location = new System.Drawing.Point(615, 351);
            this.Tb4.Margin = new System.Windows.Forms.Padding(4);
            this.Tb4.Name = "Tb4";
            this.Tb4.Size = new System.Drawing.Size(91, 44);
            this.Tb4.TabIndex = 13;
            this.Tb4.Text = "-100";
            this.Tb4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Tb4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Tb3_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.ErrorAnimator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(611, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Learning Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.ErrorAnimator.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(497, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Threshold";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.ErrorAnimator.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(497, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "w1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.ErrorAnimator.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(611, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "w2";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.BackColor = System.Drawing.Color.Transparent;
            this.ErrorAnimator.SetDecoration(this.error, BunifuAnimatorNS.DecorationType.None);
            this.error.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(497, 109);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(108, 23);
            this.error.TabIndex = 18;
            this.error.Text = "Input Error";
            // 
            // ErrorAnimator
            // 
            this.ErrorAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.ErrorAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.ErrorAnimator.DefaultAnimation = animation1;
            // 
            // Tb5
            // 
            this.Tb5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Tb5.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(0)))), ((int)(((byte)(88)))));
            this.Tb5.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Tb5.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(0)))), ((int)(((byte)(88)))));
            this.Tb5.BorderThickness = 3;
            this.Tb5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ErrorAnimator.SetDecoration(this.Tb5, BunifuAnimatorNS.DecorationType.None);
            this.Tb5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb5.ForeColor = System.Drawing.Color.White;
            this.Tb5.isPassword = false;
            this.Tb5.Location = new System.Drawing.Point(501, 175);
            this.Tb5.Margin = new System.Windows.Forms.Padding(4);
            this.Tb5.Name = "Tb5";
            this.Tb5.Size = new System.Drawing.Size(217, 44);
            this.Tb5.TabIndex = 20;
            this.Tb5.Text = "5000";
            this.Tb5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.ErrorAnimator.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(497, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Max training round";
            // 
            // Log
            // 
            this.Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.ErrorAnimator.SetDecoration(this.Log, BunifuAnimatorNS.DecorationType.None);
            this.Log.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Log.ForeColor = System.Drawing.Color.White;
            this.Log.Location = new System.Drawing.Point(774, 109);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(179, 387);
            this.Log.TabIndex = 22;
            this.Log.Text = "";
            // 
            // TLUControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.Log);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Tb5);
            this.Controls.Add(this.error);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb4);
            this.Controls.Add(this.Tb3);
            this.Controls.Add(this.Tb2);
            this.Controls.Add(this.Tb1);
            this.Controls.Add(this.TrainBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.XY_Panel);
            this.ErrorAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.Name = "TLUControl";
            this.Size = new System.Drawing.Size(1102, 607);
            this.Load += new System.EventHandler(this.TLUControl1_Load);
            this.XY_Panel.ResumeLayout(false);
            this.XY_Point_Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel XY_Panel;
        private System.Windows.Forms.Panel XY_Point_Panel;
        private System.Windows.Forms.ToolTip XY_Tip;
        private Bunifu.Framework.UI.BunifuThinButton2 ResetBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 TrainBtn;
        private Bunifu.Framework.UI.BunifuMetroTextbox Tb1;
        private Bunifu.Framework.UI.BunifuMetroTextbox Tb2;
        private Bunifu.Framework.UI.BunifuMetroTextbox Tb3;
        private Bunifu.Framework.UI.BunifuMetroTextbox Tb4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuCustomLabel error;
        private BunifuAnimatorNS.BunifuTransition ErrorAnimator;
        private System.Windows.Forms.Panel XY_Line_Panel;
        private Bunifu.Framework.UI.BunifuMetroTextbox Tb5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox Log;
    }
}
