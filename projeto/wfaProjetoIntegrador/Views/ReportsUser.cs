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

//using VS_Projeto_1.Model;
//using VS_Projeto_1.View;



namespace wfaProjetoIntegrador.Views
{
    public partial class ReportsUser : UserControl
    {
        public ReportsUser()
        {
            InitializeComponent();
        }

        private void billUser1_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertBill_Click(object sender, EventArgs e)
        {
            ReportsController.List(dataGridView1);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // http://www.pdfsharp.net/wiki/PDFsharpSamples.ashx

            // Capturando as informações dos clientes a partir do Model
            // Para puxar do banco é só usar:  System.Data.DataTable tabela = banco();
            DataTable tabela = new DataTable();
            tabela.Columns.Add("id", typeof(int));
            tabela.Columns.Add("name", typeof(string));
            tabela.Columns.Add("sellPrice", typeof(double));
            tabela.Columns.Add("company", typeof(string));
            tabela.Columns.Add("quantity", typeof(int));
            tabela.Columns.Add("category", typeof(string));
            tabela.Columns.Add("buyprice", typeof(double));

            int id = 1;
            for(int i = 0; i < 5; i++)
            {
                string dd = Convert.ToString(id);
                DataRow Linhas = tabela.NewRow();
                Linhas["id"] = dd;
                Linhas["name"] = "teste";
                Linhas["sellprice"] = "10";
                Linhas["company"] = "teste";
                Linhas["quantity"] = "10";
                Linhas["category"] = "teste";
                Linhas["buyprice"] = "10";

                tabela.Rows.Add(Linhas);
                id++;
            }

            // Preparando o documento PDF
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Reports for Products";
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont fontTitle = new XFont("Times", 20, XFontStyle.Regular);
            XFont fontText = new XFont("Times", 12, XFontStyle.Regular);

            // Escrevendo o conteúdo do documento
            double posY = 30;
            gfx.DrawString("Products:", fontTitle, XBrushes.Black, new XRect(30, posY, page.Width, page.Height), XStringFormats.TopLeft);
            posY += 60;
            foreach (System.Data.DataRow linha in tabela.Rows)
            {
                string reportAtual = "";
                foreach (object obj in linha.ItemArray)
                    reportAtual += obj.ToString() + " | ";
                gfx.DrawString(reportAtual, fontText, XBrushes.Black, new XRect(30, 100, page.Width, page.Height), XStringFormats.TopLeft);

                posY += 14;
            }

            // Salvando o arquivo final
            const string filename = "Relatório Clientes Cadastrados.pdf";
            document.Save(filename);

            // Abrindo o .PDF para ver como ficou!
            System.Diagnostics.Process.Start(filename);

        }

        private void ReportsUser_Load(object sender, EventArgs e)
        {

        }
    }
}
