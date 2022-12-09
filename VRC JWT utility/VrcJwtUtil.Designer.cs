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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxVrcNameToken = new System.Windows.Forms.GroupBox();
            this.buttonGenerateVrcNameToken = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxVrcName = new System.Windows.Forms.TextBox();
            this.buttonClipboadWithUrlAdvancedToken = new System.Windows.Forms.Button();
            this.buttonClipboadAdvancedToken = new System.Windows.Forms.Button();
            this.textBoxVrcNameModeToken = new System.Windows.Forms.TextBox();
            this.groupBoxVrcNameKeys = new System.Windows.Forms.GroupBox();
            this.buttonclipboardAdvancedPublicKey = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxVrcNameModePublicKey = new System.Windows.Forms.TextBox();
            this.buttonGenerateAdvancedKeys = new System.Windows.Forms.Button();
            this.textBoxVrcNameModeSpec = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxOneTokenResults.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBoxVrcNameToken.SuspendLayout();
            this.groupBoxVrcNameKeys.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(635, 816);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.buttonFixedOneToken);
            this.tabPage1.Controls.Add(this.groupBoxOneTokenResults);
            this.tabPage1.Controls.Add(this.textBoxSpec);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(627, 777);
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
            // buttonFixedOneToken
            // 
            this.buttonFixedOneToken.Font = new System.Drawing.Font("メイリオ", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFixedOneToken.Location = new System.Drawing.Point(98, 43);
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
            this.groupBoxOneTokenResults.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxOneTokenResults.Location = new System.Drawing.Point(14, 119);
            this.groupBoxOneTokenResults.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxOneTokenResults.Name = "groupBoxOneTokenResults";
            this.groupBoxOneTokenResults.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxOneTokenResults.Size = new System.Drawing.Size(596, 644);
            this.groupBoxOneTokenResults.TabIndex = 9;
            this.groupBoxOneTokenResults.TabStop = false;
            this.groupBoxOneTokenResults.Text = "Results";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(14, 363);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jwt Token (Tell only your members)";
            // 
            // buttonClipboadTokenWithUrlForFixedToken_Click
            // 
            this.buttonClipboadTokenWithUrlForFixedToken_Click.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClipboadTokenWithUrlForFixedToken_Click.Location = new System.Drawing.Point(215, 587);
            this.buttonClipboadTokenWithUrlForFixedToken_Click.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClipboadTokenWithUrlForFixedToken_Click.Name = "buttonClipboadTokenWithUrlForFixedToken_Click";
            this.buttonClipboadTokenWithUrlForFixedToken_Click.Size = new System.Drawing.Size(182, 32);
            this.buttonClipboadTokenWithUrlForFixedToken_Click.TabIndex = 3;
            this.buttonClipboadTokenWithUrlForFixedToken_Click.Text = "Clipboard with URL";
            this.buttonClipboadTokenWithUrlForFixedToken_Click.UseVisualStyleBackColor = true;
            this.buttonClipboadTokenWithUrlForFixedToken_Click.Click += new System.EventHandler(this.ButtonClipboadTokenWithUrlForFixedToken_Click);
            // 
            // buttonClipboadTokenForFixedToken_Click
            // 
            this.buttonClipboadTokenForFixedToken_Click.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClipboadTokenForFixedToken_Click.Location = new System.Drawing.Point(26, 587);
            this.buttonClipboadTokenForFixedToken_Click.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClipboadTokenForFixedToken_Click.Name = "buttonClipboadTokenForFixedToken_Click";
            this.buttonClipboadTokenForFixedToken_Click.Size = new System.Drawing.Size(106, 32);
            this.buttonClipboadTokenForFixedToken_Click.TabIndex = 3;
            this.buttonClipboadTokenForFixedToken_Click.Text = "Clipboard";
            this.buttonClipboadTokenForFixedToken_Click.UseVisualStyleBackColor = true;
            this.buttonClipboadTokenForFixedToken_Click.Click += new System.EventHandler(this.ButtonClipboadTokenForFixedToken_Click);
            // 
            // buttonClipboadPublicKeyForFixedToken
            // 
            this.buttonClipboadPublicKeyForFixedToken.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClipboadPublicKeyForFixedToken.Location = new System.Drawing.Point(26, 294);
            this.buttonClipboadPublicKeyForFixedToken.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClipboadPublicKeyForFixedToken.Name = "buttonClipboadPublicKeyForFixedToken";
            this.buttonClipboadPublicKeyForFixedToken.Size = new System.Drawing.Size(106, 32);
            this.buttonClipboadPublicKeyForFixedToken.TabIndex = 3;
            this.buttonClipboadPublicKeyForFixedToken.Text = "Clipboard";
            this.buttonClipboadPublicKeyForFixedToken.UseVisualStyleBackColor = true;
            this.buttonClipboadPublicKeyForFixedToken.Click += new System.EventHandler(this.ButtonClipboadPublicKeyForFixedToken_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(14, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Public key (Set your world Gimic)";
            // 
            // textBoxTokenForFixedToken
            // 
            this.textBoxTokenForFixedToken.Font = new System.Drawing.Font("メイリオ", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTokenForFixedToken.Location = new System.Drawing.Point(26, 396);
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
            this.textBoxPublicKeyForFixedToken.Location = new System.Drawing.Point(26, 80);
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
            this.textBoxSpec.Location = new System.Drawing.Point(315, 25);
            this.textBoxSpec.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSpec.Multiline = true;
            this.textBoxSpec.Name = "textBoxSpec";
            this.textBoxSpec.ReadOnly = true;
            this.textBoxSpec.Size = new System.Drawing.Size(295, 76);
            this.textBoxSpec.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.groupBoxVrcNameToken);
            this.tabPage2.Controls.Add(this.groupBoxVrcNameKeys);
            this.tabPage2.Controls.Add(this.textBoxVrcNameModeSpec);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(627, 777);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "VRC name token mode";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::VRC_JWT_utility.Properties.Resources.logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(23, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 86);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(90, 62);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 30);
            this.label9.TabIndex = 20;
            this.label9.Text = "VRChat Name.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(85, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(222, 30);
            this.label8.TabIndex = 19;
            this.label8.Text = "Generate token with ";
            // 
            // groupBoxVrcNameToken
            // 
            this.groupBoxVrcNameToken.Controls.Add(this.buttonGenerateVrcNameToken);
            this.groupBoxVrcNameToken.Controls.Add(this.label7);
            this.groupBoxVrcNameToken.Controls.Add(this.label5);
            this.groupBoxVrcNameToken.Controls.Add(this.textBoxVrcName);
            this.groupBoxVrcNameToken.Controls.Add(this.buttonClipboadWithUrlAdvancedToken);
            this.groupBoxVrcNameToken.Controls.Add(this.buttonClipboadAdvancedToken);
            this.groupBoxVrcNameToken.Controls.Add(this.textBoxVrcNameModeToken);
            this.groupBoxVrcNameToken.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxVrcNameToken.Location = new System.Drawing.Point(17, 419);
            this.groupBoxVrcNameToken.Name = "groupBoxVrcNameToken";
            this.groupBoxVrcNameToken.Size = new System.Drawing.Size(595, 349);
            this.groupBoxVrcNameToken.TabIndex = 18;
            this.groupBoxVrcNameToken.TabStop = false;
            this.groupBoxVrcNameToken.Text = "Generate Token";
            // 
            // buttonGenerateVrcNameToken
            // 
            this.buttonGenerateVrcNameToken.Font = new System.Drawing.Font("メイリオ", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGenerateVrcNameToken.Location = new System.Drawing.Point(11, 122);
            this.buttonGenerateVrcNameToken.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerateVrcNameToken.Name = "buttonGenerateVrcNameToken";
            this.buttonGenerateVrcNameToken.Size = new System.Drawing.Size(234, 38);
            this.buttonGenerateVrcNameToken.TabIndex = 13;
            this.buttonGenerateVrcNameToken.Text = "Generate new token";
            this.buttonGenerateVrcNameToken.UseVisualStyleBackColor = true;
            this.buttonGenerateVrcNameToken.Click += new System.EventHandler(this.ButtonGenerateVrcNameToken_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(11, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 30);
            this.label7.TabIndex = 8;
            this.label7.Text = "VRChat name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(11, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Jwt Token (Tell your member)";
            // 
            // textBoxVrcName
            // 
            this.textBoxVrcName.BackColor = System.Drawing.Color.LightCyan;
            this.textBoxVrcName.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxVrcName.Location = new System.Drawing.Point(11, 65);
            this.textBoxVrcName.Name = "textBoxVrcName";
            this.textBoxVrcName.Size = new System.Drawing.Size(416, 37);
            this.textBoxVrcName.TabIndex = 17;
            // 
            // buttonClipboadWithUrlAdvancedToken
            // 
            this.buttonClipboadWithUrlAdvancedToken.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClipboadWithUrlAdvancedToken.Location = new System.Drawing.Point(203, 309);
            this.buttonClipboadWithUrlAdvancedToken.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClipboadWithUrlAdvancedToken.Name = "buttonClipboadWithUrlAdvancedToken";
            this.buttonClipboadWithUrlAdvancedToken.Size = new System.Drawing.Size(182, 32);
            this.buttonClipboadWithUrlAdvancedToken.TabIndex = 6;
            this.buttonClipboadWithUrlAdvancedToken.Text = "Clipboard with URL";
            this.buttonClipboadWithUrlAdvancedToken.UseVisualStyleBackColor = true;
            this.buttonClipboadWithUrlAdvancedToken.Click += new System.EventHandler(this.ButtonClipboadWithUrlAdvancedToken_Click);
            // 
            // buttonClipboadAdvancedToken
            // 
            this.buttonClipboadAdvancedToken.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClipboadAdvancedToken.Location = new System.Drawing.Point(25, 309);
            this.buttonClipboadAdvancedToken.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClipboadAdvancedToken.Name = "buttonClipboadAdvancedToken";
            this.buttonClipboadAdvancedToken.Size = new System.Drawing.Size(106, 32);
            this.buttonClipboadAdvancedToken.TabIndex = 7;
            this.buttonClipboadAdvancedToken.Text = "Clipboard";
            this.buttonClipboadAdvancedToken.UseVisualStyleBackColor = true;
            this.buttonClipboadAdvancedToken.Click += new System.EventHandler(this.ButtonClipboadAdvancedToken_Click);
            // 
            // textBoxVrcNameModeToken
            // 
            this.textBoxVrcNameModeToken.Font = new System.Drawing.Font("メイリオ", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxVrcNameModeToken.Location = new System.Drawing.Point(11, 209);
            this.textBoxVrcNameModeToken.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxVrcNameModeToken.Multiline = true;
            this.textBoxVrcNameModeToken.Name = "textBoxVrcNameModeToken";
            this.textBoxVrcNameModeToken.ReadOnly = true;
            this.textBoxVrcNameModeToken.Size = new System.Drawing.Size(571, 91);
            this.textBoxVrcNameModeToken.TabIndex = 5;
            // 
            // groupBoxVrcNameKeys
            // 
            this.groupBoxVrcNameKeys.Controls.Add(this.buttonclipboardAdvancedPublicKey);
            this.groupBoxVrcNameKeys.Controls.Add(this.label6);
            this.groupBoxVrcNameKeys.Controls.Add(this.textBoxVrcNameModePublicKey);
            this.groupBoxVrcNameKeys.Controls.Add(this.buttonGenerateAdvancedKeys);
            this.groupBoxVrcNameKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxVrcNameKeys.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxVrcNameKeys.Location = new System.Drawing.Point(16, 109);
            this.groupBoxVrcNameKeys.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxVrcNameKeys.Name = "groupBoxVrcNameKeys";
            this.groupBoxVrcNameKeys.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxVrcNameKeys.Size = new System.Drawing.Size(596, 302);
            this.groupBoxVrcNameKeys.TabIndex = 14;
            this.groupBoxVrcNameKeys.TabStop = false;
            this.groupBoxVrcNameKeys.Text = "Genelate Keys";
            // 
            // buttonclipboardAdvancedPublicKey
            // 
            this.buttonclipboardAdvancedPublicKey.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonclipboardAdvancedPublicKey.Location = new System.Drawing.Point(26, 258);
            this.buttonclipboardAdvancedPublicKey.Margin = new System.Windows.Forms.Padding(2);
            this.buttonclipboardAdvancedPublicKey.Name = "buttonclipboardAdvancedPublicKey";
            this.buttonclipboardAdvancedPublicKey.Size = new System.Drawing.Size(106, 32);
            this.buttonclipboardAdvancedPublicKey.TabIndex = 3;
            this.buttonclipboardAdvancedPublicKey.Text = "Clipboard";
            this.buttonclipboardAdvancedPublicKey.UseVisualStyleBackColor = true;
            this.buttonclipboardAdvancedPublicKey.Click += new System.EventHandler(this.ButtonClipboardAdvancedPublicKey_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.SeaGreen;
            this.label6.Location = new System.Drawing.Point(12, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(340, 30);
            this.label6.TabIndex = 1;
            this.label6.Text = "Public key (Set your world Gimic)";
            // 
            // textBoxVrcNameModePublicKey
            // 
            this.textBoxVrcNameModePublicKey.Font = new System.Drawing.Font("メイリオ", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxVrcNameModePublicKey.Location = new System.Drawing.Point(12, 120);
            this.textBoxVrcNameModePublicKey.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxVrcNameModePublicKey.Multiline = true;
            this.textBoxVrcNameModePublicKey.Name = "textBoxVrcNameModePublicKey";
            this.textBoxVrcNameModePublicKey.ReadOnly = true;
            this.textBoxVrcNameModePublicKey.Size = new System.Drawing.Size(571, 126);
            this.textBoxVrcNameModePublicKey.TabIndex = 2;
            // 
            // buttonGenerateAdvancedKeys
            // 
            this.buttonGenerateAdvancedKeys.Font = new System.Drawing.Font("メイリオ", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGenerateAdvancedKeys.Location = new System.Drawing.Point(12, 36);
            this.buttonGenerateAdvancedKeys.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerateAdvancedKeys.Name = "buttonGenerateAdvancedKeys";
            this.buttonGenerateAdvancedKeys.Size = new System.Drawing.Size(220, 38);
            this.buttonGenerateAdvancedKeys.TabIndex = 12;
            this.buttonGenerateAdvancedKeys.Text = "Generate new keys";
            this.buttonGenerateAdvancedKeys.UseVisualStyleBackColor = true;
            this.buttonGenerateAdvancedKeys.Click += new System.EventHandler(this.ButtonGenerateAdvancedKeys_Click);
            // 
            // textBoxVrcNameModeSpec
            // 
            this.textBoxVrcNameModeSpec.Font = new System.Drawing.Font("メイリオ", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxVrcNameModeSpec.Location = new System.Drawing.Point(311, 18);
            this.textBoxVrcNameModeSpec.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxVrcNameModeSpec.Multiline = true;
            this.textBoxVrcNameModeSpec.Name = "textBoxVrcNameModeSpec";
            this.textBoxVrcNameModeSpec.ReadOnly = true;
            this.textBoxVrcNameModeSpec.Size = new System.Drawing.Size(297, 87);
            this.textBoxVrcNameModeSpec.TabIndex = 15;
            // 
            // VrcJwtUtil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 840);
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
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBoxVrcNameToken.ResumeLayout(false);
            this.groupBoxVrcNameToken.PerformLayout();
            this.groupBoxVrcNameKeys.ResumeLayout(false);
            this.groupBoxVrcNameKeys.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private PictureBox pictureBox1;
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
        private GroupBox groupBoxVrcNameToken;
        private Button buttonGenerateVrcNameToken;
        private Label label7;
        private Label label5;
        private TextBox textBoxVrcName;
        private Button buttonClipboadWithUrlAdvancedToken;
        private Button buttonClipboadAdvancedToken;
        private TextBox textBoxVrcNameModeToken;
        private GroupBox groupBoxVrcNameKeys;
        private Button buttonclipboardAdvancedPublicKey;
        private Label label6;
        private TextBox textBoxVrcNameModePublicKey;
        private Button buttonGenerateAdvancedKeys;
        private TextBox textBoxVrcNameModeSpec;
        private Label label9;
        private Label label8;
        private PictureBox pictureBox2;
    }
}