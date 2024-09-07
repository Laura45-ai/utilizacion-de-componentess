using System;
using System.Windows.Forms;

namespace Utilización_de_componentes
{
    public partial class PDF : Form
    {
        public PDF()
        {
            InitializeComponent();
            // La suscripción al evento 'Load' del formulario debería hacerse aquí
            this.Load += PDF_Load;
        }

        private void PDF_Load(object sender, EventArgs e)
        {
            // Ruta del archivo PDF
            string pdfPath = @"C:\Utilización de componentes\Utilización de componentes\Utilización de componentes.pdf";

            // Cargar el PDF en el control WebBrowser
            try
            {
                webBrowser1.Navigate(pdfPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el PDF: {ex.Message}");
            }
        }

        // Este método puede ser necesario si usas el evento DocumentCompleted
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // Manejo del evento DocumentCompleted si es necesario
        }
    }
}
