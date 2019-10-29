using System;
using System.IO;
using System.Web;

namespace SimpleLogApplication.Models
{
    public class RegistraLog
    {
        private static string caminhoAplicacao = string.Empty;

        public static bool Log(string mensagem, string nomeArquivo = "LogGeral")
        {
            try
            {
                RegistraLog.caminhoAplicacao = HttpContext.Current.Server.MapPath("~/App_Data");
                string path = Path.Combine(RegistraLog.caminhoAplicacao, nomeArquivo + ".txt");
                if (!File.Exists(path))
                    File.Create(path).Close();
                using (StreamWriter streamWriter = File.AppendText(path))
                    RegistraLog.AppendLog(mensagem, (TextWriter)streamWriter);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private static void AppendLog(string mensagem, TextWriter writer)
        {
            try
            {
                writer.Write("\r\nLog Entrada: ");
                TextWriter textWriter = writer;
                DateTime now = DateTime.Now;
                string longTimeString = now.ToLongTimeString();
                now = DateTime.Now;
                string longDateString = now.ToLongDateString();
                string str = longTimeString + " " + longDateString;
                textWriter.Write(str);
                writer.WriteLine("");
                writer.WriteLine("Mensagem: " + mensagem + "\n");
                writer.WriteLine("------------------------------------------");
            }
            catch (Exception ex)
            {
            }
        }
    }
}