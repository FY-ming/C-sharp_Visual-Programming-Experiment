using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
    public partial class Form1 : Form
    {
        private string randomText; // 随机生成的文本
        private int currentPosition = 0; // 当前输入位置
        private int correctChars = 0; // 正确字符数
        private int startTime = 60; // 默认60秒
        private int remainingTime; // 剩余时间
        private Timer timer; // 计时器
        private Font currentFont = new Font("Arial", 12); // 默认字体
        public Form1()
        {
            InitializeComponent();
            InitializeUI();
            InitializeTimer();
            GenerateRandomText(50); // 默认生成50个字符的文本
        }
    
        private void InitializeUI()
        {
            this.Text = "打字练习软件";
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            // 创建控件
            Label instructionLabel = new Label
            {
                Text = "请输入下方随机生成的文本:",
                Location = new Point(20, 20),
                Size = new Size(200, 20)
            };

            RichTextBox randomTextBox = new RichTextBox
            {
                Name = "randomTextBox",
                Location = new Point(20, 50),
                Size = new Size(740, 100),
                ReadOnly = true,
                BackColor = Color.White,
                Font = currentFont
            };

            Label inputLabel = new Label
            {
                Text = "输入区域:",
                Location = new Point(20, 170),
                Size = new Size(100, 20)
            };

            RichTextBox inputTextBox = new RichTextBox
            {
                Name = "inputTextBox",
                Location = new Point(20, 200),
                Size = new Size(740, 100),
                Font = currentFont
            };
            inputTextBox.KeyPress += InputTextBox_KeyPress;

            Label timeLabel = new Label
            {
                Name = "timeLabel",
                Text = "剩余时间: 60秒",
                Location = new Point(20, 320),
                Size = new Size(150, 20),
                Font = new Font("Arial", 12, FontStyle.Bold)
            };

            Button startButton = new Button
            {
                Text = "开始",
                Location = new Point(20, 360),
                Size = new Size(100, 30)
            };
            startButton.Click += StartButton_Click;

            Button fontButton = new Button
            {
                Text = "字体设置",
                Location = new Point(140, 360),
                Size = new Size(100, 30)
            };
            fontButton.Click += FontButton_Click;

            Label resultLabel = new Label
            {
                Name = "resultLabel",
                Text = "成绩将显示在这里",
                Location = new Point(20, 410),
                Size = new Size(740, 20),
                Font = new Font("Arial", 12, FontStyle.Bold)
            };

            // 添加控件到窗体
            this.Controls.Add(instructionLabel);
            this.Controls.Add(randomTextBox);
            this.Controls.Add(inputLabel);
            this.Controls.Add(inputTextBox);
            this.Controls.Add(timeLabel);
            this.Controls.Add(startButton);
            this.Controls.Add(fontButton);
            this.Controls.Add(resultLabel);

            // 保存对控件的引用
            randomTextBox.Tag = "randomTextBox";
            inputTextBox.Tag = "inputTextBox";
            timeLabel.Tag = "timeLabel";
            resultLabel.Tag = "resultLabel";
        }

        private void InitializeTimer()
        {
            timer = new Timer
            {
                Interval = 1000 // 1秒
            };
            timer.Tick += Timer_Tick;
        }

        private void GenerateRandomText(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789 ";
            Random random = new Random();
            char[] buffer = new char[length];

            for (int i = 0; i < length; i++)
            {
                buffer[i] = chars[random.Next(chars.Length)];
            }

            randomText = new string(buffer);
            RichTextBox randomTextBox = FindControl("randomTextBox") as RichTextBox;
            if (randomTextBox != null)
            {
                randomTextBox.Text = randomText;
                randomTextBox.SelectAll();
                randomTextBox.SelectionColor = Color.Black;
                randomTextBox.DeselectAll();
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            Button startButton = sender as Button;
            if (startButton != null)
            {
                if (timer.Enabled)
                {
                    // 停止当前练习
                    timer.Stop();
                    startButton.Text = "开始";
                    RichTextBox inputTextBox = FindControl("inputTextBox") as RichTextBox;
                    if (inputTextBox != null)
                    {
                        inputTextBox.ReadOnly = true;
                    }
                }
                else
                {
                    // 开始新练习
                    GenerateRandomText(50);
                    currentPosition = 0;
                    correctChars = 0;
                    remainingTime = startTime;

                    Label timeLabel = FindControl("timeLabel") as Label;
                    if (timeLabel != null)
                    {
                        timeLabel.Text = $"剩余时间: {remainingTime}秒";
                    }

                    RichTextBox inputTextBox = FindControl("inputTextBox") as RichTextBox;
                    if (inputTextBox != null)
                    {
                        inputTextBox.Clear();
                        inputTextBox.ReadOnly = false;
                        inputTextBox.Focus();
                    }

                    Label resultLabel = FindControl("resultLabel") as Label;
                    if (resultLabel != null)
                    {
                        resultLabel.Text = "正在练习...";
                    }

                    timer.Start();
                    startButton.Text = "停止";
                }
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            Label timeLabel = FindControl("timeLabel") as Label;
            if (timeLabel != null)
            {
                timeLabel.Text = $"剩余时间: {remainingTime}秒";

                if (remainingTime <= 0)
                {
                    timer.Stop();
                    Button startButton = FindControl("StartButton") as Button;
                    if (startButton != null)
                    {
                        startButton.Text = "开始";
                    }

                    RichTextBox inputTextBox = FindControl("inputTextBox") as RichTextBox;
                    if (inputTextBox != null)
                    {
                        inputTextBox.ReadOnly = true;
                    }

                    CalculateResult();
                }
            }
        }

        private void InputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            RichTextBox inputTextBox = sender as RichTextBox;
            RichTextBox randomTextBox = FindControl("randomTextBox") as RichTextBox;

            if (inputTextBox == null || randomTextBox == null || !timer.Enabled)
            {
                return;
            }

            // 检查输入是否正确
            if (currentPosition < randomText.Length)
            {
                char currentChar = randomText[currentPosition];

                // 显示用户输入
                inputTextBox.AppendText(e.KeyChar.ToString());

                // 检查输入是否正确并设置颜色
                if (e.KeyChar == currentChar)
                {
                    correctChars++;
                    randomTextBox.Select(currentPosition, 1);
                    randomTextBox.SelectionColor = Color.Green;
                    randomTextBox.DeselectAll();
                }
                else
                {
                    randomTextBox.Select(currentPosition, 1);
                    randomTextBox.SelectionColor = Color.Red;
                    randomTextBox.DeselectAll();
                }

                currentPosition++;

                // 检查是否完成
                if (currentPosition >= randomText.Length)
                {
                    timer.Stop();
                    Button startButton = FindControl("StartButton") as Button;
                    if (startButton != null)
                    {
                        startButton.Text = "开始";
                    }

                    inputTextBox.ReadOnly = true;
                    CalculateResult();
                }
            }

            // 阻止默认处理，我们已经手动添加了字符
            e.Handled = true;
        }

        private void FontButton_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                fontDialog.Font = currentFont;
                fontDialog.Color = Color.Black;

                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFont = fontDialog.Font;

                    RichTextBox randomTextBox = FindControl("randomTextBox") as RichTextBox;
                    RichTextBox inputTextBox = FindControl("inputTextBox") as RichTextBox;

                    if (randomTextBox != null)
                    {
                        randomTextBox.Font = currentFont;
                    }

                    if (inputTextBox != null)
                    {
                        inputTextBox.Font = currentFont;
                    }
                }
            }
        }

        private void CalculateResult()
        {
            Label resultLabel = FindControl("resultLabel") as Label;
            if (resultLabel != null)
            {
                double accuracy = 0;
                if (currentPosition > 0)
                {
                    accuracy = (double)correctChars / currentPosition * 100;
                }

                resultLabel.Text = $"练习完成！准确率: {accuracy:F2}%，速度: {correctChars} 字符";
            }
        }

        private Control FindControl(string name)
        {
            foreach (Control control in this.Controls)
            {
                if (control.Tag != null && control.Tag.ToString() == name)
                {
                    return control;
                }
            }
            return null;
        }
    }
}