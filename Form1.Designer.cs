namespace Activity_Eight
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CarbsEntered = new System.Windows.Forms.TextBox();
            this.FatEntered = new System.Windows.Forms.TextBox();
            this.calculateFat = new System.Windows.Forms.Button();
            this.calculateCarbs = new System.Windows.Forms.Button();
            this.displayFat = new System.Windows.Forms.Label();
            this.displayCarbs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Grams of Fat: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Amount Of Carbohydrates: \r\n";
            // 
            // CarbsEntered
            // 
            this.CarbsEntered.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarbsEntered.Location = new System.Drawing.Point(256, 154);
            this.CarbsEntered.Name = "CarbsEntered";
            this.CarbsEntered.Size = new System.Drawing.Size(100, 22);
            this.CarbsEntered.TabIndex = 2;
            // 
            // FatEntered
            // 
            this.FatEntered.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FatEntered.Location = new System.Drawing.Point(256, 45);
            this.FatEntered.Name = "FatEntered";
            this.FatEntered.Size = new System.Drawing.Size(100, 22);
            this.FatEntered.TabIndex = 3;
            // 
            // calculateFat
            // 
            this.calculateFat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateFat.Location = new System.Drawing.Point(376, 43);
            this.calculateFat.Name = "calculateFat";
            this.calculateFat.Size = new System.Drawing.Size(75, 23);
            this.calculateFat.TabIndex = 4;
            this.calculateFat.Text = "Calculate";
            this.calculateFat.UseVisualStyleBackColor = true;
            this.calculateFat.Click += new System.EventHandler(this.Button1_Click);
            // 
            // calculateCarbs
            // 
            this.calculateCarbs.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateCarbs.Location = new System.Drawing.Point(376, 152);
            this.calculateCarbs.Name = "calculateCarbs";
            this.calculateCarbs.Size = new System.Drawing.Size(75, 23);
            this.calculateCarbs.TabIndex = 5;
            this.calculateCarbs.Text = "Calculate";
            this.calculateCarbs.UseVisualStyleBackColor = true;
            this.calculateCarbs.Click += new System.EventHandler(this.calculateCarbs_Click);
            // 
            // displayFat
            // 
            this.displayFat.AutoSize = true;
            this.displayFat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayFat.Location = new System.Drawing.Point(97, 84);
            this.displayFat.Name = "displayFat";
            this.displayFat.Size = new System.Drawing.Size(0, 19);
            this.displayFat.TabIndex = 6;
            // 
            // displayCarbs
            // 
            this.displayCarbs.AutoSize = true;
            this.displayCarbs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayCarbs.Location = new System.Drawing.Point(97, 198);
            this.displayCarbs.Name = "displayCarbs";
            this.displayCarbs.Size = new System.Drawing.Size(0, 19);
            this.displayCarbs.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.Controls.Add(this.displayCarbs);
            this.Controls.Add(this.displayFat);
            this.Controls.Add(this.calculateCarbs);
            this.Controls.Add(this.calculateFat);
            this.Controls.Add(this.FatEntered);
            this.Controls.Add(this.CarbsEntered);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calories Calulator ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CarbsEntered;
        private System.Windows.Forms.TextBox FatEntered;
        private System.Windows.Forms.Button calculateFat;
        private System.Windows.Forms.Button calculateCarbs;
        private System.Windows.Forms.Label displayFat;
        private System.Windows.Forms.Label displayCarbs;
    }
}

