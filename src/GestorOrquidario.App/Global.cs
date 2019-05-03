using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;

namespace GestorOrquidario.App
{
    public class Global
    {
        public static string[] EXTENSIONS_LIST
        {
            get
            {
                string[] _EXTENSIONS_LIST = new string[]  { "jpg", "jpeg", "bmp", "png", "gif" };
                return _EXTENSIONS_LIST;
            }
        }

        public static string FILTER_EXTENSION
        {
            get
            {
                string _FILTER_EXTENSION = "Todos os arquivos de imagem|*.jpg;*.jpeg;*.bmp;*.png;*.gif|JPEG| *.jpg;*.jpeg|Bitmap|*.bmp|PNG|*.png|GIF|*.gif|Todos os arquivos|*.*";
                return _FILTER_EXTENSION;
            }
        }

        public static System.Byte[] OpenImageByte(string path)
        {
            System.Drawing.Image imagem = System.Drawing.Bitmap.FromFile(path);
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            imagem.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

            return ms.ToArray();
        }

        public static System.Byte[] ConvertImageToByte(System.Drawing.Image image)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            return ms.ToArray();
        }

        public static System.Drawing.Image ConvertByteToImage(System.Byte[] imageByte)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imageByte);
            System.Drawing.Image image = System.Drawing.Bitmap.FromStream(ms);

            Graphics g = Graphics.FromImage(image);
            g.DrawImage(image, 0, 0);
            
            return image;
        }

        public static void GetZip(string origem, string destino)
        {
            FileInfo dirInfo = new FileInfo(destino);
            if (!dirInfo.Directory.Exists) Directory.CreateDirectory(dirInfo.Directory.FullName);

            using (ZipFile zip = new ZipFile())
            {
                ZipEntry e = zip.AddFile(origem, "");

                zip.Comment = "Backup realizado dia " + DateTime.Now.ToString("dd/MM/yyyy") + " as " + DateTime.Now.ToString("HH:mm:ss") + ".";
                zip.Save(destino);
            }
        }
    }
}
