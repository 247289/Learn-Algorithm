using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace lnkFile.CLASS
{
    public class rwFile
    {
        
        public string ExecuteWriteNewFile(string nameFile)
        {
            String line;

            //SHA256 mySHA256 = SHA256Managed.Create();
            //byte[] key = mySHA256.ComputeHash(Encoding.ASCII.GetBytes("3sc3RLrpd17"));
            //byte[] iv = new byte[16] { 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 };
            try
            {
                StreamReader sr = new StreamReader(nameFile);
                StreamWriter sw = new StreamWriter(nameFile + ".txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    AES_AL aesF = new AES_AL();
                    WriteFile(sw, aesF.aesss(line));
                    line = sr.ReadLine();
                }

                sr.Close();
                sw.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Errors: " + e.Message);
            }
            return nameFile + ".txt";
        }

        public void WriteFile(StreamWriter sw, string line)
        {
            try
            {
                sw.WriteLine(line);
            }
            catch (Exception e)
            {
                MessageBox.Show("Errors: " + e.Message);
            }

        }

        
    }
}
