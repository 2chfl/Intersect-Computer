namespace Intersect_computer_1._0
{
    partial class AddText
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
            this.LogBox = new System.Windows.Forms.RichTextBox();
            this.LinkAdd = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.Mix = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogBox
            // 
            this.LogBox.BackColor = System.Drawing.Color.Black;
            this.LogBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LogBox.Location = new System.Drawing.Point(10, 12);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(340, 294);
            this.LogBox.TabIndex = 0;
            this.LogBox.Text = "";
            // 
            // LinkAdd
            // 
            this.LinkAdd.BackColor = System.Drawing.Color.Black;
            this.LinkAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.LinkAdd.Location = new System.Drawing.Point(10, 329);
            this.LinkAdd.Name = "LinkAdd";
            this.LinkAdd.Size = new System.Drawing.Size(302, 20);
            this.LinkAdd.TabIndex = 1;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Black;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.Location = new System.Drawing.Point(318, 316);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(41, 33);
            this.add.TabIndex = 2;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Mix
            // 
            this.Mix.BackColor = System.Drawing.Color.Black;
            this.Mix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mix.Location = new System.Drawing.Point(10, 355);
            this.Mix.Name = "Mix";
            this.Mix.Size = new System.Drawing.Size(349, 23);
            this.Mix.TabIndex = 3;
            this.Mix.Text = "Сохранить";
            this.Mix.UseVisualStyleBackColor = false;
            this.Mix.Click += new System.EventHandler(this.Mix_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите директорию txt файла (кодировка UTF-8):";
            // 
            // AddText
            // 
            this.AcceptButton = this.add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(364, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mix);
            this.Controls.Add(this.add);
            this.Controls.Add(this.LinkAdd);
            this.Controls.Add(this.LogBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AddText";
            this.ShowIcon = false;
            this.Text = "Загрузка текста";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddText_FormClosed);
            this.Load += new System.EventHandler(this.AddText_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox LogBox;
        private System.Windows.Forms.TextBox LinkAdd;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button Mix;
        private System.Windows.Forms.Label label1;
    }
}