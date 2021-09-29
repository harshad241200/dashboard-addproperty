using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace dashboardss
{
    public partial class Addproperty : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void savecard(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            SqlConnection con = null;

            try
            {
                string propname = pname.Text;
                string Minprise = minprice.Text;
                string Maxprise = maxprice.Text;
                string Facebookurl = facebookurl.Text;
                string Instagramurl = instagramurl.Text;
                string Whatsappno = whatsappno.Text;
                string Youtubeviewurl = youtubeviewurl.Text;
                string Areainsqft = areainsqft.Text;
                string Noofbedroom = noofbathroom.Text;
                string Noofbathroom = noofbathroom.Text;
                string GArage = garage.Text;
                string Listpropertyfor = listpropertyfor.Text;
                string Ihavea = ihavea.Text;
                string Propertytype = propertytype.Text;
                string Availablefor = availablefor.Text;
                string Googlemapurl = Request.Form["googlemapurl"];
                string Shortdiscription = shortdiscription.Text;
                string Longdiscription = Request.Form["editor1"];
                string Nearbyplace = Request.Form["editor2"];
                string LandMark = landmark.Text;
                string CiTy = city.Text;
                string PinCode = pincode.Text;
                string Fulladdress = Request.Form["fulladdress"];
                string SaveLocation = "";
                string newlocation = "";
                Guid g = Guid.NewGuid();
                if ((FileUpload1.PostedFile != null) && (FileUpload1.PostedFile.ContentLength > 0))
                {
                    string fn = System.IO.Path.GetFileName(FileUpload1.PostedFile.FileName);
                    SaveLocation = Server.MapPath("Uploads") + "\\" + g + fn;
                    newlocation = "\\" + "Uploads" + "\\" + g + fn;
                    FileUpload1.PostedFile.SaveAs(SaveLocation);
                }
                
                 con = new SqlConnection(strcon);
                string sql = "insert into  Addproperty1(pname ,minprice,maxprice ,uploadfile ,facebookurl ,instagramurl ,whatsapp,youtubeviewurl ,areainsqft ,noofbedroom ,noofbathroom ,garage,listpropertyfor ,ihavea ,propertytype ,availablefor ,googlemapurl,shortdiscription ,longdescription ,nearbyplaces ,landmark ,city,pincode ,fulladdress) values('" + propname + "', '" + Minprise +"','" + Maxprise + "','" + newlocation + "','" + Facebookurl + "','" +Instagramurl + "','" + Whatsappno + "','" + Youtubeviewurl + "','" +Areainsqft + "','" + Noofbedroom + "','" + Noofbathroom + "','" +GArage + "','" + Listpropertyfor + "','" + Ihavea + "','" +Propertytype + "','" + Availablefor + "','" + Googlemapurl + "','" +Shortdiscription + "','" + Longdiscription + "','" + Nearbyplace +"','" + LandMark + "','" + CiTy + "','" + PinCode + "','" +Fulladdress + "')";
                
               SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                int status = cmd.ExecuteNonQuery();
                if (status > 0)
                {
                    Console.WriteLine("success");
                }
                else
                {
                    Console.WriteLine("fail");
                }
            
          }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}