
namespace WinFormUI
{
    partial class frmCreateTodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateTodo));
            this.label1 = new System.Windows.Forms.Label();
            this.btnDaily = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnWeekly = new System.Windows.Forms.Button();
            this.btnMonthly = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Todo List";
            // 
            // btnDaily
            // 
            this.btnDaily.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDaily.BackColor = System.Drawing.SystemColors.Control;
            this.btnDaily.FlatAppearance.BorderSize = 0;
            this.btnDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaily.Image = ((System.Drawing.Image)(resources.GetObject("btnDaily.Image")));
            this.btnDaily.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDaily.Location = new System.Drawing.Point(379, 109);
            this.btnDaily.Name = "btnDaily";
            this.btnDaily.Size = new System.Drawing.Size(345, 75);
            this.btnDaily.TabIndex = 1;
            this.btnDaily.Text = " Daily Todo List\r\n";
            this.btnDaily.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Open recent";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(24, 109);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = " Search";
            this.txtSearch.Size = new System.Drawing.Size(317, 33);
            this.txtSearch.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(372, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Get started";
            // 
            // btnWeekly
            // 
            this.btnWeekly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWeekly.BackColor = System.Drawing.SystemColors.Control;
            this.btnWeekly.FlatAppearance.BorderSize = 0;
            this.btnWeekly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeekly.Image = ((System.Drawing.Image)(resources.GetObject("btnWeekly.Image")));
            this.btnWeekly.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWeekly.Location = new System.Drawing.Point(379, 199);
            this.btnWeekly.Name = "btnWeekly";
            this.btnWeekly.Size = new System.Drawing.Size(345, 75);
            this.btnWeekly.TabIndex = 5;
            this.btnWeekly.Text = "Weekly Todo List";
            this.btnWeekly.UseVisualStyleBackColor = false;
            // 
            // btnMonthly
            // 
            this.btnMonthly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMonthly.BackColor = System.Drawing.SystemColors.Control;
            this.btnMonthly.FlatAppearance.BorderSize = 0;
            this.btnMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthly.Image = ((System.Drawing.Image)(resources.GetObject("btnMonthly.Image")));
            this.btnMonthly.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonthly.Location = new System.Drawing.Point(379, 292);
            this.btnMonthly.Name = "btnMonthly";
            this.btnMonthly.Size = new System.Drawing.Size(345, 75);
            this.btnMonthly.TabIndex = 6;
            this.btnMonthly.Text = "Monthly Todo List";
            this.btnMonthly.UseVisualStyleBackColor = false;
            // 
            // frmCreateTodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(745, 521);
            this.Controls.Add(this.btnMonthly);
            this.Controls.Add(this.btnWeekly);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDaily);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCreateTodo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDaily;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnWeekly;
        private System.Windows.Forms.Button btnMonthly;
    }
}