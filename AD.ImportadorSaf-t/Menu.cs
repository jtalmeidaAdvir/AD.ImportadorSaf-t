
using Primavera.Extensibility.BusinessEntities;
using Primavera.Extensibility.CustomForm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD.ImportadorSaf_t
{
    public partial class Menu : CustomForm
    {

        private const string JAR_FILE = "FACTEMICLI-2.8.5-86076-cmdClient.jar";//"FACTEMICLI-2.8.4-60332-cmdClient.jar";

        public Menu()
        {
            InitializeComponent();
        }

        private void btnSelecionarFicheiro_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Ficheiros XML (*.xml)|*.xml|Todos os ficheiros (*.*)|*.*";
                openFileDialog.Title = "Selecionar Ficheiro SAF-T";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFicheiro.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            // Validar campos
            if (string.IsNullOrWhiteSpace(txtFicheiro.Text))
            {
                MessageBox.Show("Por favor, selecione um ficheiro SAF-T.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!File.Exists(txtFicheiro.Text))
            {
                MessageBox.Show("O ficheiro selecionado não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNIF.Text))
            {
                MessageBox.Show("Por favor, insira o NIF.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Por favor, insira a password.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAno.Text))
            {
                MessageBox.Show("Por favor, insira o ano.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMes.Text))
            {
                MessageBox.Show("Por favor, insira o mês.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar se o JAR existe no mesmo diretório do executável ou em C:\SAFT\envio
            string jarPath = FindJarFile();
            if (string.IsNullOrEmpty(jarPath))
            {
                MessageBox.Show($"Ficheiro {JAR_FILE} não encontrado.\nPor favor, coloque-o na mesma pasta da aplicação ou em C:\\SAFT\\envio",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Executar comando
            ExecutarComando(jarPath);
        }

        private string FindJarFile()
        {
            // Procurar no diretório da aplicação
            string appPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, JAR_FILE);
            if (File.Exists(appPath))
                return appPath;

            // Procurar em C:\SAFT\envio
            string saftPath = Path.Combine(@"C:\SAFT\envio", JAR_FILE);
            if (File.Exists(saftPath))
                return saftPath;

            return null;
        }

        private async void ExecutarComando(string jarPath)
        {
            try
            {
                btnExecutar.Enabled = false;
                progressBar.Visible = true;
                progressBar.Style = ProgressBarStyle.Marquee;
                progressBar.MarqueeAnimationSpeed = 30;

                string operacao = rbValidar.Checked ? "validar" : "enviar";
                lblStatus.Text = $"A {(rbValidar.Checked ? "validar" : "enviar")} ficheiro SAF-T...";
                txtResultado.Text = "A executar comando...\r\n";
                string workingDir = Path.GetDirectoryName(jarPath);
                string outputFile = Path.Combine(workingDir, $"resultado-{operacao}.txt");

                // Construir argumentos do Java
                string arguments = $"-Xmx2048m -jar \"{jarPath}\" " +
                    $"-i \"{txtFicheiro.Text}\" " +
                    $"-n {txtNIF.Text}/1 " +
                    $"-p {txtPassword.Text} " +
                    $"-a {txtAno.Text} " +
                    $"-m {txtMes.Text} " +
                    $"-op {operacao} " +
                    $"-o \"{outputFile}\"";

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = @"C:\Program Files\Eclipse Adoptium\jdk-17.0.17.10-hotspot\bin\java.exe", // Caminho absoluto do Java
                    Arguments = arguments,
                    WorkingDirectory = workingDir,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    StandardOutputEncoding = Encoding.UTF8,
                    StandardErrorEncoding = Encoding.UTF8
                };

                // Executar em Task separada para não bloquear a UI
                await Task.Run(() =>
                {
                    using (Process process = new Process())
                    {
                        process.StartInfo = startInfo;

                        process.OutputDataReceived += (sender, e) =>
                        {
                            if (!string.IsNullOrEmpty(e.Data))
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    txtResultado.AppendText(e.Data + "\r\n");
                                });
                            }
                        };

                        process.ErrorDataReceived += (sender, e) =>
                        {
                            if (!string.IsNullOrEmpty(e.Data))
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    txtResultado.AppendText("ERRO: " + e.Data + "\r\n");
                                });
                            }
                        };

                        process.Start();
                        process.BeginOutputReadLine();
                        process.BeginErrorReadLine();
                        process.WaitForExit();

                        // Ler ficheiro de resultado se existir
                        if (File.Exists(outputFile))
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                txtResultado.AppendText("\r\n=== RESULTADO DO FICHEIRO ===\r\n");
                                txtResultado.AppendText(File.ReadAllText(outputFile, Encoding.UTF8));
                            });
                        }

                        this.Invoke((MethodInvoker)delegate
                        {
                            progressBar.Visible = false;
                            lblStatus.Text = "";
                            txtResultado.AppendText($"\r\nProcesso terminado com código: {process.ExitCode}\r\n");
                            btnExecutar.Enabled = true;

                            if (process.ExitCode == 0)
                            {
                                MessageBox.Show("Operação concluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Operação concluída com erros. Verifique o resultado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        });
                    }
                });
            }
            catch (Exception ex)
            {
                progressBar.Visible = false;
                lblStatus.Text = "";
                txtResultado.AppendText($"\r\nERRO: {ex.Message}\r\n");
                MessageBox.Show($"Erro ao executar comando:\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnExecutar.Enabled = true;
            }
        }
    }
}
 