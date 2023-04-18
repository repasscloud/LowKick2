using System.Diagnostics;

namespace pdf2docx;

class Program
{
    static void Main(string[] args)
    {
        string dataDirectory = $"/data/{args[0]}";
        string[] pdfFiles = Directory.GetFiles(dataDirectory, "*.pdf");

        if (pdfFiles.Length > 0)
        {
            foreach (string pdfFile in pdfFiles)
            {
                ProcessStartInfo startInfo = new ProcessStartInfo("/usr/bin/soffice");
                startInfo.Arguments = $"--headless --infilter=writer_pdf_import --convert-to docx --outdir /data/pdfconvert/{args[0]}/ {pdfFile}";
                startInfo.RedirectStandardOutput = true;
                startInfo.RedirectStandardError = true;
                startInfo.UseShellExecute = false;

                Process process = new Process();
                process.StartInfo = startInfo;
                process.OutputDataReceived += (s, e) => { };
                process.ErrorDataReceived += (s, e) => { };
                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                process.WaitForExit();

                // remove the file/s
                if (File.Exists(pdfFile))
                {
                    File.Delete(pdfFile);
                }
            }
        }
    }
}
