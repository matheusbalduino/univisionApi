using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace univisionApi
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //this.getApi();
        }

        internal void getApi()
        {
            string urlAux = "https://integracaoapp.unimedribeirao.net/api/v1/Beneficiarios/00081501124051644/utilizacoes/202102";
            //urlAux += "cdUnidade=" + cdPrestador.ToString().Substring(0, 4);
            //urlAux += "&cdPrestador=" + cdPrestador.ToString().Substring(4);
            //urlAux += "&mmReferencia=" + dbClass.GetSomenteNumeros(referencia).Substring(0, 2);
            //urlAux += "&aaReferencia=" + dbClass.GetSomenteNumeros(referencia).Substring(2);

            string credenciais = "0008user:5240977c3899d7cc28a16eee7e0a7870";
            var encripta = System.Text.Encoding.UTF8.GetBytes(credenciais);
            credenciais = System.Convert.ToBase64String(encripta);

            Uri myUrl = new Uri(urlAux);
            WebRequest myWebRequest = WebRequest.Create(myUrl);
            myWebRequest.Method = "GET";
            myWebRequest.Headers["Authorization"] = "Basic " + credenciais;
            myWebRequest.ContentType = "application/x-www-form-urlencoded";
            WebResponse myWebResponse = myWebRequest.GetResponse();

            System.IO.Stream stream = myWebResponse.GetResponseStream();

            XmlDocument arqXml = new XmlDocument();
            arqXml.Load(stream);
        }
    }
}