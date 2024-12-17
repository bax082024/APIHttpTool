using System;
using System.Drawing.Drawing2D;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace APIHttpTool
{
    public partial class APIHttpTool : Form
    {
        

        public APIHttpTool()
        {
            InitializeComponent();



            // Create a new ToolTip instance
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();



            // Set tooltip text for GET button
            toolTip.SetToolTip(btnSendGet, "The GET method retrieves data from the server. Use this to fetch information.");

            // Set tooltip text for POST button
            toolTip.SetToolTip(btnSendPost, "The POST method sends data to the server to create new resources.");

            // Set tooltip text for PUT button
            toolTip.SetToolTip(btnSendPut, "The PUT method updates an existing resource on the server.");

            // Set tooltip text for DELETE button
            toolTip.SetToolTip(btnSendDelete, "The DELETE method removes a resource from the server.");



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
                    // Add headers if provided
                    if (!string.IsNullOrWhiteSpace(txtHeaderKeyGet.Text) && !string.IsNullOrWhiteSpace(txtHeaderValueGet.Text))
                    {
                        client.DefaultRequestHeaders.Add(txtHeaderKeyGet.Text, txtHeaderValueGet.Text);
                    }

                    rtbResponse1.Text = $"Sending GET request to {url}...\n";
                    HttpResponseMessage response = await client.GetAsync(url);

                    string responseBody = await response.Content.ReadAsStringAsync();
                    rtbResponse1.Text = $"Status: {response.StatusCode}\n{responseBody}";
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

            if (string.IsNullOrWhiteSpace(payload))
            {
                rtbResponsePost.Text = "Please enter a valid JSON payload.";
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Add headers if provided
                    if (!string.IsNullOrWhiteSpace(txtHeaderKeyPost.Text) && !string.IsNullOrWhiteSpace(txtHeaderValuePost.Text))
                    {
                        client.DefaultRequestHeaders.Add(txtHeaderKeyPost.Text, txtHeaderValuePost.Text);
                    }

                    var data = new StringContent(payload, Encoding.UTF8, "application/json");

                    rtbResponsePost.Text = $"Sending POST request to {url}...\n";
                    HttpResponseMessage response = await client.PostAsync(url, data);

                    string responseBody = await response.Content.ReadAsStringAsync();
                    rtbResponsePost.Text = $"Status: {response.StatusCode}\n{responseBody}";
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

            if (string.IsNullOrWhiteSpace(payload))
            {
                rtbResponsePut.Text = "Please enter a valid JSON payload.";
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Add headers if provided
                    if (!string.IsNullOrWhiteSpace(txtHeaderKeyPut.Text) && !string.IsNullOrWhiteSpace(txtHeaderValuePut.Text))
                    {
                        client.DefaultRequestHeaders.Add(txtHeaderKeyPut.Text, txtHeaderValuePut.Text);
                    }

                    var data = new StringContent(payload, Encoding.UTF8, "application/json");

                    rtbResponsePut.Text = $"Sending PUT request to {url}...\n";
                    HttpResponseMessage response = await client.PutAsync(url, data);

                    string responseBody = await response.Content.ReadAsStringAsync();
                    rtbResponsePut.Text = $"Status: {response.StatusCode}\n{responseBody}";
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
                    // Add headers if provided
                    if (!string.IsNullOrWhiteSpace(txtHeaderKeyDelete.Text) && !string.IsNullOrWhiteSpace(txtHeaderValueDelete.Text))
                    {
                        client.DefaultRequestHeaders.Add(txtHeaderKeyDelete.Text, txtHeaderValueDelete.Text);
                    }

                    rtbResponseDelete.Text = $"Sending DELETE request to {url}...\n";
                    HttpResponseMessage response = await client.DeleteAsync(url);

                    string responseBody = await response.Content.ReadAsStringAsync();
                    rtbResponseDelete.Text = $"Status: {response.StatusCode}\n{responseBody}";
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



        private void APIHttpTool_Load_1(object sender, EventArgs e)
        {
            // GET Example URL
            txtApiUrl1.Text = "https://jsonplaceholder.typicode.com/posts/1";
            rtbResponse1.Text = "Click 'Send GET Request' to fetch data.";

            // POST Example URL and Payload
            txtApiUrlPost.Text = "https://jsonplaceholder.typicode.com/posts";
            rtbResponsePost.Text = "{\n  \"title\": \"foo\",\n  \"body\": \"bar\",\n  \"userId\": 1\n}";

            // PUT Example URL and Payload
            txtApiUrlPut.Text = "https://jsonplaceholder.typicode.com/posts/1";
            rtbResponsePut.Text = "{\n  \"id\": 1,\n  \"title\": \"updated title\",\n  \"body\": \"updated body\",\n  \"userId\": 1\n}";

            // DELETE Example URL
            txtApiUrlDelete.Text = "https://jsonplaceholder.typicode.com/posts/1";
            rtbResponseDelete.Text = "Click 'Send DELETE Request' to delete data.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Reset GET URL
            txtApiUrl1.Text = "https://jsonplaceholder.typicode.com/posts/1";

            // Reset Response
            rtbResponse1.Text = "Click 'Send GET Request' to fetch data.";

            // Reset Status Label
            lblStatusCodeGet.Text = "Status: Not Sent";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Reset POST URL
            txtApiUrlPost.Text = "https://jsonplaceholder.typicode.com/posts";

            // Reset POST Body (Payload)
            rtbResponsePost.Text = "{\n  \"title\": \"foo\",\n  \"body\": \"bar\",\n  \"userId\": 1\n}";

            // Reset Status Label
            lblStatusCodePost.Text = "Status: Not Sent";
        }


        private void button3_Click(object sender, EventArgs e)
        {
            // Reset PUT URL
            txtApiUrlPut.Text = "https://jsonplaceholder.typicode.com/posts/1";

            // Reset PUT Body (Payload)
            rtbResponsePut.Text = "{\n  \"id\": 1,\n  \"title\": \"updated title\",\n  \"body\": \"updated body\",\n  \"userId\": 1\n}";

            // Reset Status Label
            lblStatusCodePut.Text = "Status: Not Sent";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            // Reset DELETE URL
            txtApiUrlDelete.Text = "https://jsonplaceholder.typicode.com/posts/1";

            // Reset Response
            rtbResponseDelete.Text = "Click 'Send DELETE Request' to delete data.";

            // Reset Status Label
            lblStatusCodeDelete.Text = "Status: Not Sent";
        }

        private void btnResetHeadersGet_Click(object sender, EventArgs e)
        {
            txtHeaderKeyGet.Text = "";
            txtHeaderValueGet.Text = "";
        }

        private void btnResetHeadersPost_Click(object sender, EventArgs e)
        {
            txtHeaderKeyPost.Text = "";
            txtHeaderValuePost.Text = "";
        }

        private void btnResetHeadersPut_Click(object sender, EventArgs e)
        {
            txtHeaderKeyPut.Text = "";
            txtHeaderValuePut.Text = "";
        }

        private void btnResetHeadersDelete_Click(object sender, EventArgs e)
        {
            txtHeaderKeyDelete.Text = "";
            txtHeaderValueDelete.Text = "";
        }
    }
}
