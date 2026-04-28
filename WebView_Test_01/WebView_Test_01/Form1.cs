namespace WebView_Test_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeAsync();
            this.Resize += new System.EventHandler(this.Form_Resize);
        }

        async void InitializeAsync()
        {
            // Ensure the Chromium engine is ready
            await webView21.EnsureCoreWebView2Async(null);

            // Navigate to a URL
            webView21.CoreWebView2.Navigate("http://192.168.1.139/web_japanese/");

            // Disable the default context menu
            webView21.CoreWebView2.ContextMenuRequested += CoreWebView2_ContextMenuRequested;
        }

        private void CoreWebView2_ContextMenuRequested(object sender, Microsoft.Web.WebView2.Core.CoreWebView2ContextMenuRequestedEventArgs e)
        {
            // This line blocks the right-click menu from appearing
            e.Handled = true;
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            // Example: Make WebView2 fill the bottom 80% of the window
            webView21.Size = new System.Drawing.Size(this.ClientSize.Width, this.ClientSize.Height - 50);
            webView21.Location = new System.Drawing.Point(0, 0);
        }
    }
}
