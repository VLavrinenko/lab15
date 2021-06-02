
namespace lab4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Choose_Color = new System.Windows.Forms.Button();
            this.Button_Choose_Font = new System.Windows.Forms.Button();
            this.Button_Choose_File = new System.Windows.Forms.Button();
            this.Button_Choose_Folder = new System.Windows.Forms.Button();
            this.Choose_Font = new System.Windows.Forms.TextBox();
            this.Choose_File = new System.Windows.Forms.TextBox();
            this.Choose_Folder = new System.Windows.Forms.TextBox();
            this.Color_Panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button_Choose_Color
            // 
            this.button_Choose_Color.Location = new System.Drawing.Point(32, 36);
            this.button_Choose_Color.Name = "button_Choose_Color";
            this.button_Choose_Color.Size = new System.Drawing.Size(269, 36);
            this.button_Choose_Color.TabIndex = 0;
            this.button_Choose_Color.Text = "Выбор цвета";
            this.button_Choose_Color.UseVisualStyleBackColor = true;
            this.button_Choose_Color.Click += new System.EventHandler(this.Button_Choose_Color_Click);
            // 
            // Button_Choose_Font
            // 
            this.Button_Choose_Font.Location = new System.Drawing.Point(32, 120);
            this.Button_Choose_Font.Name = "Button_Choose_Font";
            this.Button_Choose_Font.Size = new System.Drawing.Size(269, 36);
            this.Button_Choose_Font.TabIndex = 1;
            this.Button_Choose_Font.Text = "Выбор шрифта";
            this.Button_Choose_Font.UseVisualStyleBackColor = true;
            this.Button_Choose_Font.Click += new System.EventHandler(this.Button_Choose_Font_Click);
            // 
            // Button_Choose_File
            // 
            this.Button_Choose_File.Location = new System.Drawing.Point(32, 204);
            this.Button_Choose_File.Name = "Button_Choose_File";
            this.Button_Choose_File.Size = new System.Drawing.Size(269, 36);
            this.Button_Choose_File.TabIndex = 2;
            this.Button_Choose_File.Text = "Выбор файла";
            this.Button_Choose_File.UseVisualStyleBackColor = true;
            this.Button_Choose_File.Click += new System.EventHandler(this.Button_Choose_File_Click);
            // 
            // Button_Choose_Folder
            // 
            this.Button_Choose_Folder.Location = new System.Drawing.Point(32, 288);
            this.Button_Choose_Folder.Name = "Button_Choose_Folder";
            this.Button_Choose_Folder.Size = new System.Drawing.Size(269, 36);
            this.Button_Choose_Folder.TabIndex = 3;
            this.Button_Choose_Folder.Text = "Выбор каталога";
            this.Button_Choose_Folder.UseVisualStyleBackColor = true;
            this.Button_Choose_Folder.Click += new System.EventHandler(this.Button_Choose_Folder_Click);
            // 
            // Choose_Font
            // 
            this.Choose_Font.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Choose_Font.Location = new System.Drawing.Point(337, 125);
            this.Choose_Font.Name = "Choose_Font";
            this.Choose_Font.Size = new System.Drawing.Size(451, 27);
            this.Choose_Font.TabIndex = 5;
            this.Choose_Font.Text = "Пример";
            // 
            // Choose_File
            // 
            this.Choose_File.Location = new System.Drawing.Point(337, 209);
            this.Choose_File.Name = "Choose_File";
            this.Choose_File.Size = new System.Drawing.Size(451, 27);
            this.Choose_File.TabIndex = 6;
            // 
            // Choose_Folder
            // 
            this.Choose_Folder.Location = new System.Drawing.Point(337, 293);
            this.Choose_Folder.Name = "Choose_Folder";
            this.Choose_Folder.Size = new System.Drawing.Size(451, 27);
            this.Choose_Folder.TabIndex = 7;
            // 
            // Color_Panel
            // 
            this.Color_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Color_Panel.Location = new System.Drawing.Point(337, 36);
            this.Color_Panel.Name = "Color_Panel";
            this.Color_Panel.Size = new System.Drawing.Size(236, 36);
            this.Color_Panel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 361);
            this.Controls.Add(this.Color_Panel);
            this.Controls.Add(this.Choose_Folder);
            this.Controls.Add(this.Choose_File);
            this.Controls.Add(this.Choose_Font);
            this.Controls.Add(this.Button_Choose_Folder);
            this.Controls.Add(this.Button_Choose_File);
            this.Controls.Add(this.Button_Choose_Font);
            this.Controls.Add(this.button_Choose_Color);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Choose_Color;
        private System.Windows.Forms.Button Button_Choose_Font;
        private System.Windows.Forms.Button Button_Choose_File;
        private System.Windows.Forms.Button Button_Choose_Folder;
        private System.Windows.Forms.TextBox Choose_Font;
        private System.Windows.Forms.TextBox Choose_File;
        private System.Windows.Forms.TextBox Choose_Folder;
        private System.Windows.Forms.Panel Color_Panel;
    }
}

