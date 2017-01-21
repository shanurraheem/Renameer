namespace rename_File
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnTextGet = new System.Windows.Forms.Button();
            this.txtget = new System.Windows.Forms.TextBox();
            this.btnCrop = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBrowseInput = new System.Windows.Forms.Button();
            this.txtInputPath = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 535);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBrowseOutput);
            this.groupBox2.Controls.Add(this.txtOutputPath);
            this.groupBox2.Location = new System.Drawing.Point(10, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 49);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Set Output Location";
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Image = global::rename_File.Properties.Resources.Pictures_Folder_1;
            this.btnBrowseOutput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowseOutput.Location = new System.Drawing.Point(204, 17);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(84, 22);
            this.btnBrowseOutput.TabIndex = 1;
            this.btnBrowseOutput.Text = "Browse...";
            this.btnBrowseOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowseOutput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Enabled = false;
            this.txtOutputPath.Location = new System.Drawing.Point(6, 19);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(176, 20);
            this.txtOutputPath.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancle);
            this.groupBox1.Controls.Add(this.PicBox);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Enabled = false;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(10, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 390);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnCancle
            // 
            this.btnCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancle.Location = new System.Drawing.Point(105, 334);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(91, 30);
            this.btnCancle.TabIndex = 6;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancle.UseVisualStyleBackColor = true;
            // 
            // PicBox
            // 
            this.PicBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PicBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicBox.Location = new System.Drawing.Point(339, 18);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(369, 366);
            this.PicBox.TabIndex = 4;
            this.PicBox.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnRename);
            this.groupBox4.Controls.Add(this.btnTextGet);
            this.groupBox4.Controls.Add(this.txtget);
            this.groupBox4.Controls.Add(this.btnCrop);
            this.groupBox4.Controls.Add(this.btnShow);
            this.groupBox4.Location = new System.Drawing.Point(6, 87);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(327, 209);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Select Target Image";
            // 
            // btnRename
            // 
            this.btnRename.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRename.Image = global::rename_File.Properties.Resources.Rename_1;
            this.btnRename.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRename.Location = new System.Drawing.Point(71, 139);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(148, 48);
            this.btnRename.TabIndex = 5;
            this.btnRename.Text = "Rename";
            this.btnRename.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRename.UseVisualStyleBackColor = true;
            // 
            // btnTextGet
            // 
            this.btnTextGet.Image = global::rename_File.Properties.Resources.Generic_Text_1;
            this.btnTextGet.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTextGet.Location = new System.Drawing.Point(198, 87);
            this.btnTextGet.Name = "btnTextGet";
            this.btnTextGet.Size = new System.Drawing.Size(107, 41);
            this.btnTextGet.TabIndex = 4;
            this.btnTextGet.Text = "Get Text";
            this.btnTextGet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTextGet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTextGet.UseVisualStyleBackColor = true;
            this.btnTextGet.Click += new System.EventHandler(this.btnTextGet_Click);
            // 
            // txtget
            // 
            this.txtget.Location = new System.Drawing.Point(6, 92);
            this.txtget.Multiline = true;
            this.txtget.Name = "txtget";
            this.txtget.Size = new System.Drawing.Size(176, 30);
            this.txtget.TabIndex = 3;
            // 
            // btnCrop
            // 
            this.btnCrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrop.Image = global::rename_File.Properties.Resources.Crop;
            this.btnCrop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrop.Location = new System.Drawing.Point(163, 19);
            this.btnCrop.Name = "btnCrop";
            this.btnCrop.Size = new System.Drawing.Size(119, 48);
            this.btnCrop.TabIndex = 2;
            this.btnCrop.Text = "Crop";
            this.btnCrop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrop.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Image = global::rename_File.Properties.Resources.Full_Image_1;
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.Location = new System.Drawing.Point(16, 19);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(119, 48);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBrowseInput);
            this.groupBox3.Controls.Add(this.txtInputPath);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 49);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Target Image";
            // 
            // btnBrowseInput
            // 
            this.btnBrowseInput.Image = global::rename_File.Properties.Resources.Camera;
            this.btnBrowseInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowseInput.Location = new System.Drawing.Point(198, 17);
            this.btnBrowseInput.Name = "btnBrowseInput";
            this.btnBrowseInput.Size = new System.Drawing.Size(84, 22);
            this.btnBrowseInput.TabIndex = 1;
            this.btnBrowseInput.Text = "Browse...";
            this.btnBrowseInput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowseInput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrowseInput.UseVisualStyleBackColor = true;
            this.btnBrowseInput.Click += new System.EventHandler(this.btnBrowseInput_Click);
            // 
            // txtInputPath
            // 
            this.txtInputPath.Enabled = false;
            this.txtInputPath.Location = new System.Drawing.Point(6, 19);
            this.txtInputPath.Name = "txtInputPath";
            this.txtInputPath.Size = new System.Drawing.Size(176, 20);
            this.txtInputPath.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::rename_File.Properties.Resources.Untitled1;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(740, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(738, 536);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBrowseOutput;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnTextGet;
        private System.Windows.Forms.TextBox txtget;
        private System.Windows.Forms.Button btnCrop;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBrowseInput;
        private System.Windows.Forms.TextBox txtInputPath;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

