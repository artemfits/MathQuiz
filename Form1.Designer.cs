namespace MathQuiz
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeLeftCaption = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.plusSignLabel = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.plusEqualsLabel = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.minusSignLabel = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.minusEqualsLabel = new System.Windows.Forms.Label();
            this.difference = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            this.timesLeftLabel = new System.Windows.Forms.Label();
            this.timesSignLabel = new System.Windows.Forms.Label();
            this.timesRightLabel = new System.Windows.Forms.Label();
            this.timesEqualsLabel = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            this.dividedLeftLabel = new System.Windows.Forms.Label();
            this.dividedSignLabel = new System.Windows.Forms.Label();
            this.dividedRightLabel = new System.Windows.Forms.Label();
            this.dividedEqualsLabel = new System.Windows.Forms.Label();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = false;
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.timeLabel.Location = new System.Drawing.Point(262, 15);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLabel.TabIndex = 20;
            this.timeLabel.Text = "";
            // 
            // timeLeftCaption
            // 
            this.timeLeftCaption.AutoSize = true;
            this.timeLeftCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.timeLeftCaption.Location = new System.Drawing.Point(140, 18);
            this.timeLeftCaption.Name = "timeLeftCaption";
            this.timeLeftCaption.Size = new System.Drawing.Size(100, 26);
            this.timeLeftCaption.TabIndex = 21;
            this.timeLeftCaption.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.AutoSize = false;
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.plusLeftLabel.Location = new System.Drawing.Point(50, 75);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.plusLeftLabel.TabIndex = 5;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusSignLabel
            // 
            this.plusSignLabel.AutoSize = false;
            this.plusSignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.plusSignLabel.Location = new System.Drawing.Point(120, 75);
            this.plusSignLabel.Name = "plusSignLabel";
            this.plusSignLabel.Size = new System.Drawing.Size(60, 50);
            this.plusSignLabel.TabIndex = 6;
            this.plusSignLabel.Text = "+";
            this.plusSignLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.AutoSize = false;
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.plusRightLabel.Location = new System.Drawing.Point(190, 75);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.plusRightLabel.TabIndex = 7;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusEqualsLabel
            // 
            this.plusEqualsLabel.AutoSize = false;
            this.plusEqualsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.plusEqualsLabel.Location = new System.Drawing.Point(260, 75);
            this.plusEqualsLabel.Name = "plusEqualsLabel";
            this.plusEqualsLabel.Size = new System.Drawing.Size(60, 50);
            this.plusEqualsLabel.TabIndex = 8;
            this.plusEqualsLabel.Text = "=";
            this.plusEqualsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.sum.Location = new System.Drawing.Point(330, 83);
            this.sum.MaximumSize = new System.Drawing.Size(100, 0);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(100, 35);
            this.sum.TabIndex = 1;
            this.sum.Enter += new System.EventHandler(this.answer_Enter);
            this.sum.ValueChanged += new System.EventHandler(this.answer_ValueChanged);
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.AutoSize = false;
            this.minusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.minusLeftLabel.Location = new System.Drawing.Point(50, 140);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.minusLeftLabel.TabIndex = 9;
            this.minusLeftLabel.Text = "?";
            this.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusSignLabel
            // 
            this.minusSignLabel.AutoSize = false;
            this.minusSignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.minusSignLabel.Location = new System.Drawing.Point(120, 140);
            this.minusSignLabel.Name = "minusSignLabel";
            this.minusSignLabel.Size = new System.Drawing.Size(60, 50);
            this.minusSignLabel.TabIndex = 10;
            this.minusSignLabel.Text = "-";
            this.minusSignLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.AutoSize = false;
            this.minusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.minusRightLabel.Location = new System.Drawing.Point(190, 140);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.minusRightLabel.TabIndex = 11;
            this.minusRightLabel.Text = "?";
            this.minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusEqualsLabel
            // 
            this.minusEqualsLabel.AutoSize = false;
            this.minusEqualsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.minusEqualsLabel.Location = new System.Drawing.Point(260, 140);
            this.minusEqualsLabel.Name = "minusEqualsLabel";
            this.minusEqualsLabel.Size = new System.Drawing.Size(60, 50);
            this.minusEqualsLabel.TabIndex = 12;
            this.minusEqualsLabel.Text = "=";
            this.minusEqualsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // difference
            // 
            this.difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.difference.Location = new System.Drawing.Point(330, 148);
            this.difference.MaximumSize = new System.Drawing.Size(100, 0);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(100, 35);
            this.difference.TabIndex = 2;
            this.difference.Enter += new System.EventHandler(this.answer_Enter);
            this.difference.ValueChanged += new System.EventHandler(this.answer_ValueChanged);
            // 
            // timesLeftLabel
            // 
            this.timesLeftLabel.AutoSize = false;
            this.timesLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.timesLeftLabel.Location = new System.Drawing.Point(50, 205);
            this.timesLeftLabel.Name = "timesLeftLabel";
            this.timesLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.timesLeftLabel.TabIndex = 13;
            this.timesLeftLabel.Text = "?";
            this.timesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesSignLabel
            // 
            this.timesSignLabel.AutoSize = false;
            this.timesSignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.timesSignLabel.Location = new System.Drawing.Point(120, 205);
            this.timesSignLabel.Name = "timesSignLabel";
            this.timesSignLabel.Size = new System.Drawing.Size(60, 50);
            this.timesSignLabel.TabIndex = 14;
            this.timesSignLabel.Text = "×";
            this.timesSignLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            this.timesRightLabel.AutoSize = false;
            this.timesRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.timesRightLabel.Location = new System.Drawing.Point(190, 205);
            this.timesRightLabel.Name = "timesRightLabel";
            this.timesRightLabel.Size = new System.Drawing.Size(60, 50);
            this.timesRightLabel.TabIndex = 15;
            this.timesRightLabel.Text = "?";
            this.timesRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesEqualsLabel
            // 
            this.timesEqualsLabel.AutoSize = false;
            this.timesEqualsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.timesEqualsLabel.Location = new System.Drawing.Point(260, 205);
            this.timesEqualsLabel.Name = "timesEqualsLabel";
            this.timesEqualsLabel.Size = new System.Drawing.Size(60, 50);
            this.timesEqualsLabel.TabIndex = 16;
            this.timesEqualsLabel.Text = "=";
            this.timesEqualsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.product.Location = new System.Drawing.Point(330, 213);
            this.product.MaximumSize = new System.Drawing.Size(100, 0);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(100, 35);
            this.product.TabIndex = 3;
            this.product.Enter += new System.EventHandler(this.answer_Enter);
            this.product.ValueChanged += new System.EventHandler(this.answer_ValueChanged);
            // 
            // dividedLeftLabel
            // 
            this.dividedLeftLabel.AutoSize = false;
            this.dividedLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.dividedLeftLabel.Location = new System.Drawing.Point(50, 270);
            this.dividedLeftLabel.Name = "dividedLeftLabel";
            this.dividedLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.dividedLeftLabel.TabIndex = 17;
            this.dividedLeftLabel.Text = "?";
            this.dividedLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedSignLabel
            // 
            this.dividedSignLabel.AutoSize = false;
            this.dividedSignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.dividedSignLabel.Location = new System.Drawing.Point(120, 270);
            this.dividedSignLabel.Name = "dividedSignLabel";
            this.dividedSignLabel.Size = new System.Drawing.Size(60, 50);
            this.dividedSignLabel.TabIndex = 18;
            this.dividedSignLabel.Text = "÷";
            this.dividedSignLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            this.dividedRightLabel.AutoSize = false;
            this.dividedRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.dividedRightLabel.Location = new System.Drawing.Point(190, 270);
            this.dividedRightLabel.Name = "dividedRightLabel";
            this.dividedRightLabel.Size = new System.Drawing.Size(60, 50);
            this.dividedRightLabel.TabIndex = 19;
            this.dividedRightLabel.Text = "?";
            this.dividedRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedEqualsLabel
            // 
            this.dividedEqualsLabel.AutoSize = false;
            this.dividedEqualsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.dividedEqualsLabel.Location = new System.Drawing.Point(260, 270);
            this.dividedEqualsLabel.Name = "dividedEqualsLabel";
            this.dividedEqualsLabel.Size = new System.Drawing.Size(60, 50);
            this.dividedEqualsLabel.TabIndex = 20;
            this.dividedEqualsLabel.Text = "=";
            this.dividedEqualsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            this.quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.quotient.Location = new System.Drawing.Point(330, 278);
            this.quotient.MaximumSize = new System.Drawing.Size(100, 0);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(100, 35);
            this.quotient.TabIndex = 4;
            this.quotient.Enter += new System.EventHandler(this.answer_Enter);
            this.quotient.ValueChanged += new System.EventHandler(this.answer_ValueChanged);
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.startButton.Location = new System.Drawing.Point(165, 315);
            this.startButton.Name = "startButton";
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start the quiz";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Math Quiz";
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.timeLeftCaption);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.plusSignLabel);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.plusEqualsLabel);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.minusSignLabel);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.minusEqualsLabel);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.timesLeftLabel);
            this.Controls.Add(this.timesSignLabel);
            this.Controls.Add(this.timesRightLabel);
            this.Controls.Add(this.timesEqualsLabel);
            this.Controls.Add(this.product);
            this.Controls.Add(this.dividedLeftLabel);
            this.Controls.Add(this.dividedSignLabel);
            this.Controls.Add(this.dividedRightLabel);
            this.Controls.Add(this.dividedEqualsLabel);
            this.Controls.Add(this.quotient);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label timeLeftCaption;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label plusSignLabel;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label plusEqualsLabel;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.Label minusSignLabel;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Label minusEqualsLabel;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.Label timesLeftLabel;
        private System.Windows.Forms.Label timesSignLabel;
        private System.Windows.Forms.Label timesRightLabel;
        private System.Windows.Forms.Label timesEqualsLabel;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.Label dividedLeftLabel;
        private System.Windows.Forms.Label dividedSignLabel;
        private System.Windows.Forms.Label dividedRightLabel;
        private System.Windows.Forms.Label dividedEqualsLabel;
        private System.Windows.Forms.NumericUpDown quotient;
    }
}
