using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfaProjetoIntegrador.Models;
using wfaProjetoIntegrador.Controllers;

// Chamadas PDF Sharp
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf.Annotations;
using PdfSharp.Drawing.Layout;
using wfaProjetoIntegrador.Repository;

//using VS_Projeto_1.Model;
//using VS_Projeto_1.View;



namespace wfaProjetoIntegrador.Views
{
    public partial class ReportsUser : UserControl
    {

        string title = "";
        string listTitle = "";
        public ReportsUser()
        {
            InitializeComponent();
        }

        private void billUser1_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertBill_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new ProductRepository().getAll();
            title = "Reports for Products";
            listTitle = "Products: ";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // http://www.pdfsharp.net/wiki/PDFsharpSamples.ashx

            // Capturando as informações dos clientes a partir do Model
            // Para puxar do banco é só usar:  System.Data.DataTable tabela = banco();

            

            // Preparando o documento PDF
            PdfDocument document = new PdfDocument();
            document.Info.Title = title;
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont fontTitle = new XFont("Times", 20, XFontStyle.Regular);
            XFont fontText = new XFont("Times", 12, XFontStyle.Regular);

            // Escrevendo o conteúdo do documento
            double posY = 30;
            gfx.DrawString(listTitle, fontTitle, XBrushes.Black, new XRect(30, posY, page.Width, page.Height), XStringFormats.TopLeft);
            posY += 60;
            string reportAtual = "";

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                reportAtual += col.Name + " | ";
            }
            gfx.DrawString(reportAtual, fontText, XBrushes.Black, new XRect(30, posY, page.Width, page.Height), XStringFormats.TopLeft);

            posY += 16;

            
            foreach (DataGridViewRow linha in dataGridView1.Rows) 
            {
                string linhaAtual = "";
                foreach (DataGridViewCell cell in linha.Cells)
                {
                    linhaAtual += cell.Value.ToString() + " | ";
                }

                gfx.DrawString(linhaAtual, fontText, XBrushes.Black, new XRect(30, posY, page.Width, page.Height), XStringFormats.TopLeft);

                posY += 16;
            }

            // Salvando o arquivo final
            string filename = "Relatório Clientes Cadastrados - "+ new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds()+".pdf";
            document.Save(filename);

            // Abrindo o .PDF para ver como ficou!
            System.Diagnostics.Process.Start(filename);

        }

        private void ReportsUser_Load(object sender, EventArgs e)
        {
     
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new CustomerRepository().getAll();
            title = "Reports for Customers";
            listTitle = "Customers: ";
        }
    }
}
