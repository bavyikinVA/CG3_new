namespace CG3
{
    partial class Form1
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.checkBoxTransfer = new System.Windows.Forms.CheckBox();
            this.checkBoxStretching = new System.Windows.Forms.CheckBox();
            this.checkBoxReflectionY = new System.Windows.Forms.CheckBox();
            this.checkBoxReflectionX = new System.Windows.Forms.CheckBox();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.checkBoxTurn = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(37, 528);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // checkBoxTransfer
            // 
            this.checkBoxTransfer.AutoSize = true;
            this.checkBoxTransfer.Location = new System.Drawing.Point(1265, 732);
            this.checkBoxTransfer.Name = "checkBoxTransfer";
            this.checkBoxTransfer.Size = new System.Drawing.Size(70, 17);
            this.checkBoxTransfer.TabIndex = 1;
            this.checkBoxTransfer.Text = "Перенос";
            this.checkBoxTransfer.UseVisualStyleBackColor = true;
            // 
            // checkBoxStretching
            // 
            this.checkBoxStretching.AutoSize = true;
            this.checkBoxStretching.Location = new System.Drawing.Point(1265, 574);
            this.checkBoxStretching.Name = "checkBoxStretching";
            this.checkBoxStretching.Size = new System.Drawing.Size(88, 17);
            this.checkBoxStretching.TabIndex = 2;
            this.checkBoxStretching.Text = "Растяжение";
            this.checkBoxStretching.UseVisualStyleBackColor = true;
            // 
            // checkBoxReflectionY
            // 
            this.checkBoxReflectionY.AutoSize = true;
            this.checkBoxReflectionY.Location = new System.Drawing.Point(1265, 551);
            this.checkBoxReflectionY.Name = "checkBoxReflectionY";
            this.checkBoxReflectionY.Size = new System.Drawing.Size(124, 17);
            this.checkBoxReflectionY.TabIndex = 3;
            this.checkBoxReflectionY.Text = "Отражение отн. OY";
            this.checkBoxReflectionY.UseVisualStyleBackColor = true;
            // 
            // checkBoxReflectionX
            // 
            this.checkBoxReflectionX.AutoSize = true;
            this.checkBoxReflectionX.Location = new System.Drawing.Point(1265, 528);
            this.checkBoxReflectionX.Name = "checkBoxReflectionX";
            this.checkBoxReflectionX.Size = new System.Drawing.Size(121, 17);
            this.checkBoxReflectionX.TabIndex = 4;
            this.checkBoxReflectionX.Text = "Отражение отн OX";
            this.checkBoxReflectionX.UseVisualStyleBackColor = true;
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(37, 582);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(75, 23);
            this.buttonRestart.TabIndex = 5;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // checkBoxTurn
            // 
            this.checkBoxTurn.AutoSize = true;
            this.checkBoxTurn.Location = new System.Drawing.Point(1265, 683);
            this.checkBoxTurn.Name = "checkBoxTurn";
            this.checkBoxTurn.Size = new System.Drawing.Size(144, 17);
            this.checkBoxTurn.TabIndex = 6;
            this.checkBoxTurn.Text = "Поворот (введите угол)";
            this.checkBoxTurn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1262, 752);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Сдвиг X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1262, 791);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Сдвиг Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1262, 594);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Изменение по X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1262, 633);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Изменение по Y";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1159, 610);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1159, 647);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1159, 708);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1159, 768);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 20;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1159, 807);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 1000);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxTurn);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.checkBoxReflectionX);
            this.Controls.Add(this.checkBoxReflectionY);
            this.Controls.Add(this.checkBoxStretching);
            this.Controls.Add(this.checkBoxTransfer);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.Button buttonStart;
            private System.Windows.Forms.CheckBox checkBoxTransfer;
            private System.Windows.Forms.CheckBox checkBoxStretching;
            private System.Windows.Forms.CheckBox checkBoxReflectionY;
            private System.Windows.Forms.CheckBox checkBoxReflectionX;
            private System.Windows.Forms.Button buttonRestart;
            private System.Windows.Forms.CheckBox checkBoxTurn;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.Label label4;
            
            private System.Windows.Forms.Label label5;
            private System.Windows.Forms.TextBox textBox1;
            private System.Windows.Forms.TextBox textBox2;
            private System.Windows.Forms.TextBox textBox3;
            private System.Windows.Forms.TextBox textBox4;
            private System.Windows.Forms.TextBox textBox5;
    }
}


