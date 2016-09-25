using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindNoRepeatedWordsFilesCollections
{

    public partial class MainForm : Form
    {
        private List<string> resultList;

        public MainForm()
        {
            InitializeComponent();
        }

        private void openFileDialog_Btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                string methodResult = Files.Open(openFileDialog.FileName);
                if (methodResult == null) MessageBox.Show("Mistake in output file");
                else
                {
                    textChosenFile_RichTb.Text = methodResult;

                    resultList = new List<string>();
                    resultList = Files.FindNotRepeatedWords();
                    textMadeFile_Lbl.Text = "";
                    if (resultList == null) MessageBox.Show("Non-repeated words not found!");
                    else
                    {
                        foreach (string i in resultList)
                        {
                            textMadeFile_Lbl.Text += i + Environment.NewLine;
                        }
                    }
                }// if ( methodResult== null)
            }// if (openFileDialog.ShowDialog() == DialogResult.OK)

        }

        private void saveFileDialog_Btn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Files.OutputToTextfile(resultList, saveFileDialog.FileName);
            }
        }
    }
}