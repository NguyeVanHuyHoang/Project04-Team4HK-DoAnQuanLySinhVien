using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GradientPanelDemo
{
    class MixColor2 : Panel
    {
        public Color ColorTop { get; set; }
        public Color ColorBottom { get; set; }

     
        protected override void OnPaint(PaintEventArgs e)
        {

            LinearGradientBrush lgb = new LinearGradientBrush(
                this.ClientRectangle, ColorTop, ColorBottom, 180f) ;

            e.Graphics.FillRectangle(lgb, this.ClientRectangle);
            
            SizeF TextSize = e.Graphics.MeasureString(this.Text, this.Font);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb, this.ClientRectangle);
            base.OnPaint(e);
            lgb.Dispose();
            
        }
    }
}
