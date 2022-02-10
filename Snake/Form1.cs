using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkiaSharp;

namespace Snake
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void startButton_Click(object sender, EventArgs e)
		{
			SKImageInfo imageInfo = new SKImageInfo(300, 250);
			using (SKSurface surface = SKSurface.Create(imageInfo))
			{
				SKCanvas canvas = surface.Canvas;

				using (SKPaint paint = new SKPaint())
				{
					paint.Color = SKColors.Blue;
					paint.IsAntialias = true;
					paint.StrokeWidth = 15;
					paint.Style = SKPaintStyle.Stroke;
					canvas.DrawCircle(50, 50, 30, paint); //arguments are x position, y position, radius, and paint
				}
				
				using (SKImage image = surface.Snapshot())
				using (SKData data = image.Encode(SKEncodedImageFormat.Png, 100))
				using (MemoryStream mStream = new MemoryStream(data.ToArray()))
				{
					Bitmap bm = new Bitmap(mStream, false);
					pictureBox1.Image = bm;
				}
			}
		}
	}
}
