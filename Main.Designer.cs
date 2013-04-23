namespace VSDocJSDocConverter
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteTextBox = new VSDocJSDocConverter.PasteTextBox();
            this.pasteAndConvertStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearStripMenuItem,
            this.copyStripMenuItem,
            this.pasteAndConvertStripMenuItem,
            this.pasteStripMenuItem,
            this.selectAllStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(212, 114);
            // 
            // clearStripMenuItem
            // 
            this.clearStripMenuItem.Name = "clearStripMenuItem";
            this.clearStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.clearStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.clearStripMenuItem.Text = "Clear";
            this.clearStripMenuItem.Click += new System.EventHandler(this.clearStripMenuItem1_Click);
            // 
            // copyStripMenuItem
            // 
            this.copyStripMenuItem.Name = "copyStripMenuItem";
            this.copyStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.copyStripMenuItem.Text = "Copy";
            this.copyStripMenuItem.Click += new System.EventHandler(this.copyStripMenuItem2_Click);
            // 
            // pasteStripMenuItem
            // 
            this.pasteStripMenuItem.Name = "pasteStripMenuItem";
            this.pasteStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.V)));
            this.pasteStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.pasteStripMenuItem.Text = "Paste";
            this.pasteStripMenuItem.Click += new System.EventHandler(this.pasteStripMenuItem3_Click);
            // 
            // selectAllStripMenuItem
            // 
            this.selectAllStripMenuItem.Name = "selectAllStripMenuItem";
            this.selectAllStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.selectAllStripMenuItem.Text = "Select All";
            this.selectAllStripMenuItem.Click += new System.EventHandler(this.selectAllStripMenuItem4_Click);
            // 
            // pasteTextBox
            // 
            this.pasteTextBox.AcceptsReturn = true;
            this.pasteTextBox.AcceptsTab = true;
            this.pasteTextBox.AllowDrop = true;
            this.pasteTextBox.ContextMenuStrip = this.contextMenuStrip;
            this.pasteTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pasteTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pasteTextBox.Location = new System.Drawing.Point(0, 0);
            this.pasteTextBox.Multiline = true;
            this.pasteTextBox.Name = "pasteTextBox";
            this.pasteTextBox.Size = new System.Drawing.Size(284, 261);
            this.pasteTextBox.TabIndex = 0;
            this.pasteTextBox.WordWrap = false;
            this.pasteTextBox.DoubleClick += new System.EventHandler(this.pasteTextBox_DoubleClick);
            // 
            // pasteAndConvertStripMenuItem
            // 
            this.pasteAndConvertStripMenuItem.Name = "pasteAndConvertStripMenuItem";
            this.pasteAndConvertStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteAndConvertStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.pasteAndConvertStripMenuItem.Text = "Paste and Convert";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pasteTextBox);
            this.Name = "Main";
            this.Text = "Convert VsDoc to JsDoc in one Control + C";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PasteTextBox pasteTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem clearStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteAndConvertStripMenuItem;
    }
}