﻿using System;
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

		Game game;

		private void startButton_Click(object sender, EventArgs e)
		{
			Debug.WriteLine(3);

			game = new Game(20, pictureBox1);

		}
	}
}
