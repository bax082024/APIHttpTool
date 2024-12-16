using System;
using System.Drawing.Drawing2D;
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

        // GET Request
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
                    rtbResponse1.Text = $"Response:\n{responseBody}";
                }
            }
            catch (Exception ex)
            {
                rtbResponse1.Text = $"Error: {ex.Message}";
            }
        }

        // POST Request
        private async void btnSendPost_Click(object sender, EventArgs e)
        {
            string url = txtApiUrlPost.Text;
            string payload = rtbResponsePost.Text;

            if (string.IsNullOrWhiteSpace(url))
            {
                rtbResponsePost.Text = "Please enter a valid URL.";
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var data = new StringContent(payload, Encoding.UTF8, "application/json");
                    rtbResponsePost.Text = $"Sending POST request to {url}...\n";

                    HttpResponseMessage response = await client.PostAsync(url, data);
                    string responseBody = await response.Content.ReadAsStringAsync();

                    rtbResponsePost.Text = $"Response:\n{responseBody}";
                }
            }
            catch (Exception ex)
            {
                rtbResponsePost.Text = $"Error: {ex.Message}";
            }
        }

        // PUT Request
        private async void btnSendPut_Click(object sender, EventArgs e)
        {
            string url = txtApiUrlPut.Text;
            string payload = rtbResponsePut.Text;

            if (string.IsNullOrWhiteSpace(url))
            {
                rtbResponsePut.Text = "Please enter a valid URL.";
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var data = new StringContent(payload, Encoding.UTF8, "application/json");
                    rtbResponsePut.Text = $"Sending PUT request to {url}...\n";

                    HttpResponseMessage response = await client.PutAsync(url, data);
                    string responseBody = await response.Content.ReadAsStringAsync();

                    rtbResponsePut.Text = $"Response:\n{responseBody}";
                }
            }
            catch (Exception ex)
            {
                rtbResponsePut.Text = $"Error: {ex.Message}";
            }
        }


        // DELETE Request
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
                    rtbResponseDelete.Text = $"Response:\n{responseBody}";
                }
            }
            catch (Exception ex)
            {
                rtbResponseDelete.Text = $"Error: {ex.Message}";
            }
        }

        // Function to make the background change between two colors
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Rectangle gradientRectangle = new Rectangle(0, 0, this.Width, this.Height);

            // Create a LinearGradientBrush for the background
            using (LinearGradientBrush brush = new LinearGradientBrush(
                gradientRectangle,
                Color.DarkCyan, // Start color
                Color.LightBlue,  // End color                                 
                LinearGradientMode.Vertical)) // Gradient direction
            {
                // Fill the form's background with the gradient
                e.Graphics.FillRectangle(brush, gradientRectangle);
            }
        }
    }
}
