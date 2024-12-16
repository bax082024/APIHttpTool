using System.Net.Http;
using System.Text;
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

        private void btnSendGet2_Click(object sender, EventArgs e)
        {
            string url = txtApiUrlPost.Text;

            if (string.IsNullOrWhiteSpace(url))
            {
                rtbResponsePost.Text = "Please enter a valid URL.";
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Example payload
                    var data = new StringContent("{ \"key\": \"value\" }", Encoding.UTF8, "application/json");

                    rtbResponsePost.Text = $"Sending POST request to {url}...\n";
                    HttpResponseMessage response = await client.PostAsync(url, data);

                    string responseBody = await response.Content.ReadAsStringAsync();
                    rtbResponsePost.Text = responseBody;
                }
            }
            catch (Exception ex)
            {
                rtbResponsePost.Text = $"Error: {ex.Message}";
            }
        }

        private void btnSendGet3_Click(object sender, EventArgs e)
        {

        }

        private void btnSendGet4_Click(object sender, EventArgs e)
        {

        }
    }
}
