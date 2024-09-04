namespace PrinterManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox listBoxPrinters;
        private Button btnSharePrinter;
        private Label lblInstructions;

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
            this.listBoxPrinters = new ListBox();
            this.btnSharePrinter = new Button();
            this.lblInstructions = new Label();
            this.SuspendLayout();
            
            // listBoxPrinters
            this.listBoxPrinters.FormattingEnabled = true;
            this.listBoxPrinters.ItemHeight = 16;
            this.listBoxPrinters.Location = new System.Drawing.Point(12, 29);
            this.listBoxPrinters.Name = "listBoxPrinters";
            this.listBoxPrinters.Size = new System.Drawing.Size(300, 164);
            this.listBoxPrinters.TabIndex = 0;
            
            // btnSharePrinter
            this.btnSharePrinter.Location = new System.Drawing.Point(12, 199);
            this.btnSharePrinter.Name = "btnSharePrinter";
            this.btnSharePrinter.Size = new System.Drawing.Size(300, 23);
            this.btnSharePrinter.TabIndex = 1;
            this.btnSharePrinter.Text = "Selecionar Impressora";
            this.btnSharePrinter.UseVisualStyleBackColor = true;
            this.btnSharePrinter.Click += new System.EventHandler(this.btnSharePrinter_Click);

            // lblInstructions
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(12, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(200, 16);
            this.lblInstructions.TabIndex = 2;
            this.lblInstructions.Text = "Selecione uma impressora e clique em Selecionar";

            // Form1
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnSharePrinter);
            this.Controls.Add(this.listBoxPrinters);
            this.Name = "Form1";
            this.Text = "Gerenciador de Impressoras";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
