namespace MoveFile
{
    partial class MainForm
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
            this._folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._sourceTextBox = new System.Windows.Forms.TextBox();
            this._goalTextBox = new System.Windows.Forms.TextBox();
            this._sourceButton = new System.Windows.Forms.Button();
            this._goalButton = new System.Windows.Forms.Button();
            this._doButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _folderBrowserDialog
            // 
            this._folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this._sourceTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._goalTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._sourceButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._goalButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this._doButton, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _sourceTextBox
            // 
            this._sourceTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this._sourceTextBox.Location = new System.Drawing.Point(3, 3);
            this._sourceTextBox.Name = "_sourceTextBox";
            this._sourceTextBox.Size = new System.Drawing.Size(192, 22);
            this._sourceTextBox.TabIndex = 0;
            // 
            // _goalTextBox
            // 
            this._goalTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this._goalTextBox.Location = new System.Drawing.Point(3, 89);
            this._goalTextBox.Name = "_goalTextBox";
            this._goalTextBox.Size = new System.Drawing.Size(192, 22);
            this._goalTextBox.TabIndex = 1;
            // 
            // _sourceButton
            // 
            this._sourceButton.Location = new System.Drawing.Point(201, 3);
            this._sourceButton.Name = "_sourceButton";
            this._sourceButton.Size = new System.Drawing.Size(75, 23);
            this._sourceButton.TabIndex = 2;
            this._sourceButton.Text = "source";
            this._sourceButton.UseVisualStyleBackColor = true;
            this._sourceButton.Click += new System.EventHandler(this._sourceButton_Click);
            // 
            // _goalButton
            // 
            this._goalButton.Location = new System.Drawing.Point(201, 89);
            this._goalButton.Name = "_goalButton";
            this._goalButton.Size = new System.Drawing.Size(75, 23);
            this._goalButton.TabIndex = 3;
            this._goalButton.Text = "goal";
            this._goalButton.UseVisualStyleBackColor = true;
            this._goalButton.Click += new System.EventHandler(this._goalButton_Click);
            // 
            // _doButton
            // 
            this._doButton.Location = new System.Drawing.Point(201, 175);
            this._doButton.Name = "_doButton";
            this._doButton.Size = new System.Drawing.Size(75, 23);
            this._doButton.TabIndex = 4;
            this._doButton.Text = "do operate";
            this._doButton.UseVisualStyleBackColor = true;
            this._doButton.Click += new System.EventHandler(this._doButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog _folderBrowserDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox _sourceTextBox;
        private System.Windows.Forms.TextBox _goalTextBox;
        private System.Windows.Forms.Button _sourceButton;
        private System.Windows.Forms.Button _goalButton;
        private System.Windows.Forms.Button _doButton;
    }
}

