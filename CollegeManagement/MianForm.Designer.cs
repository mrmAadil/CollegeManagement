namespace CollegeManagement
{
    partial class MianForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pannelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pannelChild = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconBtnSub = new FontAwesome.Sharp.IconButton();
            this.icnBtnStat = new FontAwesome.Sharp.IconButton();
            this.icnBtnTags = new FontAwesome.Sharp.IconButton();
            this.icnBtnWrk = new FontAwesome.Sharp.IconButton();
            this.icnBtnStudent = new FontAwesome.Sharp.IconButton();
            this.icnBtnLec = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.pannelTitle.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.pannelTitle);
            this.panel1.Controls.Add(this.pannelChild);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 609);
            this.panel1.TabIndex = 0;
            // 
            // pannelTitle
            // 
            this.pannelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pannelTitle.Controls.Add(this.lblTitle);
            this.pannelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pannelTitle.Location = new System.Drawing.Point(161, 0);
            this.pannelTitle.Margin = new System.Windows.Forms.Padding(2);
            this.pannelTitle.Name = "pannelTitle";
            this.pannelTitle.Size = new System.Drawing.Size(886, 46);
            this.pannelTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(17, 13);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 20);
            this.lblTitle.TabIndex = 0;
            // 
            // pannelChild
            // 
            this.pannelChild.AutoSize = true;
            this.pannelChild.Location = new System.Drawing.Point(161, 46);
            this.pannelChild.Margin = new System.Windows.Forms.Padding(2);
            this.pannelChild.Name = "pannelChild";
            this.pannelChild.Size = new System.Drawing.Size(884, 560);
            this.pannelChild.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.icnBtnStat);
            this.panel2.Controls.Add(this.icnBtnTags);
            this.panel2.Controls.Add(this.icnBtnWrk);
            this.panel2.Controls.Add(this.icnBtnStudent);
            this.panel2.Controls.Add(this.iconBtnSub);
            this.panel2.Controls.Add(this.icnBtnLec);
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 609);
            this.panel2.TabIndex = 0;
            // 
            // iconBtnSub
            // 
            this.iconBtnSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnSub.FlatAppearance.BorderSize = 0;
            this.iconBtnSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnSub.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconBtnSub.ForeColor = System.Drawing.SystemColors.Control;
            this.iconBtnSub.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconBtnSub.IconColor = System.Drawing.Color.White;
            this.iconBtnSub.IconSize = 32;
            this.iconBtnSub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnSub.Location = new System.Drawing.Point(0, 92);
            this.iconBtnSub.Margin = new System.Windows.Forms.Padding(2);
            this.iconBtnSub.Name = "iconBtnSub";
            this.iconBtnSub.Rotation = 0D;
            this.iconBtnSub.Size = new System.Drawing.Size(161, 46);
            this.iconBtnSub.TabIndex = 2;
            this.iconBtnSub.Text = "Subjects";
            this.iconBtnSub.UseVisualStyleBackColor = true;
            this.iconBtnSub.Click += new System.EventHandler(this.iconBtnSub_Click);
            // 
            // icnBtnStat
            // 
            this.icnBtnStat.Dock = System.Windows.Forms.DockStyle.Top;
            this.icnBtnStat.FlatAppearance.BorderSize = 0;
            this.icnBtnStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnBtnStat.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnBtnStat.ForeColor = System.Drawing.SystemColors.Control;
            this.icnBtnStat.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.icnBtnStat.IconColor = System.Drawing.Color.White;
            this.icnBtnStat.IconSize = 32;
            this.icnBtnStat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnStat.Location = new System.Drawing.Point(0, 276);
            this.icnBtnStat.Margin = new System.Windows.Forms.Padding(2);
            this.icnBtnStat.Name = "icnBtnStat";
            this.icnBtnStat.Rotation = 0D;
            this.icnBtnStat.Size = new System.Drawing.Size(161, 46);
            this.icnBtnStat.TabIndex = 5;
            this.icnBtnStat.Text = "Statistics";
            this.icnBtnStat.UseVisualStyleBackColor = true;
            this.icnBtnStat.Click += new System.EventHandler(this.icnBtnStat_Click);
            // 
            // icnBtnTags
            // 
            this.icnBtnTags.Dock = System.Windows.Forms.DockStyle.Top;
            this.icnBtnTags.FlatAppearance.BorderSize = 0;
            this.icnBtnTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnBtnTags.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnBtnTags.ForeColor = System.Drawing.SystemColors.Control;
            this.icnBtnTags.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.icnBtnTags.IconColor = System.Drawing.Color.White;
            this.icnBtnTags.IconSize = 32;
            this.icnBtnTags.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnTags.Location = new System.Drawing.Point(0, 230);
            this.icnBtnTags.Margin = new System.Windows.Forms.Padding(2);
            this.icnBtnTags.Name = "icnBtnTags";
            this.icnBtnTags.Rotation = 0D;
            this.icnBtnTags.Size = new System.Drawing.Size(161, 46);
            this.icnBtnTags.TabIndex = 4;
            this.icnBtnTags.Text = "Tags";
            this.icnBtnTags.UseVisualStyleBackColor = true;
            this.icnBtnTags.Click += new System.EventHandler(this.icnBtnTags_Click);
            // 
            // icnBtnWrk
            // 
            this.icnBtnWrk.Dock = System.Windows.Forms.DockStyle.Top;
            this.icnBtnWrk.FlatAppearance.BorderSize = 0;
            this.icnBtnWrk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnBtnWrk.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnBtnWrk.ForeColor = System.Drawing.SystemColors.Control;
            this.icnBtnWrk.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.icnBtnWrk.IconColor = System.Drawing.Color.White;
            this.icnBtnWrk.IconSize = 32;
            this.icnBtnWrk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnWrk.Location = new System.Drawing.Point(0, 184);
            this.icnBtnWrk.Margin = new System.Windows.Forms.Padding(2);
            this.icnBtnWrk.Name = "icnBtnWrk";
            this.icnBtnWrk.Rotation = 0D;
            this.icnBtnWrk.Size = new System.Drawing.Size(161, 46);
            this.icnBtnWrk.TabIndex = 3;
            this.icnBtnWrk.Text = "Workind Hours";
            this.icnBtnWrk.UseVisualStyleBackColor = true;
            this.icnBtnWrk.Click += new System.EventHandler(this.icnBtnWrk_Click);
            // 
            // icnBtnStudent
            // 
            this.icnBtnStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.icnBtnStudent.FlatAppearance.BorderSize = 0;
            this.icnBtnStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnBtnStudent.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnBtnStudent.ForeColor = System.Drawing.SystemColors.Control;
            this.icnBtnStudent.IconChar = FontAwesome.Sharp.IconChar.User;
            this.icnBtnStudent.IconColor = System.Drawing.Color.White;
            this.icnBtnStudent.IconSize = 32;
            this.icnBtnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnStudent.Location = new System.Drawing.Point(0, 138);
            this.icnBtnStudent.Margin = new System.Windows.Forms.Padding(2);
            this.icnBtnStudent.Name = "icnBtnStudent";
            this.icnBtnStudent.Rotation = 0D;
            this.icnBtnStudent.Size = new System.Drawing.Size(161, 46);
            this.icnBtnStudent.TabIndex = 2;
            this.icnBtnStudent.Text = "Students";
            this.icnBtnStudent.UseVisualStyleBackColor = true;
            this.icnBtnStudent.Click += new System.EventHandler(this.icnBtnStudent_Click);
            // 
            // icnBtnLec
            // 
            this.icnBtnLec.Dock = System.Windows.Forms.DockStyle.Top;
            this.icnBtnLec.FlatAppearance.BorderSize = 0;
            this.icnBtnLec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnBtnLec.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnBtnLec.ForeColor = System.Drawing.SystemColors.Control;
            this.icnBtnLec.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.icnBtnLec.IconColor = System.Drawing.Color.White;
            this.icnBtnLec.IconSize = 32;
            this.icnBtnLec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnLec.Location = new System.Drawing.Point(0, 46);
            this.icnBtnLec.Margin = new System.Windows.Forms.Padding(2);
            this.icnBtnLec.Name = "icnBtnLec";
            this.icnBtnLec.Rotation = 0D;
            this.icnBtnLec.Size = new System.Drawing.Size(161, 46);
            this.icnBtnLec.TabIndex = 1;
            this.icnBtnLec.Text = "Lecturers";
            this.icnBtnLec.UseVisualStyleBackColor = true;
            this.icnBtnLec.Click += new System.EventHandler(this.icnBtnLec_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Dashcube;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(161, 46);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Dashboard";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // MianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 609);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MianForm";
            this.Text = "AddYearSemester";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pannelTitle.ResumeLayout(false);
            this.pannelTitle.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton icnBtnStat;
        private FontAwesome.Sharp.IconButton icnBtnTags;
        private FontAwesome.Sharp.IconButton icnBtnWrk;
        private FontAwesome.Sharp.IconButton icnBtnStudent;
        private FontAwesome.Sharp.IconButton icnBtnLec;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel pannelChild;
        private System.Windows.Forms.Panel pannelTitle;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconButton iconBtnSub;
    }
}