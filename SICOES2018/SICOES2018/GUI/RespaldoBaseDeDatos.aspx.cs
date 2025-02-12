﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SICOES2018.GUI
{
    public partial class RespaldoBaseDeDatos : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection();
        SqlCommand sqlcmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBackup_Click(object sender, EventArgs e)
        {
            //IF SQL Server Authentication then Connection String  
            //con.ConnectionString = @"Server=MyPC\SqlServer2k8;database=" + YourDBName + ";uid=sa;pwd=password;";  

            //IF Window Authentication then Connection String  
            con = new SqlConnection("Data Source=sql5037.site4now.net;Initial Catalog=DB_A26FD9_SICOESHunucma;User Id= DB_A26FD9_SICOESHunucma_admin;Password=sicoeshunucma2018;");

            string backupDIR = Server.MapPath(@"~/Respaldos");
            string nombre = DateTime.Now.ToString("ddMMyyyy_HHmmss");
            if (!System.IO.Directory.Exists(backupDIR))
            {
                System.IO.Directory.CreateDirectory(backupDIR);
            }
            try
            {
                
                con.Open();
                sqlcmd = new SqlCommand("backup database DB_A26FD9_SICOESHunucma to disk='" + backupDIR + "\\" + nombre + ".Bak'", con);
                sqlcmd.ExecuteNonQuery();
                con.Close();
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "respaldosuccessalert();", true);
                bdok.Text = "<a href ='" + backupDIR + "/" + nombre + ".bak'>Descargar Respaldo</a>";
            }
            catch (Exception)
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "erroralert();", true);
            }

            
        }
    }
}