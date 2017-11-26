namespace HowToTrainTapirDoDo.Hopfield
{
    partial class HopfieldControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HopfieldControl));
            this.TrainBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.RunBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AutoBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ResetBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.UserInput = new DrawControl.DrawBox();
            this.Input3 = new DrawControl.DrawBox();
            this.Input2 = new DrawControl.DrawBox();
            this.Input1 = new DrawControl.DrawBox();
            this.ClearBtn = new Bunifu.Framework.UI.BunifuThinButton2();
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
            this.TrainBtn.Location = new System.Drawing.Point(385, 300);
            this.TrainBtn.Margin = new System.Windows.Forms.Padding(5);
            this.TrainBtn.Name = "TrainBtn";
            this.TrainBtn.Size = new System.Drawing.Size(91, 41);
            this.TrainBtn.TabIndex = 8;
            this.TrainBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TrainBtn.Click += new System.EventHandler(this.TrainBtn_Click);
            // 
            // RunBtn
            // 
            this.RunBtn.ActiveBorderThickness = 1;
            this.RunBtn.ActiveCornerRadius = 20;
            this.RunBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(80)))));
            this.RunBtn.ActiveForecolor = System.Drawing.Color.White;
            this.RunBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(80)))));
            this.RunBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.RunBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RunBtn.BackgroundImage")));
            this.RunBtn.ButtonText = "Run";
            this.RunBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RunBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.RunBtn.IdleBorderThickness = 1;
            this.RunBtn.IdleCornerRadius = 20;
            this.RunBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.RunBtn.IdleForecolor = System.Drawing.Color.AliceBlue;
            this.RunBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.RunBtn.Location = new System.Drawing.Point(623, 419);
            this.RunBtn.Margin = new System.Windows.Forms.Padding(5);
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.Size = new System.Drawing.Size(91, 41);
            this.RunBtn.TabIndex = 9;
            this.RunBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RunBtn.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // AutoBtn
            // 
            this.AutoBtn.ActiveBorderThickness = 1;
            this.AutoBtn.ActiveCornerRadius = 20;
            this.AutoBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(80)))));
            this.AutoBtn.ActiveForecolor = System.Drawing.Color.White;
            this.AutoBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(80)))));
            this.AutoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.AutoBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AutoBtn.BackgroundImage")));
            this.AutoBtn.ButtonText = "Auto";
            this.AutoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutoBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.AutoBtn.IdleBorderThickness = 1;
            this.AutoBtn.IdleCornerRadius = 20;
            this.AutoBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.AutoBtn.IdleForecolor = System.Drawing.Color.AliceBlue;
            this.AutoBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.AutoBtn.Location = new System.Drawing.Point(623, 470);
            this.AutoBtn.Margin = new System.Windows.Forms.Padding(5);
            this.AutoBtn.Name = "AutoBtn";
            this.AutoBtn.Size = new System.Drawing.Size(91, 41);
            this.AutoBtn.TabIndex = 14;
            this.AutoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AutoBtn.Click += new System.EventHandler(this.AutoBtn_Click);
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
            this.ResetBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.ResetBtn.IdleBorderThickness = 1;
            this.ResetBtn.IdleCornerRadius = 20;
            this.ResetBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.ResetBtn.IdleForecolor = System.Drawing.Color.AliceBlue;
            this.ResetBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.ResetBtn.Location = new System.Drawing.Point(494, 300);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(91, 41);
            this.ResetBtn.TabIndex = 15;
            this.ResetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // UserInput
            // 
            this.UserInput.IndexLine = true;
            this.UserInput.LineColor = System.Drawing.Color.Black;
            this.UserInput.Location = new System.Drawing.Point(385, 371);
            this.UserInput.Name = "UserInput";
            this.UserInput.Pixel = 20;
            this.UserInput.Size = new System.Drawing.Size(200, 200);
            this.UserInput.TabIndex = 13;
            // 
            // Input3
            // 
            this.Input3.IndexLine = true;
            this.Input3.LineColor = System.Drawing.Color.Black;
            this.Input3.Location = new System.Drawing.Point(725, 45);
            this.Input3.Name = "Input3";
            this.Input3.Pixel = 20;
            this.Input3.Size = new System.Drawing.Size(200, 200);
            this.Input3.TabIndex = 12;
            // 
            // Input2
            // 
            this.Input2.IndexLine = true;
            this.Input2.LineColor = System.Drawing.Color.Black;
            this.Input2.Location = new System.Drawing.Point(385, 45);
            this.Input2.Name = "Input2";
            this.Input2.Pixel = 20;
            this.Input2.Size = new System.Drawing.Size(200, 200);
            this.Input2.TabIndex = 11;
            // 
            // Input1
            // 
            this.Input1.IndexLine = true;
            this.Input1.LineColor = System.Drawing.Color.Black;
            this.Input1.Location = new System.Drawing.Point(45, 45);
            this.Input1.Name = "Input1";
            this.Input1.Pixel = 20;
            this.Input1.Size = new System.Drawing.Size(200, 200);
            this.Input1.TabIndex = 10;
            // 
            // ClearBtn
            // 
            this.ClearBtn.ActiveBorderThickness = 1;
            this.ClearBtn.ActiveCornerRadius = 20;
            this.ClearBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(80)))));
            this.ClearBtn.ActiveForecolor = System.Drawing.Color.White;
            this.ClearBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(80)))));
            this.ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ClearBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearBtn.BackgroundImage")));
            this.ClearBtn.ButtonText = "Clean";
            this.ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.ClearBtn.IdleBorderThickness = 1;
            this.ClearBtn.IdleCornerRadius = 20;
            this.ClearBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.ClearBtn.IdleForecolor = System.Drawing.Color.AliceBlue;
            this.ClearBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.ClearBtn.Location = new System.Drawing.Point(623, 521);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(91, 41);
            this.ClearBtn.TabIndex = 16;
            this.ClearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // HopfieldControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.AutoBtn);
            this.Controls.Add(this.UserInput);
            this.Controls.Add(this.Input3);
            this.Controls.Add(this.Input2);
            this.Controls.Add(this.Input1);
            this.Controls.Add(this.RunBtn);
            this.Controls.Add(this.TrainBtn);
            this.Name = "HopfieldControl";
            this.Size = new System.Drawing.Size(1102, 607);
            this.Load += new System.EventHandler(this.HopfieldControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 TrainBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 RunBtn;
        private DrawControl.DrawBox Input1;
        private DrawControl.DrawBox Input2;
        private DrawControl.DrawBox Input3;
        private DrawControl.DrawBox UserInput;
        private Bunifu.Framework.UI.BunifuThinButton2 AutoBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 ResetBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 ClearBtn;
    }
}
