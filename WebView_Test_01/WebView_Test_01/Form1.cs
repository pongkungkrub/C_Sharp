namespace WebView_Test_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeAsync();
        }

        async void InitializeAsync()
        {
            // Ensure the Chromium engine is ready
            await webView21.EnsureCoreWebView2Async(null);

            // Navigate to a URL
            webView21.CoreWebView2.Navigate("http://192.168.1.139/web_japanese/");
        }
    }
}
