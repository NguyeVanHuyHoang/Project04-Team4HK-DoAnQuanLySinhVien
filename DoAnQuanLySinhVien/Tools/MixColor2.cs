using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;



class MixColor2 : Panel
{
    public Color ColorTop { get; set; }
    public Color ColorBottom { get; set; }
    public float Angle { get; set; }
    protected override void OnPaint(PaintEventArgs e)
    {

        LinearGradientBrush brush = new LinearGradientBrush(
            this.ClientRectangle, this.ColorTop, this.ColorBottom , this.Angle);
        Graphics g = e.Graphics;
        g.FillRectangle(brush, this.ClientRectangle);
        base.OnPaint(e);


    }
}

