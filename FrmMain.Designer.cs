namespace grit
{
    partial class FrmMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.ListResources = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.DlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.statusNOR = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMod = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFind = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.mnuEdit});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(558, 25);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.mnuSave});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOpen.Size = new System.Drawing.Size(152, 22);
            this.mnuOpen.Text = "打开";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSave.Size = new System.Drawing.Size(152, 22);
            this.mnuSave.Text = "保存";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // ListResources
            // 
            this.ListResources.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colText});
            this.ListResources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListResources.FullRowSelect = true;
            this.ListResources.GridLines = true;
            this.ListResources.Location = new System.Drawing.Point(0, 25);
            this.ListResources.MultiSelect = false;
            this.ListResources.Name = "ListResources";
            this.ListResources.Size = new System.Drawing.Size(558, 481);
            this.ListResources.TabIndex = 1;
            this.ListResources.UseCompatibleStateImageBehavior = false;
            this.ListResources.View = System.Windows.Forms.View.Details;
            this.ListResources.SelectedIndexChanged += new System.EventHandler(this.ListResources_SelectedIndexChanged);
            // 
            // colId
            // 
            this.colId.Text = "ID";
            this.colId.Width = 100;
            // 
            // colText
            // 
            this.colText.Text = "Text";
            this.colText.Width = 400;
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusNOR});
            this.statusMain.Location = new System.Drawing.Point(0, 484);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(558, 22);
            this.statusMain.TabIndex = 2;
            this.statusMain.Text = "statusStrip1";
            // 
            // statusNOR
            // 
            this.statusNOR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusNOR.Name = "statusNOR";
            this.statusNOR.Size = new System.Drawing.Size(0, 17);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFind,
            this.mnuAdd,
            this.mnuMod,
            this.mnuDel});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(59, 21);
            this.mnuEdit.Text = "编辑(&E)";
            // 
            // mnuAdd
            // 
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Size = new System.Drawing.Size(152, 22);
            this.mnuAdd.Text = "添加";
            // 
            // mnuMod
            // 
            this.mnuMod.Enabled = false;
            this.mnuMod.Name = "mnuMod";
            this.mnuMod.Size = new System.Drawing.Size(152, 22);
            this.mnuMod.Text = "修改";
            // 
            // mnuDel
            // 
            this.mnuDel.Enabled = false;
            this.mnuDel.Name = "mnuDel";
            this.mnuDel.Size = new System.Drawing.Size(152, 22);
            this.mnuDel.Text = "删除";
            // 
            // mnuFind
            // 
            this.mnuFind.Name = "mnuFind";
            this.mnuFind.Size = new System.Drawing.Size(152, 22);
            this.mnuFind.Text = "查找";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 506);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.ListResources);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Google Resource Pak Explore";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ListView ListResources;
        private System.Windows.Forms.OpenFileDialog DlgOpenFile;
        private System.Windows.Forms.SaveFileDialog DlgSaveFile;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colText;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripStatusLabel statusNOR;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuMod;
        private System.Windows.Forms.ToolStripMenuItem mnuDel;
        private System.Windows.Forms.ToolStripMenuItem mnuFind;
    }
}

