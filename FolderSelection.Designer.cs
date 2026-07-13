using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CONBIT.CreateProjectFolder
{
    partial class FolderSelection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public List<FolderName> SelectedFolders;
        
        //Create archive booleans for sub checkboxes
        private bool _CKB4_1Arch;
        private bool _CKB4_2Arch;
        private bool _CKB4_3Arch;
        private bool _CKB5_1Arch;
        private bool _CKB5_2Arch;
        private bool _CKB7_1Arch;
        private bool _CKB7_2Arch;
        private bool _CKDLoopPrevention;

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
            this.CKB1 = new System.Windows.Forms.CheckBox();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.CKB2 = new System.Windows.Forms.CheckBox();
            this.TB3 = new System.Windows.Forms.TextBox();
            this.CKB3 = new System.Windows.Forms.CheckBox();
            this.TB4 = new System.Windows.Forms.TextBox();
            this.CKB4 = new System.Windows.Forms.CheckBox();
            this.TB4_1 = new System.Windows.Forms.TextBox();
            this.CKB4_1 = new System.Windows.Forms.CheckBox();
            this.TB4_2 = new System.Windows.Forms.TextBox();
            this.CKB4_2 = new System.Windows.Forms.CheckBox();
            this.TB4_3 = new System.Windows.Forms.TextBox();
            this.CKB4_3 = new System.Windows.Forms.CheckBox();
            this.TB5 = new System.Windows.Forms.TextBox();
            this.CKB5 = new System.Windows.Forms.CheckBox();
            this.TB5_1 = new System.Windows.Forms.TextBox();
            this.CKB5_1 = new System.Windows.Forms.CheckBox();
            this.TB5_2 = new System.Windows.Forms.TextBox();
            this.CKB5_2 = new System.Windows.Forms.CheckBox();
            this.TB6 = new System.Windows.Forms.TextBox();
            this.CKB6 = new System.Windows.Forms.CheckBox();
            this.TB7 = new System.Windows.Forms.TextBox();
            this.CKB7 = new System.Windows.Forms.CheckBox();
            this.TB7_1 = new System.Windows.Forms.TextBox();
            this.CKB7_1 = new System.Windows.Forms.CheckBox();
            this.TB7_2 = new System.Windows.Forms.TextBox();
            this.CKB7_2 = new System.Windows.Forms.CheckBox();
            this.TB8 = new System.Windows.Forms.TextBox();
            this.CKB8 = new System.Windows.Forms.CheckBox();
            this.TB9 = new System.Windows.Forms.TextBox();
            this.CKB9 = new System.Windows.Forms.CheckBox();
            this.TB10 = new System.Windows.Forms.TextBox();
            this.CKB10 = new System.Windows.Forms.CheckBox();
            this.TB11 = new System.Windows.Forms.TextBox();
            this.CKB11 = new System.Windows.Forms.CheckBox();
            this.TB12 = new System.Windows.Forms.TextBox();
            this.CKB12 = new System.Windows.Forms.CheckBox();
            this.TB13 = new System.Windows.Forms.TextBox();
            this.CKB13 = new System.Windows.Forms.CheckBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CKB1
            // 
            this.CKB1.AutoSize = true;
            this.CKB1.Checked = true;
            this.CKB1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB1.Location = new System.Drawing.Point(12, 12);
            this.CKB1.Name = "CKB1";
            this.CKB1.Size = new System.Drawing.Size(15, 14);
            this.CKB1.TabIndex = 1;
            this.CKB1.UseVisualStyleBackColor = true;
            // 
            // TB1
            // 
            this.TB1.BackColor = System.Drawing.SystemColors.Control;
            this.TB1.Location = new System.Drawing.Point(33, 9);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(755, 20);
            this.TB1.TabIndex = 2;
            // 
            // TB2
            // 
            this.TB2.BackColor = System.Drawing.SystemColors.Control;
            this.TB2.Location = new System.Drawing.Point(33, 35);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(755, 20);
            this.TB2.TabIndex = 4;
            // 
            // CKB2
            // 
            this.CKB2.AutoSize = true;
            this.CKB2.Checked = true;
            this.CKB2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB2.Location = new System.Drawing.Point(12, 38);
            this.CKB2.Name = "CKB2";
            this.CKB2.Size = new System.Drawing.Size(15, 14);
            this.CKB2.TabIndex = 3;
            this.CKB2.UseVisualStyleBackColor = true;
            // 
            // TB3
            // 
            this.TB3.BackColor = System.Drawing.SystemColors.Control;
            this.TB3.Location = new System.Drawing.Point(33, 61);
            this.TB3.Name = "TB3";
            this.TB3.Size = new System.Drawing.Size(755, 20);
            this.TB3.TabIndex = 6;
            // 
            // CKB3
            // 
            this.CKB3.AutoSize = true;
            this.CKB3.Checked = true;
            this.CKB3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB3.Location = new System.Drawing.Point(12, 64);
            this.CKB3.Name = "CKB3";
            this.CKB3.Size = new System.Drawing.Size(15, 14);
            this.CKB3.TabIndex = 5;
            this.CKB3.UseVisualStyleBackColor = true;
            // 
            // TB4
            // 
            this.TB4.BackColor = System.Drawing.SystemColors.Control;
            this.TB4.Location = new System.Drawing.Point(33, 87);
            this.TB4.Name = "TB4";
            this.TB4.Size = new System.Drawing.Size(755, 20);
            this.TB4.TabIndex = 8;
            // 
            // CKB4
            // 
            this.CKB4.AutoSize = true;
            this.CKB4.Checked = true;
            this.CKB4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB4.Location = new System.Drawing.Point(12, 90);
            this.CKB4.Name = "CKB4";
            this.CKB4.Size = new System.Drawing.Size(15, 14);
            this.CKB4.TabIndex = 7;
            this.CKB4.UseVisualStyleBackColor = true;
            // 
            // TB4_1
            // 
            this.TB4_1.BackColor = System.Drawing.SystemColors.Control;
            this.TB4_1.Location = new System.Drawing.Point(56, 113);
            this.TB4_1.Name = "TB4_1";
            this.TB4_1.Size = new System.Drawing.Size(732, 20);
            this.TB4_1.TabIndex = 10;
            // 
            // CKB4_1
            // 
            this.CKB4_1.AutoSize = true;
            this.CKB4_1.Checked = true;
            this.CKB4_1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB4_1.Location = new System.Drawing.Point(35, 116);
            this.CKB4_1.Name = "CKB4_1";
            this.CKB4_1.Size = new System.Drawing.Size(15, 14);
            this.CKB4_1.TabIndex = 9;
            this.CKB4_1.UseVisualStyleBackColor = true;
            // 
            // TB4_2
            // 
            this.TB4_2.BackColor = System.Drawing.SystemColors.Control;
            this.TB4_2.Location = new System.Drawing.Point(56, 139);
            this.TB4_2.Name = "TB4_2";
            this.TB4_2.Size = new System.Drawing.Size(732, 20);
            this.TB4_2.TabIndex = 12;
            // 
            // CKB4_2
            // 
            this.CKB4_2.AutoSize = true;
            this.CKB4_2.Checked = true;
            this.CKB4_2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB4_2.Location = new System.Drawing.Point(35, 142);
            this.CKB4_2.Name = "CKB4_2";
            this.CKB4_2.Size = new System.Drawing.Size(15, 14);
            this.CKB4_2.TabIndex = 11;
            this.CKB4_2.UseVisualStyleBackColor = true;
            // 
            // TB4_3
            // 
            this.TB4_3.BackColor = System.Drawing.SystemColors.Control;
            this.TB4_3.Location = new System.Drawing.Point(56, 165);
            this.TB4_3.Name = "TB4_3";
            this.TB4_3.Size = new System.Drawing.Size(732, 20);
            this.TB4_3.TabIndex = 14;
            // 
            // CKB4_3
            // 
            this.CKB4_3.AutoSize = true;
            this.CKB4_3.Checked = true;
            this.CKB4_3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB4_3.Location = new System.Drawing.Point(35, 168);
            this.CKB4_3.Name = "CKB4_3";
            this.CKB4_3.Size = new System.Drawing.Size(15, 14);
            this.CKB4_3.TabIndex = 13;
            this.CKB4_3.UseVisualStyleBackColor = true;
            // 
            // TB5
            // 
            this.TB5.BackColor = System.Drawing.SystemColors.Control;
            this.TB5.Location = new System.Drawing.Point(33, 191);
            this.TB5.Name = "TB5";
            this.TB5.Size = new System.Drawing.Size(755, 20);
            this.TB5.TabIndex = 16;
            // 
            // CKB5
            // 
            this.CKB5.AutoSize = true;
            this.CKB5.Checked = true;
            this.CKB5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB5.Location = new System.Drawing.Point(12, 194);
            this.CKB5.Name = "CKB5";
            this.CKB5.Size = new System.Drawing.Size(15, 14);
            this.CKB5.TabIndex = 15;
            this.CKB5.UseVisualStyleBackColor = true;
            // 
            // TB5_1
            // 
            this.TB5_1.BackColor = System.Drawing.SystemColors.Control;
            this.TB5_1.Location = new System.Drawing.Point(56, 217);
            this.TB5_1.Name = "TB5_1";
            this.TB5_1.Size = new System.Drawing.Size(732, 20);
            this.TB5_1.TabIndex = 18;
            // 
            // CKB5_1
            // 
            this.CKB5_1.AutoSize = true;
            this.CKB5_1.Checked = true;
            this.CKB5_1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB5_1.Location = new System.Drawing.Point(35, 220);
            this.CKB5_1.Name = "CKB5_1";
            this.CKB5_1.Size = new System.Drawing.Size(15, 14);
            this.CKB5_1.TabIndex = 17;
            this.CKB5_1.UseVisualStyleBackColor = true;
            // 
            // TB5_2
            // 
            this.TB5_2.BackColor = System.Drawing.SystemColors.Control;
            this.TB5_2.Location = new System.Drawing.Point(56, 243);
            this.TB5_2.Name = "TB5_2";
            this.TB5_2.Size = new System.Drawing.Size(732, 20);
            this.TB5_2.TabIndex = 20;
            // 
            // CKB5_2
            // 
            this.CKB5_2.AutoSize = true;
            this.CKB5_2.Checked = true;
            this.CKB5_2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB5_2.Location = new System.Drawing.Point(35, 246);
            this.CKB5_2.Name = "CKB5_2";
            this.CKB5_2.Size = new System.Drawing.Size(15, 14);
            this.CKB5_2.TabIndex = 19;
            this.CKB5_2.UseVisualStyleBackColor = true;
            // 
            // TB6
            // 
            this.TB6.BackColor = System.Drawing.SystemColors.Control;
            this.TB6.Location = new System.Drawing.Point(33, 269);
            this.TB6.Name = "TB6";
            this.TB6.Size = new System.Drawing.Size(755, 20);
            this.TB6.TabIndex = 22;
            // 
            // CKB6
            // 
            this.CKB6.AutoSize = true;
            this.CKB6.Checked = true;
            this.CKB6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB6.Location = new System.Drawing.Point(12, 272);
            this.CKB6.Name = "CKB6";
            this.CKB6.Size = new System.Drawing.Size(15, 14);
            this.CKB6.TabIndex = 21;
            this.CKB6.UseVisualStyleBackColor = true;
            // 
            // TB7
            // 
            this.TB7.BackColor = System.Drawing.SystemColors.Control;
            this.TB7.Location = new System.Drawing.Point(33, 295);
            this.TB7.Name = "TB7";
            this.TB7.Size = new System.Drawing.Size(755, 20);
            this.TB7.TabIndex = 24;
            // 
            // CKB7
            // 
            this.CKB7.AutoSize = true;
            this.CKB7.Checked = true;
            this.CKB7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB7.Location = new System.Drawing.Point(12, 298);
            this.CKB7.Name = "CKB7";
            this.CKB7.Size = new System.Drawing.Size(15, 14);
            this.CKB7.TabIndex = 23;
            this.CKB7.UseVisualStyleBackColor = true;
            // 
            // TB7_1
            // 
            this.TB7_1.BackColor = System.Drawing.SystemColors.Control;
            this.TB7_1.Location = new System.Drawing.Point(56, 321);
            this.TB7_1.Name = "TB7_1";
            this.TB7_1.Size = new System.Drawing.Size(732, 20);
            this.TB7_1.TabIndex = 26;
            // 
            // CKB7_1
            // 
            this.CKB7_1.AutoSize = true;
            this.CKB7_1.Checked = true;
            this.CKB7_1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB7_1.Location = new System.Drawing.Point(35, 324);
            this.CKB7_1.Name = "CKB7_1";
            this.CKB7_1.Size = new System.Drawing.Size(15, 14);
            this.CKB7_1.TabIndex = 25;
            this.CKB7_1.UseVisualStyleBackColor = true;
            // 
            // TB7_2
            // 
            this.TB7_2.BackColor = System.Drawing.SystemColors.Control;
            this.TB7_2.Location = new System.Drawing.Point(56, 347);
            this.TB7_2.Name = "TB7_2";
            this.TB7_2.Size = new System.Drawing.Size(732, 20);
            this.TB7_2.TabIndex = 28;
            // 
            // CKB7_2
            // 
            this.CKB7_2.AutoSize = true;
            this.CKB7_2.Checked = true;
            this.CKB7_2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB7_2.Location = new System.Drawing.Point(35, 350);
            this.CKB7_2.Name = "CKB7_2";
            this.CKB7_2.Size = new System.Drawing.Size(15, 14);
            this.CKB7_2.TabIndex = 27;
            this.CKB7_2.UseVisualStyleBackColor = true;
            // 
            // TB8
            // 
            this.TB8.BackColor = System.Drawing.SystemColors.Control;
            this.TB8.Location = new System.Drawing.Point(33, 373);
            this.TB8.Name = "TB8";
            this.TB8.Size = new System.Drawing.Size(755, 20);
            this.TB8.TabIndex = 30;
            // 
            // CKB8
            // 
            this.CKB8.AutoSize = true;
            this.CKB8.Checked = true;
            this.CKB8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB8.Location = new System.Drawing.Point(12, 376);
            this.CKB8.Name = "CKB8";
            this.CKB8.Size = new System.Drawing.Size(15, 14);
            this.CKB8.TabIndex = 29;
            this.CKB8.UseVisualStyleBackColor = true;
            // 
            // TB9
            // 
            this.TB9.BackColor = System.Drawing.SystemColors.Control;
            this.TB9.Location = new System.Drawing.Point(33, 399);
            this.TB9.Name = "TB9";
            this.TB9.Size = new System.Drawing.Size(755, 20);
            this.TB9.TabIndex = 32;
            // 
            // CKB9
            // 
            this.CKB9.AutoSize = true;
            this.CKB9.Checked = true;
            this.CKB9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB9.Location = new System.Drawing.Point(12, 402);
            this.CKB9.Name = "CKB9";
            this.CKB9.Size = new System.Drawing.Size(15, 14);
            this.CKB9.TabIndex = 31;
            this.CKB9.UseVisualStyleBackColor = true;
            // 
            // TB10
            // 
            this.TB10.BackColor = System.Drawing.SystemColors.Control;
            this.TB10.Location = new System.Drawing.Point(33, 425);
            this.TB10.Name = "TB10";
            this.TB10.Size = new System.Drawing.Size(755, 20);
            this.TB10.TabIndex = 34;
            // 
            // CKB10
            // 
            this.CKB10.AutoSize = true;
            this.CKB10.Checked = true;
            this.CKB10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB10.Location = new System.Drawing.Point(12, 428);
            this.CKB10.Name = "CKB10";
            this.CKB10.Size = new System.Drawing.Size(15, 14);
            this.CKB10.TabIndex = 33;
            this.CKB10.UseVisualStyleBackColor = true;
            // 
            // TB11
            // 
            this.TB11.BackColor = System.Drawing.SystemColors.Control;
            this.TB11.Location = new System.Drawing.Point(33, 451);
            this.TB11.Name = "TB11";
            this.TB11.Size = new System.Drawing.Size(755, 20);
            this.TB11.TabIndex = 36;
            // 
            // CKB11
            // 
            this.CKB11.AutoSize = true;
            this.CKB11.Checked = true;
            this.CKB11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB11.Location = new System.Drawing.Point(12, 454);
            this.CKB11.Name = "CKB11";
            this.CKB11.Size = new System.Drawing.Size(15, 14);
            this.CKB11.TabIndex = 35;
            this.CKB11.UseVisualStyleBackColor = true;
            // 
            // TB12
            // 
            this.TB12.BackColor = System.Drawing.SystemColors.Control;
            this.TB12.Location = new System.Drawing.Point(33, 477);
            this.TB12.Name = "TB12";
            this.TB12.Size = new System.Drawing.Size(755, 20);
            this.TB12.TabIndex = 38;
            // 
            // CKB12
            // 
            this.CKB12.AutoSize = true;
            this.CKB12.Checked = true;
            this.CKB12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB12.Location = new System.Drawing.Point(12, 480);
            this.CKB12.Name = "CKB12";
            this.CKB12.Size = new System.Drawing.Size(15, 14);
            this.CKB12.TabIndex = 37;
            this.CKB12.UseVisualStyleBackColor = true;
            // 
            // TB13
            // 
            this.TB13.BackColor = System.Drawing.SystemColors.Control;
            this.TB13.Location = new System.Drawing.Point(33, 503);
            this.TB13.Name = "TB13";
            this.TB13.Size = new System.Drawing.Size(755, 20);
            this.TB13.TabIndex = 40;
            // 
            // CKB13
            // 
            this.CKB13.AutoSize = true;
            this.CKB13.Checked = true;
            this.CKB13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB13.Location = new System.Drawing.Point(12, 506);
            this.CKB13.Name = "CKB13";
            this.CKB13.Size = new System.Drawing.Size(15, 14);
            this.CKB13.TabIndex = 39;
            this.CKB13.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(713, 529);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 41;
            this.OKButton.Text = "APPLY";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            //Functionality of checkboxes
            //
            this.CKB4.CheckedChanged += (this.CheckedChanged);
            this.CKB4_1.CheckedChanged += (this.CheckedChanged);
            this.CKB4_2.CheckedChanged += (this.CheckedChanged);
            this.CKB4_3.CheckedChanged += (this.CheckedChanged);
            this.CKB5.CheckedChanged += (this.CheckedChanged);
            this.CKB5_1.CheckedChanged += (this.CheckedChanged);
            this.CKB5_2.CheckedChanged += (this.CheckedChanged);
            this.CKB7.CheckedChanged += (this.CheckedChanged);
            this.CKB7_1.CheckedChanged += (this.CheckedChanged);
            this.CKB7_2.CheckedChanged += (this.CheckedChanged);
            //
            // FolderSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.TB13);
            this.Controls.Add(this.CKB13);
            this.Controls.Add(this.TB12);
            this.Controls.Add(this.CKB12);
            this.Controls.Add(this.TB11);
            this.Controls.Add(this.CKB11);
            this.Controls.Add(this.TB10);
            this.Controls.Add(this.CKB10);
            this.Controls.Add(this.TB9);
            this.Controls.Add(this.CKB9);
            this.Controls.Add(this.TB8);
            this.Controls.Add(this.CKB8);
            this.Controls.Add(this.TB7_2);
            this.Controls.Add(this.CKB7_2);
            this.Controls.Add(this.TB7_1);
            this.Controls.Add(this.CKB7_1);
            this.Controls.Add(this.TB7);
            this.Controls.Add(this.CKB7);
            this.Controls.Add(this.TB6);
            this.Controls.Add(this.CKB6);
            this.Controls.Add(this.TB5_2);
            this.Controls.Add(this.CKB5_2);
            this.Controls.Add(this.TB5_1);
            this.Controls.Add(this.CKB5_1);
            this.Controls.Add(this.TB5);
            this.Controls.Add(this.CKB5);
            this.Controls.Add(this.TB4_3);
            this.Controls.Add(this.CKB4_3);
            this.Controls.Add(this.TB4_2);
            this.Controls.Add(this.CKB4_2);
            this.Controls.Add(this.TB4_1);
            this.Controls.Add(this.CKB4_1);
            this.Controls.Add(this.TB4);
            this.Controls.Add(this.CKB4);
            this.Controls.Add(this.TB3);
            this.Controls.Add(this.CKB3);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.CKB2);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.CKB1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FolderSelection";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select standard folders to add";
            this.ResumeLayout(false);
            this.PerformLayout();

            //Set default archived values to true as all checkboxes start as true
            _CKB4_1Arch = true;
            _CKB4_2Arch = true;
            _CKB4_3Arch = true;
            _CKB5_1Arch = true;
            _CKB5_2Arch = true;
            _CKB7_1Arch = true;
            _CKB7_2Arch = true;
            _CKDLoopPrevention = false;
        }

        #endregion

        public void SetDefaultNames(string ProjNum)
        {
            //Set default subfolders with names
            TB1.Text = string.Format("{0}-00_Layouts", ProjNum);
            TB2.Text = string.Format("{0}-01_Platform", ProjNum);
            TB3.Text = string.Format("{0}-02_Lifted objects", ProjNum);
            TB4.Text = string.Format("{0}-03_PLE", ProjNum);
            TB4_1.Text = string.Format("{0}-03_PLE-Axis", ProjNum);
            TB4_2.Text = string.Format("{0}-03_PLE-Lines", ProjNum);
            TB4_3.Text = string.Format("{0}-03_PLE-Structure", ProjNum);
            TB5.Text = string.Format("{0}-04_LRE", ProjNum);
            TB5_1.Text = string.Format("{0}-04_LRE-Lines", ProjNum);
            TB5_2.Text = string.Format("{0}-04_LRE-Structure", ProjNum);
            TB6.Text = string.Format("{0}-05_Lift configs", ProjNum);
            TB7.Text = string.Format("{0}-06_Winches", ProjNum);
            TB7_1.Text = string.Format("{0}-06_Winches-Liftline", ProjNum);
            TB7_2.Text = string.Format("{0}-06_Winches-Securing", ProjNum);
            TB8.Text = string.Format("{0}-07_FAT", ProjNum);
            TB9.Text = string.Format("{0}-08_Procedures", ProjNum);
            TB10.Text = string.Format("{0}-09_Project specific designs", ProjNum);
            TB11.Text = string.Format("{0}-10_Vessel", ProjNum);
            TB12.Text = string.Format("{0}-11_Various", ProjNum);
            TB13.Text = string.Format("{0}-99_Archive", ProjNum);
        }

        public List<FolderName> GetFolderNames()
        {
            List<FolderName> FolderNames = new List<FolderName>();

            //Add first series childless folders
            FolderNames.Add(new FolderName(TB1.Text, CKB1.Checked, null));
            FolderNames.Add(new FolderName(TB2.Text, CKB2.Checked, null));
            FolderNames.Add(new FolderName(TB3.Text, CKB3.Checked, null));

            //Add PLE folder with children
            List<string> PLEChildren = new List<string>();
            if (CKB4_1.Checked) { PLEChildren.Add(TB4_1.Text); }
            if (CKB4_2.Checked) { PLEChildren.Add(TB4_2.Text); }
            if (CKB4_3.Checked) { PLEChildren.Add(TB4_3.Text); }
            FolderNames.Add(new FolderName(TB4.Text, CKB4.Checked, PLEChildren.Distinct().ToList()));

            //Add LRE folder with children
            List<string> LREChildren = new List<string>();
            if (CKB5_1.Checked) { LREChildren.Add(TB5_1.Text); }
            if (CKB5_2.Checked) { LREChildren.Add(TB5_2.Text); }
            FolderNames.Add(new FolderName(TB5.Text, CKB5.Checked, LREChildren.Distinct().ToList()));

            //Add second series of childless folders
            FolderNames.Add(new FolderName(TB6.Text, CKB6.Checked, null));

            //Add Winches folder with children
            List<string> WinchChildren = new List<string>();
            if (CKB7_1.Checked) { WinchChildren.Add(TB7_1.Text); }
            if (CKB7_2.Checked) { WinchChildren.Add(TB7_2.Text); }
            FolderNames.Add(new FolderName(TB7.Text, CKB7.Checked, WinchChildren.Distinct().ToList()));

            //Add third series of childless folders
            FolderNames.Add(new FolderName(TB8.Text, CKB8.Checked, null));
            FolderNames.Add(new FolderName(TB9.Text, CKB9.Checked, null));
            FolderNames.Add(new FolderName(TB10.Text, CKB10.Checked, null));
            FolderNames.Add(new FolderName(TB11.Text, CKB11.Checked, null));
            FolderNames.Add(new FolderName(TB12.Text, CKB12.Checked, null));
            FolderNames.Add(new FolderName(TB13.Text, CKB13.Checked, null));

            //Filter inactive entries
            FolderNames = (from f in FolderNames where f.Active select f).ToList();

            return FolderNames;
        }
        private void CheckedChanged(object sender, EventArgs e)
        {
            //While likely not needed, this locks out looping because checkboxes are changing by the code itself
            if (_CKDLoopPrevention) { return; }
            _CKDLoopPrevention = true;

            CheckBox Origin = (CheckBox)sender;
            switch (Origin.Name)
            {
                case "CKB4":
                    if (Origin.Checked)
                    {
                        //Reset archived values for subboxes
                        if (CKB4_1.Checked != _CKB4_1Arch) { CKB4_1.Checked = _CKB4_1Arch; }
                        if (CKB4_2.Checked != _CKB4_2Arch) { CKB4_2.Checked = _CKB4_2Arch; }
                        if (CKB4_3.Checked != _CKB4_3Arch) { CKB4_3.Checked = _CKB4_3Arch; }
                    }
                    else
                    {
                        //Archive subbox values and then turn them all to unchecked
                        _CKB4_1Arch = CKB4_1.Checked;
                        _CKB4_2Arch = CKB4_2.Checked;
                        _CKB4_3Arch = CKB4_3.Checked;

                        CKB4_1.Checked = false;
                        CKB4_2.Checked = false;
                        CKB4_3.Checked = false;
                    }
                    break;
                case "CKB5":
                    if (Origin.Checked)
                    {
                        //Reset archived values for subboxes
                        if (CKB5_1.Checked != _CKB5_1Arch) { CKB5_1.Checked = _CKB5_1Arch; }
                        if (CKB5_2.Checked != _CKB5_2Arch) { CKB5_2.Checked = _CKB5_2Arch; }
                    }
                    else
                    {
                        //Acrhive subbox values and then turn them all to unchecked
                        _CKB5_1Arch = CKB5_1.Checked;
                        _CKB5_2Arch = CKB5_2.Checked;

                        CKB5_1.Checked = false;
                        CKB5_2.Checked = false;
                    }
                    break;
                case "CKB7":
                    if (Origin.Checked)
                    {
                        //Reset archived values for subboxes
                        if (CKB7_1.Checked != _CKB7_1Arch) { CKB7_1.Checked = _CKB7_1Arch; }
                        if (CKB7_2.Checked != _CKB7_2Arch) { CKB7_2.Checked = _CKB7_2Arch; }
                    }
                    else
                    {
                        //Acrhive subbox values and then turn them all to unchecked
                        _CKB7_1Arch = CKB7_1.Checked;
                        _CKB7_2Arch = CKB7_2.Checked;

                        CKB7_1.Checked = false;
                        CKB7_2.Checked = false;
                    }
                    break;
                case "CKB4_1":
                    if (Origin.Checked && !CKB4.Checked)
                    {
                        //Check main box and reset archives values of other subboxes to unchecked
                        _CKB4_2Arch = false;
                        _CKB4_3Arch = false;
                        CKB4.Checked = true;
                    }
                    break;
                case "CKB4_2":
                    if (Origin.Checked && !CKB4.Checked)
                    {
                        //Check main box and reset archives values of other subboxes to unchecked
                        _CKB4_1Arch = false;
                        _CKB4_3Arch = false;
                        CKB4.Checked = true;
                    }
                    break;
                case "CKB4_3":
                    if (Origin.Checked && !CKB4.Checked)
                    {
                        //Check main box and reset archives values of other subboxes to unchecked
                        _CKB4_1Arch = false;
                        _CKB4_2Arch = false;
                        CKB4.Checked = true;
                    }
                    break;
                case "CKB5_1":
                    if (Origin.Checked && !CKB5.Checked)
                    {
                        //Check main box and reset archives values of other subboxes to unchecked
                        _CKB5_2Arch = false;
                        CKB5.Checked = true;
                    }
                    break;
                case "CKB5_2":
                    if (Origin.Checked && !CKB5.Checked)
                    {
                        //Check main box and reset archives values of other subboxes to unchecked
                        _CKB5_1Arch = false;
                        CKB5.Checked = true;
                    }
                    break;
                case "CKB7_1":
                    if (Origin.Checked && !CKB7.Checked)
                    {
                        //Check main box and reset archives values of other subboxes to unchecked
                        _CKB7_2Arch = false;
                        CKB7.Checked = true;
                    }
                    break;
                case "CKB7_2":
                    if (Origin.Checked && !CKB7.Checked)
                    {
                        //Check main box and reset archives values of other subboxes to unchecked
                        _CKB7_1Arch = false;
                        CKB7.Checked = true;
                    }
                    break;
            }
            //Now that it is done it can disable the loop prevention again
            _CKDLoopPrevention = false;
        }

        public class FolderName
        {
            //Class to save the folder data to
            public string Name;
            public bool Active;
            public List<string> ActiveChildren;

            public FolderName(string name, bool active, List<string> actchildren)
            {
                //Initialization for class
                Name = name;
                Active = active;
                ActiveChildren = actchildren;
            }
        }

        //Definitions controls for referencing outside of initialize subroutine
        private System.Windows.Forms.CheckBox CKB1;
        private System.Windows.Forms.TextBox TB1;
        private TextBox TB2;
        private CheckBox CKB2;
        private TextBox TB3;
        private CheckBox CKB3;
        private TextBox TB4;
        private CheckBox CKB4;
        private TextBox TB4_1;
        private CheckBox CKB4_1;
        private TextBox TB4_2;
        private CheckBox CKB4_2;
        private TextBox TB4_3;
        private CheckBox CKB4_3;
        private TextBox TB5;
        private CheckBox CKB5;
        private TextBox TB5_1;
        private CheckBox CKB5_1;
        private TextBox TB5_2;
        private CheckBox CKB5_2;
        private TextBox TB6;
        private CheckBox CKB6;
        private TextBox TB7;
        private CheckBox CKB7;
        private TextBox TB7_1;
        private CheckBox CKB7_1;
        private TextBox TB7_2;
        private CheckBox CKB7_2;
        private TextBox TB8;
        private CheckBox CKB8;
        private TextBox TB9;
        private CheckBox CKB9;
        private TextBox TB10;
        private CheckBox CKB10;
        private TextBox TB11;
        private CheckBox CKB11;
        private TextBox TB12;
        private CheckBox CKB12;
        private TextBox TB13;
        private CheckBox CKB13;
        private Button OKButton;
    }
}