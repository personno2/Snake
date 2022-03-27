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



public class Game
{
	private List<Tuple<int, int>> freeSpaces = new List<Tuple<int, int>>();	
	private Queue<Tuple<int, int>> snake = new Queue<Tuple<int, int>>();
	private Tuple<int, int> snakeHead;
	
	private Tuple<int, int> apple;

	private int size;
	
	private PictureBox pictureBox1; 


	public Game(int size, PictureBox p)
	{
		pictureBox1 = p;

		this.size = size;

		int mid = size / 2;	

		apple = new Tuple<int, int>(mid + 3, mid);
		snakeHead = new Tuple<int, int>(mid, mid);

		for (int x = 0; x < size; x++)
		{
			for (int y = 0; y < size; y++)
			{
				freeSpaces.Add(Tuple.Create(x, y));
			}
		}

		for (int i = 0; i < 3; i++)
		{
			snake.Enqueue(new Tuple<int, int>(mid - i, mid));
			freeSpaces.Remove(Tuple.Create(mid - 1, mid));
		}

		GameLoop();
	}

	private void GameLoop()
	{
		Random r = new Random();

		Tuple<int, int> direction = new Tuple<int, int>(1, 0);

		while (true)
		{
			snakeHead = new Tuple<int, int>(snakeHead.Item1 + direction.Item1, snakeHead.Item2 + direction.Item2);

			snake.Enqueue(snakeHead);
			freeSpaces.Remove(snakeHead);

			Console.WriteLine(snakeHead);
			Console.WriteLine(apple);
			if (snakeHead == apple)
			{
				apple = freeSpaces[r.Next(freeSpaces.Count)];
				Console.WriteLine(1);
			}
			else
			{
				freeSpaces.Add(snake.Dequeue());
			}

		}
	}

	private void Draw(bool lost = false)
	{
		SKImageInfo imageInfo = new SKImageInfo(300, 250);
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
				paintApple.Color = SKColors.Blue;
				paintApple.IsAntialias = true;
				paintApple.Style = SKPaintStyle.Fill;
				canvas.DrawCircle(50, 50, 30, paintApple); //arguments are x position, y position, radius, and paint
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
