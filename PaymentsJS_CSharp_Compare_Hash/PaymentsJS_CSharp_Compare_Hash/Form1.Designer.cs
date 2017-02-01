namespace PaymentsJS_CSharp_Compare_Hash
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtRawResponse = new System.Windows.Forms.TextBox();
            this.txtParsedResponse = new System.Windows.Forms.TextBox();
            this.txtParsedHash = new System.Windows.Forms.TextBox();
            this.txtCalculatedHash = new System.Windows.Forms.TextBox();
            this.btDeserializeJSON = new System.Windows.Forms.Button();
            this.btCalculateHash = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRawResponse
            // 
            this.txtRawResponse.Location = new System.Drawing.Point(12, 48);
            this.txtRawResponse.Multiline = true;
            this.txtRawResponse.Name = "txtRawResponse";
            this.txtRawResponse.Size = new System.Drawing.Size(216, 247);
            this.txtRawResponse.TabIndex = 0;
            this.txtRawResponse.Text = resources.GetString("txtRawResponse.Text");
            // 
            // txtParsedResponse
            // 
            this.txtParsedResponse.Location = new System.Drawing.Point(310, 48);
            this.txtParsedResponse.Multiline = true;
            this.txtParsedResponse.Name = "txtParsedResponse";
            this.txtParsedResponse.Size = new System.Drawing.Size(216, 247);
            this.txtParsedResponse.TabIndex = 1;
            // 
            // txtParsedHash
            // 
            this.txtParsedHash.Location = new System.Drawing.Point(532, 102);
            this.txtParsedHash.Name = "txtParsedHash";
            this.txtParsedHash.Size = new System.Drawing.Size(393, 20);
            this.txtParsedHash.TabIndex = 2;
            // 
            // txtCalculatedHash
            // 
            this.txtCalculatedHash.Location = new System.Drawing.Point(533, 275);
            this.txtCalculatedHash.Name = "txtCalculatedHash";
            this.txtCalculatedHash.Size = new System.Drawing.Size(393, 20);
            this.txtCalculatedHash.TabIndex = 3;
            // 
            // btDeserializeJSON
            // 
            this.btDeserializeJSON.Location = new System.Drawing.Point(234, 49);
            this.btDeserializeJSON.Name = "btDeserializeJSON";
            this.btDeserializeJSON.Size = new System.Drawing.Size(70, 74);
            this.btDeserializeJSON.TabIndex = 4;
            this.btDeserializeJSON.Text = "Deserialize";
            this.btDeserializeJSON.UseVisualStyleBackColor = true;
            this.btDeserializeJSON.Click += new System.EventHandler(this.btDeserializeJSON_Click);
            // 
            // btCalculateHash
            // 
            this.btCalculateHash.Location = new System.Drawing.Point(533, 221);
            this.btCalculateHash.Name = "btCalculateHash";
            this.btCalculateHash.Size = new System.Drawing.Size(108, 23);
            this.btCalculateHash.TabIndex = 5;
            this.btCalculateHash.Text = "Calculate Hash";
            this.btCalculateHash.UseVisualStyleBackColor = true;
            this.btCalculateHash.Click += new System.EventHandler(this.btCalculateHash_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Raw JSON Response";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Deserialized JSON Response";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Deserialized Response Hash";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Calculated Response Hash";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 307);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCalculateHash);
            this.Controls.Add(this.btDeserializeJSON);
            this.Controls.Add(this.txtCalculatedHash);
            this.Controls.Add(this.txtParsedHash);
            this.Controls.Add(this.txtParsedResponse);
            this.Controls.Add(this.txtRawResponse);
            this.Name = "Form1";
            this.Text = "Response: Compare Hash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRawResponse;
        private System.Windows.Forms.TextBox txtParsedResponse;
        private System.Windows.Forms.TextBox txtParsedHash;
        private System.Windows.Forms.TextBox txtCalculatedHash;
        private System.Windows.Forms.Button btDeserializeJSON;
        private System.Windows.Forms.Button btCalculateHash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

