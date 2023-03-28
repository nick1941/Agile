namespace DrawRectangle;

public partial class FormDrawRectangle : Form
{
    public FormDrawRectangle ()
    {
        InitializeComponent ();
    }

    public void DrawImage2FloatRectF (PaintEventArgs e)
    {

        // Create image.
        Image newImage = Image.FromFile (@"..\..\..\Images\Aunt Lee.jpeg");

        // Create coordinates for upper-left corner of image.
        float x = 100.0F;
        float y = 100.0F;

        // Create rectangle for source image.
        RectangleF srcRect = new RectangleF (50.0F, 50.0F, 450.0F, 450.0F);
        GraphicsUnit units = GraphicsUnit.Pixel;

        // Draw image to screen.
        e.Graphics.DrawImage (newImage, x, y, srcRect, units);
    }

    private void OnPaint (object sender, PaintEventArgs e)
    {
        DrawImage2FloatRectF (e);
    }
}
/* Temporary Area for Test Examples

*/
