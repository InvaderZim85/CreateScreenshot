using System.Drawing.Imaging;
using CreateScreenshot.Properties;

namespace CreateScreenshot;

public partial class FormMain : Form
{
    /// <summary>
    /// Creates a new instance of the <see cref="FormMain"/>.
    /// </summary>
    public FormMain()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Occurs when the user hits the browse button (top right).
    /// </summary>
    /// <param name="sender">The <see cref="buttonBrowse"/>.</param>
    /// <param name="e">The event arguments.</param>
    private void ButtonBrowse_Click(object sender, EventArgs e)
    {
        var dialog = new SaveFileDialog
        {
            Filter = "JPG (*.jpg)|*.jpg"
        };

        if (dialog.ShowDialog() != DialogResult.OK)
            return;

        textBoxTarget.Text = dialog.FileName;
    }

    /// <summary>
    /// Occurs when the user hits the clear button (top right, underneath the browse button).
    /// </summary>
    /// <param name="sender">The <see cref="buttonClear"/>.</param>
    /// <param name="e">The event arguments.</param>
    private void buttonClear_Click(object sender, EventArgs e)
    {
        textBoxTarget.Clear();
        radioButtonColor.Checked = true;
        pictureBox.Image = null; // Remove the current image.
    }

    /// <summary>
    /// Occurs when the user hits the "take screenshot" button.
    /// </summary>
    /// <param name="sender">The <see cref="buttonScreenshot"/>.</param>
    /// <param name="e">The event arguments.</param>
    private void buttonScreenshot_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(textBoxTarget.Text))
            return;

        CreateAScreenshot(textBoxTarget.Text);
    }

    /// <summary>
    /// Creates a screenshot of the current monitor.
    /// </summary>
    /// <param name="target">The desired target.</param>
    private void CreateAScreenshot(string target)
    {
        try
        {
            // Reset the image
            pictureBox.Image = Resources.DummyImage;

            // Delete the file if needed.
            if (File.Exists(target))
                return;
                
            // Create the bitmap which is needed for the screenshot
            // The size is not the actual size of the monitor.
            // Change these values so that they meet your requirements.
            var bitmap = new Bitmap(1920, 1080, PixelFormat.Format32bppRgb); // Note: We create an image with color.

            // Create a new rectangle with the size of the main monitor
            var captureRectangle = GetMainMonitor();
            
            // Create a new graphics object
            var captureGraphics = Graphics.FromImage(bitmap);

            // Copy the screen
            captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);

            if (radioButtonColor.Checked)
                bitmap.Save(target);
            else
                ToGrayscale(bitmap, target);

            // Show the image
            pictureBox.Image = Image.FromFile(target);

        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error has occurred: {ex.Message}", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        return;

        Rectangle GetMainMonitor()
        {
            if (Screen.AllScreens.Length == 0)
                return new Rectangle();

            foreach (var tmpScreen in Screen.AllScreens)
            {
                if (tmpScreen.Bounds.Left == 0)
                    return tmpScreen.Bounds;
            }

            return new Rectangle();
        }
    }

    /// <summary>
    /// Converts the image into a gray scale.
    /// </summary>
    /// <param name="bitmap">The bitmap with the screenshot.</param>
    /// <param name="target">The target.</param>
    private static void ToGrayscale(Bitmap bitmap, string target)
    {
        // Create a new blank image with the same dimensions as the "original".
        using var tmpBitmap = new Bitmap(bitmap.Width, bitmap.Height);

        // Get a graphics object
        using var graphics = Graphics.FromImage(tmpBitmap);

        // Create a grayscale color matrix
        var colorMatrix = new ColorMatrix(
        [
            [.3f, .3f, .3f, 0, 0],
            [.59f, .59f, .59f, 0, 0],
            [.11f, .11f, .11f, 0, 0],
            [0, 0, 0, 1, 0],
            [0, 0, 0, 0, 1]
        ]);

        // Create some attributes
        using var attributes = new ImageAttributes();
        attributes.SetColorMatrix(colorMatrix);

        // Draw the original image to the new using the grayscale color matrix
        graphics.DrawImage(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height),
            0, 0, bitmap.Width, bitmap.Height, GraphicsUnit.Pixel, attributes);

        // Save the image
        tmpBitmap.Save(target);
    }
}