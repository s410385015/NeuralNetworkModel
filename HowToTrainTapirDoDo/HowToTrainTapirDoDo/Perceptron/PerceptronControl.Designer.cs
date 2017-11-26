namespace HowToTrainTapirDoDo.Perceptron
{
    partial class PerceptronControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerceptronControl));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.TrainBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Log = new System.Windows.Forms.RichTextBox();
            this.ResetBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tb2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Tb1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.error = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ErrorAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.UserOutput = new DrawControl.DrawBox();
            this.UserInput = new DrawControl.DrawBox();
            this.output5 = new DrawControl.DrawBox();
            this.output4 = new DrawControl.DrawBox();
            this.output3 = new DrawControl.DrawBox();
            this.output2 = new DrawControl.DrawBox();
            this.output1 = new DrawControl.DrawBox();
            this.input5 = new DrawControl.DrawBox();
            this.input4 = new DrawControl.DrawBox();
            this.Input2 = new DrawControl.DrawBox();
            this.Input3 = new DrawControl.DrawBox();
            this.Input1 = new DrawControl.DrawBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.ErrorAnimator.SetDecoration(this.TrainBtn, BunifuAnimatorNS.DecorationType.None);
            this.TrainBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrainBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.TrainBtn.IdleBorderThickness = 1;
            this.TrainBtn.IdleCornerRadius = 20;
            this.TrainBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.TrainBtn.IdleForecolor = System.Drawing.Color.AliceBlue;
            this.TrainBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.TrainBtn.Location = new System.Drawing.Point(401, 506);
            this.TrainBtn.Margin = new System.Windows.Forms.Padding(5);
            this.TrainBtn.Name = "TrainBtn";
            this.TrainBtn.Size = new System.Drawing.Size(91, 41);
            this.TrainBtn.TabIndex = 9;
            this.TrainBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TrainBtn.Click += new System.EventHandler(this.TrainBtn_Click);
            // 
            // Log
            // 
            this.Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.ErrorAnimator.SetDecoration(this.Log, BunifuAnimatorNS.DecorationType.None);
            this.Log.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Log.ForeColor = System.Drawing.Color.White;
            this.Log.Location = new System.Drawing.Point(507, 63);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(179, 387);
            this.Log.TabIndex = 23;
            this.Log.Text = "";
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
            this.ResetBtn.Location = new System.Drawing.Point(300, 506);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(91, 41);
            this.ResetBtn.TabIndex = 24;
            this.ResetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.ErrorAnimator.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(44, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Input";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.ErrorAnimator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(320, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.ErrorAnimator.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Threshold";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.ErrorAnimator.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(158, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Learning Rate";
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
            this.Tb2.Location = new System.Drawing.Point(48, 503);
            this.Tb2.Margin = new System.Windows.Forms.Padding(4);
            this.Tb2.Name = "Tb2";
            this.Tb2.Size = new System.Drawing.Size(83, 44);
            this.Tb2.TabIndex = 30;
            this.Tb2.Text = "1.5";
            this.Tb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.Tb1.Location = new System.Drawing.Point(162, 503);
            this.Tb1.Margin = new System.Windows.Forms.Padding(4);
            this.Tb1.Name = "Tb1";
            this.Tb1.Size = new System.Drawing.Size(103, 44);
            this.Tb1.TabIndex = 29;
            this.Tb1.Text = "1";
            this.Tb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.BackColor = System.Drawing.Color.Transparent;
            this.ErrorAnimator.SetDecoration(this.error, BunifuAnimatorNS.DecorationType.None);
            this.error.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(44, 561);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(108, 23);
            this.error.TabIndex = 33;
            this.error.Text = "Input Error";
            // 
            // ErrorAnimator
            // 
            this.ErrorAnimator.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
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
            animation1.TransparencyCoeff = 0F;
            this.ErrorAnimator.DefaultAnimation = animation1;
            // 
            // UserOutput
            // 
            this.ErrorAnimator.SetDecoration(this.UserOutput, BunifuAnimatorNS.DecorationType.None);
            this.UserOutput.IndexLine = true;
            this.UserOutput.LineColor = System.Drawing.Color.Black;
            this.UserOutput.Location = new System.Drawing.Point(712, 175);
            this.UserOutput.Name = "UserOutput";
            this.UserOutput.Pixel = 30;
            this.UserOutput.Size = new System.Drawing.Size(150, 30);
            this.UserOutput.TabIndex = 28;
            // 
            // UserInput
            // 
            this.ErrorAnimator.SetDecoration(this.UserInput, BunifuAnimatorNS.DecorationType.None);
            this.UserInput.IndexLine = true;
            this.UserInput.LineColor = System.Drawing.Color.Black;
            this.UserInput.Location = new System.Drawing.Point(712, 100);
            this.UserInput.Name = "UserInput";
            this.UserInput.Pixel = 30;
            this.UserInput.Size = new System.Drawing.Size(240, 30);
            this.UserInput.TabIndex = 27;
            // 
            // output5
            // 
            this.ErrorAnimator.SetDecoration(this.output5, BunifuAnimatorNS.DecorationType.None);
            this.output5.IndexLine = true;
            this.output5.LineColor = System.Drawing.Color.Black;
            this.output5.Location = new System.Drawing.Point(324, 400);
            this.output5.Name = "output5";
            this.output5.Pixel = 30;
            this.output5.Size = new System.Drawing.Size(150, 30);
            this.output5.TabIndex = 8;
            // 
            // output4
            // 
            this.ErrorAnimator.SetDecoration(this.output4, BunifuAnimatorNS.DecorationType.None);
            this.output4.IndexLine = true;
            this.output4.LineColor = System.Drawing.Color.Black;
            this.output4.Location = new System.Drawing.Point(324, 325);
            this.output4.Name = "output4";
            this.output4.Pixel = 30;
            this.output4.Size = new System.Drawing.Size(150, 30);
            this.output4.TabIndex = 7;
            // 
            // output3
            // 
            this.ErrorAnimator.SetDecoration(this.output3, BunifuAnimatorNS.DecorationType.None);
            this.output3.IndexLine = true;
            this.output3.LineColor = System.Drawing.Color.Black;
            this.output3.Location = new System.Drawing.Point(324, 250);
            this.output3.Name = "output3";
            this.output3.Pixel = 30;
            this.output3.Size = new System.Drawing.Size(150, 30);
            this.output3.TabIndex = 6;
            // 
            // output2
            // 
            this.ErrorAnimator.SetDecoration(this.output2, BunifuAnimatorNS.DecorationType.None);
            this.output2.IndexLine = true;
            this.output2.LineColor = System.Drawing.Color.Black;
            this.output2.Location = new System.Drawing.Point(324, 175);
            this.output2.Name = "output2";
            this.output2.Pixel = 30;
            this.output2.Size = new System.Drawing.Size(150, 30);
            this.output2.TabIndex = 5;
            // 
            // output1
            // 
            this.ErrorAnimator.SetDecoration(this.output1, BunifuAnimatorNS.DecorationType.None);
            this.output1.IndexLine = true;
            this.output1.LineColor = System.Drawing.Color.Black;
            this.output1.Location = new System.Drawing.Point(324, 100);
            this.output1.Name = "output1";
            this.output1.Pixel = 30;
            this.output1.Size = new System.Drawing.Size(150, 30);
            this.output1.TabIndex = 4;
            // 
            // input5
            // 
            this.ErrorAnimator.SetDecoration(this.input5, BunifuAnimatorNS.DecorationType.None);
            this.input5.IndexLine = true;
            this.input5.LineColor = System.Drawing.Color.Black;
            this.input5.Location = new System.Drawing.Point(48, 400);
            this.input5.Name = "input5";
            this.input5.Pixel = 30;
            this.input5.Size = new System.Drawing.Size(240, 30);
            this.input5.TabIndex = 3;
            // 
            // input4
            // 
            this.ErrorAnimator.SetDecoration(this.input4, BunifuAnimatorNS.DecorationType.None);
            this.input4.IndexLine = true;
            this.input4.LineColor = System.Drawing.Color.Black;
            this.input4.Location = new System.Drawing.Point(48, 325);
            this.input4.Name = "input4";
            this.input4.Pixel = 30;
            this.input4.Size = new System.Drawing.Size(240, 30);
            this.input4.TabIndex = 2;
            // 
            // Input2
            // 
            this.ErrorAnimator.SetDecoration(this.Input2, BunifuAnimatorNS.DecorationType.None);
            this.Input2.IndexLine = true;
            this.Input2.LineColor = System.Drawing.Color.Black;
            this.Input2.Location = new System.Drawing.Point(48, 175);
            this.Input2.Name = "Input2";
            this.Input2.Pixel = 30;
            this.Input2.Size = new System.Drawing.Size(240, 30);
            this.Input2.TabIndex = 1;
            // 
            // Input3
            // 
            this.ErrorAnimator.SetDecoration(this.Input3, BunifuAnimatorNS.DecorationType.None);
            this.Input3.IndexLine = true;
            this.Input3.LineColor = System.Drawing.Color.Black;
            this.Input3.Location = new System.Drawing.Point(48, 250);
            this.Input3.Name = "Input3";
            this.Input3.Pixel = 30;
            this.Input3.Size = new System.Drawing.Size(240, 30);
            this.Input3.TabIndex = 1;
            // 
            // Input1
            // 
            this.ErrorAnimator.SetDecoration(this.Input1, BunifuAnimatorNS.DecorationType.None);
            this.Input1.IndexLine = true;
            this.Input1.LineColor = System.Drawing.Color.Black;
            this.Input1.Location = new System.Drawing.Point(48, 100);
            this.Input1.Name = "Input1";
            this.Input1.Pixel = 30;
            this.Input1.Size = new System.Drawing.Size(240, 30);
            this.Input1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.ErrorAnimator.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(708, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 34;
            this.label4.Text = "New Input";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.ErrorAnimator.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(708, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 21);
            this.label6.TabIndex = 35;
            this.label6.Text = "Expect Input";
            // 
            // PerceptronControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.error);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tb2);
            this.Controls.Add(this.Tb1);
            this.Controls.Add(this.UserOutput);
            this.Controls.Add(this.UserInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.TrainBtn);
            this.Controls.Add(this.output5);
            this.Controls.Add(this.output4);
            this.Controls.Add(this.output3);
            this.Controls.Add(this.output2);
            this.Controls.Add(this.output1);
            this.Controls.Add(this.input5);
            this.Controls.Add(this.input4);
            this.Controls.Add(this.Input2);
            this.Controls.Add(this.Input3);
            this.Controls.Add(this.Input1);
            this.ErrorAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "PerceptronControl";
            this.Size = new System.Drawing.Size(1102, 607);
            this.Load += new System.EventHandler(this.PerceptronControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DrawControl.DrawBox Input1;
        private DrawControl.DrawBox Input3;
        private DrawControl.DrawBox Input2;
        private DrawControl.DrawBox input4;
        private DrawControl.DrawBox input5;
        private DrawControl.DrawBox output1;
        private DrawControl.DrawBox output2;
        private DrawControl.DrawBox output3;
        private DrawControl.DrawBox output4;
        private DrawControl.DrawBox output5;
        private Bunifu.Framework.UI.BunifuThinButton2 TrainBtn;
        private System.Windows.Forms.RichTextBox Log;
        private Bunifu.Framework.UI.BunifuThinButton2 ResetBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private DrawControl.DrawBox UserInput;
        private DrawControl.DrawBox UserOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox Tb2;
        private Bunifu.Framework.UI.BunifuMetroTextbox Tb1;
        private Bunifu.Framework.UI.BunifuCustomLabel error;
        private BunifuAnimatorNS.BunifuTransition ErrorAnimator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}
