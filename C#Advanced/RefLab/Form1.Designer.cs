namespace RefLab
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
            this.btn_get_class = new System.Windows.Forms.Button();
            this.btn_get_methods = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_file_path = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.open_file_select = new System.Windows.Forms.OpenFileDialog();
            this.list_Classes = new System.Windows.Forms.ListBox();
            this.list_methods = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_get_class
            // 
            this.btn_get_class.Location = new System.Drawing.Point(292, 19);
            this.btn_get_class.Name = "btn_get_class";
            this.btn_get_class.Size = new System.Drawing.Size(88, 23);
            this.btn_get_class.TabIndex = 0;
            this.btn_get_class.Text = "Get Classes";
            this.btn_get_class.UseVisualStyleBackColor = true;
            this.btn_get_class.Click += new System.EventHandler(this.btn_get_class_Click);
            // 
            // btn_get_methods
            // 
            this.btn_get_methods.Location = new System.Drawing.Point(292, 225);
            this.btn_get_methods.Name = "btn_get_methods";
            this.btn_get_methods.Size = new System.Drawing.Size(88, 23);
            this.btn_get_methods.TabIndex = 3;
            this.btn_get_methods.Text = "Get Methods";
            this.btn_get_methods.UseVisualStyleBackColor = true;
            this.btn_get_methods.Click += new System.EventHandler(this.btn_get_methods_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Methods";
            // 
            // txt_file_path
            // 
            this.txt_file_path.Location = new System.Drawing.Point(12, 19);
            this.txt_file_path.Name = "txt_file_path";
            this.txt_file_path.Size = new System.Drawing.Size(274, 20);
            this.txt_file_path.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Classes";
            // 
            // open_file_select
            // 
            this.open_file_select.FileName = "openFileDialog1";
            // 
            // list_Classes
            // 
            this.list_Classes.FormattingEnabled = true;
            this.list_Classes.Location = new System.Drawing.Point(16, 79);
            this.list_Classes.Name = "list_Classes";
            this.list_Classes.Size = new System.Drawing.Size(270, 121);
            this.list_Classes.TabIndex = 9;
            this.list_Classes.Click += new System.EventHandler(this.list_Classes_Click);
            this.list_Classes.SelectedIndexChanged += new System.EventHandler(this.list_Classes_SelectedIndexChanged);
            // 
            // list_methods
            // 
            this.list_methods.FormattingEnabled = true;
            this.list_methods.Location = new System.Drawing.Point(16, 247);
            this.list_methods.Name = "list_methods";
            this.list_methods.Size = new System.Drawing.Size(270, 134);
            this.list_methods.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 403);
            this.Controls.Add(this.list_methods);
            this.Controls.Add(this.list_Classes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_file_path);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_get_methods);
            this.Controls.Add(this.btn_get_class);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_get_class;
        private System.Windows.Forms.Button btn_get_methods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_file_path;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog open_file_select;
        private System.Windows.Forms.ListBox list_Classes;
        private System.Windows.Forms.ListBox list_methods;
    }
}

