namespace Project8
{
    partial class ConnectFour
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
            this.uxButton1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.uxButton2 = new System.Windows.Forms.Button();
            this.uxButton3 = new System.Windows.Forms.Button();
            this.uxButton4 = new System.Windows.Forms.Button();
            this.uxButton5 = new System.Windows.Forms.Button();
            this.uxButton6 = new System.Windows.Forms.Button();
            this.uxButton7 = new System.Windows.Forms.Button();
            this.uxLabel = new System.Windows.Forms.Label();
            this.uxNewGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxButton1
            // 
            this.uxButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButton1.Location = new System.Drawing.Point(16, 12);
            this.uxButton1.Name = "uxButton1";
            this.uxButton1.Size = new System.Drawing.Size(64, 43);
            this.uxButton1.TabIndex = 0;
            this.uxButton1.Text = "1";
            this.uxButton1.UseVisualStyleBackColor = true;
            this.uxButton1.Click += new System.EventHandler(this.ClickColumn);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(102, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(0, 0);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(192, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(0, 0);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(282, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(0, 0);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(372, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(0, 0);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(177, 91);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(0, 0);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(208, 220);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(0, 0);
            this.button7.TabIndex = 6;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // uxButton2
            // 
            this.uxButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButton2.Location = new System.Drawing.Point(85, 12);
            this.uxButton2.Name = "uxButton2";
            this.uxButton2.Size = new System.Drawing.Size(62, 43);
            this.uxButton2.TabIndex = 7;
            this.uxButton2.Text = "2";
            this.uxButton2.UseVisualStyleBackColor = true;
            this.uxButton2.Click += new System.EventHandler(this.ClickColumn);
            // 
            // uxButton3
            // 
            this.uxButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButton3.Location = new System.Drawing.Point(154, 12);
            this.uxButton3.Name = "uxButton3";
            this.uxButton3.Size = new System.Drawing.Size(62, 43);
            this.uxButton3.TabIndex = 8;
            this.uxButton3.Text = "3";
            this.uxButton3.UseVisualStyleBackColor = true;
            this.uxButton3.Click += new System.EventHandler(this.ClickColumn);
            // 
            // uxButton4
            // 
            this.uxButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButton4.Location = new System.Drawing.Point(223, 12);
            this.uxButton4.Name = "uxButton4";
            this.uxButton4.Size = new System.Drawing.Size(62, 43);
            this.uxButton4.TabIndex = 9;
            this.uxButton4.Text = "4";
            this.uxButton4.UseVisualStyleBackColor = true;
            this.uxButton4.Click += new System.EventHandler(this.ClickColumn);
            // 
            // uxButton5
            // 
            this.uxButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButton5.Location = new System.Drawing.Point(290, 12);
            this.uxButton5.Name = "uxButton5";
            this.uxButton5.Size = new System.Drawing.Size(62, 43);
            this.uxButton5.TabIndex = 10;
            this.uxButton5.Text = "5";
            this.uxButton5.UseVisualStyleBackColor = true;
            this.uxButton5.Click += new System.EventHandler(this.ClickColumn);
            // 
            // uxButton6
            // 
            this.uxButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButton6.Location = new System.Drawing.Point(359, 12);
            this.uxButton6.Name = "uxButton6";
            this.uxButton6.Size = new System.Drawing.Size(62, 43);
            this.uxButton6.TabIndex = 11;
            this.uxButton6.Text = "6";
            this.uxButton6.UseVisualStyleBackColor = true;
            this.uxButton6.Click += new System.EventHandler(this.ClickColumn);
            // 
            // uxButton7
            // 
            this.uxButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxButton7.Location = new System.Drawing.Point(427, 12);
            this.uxButton7.Name = "uxButton7";
            this.uxButton7.Size = new System.Drawing.Size(62, 43);
            this.uxButton7.TabIndex = 12;
            this.uxButton7.Text = "7";
            this.uxButton7.UseVisualStyleBackColor = true;
            this.uxButton7.Click += new System.EventHandler(this.ClickColumn);
            // 
            // uxLabel
            // 
            this.uxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLabel.Location = new System.Drawing.Point(21, 496);
            this.uxLabel.Name = "uxLabel";
            this.uxLabel.Size = new System.Drawing.Size(146, 23);
            this.uxLabel.TabIndex = 13;
            this.uxLabel.Text = "red\'s turn";
            this.uxLabel.Click += new System.EventHandler(this.UxLabel_Click);
            // 
            // uxNewGame
            // 
            this.uxNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxNewGame.Location = new System.Drawing.Point(361, 490);
            this.uxNewGame.Name = "uxNewGame";
            this.uxNewGame.Size = new System.Drawing.Size(130, 37);
            this.uxNewGame.TabIndex = 14;
            this.uxNewGame.Text = "New Game";
            this.uxNewGame.UseVisualStyleBackColor = true;
            this.uxNewGame.Click += new System.EventHandler(this.UxNewGame_Click);
            // 
            // ConnectFour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 533);
            this.Controls.Add(this.uxNewGame);
            this.Controls.Add(this.uxLabel);
            this.Controls.Add(this.uxButton7);
            this.Controls.Add(this.uxButton6);
            this.Controls.Add(this.uxButton5);
            this.Controls.Add(this.uxButton4);
            this.Controls.Add(this.uxButton3);
            this.Controls.Add(this.uxButton2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.uxButton1);
            this.Name = "ConnectFour";
            this.Text = "Connect Four";
            this.Load += new System.EventHandler(this.ConnectFour_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxButton1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button uxButton2;
        private System.Windows.Forms.Button uxButton3;
        private System.Windows.Forms.Button uxButton4;
        private System.Windows.Forms.Button uxButton5;
        private System.Windows.Forms.Button uxButton6;
        private System.Windows.Forms.Button uxButton7;
        private System.Windows.Forms.Label uxLabel;
        private System.Windows.Forms.Button uxNewGame;
    }
}

