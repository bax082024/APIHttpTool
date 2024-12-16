using System.Net.Http;
using System.Threading.Tasks;



namespace APIHttpTool
{
    public partial class APIHttpTool : Form
    {
        public APIHttpTool()
        {
            InitializeComponent();
        }

        private void btnSendGet1_Click(object sender, EventArgs e)
        {
            string url = txtApiUrl1.Text;

            if (string.IsNullOrWhiteSpace(url))
            {
                rtbResponse1.Text = "Please enter a valid URL.";
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    rtbResponse1.Text = $"Sending GET request to {url}...\n";
                    HttpResponseMessage response = await client.GetAsync(url);

                    string responseBody = await response.Content.ReadAsStringAsync();
                    rtbResponse1.Text = responseBody;
                }
            }
            catch (Exception ex)
            {
                rtbResponse1.Text = $"Error: {ex.Message}";
            }
        }
    }
}
