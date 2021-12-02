
namespace WoodStockApp
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
            this.dvgStocklist = new System.Windows.Forms.DataGridView();
            this.saveBtn = new System.Windows.Forms.Button();
            this.BrowseBtn = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveXml = new System.Windows.Forms.Button();
            this.btnStyle = new System.Windows.Forms.Button();
            this.btnStyle1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgStocklist)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgStocklist
            // 
            this.dvgStocklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgStocklist.Location = new System.Drawing.Point(31, 104);
            this.dvgStocklist.Name = "dvgStocklist";
            this.dvgStocklist.Size = new System.Drawing.Size(712, 334);
            this.dvgStocklist.TabIndex = 0;
            this.dvgStocklist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgStocklist_CellContentClick);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(657, 63);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(86, 23);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save (CSV)";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Location = new System.Drawing.Point(532, 63);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(87, 23);
            this.BrowseBtn.TabIndex = 1;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.UseVisualStyleBackColor = true;
            this.BrowseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(136, 63);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(369, 20);
            this.txtFilePath.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "CSV Files (*.csv)|*.csv";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "saveFileDialog";
            this.saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            // 
            // btnSaveXml
            // 
            this.btnSaveXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveXml.Location = new System.Drawing.Point(657, 24);
            this.btnSaveXml.Name = "btnSaveXml";
            this.btnSaveXml.Size = new System.Drawing.Size(86, 23);
            this.btnSaveXml.TabIndex = 3;
            this.btnSaveXml.Text = "Save (XML)";
            this.btnSaveXml.UseVisualStyleBackColor = true;
            this.btnSaveXml.Click += new System.EventHandler(this.btnSaveXml_Click);
            // 
            // btnStyle
            // 
            this.btnStyle.Location = new System.Drawing.Point(31, 24);
            this.btnStyle.Name = "btnStyle";
            this.btnStyle.Size = new System.Drawing.Size(87, 23);
            this.btnStyle.TabIndex = 4;
            this.btnStyle.Text = "Style";
            this.btnStyle.UseVisualStyleBackColor = true;
            this.btnStyle.Click += new System.EventHandler(this.btnStyle_Click);
            // 
            // btnStyle1
            // 
            this.btnStyle1.Location = new System.Drawing.Point(31, 60);
            this.btnStyle1.Name = "btnStyle1";
            this.btnStyle1.Size = new System.Drawing.Size(87, 23);
            this.btnStyle1.TabIndex = 5;
            this.btnStyle1.Text = "Style1";
            this.btnStyle1.UseVisualStyleBackColor = true;
            this.btnStyle1.Click += new System.EventHandler(this.btnStyle1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStyle1);
            this.Controls.Add(this.btnStyle);
            this.Controls.Add(this.btnSaveXml);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.BrowseBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.dvgStocklist);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dvgStocklist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgStocklist;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button BrowseBtn;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnSaveXml;
        private System.Windows.Forms.Button btnStyle;
        private System.Windows.Forms.Button btnStyle1;
    }
}

