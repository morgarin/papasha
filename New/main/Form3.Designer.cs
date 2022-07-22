
namespace main
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.Increment = new System.Windows.Forms.Button();
            this.Decrement = new System.Windows.Forms.Button();
            this.Increase = new System.Windows.Forms.Button();
            this.Devide = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.BackColor = System.Drawing.Color.Transparent;
            this.lblFirst.Font = new System.Drawing.Font("Sitka Subheading", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirst.ForeColor = System.Drawing.Color.White;
            this.lblFirst.Location = new System.Drawing.Point(31, 57);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(209, 42);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "Первое число:";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.BackColor = System.Drawing.Color.Transparent;
            this.lblSecond.Font = new System.Drawing.Font("Sitka Subheading", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSecond.ForeColor = System.Drawing.Color.White;
            this.lblSecond.Location = new System.Drawing.Point(34, 105);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(206, 42);
            this.lblSecond.TabIndex = 1;
            this.lblSecond.Text = "Второе число:";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(245, 76);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(100, 20);
            this.txtFirst.TabIndex = 2;
            this.txtFirst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.txtFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(245, 124);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(100, 20);
            this.txtSecond.TabIndex = 3;
            this.txtSecond.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.txtSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Increment
            // 
            this.Increment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Increment.BackgroundImage")));
            this.Increment.FlatAppearance.BorderSize = 0;
            this.Increment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Increment.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Increment.Location = new System.Drawing.Point(65, 189);
            this.Increment.Name = "Increment";
            this.Increment.Size = new System.Drawing.Size(116, 97);
            this.Increment.TabIndex = 4;
            this.Increment.UseVisualStyleBackColor = true;
            this.Increment.Click += new System.EventHandler(this.btn_click);
            // 
            // Decrement
            // 
            this.Decrement.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Decrement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Decrement.BackgroundImage")));
            this.Decrement.FlatAppearance.BorderSize = 0;
            this.Decrement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decrement.Location = new System.Drawing.Point(229, 189);
            this.Decrement.Name = "Decrement";
            this.Decrement.Size = new System.Drawing.Size(116, 97);
            this.Decrement.TabIndex = 5;
            this.Decrement.UseVisualStyleBackColor = false;
            this.Decrement.Click += new System.EventHandler(this.btn_click);
            // 
            // Increase
            // 
            this.Increase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Increase.BackgroundImage")));
            this.Increase.FlatAppearance.BorderSize = 0;
            this.Increase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Increase.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Increase.Location = new System.Drawing.Point(65, 309);
            this.Increase.Name = "Increase";
            this.Increase.Size = new System.Drawing.Size(116, 97);
            this.Increase.TabIndex = 6;
            this.Increase.UseVisualStyleBackColor = true;
            this.Increase.Click += new System.EventHandler(this.btn_click);
            // 
            // Devide
            // 
            this.Devide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Devide.BackgroundImage")));
            this.Devide.FlatAppearance.BorderSize = 0;
            this.Devide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Devide.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Devide.Location = new System.Drawing.Point(229, 309);
            this.Devide.Name = "Devide";
            this.Devide.Size = new System.Drawing.Size(116, 101);
            this.Devide.TabIndex = 7;
            this.Devide.UseVisualStyleBackColor = true;
            this.Devide.Click += new System.EventHandler(this.btn_click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Sitka Subheading", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(12, 428);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(158, 42);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "Результат:";
            // 
            // txtResult
            // 
            this.txtResult.AutoSize = true;
            this.txtResult.BackColor = System.Drawing.Color.Transparent;
            this.txtResult.Font = new System.Drawing.Font("Sitka Text", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtResult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtResult.Location = new System.Drawing.Point(193, 428);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(44, 50);
            this.txtResult.TabIndex = 9;
            this.txtResult.Text = "0";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(337, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 60);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(432, 505);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.Devide);
            this.Controls.Add(this.Increase);
            this.Controls.Add(this.Decrement);
            this.Controls.Add(this.Increment);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblFirst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Click += new System.EventHandler(this.btn_click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.Button Increment;
        private System.Windows.Forms.Button Decrement;
        private System.Windows.Forms.Button Increase;
        private System.Windows.Forms.Button Devide;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label txtResult;
        private System.Windows.Forms.Button button1;
    }
}