namespace Note.Maui
{    
    public partial class NuevaPage : ContentPage
    {
        string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
        public const double MyFontSize = 28;
        public NuevaPage()
        {
            InitializeComponent();

            if (File.Exists(_fileName))
            {
                editor.Text = File.ReadAllText(_fileName);
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }

    public class GlobalFontSizeExtension : IMarkupExtension
    {
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return NuevaPage.MyFontSize;
        }
    }
}