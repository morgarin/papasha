
namespace papasha
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
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.increment = new System.Windows.Forms.Button();
            this.decrement = new System.Windows.Forms.Button();
            this.increase = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.txtResoult = new System.Windows.Forms.Label();
            this.lblResoult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFirst
            // 
            this.txtFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirst.Location = new System.Drawing.Point(142, 31);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(166, 26);
            this.txtFirst.TabIndex = 2;
            this.txtFirst.TextChanged += new System.EventHandler(this.label2_Click);
            this.txtFirst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.txtFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtSecond
            // 
            this.txtSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecond.Location = new System.Drawing.Point(142, 86);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(166, 26);
            this.txtSecond.TabIndex = 3;
            this.txtSecond.Click += new System.EventHandler(this.btn_click);
            this.txtSecond.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.txtSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.Location = new System.Drawing.Point(12, 20);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(87, 31);
            this.lblFirst.TabIndex = 4;
            this.lblFirst.Text = "perviy";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.Location = new System.Drawing.Point(15, 75);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(89, 31);
            this.lblSecond.TabIndex = 5;
            this.lblSecond.Text = "vtoroy";
            this.lblSecond.Click += new System.EventHandler(this.label2_Click);
            // 
            // increment
            // 
            this.increment.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increment.Location = new System.Drawing.Point(30, 168);
            this.increment.Name = "increment";
            this.increment.Size = new System.Drawing.Size(50, 50);
            this.increment.TabIndex = 6;
            this.increment.Text = "+";
            this.increment.UseVisualStyleBackColor = true;
            this.increment.Click += new System.EventHandler(this.btn_click);
            // 
            // decrement
            // 
            this.decrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decrement.Location = new System.Drawing.Point(104, 168);
            this.decrement.Name = "decrement";
            this.decrement.Size = new System.Drawing.Size(50, 50);
            this.decrement.TabIndex = 7;
            this.decrement.Text = "-";
            this.decrement.UseVisualStyleBackColor = true;
            this.decrement.Click += new System.EventHandler(this.btn_click);
            // 
            // increase
            // 
            this.increase.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increase.Location = new System.Drawing.Point(181, 168);
            this.increase.Name = "increase";
            this.increase.Size = new System.Drawing.Size(50, 50);
            this.increase.TabIndex = 8;
            this.increase.Text = "*";
            this.increase.UseVisualStyleBackColor = true;
            this.increase.Click += new System.EventHandler(this.btn_click);
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(258, 168);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(50, 50);
            this.divide.TabIndex = 9;
            this.divide.Text = ":";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.btn_click);
            // 
            // txtResoult
            // 
            this.txtResoult.AutoSize = true;
            this.txtResoult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResoult.Location = new System.Drawing.Point(159, 271);
            this.txtResoult.Name = "txtResoult";
            this.txtResoult.Size = new System.Drawing.Size(29, 31);
            this.txtResoult.TabIndex = 10;
            this.txtResoult.Text = "0";
            // 
            // lblResoult
            // 
            this.lblResoult.AutoSize = true;
            this.lblResoult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResoult.Location = new System.Drawing.Point(24, 271);
            this.lblResoult.Name = "lblResoult";
            this.lblResoult.Size = new System.Drawing.Size(104, 31);
            this.lblResoult.TabIndex = 11;
            this.lblResoult.Text = "resoult:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(333, 334);
            this.Controls.Add(this.lblResoult);
            this.Controls.Add(this.txtResoult);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.increase);
            this.Controls.Add(this.decrement);
            this.Controls.Add(this.increment);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtFirst);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Button increment;
        private System.Windows.Forms.Button decrement;
        private System.Windows.Forms.Button increase;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Label txtResoult;
        private System.Windows.Forms.Label lblResoult;
    }
}