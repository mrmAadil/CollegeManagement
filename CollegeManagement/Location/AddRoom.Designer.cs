namespace CollegeManagement.Location
{
    partial class AddRoom
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
            this.icnBtnAdd = new FontAwesome.Sharp.IconButton();
            this.txtNoRooms = new System.Windows.Forms.TextBox();
            this.txtBuildingName = new System.Windows.Forms.TextBox();
            this.lblBlock = new System.Windows.Forms.Label();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // icnBtnAdd
            // 
            this.icnBtnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnBtnAdd.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnBtnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.icnBtnAdd.IconColor = System.Drawing.Color.Black;
            this.icnBtnAdd.IconSize = 32;
            this.icnBtnAdd.Location = new System.Drawing.Point(418, 407);
            this.icnBtnAdd.Name = "icnBtnAdd";
            this.icnBtnAdd.Padding = new System.Windows.Forms.Padding(3);
            this.icnBtnAdd.Rotation = 0D;
            this.icnBtnAdd.Size = new System.Drawing.Size(181, 50);
            this.icnBtnAdd.TabIndex = 14;
            this.icnBtnAdd.Text = "Submit";
            this.icnBtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.icnBtnAdd.UseVisualStyleBackColor = true;
            // 
            // txtNoRooms
            // 
            this.txtNoRooms.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoRooms.Location = new System.Drawing.Point(482, 208);
            this.txtNoRooms.Multiline = true;
            this.txtNoRooms.Name = "txtNoRooms";
            this.txtNoRooms.Size = new System.Drawing.Size(433, 33);
            this.txtNoRooms.TabIndex = 13;
            // 
            // txtBuildingName
            // 
            this.txtBuildingName.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuildingName.Location = new System.Drawing.Point(482, 123);
            this.txtBuildingName.Multiline = true;
            this.txtBuildingName.Name = "txtBuildingName";
            this.txtBuildingName.Size = new System.Drawing.Size(433, 33);
            this.txtBuildingName.TabIndex = 12;
            // 
            // lblBlock
            // 
            this.lblBlock.AutoSize = true;
            this.lblBlock.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlock.Location = new System.Drawing.Point(242, 211);
            this.lblBlock.Name = "lblBlock";
            this.lblBlock.Size = new System.Drawing.Size(124, 23);
            this.lblBlock.TabIndex = 11;
            this.lblBlock.Text = "Room Block";
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomName.Location = new System.Drawing.Point(242, 134);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(126, 23);
            this.lblRoomName.TabIndex = 10;
            this.lblRoomName.Text = "Room Name";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(242, 290);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(116, 23);
            this.lblCategory.TabIndex = 15;
            this.lblCategory.Text = "Room Type";
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Items.AddRange(new object[] {
            "Lecture Hall",
            "Laboratory"});
            this.cmbRoomType.Location = new System.Drawing.Point(482, 290);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(230, 33);
            this.cmbRoomType.TabIndex = 18;
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1160, 642);
            this.Controls.Add(this.cmbRoomType);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.icnBtnAdd);
            this.Controls.Add(this.txtNoRooms);
            this.Controls.Add(this.txtBuildingName);
            this.Controls.Add(this.lblBlock);
            this.Controls.Add(this.lblRoomName);
            this.Name = "AddRoom";
            this.Text = "AddRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton icnBtnAdd;
        private System.Windows.Forms.TextBox txtNoRooms;
        private System.Windows.Forms.TextBox txtBuildingName;
        private System.Windows.Forms.Label lblBlock;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbRoomType;
    }
}