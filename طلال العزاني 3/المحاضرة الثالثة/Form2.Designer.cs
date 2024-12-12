namespace المحاضرة_الثالثة
{
    partial class Form2
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
            this.btnred = new System.Windows.Forms.Button();
            this.btngreen = new System.Windows.Forms.Button();
            this.btnyellow = new System.Windows.Forms.Button();
            this.device1 = new System.Windows.Forms.Label();
            this.device2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnred
            // 
            this.btnred.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnred.Location = new System.Drawing.Point(30, 102);
            this.btnred.Name = "btnred";
            this.btnred.Size = new System.Drawing.Size(125, 38);
            this.btnred.TabIndex = 0;
            this.btnred.Text = "احمر";
            this.btnred.UseVisualStyleBackColor = true;
            this.btnred.Click += new System.EventHandler(this.traingforsender);
            // 
            // btngreen
            // 
            this.btngreen.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngreen.Location = new System.Drawing.Point(201, 102);
            this.btngreen.Name = "btngreen";
            this.btngreen.Size = new System.Drawing.Size(125, 38);
            this.btngreen.TabIndex = 1;
            this.btngreen.Text = "اخضر";
            this.btngreen.UseVisualStyleBackColor = true;
            this.btngreen.Click += new System.EventHandler(this.traingforsender);
            // 
            // btnyellow
            // 
            this.btnyellow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyellow.Location = new System.Drawing.Point(387, 102);
            this.btnyellow.Name = "btnyellow";
            this.btnyellow.Size = new System.Drawing.Size(125, 38);
            this.btnyellow.TabIndex = 2;
            this.btnyellow.Text = "اصفر";
            this.btnyellow.UseVisualStyleBackColor = true;
            this.btnyellow.Click += new System.EventHandler(this.traingforsender);
            // 
            // device1
            // 
            this.device1.AutoSize = true;
            this.device1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.device1.Location = new System.Drawing.Point(104, 35);
            this.device1.Name = "device1";
            this.device1.Size = new System.Drawing.Size(86, 29);
            this.device1.TabIndex = 3;
            this.device1.Text = "جهاز 1";
            this.device1.Click += new System.EventHandler(this.traingforsender);
            // 
            // device2
            // 
            this.device2.AutoSize = true;
            this.device2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.device2.Location = new System.Drawing.Point(395, 35);
            this.device2.Name = "device2";
            this.device2.Size = new System.Drawing.Size(86, 29);
            this.device2.TabIndex = 4;
            this.device2.Text = "جهاز 2";
            this.device2.Click += new System.EventHandler(this.traingforsender);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 367);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.device2);
            this.Controls.Add(this.device1);
            this.Controls.Add(this.btnyellow);
            this.Controls.Add(this.btngreen);
            this.Controls.Add(this.btnred);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnred;
        private System.Windows.Forms.Button btngreen;
        private System.Windows.Forms.Button btnyellow;
        private System.Windows.Forms.Label device1;
        private System.Windows.Forms.Label device2;
        private System.Windows.Forms.Button button1;
    }
}