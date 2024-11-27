using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TextFileProcessor
{
    public partial class Form1 : Form
    {
        private string currentFilePath = string.Empty;

        public Form1()
        {
            InitializeComponent();
            UpdateWindowTitle();
        }

        private void UpdateWindowTitle()
        {
            string fileName = string.IsNullOrEmpty(currentFilePath) ? "Безымянный" : Path.GetFileName(currentFilePath);
            this.Text = $"Обработчик чисел - {fileName}";
        }

        private void NewFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentFilePath = string.Empty;
            TextBoxInput.Clear();
            TextBoxEven.Clear();
            TextBoxOdd.Clear();
            UpdateWindowTitle();
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = openFileDialog.FileName;
                TextBoxInput.Text = File.ReadAllText(currentFilePath);
                UpdateWindowTitle();
            }
        }

        private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                File.WriteAllText(currentFilePath, TextBoxInput.Text);
            }
            else
            {
                SaveFileAsToolStripMenuItem_Click(sender, e);
            }
        }

        private void SaveFileAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = saveFileDialog.FileName;
                File.WriteAllText(currentFilePath, TextBoxInput.Text);
                UpdateWindowTitle();
            }
        }

        private void ProcessNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxInput.Text))
            {
                MessageBox.Show("Сначала введите числа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] numbersStr = TextBoxInput.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder evenBuilder = new StringBuilder();
            StringBuilder oddBuilder = new StringBuilder();

            foreach (string numStr in numbersStr)
            {
                if (int.TryParse(numStr, out int number))
                {
                    if (number % 2 == 0)
                    {
                        evenBuilder.AppendLine(number.ToString());
                    }
                    else
                    {
                        oddBuilder.AppendLine(number.ToString());
                    }
                }
                else
                {
                    MessageBox.Show($"'{numStr}' не является числом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            TextBoxEven.Text = evenBuilder.ToString();
            TextBoxOdd.Text = oddBuilder.ToString();
        }

        private void ClearResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBoxEven.Clear();
            TextBoxOdd.Clear();
        }

        private void SaveEvenResultAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveResultDialog = new SaveFileDialog())
            {
                saveResultDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (saveResultDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveResultDialog.FileName, TextBoxEven.Text);
                }
            }
        }

        private void SaveOddResultAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveResultDialog = new SaveFileDialog())
            {
                saveResultDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (saveResultDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveResultDialog.FileName, TextBoxOdd.Text);
                }
            }
        }
    }
}