﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace MEIP_System.UI.GeneralManager
{
    public partial class GM_ViewGovtInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RequestViewGovtInfo request = new RequestViewGovtInfo();
            request.Username = Session["Username"].ToString();
            DataTable dt = DAT.ViewGovtInfo(request);

            if (dt.Rows.Count > 0)
            {
                LabelTIN.Text = dt.Rows[0]["TIN"].ToString();
                LabelSSS.Text = dt.Rows[0]["SSS"].ToString();
                LabelPhilHealth.Text = dt.Rows[0]["PhilHealth"].ToString();
                LabelPagibig.Text = dt.Rows[0]["Pagibig"].ToString();
            }
            else
            {
                Response.Redirect("GM_UpdateGovtInfo.aspx");
            }
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login.aspx");
        }
}
}