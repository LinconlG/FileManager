using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            try
            {
                int linhas = Convert.ToInt32(txtLinhas.Text);
                string diretorioExcel = txtPlanilha.Text;
                DirectoryInfo pastaArquivos = new DirectoryInfo($@"{txtArquivo.Text}");
                DirectoryInfo pastaAlvo = new DirectoryInfo($@"{txtPastas.Text}");

                FileInfo[] listaArquivos = pastaArquivos.GetFiles();
                DirectoryInfo[] listaPastas = pastaAlvo.GetDirectories();
                DirectoryInfo pastaAtual;
                FileInfo[] arquivosPasta;

                string[] nomesArquivos = new string[linhas];
                string[] pastas = new string[linhas];


                //Recebe as informações da planilha
                var planilha = new Microsoft.Office.Interop.Excel.Application();
                var wb = planilha.Workbooks.Open($@"{diretorioExcel}", ReadOnly: true);
                var ws = wb.Worksheets[1];
                var r = ws.Range["A1"].Resize[linhas, 2];
                var array = r.Value;

                for (int i = 1; i <= linhas; i++)
                {
                    for (int j = 1; j <= 2; j++)
                    {
                        string text = Convert.ToString(array[i, j]);

                        if (j == 1)
                        {
                            nomesArquivos[i - 1] = text;
                        }
                        else
                        {
                            pastas[i - 1] = text;
                        }
                    }
                }

                //-------------------------------------------------------------

                for (int i = 0; i < linhas; i++)
                {
                    if (Directory.Exists($@"{txtPastas.Text}\{pastas[i]}"))
                    {

                    }
                    else
                    {
                        Directory.CreateDirectory($@"{txtPastas.Text}\{pastas[i]}");
                    }
                }



                foreach (FileInfo arquivo in listaArquivos)
                {
                    if (Path.GetFileName(arquivo.FullName) == "desktop.ini")
                    {

                    }
                    else
                    {
                        string extensao = Path.GetExtension(arquivo.FullName).ToLower();
                        int indRev = Path.GetFileNameWithoutExtension(arquivo.FullName).LastIndexOf(" Rev");
                        string nomeArquivo = Path.GetFileNameWithoutExtension(arquivo.FullName).Substring(0, indRev);

                        for (int i = 1; i <= linhas; i++)
                        {
                            if (nomesArquivos[i - 1] == nomeArquivo)
                            {
                                pastaAtual = new DirectoryInfo($@"{txtPastas.Text}\{pastas[i - 1]}");
                                arquivosPasta = pastaAtual.GetFiles();

                                foreach (FileInfo item in arquivosPasta)
                                {
                                    if (Path.GetFileName(item.FullName) != "desktop.ini")
                                    {
                                        int indrev = Path.GetFileNameWithoutExtension(item.FullName).LastIndexOf(" Rev");
                                        string extItem = Path.GetExtension(item.FullName).ToLower();

                                        if (Path.GetFileNameWithoutExtension(item.FullName).Substring(0, indrev)+$"{extItem}" == Path.GetFileNameWithoutExtension(arquivo.FullName).Substring(0, indRev) + $"{extensao}")
                                        {
                                            File.Move(item.FullName, $@"{Path.GetDirectoryName(item.FullName)}\Superado\{Path.GetFileName(item.FullName)}");
                                        }
                                    }

                                }

                                if (File.Exists($@"{txtPastas.Text}\{pastas[i - 1]}\{Path.GetFileName(arquivo.FullName)}"))
                                {
                                    File.Delete($@"{txtPastas.Text}\{pastas[i - 1]}\{Path.GetFileName(arquivo.FullName)}");
                                }

                                File.Move(arquivo.FullName, $@"{txtPastas.Text}\{pastas[i - 1]}\{Path.GetFileName(arquivo.FullName)}");

                                break;
                            }
                        }
                    }
                }

                MessageBox.Show("Processo concluído");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

    }
}
