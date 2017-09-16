namespace WinFormCopyFiles
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txbFrom = new System.Windows.Forms.TextBox();
            this.txbTo = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpModified = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtpModifiedTime = new System.Windows.Forms.DateTimePicker();
            this.btnFromDialog = new System.Windows.Forms.Button();
            this.btnToDialog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbFrom
            // 
            this.txbFrom.Location = new System.Drawing.Point(57, 50);
            this.txbFrom.Name = "txbFrom";
            this.txbFrom.Size = new System.Drawing.Size(340, 20);
            this.txbFrom.TabIndex = 0;
            this.txbFrom.Click += new System.EventHandler(this.txbFrom_Click);
            // 
            // txbTo
            // 
            this.txbTo.Location = new System.Drawing.Point(57, 82);
            this.txbTo.Name = "txbTo";
            this.txbTo.Size = new System.Drawing.Size(340, 20);
            this.txbTo.TabIndex = 1;
            this.txbTo.Click += new System.EventHandler(this.txbTo_Click);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(13, 53);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(30, 13);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(13, 85);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 13);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "To";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(318, 169);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(103, 33);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Copy files and directories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Where modified date bigger or equal than";
            // 
            // dtpModified
            // 
            this.dtpModified.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpModified.Location = new System.Drawing.Point(221, 123);
            this.dtpModified.Name = "dtpModified";
            this.dtpModified.Size = new System.Drawing.Size(121, 20);
            this.dtpModified.TabIndex = 16;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dtpModifiedTime
            // 
            this.dtpModifiedTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpModifiedTime.Location = new System.Drawing.Point(348, 123);
            this.dtpModifiedTime.Name = "dtpModifiedTime";
            this.dtpModifiedTime.ShowUpDown = true;
            this.dtpModifiedTime.Size = new System.Drawing.Size(73, 20);
            this.dtpModifiedTime.TabIndex = 17;
            // 
            // btnFromDialog
            // 
            this.btnFromDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFromDialog.Location = new System.Drawing.Point(397, 50);
            this.btnFromDialog.Name = "btnFromDialog";
            this.btnFromDialog.Size = new System.Drawing.Size(24, 20);
            this.btnFromDialog.TabIndex = 18;
            this.btnFromDialog.Text = "...";
            this.btnFromDialog.UseVisualStyleBackColor = true;
            this.btnFromDialog.Click += new System.EventHandler(this.btnFromDialog_Click);
            // 
            // btnToDialog
            // 
            this.btnToDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToDialog.Location = new System.Drawing.Point(397, 82);
            this.btnToDialog.Name = "btnToDialog";
            this.btnToDialog.Size = new System.Drawing.Size(24, 20);
            this.btnToDialog.TabIndex = 19;
            this.btnToDialog.Text = "...";
            this.btnToDialog.UseVisualStyleBackColor = true;
            this.btnToDialog.Click += new System.EventHandler(this.btnToDialog_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 243);
            this.Controls.Add(this.btnToDialog);
            this.Controls.Add(this.btnFromDialog);
            this.Controls.Add(this.dtpModifiedTime);
            this.Controls.Add(this.dtpModified);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.txbTo);
            this.Controls.Add(this.txbFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Copy Files";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txbFrom;
        private System.Windows.Forms.TextBox txbTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpModified;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dtpModifiedTime;
        private System.Windows.Forms.Button btnToDialog;
        private System.Windows.Forms.Button btnFromDialog;
    }
}

