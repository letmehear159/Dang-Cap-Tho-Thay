namespace Thợ_Thầy
{
    partial class Home
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
            this.FINDWORK = new System.Windows.Forms.TabControl();
            this.USEr = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Work = new System.Windows.Forms.TabPage();
            this.FINDWORK.SuspendLayout();
            this.USEr.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FINDWORK
            // 
            this.FINDWORK.Controls.Add(this.USEr);
            this.FINDWORK.Controls.Add(this.Work);
            this.FINDWORK.Cursor = System.Windows.Forms.Cursors.Default;
            this.FINDWORK.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FINDWORK.Location = new System.Drawing.Point(12, 5);
            this.FINDWORK.Name = "FINDWORK";
            this.FINDWORK.SelectedIndex = 0;
            this.FINDWORK.Size = new System.Drawing.Size(759, 544);
            this.FINDWORK.TabIndex = 0;
            // 
            // USEr
            // 
            this.USEr.Controls.Add(this.button5);
            this.USEr.Controls.Add(this.tableLayoutPanel1);
            this.USEr.Controls.Add(this.button1);
            this.USEr.Controls.Add(this.dataGridView1);
            this.USEr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USEr.Location = new System.Drawing.Point(4, 40);
            this.USEr.Name = "USEr";
            this.USEr.Padding = new System.Windows.Forms.Padding(3);
            this.USEr.Size = new System.Drawing.Size(751, 500);
            this.USEr.TabIndex = 0;
            this.USEr.Text = " Worker List";
            this.USEr.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(262, 304);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(240, 78);
            this.button5.TabIndex = 6;
            this.button5.Text = "Adjust Information";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.21881F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.78119F));
            this.tableLayoutPanel1.Controls.Add(this.button4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(489, 244);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(184, 165);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(301, 52);
            this.button4.TabIndex = 10;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(184, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(301, 52);
            this.button3.TabIndex = 9;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(301, 52);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 78);
            this.button1.TabIndex = 4;
            this.button1.Text = "Worker\'s Detail Information";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(508, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(636, 418);
            this.dataGridView1.TabIndex = 0;
            // 
            // Work
            // 
            this.Work.Location = new System.Drawing.Point(4, 40);
            this.Work.Name = "Work";
            this.Work.Padding = new System.Windows.Forms.Padding(3);
            this.Work.Size = new System.Drawing.Size(751, 500);
            this.Work.TabIndex = 1;
            this.Work.Text = "Job List";
            this.Work.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 564);
            this.Controls.Add(this.FINDWORK);
            this.Name = "Home";
            this.Text = "Form1";
            this.FINDWORK.ResumeLayout(false);
            this.USEr.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl FINDWORK;
        private System.Windows.Forms.TabPage USEr;
        private System.Windows.Forms.TabPage Work;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
    }
}

