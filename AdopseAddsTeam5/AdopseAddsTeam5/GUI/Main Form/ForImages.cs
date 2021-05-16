using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using Renci.SshNet;
using System.Text.Encodings;

namespace AdopseAddsTeam5.GUI.Main_Form
{
    public class ForImages
    {

        //metatropi foto se string gia ton User
        public static void imageToString(Bitmap bitmap)
        {
            Image image = bitmap;
            var ms = new MemoryStream(); 
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            DataAccess.UserImage(MainForm.user1.EmailAddress , Convert.ToBase64String(ms.ToArray()));
        }

        //metatropi foto se string gia tin Add
        public static void imageToStringAdd(Bitmap bitmap)
        {
            Image image = bitmap;
            var ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            DataAccess.addImage(MainForm.newuseradd.sid, Convert.ToBase64String(ms.ToArray()));
        }

        //anaktisi foto apo string
        public static Image stringToImage(string image)
        {
            byte[] bytes = Convert.FromBase64String(image);
            MemoryStream ms = new MemoryStream(bytes, 0, bytes.Length);
            ms.Write(bytes, 0, bytes.Length);
            System.Drawing.Image imageMemoryStream = System.Drawing.Image.FromStream(ms, true);
            return imageMemoryStream;
        }



        //methodos gia to static google maps 
        public static string googleMaps(string perioxi, string dieuthinsi, int x, int y)
        {
            string city = perioxi;
            string street = dieuthinsi;
            string w = x.ToString();
            string h = y.ToString();

            StringBuilder queryaddress = new StringBuilder();
            queryaddress.Append("https://maps.googleapis.com/maps/api/staticmap?center=");
                if ( street != string.Empty)
                {
                queryaddress.Append(street + "," + "+");
                }
                if (city != string.Empty)
                {
                    queryaddress.Append(city + "," + "+");
                }
            queryaddress.Append("&zoom=17&size="+w+"x"+h+"&markers=color:red|");
            queryaddress.Append(city + "+");
            queryaddress.Append(street);
            queryaddress.Append("&key=AIzaSyAcIRhdafdixebdvXHyF6PS4dAFtvy431w");
            //edw theli to areas opou 8a emfanizete to map
            //p.x.--> webBrowser1.Navigate(queryaddress.ToString());
            return queryaddress.ToString();
        }

        //dimiourgia tou fakelou twn fwto tis kathe aggelias
        public static void createPhotoDir(int addsid)
        {
            string host = @"users.iee.ihu.gr";
            string username = "it144377";
            string password = "Vainoe3zit144377#$";
            try
            {

                int port = 22;
                string destinationpath = "/home/student/it/2014/it144377/public_html/Images/" + addsid.ToString() + "/";

                using (SftpClient client = new SftpClient(host, port, username, password))
                {
                    client.Connect();
                    client.CreateDirectory("/home/student/it/2014/it144377/public_html/Images/" + "add" + addsid.ToString() + "/");
                }
            }
            catch (Exception)
            {
                throw;
            }

        }


        //anevasma foto me sftp
        public static void sftpSendImage(int addsid, string imagePath, int counter)
        {
            string filename = imagePath;
            string host = @"users.iee.ihu.gr";
            string username = "it144377";
            string password = "Vainoe3zit144377#$";

            try
            {

                int port = 22;
                //edw apo katw na pros8esw to sid
                string destinationpath = "/home/student/it/2014/it144377/public_html/Images/"+ "add" + addsid.ToString() + "/";
                
                using (SftpClient client = new SftpClient(host, port, username, password))
                {
                    client.Connect();
                    client.ChangeDirectory(destinationpath);
                    using (FileStream fs = new FileStream(filename, FileMode.Open))
                    {
                        client.BufferSize = 4 * 1024;
                        string s = Path.GetFileName(filename);
                        client.UploadFile(fs, Path.GetFileName(filename));
                        client.RenameFile("/home/student/it/2014/it144377/public_html/Images/" + "add"+addsid.ToString() + "/" + Path.GetFileName(filename), "/home/student/it/2014/it144377/public_html/Images/" +"add"+ addsid.ToString()+"/"+"photo_"+counter.ToString()+".png");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //metritis fwtografiwn tis kathe aggelias
        public static void imageCounter(int addsid)
        {
            string host = @"users.iee.ihu.gr";
            string username = "it144377";
            string password = "Vainoe3zit144377#$";
            try
            {
                int port = 22;
                //edw apo katw na pros8esw to sid
                string destinationpath = "/home/student/it/2014/it144377/public_html/Images/" + "add" + addsid.ToString() + "/";
                int x = 0;
                using (SftpClient client = new SftpClient(host, port, username, password))
                {
                    client.Connect();
                    client.ChangeDirectory(destinationpath);
                    string filepath = "/home/student/it/2014/it144377/public_html/Images/" + "add" + addsid.ToString() + "/" + "photo_" + x.ToString() + ".png";
                    while (client.Exists(filepath))
                    {
                        x = x + 1;
                        filepath = "/home/student/it/2014/it144377/public_html/Images/" + "add" + addsid.ToString() + "/" + "photo_" + x.ToString() + ".png";
                    }
                }
                DataAccess.setPhotoNum(addsid,x);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //emfanisi foto se webBrowser 
        public static string showAddImages(int addsid, int photonumber)
        {
            StringBuilder queryaddress = new StringBuilder();
            queryaddress.Append("https://users.iee.ihu.gr/~it144377/Images/"+"add"+addsid.ToString());
            queryaddress.Append("/photo_"+photonumber.ToString()+".png");
            //webBrowser1.Navigate(queryaddress.ToString());
            //https://users.iee.ihu.gr/~it144377/
            return queryaddress.ToString();
        }

    }
}
