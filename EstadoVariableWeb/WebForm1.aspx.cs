using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EstadoVariableWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private int numero = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtNumero.Text = "0";
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ViewState["conteo"] !=null)
            {
                numero = (int)ViewState["conteo"] + 1;
                txtNumero.Text = numero.ToString();
                
            }
            ViewState["conteo"] = numero;

        }
    }
}