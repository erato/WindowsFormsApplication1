namespace WindowsFormsApplication1
{
    partial class frmCESD
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
            this.gbQuestionNumber = new System.Windows.Forms.GroupBox();
            this.gbCESD = new System.Windows.Forms.GroupBox();
            this.rbOccasionally = new System.Windows.Forms.RadioButton();
            this.rbSome = new System.Windows.Forms.RadioButton();
            this.rbRare = new System.Windows.Forms.RadioButton();
            this.rbMost = new System.Windows.Forms.RadioButton();
            this.btnRead = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gbQuestionNumber.SuspendLayout();
            this.gbCESD.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbQuestionNumber
            // 
            this.gbQuestionNumber.Controls.Add(this.gbCESD);
            this.gbQuestionNumber.Controls.Add(this.btnRead);
            this.gbQuestionNumber.Controls.Add(this.lblQuestion);
            this.gbQuestionNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbQuestionNumber.ForeColor = System.Drawing.Color.Black;
            this.gbQuestionNumber.Location = new System.Drawing.Point(7, 46);
            this.gbQuestionNumber.Name = "gbQuestionNumber";
            this.gbQuestionNumber.Size = new System.Drawing.Size(906, 152);
            this.gbQuestionNumber.TabIndex = 5;
            this.gbQuestionNumber.TabStop = false;
            this.gbQuestionNumber.Text = "Question 1";
            // 
            // gbCESD
            // 
            this.gbCESD.Controls.Add(this.rbOccasionally);
            this.gbCESD.Controls.Add(this.rbSome);
            this.gbCESD.Controls.Add(this.rbRare);
            this.gbCESD.Controls.Add(this.rbMost);
            this.gbCESD.Location = new System.Drawing.Point(410, 0);
            this.gbCESD.Name = "gbCESD";
            this.gbCESD.Size = new System.Drawing.Size(389, 152);
            this.gbCESD.TabIndex = 7;
            this.gbCESD.TabStop = false;
            this.gbCESD.Text = "Answer";
            // 
            // rbOccasionally
            // 
            this.rbOccasionally.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOccasionally.Location = new System.Drawing.Point(18, 76);
            this.rbOccasionally.Name = "rbOccasionally";
            this.rbOccasionally.Size = new System.Drawing.Size(365, 39);
            this.rbOccasionally.TabIndex = 3;
            this.rbOccasionally.TabStop = true;
            this.rbOccasionally.Text = "Occasionally or a Moderate Amount of Time (3-4 Days)";
            this.rbOccasionally.UseVisualStyleBackColor = true;
            // 
            // rbSome
            // 
            this.rbSome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSome.Location = new System.Drawing.Point(18, 50);
            this.rbSome.Name = "rbSome";
            this.rbSome.Size = new System.Drawing.Size(365, 23);
            this.rbSome.TabIndex = 2;
            this.rbSome.TabStop = true;
            this.rbSome.Text = "Some or a Little of the time (1-2 Days)";
            this.rbSome.UseVisualStyleBackColor = true;
            // 
            // rbRare
            // 
            this.rbRare.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRare.Location = new System.Drawing.Point(18, 24);
            this.rbRare.Name = "rbRare";
            this.rbRare.Size = new System.Drawing.Size(365, 23);
            this.rbRare.TabIndex = 0;
            this.rbRare.TabStop = true;
            this.rbRare.Text = "Rarely or None of the Time (Less than 1 day)";
            this.rbRare.UseVisualStyleBackColor = true;
            // 
            // rbMost
            // 
            this.rbMost.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMost.Location = new System.Drawing.Point(18, 118);
            this.rbMost.Name = "rbMost";
            this.rbMost.Size = new System.Drawing.Size(365, 23);
            this.rbMost.TabIndex = 1;
            this.rbMost.TabStop = true;
            this.rbMost.Text = "Most or All of the time (5-7 days)";
            this.rbMost.UseVisualStyleBackColor = true;
            // 
            // btnRead
            // 
            this.btnRead.AccessibleDescription = "Read this question";
            this.btnRead.AccessibleName = "Button";
            this.btnRead.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.clipart_mb_speaker;
            this.btnRead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRead.Location = new System.Drawing.Point(815, 17);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(84, 84);
            this.btnRead.TabIndex = 5;
            this.btnRead.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(17, 25);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(387, 118);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "Have you missed any doses of your medication?";
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(19, 209);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(145, 42);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(763, 209);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(145, 42);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(894, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "Please select the answer to the statement that best describes how often you felt " +
    "or behaved this way DURING THE PAST WEEK.";
            // 
            // frmCESD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(921, 260);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbQuestionNumber);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCESD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CES-D SCALE";
            this.gbQuestionNumber.ResumeLayout(false);
            this.gbCESD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbQuestionNumber;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.GroupBox gbCESD;
        private System.Windows.Forms.RadioButton rbOccasionally;
        private System.Windows.Forms.RadioButton rbSome;
        private System.Windows.Forms.RadioButton rbRare;
        private System.Windows.Forms.RadioButton rbMost;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label2;
    }
}