namespace DrawRectangle;

/// <summary>
/// A class to draw a rectangle with an embedded image
/// and perform computation geometry on the rectangle.
/// </summary>
public partial class FormDrawRectangle : Form
{
    Rectangle srcRect;

    // Creates a new instance of the FormDrawRectangle class.
    public FormDrawRectangle ()
    {
        InitializeComponent ();
    }

    /// <summary>
    /// Draws an image in a rectangle.
    /// </summary>
    /// <param name="e"></param>
    public void DrawImageInRectangle (PaintEventArgs e)
    {

        Image newImage = Image.FromFile (@"..\..\..\Images\Aunt Lee.jpeg");
        Pen skyBluePen = new (Brushes.SkyBlue);

        srcRect          = new (20, 20, 1300, 1600);
        skyBluePen.Width = 8.0F;
        DoubleBuffered   = true;

        e.Graphics.DrawRectangle (skyBluePen, srcRect);
        e.Graphics.DrawImageUnscaledAndClipped (newImage, srcRect);
        skyBluePen.Dispose ();
        newImage.Dispose ();
    }

    // Handles the form's Paint event.
    private void OnPaint (object sender, PaintEventArgs e)
    {
        DrawImageInRectangle (e);
    }

    // Handles the button's click event.
    private void OnClickCompute (object sender, EventArgs e)
    {
        int area          = srcRect.Width * srcRect.Height;
        int circumference = 2 * srcRect.Width + 2 * srcRect.Height;

        tbArea.Text          = string.Format ($"{area:N0}");
        tbCircumference.Text = string.Format ($"{circumference:N0}");
    }
}
/* Temporary Area for Test Examples

*/
