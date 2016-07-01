namespace FM2
{
    partial class fmPlayerEvalForm
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importCsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripFilePath = new System.Windows.Forms.ToolStripStatusLabel();
            this.playerGrid = new System.Windows.Forms.DataGridView();
            this.clearData = new System.Windows.Forms.Button();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerEvalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DebugPanel = new System.Windows.Forms.Panel();
            this.DebugPlayerGridLabel = new System.Windows.Forms.Label();
            this.weightsGrid = new System.Windows.Forms.DataGridView();
            this.clearWeightData = new System.Windows.Forms.Button();
            this.DebugWeightsGridLabel = new System.Windows.Forms.Label();
            this.mainMenuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerGrid)).BeginInit();
            this.DebugPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.playerEvalsToolStripMenuItem,
            this.weightsToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(875, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.openToolStripMenuItem,
            this.importCsvToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // importCsvToolStripMenuItem
            // 
            this.importCsvToolStripMenuItem.Name = "importCsvToolStripMenuItem";
            this.importCsvToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importCsvToolStripMenuItem.Text = "Import Csv";
            this.importCsvToolStripMenuItem.Click += new System.EventHandler(this.importCsvToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFilePath});
            this.statusStrip1.Location = new System.Drawing.Point(0, 488);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(875, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripFilePath
            // 
            this.toolStripFilePath.Name = "toolStripFilePath";
            this.toolStripFilePath.Size = new System.Drawing.Size(77, 17);
            this.toolStripFilePath.Text = "Choose a File";
            // 
            // playerGrid
            // 
            this.playerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playerGrid.Location = new System.Drawing.Point(12, 34);
            this.playerGrid.Name = "playerGrid";
            this.playerGrid.Size = new System.Drawing.Size(328, 379);
            this.playerGrid.TabIndex = 2;
            // 
            // clearData
            // 
            this.clearData.Location = new System.Drawing.Point(265, 8);
            this.clearData.Name = "clearData";
            this.clearData.Size = new System.Drawing.Size(75, 23);
            this.clearData.TabIndex = 3;
            this.clearData.Text = "Reset Data";
            this.clearData.UseVisualStyleBackColor = true;
            this.clearData.Click += new System.EventHandler(this.clearData_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // playerEvalsToolStripMenuItem
            // 
            this.playerEvalsToolStripMenuItem.Name = "playerEvalsToolStripMenuItem";
            this.playerEvalsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.playerEvalsToolStripMenuItem.Text = "Player Evals";
            // 
            // weightsToolStripMenuItem
            // 
            this.weightsToolStripMenuItem.Name = "weightsToolStripMenuItem";
            this.weightsToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.weightsToolStripMenuItem.Text = "Weights";
            // 
            // DebugPanel
            // 
            this.DebugPanel.Controls.Add(this.DebugWeightsGridLabel);
            this.DebugPanel.Controls.Add(this.clearWeightData);
            this.DebugPanel.Controls.Add(this.weightsGrid);
            this.DebugPanel.Controls.Add(this.DebugPlayerGridLabel);
            this.DebugPanel.Controls.Add(this.playerGrid);
            this.DebugPanel.Controls.Add(this.clearData);
            this.DebugPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DebugPanel.Location = new System.Drawing.Point(0, 24);
            this.DebugPanel.Name = "DebugPanel";
            this.DebugPanel.Size = new System.Drawing.Size(875, 464);
            this.DebugPanel.TabIndex = 4;
            // 
            // DebugPlayerGridLabel
            // 
            this.DebugPlayerGridLabel.AutoSize = true;
            this.DebugPlayerGridLabel.Location = new System.Drawing.Point(12, 18);
            this.DebugPlayerGridLabel.Name = "DebugPlayerGridLabel";
            this.DebugPlayerGridLabel.Size = new System.Drawing.Size(41, 13);
            this.DebugPlayerGridLabel.TabIndex = 4;
            this.DebugPlayerGridLabel.Text = "Players";
            this.DebugPlayerGridLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // weightsGrid
            // 
            this.weightsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weightsGrid.Location = new System.Drawing.Point(346, 34);
            this.weightsGrid.Name = "weightsGrid";
            this.weightsGrid.Size = new System.Drawing.Size(316, 379);
            this.weightsGrid.TabIndex = 5;
            // 
            // clearWeightData
            // 
            this.clearWeightData.Location = new System.Drawing.Point(587, 8);
            this.clearWeightData.Name = "clearWeightData";
            this.clearWeightData.Size = new System.Drawing.Size(75, 23);
            this.clearWeightData.TabIndex = 6;
            this.clearWeightData.Text = "Reset Data";
            this.clearWeightData.UseVisualStyleBackColor = true;
            this.clearWeightData.Click += new System.EventHandler(this.clearWeightData_Click);
            // 
            // DebugWeightsGridLabel
            // 
            this.DebugWeightsGridLabel.AutoSize = true;
            this.DebugWeightsGridLabel.Location = new System.Drawing.Point(346, 18);
            this.DebugWeightsGridLabel.Name = "DebugWeightsGridLabel";
            this.DebugWeightsGridLabel.Size = new System.Drawing.Size(46, 13);
            this.DebugWeightsGridLabel.TabIndex = 7;
            this.DebugWeightsGridLabel.Text = "Weights";
            // 
            // fmPlayerEvalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 510);
            this.Controls.Add(this.DebugPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "fmPlayerEvalForm";
            this.Text = "FM Player Evaluator";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerGrid)).EndInit();
            this.DebugPanel.ResumeLayout(false);
            this.DebugPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importCsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripFilePath;
        private System.Windows.Forms.DataGridView playerGrid;
        private System.Windows.Forms.Button clearData;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerEvalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weightsToolStripMenuItem;
        private System.Windows.Forms.Panel DebugPanel;
        private System.Windows.Forms.Label DebugPlayerGridLabel;
        private System.Windows.Forms.Button clearWeightData;
        private System.Windows.Forms.DataGridView weightsGrid;
        private System.Windows.Forms.Label DebugWeightsGridLabel;
    }
}

