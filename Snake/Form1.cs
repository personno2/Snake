using System;
using System.Diagnostics;
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
			Debug.WriteLine(3);

			Start(20, pictureBox1);

		}
		private List<Tuple<int, int>> freeSpaces = new List<Tuple<int, int>>();
		private Queue<Tuple<int, int>> snake = new Queue<Tuple<int, int>>();
		private Tuple<int, int> snakeHead;

		private Tuple<int, int> apple;

		private int size;
		private int squareSize = 50;
		private int squareMargin = 2;




		public void Start(int size, PictureBox p)
		{

			//pictureBox1.Size.Width. = squareSize * size;
			//pictureBox1.Size.Height = squareSize * size;

			this.size = size;

			int mid = size / 2;

			apple = new Tuple<int, int>(mid + 3, mid);
			snakeHead = new Tuple<int, int>(mid - 1, mid);

			for (int x = 0; x < size; x++)
			{
				for (int y = 0; y < size; y++)
				{
					freeSpaces.Add(Tuple.Create(x, y));
				}
			}

			for (int i = 3; i > 0; i--)
			{
				snake.Enqueue(new Tuple<int, int>(mid - i, mid));
				freeSpaces.Remove(Tuple.Create(mid - 1, mid));
			}
			Debug.WriteLine(2);

			GameLoop();
		}

		private async void GameLoop()
		{
			Random r = new Random();

			Tuple<int, int> direction = new Tuple<int, int>(1, 0);

			while (true)
			{
				if (int.Parse(textBoxFPS.Text) >= 250)
				{
					labelActualFPS.Text = "MAX";
				}
				else
				{
					//labelActualFPS.Text = ;
					await Task.Delay(1000 / int.Parse(labelActualFPS.Text));
				}

				Draw();
				snakeHead = new Tuple<int, int>(snakeHead.Item1 + direction.Item1, snakeHead.Item2 + direction.Item2);

				snake.Enqueue(snakeHead);
				freeSpaces.Remove(snakeHead);

				Debug.WriteLine(snakeHead);
				Debug.WriteLine(apple);
				if (snakeHead.Equals(apple))
				{
					apple = freeSpaces[r.Next(freeSpaces.Count)];
					Debug.WriteLine(1);
				}
				else
				{
					freeSpaces.Add(snake.Dequeue());
				}

			}
		}

		private void Draw(bool lost = false)
		{
			SKImageInfo imageInfo = new SKImageInfo(size * squareSize, size * squareSize);
			using (SKSurface surface = SKSurface.Create(imageInfo))
			{
				SKCanvas canvas = surface.Canvas;

				if (lost)
				{
					//text

				}
				else
				{
					using SKPaint paintApple = new SKPaint(),
								  paintSnake = new SKPaint();

					paintApple.Color = SKColors.Red;
					paintApple.IsAntialias = true;
					paintApple.Style = SKPaintStyle.Fill;

					paintSnake.Color = SKColors.Green;
					paintSnake.IsAntialias = true;
					paintSnake.Style = SKPaintStyle.Fill;

					Debug.WriteLine(squareSize * apple.Item1 + ", " + squareSize * apple.Item2 + ", " + (squareSize / 2 - squareMargin));
					canvas.DrawCircle(squareSize * apple.Item1, squareSize * apple.Item2, squareSize / 2 - squareMargin, paintApple); //arguments are x position, y position, radius, and paint

					foreach (Tuple<int, int> s in snake)
					{
						canvas.DrawRect(s.Item1 * squareSize - squareSize / 2 + squareMargin, s.Item2 * squareSize - squareSize / 2 + squareMargin, squareSize - 2 * squareMargin, squareSize - 2 * squareMargin, paintSnake);
					}
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
