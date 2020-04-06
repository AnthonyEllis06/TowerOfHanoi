using System.Windows.Forms;

namespace TowerOfHanoi
{
    partial class TowerOfHanoiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TowerOfHanoiForm));
            this.MoveStatusStrip = new System.Windows.Forms.StatusStrip();
            this.CurrentMoveLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TotalMovesLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TowerHanoiLayout = new System.Windows.Forms.TableLayoutPanel();
            this.InputLayout = new System.Windows.Forms.TableLayoutPanel();
            this.StartButtonLayout = new System.Windows.Forms.TableLayoutPanel();
            this.StartButton = new System.Windows.Forms.Button();
            this.DiskInputGroupBox = new System.Windows.Forms.GroupBox();
            this.TextInputLayout = new System.Windows.Forms.TableLayoutPanel();
            this.NumDisksDirectionLabel = new System.Windows.Forms.Label();
            this.DiskNumInputBox = new System.Windows.Forms.TextBox();
            this.NextMoveButton = new System.Windows.Forms.Button();
            this.CenterTowersLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TowersLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TowerTextBox2 = new System.Windows.Forms.TextBox();
            this.TowerTextBox1 = new System.Windows.Forms.TextBox();
            this.TowerTextBox0 = new System.Windows.Forms.TextBox();
            this.TOHMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.StartToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.NextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.QuitToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.TowerHanoiLayout.SuspendLayout();
            this.InputLayout.SuspendLayout();
            this.StartButtonLayout.SuspendLayout();
            this.DiskInputGroupBox.SuspendLayout();
            this.TextInputLayout.SuspendLayout();
            this.CenterTowersLayout.SuspendLayout();
            this.TowersLayout.SuspendLayout();
            this.TOHMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MoveStatusStrip
            // 
            this.MoveStatusStrip.Location = new System.Drawing.Point(0, 428);
            this.MoveStatusStrip.Name = "MoveStatusStrip";
            this.MoveStatusStrip.Size = new System.Drawing.Size(800, 22);
            this.MoveStatusStrip.TabIndex = 1;
            this.MoveStatusStrip.Text = "statusStrip1";
            // 
            // CurrentMoveLabel
            // 
            this.CurrentMoveLabel.Name = "CurrentMoveLabel";
            this.CurrentMoveLabel.Size = new System.Drawing.Size(83, 17);
            this.CurrentMoveLabel.Text = "CurrentMove: ";
            this.CurrentMoveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalMovesLabel
            // 
            this.TotalMovesLabel.Name = "TotalMovesLabel";
            this.TotalMovesLabel.Size = new System.Drawing.Size(702, 17);
            this.TotalMovesLabel.Spring = true;
            this.TotalMovesLabel.Text = "Total Number Of Moves: ";
            this.TotalMovesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TowerHanoiLayout
            // 
            this.TowerHanoiLayout.ColumnCount = 1;
            this.TowerHanoiLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TowerHanoiLayout.Controls.Add(this.InputLayout, 0, 0);
            this.TowerHanoiLayout.Controls.Add(this.NextMoveButton, 0, 2);
            this.TowerHanoiLayout.Controls.Add(this.CenterTowersLayout, 0, 1);
            this.TowerHanoiLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TowerHanoiLayout.Location = new System.Drawing.Point(0, 24);
            this.TowerHanoiLayout.Name = "TowerHanoiLayout";
            this.TowerHanoiLayout.RowCount = 3;
            this.TowerHanoiLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.TowerHanoiLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.TowerHanoiLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TowerHanoiLayout.Size = new System.Drawing.Size(800, 404);
            this.TowerHanoiLayout.TabIndex = 2;
            // 
            // InputLayout
            // 
            this.InputLayout.ColumnCount = 2;
            this.InputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.InputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.InputLayout.Controls.Add(this.StartButtonLayout, 1, 0);
            this.InputLayout.Controls.Add(this.DiskInputGroupBox, 0, 0);
            this.InputLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputLayout.Location = new System.Drawing.Point(3, 3);
            this.InputLayout.Name = "InputLayout";
            this.InputLayout.RowCount = 1;
            this.InputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.InputLayout.Size = new System.Drawing.Size(794, 54);
            this.InputLayout.TabIndex = 0;
            // 
            // StartButtonLayout
            // 
            this.StartButtonLayout.ColumnCount = 3;
            this.StartButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.StartButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.StartButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.StartButtonLayout.Controls.Add(this.StartButton, 1, 1);
            this.StartButtonLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartButtonLayout.Location = new System.Drawing.Point(638, 3);
            this.StartButtonLayout.Name = "StartButtonLayout";
            this.StartButtonLayout.RowCount = 3;
            this.StartButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.StartButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.StartButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.StartButtonLayout.Size = new System.Drawing.Size(153, 48);
            this.StartButtonLayout.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartButton.Location = new System.Drawing.Point(33, 10);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(85, 27);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // DiskInputGroupBox
            // 
            this.DiskInputGroupBox.Controls.Add(this.TextInputLayout);
            this.DiskInputGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiskInputGroupBox.Location = new System.Drawing.Point(3, 3);
            this.DiskInputGroupBox.Name = "DiskInputGroupBox";
            this.DiskInputGroupBox.Size = new System.Drawing.Size(629, 48);
            this.DiskInputGroupBox.TabIndex = 1;
            this.DiskInputGroupBox.TabStop = false;
            this.DiskInputGroupBox.Text = "Please Enter the Number of Disks:";
            // 
            // TextInputLayout
            // 
            this.TextInputLayout.ColumnCount = 2;
            this.TextInputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TextInputLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TextInputLayout.Controls.Add(this.NumDisksDirectionLabel, 0, 0);
            this.TextInputLayout.Controls.Add(this.DiskNumInputBox, 1, 0);
            this.TextInputLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextInputLayout.Location = new System.Drawing.Point(3, 16);
            this.TextInputLayout.Name = "TextInputLayout";
            this.TextInputLayout.RowCount = 1;
            this.TextInputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TextInputLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.TextInputLayout.Size = new System.Drawing.Size(623, 29);
            this.TextInputLayout.TabIndex = 0;
            // 
            // NumDisksDirectionLabel
            // 
            this.NumDisksDirectionLabel.AutoSize = true;
            this.NumDisksDirectionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumDisksDirectionLabel.Location = new System.Drawing.Point(3, 0);
            this.NumDisksDirectionLabel.Name = "NumDisksDirectionLabel";
            this.NumDisksDirectionLabel.Size = new System.Drawing.Size(180, 29);
            this.NumDisksDirectionLabel.TabIndex = 0;
            this.NumDisksDirectionLabel.Text = "Number of Disks: ";
            this.NumDisksDirectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DiskNumInputBox
            // 
            this.DiskNumInputBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiskNumInputBox.Location = new System.Drawing.Point(189, 3);
            this.DiskNumInputBox.Name = "DiskNumInputBox";
            this.DiskNumInputBox.Size = new System.Drawing.Size(431, 20);
            this.DiskNumInputBox.TabIndex = 1;
            this.DiskNumInputBox.TextChanged += new System.EventHandler(this.DiskNumInputBox_TextChanged);
            // 
            // NextMoveButton
            // 
            this.NextMoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NextMoveButton.Enabled = false;
            this.NextMoveButton.Location = new System.Drawing.Point(3, 366);
            this.NextMoveButton.Name = "NextMoveButton";
            this.NextMoveButton.Size = new System.Drawing.Size(794, 35);
            this.NextMoveButton.TabIndex = 1;
            this.NextMoveButton.Text = "Next Move";
            this.NextMoveButton.UseVisualStyleBackColor = true;
            this.NextMoveButton.Click += new System.EventHandler(this.NextMoveButton_Click);
            // 
            // CenterTowersLayout
            // 
            this.CenterTowersLayout.ColumnCount = 3;
            this.CenterTowersLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.CenterTowersLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.CenterTowersLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.CenterTowersLayout.Controls.Add(this.TowersLayout, 1, 0);
            this.CenterTowersLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterTowersLayout.Location = new System.Drawing.Point(3, 63);
            this.CenterTowersLayout.Name = "CenterTowersLayout";
            this.CenterTowersLayout.RowCount = 1;
            this.CenterTowersLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CenterTowersLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 297F));
            this.CenterTowersLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 297F));
            this.CenterTowersLayout.Size = new System.Drawing.Size(794, 297);
            this.CenterTowersLayout.TabIndex = 2;
            // 
            // TowersLayout
            // 
            this.TowersLayout.ColumnCount = 5;
            this.TowersLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TowersLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TowersLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TowersLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TowersLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TowersLayout.Controls.Add(this.TowerTextBox2, 4, 0);
            this.TowersLayout.Controls.Add(this.TowerTextBox1, 2, 0);
            this.TowersLayout.Controls.Add(this.TowerTextBox0, 0, 0);
            this.TowersLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TowersLayout.Location = new System.Drawing.Point(82, 3);
            this.TowersLayout.Name = "TowersLayout";
            this.TowersLayout.RowCount = 1;
            this.TowersLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TowersLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 291F));
            this.TowersLayout.Size = new System.Drawing.Size(629, 291);
            this.TowersLayout.TabIndex = 0;
            // 
            // TowerTextBox2
            // 
            this.TowerTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TowerTextBox2.Location = new System.Drawing.Point(441, 3);
            this.TowerTextBox2.Multiline = true;
            this.TowerTextBox2.Name = "TowerTextBox2";
            this.TowerTextBox2.Size = new System.Drawing.Size(185, 285);
            this.TowerTextBox2.TabIndex = 2;
            this.TowerTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TowerTextBox1
            // 
            this.TowerTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TowerTextBox1.Location = new System.Drawing.Point(222, 3);
            this.TowerTextBox1.Multiline = true;
            this.TowerTextBox1.Name = "TowerTextBox1";
            this.TowerTextBox1.Size = new System.Drawing.Size(182, 285);
            this.TowerTextBox1.TabIndex = 1;
            this.TowerTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TowerTextBox0
            // 
            this.TowerTextBox0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TowerTextBox0.Location = new System.Drawing.Point(3, 3);
            this.TowerTextBox0.Multiline = true;
            this.TowerTextBox0.Name = "TowerTextBox0";
            this.TowerTextBox0.Size = new System.Drawing.Size(182, 285);
            this.TowerTextBox0.TabIndex = 0;
            this.TowerTextBox0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TOHMenuStrip
            // 
            this.TOHMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem3,
            this.HelpToolStripMenuItem3});
            this.TOHMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TOHMenuStrip.Name = "TOHMenuStrip";
            this.TOHMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.TOHMenuStrip.TabIndex = 3;
            this.TOHMenuStrip.Text = "menuStrip2";
            // 
            // FileToolStripMenuItem3
            // 
            this.FileToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartToolStripMenuItem4,
            this.NextToolStripMenuItem,
            this.ResetToolStripMenuItem5,
            this.QuitToolStripMenuItem6});
            this.FileToolStripMenuItem3.Name = "FileToolStripMenuItem3";
            this.FileToolStripMenuItem3.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem3.Text = "File";
            // 
            // HelpToolStripMenuItem3
            // 
            this.HelpToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem4});
            this.HelpToolStripMenuItem3.Name = "HelpToolStripMenuItem3";
            this.HelpToolStripMenuItem3.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem3.Text = "Help";
            // 
            // AboutToolStripMenuItem4
            // 
            this.AboutToolStripMenuItem4.Name = "AboutToolStripMenuItem4";
            this.AboutToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.AboutToolStripMenuItem4.Text = "About";
            this.AboutToolStripMenuItem4.Click += new System.EventHandler(this.AboutToolStripMenuItem4_Click);
            // 
            // StartToolStripMenuItem4
            // 
            this.StartToolStripMenuItem4.Name = "StartToolStripMenuItem4";
            this.StartToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.StartToolStripMenuItem4.Text = "Start";
            this.StartToolStripMenuItem4.Click += new System.EventHandler(this.StartToolStripMenuItem4_Click);
            // 
            // NextToolStripMenuItem
            // 
            this.NextToolStripMenuItem.Name = "NextToolStripMenuItem";
            this.NextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NextToolStripMenuItem.Text = "Next Move";
            this.NextToolStripMenuItem.Click += new System.EventHandler(this.NextToolStripMenuItem_Click);
            // 
            // ResetToolStripMenuItem5
            // 
            this.ResetToolStripMenuItem5.Name = "ResetToolStripMenuItem5";
            this.ResetToolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.ResetToolStripMenuItem5.Text = "Reset";
            this.ResetToolStripMenuItem5.Click += new System.EventHandler(this.ResetToolStripMenuItem5_Click);
            // 
            // QuitToolStripMenuItem6
            // 
            this.QuitToolStripMenuItem6.Name = "QuitToolStripMenuItem6";
            this.QuitToolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            this.QuitToolStripMenuItem6.Text = "Quit";
            this.QuitToolStripMenuItem6.Click += new System.EventHandler(this.QuitToolStripMenuItem6_Click);
            // 
            // TowerOfHanoiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TowerHanoiLayout);
            this.Controls.Add(this.MoveStatusStrip);
            this.Controls.Add(this.TOHMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.TOHMenuStrip;
            this.Name = "TowerOfHanoiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tower Of Hanoi";
            this.TowerHanoiLayout.ResumeLayout(false);
            this.InputLayout.ResumeLayout(false);
            this.StartButtonLayout.ResumeLayout(false);
            this.DiskInputGroupBox.ResumeLayout(false);
            this.TextInputLayout.ResumeLayout(false);
            this.TextInputLayout.PerformLayout();
            this.CenterTowersLayout.ResumeLayout(false);
            this.TowersLayout.ResumeLayout(false);
            this.TowersLayout.PerformLayout();
            this.TOHMenuStrip.ResumeLayout(false);
            this.TOHMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextMoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip MoveStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel CurrentMoveLabel;
        private System.Windows.Forms.ToolStripStatusLabel TotalMovesLabel;
        private System.Windows.Forms.TableLayoutPanel TowerHanoiLayout;
        private System.Windows.Forms.TableLayoutPanel InputLayout;
        private System.Windows.Forms.TableLayoutPanel StartButtonLayout;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.GroupBox DiskInputGroupBox;
        private System.Windows.Forms.TableLayoutPanel TextInputLayout;
        private System.Windows.Forms.Label NumDisksDirectionLabel;
        private System.Windows.Forms.TextBox DiskNumInputBox;
        private System.Windows.Forms.Button NextMoveButton;
        private System.Windows.Forms.TableLayoutPanel CenterTowersLayout;
        private System.Windows.Forms.TableLayoutPanel TowersLayout;
        private System.Windows.Forms.TextBox TowerTextBox2;
        private System.Windows.Forms.TextBox TowerTextBox1;
        private System.Windows.Forms.TextBox TowerTextBox0;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private MenuStrip TOHMenuStrip;
        private ToolStripMenuItem FileToolStripMenuItem3;
        private ToolStripMenuItem StartToolStripMenuItem4;
        private ToolStripMenuItem NextToolStripMenuItem;
        private ToolStripMenuItem ResetToolStripMenuItem5;
        private ToolStripMenuItem QuitToolStripMenuItem6;
        private ToolStripMenuItem HelpToolStripMenuItem3;
        private ToolStripMenuItem AboutToolStripMenuItem4;
    }
}

