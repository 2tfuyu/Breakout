using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Breakout
{
    public partial class Breakout : Form
    {

        Vector ballPos;
        Vector ballSpeed;
        int ballRadius;
        Rectangle paddlePos;
        List<Rectangle> blockPos;
        Timer _timer;
        int score = 0;

        public Breakout()
        {
            InitializeComponent();

            this.ballPos = new Vector(200, 200);
            this.ballSpeed = new Vector(-2, -4);
            this.ballRadius = 10;
            this.paddlePos = new Rectangle(100, this.Height - 50, 100, 5);

            this.blockPos = new List<Rectangle>();
            for (int x = 0; x <= this.Height; x += 100)
            {
                for (int y = 0; y <= 150; y += 40)
                {
                    this.blockPos.Add(new Rectangle(25 + x, y, 80, 25));
                }
            }

            Timer timer = new Timer();
            timer.Interval = 33;
            timer.Tick += new EventHandler(Update);
            timer.Start();
            _timer = timer;
        }

        private void Update(object sender, EventArgs e)
        {
            ballPos += ballSpeed;

            scoreLabel.Text = "Score: " + this.score.ToString();

            if (this.score == 200)
            {
                _timer.Enabled = false;
                Clear clear = new Clear();
                clear.Show();
                this.Close();
            }

            if (ballPos.X + ballRadius > this.Bounds.Width || ballPos.X - ballRadius < 0)
            {
                ballSpeed.X *= -1;
            }

            if (ballPos.Y - ballRadius < 0)
            {
                ballSpeed.Y *= -1;
            }

            if (ballPos.Y - ballRadius > paddlePos.Y)
            {
                _timer.Enabled = false;
                GameOver gameover = new GameOver();
                gameover.Show();
                this.Close();
            }

            Vector leftTop = new Vector(this.paddlePos.Left, this.paddlePos.Top);
            Vector rightTop = new Vector(this.paddlePos.Right, this.paddlePos.Top);

            if (LineVsCircle(leftTop, rightTop, ballPos, ballRadius))
            {
                ballSpeed.Y *= -1;
            }

            for (int i = 0; i < this.blockPos.Count; i++)
            {
                int collision = BlockVsCircle(blockPos[i], ballPos);

                if (collision == 1 || collision == 2)
                {
                    ballSpeed.Y *= -1;
                    this.score += 10;
                    this.blockPos.Remove(blockPos[i]);
                }
                else if (collision == 3 || collision == 4)
                {
                    ballSpeed.X *= -1;
                    this.score += 10;
                    this.blockPos.Remove(blockPos[i]);
                }

            }

            Invalidate();
        }

        double DotProduct(Vector a, Vector b)
        {
            return a.X * b.X + a.Y * b.Y;
        }

        int BlockVsCircle(Rectangle block, Vector ball)
        {
            Vector leftTop = new Vector(block.Left, block.Top);
            Vector rightTop = new Vector(block.Right, block.Top);

            Vector leftBottom = new Vector(block.Left, block.Bottom);
            Vector rightBottom = new Vector(block.Right, block.Bottom);

            if (LineVsCircle(leftTop, rightTop, ball, ballRadius))
            {
                return 1;
            }

            if (LineVsCircle(leftBottom, rightBottom, ball, ballRadius))
            {
                return 2;
            }

            if (LineVsCircle(rightTop, rightBottom, ball, ballRadius))
            {
                return 3;
            }

            if (LineVsCircle(leftTop, leftBottom, ball, ballRadius))
            {
                return 4;
            }

            return -1;
        }

        bool LineVsCircle(Vector p1, Vector p2, Vector center, float radius)
        {
            Vector lineDir = (p2 - p1);
            Vector n = new Vector(lineDir.Y, -lineDir.X);
            n.Normalize();

            Vector dir1 = center - p1;
            Vector dir2 = center - p2;

            double dist = Math.Abs(DotProduct(dir1, n));

            double a1 = DotProduct(dir1, lineDir);
            double a2 = DotProduct(dir2, lineDir);

            return (a1 * a2 < 0 && dist < radius);
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            SolidBrush pinkBrush = new SolidBrush(Color.HotPink);
            SolidBrush grayBrush = new SolidBrush(Color.DimGray);
            SolidBrush blueBrush = new SolidBrush(Color.LightBlue);

            float px = (float)this.ballPos.X - ballRadius;
            float py = (float)this.ballPos.Y - ballRadius;

            e.Graphics.FillEllipse(pinkBrush, px, py, this.ballRadius * 2, this.ballRadius * 2);
            e.Graphics.FillRectangle(grayBrush, paddlePos);
            for (int i = 0; i < this.blockPos.Count; i++)
            {
                e.Graphics.FillRectangle(blueBrush, blockPos[i]);
            }
        }

        private void KeyPressed(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    this.paddlePos.X -= 20;
                    break;
                case Keys.Right:
                    this.paddlePos.X += 20;
                    break;
            }
        }

        private void Breakout_Load(object sender, EventArgs e)
        {

        }
    }
}
