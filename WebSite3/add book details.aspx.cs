using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class add_book_details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if(FileUpload1.HasFile )
        {
            //string fname = FileUpload1.FileName.ToString();
            string img = "4" + ".jpg";
            FileUpload1.PostedFile.SaveAs(Server.MapPath("~/image/")+img);

        }
    }
}