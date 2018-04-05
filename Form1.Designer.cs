namespace NPCGen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resultText = new System.Windows.Forms.Label();
            this.cultureBox = new System.Windows.Forms.ComboBox();
            this.classBox = new System.Windows.Forms.ComboBox();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.checkName = new System.Windows.Forms.CheckBox();
            this.checkJob = new System.Windows.Forms.CheckBox();
            this.checkHome = new System.Windows.Forms.CheckBox();
            this.mixButton = new System.Windows.Forms.Button();
            this.checkPers = new System.Windows.Forms.CheckBox();
            this.checkPhys = new System.Windows.Forms.CheckBox();
            this.checkItem = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Culture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gender";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resultText);
            this.groupBox1.Location = new System.Drawing.Point(18, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 138);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultText.Location = new System.Drawing.Point(6, 26);
            this.resultText.MaximumSize = new System.Drawing.Size(560, 100);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(514, 50);
            this.resultText.TabIndex = 0;
            this.resultText.Text = "Result might be longer than one line. Scary thought, innit?";
            // 
            // cultureBox
            // 
            this.cultureBox.FormattingEnabled = true;
            this.cultureBox.Location = new System.Drawing.Point(13, 32);
            this.cultureBox.Name = "cultureBox";
            this.cultureBox.Size = new System.Drawing.Size(111, 21);
            this.cultureBox.TabIndex = 7;
            // 
            // classBox
            // 
            this.classBox.FormattingEnabled = true;
            this.classBox.Location = new System.Drawing.Point(161, 32);
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(111, 21);
            this.classBox.TabIndex = 8;
            // 
            // genderBox
            // 
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Location = new System.Drawing.Point(315, 32);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(111, 21);
            this.genderBox.TabIndex = 9;
            // 
            // checkName
            // 
            this.checkName.AutoSize = true;
            this.checkName.Location = new System.Drawing.Point(12, 54);
            this.checkName.Name = "checkName";
            this.checkName.Size = new System.Drawing.Size(79, 17);
            this.checkName.TabIndex = 10;
            this.checkName.Text = "Lock name";
            this.checkName.UseVisualStyleBackColor = true;
            // 
            // checkJob
            // 
            this.checkJob.AutoSize = true;
            this.checkJob.Location = new System.Drawing.Point(161, 54);
            this.checkJob.Name = "checkJob";
            this.checkJob.Size = new System.Drawing.Size(67, 17);
            this.checkJob.TabIndex = 11;
            this.checkJob.Text = "Lock job";
            this.checkJob.UseVisualStyleBackColor = true;
            // 
            // checkHome
            // 
            this.checkHome.AutoSize = true;
            this.checkHome.Location = new System.Drawing.Point(315, 54);
            this.checkHome.Name = "checkHome";
            this.checkHome.Size = new System.Drawing.Size(79, 17);
            this.checkHome.TabIndex = 12;
            this.checkHome.Text = "Lock home";
            this.checkHome.UseVisualStyleBackColor = true;
            // 
            // mixButton
            // 
            this.mixButton.Location = new System.Drawing.Point(470, 32);
            this.mixButton.Name = "mixButton";
            this.mixButton.Size = new System.Drawing.Size(111, 39);
            this.mixButton.TabIndex = 13;
            this.mixButton.Text = "Gimme that NPC";
            this.mixButton.UseVisualStyleBackColor = true;
            this.mixButton.Click += new System.EventHandler(this.mixButton_Click);
            // 
            // checkPers
            // 
            this.checkPers.AutoSize = true;
            this.checkPers.Location = new System.Drawing.Point(161, 77);
            this.checkPers.Name = "checkPers";
            this.checkPers.Size = new System.Drawing.Size(103, 17);
            this.checkPers.TabIndex = 15;
            this.checkPers.Text = "Lock personality";
            this.checkPers.UseVisualStyleBackColor = true;
            // 
            // checkPhys
            // 
            this.checkPhys.AutoSize = true;
            this.checkPhys.Location = new System.Drawing.Point(12, 77);
            this.checkPhys.Name = "checkPhys";
            this.checkPhys.Size = new System.Drawing.Size(91, 17);
            this.checkPhys.TabIndex = 14;
            this.checkPhys.Text = "Lock physical";
            this.checkPhys.UseVisualStyleBackColor = true;
            // 
            // checkItem
            // 
            this.checkItem.AutoSize = true;
            this.checkItem.Location = new System.Drawing.Point(315, 77);
            this.checkItem.Name = "checkItem";
            this.checkItem.Size = new System.Drawing.Size(72, 17);
            this.checkItem.TabIndex = 16;
            this.checkItem.Text = "Lock item";
            this.checkItem.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 261);
            this.Controls.Add(this.checkItem);
            this.Controls.Add(this.checkPers);
            this.Controls.Add(this.checkPhys);
            this.Controls.Add(this.mixButton);
            this.Controls.Add(this.checkHome);
            this.Controls.Add(this.checkJob);
            this.Controls.Add(this.checkName);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.classBox);
            this.Controls.Add(this.cultureBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Non-Player Character Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cultureBox;
        private System.Windows.Forms.ComboBox classBox;
        private System.Windows.Forms.ComboBox genderBox;
        private System.Windows.Forms.CheckBox checkName;
        private System.Windows.Forms.CheckBox checkJob;
        private System.Windows.Forms.CheckBox checkHome;
        private System.Windows.Forms.Button mixButton;
        private System.Windows.Forms.Label resultText;
        private System.Windows.Forms.CheckBox checkPers;
        private System.Windows.Forms.CheckBox checkPhys;
        private System.Windows.Forms.CheckBox checkItem;
    }
}

