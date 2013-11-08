using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public enum SweepDirection
        {
            CounterClockwise,
            Clockwise,
        }

        private Vector2 PointOnCircle(float radius, float angle)
        {
            return new Vector2((float)Math.Cos(angle) * radius, (float)Math.Sin(angle) * radius);
        }

        private GraphicsPath GetArc(Graphics g, Vector2 center, float radiusX, float radiusY, float theta, float eta1, float eta2, SweepDirection sweepDirection)
        {
            const float twoPi = (float)(2 * Math.PI);

            var path = new GraphicsPath();

            float radius = Math.Min(radiusX, radiusY);
            float widthFactor = radiusX / radius;
            float heightFactor = radiusY / radius;

            eta1 = eta1 % twoPi;
            eta2 = eta2 % twoPi;
            if (sweepDirection == SweepDirection.Clockwise)
            {
                float temp = eta1;
                eta1 = eta2;
                eta2 = temp;
            }

            float alpha = eta2 - eta1;
            float startAngle = eta1;
            while (alpha > 0)
            {
                float a = Math.Min(alpha, (float)(Math.PI / 2));
                float l = 4 * (float)Math.Tan(a / 4) / 3 * radius;
                Vector2 p0 = this.PointOnCircle(radius, startAngle);
                Vector2 p1 = p0 + p0.Normalize().CrossProduct() * l;
                Vector2 p3 = this.PointOnCircle(radius, startAngle + a);
                Vector2 p2 = p3 + p3.Normalize().CrossProduct() * -l;
                p0.X *= widthFactor;
                p0.Y *= heightFactor;
                p1.X *= widthFactor;
                p1.Y *= heightFactor;
                p2.X *= widthFactor;
                p2.Y *= heightFactor;
                p3.X *= widthFactor;
                p3.Y *= heightFactor;
                p0 += center;
                p1 += center;
                p2 += center;
                p3 += center;
                g.FillEllipse(Brushes.Blue, new RectangleF(p0.X - 5, p0.Y - 5, 10, 10));
                g.FillEllipse(Brushes.Blue, new RectangleF(p1.X - 5, p1.Y - 5, 10, 10));
                g.FillEllipse(Brushes.Blue, new RectangleF(p2.X - 5, p2.Y - 5, 10, 10));
                g.FillEllipse(Brushes.Blue, new RectangleF(p3.X - 5, p3.Y - 5, 10, 10));
                path.AddBezier(new PointF(p0.X, p0.Y), new PointF(p1.X, p1.Y), new PointF(p2.X, p2.Y), new PointF(p3.X, p3.Y));

                alpha -= a;
                startAngle += a;
            }

            return path;
        }

        private void drawingPanel1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            float minX = (drawingPanel1.Width - 2 * xTrackBar.Value) / 2.0f;
            float minY = (drawingPanel1.Height - 2 * yTrackBar.Value) / 2.0f;
            float maxX = minX + 2 * xTrackBar.Value;
            float maxY = minY + 2 * yTrackBar.Value;
            float centerX = (minX + maxX) / 2.0f;
            float centerY = (minY + maxY) / 2.0f;

            using (var matrix = new Matrix())
            {
                matrix.RotateAt(thetaTrackBar.Value, new PointF(centerX, centerY));
                g.Transform = matrix;

                g.DrawEllipse(Pens.Gray, new RectangleF(minX, minY, 2 * xTrackBar.Value, 2 * yTrackBar.Value));
                g.DrawLine(Pens.Gray, new PointF(minX, centerY), new PointF(maxX, centerY));
                g.DrawLine(Pens.Gray, new PointF(centerX, minY), new PointF(centerX, maxY));

                g.ResetTransform();
            }

            using (GraphicsPath arc = this.GetArc(g, new Vector2(centerX, centerY), xTrackBar.Value, yTrackBar.Value, thetaTrackBar.Value / 180.0f * (float)Math.PI, eta1TrackBar.Value / 180.0f * (float)Math.PI, eta2TrackBar.Value / 180.0f * (float)Math.PI, SweepDirection.CounterClockwise))
            {
                using (var p = new Pen(Color.Red, 3))
                {
                    g.DrawPath(p, arc);
                }
            }
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            drawingPanel1.Invalidate();
        }
    }

    public class DrawingPanel : Panel
    {
        public DrawingPanel()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
            this.UpdateStyles();
        }
    }

    /// <summary>
    /// Ein Paar von X- und Y-Koordinaten.
    /// </summary>
    [Serializable]
    public struct Vector2 : IEquatable<Vector2>
    {
        /// <summary>
        /// Erstellt einen neuen Vektor.
        /// </summary>
        /// <param name="x">Die X-Koordinate des Vektors.</param>
        /// <param name="y">Die Y-Koordinate des Vektors.</param>
        public Vector2(float x, float y)
            : this()
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Die X-Koordinate des Vektors.
        /// </summary>
        public float X { get; set; }

        /// <summary>
        /// Die Y-Koordinate des Vektors.
        /// </summary>
        public float Y { get; set; }

        /// <summary>
        /// Die Länge dieses Vektors.
        /// </summary>
        public float Length
        {
            get { return (float)Math.Sqrt(X * X + Y * Y); }
        }

        /// <summary>
        /// Normalisiert diesen Vektor.
        /// </summary>
        public Vector2 Normalize()
        {
            return this / this.Length;
        }

        /// <summary>
        /// Gibt das Kreuzprodukt dieses Vektors zurück.
        /// </summary>
        public Vector2 CrossProduct()
        {
            return new Vector2(-Y, X);
        }

        /// <summary>
        /// Berechnet das Skalarprodukt zweier Vektoren.
        /// </summary>
        public static float DotProduct(Vector2 left, Vector2 right)
        {
            return left.X * right.X + left.Y * right.Y;
        }

        /// <summary>
        /// Berechnet das Vektorprodukt zweier Vektoren.
        /// </summary>
        public static float VectorProduct(Vector2 left, Vector2 right)
        {
            return left.X * right.Y - left.Y * right.X;
        }

        public static bool operator ==(Vector2 left, Vector2 right)
        {
            return left.X == right.X && left.Y == right.Y;
        }

        public static bool operator !=(Vector2 left, Vector2 right)
        {
            return left.X != right.X || left.Y != right.Y;
        }

        public static Vector2 operator +(Vector2 left, Vector2 right)
        {
            return new Vector2(left.X + right.X, left.Y + right.Y);
        }

        public static Vector2 operator -(Vector2 left, Vector2 right)
        {
            return new Vector2(left.X - right.X, left.Y - right.Y);
        }

        public static Vector2 operator -(Vector2 value)
        {
            return new Vector2(-value.X, -value.Y);
        }

        public static Vector2 operator *(Vector2 value, float scalar)
        {
            return new Vector2(value.X * scalar, value.Y * scalar);
        }

        public static Vector2 operator *(float scalar, Vector2 value)
        {
            return new Vector2(scalar * value.X, scalar * value.Y);
        }

        public static Vector2 operator /(Vector2 value, float scalar)
        {
            return new Vector2(value.X / scalar, value.Y / scalar);
        }

        public override bool Equals(object obj)
        {
            if (obj is Vector2)
                return this == (Vector2)obj;
            else
                return false;
        }

        public bool Equals(Vector2 other)
        {
            return this == other;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("Vector2 { X={0}, Y={1} }", X, Y);
        }
    }
}
