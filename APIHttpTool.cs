using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace APIHttpTool
{
    public partial class APIHttpTool : Form
    {
        public APIHttpTool()
        {
            InitializeComponent();
        }

        private async void btnSendPost_Click(object sender, EventArgs e)
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


        private async void btnSendPut_Click(object sender, EventArgs e)
        {
            string url = txtApiUrlPut.Text;

            if (string.IsNullOrWhiteSpace(url))
            {
                rtbResponsePut.Text = "Please enter a valid URL.";
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Example payload
                    var data = new StringContent("{ \"key\": \"updated value\" }", Encoding.UTF8, "application/json");

                    rtbResponsePut.Text = $"Sending PUT request to {url}...\n";
                    HttpResponseMessage response = await client.PutAsync(url, data);

                    string responseBody = await response.Content.ReadAsStringAsync();
                    rtbResponsePut.Text = responseBody;
                }
            }
            catch (Exception ex)
            {
                rtbResponsePut.Text = $"Error: {ex.Message}";
            }
        }


        private async void btnSendDelete_Click(object sender, EventArgs e)
        {
            string url = txtApiUrlDelete.Text;

            if (string.IsNullOrWhiteSpace(url))
            {
                rtbResponseDelete.Text = "Please enter a valid URL.";
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    rtbResponseDelete.Text = $"Sending DELETE request to {url}...\n";
                    HttpResponseMessage response = await client.DeleteAsync(url);

                    string responseBody = await response.Content.ReadAsStringAsync();
                    rtbResponseDelete.Text = responseBody;
                }
            }
            catch (Exception ex)
            {
                rtbResponseDelete.Text = $"Error: {ex.Message}";
            }
        }


        private async void btnSendGet_Click(object sender, EventArgs e)
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
