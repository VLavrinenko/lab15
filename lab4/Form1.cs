using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Choose_Color_Click(object sender, EventArgs e)
        {
            ColorDialog Cdialog = new ColorDialog();
            Cdialog.FullOpen = true;
            Cdialog.ShowHelp = true;
            Cdialog.Color = Color_Panel.BackColor;

            if (Cdialog.ShowDialog() == DialogResult.OK)
            {
                Color_Panel.BackColor = Cdialog.Color;
            }
        }

        private void Button_Choose_Font_Click(object sender, EventArgs e)
        {
            FontDialog Fntdialog = new FontDialog();
            Fntdialog.ShowColor = true;
            Fntdialog.ShowHelp = true;
            Fntdialog.Font = Choose_Font.Font;
            
            if (Fntdialog.ShowDialog() == DialogResult.OK) 
            {
                Choose_Font.Font = Fntdialog.Font;
                Choose_Font.ForeColor = Fntdialog.Color;
            }
        }

        private void Button_Choose_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog FlDialog = new OpenFileDialog();
            FlDialog.InitialDirectory = Application.StartupPath;
            FlDialog.Filter = "txt files (*.txt)|*.txt|" +
                "Мои файлы (*.xxx)|*.xxx|" +
                "Сборки (.exe)|*.exe";
            FlDialog.FilterIndex = 3;
            FlDialog.Title = "Выбор моего файла";
            
            if (FlDialog.ShowDialog() == DialogResult.OK)
            {
                Choose_File.Text = FlDialog.FileName;
            }
        }

        private void Button_Choose_Folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FldDialog = new FolderBrowserDialog();
            FldDialog.Description = "Выберите папку для демонстрации работы диалога";
            FldDialog.SelectedPath = Application.StartupPath;

            if (FldDialog.ShowDialog() == DialogResult.OK)
            {
                Choose_Folder.Text = FldDialog.SelectedPath;
            }
        }
    }
}
