using MoveFile.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveFile
{
    public partial class MainForm : Form
    {
        Model _model;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _model = new Model();
        }

        private void _sourceButton_Click(object sender, EventArgs e)
        {
            _folderBrowserDialog.ShowDialog();
            string folderPath = _folderBrowserDialog.SelectedPath;
            _sourceTextBox.Text = folderPath;
            _model.SourcePath = folderPath;
        }

        private void _goalButton_Click(object sender, EventArgs e)
        {
            _folderBrowserDialog.ShowDialog();
            string folderPath = _folderBrowserDialog.SelectedPath;
            _goalTextBox.Text = folderPath;
            _model.GoalPath = folderPath;
        }

        private void _doButton_Click(object sender, EventArgs e)
        {
            _model.FilterString = _filterTextBox.Text;
            _model.DoOperate();
        }
    }
}
