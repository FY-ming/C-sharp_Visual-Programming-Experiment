namespace DocumentProcessor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.样式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水平平铺ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.垂直平铺ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.层叠ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.打开文件toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.保存文件toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.复制toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.粘贴toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.剪切toolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.样式ToolStripMenuItem,
            this.窗口ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.toolStripSeparator1,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.新建ToolStripMenuItem.Text = "新建";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制ToolStripMenuItem,
            this.粘贴ToolStripMenuItem,
            this.剪切ToolStripMenuItem,
            this.撤销ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.复制ToolStripMenuItem.Text = "复制";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.复制ToolStripMenuItem_Click);
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            this.粘贴ToolStripMenuItem.Click += new System.EventHandler(this.粘贴ToolStripMenuItem_Click);
            // 
            // 剪切ToolStripMenuItem
            // 
            this.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem";
            this.剪切ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.剪切ToolStripMenuItem.Text = "剪切";
            this.剪切ToolStripMenuItem.Click += new System.EventHandler(this.剪切ToolStripMenuItem_Click);
            // 
            // 撤销ToolStripMenuItem
            // 
            this.撤销ToolStripMenuItem.Name = "撤销ToolStripMenuItem";
            this.撤销ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.撤销ToolStripMenuItem.Text = "撤销";
            this.撤销ToolStripMenuItem.Click += new System.EventHandler(this.撤销ToolStripMenuItem_Click);
            // 
            // 样式ToolStripMenuItem
            // 
            this.样式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.颜色ToolStripMenuItem,
            this.字体ToolStripMenuItem});
            this.样式ToolStripMenuItem.Name = "样式ToolStripMenuItem";
            this.样式ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.样式ToolStripMenuItem.Text = "样式";
            // 
            // 颜色ToolStripMenuItem
            // 
            this.颜色ToolStripMenuItem.Name = "颜色ToolStripMenuItem";
            this.颜色ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.颜色ToolStripMenuItem.Text = "颜色";
            this.颜色ToolStripMenuItem.Click += new System.EventHandler(this.颜色ToolStripMenuItem_Click);
            // 
            // 字体ToolStripMenuItem
            // 
            this.字体ToolStripMenuItem.Name = "字体ToolStripMenuItem";
            this.字体ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.字体ToolStripMenuItem.Text = "字体";
            this.字体ToolStripMenuItem.Click += new System.EventHandler(this.字体ToolStripMenuItem_Click);
            // 
            // 窗口ToolStripMenuItem
            // 
            this.窗口ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.水平平铺ToolStripMenuItem,
            this.垂直平铺ToolStripMenuItem,
            this.层叠ToolStripMenuItem});
            this.窗口ToolStripMenuItem.Name = "窗口ToolStripMenuItem";
            this.窗口ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.窗口ToolStripMenuItem.Text = "窗口";
            // 
            // 水平平铺ToolStripMenuItem
            // 
            this.水平平铺ToolStripMenuItem.Name = "水平平铺ToolStripMenuItem";
            this.水平平铺ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.水平平铺ToolStripMenuItem.Text = "水平平铺";
            this.水平平铺ToolStripMenuItem.Click += new System.EventHandler(this.水平平铺ToolStripMenuItem_Click);
            // 
            // 垂直平铺ToolStripMenuItem
            // 
            this.垂直平铺ToolStripMenuItem.Name = "垂直平铺ToolStripMenuItem";
            this.垂直平铺ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.垂直平铺ToolStripMenuItem.Text = "垂直平铺";
            this.垂直平铺ToolStripMenuItem.Click += new System.EventHandler(this.垂直平铺ToolStripMenuItem_Click);
            // 
            // 层叠ToolStripMenuItem
            // 
            this.层叠ToolStripMenuItem.Name = "层叠ToolStripMenuItem";
            this.层叠ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.层叠ToolStripMenuItem.Text = "层叠";
            this.层叠ToolStripMenuItem.Click += new System.EventHandler(this.层叠ToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开文件toolStripButton,
            this.保存文件toolStripButton,
            this.复制toolStripButton,
            this.粘贴toolStripButton,
            this.剪切toolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 32);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 33);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // 打开文件toolStripButton
            // 
            this.打开文件toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.打开文件toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("打开文件toolStripButton.Image")));
            this.打开文件toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.打开文件toolStripButton.Name = "打开文件toolStripButton";
            this.打开文件toolStripButton.Size = new System.Drawing.Size(34, 28);
            this.打开文件toolStripButton.Text = "toolStripButton_openFile";
            this.打开文件toolStripButton.Click += new System.EventHandler(this.打开文件toolStripButton_Click);
            // 
            // 保存文件toolStripButton
            // 
            this.保存文件toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.保存文件toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("保存文件toolStripButton.Image")));
            this.保存文件toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.保存文件toolStripButton.Name = "保存文件toolStripButton";
            this.保存文件toolStripButton.Size = new System.Drawing.Size(34, 28);
            this.保存文件toolStripButton.Text = "toolStripButton_saveFile";
            this.保存文件toolStripButton.Click += new System.EventHandler(this.保存文件toolStripButton_Click);
            // 
            // 复制toolStripButton
            // 
            this.复制toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.复制toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("复制toolStripButton.Image")));
            this.复制toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.复制toolStripButton.Name = "复制toolStripButton";
            this.复制toolStripButton.Size = new System.Drawing.Size(34, 28);
            this.复制toolStripButton.Text = "toolStripButton_copy";
            this.复制toolStripButton.Click += new System.EventHandler(this.复制toolStripButton_Click);
            // 
            // 粘贴toolStripButton
            // 
            this.粘贴toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.粘贴toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("粘贴toolStripButton.Image")));
            this.粘贴toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.粘贴toolStripButton.Name = "粘贴toolStripButton";
            this.粘贴toolStripButton.Size = new System.Drawing.Size(34, 28);
            this.粘贴toolStripButton.Text = "toolStripButton_Paste";
            this.粘贴toolStripButton.Click += new System.EventHandler(this.粘贴toolStripButton_Click);
            // 
            // 剪切toolStripButton
            // 
            this.剪切toolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.剪切toolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("剪切toolStripButton.Image")));
            this.剪切toolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.剪切toolStripButton.Name = "剪切toolStripButton";
            this.剪切toolStripButton.Size = new System.Drawing.Size(34, 28);
            this.剪切toolStripButton.Text = "toolStripButton_cut";
            this.剪切toolStripButton.Click += new System.EventHandler(this.剪切toolStripButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "实验4-文本编辑器";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 样式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 剪切ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 颜色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字体ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 撤销ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton 打开文件toolStripButton;
        private System.Windows.Forms.ToolStripButton 保存文件toolStripButton;
        private System.Windows.Forms.ToolStripButton 复制toolStripButton;
        private System.Windows.Forms.ToolStripButton 粘贴toolStripButton;
        private System.Windows.Forms.ToolStripButton 剪切toolStripButton;
        private System.Windows.Forms.ToolStripMenuItem 水平平铺ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 垂直平铺ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 层叠ToolStripMenuItem;
    }
}

