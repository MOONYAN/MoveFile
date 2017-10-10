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
            _sourceTextBox.Text = _folderBrowserDialog.SelectedPath;
            _model.SourcePath = _folderBrowserDialog.SelectedPath;
        }

        private void _goalButton_Click(object sender, EventArgs e)
        {
            _folderBrowserDialog.ShowDialog();
            _goalTextBox.Text = _folderBrowserDialog.SelectedPath;
            _model.GoalPath = _folderBrowserDialog.SelectedPath;
        }

        private void _doButton_Click(object sender, EventArgs e)
        {
            _model.DoOperate();
        }
    }
}
