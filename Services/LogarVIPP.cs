using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace ModuloBling.Services
{
    class Logar
    {
        public static bool LogarVipp(string txtUsr, string txtPwd)
        {
            try
            {
                ServicePointManager.Expect100Continue = false;
                if (string.IsNullOrEmpty(ModuloBling.Properties.Settings.Default.WSVippPostarObj))
                {
                    return false;
                }

                HttpWebRequest httpWReq = (HttpWebRequest)WebRequest.Create(ModuloBling.Properties.Settings.Default.WSVippPostarObj + "/vipp/remoto/LoginRemoto.php");

                ASCIIEncoding encoding = new ASCIIEncoding();

                string postData = "";
                postData += "&Login=" + txtUsr;
                postData += "&Senha=" + txtPwd;

                byte[] data = encoding.GetBytes(postData);


                httpWReq.Method = "POST";
                httpWReq.ContentType = "application/x-www-form-urlencoded";
                httpWReq.ContentLength = data.Length;

                using (Stream stream = httpWReq.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                HttpWebResponse response = (HttpWebResponse)httpWReq.GetResponse();

                string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                JsonRetornoLogarVIPP oJsonRetorno = new JavaScriptSerializer().Deserialize<JsonRetornoLogarVIPP>(responseString);


                if (oJsonRetorno.Status.Equals("0"))
                {
                    MessageBox.Show(oJsonRetorno.Msg, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (oJsonRetorno.Status.Equals("1"))
                {
                    return true;
                }

                
                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Impossível Acessar o Site, entre em contato com a VisualSet", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                GC.Collect();
            }

        }
    }
}
