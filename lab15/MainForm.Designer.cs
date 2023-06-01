namespace lab15
{
    partial class Calculator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CalculateButton_Click = new System.Windows.Forms.Button();
            this.AInput = new System.Windows.Forms.TextBox();
            this.BInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HypotenuseOutput = new System.Windows.Forms.TextBox();
            this.AreaOutput = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(400, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Катет A:";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(400, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Катет B:";
            this.label2.UseWaitCursor = true;
            // 
            // CalculateButton_Click
            // 
            this.CalculateButton_Click.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CalculateButton_Click.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CalculateButton_Click.Font = new System.Drawing.Font("Roboto Bk", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateButton_Click.Location = new System.Drawing.Point(514, 215);
            this.CalculateButton_Click.Name = "CalculateButton_Click";
            this.CalculateButton_Click.Size = new System.Drawing.Size(100, 44);
            this.CalculateButton_Click.TabIndex = 2;
            this.CalculateButton_Click.Text = "Обчислити";
            this.CalculateButton_Click.UseVisualStyleBackColor = false;
            this.CalculateButton_Click.UseWaitCursor = true;
            this.CalculateButton_Click.Click += new System.EventHandler(this.CalculateButton_Click_Click);
            // 
            // AInput
            // 
            this.AInput.Location = new System.Drawing.Point(514, 27);
            this.AInput.Name = "AInput";
            this.AInput.Size = new System.Drawing.Size(100, 20);
            this.AInput.TabIndex = 3;
            this.AInput.UseWaitCursor = true;
            // 
            // BInput
            // 
            this.BInput.Location = new System.Drawing.Point(514, 73);
            this.BInput.Name = "BInput";
            this.BInput.Size = new System.Drawing.Size(100, 20);
            this.BInput.TabIndex = 4;
            this.BInput.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(363, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Гіпотенуза:";
            this.label3.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(409, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Площа:";
            this.label4.UseWaitCursor = true;
            // 
            // HypotenuseOutput
            // 
            this.HypotenuseOutput.Location = new System.Drawing.Point(514, 122);
            this.HypotenuseOutput.Name = "HypotenuseOutput";
            this.HypotenuseOutput.Size = new System.Drawing.Size(100, 20);
            this.HypotenuseOutput.TabIndex = 7;
            this.HypotenuseOutput.UseWaitCursor = true;
            // 
            // AreaOutput
            // 
            this.AreaOutput.Location = new System.Drawing.Point(514, 166);
            this.AreaOutput.Name = "AreaOutput";
            this.AreaOutput.Size = new System.Drawing.Size(100, 20);
            this.AreaOutput.TabIndex = 8;
            this.AreaOutput.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::lab15.Properties.Resources.pexels_karolina_grabowska_5412432;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(733, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 450);
            this.Controls.Add(this.AreaOutput);
            this.Controls.Add(this.HypotenuseOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BInput);
            this.Controls.Add(this.AInput);
            this.Controls.Add(this.CalculateButton_Click);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CalculateButton_Click;
        private System.Windows.Forms.TextBox AInput;
        private System.Windows.Forms.TextBox BInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HypotenuseOutput;
        private System.Windows.Forms.TextBox AreaOutput;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

