namespace Lesson9_Files
{
    partial class CoffeeSyrupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoffeeSyrupForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.coffeeComboBox = new System.Windows.Forms.ComboBox();
            this.syrupListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printSelectedFlavoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printAllFlavoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCoffeeFlavourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCoffeeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countCoffeeListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printAllDocument = new System.Drawing.Printing.PrintDocument();
            this.printSelectedDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coffee and Syrup Selection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(480, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anju Chawla";
            // 
            // coffeeComboBox
            // 
            this.coffeeComboBox.FormattingEnabled = true;
            this.coffeeComboBox.Items.AddRange(new object[] {
            "Chocolate Almond",
            "Espresso Roast",
            "Jamaica Blue Mountain",
            "Kona Blend ",
            "Vanilla Nut"});
            this.coffeeComboBox.Location = new System.Drawing.Point(77, 108);
            this.coffeeComboBox.Name = "coffeeComboBox";
            this.coffeeComboBox.Size = new System.Drawing.Size(121, 21);
            this.coffeeComboBox.Sorted = true;
            this.coffeeComboBox.TabIndex = 2;
            // 
            // syrupListBox
            // 
            this.syrupListBox.FormattingEnabled = true;
            this.syrupListBox.Items.AddRange(new object[] {
            "(None)",
            "Chocolate",
            "Hazel Nut",
            "Irish Creme",
            "Orange "});
            this.syrupListBox.Location = new System.Drawing.Point(367, 108);
            this.syrupListBox.Name = "syrupListBox";
            this.syrupListBox.Size = new System.Drawing.Size(120, 95);
            this.syrupListBox.Sorted = true;
            this.syrupListBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Coffee Flavour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "&Syrup";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(569, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printSelectedFlavoursToolStripMenuItem,
            this.printAllFlavoursToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveFileToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printSelectedFlavoursToolStripMenuItem
            // 
            this.printSelectedFlavoursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printSelectedToolStripMenuItem,
            this.previewSelectedToolStripMenuItem});
            this.printSelectedFlavoursToolStripMenuItem.Name = "printSelectedFlavoursToolStripMenuItem";
            this.printSelectedFlavoursToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.printSelectedFlavoursToolStripMenuItem.Text = "Print &Selected Flavours";
            // 
            // printSelectedToolStripMenuItem
            // 
            this.printSelectedToolStripMenuItem.Name = "printSelectedToolStripMenuItem";
            this.printSelectedToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.printSelectedToolStripMenuItem.Text = "&Print Selected";
            this.printSelectedToolStripMenuItem.Click += new System.EventHandler(this.printSelectedToolStripMenuItem_Click);
            // 
            // previewSelectedToolStripMenuItem
            // 
            this.previewSelectedToolStripMenuItem.Name = "previewSelectedToolStripMenuItem";
            this.previewSelectedToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.previewSelectedToolStripMenuItem.Text = "Preview &Selected";
            this.previewSelectedToolStripMenuItem.Click += new System.EventHandler(this.previewSelectedToolStripMenuItem_Click);
            // 
            // printAllFlavoursToolStripMenuItem
            // 
            this.printAllFlavoursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printAllToolStripMenuItem,
            this.previewAllToolStripMenuItem});
            this.printAllFlavoursToolStripMenuItem.Name = "printAllFlavoursToolStripMenuItem";
            this.printAllFlavoursToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.printAllFlavoursToolStripMenuItem.Text = "Print &All Flavours";
            // 
            // printAllToolStripMenuItem
            // 
            this.printAllToolStripMenuItem.Name = "printAllToolStripMenuItem";
            this.printAllToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.printAllToolStripMenuItem.Text = "&Print All";
            this.printAllToolStripMenuItem.Click += new System.EventHandler(this.printAllToolStripMenuItem_Click);
            // 
            // previewAllToolStripMenuItem
            // 
            this.previewAllToolStripMenuItem.Name = "previewAllToolStripMenuItem";
            this.previewAllToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.previewAllToolStripMenuItem.Text = "Pre&view All";
            this.previewAllToolStripMenuItem.Click += new System.EventHandler(this.previewAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeCoffeeFlavourToolStripMenuItem,
            this.clearCoffeeListToolStripMenuItem,
            this.countCoffeeListToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.addToolStripMenuItem.Text = "&Add Coffee Flavour";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeCoffeeFlavourToolStripMenuItem
            // 
            this.removeCoffeeFlavourToolStripMenuItem.Name = "removeCoffeeFlavourToolStripMenuItem";
            this.removeCoffeeFlavourToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.removeCoffeeFlavourToolStripMenuItem.Text = "&Remove Coffee Flavour";
            this.removeCoffeeFlavourToolStripMenuItem.Click += new System.EventHandler(this.removeCoffeeFlavourToolStripMenuItem_Click);
            // 
            // clearCoffeeListToolStripMenuItem
            // 
            this.clearCoffeeListToolStripMenuItem.Name = "clearCoffeeListToolStripMenuItem";
            this.clearCoffeeListToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.clearCoffeeListToolStripMenuItem.Text = "&Clear Coffee List";
            this.clearCoffeeListToolStripMenuItem.Click += new System.EventHandler(this.clearCoffeeListToolStripMenuItem_Click);
            // 
            // countCoffeeListToolStripMenuItem
            // 
            this.countCoffeeListToolStripMenuItem.Name = "countCoffeeListToolStripMenuItem";
            this.countCoffeeListToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.countCoffeeListToolStripMenuItem.Text = "Count Coffee &List";
            this.countCoffeeListToolStripMenuItem.Click += new System.EventHandler(this.countCoffeeListToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // printAllDocument
            // 
            this.printAllDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printAllDocument_PrintPage);
            // 
            // printSelectedDocument
            // 
            this.printSelectedDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printSelectedDocument_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckPathExists = false;
            this.saveFileDialog1.DefaultExt = "txt";
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.saveFileToolStripMenuItem.Text = "S&ave File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.openFileToolStripMenuItem.Text = "&Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(190, 6);
            // 
            // CoffeeSyrupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 265);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.syrupListBox);
            this.Controls.Add(this.coffeeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CoffeeSyrupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R \'n R for Reading and Refreshment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CoffeeSyrupForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox coffeeComboBox;
        private System.Windows.Forms.ListBox syrupListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printSelectedFlavoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printAllFlavoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCoffeeFlavourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearCoffeeListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countCoffeeListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printAllDocument;
        private System.Drawing.Printing.PrintDocument printSelectedDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

