namespace EX3
{
    partial class Type
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.inputTextBox = new System.Windows.Forms.RichTextBox();
            this.setTopicButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.endButton = new System.Windows.Forms.Button();
            this.fontButton = new System.Windows.Forms.Button();
            this.topicNumberLabel = new System.Windows.Forms.Label();
            this.setTimeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.topicLabel = new System.Windows.Forms.Label();
            this.inputLabel = new System.Windows.Forms.Label();
            this.topicNumberTextBox = new System.Windows.Forms.TextBox();
            this.setTimeButton = new System.Windows.Forms.Button();
            this.topicTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Enabled = false;
            this.inputTextBox.Location = new System.Drawing.Point(22, 286);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(860, 100);
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.Text = "";
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // setTopicButton
            // 
            this.setTopicButton.Location = new System.Drawing.Point(416, 164);
            this.setTopicButton.Name = "setTopicButton";
            this.setTopicButton.Size = new System.Drawing.Size(100, 50);
            this.setTopicButton.TabIndex = 2;
            this.setTopicButton.Text = "出题";
            this.setTopicButton.UseVisualStyleBackColor = true;
            this.setTopicButton.Click += new System.EventHandler(this.setTopicButton_Click);
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(35, 392);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 50);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "开始";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // endButton
            // 
            this.endButton.Enabled = false;
            this.endButton.Location = new System.Drawing.Point(241, 392);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(100, 50);
            this.endButton.TabIndex = 4;
            this.endButton.Text = "交卷";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // fontButton
            // 
            this.fontButton.Location = new System.Drawing.Point(22, 164);
            this.fontButton.Name = "fontButton";
            this.fontButton.Size = new System.Drawing.Size(100, 50);
            this.fontButton.TabIndex = 5;
            this.fontButton.Text = "字体设计";
            this.fontButton.UseVisualStyleBackColor = true;
            this.fontButton.Click += new System.EventHandler(this.fontButton_Click);
            // 
            // topicNumberLabel
            // 
            this.topicNumberLabel.AutoSize = true;
            this.topicNumberLabel.Enabled = false;
            this.topicNumberLabel.Location = new System.Drawing.Point(168, 180);
            this.topicNumberLabel.Name = "topicNumberLabel";
            this.topicNumberLabel.Size = new System.Drawing.Size(116, 18);
            this.topicNumberLabel.TabIndex = 6;
            this.topicNumberLabel.Text = "设置出题字数";
            // 
            // setTimeLabel
            // 
            this.setTimeLabel.AutoSize = true;
            this.setTimeLabel.Location = new System.Drawing.Point(599, 180);
            this.setTimeLabel.Name = "setTimeLabel";
            this.setTimeLabel.Size = new System.Drawing.Size(80, 18);
            this.setTimeLabel.TabIndex = 7;
            this.setTimeLabel.Text = "剩余时间";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Enabled = false;
            this.resultTextBox.Location = new System.Drawing.Point(22, 495);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(860, 100);
            this.resultTextBox.TabIndex = 8;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Enabled = false;
            this.resultLabel.Location = new System.Drawing.Point(49, 463);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(80, 18);
            this.resultLabel.TabIndex = 9;
            this.resultLabel.Text = "测试结果";
            // 
            // topicLabel
            // 
            this.topicLabel.AutoSize = true;
            this.topicLabel.Enabled = false;
            this.topicLabel.Location = new System.Drawing.Point(49, 32);
            this.topicLabel.Name = "topicLabel";
            this.topicLabel.Size = new System.Drawing.Size(44, 18);
            this.topicLabel.TabIndex = 10;
            this.topicLabel.Text = "题目";
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Enabled = false;
            this.inputLabel.Location = new System.Drawing.Point(49, 265);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(62, 18);
            this.inputLabel.TabIndex = 11;
            this.inputLabel.Text = "练习区";
            // 
            // topicNumberTextBox
            // 
            this.topicNumberTextBox.Location = new System.Drawing.Point(299, 177);
            this.topicNumberTextBox.Name = "topicNumberTextBox";
            this.topicNumberTextBox.Size = new System.Drawing.Size(100, 28);
            this.topicNumberTextBox.TabIndex = 12;
            this.topicNumberTextBox.TextChanged += new System.EventHandler(this.topicNumberTextBox_TextChanged);
            // 
            // setTimeButton
            // 
            this.setTimeButton.Location = new System.Drawing.Point(756, 164);
            this.setTimeButton.Name = "setTimeButton";
            this.setTimeButton.Size = new System.Drawing.Size(126, 50);
            this.setTimeButton.TabIndex = 13;
            this.setTimeButton.Text = "设置练习时间";
            this.setTimeButton.UseVisualStyleBackColor = true;
            this.setTimeButton.Click += new System.EventHandler(this.setTimeButton_Click);
            // 
            // topicTextBox
            // 
            this.topicTextBox.Location = new System.Drawing.Point(22, 53);
            this.topicTextBox.Name = "topicTextBox";
            this.topicTextBox.Size = new System.Drawing.Size(860, 100);
            this.topicTextBox.TabIndex = 14;
            this.topicTextBox.Text = "";
            // 
            // Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 722);
            this.Controls.Add(this.topicTextBox);
            this.Controls.Add(this.setTimeButton);
            this.Controls.Add(this.topicNumberTextBox);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.topicLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.setTimeLabel);
            this.Controls.Add(this.topicNumberLabel);
            this.Controls.Add(this.fontButton);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.setTopicButton);
            this.Controls.Add(this.inputTextBox);
            this.Name = "Type";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Type_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox inputTextBox;
        private System.Windows.Forms.Button setTopicButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Button fontButton;
        private System.Windows.Forms.Label topicNumberLabel;
        private System.Windows.Forms.Label setTimeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label topicLabel;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox topicNumberTextBox;
        private System.Windows.Forms.Button setTimeButton;
        private System.Windows.Forms.RichTextBox topicTextBox;
    }
}

