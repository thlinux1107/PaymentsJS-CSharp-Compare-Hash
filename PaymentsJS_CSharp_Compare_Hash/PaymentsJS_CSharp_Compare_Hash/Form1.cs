using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.Security.Cryptography;

namespace PaymentsJS_CSharp_Compare_Hash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btDeserializeJSON_Click(object sender, EventArgs e)
        {
            //TH - Grab the JSON Response String
            var rawResponse = txtRawResponse.Text;

            //TH - Initialize JSON parser
            var jss = new JavaScriptSerializer();

            //TH - Deserialize JSON string to pull out the "Response" and "Hash"
            var dict = jss.Deserialize<Dictionary<string, dynamic>>(rawResponse);

            //TH - Identify the "Response" segment of the rawResponse string.
            var resp = dict["Response"];

            //TH - Serialize the "Response" segment.
            string json_resp = jss.Serialize(resp).ToString();

            //TH - Identify the "Hash" segment of the rawResponse string.
            var hash = dict["Hash"];


            //TH - Display the "Response" and "Hash" segments.
            txtParsedResponse.Text = json_resp.ToString();
            txtParsedHash.Text = hash.ToString();


        }

        private void btCalculateHash_Click(object sender, EventArgs e)
        {
            //TH - Grab the "Response" segment of the rawResponse string.
            var json_resp_string = txtParsedResponse.Text;

            //TH - You will need your Client Secret to hash the "Response".
            string clientSecret = "wtC5Ns0jbtiNA8sP";

            //TH - Set your variables
            Byte[] computedHash;
            string computedHashString = string.Empty;

            //TH - Build the hmac using the Client Secret.
            HMACSHA512 hmac = new HMACSHA512(Encoding.ASCII.GetBytes(clientSecret));

            //TH - Compute the hash of the "Response" segment.
            computedHash = hmac.ComputeHash(Encoding.ASCII.GetBytes(json_resp_string));

            //TH - Convert the hash to Base64.
            computedHashString = Convert.ToBase64String(computedHash);

            //TH - Display the hashed "Response" segment for comparison to original hash.
            txtCalculatedHash.Text = computedHashString;


        }
    }
}
