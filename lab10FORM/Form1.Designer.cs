
namespace lab10FORM
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
            this.applybtn = new System.Windows.Forms.Button();
            this.radioButtonRaw = new System.Windows.Forms.RadioButton();
            this.radioButtonColumn = new System.Windows.Forms.RadioButton();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // applybtn
            // 
            this.applybtn.Location = new System.Drawing.Point(332, 357);
            this.applybtn.Name = "applybtn";
            this.applybtn.Size = new System.Drawing.Size(128, 57);
            this.applybtn.TabIndex = 0;
            this.applybtn.Text = "Apply";
            this.applybtn.UseVisualStyleBackColor = true;
            this.applybtn.Click += new System.EventHandler(this.applybtn_Click);
            // 
            // radioButtonRaw
            // 
            this.radioButtonRaw.AutoSize = true;
            this.radioButtonRaw.Location = new System.Drawing.Point(236, 290);
            this.radioButtonRaw.Name = "radioButtonRaw";
            this.radioButtonRaw.Size = new System.Drawing.Size(91, 21);
            this.radioButtonRaw.TabIndex = 1;
            this.radioButtonRaw.TabStop = true;
            this.radioButtonRaw.Text = "Row Style";
            this.radioButtonRaw.UseVisualStyleBackColor = true;
            this.radioButtonRaw.CheckedChanged += new System.EventHandler(this.radioButtonRaw_CheckedChanged);
            // 
            // radioButtonColumn
            // 
            this.radioButtonColumn.AutoSize = true;
            this.radioButtonColumn.Location = new System.Drawing.Point(450, 290);
            this.radioButtonColumn.Name = "radioButtonColumn";
            this.radioButtonColumn.Size = new System.Drawing.Size(111, 21);
            this.radioButtonColumn.TabIndex = 2;
            this.radioButtonColumn.TabStop = true;
            this.radioButtonColumn.Text = "Column Style";
            this.radioButtonColumn.UseVisualStyleBackColor = true;
            this.radioButtonColumn.CheckedChanged += new System.EventHandler(this.radioButtonColumn_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(181, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(412, 180);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.radioButtonColumn);
            this.Controls.Add(this.radioButtonRaw);
            this.Controls.Add(this.applybtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button applybtn;
        private System.Windows.Forms.RadioButton radioButtonRaw;
        private System.Windows.Forms.RadioButton radioButtonColumn;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

