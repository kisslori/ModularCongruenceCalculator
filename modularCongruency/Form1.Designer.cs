namespace modularCongruency
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
            this.b_txtbox = new System.Windows.Forms.TextBox();
            this.a_txtbox = new System.Windows.Forms.TextBox();
            this.n_txtbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ans_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "* X ≡ ";
            // 
            // b_txtbox
            // 
            this.b_txtbox.Location = new System.Drawing.Point(87, 35);
            this.b_txtbox.Name = "b_txtbox";
            this.b_txtbox.Size = new System.Drawing.Size(25, 20);
            this.b_txtbox.TabIndex = 2;
            this.b_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.b_txtbox_KeyPress);
            // 
            // a_txtbox
            // 
            this.a_txtbox.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.a_txtbox.Location = new System.Drawing.Point(13, 35);
            this.a_txtbox.Name = "a_txtbox";
            this.a_txtbox.Size = new System.Drawing.Size(25, 20);
            this.a_txtbox.TabIndex = 1;
            this.a_txtbox.Text = "\r\n";
            this.a_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.a_txtbox_KeyPress);
            // 
            // n_txtbox
            // 
            this.n_txtbox.Location = new System.Drawing.Point(171, 35);
            this.n_txtbox.Name = "n_txtbox";
            this.n_txtbox.Size = new System.Drawing.Size(25, 20);
            this.n_txtbox.TabIndex = 3;
            this.n_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.n_txtbox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(118, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "( mod";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(202, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = ")";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Find X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ans_label
            // 
            this.ans_label.AutoSize = true;
            this.ans_label.Location = new System.Drawing.Point(13, 78);
            this.ans_label.Name = "ans_label";
            this.ans_label.Size = new System.Drawing.Size(0, 13);
            this.ans_label.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 139);
            this.Controls.Add(this.ans_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.n_txtbox);
            this.Controls.Add(this.a_txtbox);
            this.Controls.Add(this.b_txtbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Modular Congruency";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox b_txtbox;
        private System.Windows.Forms.TextBox a_txtbox;
        private System.Windows.Forms.TextBox n_txtbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ans_label;
    }
}

