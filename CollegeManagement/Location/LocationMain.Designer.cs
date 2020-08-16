namespace CollegeManagement.Location
{
    partial class LocationMain
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.icnBtnViewRoom = new FontAwesome.Sharp.IconButton();
            this.icnBtnViewBuilding = new FontAwesome.Sharp.IconButton();
            this.icnBtnAddRoom = new FontAwesome.Sharp.IconButton();
            this.icnBtnAddBuild = new FontAwesome.Sharp.IconButton();
            this.panelLocationChild = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.Teal;
            this.menuPanel.Controls.Add(this.icnBtnViewRoom);
            this.menuPanel.Controls.Add(this.icnBtnViewBuilding);
            this.menuPanel.Controls.Add(this.icnBtnAddRoom);
            this.menuPanel.Controls.Add(this.icnBtnAddBuild);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1192, 51);
            this.menuPanel.TabIndex = 0;
            // 
            // icnBtnViewRoom
            // 
            this.icnBtnViewRoom.FlatAppearance.BorderSize = 0;
            this.icnBtnViewRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnBtnViewRoom.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnBtnViewRoom.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnBtnViewRoom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.icnBtnViewRoom.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icnBtnViewRoom.IconColor = System.Drawing.Color.Black;
            this.icnBtnViewRoom.IconSize = 16;
            this.icnBtnViewRoom.Location = new System.Drawing.Point(788, 6);
            this.icnBtnViewRoom.Name = "icnBtnViewRoom";
            this.icnBtnViewRoom.Rotation = 0D;
            this.icnBtnViewRoom.Size = new System.Drawing.Size(183, 42);
            this.icnBtnViewRoom.TabIndex = 3;
            this.icnBtnViewRoom.Text = "View Rooms";
            this.icnBtnViewRoom.UseVisualStyleBackColor = true;
            this.icnBtnViewRoom.Click += new System.EventHandler(this.icnBtnViewRoom_Click);
            // 
            // icnBtnViewBuilding
            // 
            this.icnBtnViewBuilding.FlatAppearance.BorderSize = 0;
            this.icnBtnViewBuilding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnBtnViewBuilding.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnBtnViewBuilding.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnBtnViewBuilding.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.icnBtnViewBuilding.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icnBtnViewBuilding.IconColor = System.Drawing.Color.Black;
            this.icnBtnViewBuilding.IconSize = 16;
            this.icnBtnViewBuilding.Location = new System.Drawing.Point(599, 6);
            this.icnBtnViewBuilding.Name = "icnBtnViewBuilding";
            this.icnBtnViewBuilding.Rotation = 0D;
            this.icnBtnViewBuilding.Size = new System.Drawing.Size(183, 42);
            this.icnBtnViewBuilding.TabIndex = 2;
            this.icnBtnViewBuilding.Text = "View Buildings";
            this.icnBtnViewBuilding.UseVisualStyleBackColor = true;
            this.icnBtnViewBuilding.Click += new System.EventHandler(this.icnBtnViewBuilding_Click);
            // 
            // icnBtnAddRoom
            // 
            this.icnBtnAddRoom.FlatAppearance.BorderSize = 0;
            this.icnBtnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnBtnAddRoom.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnBtnAddRoom.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnBtnAddRoom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.icnBtnAddRoom.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icnBtnAddRoom.IconColor = System.Drawing.Color.Black;
            this.icnBtnAddRoom.IconSize = 16;
            this.icnBtnAddRoom.Location = new System.Drawing.Point(410, 3);
            this.icnBtnAddRoom.Name = "icnBtnAddRoom";
            this.icnBtnAddRoom.Rotation = 0D;
            this.icnBtnAddRoom.Size = new System.Drawing.Size(183, 45);
            this.icnBtnAddRoom.TabIndex = 1;
            this.icnBtnAddRoom.Text = "Add New Room";
            this.icnBtnAddRoom.UseVisualStyleBackColor = true;
            this.icnBtnAddRoom.Click += new System.EventHandler(this.icnBtnAddRoom_Click);
            // 
            // icnBtnAddBuild
            // 
            this.icnBtnAddBuild.FlatAppearance.BorderSize = 0;
            this.icnBtnAddBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnBtnAddBuild.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnBtnAddBuild.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnBtnAddBuild.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.icnBtnAddBuild.IconChar = FontAwesome.Sharp.IconChar.None;
            this.icnBtnAddBuild.IconColor = System.Drawing.Color.WhiteSmoke;
            this.icnBtnAddBuild.IconSize = 16;
            this.icnBtnAddBuild.Location = new System.Drawing.Point(221, 4);
            this.icnBtnAddBuild.Name = "icnBtnAddBuild";
            this.icnBtnAddBuild.Rotation = 0D;
            this.icnBtnAddBuild.Size = new System.Drawing.Size(183, 44);
            this.icnBtnAddBuild.TabIndex = 0;
            this.icnBtnAddBuild.Text = "Add New Building";
            this.icnBtnAddBuild.UseVisualStyleBackColor = true;
            this.icnBtnAddBuild.Click += new System.EventHandler(this.icnBtnAddBuild_Click);
            // 
            // panelLocationChild
            // 
            this.panelLocationChild.BackColor = System.Drawing.Color.White;
            this.panelLocationChild.Location = new System.Drawing.Point(0, 54);
            this.panelLocationChild.Name = "panelLocationChild";
            this.panelLocationChild.Size = new System.Drawing.Size(1192, 710);
            this.panelLocationChild.TabIndex = 1;
            // 
            // LocationMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 703);
            this.Controls.Add(this.panelLocationChild);
            this.Controls.Add(this.menuPanel);
            this.Name = "LocationMain";
            this.Text = "LocationMain";
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private FontAwesome.Sharp.IconButton icnBtnAddBuild;
        private FontAwesome.Sharp.IconButton icnBtnViewRoom;
        private FontAwesome.Sharp.IconButton icnBtnViewBuilding;
        private FontAwesome.Sharp.IconButton icnBtnAddRoom;
        private System.Windows.Forms.Panel panelLocationChild;
    }
}