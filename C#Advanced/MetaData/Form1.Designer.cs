namespace MetaData
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
            this.btn_open_dialog = new System.Windows.Forms.Button();
            this.txt_filename = new System.Windows.Forms.TextBox();
            this.btn_create_class = new System.Windows.Forms.Button();
            this.get_dll_name = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_open_dialog
            // 
            this.btn_open_dialog.Location = new System.Drawing.Point(322, 52);
            this.btn_open_dialog.Name = "btn_open_dialog";
            this.btn_open_dialog.Size = new System.Drawing.Size(83, 23);
            this.btn_open_dialog.TabIndex = 0;
            this.btn_open_dialog.Text = "Open File";
            this.btn_open_dialog.UseVisualStyleBackColor = true;
            this.btn_open_dialog.Click += new System.EventHandler(this.btn_open_dialog_Click);
            // 
            // txt_filename
            // 
            this.txt_filename.Location = new System.Drawing.Point(73, 55);
            this.txt_filename.Name = "txt_filename";
            this.txt_filename.Size = new System.Drawing.Size(243, 20);
            this.txt_filename.TabIndex = 1;
            // 
            // btn_create_class
            // 
            this.btn_create_class.Location = new System.Drawing.Point(322, 82);
            this.btn_create_class.Name = "btn_create_class";
            this.btn_create_class.Size = new System.Drawing.Size(83, 23);
            this.btn_create_class.TabIndex = 2;
            this.btn_create_class.Text = "Create Class";
            this.btn_create_class.UseVisualStyleBackColor = true;
            // 
            // get_dll_name
            // 
            this.get_dll_name.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label2.Location = new System.Drawing.Point(15, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Create Classes For DLLs , Reflections";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 124);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_create_class);
            this.Controls.Add(this.txt_filename);
            this.Controls.Add(this.btn_open_dialog);
            this.Name = "Form1";
            this.Text = "Reflections";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_open_dialog;
        private System.Windows.Forms.TextBox txt_filename;
        private System.Windows.Forms.Button btn_create_class;
        private System.Windows.Forms.OpenFileDialog get_dll_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

