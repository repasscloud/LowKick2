using System.Diagnostics;

namespace docx2pdf;

class Program
{
    static void Main(string[] args)
    {
        string dataDirectory = $"/data/{args[0]}";
        string[] docxFiles = Directory.GetFiles(dataDirectory, "*.docx");
        string[] docFiles = Directory.GetFiles(dataDirectory, "*.doc");

        if (docxFiles.Length > 0)
        {
            foreach (string docxFile in docxFiles)
            {
                ProcessStartInfo startInfo = new ProcessStartInfo("/usr/bin/soffice");
                startInfo.Arguments = $"--headless --convert-to pdf:writer_pdf_Export --outdir /data/pdfconvert/{args[0]}/ {docxFile}";
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
                if (File.Exists(docxFile))
                {
                    File.Delete(docxFile);
                }
            }
        }
        if (docFiles.Length > 0)
        {
            foreach (string docFile in docxFiles)
            {
                ProcessStartInfo startInfo = new ProcessStartInfo("/usr/bin/soffice");
                startInfo.Arguments = $"--headless --convert-to pdf:writer_pdf_Export --outdir /data/pdfconvert/{args[0]}/ {docFile}";
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
                if (File.Exists(docFile))
                {
                    File.Delete(docFile);
                }
            }
        }
    }
}
