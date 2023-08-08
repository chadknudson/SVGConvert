using Svg;
using System.Drawing;
using System.Drawing.Imaging;

namespace SVGConvert
{
    public static class SVGConverter
    {
        public static void SvgToJpg(string svgFilePath, string jpgFilePath, int width, int height)
        {
            try
            {
                SvgDocument svgDocument = SvgDocument.Open(svgFilePath);
                if (svgDocument == null)
                {
                    throw new InvalidOperationException("Invalid SVG file.");
                }
                // Maintain the SVG aspect ratio if necessary.
                float aspectRatio = svgDocument.Width / svgDocument.Height;
                if (width < height * aspectRatio)
                {
                    height = (int)(width / aspectRatio);
                }
                else
                {
                    width = (int)(height * aspectRatio);
                }

                Bitmap bitmap = new Bitmap(width, height);
                svgDocument.Draw(bitmap);
                bitmap.Save(jpgFilePath, ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void SvgToPng(string svgFilePath, string pngFilePath, int width, int height)
        {
            try
            {
                SvgDocument svgDocument = SvgDocument.Open(svgFilePath);
                if (svgDocument == null)
                {
                    throw new InvalidOperationException("Invalid SVG file.");
                }

                // Maintain the SVG aspect ratio if necessary.
                float aspectRatio = svgDocument.Width / svgDocument.Height;
                if (width < height * aspectRatio)
                {
                    height = (int)(width / aspectRatio);
                }
                else
                {
                    width = (int)(height * aspectRatio);
                }

                Bitmap bitmap = new Bitmap(width, height);
                svgDocument.Draw(bitmap);
                bitmap.Save(pngFilePath, ImageFormat.Png);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
