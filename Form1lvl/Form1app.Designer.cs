namespace anketa.Form1lvl
{
    partial class Form1app
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
            this.pQuestion = new System.Windows.Forms.Panel();
            this.pAnswer3 = new System.Windows.Forms.Panel();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.pAnswer2 = new System.Windows.Forms.Panel();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.pAnswer1 = new System.Windows.Forms.Panel();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.pButton = new System.Windows.Forms.Panel();
            this.bOk = new System.Windows.Forms.Button();
            this.pQuestPoint = new System.Windows.Forms.Panel();
            this.lQuestPoint = new System.Windows.Forms.Label();
            this.pQuestText = new System.Windows.Forms.Panel();
            this.lQuestText = new System.Windows.Forms.Label();
            this.pQuestion.SuspendLayout();
            this.pAnswer3.SuspendLayout();
            this.pAnswer2.SuspendLayout();
            this.pAnswer1.SuspendLayout();
            this.pButton.SuspendLayout();
            this.pQuestPoint.SuspendLayout();
            this.pQuestText.SuspendLayout();
            this.SuspendLayout();
            // 
            // pQuestion
            // 
            this.pQuestion.AutoSize = true;
            this.pQuestion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pQuestion.Controls.Add(this.pAnswer3);
            this.pQuestion.Controls.Add(this.pAnswer2);
            this.pQuestion.Controls.Add(this.pAnswer1);
            this.pQuestion.Controls.Add(this.pButton);
            this.pQuestion.Controls.Add(this.pQuestPoint);
            this.pQuestion.Controls.Add(this.pQuestText);
            this.pQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pQuestion.Location = new System.Drawing.Point(0, 0);
            this.pQuestion.Name = "pQuestion";
            this.pQuestion.Size = new System.Drawing.Size(887, 216);
            this.pQuestion.TabIndex = 0;
            // 
            // pAnswer3
            // 
            this.pAnswer3.AutoSize = true;
            this.pAnswer3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pAnswer3.Controls.Add(this.tbAge);
            this.pAnswer3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pAnswer3.Location = new System.Drawing.Point(0, 161);
            this.pAnswer3.Name = "pAnswer3";
            this.pAnswer3.Size = new System.Drawing.Size(887, 26);
            this.pAnswer3.TabIndex = 11;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(22, 3);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(290, 20);
            this.tbAge.TabIndex = 0;
            // 
            // pAnswer2
            // 
            this.pAnswer2.AutoSize = true;
            this.pAnswer2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pAnswer2.Controls.Add(this.rb3);
            this.pAnswer2.Controls.Add(this.rb4);
            this.pAnswer2.Controls.Add(this.rb5);
            this.pAnswer2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pAnswer2.Location = new System.Drawing.Point(0, 91);
            this.pAnswer2.Name = "pAnswer2";
            this.pAnswer2.Size = new System.Drawing.Size(887, 70);
            this.pAnswer2.TabIndex = 1;
            // 
            // rb3
            // 
            this.rb3.AccessibleDescription = "3";
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(22, 4);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(290, 17);
            this.rb3.TabIndex = 3;
            this.rb3.Text = "3. Скорее не удовлетворен (а), чем удовлетворен (а)";
            this.rb3.UseVisualStyleBackColor = true;
            this.rb3.Click += new System.EventHandler(this.rb3Q1_Click);
            // 
            // rb4
            // 
            this.rb4.AccessibleDescription = "4";
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(22, 27);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(139, 17);
            this.rb4.TabIndex = 4;
            this.rb4.Text = "4. Не удовлетворен (а)";
            this.rb4.UseVisualStyleBackColor = true;
            this.rb4.Click += new System.EventHandler(this.rb4Q1_Click);
            // 
            // rb5
            // 
            this.rb5.AccessibleDescription = "99";
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(22, 50);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(158, 17);
            this.rb5.TabIndex = 5;
            this.rb5.Text = "99. Затрудняюсь ответить";
            this.rb5.UseVisualStyleBackColor = true;
            this.rb5.Click += new System.EventHandler(this.rb5Q1_Click);
            // 
            // pAnswer1
            // 
            this.pAnswer1.AutoSize = true;
            this.pAnswer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pAnswer1.Controls.Add(this.rb1);
            this.pAnswer1.Controls.Add(this.rb2);
            this.pAnswer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pAnswer1.Location = new System.Drawing.Point(0, 45);
            this.pAnswer1.Name = "pAnswer1";
            this.pAnswer1.Size = new System.Drawing.Size(887, 46);
            this.pAnswer1.TabIndex = 10;
            // 
            // rb1
            // 
            this.rb1.AccessibleDescription = "1";
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(22, 3);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(125, 17);
            this.rb1.TabIndex = 1;
            this.rb1.Text = "1. Удовлетворен (а)";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.Click += new System.EventHandler(this.rb1Q1_Click);
            // 
            // rb2
            // 
            this.rb2.AccessibleDescription = "2";
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(22, 26);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(290, 17);
            this.rb2.TabIndex = 2;
            this.rb2.Text = "2. Скорее удовлетворен (а), чем не удовлетворен (а)";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.Click += new System.EventHandler(this.rb2Q1_Click);
            // 
            // pButton
            // 
            this.pButton.Controls.Add(this.bOk);
            this.pButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pButton.Location = new System.Drawing.Point(0, 187);
            this.pButton.Name = "pButton";
            this.pButton.Size = new System.Drawing.Size(887, 29);
            this.pButton.TabIndex = 9;
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(62, 3);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(135, 23);
            this.bOk.TabIndex = 6;
            this.bOk.Text = "OK";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bQ1Ok_Click);
            // 
            // pQuestPoint
            // 
            this.pQuestPoint.Controls.Add(this.lQuestPoint);
            this.pQuestPoint.Dock = System.Windows.Forms.DockStyle.Top;
            this.pQuestPoint.Location = new System.Drawing.Point(0, 23);
            this.pQuestPoint.Name = "pQuestPoint";
            this.pQuestPoint.Size = new System.Drawing.Size(887, 22);
            this.pQuestPoint.TabIndex = 8;
            // 
            // lQuestPoint
            // 
            this.lQuestPoint.AutoSize = true;
            this.lQuestPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lQuestPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lQuestPoint.Location = new System.Drawing.Point(0, 0);
            this.lQuestPoint.Name = "lQuestPoint";
            this.lQuestPoint.Size = new System.Drawing.Size(345, 17);
            this.lQuestPoint.TabIndex = 1;
            this.lQuestPoint.Text = "1. Техническим состоянием, ремонтом помещений";
            // 
            // pQuestText
            // 
            this.pQuestText.Controls.Add(this.lQuestText);
            this.pQuestText.Dock = System.Windows.Forms.DockStyle.Top;
            this.pQuestText.Location = new System.Drawing.Point(0, 0);
            this.pQuestText.Name = "pQuestText";
            this.pQuestText.Size = new System.Drawing.Size(887, 23);
            this.pQuestText.TabIndex = 7;
            // 
            // lQuestText
            // 
            this.lQuestText.AutoSize = true;
            this.lQuestText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lQuestText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lQuestText.Location = new System.Drawing.Point(0, 0);
            this.lQuestText.Name = "lQuestText";
            this.lQuestText.Size = new System.Drawing.Size(809, 17);
            this.lQuestText.TabIndex = 0;
            this.lQuestText.Text = "1. Насколько Вы удовлетворены качеством бесплатной медицинской помощи, получаемой" +
    " в поликлинике";
            // 
            // Form1app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 216);
            this.Controls.Add(this.pQuestion);
            this.Name = "Form1app";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "app";
            this.pQuestion.ResumeLayout(false);
            this.pQuestion.PerformLayout();
            this.pAnswer3.ResumeLayout(false);
            this.pAnswer3.PerformLayout();
            this.pAnswer2.ResumeLayout(false);
            this.pAnswer2.PerformLayout();
            this.pAnswer1.ResumeLayout(false);
            this.pAnswer1.PerformLayout();
            this.pButton.ResumeLayout(false);
            this.pQuestPoint.ResumeLayout(false);
            this.pQuestPoint.PerformLayout();
            this.pQuestText.ResumeLayout(false);
            this.pQuestText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pQuestion;
        private System.Windows.Forms.Label lQuestText;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Panel pQuestPoint;
        private System.Windows.Forms.Label lQuestPoint;
        private System.Windows.Forms.Panel pQuestText;
        private System.Windows.Forms.Panel pAnswer1;
        private System.Windows.Forms.Panel pButton;
        private System.Windows.Forms.Panel pAnswer2;
        private System.Windows.Forms.Panel pAnswer3;
        private System.Windows.Forms.TextBox tbAge;
    }
}