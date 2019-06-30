namespace MineSweeper
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblDificulty = new System.Windows.Forms.Label();
            this.txBoxSize = new System.Windows.Forms.TextBox();
            this.txBoxDifficulty = new System.Windows.Forms.TextBox();
            this.txBoxUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnScores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vani", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To MineSweeper";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Vani", 10.25F);
            this.btnStart.Location = new System.Drawing.Point(82, 236);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(164, 29);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Vani", 10.25F);
            this.lblSize.Location = new System.Drawing.Point(146, 116);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(37, 25);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Size";
            // 
            // lblDificulty
            // 
            this.lblDificulty.AutoSize = true;
            this.lblDificulty.Font = new System.Drawing.Font("Vani", 10.25F);
            this.lblDificulty.Location = new System.Drawing.Point(129, 172);
            this.lblDificulty.Name = "lblDificulty";
            this.lblDificulty.Size = new System.Drawing.Size(70, 25);
            this.lblDificulty.TabIndex = 2;
            this.lblDificulty.Text = "Difficulty";
            // 
            // txBoxSize
            // 
            this.txBoxSize.Location = new System.Drawing.Point(114, 144);
            this.txBoxSize.Name = "txBoxSize";
            this.txBoxSize.Size = new System.Drawing.Size(100, 20);
            this.txBoxSize.TabIndex = 2;
            // 
            // txBoxDifficulty
            // 
            this.txBoxDifficulty.Location = new System.Drawing.Point(114, 200);
            this.txBoxDifficulty.Name = "txBoxDifficulty";
            this.txBoxDifficulty.Size = new System.Drawing.Size(100, 20);
            this.txBoxDifficulty.TabIndex = 3;
            // 
            // txBoxUserName
            // 
            this.txBoxUserName.Font = new System.Drawing.Font("Vani", 8.25F);
            this.txBoxUserName.Location = new System.Drawing.Point(114, 87);
            this.txBoxUserName.Name = "txBoxUserName";
            this.txBoxUserName.Size = new System.Drawing.Size(100, 26);
            this.txBoxUserName.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Vani", 10.25F);
            this.lblUserName.Location = new System.Drawing.Point(118, 59);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(92, 25);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "Player Name";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(340, 17);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(326, 459);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // btnScores
            // 
            this.btnScores.Font = new System.Drawing.Font("Vani", 10.25F);
            this.btnScores.Location = new System.Drawing.Point(89, 290);
            this.btnScores.Name = "btnScores";
            this.btnScores.Size = new System.Drawing.Size(150, 29);
            this.btnScores.TabIndex = 5;
            this.btnScores.Text = "Scores";
            this.btnScores.UseVisualStyleBackColor = true;
            this.btnScores.Click += new System.EventHandler(this.btnScores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 488);
            this.Controls.Add(this.btnScores);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txBoxUserName);
            this.Controls.Add(this.txBoxDifficulty);
            this.Controls.Add(this.txBoxSize);
            this.Controls.Add(this.lblDificulty);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblDificulty;
        private System.Windows.Forms.TextBox txBoxSize;
        private System.Windows.Forms.TextBox txBoxDifficulty;
        private System.Windows.Forms.TextBox txBoxUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnScores;
    }
}

