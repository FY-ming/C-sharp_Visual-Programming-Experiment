using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX3
{
    public partial class Type : Form
    {
        // 游戏状态变量
        private string targetText;          // 目标文本
        private int currentPosition = 0;     // 当前输入位置
        private int totalTime = 60;          // 总时间(秒)，默认60秒
        private int remainingTime;           // 剩余时间
        private int charCount = 30;          // 字符数，默认30个
        private bool isGameStarted = false;  // 游戏是否开始
        private bool isGameEnded = false;    // 游戏是否结束
        private List<bool> inputStatus;      // 记录每个位置的输入状态：true=正确，false=错误
        public Type()
        {
            InitializeComponent();
            InitializeGame();
        }
        // 初始化游戏状态
        private void InitializeGame()
        {
            remainingTime = totalTime;
            setTimeLabel.ForeColor = Color.Black;
            setTimeLabel.Text = $"剩余时间: {remainingTime}秒";

            topicNumberLabel.Text = "设置出题字数:";
            topicNumberTextBox.Text = charCount.ToString(); // 初始化文本框值
            resultTextBox.Clear();

            // 重置所有按钮状态
            setTopicButton.Enabled = true;
            startButton.Enabled = false;
            endButton.Enabled = false;
            fontButton.Enabled = true;
            setTimeButton.Enabled = true;

            // 重置已完成字符列表
            inputStatus = new List<bool>();

            // 重置题目文本框样式
            topicTextBox.ForeColor = Color.Black;
            topicTextBox.BackColor = SystemColors.Window;
        }
        private void Type_Load(object sender, EventArgs e)
        {
            // 设置默认字体和颜色
            topicTextBox.Font = new Font("宋体", 12);
            topicTextBox.ForeColor = Color.Black;

            resultTextBox.Font = new Font("宋体", 12);
            inputTextBox.Font = new Font("宋体", 12);
            inputTextBox.ForeColor = Color.Black;
        }
        // 题目字数文本框内容变化事件
        private void topicNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (isGameStarted) return; // 游戏进行中不允许修改

            if (int.TryParse(topicNumberTextBox.Text, out int newCount))
            {
                charCount = Math.Max(1, Math.Min(newCount, 200)); // 限制范围1-200
                topicNumberTextBox.Text = charCount.ToString();
            }
            else
            {
                // 输入非数字时恢复为当前有效数值
                topicNumberTextBox.Text = charCount.ToString();
            }
        }
        // 出题按钮点击事件
        private void setTopicButton_Click(object sender, EventArgs e)
        {
            if (isGameStarted) return;  // 游戏已开始，不再出题
            isGameEnded = false;
            // 从文本框获取有效字数
            if (int.TryParse(topicNumberTextBox.Text, out int newCount))
            {
                charCount = Math.Max(1, Math.Min(newCount, 200));
            }
            GenerateTargetText();  // 生成目标文本
            UpdateUIAfterSetTopic();  // 更新UI状态
        }

        // 生成目标文本
        private void GenerateTargetText()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789 ";
            Random random = new Random();
            char[] text = new char[charCount];

            for (int i = 0; i < charCount; i++)
            {
                text[i] = chars[random.Next(chars.Length)];
            }

            targetText = new string(text);
            topicTextBox.Text = targetText;
            topicTextBox.SelectionStart = 0;
            topicTextBox.SelectionLength = 0;
            // 重置已完成字符列表
            inputStatus.Clear();
            for (int i = 0; i < targetText.Length; i++)
            {
                inputStatus.Add(false); // 初始都为未输入
            }

        }

        // 开始按钮点击事件
        private void startButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(targetText))
            {
                MessageBox.Show("请先出题！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            isGameStarted = true;
            isGameEnded = false;
            currentPosition = 0;
            inputTextBox.Clear();
            setTopicButton.Enabled = false;
            setTimeButton.Enabled = false;
            inputTextBox.Enabled = true;
            startButton.Enabled = false;
            endButton.Enabled = true;
            remainingTime = totalTime;
            setTimeLabel.Text = $"剩余时间: {remainingTime}秒";
            timer1.Interval = 1000;  // 1秒间隔
            timer1.Start();          // 启动计时器
        }

        // 计时器Tick事件
        private void timer1_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            setTimeLabel.Text = $"剩余时间: {remainingTime}秒";

            // 时间不足10秒时，红色闪烁提示
            if (remainingTime <= 10)
            {
                setTimeLabel.ForeColor = (remainingTime % 2 == 0) ? Color.Black : Color.Red;
            }
            else
            {
                setTimeLabel.ForeColor = Color.Black;
            }

            if (remainingTime <= 0)
            {
                timer1.Stop();
                EndGame();
            }
        }
        // 输入文本框文本变化事件
        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!isGameStarted || isGameEnded) return;

            string inputText = inputTextBox.Text;

            // 禁用自动滚动，防止输入时跳动
            inputTextBox.SelectionStart = inputTextBox.Text.Length;
            inputTextBox.ScrollToCaret();

            // 高亮显示输入内容
            HighlightInputText(inputText);

            // 检查是否完成输入
            if (inputText.Length >= targetText.Length)
            {
                timer1.Stop();
                EndGame();
            }
        }

        // 高亮显示输入内容
        private void HighlightInputText(string inputText)
        {
            inputTextBox.SuspendLayout();

            // 清除之前的内容
            inputTextBox.Clear();

            // 逐字符比较并设置颜色
            for (int i = 0; i < inputText.Length; i++)
            {
                // 设置当前字符的颜色
                if (i < targetText.Length && inputText[i] == targetText[i])
                {
                    // 正确输入 - 绿色
                    inputTextBox.SelectionColor = Color.Green;
                }
                else
                {
                    // 错误输入 - 红色
                    inputTextBox.SelectionColor = Color.Red;
                }

                // 添加当前字符
                inputTextBox.AppendText(inputText[i].ToString());
            }

            // 恢复光标位置
            inputTextBox.SelectionStart = inputText.Length;

            inputTextBox.ResumeLayout();
        }
        // 交卷按钮点击事件
        private void endButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            EndGame();
        }
        // 结束游戏
        private void EndGame()
        {
            isGameEnded = true;
            isGameStarted = false;
            setTopicButton.Enabled = true;
            fontButton.Enabled = true;
            setTimeButton.Enabled = true;
            inputTextBox.Enabled = false;
            startButton.Enabled = true;
            endButton.Enabled = false;

            // 恢复时间标签颜色
            setTimeLabel.ForeColor = Color.Red;
            // 计算结果
            CalculateResult();
        }

        // 计算结果
        private void CalculateResult()
        {
            string inputText = inputTextBox.Text;
            int correctCount = 0;

            // 计算正确字符数
            int compareLength = Math.Min(targetText.Length, inputText.Length);
            for (int i = 0; i < compareLength; i++)
            {
                if (inputText[i] == targetText[i])
                {
                    correctCount++;
                }
            }

            // 计算准确率
            double accuracy = targetText.Length > 0 ? (double)correctCount / targetText.Length * 100 : 0;

            // 显示结果
            resultTextBox.Clear();
            resultTextBox.AppendText($"总字符数: {targetText.Length}\n");
            resultTextBox.AppendText($"正确字符数: {correctCount}\n");
            resultTextBox.AppendText($"准确率: {accuracy:F2}%\n");
            resultTextBox.AppendText($"用时: {totalTime - remainingTime}秒\n");

            if (correctCount == targetText.Length)
            {
                resultTextBox.AppendText("恭喜你，全部正确！");
            }
        }
        // 字体设计按钮点击事件
        private void fontButton_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                fontDialog.ShowColor = true;
                fontDialog.Font = topicTextBox.Font;
                fontDialog.Color = topicTextBox.ForeColor;

                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    topicTextBox.Font = fontDialog.Font;
                    topicTextBox.ForeColor = fontDialog.Color;
                }
            }
        }
        // 鼠标单击击设置时间
        private void setTimeButton_Click(object sender, EventArgs e)
        {
            if (isGameStarted) return;

            string input = Microsoft.VisualBasic.Interaction.InputBox(
                "请输入练习时间(1-300秒):", "设置练习时间", totalTime.ToString());

            if (int.TryParse(input, out int newTime) && newTime >= 1 && newTime <= 300)
            {
                totalTime = newTime;
                remainingTime = totalTime;
                setTimeLabel.Text = $"剩余时间: {remainingTime}秒";
            }
            else
            {
                MessageBox.Show("请输入有效数字(1-300)!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // 更新出题后的UI状态
        private void UpdateUIAfterSetTopic()
        {
            inputTextBox.Enabled = false;
            startButton.Enabled = true;
            endButton.Enabled = false;
            resultTextBox.Clear();
        }

    }
}
