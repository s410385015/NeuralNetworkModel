namespace HowToTrainTapirDoDo.Backpropagtion
{
    partial class BackpropagationControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackpropagationControl));
            this.TrainBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.InputBox = new DrawControl.DrawBox();
            this.DataList = new System.Windows.Forms.ListBox();
            this.DelBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ShowBox = new DrawControl.DrawBox();
            this.HorList = new System.Windows.Forms.ListView();
            this.AddBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.RedoBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.RemoveBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.UserBox = new DrawControl.DrawBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.ClnBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedoBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClnBtn)).BeginInit();
            this.SuspendLayout();
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
            this.TrainBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.TrainBtn.IdleBorderThickness = 1;
            this.TrainBtn.IdleCornerRadius = 20;
            this.TrainBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.TrainBtn.IdleForecolor = System.Drawing.Color.AliceBlue;
            this.TrainBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.TrainBtn.Location = new System.Drawing.Point(515, 82);
            this.TrainBtn.Margin = new System.Windows.Forms.Padding(5);
            this.TrainBtn.Name = "TrainBtn";
            this.TrainBtn.Size = new System.Drawing.Size(91, 41);
            this.TrainBtn.TabIndex = 9;
            this.TrainBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TrainBtn.Click += new System.EventHandler(this.TrainBtn_Click);
            // 
            // InputBox
            // 
            this.InputBox.LineColor = System.Drawing.Color.Transparent;
            this.InputBox.Location = new System.Drawing.Point(69, 82);
            this.InputBox.Name = "InputBox";
            this.InputBox.Pixel = 25;
            this.InputBox.Size = new System.Drawing.Size(225, 225);
            this.InputBox.TabIndex = 10;
            // 
            // DataList
            // 
            this.DataList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.DataList.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DataList.ForeColor = System.Drawing.Color.White;
            this.DataList.FormattingEnabled = true;
            this.DataList.ItemHeight = 21;
            this.DataList.Location = new System.Drawing.Point(369, 23);
            this.DataList.Name = "DataList";
            this.DataList.Size = new System.Drawing.Size(87, 571);
            this.DataList.TabIndex = 15;
            this.DataList.SelectedIndexChanged += new System.EventHandler(this.DataList_SelectedIndexChanged);
            // 
            // DelBtn
            // 
            this.DelBtn.ActiveBorderThickness = 1;
            this.DelBtn.ActiveCornerRadius = 20;
            this.DelBtn.ActiveFillColor = System.Drawing.Color.Red;
            this.DelBtn.ActiveForecolor = System.Drawing.Color.White;
            this.DelBtn.ActiveLineColor = System.Drawing.Color.Red;
            this.DelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.DelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DelBtn.BackgroundImage")));
            this.DelBtn.ButtonText = "Reset";
            this.DelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelBtn.ForeColor = System.Drawing.Color.White;
            this.DelBtn.IdleBorderThickness = 1;
            this.DelBtn.IdleCornerRadius = 20;
            this.DelBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(0)))), ((int)(((byte)(88)))));
            this.DelBtn.IdleForecolor = System.Drawing.Color.AliceBlue;
            this.DelBtn.IdleLineColor = System.Drawing.Color.White;
            this.DelBtn.Location = new System.Drawing.Point(647, 83);
            this.DelBtn.Margin = new System.Windows.Forms.Padding(5);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(78, 41);
            this.DelBtn.TabIndex = 16;
            this.DelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // ShowBox
            // 
            this.ShowBox.LineColor = System.Drawing.Color.Transparent;
            this.ShowBox.Location = new System.Drawing.Point(69, 351);
            this.ShowBox.Name = "ShowBox";
            this.ShowBox.Pixel = 25;
            this.ShowBox.Size = new System.Drawing.Size(225, 225);
            this.ShowBox.TabIndex = 18;
            // 
            // HorList
            // 
            this.HorList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.HorList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.HorList.Location = new System.Drawing.Point(69, 23);
            this.HorList.Name = "HorList";
            this.HorList.Size = new System.Drawing.Size(224, 39);
            this.HorList.TabIndex = 20;
            this.HorList.UseCompatibleStateImageBehavior = false;
            this.HorList.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.HorList_DrawItem);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.AddBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("AddBtn.ErrorImage")));
            this.AddBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddBtn.Image")));
            this.AddBtn.ImageActive = null;
            this.AddBtn.Location = new System.Drawing.Point(299, 83);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(40, 40);
            this.AddBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddBtn.TabIndex = 21;
            this.AddBtn.TabStop = false;
            this.AddBtn.Zoom = 10;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RedoBtn
            // 
            this.RedoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.RedoBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("RedoBtn.ErrorImage")));
            this.RedoBtn.Image = ((System.Drawing.Image)(resources.GetObject("RedoBtn.Image")));
            this.RedoBtn.ImageActive = null;
            this.RedoBtn.Location = new System.Drawing.Point(299, 129);
            this.RedoBtn.Name = "RedoBtn";
            this.RedoBtn.Size = new System.Drawing.Size(40, 40);
            this.RedoBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RedoBtn.TabIndex = 22;
            this.RedoBtn.TabStop = false;
            this.RedoBtn.Zoom = 10;
            this.RedoBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.BackColor = System.Drawing.Color.Transparent;
            this.RemoveBtn.Image = ((System.Drawing.Image)(resources.GetObject("RemoveBtn.Image")));
            this.RemoveBtn.ImageActive = null;
            this.RemoveBtn.Location = new System.Drawing.Point(304, 351);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(35, 35);
            this.RemoveBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RemoveBtn.TabIndex = 23;
            this.RemoveBtn.TabStop = false;
            this.RemoveBtn.Zoom = 10;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Sample";
            // 
            // UserBox
            // 
            this.UserBox.LineColor = System.Drawing.Color.Transparent;
            this.UserBox.Location = new System.Drawing.Point(515, 231);
            this.UserBox.Name = "UserBox";
            this.UserBox.Pixel = 25;
            this.UserBox.Size = new System.Drawing.Size(225, 225);
            this.UserBox.TabIndex = 28;
            this.UserBox.Load += new System.EventHandler(this.drawBox1_Load);
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.ForeColor = System.Drawing.Color.White;
            this.OutputLabel.Location = new System.Drawing.Point(562, 170);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(126, 37);
            this.OutputLabel.TabIndex = 29;
            this.OutputLabel.Text = "Sample";
            // 
            // ClnBtn
            // 
            this.ClnBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ClnBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ClnBtn.ErrorImage")));
            this.ClnBtn.Image = ((System.Drawing.Image)(resources.GetObject("ClnBtn.Image")));
            this.ClnBtn.ImageActive = null;
            this.ClnBtn.Location = new System.Drawing.Point(700, 462);
            this.ClnBtn.Name = "ClnBtn";
            this.ClnBtn.Size = new System.Drawing.Size(40, 40);
            this.ClnBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClnBtn.TabIndex = 30;
            this.ClnBtn.TabStop = false;
            this.ClnBtn.Zoom = 10;
            this.ClnBtn.Click += new System.EventHandler(this.ClnBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BackpropagationControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.ClnBtn);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.RedoBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.HorList);
            this.Controls.Add(this.ShowBox);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.DataList);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.TrainBtn);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "BackpropagationControl";
            this.Size = new System.Drawing.Size(1102, 607);
            this.Load += new System.EventHandler(this.BackpropagationControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedoBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClnBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 TrainBtn;
        private DrawControl.DrawBox InputBox;
        private System.Windows.Forms.ListBox DataList;
        private Bunifu.Framework.UI.BunifuThinButton2 DelBtn;
        private DrawControl.DrawBox ShowBox;
        private System.Windows.Forms.ListView HorList;
        private Bunifu.Framework.UI.BunifuImageButton AddBtn;
        private Bunifu.Framework.UI.BunifuImageButton RedoBtn;
        private Bunifu.Framework.UI.BunifuImageButton RemoveBtn;
        private System.Windows.Forms.Label label1;
        private DrawControl.DrawBox UserBox;
        private System.Windows.Forms.Label OutputLabel;
        private Bunifu.Framework.UI.BunifuImageButton ClnBtn;
        private System.Windows.Forms.Timer timer1;
    }
}
