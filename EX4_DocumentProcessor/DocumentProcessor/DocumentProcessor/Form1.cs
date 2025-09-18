using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DocumentProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
            this.IsMdiContainer = true; // 启用MDI容器
            // 设置文件对话框的过滤器
            openFileDialog1.Filter = "富文本文件 (*.rtf)|*.rtf|文本文件 (*.txt)|*.txt|所有文件 (*.*)|*.*";
            saveFileDialog1.Filter = "富文本文件 (*.rtf)|*.rtf|文本文件 (*.txt)|*.txt|所有文件 (*.*)|*.*";
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var child in this.MdiChildren)
            {
                if (child is ChildForm cf && cf.IsModified)
                {
                    var result = MessageBox.Show(
                        "有未保存的文件，是否继续退出？",
                        "确认退出",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.No)
                    {
                        e.Cancel = true; // 取消关闭
                        return;
                    }
                    break;
                }
            }
        }
        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm newChild = new ChildForm();
            newChild.MdiParent = this;
            newChild.Show();
        }
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
        private void OpenFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                try
                {
                    ChildForm child = new ChildForm();
                    child.MdiParent = this;
                    child.OpenFile(filePath);
                    child.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("打开文件失败：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void SaveFile()
        {
            if (ActiveMdiChild is ChildForm activeChild)
            {
                activeChild.SaveFile();
            }
        }
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyText();
        }
        private void CopyText()
        {
            if (ActiveMdiChild is ChildForm activeChild)
            {
                activeChild.Copy();
            }
        }
        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasteText();
        }
        private void PasteText()
        {
            if (ActiveMdiChild is ChildForm activeChild)
            {
                activeChild.Paste();
            }
        }
        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CutText();
        }

        private void CutText()
        {
            if (ActiveMdiChild is ChildForm activeChild)
            {
                activeChild.Cut();
            }
        }
        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UndoText();
        }

        private void UndoText()
        {
            if (ActiveMdiChild is ChildForm activeChild)
            {
                activeChild.Undo();
            }
        }
        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (ActiveMdiChild is ChildForm activeChild)
                {
                    activeChild.SetTextColor(colorDialog1.Color);
                }
            }
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                if (ActiveMdiChild is ChildForm activeChild)
                {
                    activeChild.SetTextFont(fontDialog1.Font);
                }
            }
        }
        private void 水平平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 垂直平铺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void 层叠ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        private void 打开文件toolStripButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void 保存文件toolStripButton_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void 复制toolStripButton_Click(object sender, EventArgs e)
        {
            CopyText();
        }

        private void 粘贴toolStripButton_Click(object sender, EventArgs e)
        {
            PasteText();
        }

        private void 剪切toolStripButton_Click(object sender, EventArgs e)
        {
            CutText();
        }
    }
    public class ChildForm : Form
    {
        private RichTextBox richTextBox;
        private bool _isModified = false; // 标记文件是否被修改
        public bool IsModified => _isModified;
        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            // 在文本变更时设置修改状态
            _isModified = true;
        }
        public ChildForm()
        {
            InitializeComponent();
            this.Text = "未命名";
        }

        private void InitializeComponent()
        {
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.ContextMenuStrip = new ContextMenuStrip();
            this.richTextBox.ContextMenuStrip.Items.AddRange(new ToolStripItem[] {
                new ToolStripMenuItem("复制", null, (s, e) => Copy()),
                new ToolStripMenuItem("粘贴", null, (s, e) => Paste()),
                new ToolStripMenuItem("剪切", null, (s, e) => Cut()),
                new ToolStripMenuItem("撤销", null, (s, e) => Undo())
            });
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(800, 450);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // ChildForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox);
            this.Name = "ChildForm";
            this.ResumeLayout(false);
            richTextBox.TextChanged += (s, e) => _isModified = true;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // 检测快捷键组合
            switch (keyData)
            {
                case Keys.Control | Keys.C:  // Ctrl+C
                    Copy();
                    return true;

                case Keys.Control | Keys.V:  // Ctrl+V
                    Paste();
                    return true;

                case Keys.Control | Keys.X:  // Ctrl+X
                    Cut();
                    return true;

                case Keys.Control | Keys.Z:  // Ctrl+Z
                    Undo();
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_isModified)
            {
                var result = MessageBox.Show(
                    $"是否保存对 {this.Text} 的更改？",
                    "确认保存",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SaveFile(); // 调用保存方法
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true; // 取消关闭操作
                }
            }
            base.OnFormClosing(e);
        }
        public void OpenFile(string filePath)
        {
            try
            {
                string ext = Path.GetExtension(filePath).ToLower();

                if (ext == ".rtf")
                {
                    // RTF文件直接加载
                    richTextBox.LoadFile(filePath, RichTextBoxStreamType.RichText);
                }
                else
                {
                    // 文本文件按编码读取
                    using (StreamReader reader = new StreamReader(filePath, Encoding.Default, true))
                    {
                        richTextBox.Text = reader.ReadToEnd();
                    }
                }

                this.Text = Path.GetFileName(filePath);
                this.Tag = filePath;
                _isModified = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"打开文件失败：{ex.Message}", "错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SaveFile()
        {
            try
            {
                if (this.Tag != null && File.Exists(this.Tag as string))
                {
                    SaveExistingFile();
                }
                else
                {
                    SaveNewFile();
                }
                _isModified = false;
                MessageBox.Show("文件保存成功!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);   
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存文件失败：{ex.Message}", "错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveExistingFile()
        {
            string filePath = this.Tag as string;
            string ext = Path.GetExtension(filePath).ToLower();

            if (ext == ".rtf")
            {
                richTextBox.SaveFile(filePath, RichTextBoxStreamType.RichText);
            }
            else
            {
                File.WriteAllText(filePath, richTextBox.Text, Encoding.UTF8);
            }
        }

        private void SaveNewFile()
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "富文本文件 (*.rtf)|*.rtf|文本文件 (*.txt)|*.txt|所有文件 (*.*)|*.*";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string ext = Path.GetExtension(saveDialog.FileName).ToLower();

                    if (ext == ".rtf")
                    {
                        richTextBox.SaveFile(saveDialog.FileName, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        File.WriteAllText(saveDialog.FileName, richTextBox.Text, Encoding.UTF8);
                    }

                    this.Text = Path.GetFileName(saveDialog.FileName);
                    this.Tag = saveDialog.FileName;
                }
            }
        }
        public void Copy()
        {
            richTextBox.Copy();
        }

        public void Paste()
        {
            richTextBox.Paste();
        }

        public void Cut()
        {
            richTextBox.Cut();
        }

        public void Undo()
        {
            richTextBox.Undo();
        }

        public void SetTextColor(Color color)
        {
            richTextBox.SelectionColor = color;
        }

        public void SetTextFont(Font font)
        {
            richTextBox.SelectionFont = font;
        }
    }
}
