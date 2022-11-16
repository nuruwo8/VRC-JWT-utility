namespace VRC_JWT_utility
{
    partial class VrcJwtUtil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonFixedOneToken = new System.Windows.Forms.Button();
            this.groupBoxOneTokenResults = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClipboadTokenWithUrlForFixedToken_Click = new System.Windows.Forms.Button();
            this.buttonClipboadTokenForFixedToken_Click = new System.Windows.Forms.Button();
            this.buttonClipboadPublicKeyForFixedToken = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTokenForFixedToken = new System.Windows.Forms.TextBox();
            this.textBoxPublicKeyForFixedToken = new System.Windows.Forms.TextBox();
            this.textBoxSpec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxOneTokenResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFixedOneToken
            // 
            this.buttonFixedOneToken.Font = new System.Drawing.Font("メイリオ", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFixedOneToken.Location = new System.Drawing.Point(24, 54);
            this.buttonFixedOneToken.Name = "buttonFixedOneToken";
            this.buttonFixedOneToken.Size = new System.Drawing.Size(314, 48);
            this.buttonFixedOneToken.TabIndex = 0;
            this.buttonFixedOneToken.Text = "Generate new JWT token";
            this.buttonFixedOneToken.UseVisualStyleBackColor = true;
            this.buttonFixedOneToken.Click += new System.EventHandler(this.ButtonFixedOneToken_Click);
            // 
            // groupBoxOneTokenResults
            // 
            this.groupBoxOneTokenResults.Controls.Add(this.label3);
            this.groupBoxOneTokenResults.Controls.Add(this.buttonClipboadTokenWithUrlForFixedToken_Click);
            this.groupBoxOneTokenResults.Controls.Add(this.buttonClipboadTokenForFixedToken_Click);
            this.groupBoxOneTokenResults.Controls.Add(this.buttonClipboadPublicKeyForFixedToken);
            this.groupBoxOneTokenResults.Controls.Add(this.label2);
            this.groupBoxOneTokenResults.Controls.Add(this.textBoxTokenForFixedToken);
            this.groupBoxOneTokenResults.Controls.Add(this.textBoxPublicKeyForFixedToken);
            this.groupBoxOneTokenResults.Enabled = false;
            this.groupBoxOneTokenResults.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxOneTokenResults.Location = new System.Drawing.Point(24, 135);
            this.groupBoxOneTokenResults.Name = "groupBoxOneTokenResults";
            this.groupBoxOneTokenResults.Size = new System.Drawing.Size(745, 733);
            this.groupBoxOneTokenResults.TabIndex = 5;
            this.groupBoxOneTokenResults.TabStop = false;
            this.groupBoxOneTokenResults.Text = "Results";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(20, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(436, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jwt Token (Tell only your members)";
            // 
            // buttonClipboadTokenWithUrlForFixedToken_Click
            // 
            this.buttonClipboadTokenWithUrlForFixedToken_Click.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClipboadTokenWithUrlForFixedToken_Click.Location = new System.Drawing.Point(267, 675);
            this.buttonClipboadTokenWithUrlForFixedToken_Click.Name = "buttonClipboadTokenWithUrlForFixedToken_Click";
            this.buttonClipboadTokenWithUrlForFixedToken_Click.Size = new System.Drawing.Size(228, 40);
            this.buttonClipboadTokenWithUrlForFixedToken_Click.TabIndex = 3;
            this.buttonClipboadTokenWithUrlForFixedToken_Click.Text = "clipboard with URL";
            this.buttonClipboadTokenWithUrlForFixedToken_Click.UseVisualStyleBackColor = true;
            this.buttonClipboadTokenWithUrlForFixedToken_Click.Click += new System.EventHandler(this.ButtonClipboadTokenWithUrlForFixedToken_Click_Click);
            // 
            // buttonClipboadTokenForFixedToken_Click
            // 
            this.buttonClipboadTokenForFixedToken_Click.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClipboadTokenForFixedToken_Click.Location = new System.Drawing.Point(33, 675);
            this.buttonClipboadTokenForFixedToken_Click.Name = "buttonClipboadTokenForFixedToken_Click";
            this.buttonClipboadTokenForFixedToken_Click.Size = new System.Drawing.Size(132, 40);
            this.buttonClipboadTokenForFixedToken_Click.TabIndex = 3;
            this.buttonClipboadTokenForFixedToken_Click.Text = "clipboard";
            this.buttonClipboadTokenForFixedToken_Click.UseVisualStyleBackColor = true;
            this.buttonClipboadTokenForFixedToken_Click.Click += new System.EventHandler(this.ButtonClipboadTokenForFixedToken_Click_Click);
            // 
            // buttonClipboadPublicKeyForFixedToken
            // 
            this.buttonClipboadPublicKeyForFixedToken.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClipboadPublicKeyForFixedToken.Location = new System.Drawing.Point(33, 338);
            this.buttonClipboadPublicKeyForFixedToken.Name = "buttonClipboadPublicKeyForFixedToken";
            this.buttonClipboadPublicKeyForFixedToken.Size = new System.Drawing.Size(132, 40);
            this.buttonClipboadPublicKeyForFixedToken.TabIndex = 3;
            this.buttonClipboadPublicKeyForFixedToken.Text = "clipboard";
            this.buttonClipboadPublicKeyForFixedToken.UseVisualStyleBackColor = true;
            this.buttonClipboadPublicKeyForFixedToken.Click += new System.EventHandler(this.ButtonClipboadPublicKeyForFixedToken_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(20, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(406, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Public key (Set your world Gimic)";
            // 
            // textBoxTokenForFixedToken
            // 
            this.textBoxTokenForFixedToken.Font = new System.Drawing.Font("メイリオ", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTokenForFixedToken.Location = new System.Drawing.Point(33, 451);
            this.textBoxTokenForFixedToken.Multiline = true;
            this.textBoxTokenForFixedToken.Name = "textBoxTokenForFixedToken";
            this.textBoxTokenForFixedToken.ReadOnly = true;
            this.textBoxTokenForFixedToken.Size = new System.Drawing.Size(695, 218);
            this.textBoxTokenForFixedToken.TabIndex = 2;
            // 
            // textBoxPublicKeyForFixedToken
            // 
            this.textBoxPublicKeyForFixedToken.Font = new System.Drawing.Font("メイリオ", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPublicKeyForFixedToken.Location = new System.Drawing.Point(33, 84);
            this.textBoxPublicKeyForFixedToken.Multiline = true;
            this.textBoxPublicKeyForFixedToken.Name = "textBoxPublicKeyForFixedToken";
            this.textBoxPublicKeyForFixedToken.ReadOnly = true;
            this.textBoxPublicKeyForFixedToken.Size = new System.Drawing.Size(695, 248);
            this.textBoxPublicKeyForFixedToken.TabIndex = 2;
            // 
            // textBoxSpec
            // 
            this.textBoxSpec.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSpec.Location = new System.Drawing.Point(401, 44);
            this.textBoxSpec.Multiline = true;
            this.textBoxSpec.Name = "textBoxSpec";
            this.textBoxSpec.ReadOnly = true;
            this.textBoxSpec.Size = new System.Drawing.Size(368, 91);
            this.textBoxSpec.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(401, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Specs";
            // 
            // VrcJwtUtil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 880);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSpec);
            this.Controls.Add(this.groupBoxOneTokenResults);
            this.Controls.Add(this.buttonFixedOneToken);
            this.Name = "VrcJwtUtil";
            this.Text = "VRC JWT utility";
            this.groupBoxOneTokenResults.ResumeLayout(false);
            this.groupBoxOneTokenResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonFixedOneToken;
        private GroupBox groupBoxOneTokenResults;
        private Label label3;
        private Button buttonClipboadPublicKeyForFixedToken;
        private Label label2;
        private TextBox textBoxPublicKeyForFixedToken;
        private Button buttonClipboadTokenForFixedToken_Click;
        private TextBox textBoxTokenForFixedToken;
        private Button buttonClipboadTokenWithUrlForFixedToken_Click;
        private TextBox textBoxSpec;
        private Label label1;
    }
}