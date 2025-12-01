using ICSharpCode.Decompiler;
using ICSharpCode.Decompiler.CSharp;
using ICSharpCode.Decompiler.Metadata;
using ICSharpCode.Decompiler.TypeSystem;
using SharpDisasm;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheatCracker
{
    public partial class SRC : Form
    {
        public SRC()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += SRC_DragEnter;
            this.DragDrop += SRC_DragDrop;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Executable (*.exe;*.dll)|*.exe;*.dll",
                Title = "Select an executable or .NET assembly"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
                DecompileFileAsync(ofd.FileName);
        }

        private void SRC_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void SRC_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0)
                DecompileFileAsync(files[0]);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOutput.Text))
            {
                MessageBox.Show("No content to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Text File (*.txt)|*.txt",
                Title = "Save Decompiled / Extracted Info"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
                File.WriteAllText(sfd.FileName, txtOutput.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
        }

        private async void DecompileFileAsync(string filePath)
        {
            txtOutput.Text = "Processing, please wait...";
            btnBrowse.Enabled = btnSave.Enabled = false;

            try
            {
                string output = await Task.Run(() => TryDecompileOrExtract(filePath));
                txtOutput.Text = output;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to process the file:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOutput.Clear();
            }
            finally
            {
                btnBrowse.Enabled = btnSave.Enabled = true;
            }
        }

        private string TryDecompileOrExtract(string filePath)
        {

            try
            {
                var resolver = new UniversalAssemblyResolver(filePath, false, null);
                var settings = new DecompilerSettings()
                {
                    ThrowOnAssemblyResolveErrors = false,
                    UsingDeclarations = true
                };
                var decompiler = new CSharpDecompiler(filePath, resolver, settings);
                return decompiler.DecompileWholeModuleAsString();
            }
            catch
            {

            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("File is not a .NET assembly. Showing partial info:\n");


            try
            {
                var allBytes = File.ReadAllBytes(filePath);
                var asciiStrings = ExtractStrings(allBytes, 4);
                sb.AppendLine("=== Strings in file ===");
                foreach (var s in asciiStrings)
                    sb.AppendLine(s);
            }
            catch
            {
                sb.AppendLine("[Failed to extract strings]");
            }


            try
            {
                var codeBytes = File.ReadAllBytes(filePath);
                var archMode = GetArchFromPE(filePath);
                var disasm = new Disassembler(codeBytes, archMode, 0, true);
                sb.AppendLine("\n=== First 100 instructions ===");
                foreach (var ins in disasm.Disassemble().Take(100))
                    sb.AppendLine(ins.ToString());
            }
            catch
            {
                sb.AppendLine("[Failed to disassemble file]");
            }

            return sb.ToString();
        }


        private static ArchitectureMode GetArchFromPE(string filePath)
        {
            try
            {
                using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (var br = new BinaryReader(fs))
                {
                    if (br.ReadUInt16() != 0x5A4D)
                        return ArchitectureMode.x86_32;

                    fs.Seek(0x3C, SeekOrigin.Begin);
                    int peOffset = br.ReadInt32();
                    fs.Seek(peOffset, SeekOrigin.Begin);

                    if (br.ReadUInt32() != 0x00004550)
                        return ArchitectureMode.x86_32;

                    ushort machine = br.ReadUInt16();
                    return machine switch
                    {
                        0x8664 => ArchitectureMode.x86_64,
                        0x014c => ArchitectureMode.x86_32,
                        _ => ArchitectureMode.x86_32
                    };
                }
            }
            catch
            {
                return ArchitectureMode.x86_32;
            }
        }


        private static string[] ExtractStrings(byte[] bytes, int minLength = 4)
        {
            var result = new System.Collections.Generic.List<string>();
            int count = 0;
            StringBuilder sb = new StringBuilder();

            foreach (var b in bytes)
            {
                if (b >= 32 && b <= 126)
                {
                    sb.Append((char)b);
                    count++;
                }
                else
                {
                    if (count >= minLength)
                        result.Add(sb.ToString());
                    sb.Clear();
                    count = 0;
                }
            }

            if (count >= minLength)
                result.Add(sb.ToString());

            return result.ToArray();
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }
    }
}
