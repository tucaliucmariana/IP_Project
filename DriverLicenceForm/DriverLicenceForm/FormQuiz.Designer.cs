namespace DriverLicenceForm
{
    partial class FormQuiz
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
            this.panelQuestion = new System.Windows.Forms.Panel();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelQuestions = new System.Windows.Forms.Label();
            this.groupBoxAnswers = new System.Windows.Forms.GroupBox();
            this.labelC = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.RadioButton();
            this.C = new System.Windows.Forms.RadioButton();
            this.B = new System.Windows.Forms.RadioButton();
            this.panelIntro = new System.Windows.Forms.Panel();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panelQuestion.SuspendLayout();
            this.groupBoxAnswers.SuspendLayout();
            this.panelIntro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuestion
            // 
            this.panelQuestion.Controls.Add(this.textBoxQuestion);
            this.panelQuestion.Controls.Add(this.buttonSubmit);
            this.panelQuestion.Controls.Add(this.labelQuestions);
            this.panelQuestion.Controls.Add(this.groupBoxAnswers);
            this.panelQuestion.Location = new System.Drawing.Point(19, 28);
            this.panelQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new System.Drawing.Size(883, 532);
            this.panelQuestion.TabIndex = 4;
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(39, 59);
            this.textBoxQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(780, 171);
            this.textBoxQuestion.TabIndex = 4;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(733, 470);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(100, 36);
            this.buttonSubmit.TabIndex = 3;
            this.buttonSubmit.Text = "Trimite";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.OnButtonSubmitClick);
            // 
            // labelQuestions
            // 
            this.labelQuestions.AutoSize = true;
            this.labelQuestions.Location = new System.Drawing.Point(48, 18);
            this.labelQuestions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuestions.Name = "labelQuestions";
            this.labelQuestions.Size = new System.Drawing.Size(69, 17);
            this.labelQuestions.TabIndex = 2;
            this.labelQuestions.Text = "Întrebare:";
            // 
            // groupBoxAnswers
            // 
            this.groupBoxAnswers.Controls.Add(this.labelC);
            this.groupBoxAnswers.Controls.Add(this.labelB);
            this.groupBoxAnswers.Controls.Add(this.labelA);
            this.groupBoxAnswers.Controls.Add(this.A);
            this.groupBoxAnswers.Controls.Add(this.C);
            this.groupBoxAnswers.Controls.Add(this.B);
            this.groupBoxAnswers.Location = new System.Drawing.Point(39, 251);
            this.groupBoxAnswers.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxAnswers.Name = "groupBoxAnswers";
            this.groupBoxAnswers.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxAnswers.Size = new System.Drawing.Size(795, 198);
            this.groupBoxAnswers.TabIndex = 1;
            this.groupBoxAnswers.TabStop = false;
            this.groupBoxAnswers.Text = "Variante de răspuns:";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(60, 121);
            this.labelC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(17, 17);
            this.labelC.TabIndex = 11;
            this.labelC.Text = "C";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(60, 84);
            this.labelB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(17, 17);
            this.labelB.TabIndex = 10;
            this.labelB.Text = "B";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(60, 47);
            this.labelA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(17, 17);
            this.labelA.TabIndex = 9;
            this.labelA.Text = "A";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Location = new System.Drawing.Point(92, 47);
            this.A.Margin = new System.Windows.Forms.Padding(4);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(17, 16);
            this.A.TabIndex = 5;
            this.A.TabStop = true;
            this.A.UseVisualStyleBackColor = true;
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(92, 121);
            this.C.Margin = new System.Windows.Forms.Padding(4);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(17, 16);
            this.C.TabIndex = 7;
            this.C.TabStop = true;
            this.C.UseVisualStyleBackColor = true;
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(92, 84);
            this.B.Margin = new System.Windows.Forms.Padding(4);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(17, 16);
            this.B.TabIndex = 8;
            this.B.TabStop = true;
            this.B.UseVisualStyleBackColor = true;
            // 
            // panelIntro
            // 
            this.panelIntro.Controls.Add(this.textBoxTitle);
            this.panelIntro.Controls.Add(this.buttonStart);
            this.panelIntro.Location = new System.Drawing.Point(19, 28);
            this.panelIntro.Margin = new System.Windows.Forms.Padding(4);
            this.panelIntro.Name = "panelIntro";
            this.panelIntro.Size = new System.Drawing.Size(881, 532);
            this.panelIntro.TabIndex = 5;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTitle.Location = new System.Drawing.Point(129, 135);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTitle.Multiline = true;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(637, 95);
            this.textBoxTitle.TabIndex = 1;
            this.textBoxTitle.Text = "Chestionar Auto\r\nCategoria B\r\n";
            this.textBoxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStart.Location = new System.Drawing.Point(304, 335);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(293, 119);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.OnButtonStartClick);
            // 
            // FormQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 596);
            this.Controls.Add(this.panelIntro);
            this.Controls.Add(this.panelQuestion);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormQuiz";
            this.Text = "Chestionar Auto";
            this.Load += new System.EventHandler(this.FormQuiz_Load);
            this.panelQuestion.ResumeLayout(false);
            this.panelQuestion.PerformLayout();
            this.groupBoxAnswers.ResumeLayout(false);
            this.groupBoxAnswers.PerformLayout();
            this.panelIntro.ResumeLayout(false);
            this.panelIntro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelQuestion;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelQuestions;
        private System.Windows.Forms.GroupBox groupBoxAnswers;
        private System.Windows.Forms.RadioButton C;
        private System.Windows.Forms.RadioButton B;
        private System.Windows.Forms.Panel panelIntro;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.RadioButton A;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
    }
}

