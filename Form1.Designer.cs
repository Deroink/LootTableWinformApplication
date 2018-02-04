namespace LootTableApplication
{
    partial class Form1
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
            this.btnRollTheDice = new System.Windows.Forms.Button();
            this.RollResultsDataGrid = new System.Windows.Forms.DataGridView();
            this.IntroductionLabel = new System.Windows.Forms.Label();
            this.InformationButton = new System.Windows.Forms.Button();
            this.LabelRollsLeft = new System.Windows.Forms.Label();
            this.BtnResetRollCount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RollResultsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRollTheDice
            // 
            this.btnRollTheDice.Location = new System.Drawing.Point(355, 115);
            this.btnRollTheDice.Name = "btnRollTheDice";
            this.btnRollTheDice.Size = new System.Drawing.Size(322, 90);
            this.btnRollTheDice.TabIndex = 0;
            this.btnRollTheDice.Text = "Roll the Dice";
            this.btnRollTheDice.UseVisualStyleBackColor = true;
            this.btnRollTheDice.Click += new System.EventHandler(this.btnRollTheDice_Click);
            // 
            // RollResultsDataGrid
            // 
            this.RollResultsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RollResultsDataGrid.Location = new System.Drawing.Point(12, 211);
            this.RollResultsDataGrid.Name = "RollResultsDataGrid";
            this.RollResultsDataGrid.RowTemplate.Height = 24;
            this.RollResultsDataGrid.Size = new System.Drawing.Size(958, 265);
            this.RollResultsDataGrid.TabIndex = 1;
            // 
            // IntroductionLabel
            // 
            this.IntroductionLabel.AutoSize = true;
            this.IntroductionLabel.Location = new System.Drawing.Point(12, 9);
            this.IntroductionLabel.Name = "IntroductionLabel";
            this.IntroductionLabel.Size = new System.Drawing.Size(555, 17);
            this.IntroductionLabel.TabIndex = 2;
            this.IntroductionLabel.Text = "Welcome to the Loot Table Application. Click the button to the right to see how i" +
    "t works.";
            // 
            // InformationButton
            // 
            this.InformationButton.Location = new System.Drawing.Point(573, 9);
            this.InformationButton.Name = "InformationButton";
            this.InformationButton.Size = new System.Drawing.Size(177, 23);
            this.InformationButton.TabIndex = 3;
            this.InformationButton.Text = "About the Program";
            this.InformationButton.UseVisualStyleBackColor = true;
            this.InformationButton.Click += new System.EventHandler(this.InformationButton_Click);
            // 
            // LabelRollsLeft
            // 
            this.LabelRollsLeft.AutoSize = true;
            this.LabelRollsLeft.Location = new System.Drawing.Point(699, 187);
            this.LabelRollsLeft.Name = "LabelRollsLeft";
            this.LabelRollsLeft.Size = new System.Drawing.Size(83, 17);
            this.LabelRollsLeft.TabIndex = 4;
            this.LabelRollsLeft.Text = "Rolls Left: 1";
            // 
            // BtnResetRollCount
            // 
            this.BtnResetRollCount.Location = new System.Drawing.Point(823, 181);
            this.BtnResetRollCount.Name = "BtnResetRollCount";
            this.BtnResetRollCount.Size = new System.Drawing.Size(147, 23);
            this.BtnResetRollCount.TabIndex = 5;
            this.BtnResetRollCount.Text = "Reset Roll Count";
            this.BtnResetRollCount.UseVisualStyleBackColor = true;
            this.BtnResetRollCount.Click += new System.EventHandler(this.BtnResetRollCount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 488);
            this.Controls.Add(this.BtnResetRollCount);
            this.Controls.Add(this.LabelRollsLeft);
            this.Controls.Add(this.InformationButton);
            this.Controls.Add(this.IntroductionLabel);
            this.Controls.Add(this.RollResultsDataGrid);
            this.Controls.Add(this.btnRollTheDice);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RollResultsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRollTheDice;
        private System.Windows.Forms.DataGridView RollResultsDataGrid;
        private System.Windows.Forms.Label IntroductionLabel;
        private System.Windows.Forms.Button InformationButton;
        private System.Windows.Forms.Label LabelRollsLeft;
        private System.Windows.Forms.Button BtnResetRollCount;
    }
}

