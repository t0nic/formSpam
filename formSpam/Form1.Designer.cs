namespace formSpam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.theURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userVarName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userVarValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passVarName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passVarValue = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro Cond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SCRIPT URL:";
            // 
            // theURL
            // 
            this.theURL.Location = new System.Drawing.Point(110, 9);
            this.theURL.Name = "theURL";
            this.theURL.Size = new System.Drawing.Size(295, 20);
            this.theURL.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "USER VAR NAME:";
            // 
            // userVarName
            // 
            this.userVarName.Location = new System.Drawing.Point(110, 35);
            this.userVarName.Name = "userVarName";
            this.userVarName.Size = new System.Drawing.Size(94, 20);
            this.userVarName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myriad Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "USER VAR VALUE:";
            // 
            // userVarValue
            // 
            this.userVarValue.Location = new System.Drawing.Point(311, 35);
            this.userVarValue.Name = "userVarValue";
            this.userVarValue.Size = new System.Drawing.Size(94, 20);
            this.userVarValue.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myriad Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "PASS VAR NAME:";
            // 
            // passVarName
            // 
            this.passVarName.Location = new System.Drawing.Point(110, 56);
            this.passVarName.Name = "passVarName";
            this.passVarName.Size = new System.Drawing.Size(94, 20);
            this.passVarName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myriad Pro Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(211, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "PASS VAR VALUE:";
            // 
            // passVarValue
            // 
            this.passVarValue.Location = new System.Drawing.Point(311, 56);
            this.passVarValue.Name = "passVarValue";
            this.passVarValue.Size = new System.Drawing.Size(94, 20);
            this.passVarValue.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(119, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 31);
            this.button2.TabIndex = 11;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(20, 136);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(385, 164);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 312);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passVarValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passVarName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userVarValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userVarName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.theURL);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Phish Spammer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox theURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userVarName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userVarValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passVarName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passVarValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
    }
}

