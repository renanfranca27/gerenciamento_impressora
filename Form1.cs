using System;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace PrinterManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadPrinters();
        }

        private void LoadPrinters()
        {
            try
            {
                // PrintDocument object to get the installed printers
                foreach (string printer in PrinterSettings.InstalledPrinters)
                {
                    listBoxPrinters.Items.Add(printer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar impressoras: " + ex.Message);
            }
        }

        private void btnSharePrinter_Click(object sender, EventArgs e)
        {
            if (listBoxPrinters.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione uma impressora.");
                return;
            }

            string printerName = listBoxPrinters.SelectedItem.ToString();
            // Implement additional functionality as needed
            MessageBox.Show($"A impressora {printerName} foi selecionada.");
        }
    }
}
