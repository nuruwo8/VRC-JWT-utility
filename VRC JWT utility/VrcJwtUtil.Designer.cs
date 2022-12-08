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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VrcJwtUtil));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonGenerateAdvancedKeys = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonclipboardAdvancedPublicKey = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxVrcName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonClipboadWithUrlAdvancedToken = new System.Windows.Forms.Button();
            this.buttonClipboadAdvancedToken = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonGenerateAdvancedToken = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxOneTokenResults.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(20, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(635, 751);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonFixedOneToken);
            this.tabPage1.Controls.Add(this.groupBoxOneTokenResults);
            this.tabPage1.Controls.Add(this.textBoxSpec);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(627, 712);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fixed one token Mode";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::VRC_JWT_utility.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(23, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 86);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(319, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Specs";
            // 
            // buttonFixedOneToken
            // 
            this.buttonFixedOneToken.Font = new System.Drawing.Font("メイリオ", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFixedOneToken.Location = new System.Drawing.Point(98, 48);
            this.buttonFixedOneToken.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFixedOneToken.Name = "buttonFixedOneToken";
            this.buttonFixedOneToken.Size = new System.Drawing.Size(196, 38);
            this.buttonFixedOneToken.TabIndex = 7;
            this.buttonFixedOneToken.Text = "Generate new token";
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
            this.groupBoxOneTokenResults.Location = new System.Drawing.Point(14, 117);
            this.groupBoxOneTokenResults.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxOneTokenResults.Name = "groupBoxOneTokenResults";
            this.groupBoxOneTokenResults.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxOneTokenResults.Size = new System.Drawing.Size(596, 586);
            this.groupBoxOneTokenResults.TabIndex = 9;
            this.groupBoxOneTokenResults.TabStop = false;
            this.groupBoxOneTokenResults.Text = "Results";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(14, 328);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jwt Token (Tell only your members)";
            // 
            // buttonClipboadTokenWithUrlForFixedToken_Click
            // 
            this.buttonClipboadTokenWithUrlForFixedToken_Click.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClipboadTokenWithUrlForFixedToken_Click.Location = new System.Drawing.Point(214, 540);
            this.buttonClipboadTokenWithUrlForFixedToken_Click.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClipboadTokenWithUrlForFixedToken_Click.Name = "buttonClipboadTokenWithUrlForFixedToken_Click";
            this.buttonClipboadTokenWithUrlForFixedToken_Click.Size = new System.Drawing.Size(182, 32);
            this.buttonClipboadTokenWithUrlForFixedToken_Click.TabIndex = 3;
            this.buttonClipboadTokenWithUrlForFixedToken_Click.Text = "clipboard with URL";
            this.buttonClipboadTokenWithUrlForFixedToken_Click.UseVisualStyleBackColor = true;
            this.buttonClipboadTokenWithUrlForFixedToken_Click.Click += new System.EventHandler(this.ButtonClipboadTokenWithUrlForFixedToken_Click_Click);
            // 
            // buttonClipboadTokenForFixedToken_Click
            // 
            this.buttonClipboadTokenForFixedToken_Click.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClipboadTokenForFixedToken_Click.Location = new System.Drawing.Point(26, 540);
            this.buttonClipboadTokenForFixedToken_Click.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClipboadTokenForFixedToken_Click.Name = "buttonClipboadTokenForFixedToken_Click";
            this.buttonClipboadTokenForFixedToken_Click.Size = new System.Drawing.Size(106, 32);
            this.buttonClipboadTokenForFixedToken_Click.TabIndex = 3;
            this.buttonClipboadTokenForFixedToken_Click.Text = "clipboard";
            this.buttonClipboadTokenForFixedToken_Click.UseVisualStyleBackColor = true;
            this.buttonClipboadTokenForFixedToken_Click.Click += new System.EventHandler(this.ButtonClipboadTokenForFixedToken_Click_Click);
            // 
            // buttonClipboadPublicKeyForFixedToken
            // 
            this.buttonClipboadPublicKeyForFixedToken.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClipboadPublicKeyForFixedToken.Location = new System.Drawing.Point(26, 270);
            this.buttonClipboadPublicKeyForFixedToken.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClipboadPublicKeyForFixedToken.Name = "buttonClipboadPublicKeyForFixedToken";
            this.buttonClipboadPublicKeyForFixedToken.Size = new System.Drawing.Size(106, 32);
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
            this.label2.Location = new System.Drawing.Point(14, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Public key (Set your world Gimic)";
            // 
            // textBoxTokenForFixedToken
            // 
            this.textBoxTokenForFixedToken.Font = new System.Drawing.Font("メイリオ", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTokenForFixedToken.Location = new System.Drawing.Point(26, 361);
            this.textBoxTokenForFixedToken.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTokenForFixedToken.Multiline = true;
            this.textBoxTokenForFixedToken.Name = "textBoxTokenForFixedToken";
            this.textBoxTokenForFixedToken.ReadOnly = true;
            this.textBoxTokenForFixedToken.Size = new System.Drawing.Size(557, 175);
            this.textBoxTokenForFixedToken.TabIndex = 2;
            // 
            // textBoxPublicKeyForFixedToken
            // 
            this.textBoxPublicKeyForFixedToken.Font = new System.Drawing.Font("メイリオ", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPublicKeyForFixedToken.Location = new System.Drawing.Point(26, 67);
            this.textBoxPublicKeyForFixedToken.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPublicKeyForFixedToken.Multiline = true;
            this.textBoxPublicKeyForFixedToken.Name = "textBoxPublicKeyForFixedToken";
            this.textBoxPublicKeyForFixedToken.ReadOnly = true;
            this.textBoxPublicKeyForFixedToken.Size = new System.Drawing.Size(557, 199);
            this.textBoxPublicKeyForFixedToken.TabIndex = 2;
            // 
            // textBoxSpec
            // 
            this.textBoxSpec.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSpec.Location = new System.Drawing.Point(316, 40);
            this.textBoxSpec.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSpec.Multiline = true;
            this.textBoxSpec.Name = "textBoxSpec";
            this.textBoxSpec.ReadOnly = true;
            this.textBoxSpec.Size = new System.Drawing.Size(295, 74);
            this.textBoxSpec.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(627, 712);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "VRC name token mode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(305, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Specs";
            // 
            // buttonGenerateAdvancedKeys
            // 
            this.buttonGenerateAdvancedKeys.Font = new System.Drawing.Font("メイリオ", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGenerateAdvancedKeys.Location = new System.Drawing.Point(87, 56);
            this.buttonGenerateAdvancedKeys.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerateAdvancedKeys.Name = "buttonGenerateAdvancedKeys";
            this.buttonGenerateAdvancedKeys.Size = new System.Drawing.Size(220, 38);
            this.buttonGenerateAdvancedKeys.TabIndex = 12;
            this.buttonGenerateAdvancedKeys.Text = "Generate new keys";
            this.buttonGenerateAdvancedKeys.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.buttonclipboardAdvancedPublicKey);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.buttonGenerateAdvancedKeys);
            this.groupBox1.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(596, 322);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genelate Keys";
            // 
            // buttonclipboardAdvancedPublicKey
            // 
            this.buttonclipboardAdvancedPublicKey.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonclipboardAdvancedPublicKey.Location = new System.Drawing.Point(26, 276);
            this.buttonclipboardAdvancedPublicKey.Margin = new System.Windows.Forms.Padding(2);
            this.buttonclipboardAdvancedPublicKey.Name = "buttonclipboardAdvancedPublicKey";
            this.buttonclipboardAdvancedPublicKey.Size = new System.Drawing.Size(106, 32);
            this.buttonclipboardAdvancedPublicKey.TabIndex = 3;
            this.buttonclipboardAdvancedPublicKey.Text = "clipboard";
            this.buttonclipboardAdvancedPublicKey.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.SeaGreen;
            this.label6.Location = new System.Drawing.Point(26, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(340, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "Public key (Set your world Gimic)";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("メイリオ", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(12, 168);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(571, 96);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(305, 71);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(285, 90);
            this.textBox3.TabIndex = 15;
            // 
            // textBoxVrcName
            // 
            this.textBoxVrcName.BackColor = System.Drawing.Color.White;
            this.textBoxVrcName.Location = new System.Drawing.Point(11, 72);
            this.textBoxVrcName.Name = "textBoxVrcName";
            this.textBoxVrcName.Size = new System.Drawing.Size(281, 37);
            this.textBoxVrcName.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonGenerateAdvancedToken);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxVrcName);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.buttonClipboadWithUrlAdvancedToken);
            this.groupBox2.Controls.Add(this.buttonClipboadAdvancedToken);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(17, 343);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 354);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generate Token";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(11, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Jwt Token (Tell your member)";
            // 
            // buttonClipboadWithUrlAdvancedToken
            // 
            this.buttonClipboadWithUrlAdvancedToken.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClipboadWithUrlAdvancedToken.Location = new System.Drawing.Point(203, 310);
            this.buttonClipboadWithUrlAdvancedToken.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClipboadWithUrlAdvancedToken.Name = "buttonClipboadWithUrlAdvancedToken";
            this.buttonClipboadWithUrlAdvancedToken.Size = new System.Drawing.Size(182, 32);
            this.buttonClipboadWithUrlAdvancedToken.TabIndex = 6;
            this.buttonClipboadWithUrlAdvancedToken.Text = "clipboard with URL";
            this.buttonClipboadWithUrlAdvancedToken.UseVisualStyleBackColor = true;
            // 
            // buttonClipboadAdvancedToken
            // 
            this.buttonClipboadAdvancedToken.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClipboadAdvancedToken.Location = new System.Drawing.Point(25, 310);
            this.buttonClipboadAdvancedToken.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClipboadAdvancedToken.Name = "buttonClipboadAdvancedToken";
            this.buttonClipboadAdvancedToken.Size = new System.Drawing.Size(106, 32);
            this.buttonClipboadAdvancedToken.TabIndex = 7;
            this.buttonClipboadAdvancedToken.Text = "clipboard";
            this.buttonClipboadAdvancedToken.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("メイリオ", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(11, 206);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(571, 91);
            this.textBox1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(11, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 30);
            this.label7.TabIndex = 8;
            this.label7.Text = "VRChat name";
            // 
            // buttonGenerateAdvancedToken
            // 
            this.buttonGenerateAdvancedToken.Font = new System.Drawing.Font("メイリオ", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGenerateAdvancedToken.Location = new System.Drawing.Point(11, 123);
            this.buttonGenerateAdvancedToken.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerateAdvancedToken.Name = "buttonGenerateAdvancedToken";
            this.buttonGenerateAdvancedToken.Size = new System.Drawing.Size(234, 38);
            this.buttonGenerateAdvancedToken.TabIndex = 13;
            this.buttonGenerateAdvancedToken.Text = "Generate new token";
            this.buttonGenerateAdvancedToken.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::VRC_JWT_utility.Properties.Resources.logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(12, 34);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 86);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // VrcJwtUtil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 772);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VrcJwtUtil";
            this.Text = "VRC JWT utility";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxOneTokenResults.ResumeLayout(false);
            this.groupBoxOneTokenResults.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button buttonFixedOneToken;
        private GroupBox groupBoxOneTokenResults;
        private Label label3;
        private Button buttonClipboadTokenWithUrlForFixedToken_Click;
        private Button buttonClipboadTokenForFixedToken_Click;
        private Button buttonClipboadPublicKeyForFixedToken;
        private Label label2;
        private TextBox textBoxTokenForFixedToken;
        private TextBox textBoxPublicKeyForFixedToken;
        private TextBox textBoxSpec;
        private TabPage tabPage2;
        private GroupBox groupBox2;
        private Button buttonGenerateAdvancedToken;
        private Label label7;
        private Label label5;
        private TextBox textBoxVrcName;
        private Button buttonClipboadWithUrlAdvancedToken;
        private Button buttonClipboadAdvancedToken;
        private TextBox textBox1;
        private Label label4;
        private GroupBox groupBox1;
        private Button buttonclipboardAdvancedPublicKey;
        private Label label6;
        private TextBox textBox2;
        private Button buttonGenerateAdvancedKeys;
        private TextBox textBox3;
        private PictureBox pictureBox2;
    }
}