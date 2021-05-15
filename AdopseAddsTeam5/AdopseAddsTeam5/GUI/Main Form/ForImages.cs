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
        public static void imageToString(Bitmap bitmap)
        {
            Image image = bitmap;
            var ms = new MemoryStream();  // this is where we are going to deposit the bytes
            // save bytes to ms
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            // to get the bytes we type
            //var bytes = ms.ToString();

            // we can now save the byte array to a db, file, or transport (stream) it
            DataAccess.UserImage(MainForm.user1.EmailAddress , Convert.ToBase64String(ms.ToArray()));
        }

        //anaktisi foto tou user
        public static Image stringToImage(string image)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(image);
            Image imageMemoryStream = Image.FromStream(new MemoryStream(bytes));
            return imageMemoryStream;
        }



        //methodos gia to static google maps 
        public static string googleMaps(string perioxi , string dieuthinsi)
        {
            string city = perioxi;
            string street = dieuthinsi;

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
            queryaddress.Append("&zoom=17&size=600x400&markers=color:red|");
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
                string destinationpath = "/home/student/it/2014/it144377/public_html/Images/" + addsid.ToString() + "/";
                int x = 0;
                using (SftpClient client = new SftpClient(host, port, username, password))
                {
                    client.Connect();
                    client.ChangeDirectory(destinationpath);
                    string filepath = "/home/student/it/2014/it144377/public_html/Images/" + "add" + addsid.ToString() + "/" + "photo_" + x.ToString() + "/";
                    while (File.Exists(filepath))
                    {
                        x = x + 1;
                        filepath = "/home/student/it/2014/it144377/public_html/Images/" + "add" + addsid.ToString() + "/" + "photo_" + x.ToString() + "/";
                    }
                }
                DataAccess.setPhotoNum(x);
            }
            catch (Exception)
            {
                throw;
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
