namespace WindowsFormsApplication1
{
    partial class frmQ1
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbYesNo = new System.Windows.Forms.GroupBox();
            this.gbHighLow = new System.Windows.Forms.GroupBox();
            this.rbHigh = new System.Windows.Forms.RadioButton();
            this.rbLow = new System.Windows.Forms.RadioButton();
            this.rbMod = new System.Windows.Forms.RadioButton();
            this.rbStable = new System.Windows.Forms.RadioButton();
            this.groupBox.SuspendLayout();
            this.gbYesNo.SuspendLayout();
            this.gbHighLow.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.gbYesNo);
            this.groupBox.Controls.Add(this.btnRead);
            this.groupBox.Controls.Add(this.lblQuestion);
            this.groupBox.Controls.Add(this.gbHighLow);
            this.groupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.Color.Black;
            this.groupBox.Location = new System.Drawing.Point(13, 15);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(896, 152);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Question 1";
            // 
            // btnRead
            // 
            this.btnRead.AccessibleDescription = "Read this question";
            this.btnRead.AccessibleName = "Button";
            this.btnRead.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.clipart_mb_speaker;
            this.btnRead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRead.Location = new System.Drawing.Point(800, 17);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(84, 84);
            this.btnRead.TabIndex = 5;
            this.btnRead.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRead.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(17, 39);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(559, 104);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "Have you missed any doses of your medication?";
            // 
            // rbNo
            // 
            this.rbNo.Location = new System.Drawing.Point(18, 99);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(176, 23);
            this.rbNo.TabIndex = 1;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbYes
            // 
            this.rbYes.Location = new System.Drawing.Point(18, 39);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(176, 23);
            this.rbYes.TabIndex = 0;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(764, 186);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(145, 42);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBack
            // 
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(20, 186);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(145, 42);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbYesNo
            // 
            this.gbYesNo.Controls.Add(this.rbYes);
            this.gbYesNo.Controls.Add(this.rbNo);
            this.gbYesNo.Location = new System.Drawing.Point(582, 0);
            this.gbYesNo.Name = "gbYesNo";
            this.gbYesNo.Size = new System.Drawing.Size(200, 152);
            this.gbYesNo.TabIndex = 6;
            this.gbYesNo.TabStop = false;
            this.gbYesNo.Text = "Answer";
            this.gbYesNo.Visible = false;
            // 
            // gbHighLow
            // 
            this.gbHighLow.Controls.Add(this.rbStable);
            this.gbHighLow.Controls.Add(this.rbMod);
            this.gbHighLow.Controls.Add(this.rbHigh);
            this.gbHighLow.Controls.Add(this.rbLow);
            this.gbHighLow.Location = new System.Drawing.Point(582, 0);
            this.gbHighLow.Name = "gbHighLow";
            this.gbHighLow.Size = new System.Drawing.Size(200, 152);
            this.gbHighLow.TabIndex = 7;
            this.gbHighLow.TabStop = false;
            this.gbHighLow.Text = "Answer";
            this.gbHighLow.Visible = false;
            // 
            // rbHigh
            // 
            this.rbHigh.Location = new System.Drawing.Point(18, 25);
            this.rbHigh.Name = "rbHigh";
            this.rbHigh.Size = new System.Drawing.Size(176, 23);
            this.rbHigh.TabIndex = 0;
            this.rbHigh.TabStop = true;
            this.rbHigh.Text = "High";
            this.rbHigh.UseVisualStyleBackColor = true;
            this.rbHigh.CheckedChanged += new System.EventHandler(this.rbHigh_CheckedChanged);
            // 
            // rbLow
            // 
            this.rbLow.Location = new System.Drawing.Point(18, 120);
            this.rbLow.Name = "rbLow";
            this.rbLow.Size = new System.Drawing.Size(176, 23);
            this.rbLow.TabIndex = 1;
            this.rbLow.TabStop = true;
            this.rbLow.Text = "Low";
            this.rbLow.UseVisualStyleBackColor = true;
            // 
            // rbMod
            // 
            this.rbMod.Location = new System.Drawing.Point(18, 54);
            this.rbMod.Name = "rbMod";
            this.rbMod.Size = new System.Drawing.Size(176, 23);
            this.rbMod.TabIndex = 2;
            this.rbMod.TabStop = true;
            this.rbMod.Text = "Moderate";
            this.rbMod.UseVisualStyleBackColor = true;
            // 
            // rbStable
            // 
            this.rbStable.Location = new System.Drawing.Point(18, 86);
            this.rbStable.Name = "rbStable";
            this.rbStable.Size = new System.Drawing.Size(176, 23);
            this.rbStable.TabIndex = 3;
            this.rbStable.TabStop = true;
            this.rbStable.Text = "Stable";
            this.rbStable.UseVisualStyleBackColor = true;
            // 
            // frmQ1
            // 
            this.AcceptButton = this.btnNext;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(921, 240);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.groupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQ1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HCV Questionnaire";
            this.groupBox.ResumeLayout(false);
            this.gbYesNo.ResumeLayout(false);
            this.gbHighLow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.GroupBox gbYesNo;
        private System.Windows.Forms.GroupBox gbHighLow;
        private System.Windows.Forms.RadioButton rbHigh;
        private System.Windows.Forms.RadioButton rbLow;
        private System.Windows.Forms.RadioButton rbStable;
        private System.Windows.Forms.RadioButton rbMod;

    }
}

