namespace TextFileProcessor
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProcessNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveEvenResultAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveOddResultAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.TextBoxEven = new System.Windows.Forms.TextBox();
            this.TextBoxOdd = new System.Windows.Forms.TextBox();
            this.LabelInput = new System.Windows.Forms.Label();
            this.LabelEven = new System.Windows.Forms.Label();
            this.LabelOdd = new System.Windows.Forms.Label();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFileToolStripMenuItem,
            this.OpenFileToolStripMenuItem,
            this.SaveFileToolStripMenuItem,
            this.SaveFileAsToolStripMenuItem,
            this.ProcessNumbersToolStripMenuItem,
            this.ClearResultsToolStripMenuItem,
            this.SaveEvenResultAsToolStripMenuItem,
            this.SaveOddResultAsToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // NewFileToolStripMenuItem
            // 
            this.NewFileToolStripMenuItem.Name = "NewFileToolStripMenuItem";
            this.NewFileToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.NewFileToolStripMenuItem.Text = "Новый";
            this.NewFileToolStripMenuItem.Click += new System.EventHandler(this.NewFileToolStripMenuItem_Click);
            // 
            // OpenFileToolStripMenuItem
            // 
            this.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem";
            this.OpenFileToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.OpenFileToolStripMenuItem.Text = "Открыть";
            this.OpenFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // SaveFileToolStripMenuItem
            // 
            this.SaveFileToolStripMenuItem.Name = "SaveFileToolStripMenuItem";
            this.SaveFileToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.SaveFileToolStripMenuItem.Text = "Сохранить";
            this.SaveFileToolStripMenuItem.Click += new System.EventHandler(this.SaveFileToolStripMenuItem_Click);
            // 
            // SaveFileAsToolStripMenuItem
            // 
            this.SaveFileAsToolStripMenuItem.Name = "SaveFileAsToolStripMenuItem";
            this.SaveFileAsToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.SaveFileAsToolStripMenuItem.Text = "Сохранить как...";
            this.SaveFileAsToolStripMenuItem.Click += new System.EventHandler(this.SaveFileAsToolStripMenuItem_Click);
            // 
            // ProcessNumbersToolStripMenuItem
            // 
            this.ProcessNumbersToolStripMenuItem.Name = "ProcessNumbersToolStripMenuItem";
            this.ProcessNumbersToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.ProcessNumbersToolStripMenuItem.Text = "Обработать числа";
            this.ProcessNumbersToolStripMenuItem.Click += new System.EventHandler(this.ProcessNumbersToolStripMenuItem_Click);
            // 
            // ClearResultsToolStripMenuItem
            // 
            this.ClearResultsToolStripMenuItem.Name = "ClearResultsToolStripMenuItem";
            this.ClearResultsToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.ClearResultsToolStripMenuItem.Text = "Очистить результаты";
            this.ClearResultsToolStripMenuItem.Click += new System.EventHandler(this.ClearResultsToolStripMenuItem_Click);
            // 
            // SaveEvenResultAsToolStripMenuItem
            // 
            this.SaveEvenResultAsToolStripMenuItem.Name = "SaveEvenResultAsToolStripMenuItem";
            this.SaveEvenResultAsToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.SaveEvenResultAsToolStripMenuItem.Text = "Сохранить четные результаты как...";
            this.SaveEvenResultAsToolStripMenuItem.Click += new System.EventHandler(this.SaveEvenResultAsToolStripMenuItem_Click);
            // 
            // SaveOddResultAsToolStripMenuItem
            // 
            this.SaveOddResultAsToolStripMenuItem.Name = "SaveOddResultAsToolStripMenuItem";
            this.SaveOddResultAsToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.SaveOddResultAsToolStripMenuItem.Text = "Сохранить нечетные результаты как...";
            this.SaveOddResultAsToolStripMenuItem.Click += new System.EventHandler(this.SaveOddResultAsToolStripMenuItem_Click);
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.Location = new System.Drawing.Point(12, 44);
            this.TextBoxInput.Multiline = true;
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.Size = new System.Drawing.Size(776, 100);
            this.TextBoxInput.TabIndex = 1;
            // 
            // TextBoxEven
            // 
            this.TextBoxEven.Location = new System.Drawing.Point(15, 163);
            this.TextBoxEven.Multiline = true;
            this.TextBoxEven.Name = "TextBoxEven";
            this.TextBoxEven.Size = new System.Drawing.Size(376, 200);
            this.TextBoxEven.TabIndex = 2;
            // 
            // TextBoxOdd
            // 
            this.TextBoxOdd.Location = new System.Drawing.Point(412, 163);
            this.TextBoxOdd.Multiline = true;
            this.TextBoxOdd.Name = "TextBoxOdd";
            this.TextBoxOdd.Size = new System.Drawing.Size(376, 200);
            this.TextBoxOdd.TabIndex = 3;
            // 
            // LabelInput
            // 
            this.LabelInput.AutoSize = true;
            this.LabelInput.Location = new System.Drawing.Point(9, 28);
            this.LabelInput.Name = "LabelInput";
            this.LabelInput.Size = new System.Drawing.Size(84, 13);
            this.LabelInput.TabIndex = 4;
            this.LabelInput.Text = "Введите числа:";
            // 
            // LabelEven
            // 
            this.LabelEven.AutoSize = true;
            this.LabelEven.Location = new System.Drawing.Point(12, 147);
            this.LabelEven.Name = "LabelEven";
            this.LabelEven.Size = new System.Drawing.Size(81, 13);
            this.LabelEven.TabIndex = 5;
            this.LabelEven.Text = "Четные числа:";
            // 
            // LabelOdd
            // 
            this.LabelOdd.AutoSize = true;
            this.LabelOdd.Location = new System.Drawing.Point(409, 147);
            this.LabelOdd.Name = "LabelOdd";
            this.LabelOdd.Size = new System.Drawing.Size(92, 13);
            this.LabelOdd.TabIndex = 6;
            this.LabelOdd.Text = "Нечетные числа:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelOdd);
            this.Controls.Add(this.LabelEven);
            this.Controls.Add(this.LabelInput);
            this.Controls.Add(this.TextBoxOdd);
            this.Controls.Add(this.TextBoxEven);
            this.Controls.Add(this.TextBoxInput);
            this.Controls.Add(this.MenuStrip1);
            this.MainMenuStrip = this.MenuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveFileAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProcessNumbersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveEvenResultAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveOddResultAsToolStripMenuItem;
        private System.Windows.Forms.TextBox TextBoxInput;
        private System.Windows.Forms.TextBox TextBoxEven;
        private System.Windows.Forms.TextBox TextBoxOdd;
        private System.Windows.Forms.Label LabelInput;
        private System.Windows.Forms.Label LabelEven;
        private System.Windows.Forms.Label LabelOdd;
    }
}