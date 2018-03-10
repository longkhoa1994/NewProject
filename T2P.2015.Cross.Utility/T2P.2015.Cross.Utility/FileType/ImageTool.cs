using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace T2P._2015.Cross.Utility.FileType
{
    public class ImageTool
    {
        public void AddTextToImage(string filePathInput, string filePathOutput, string textToAdd, Brush brush, int xPost, int yPost, string fontFamily = "Times New Roman", int fontSize = 10)
        {
            try
            {

                Image image = Image.FromFile(filePathInput);// get image to path input
                Point point = new Point(xPost, yPost);

                Graphics graphics = Graphics.FromImage(image);

                Font font = new Font(fontFamily, fontSize);

                graphics.DrawString(textToAdd, font, brush, point);

                image.Save(filePathOutput);
            }
            catch (Exception ex)
            {
                Log.Logging.Error("Add Text To Image " + DateTime.Now.ToString("ddMMyyyy").ToString() + ex.Message + ex.InnerException);
            }

        }
    }
}
