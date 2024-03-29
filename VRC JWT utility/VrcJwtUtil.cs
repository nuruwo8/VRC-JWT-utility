using Microsoft.IdentityModel.Tokens;
using System.Diagnostics;
using System.IO;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace VRC_JWT_utility
{
    public partial class VrcJwtUtil : Form
    {
        const string VRC_NAME_MODE_KEYS_DIRECTORY_PATH = "vrc_name_mode_keys";
        const string VRC_NAME_MODE_PUBLIC_KEY_PATH = VRC_NAME_MODE_KEYS_DIRECTORY_PATH + "/public_key.pem";
        const string VRC_NAME_MODE_PRIVATE_KEY_PATH = VRC_NAME_MODE_KEYS_DIRECTORY_PATH + "/private_key.pem";
        const string SPEC_ONE_TOKEN_TEXT = @"Algorithm: RSA (RS256) 2048bit
Claims: iat (unix time when generate)
Token expiration period: forever
";
        const string SPEC_VRC_NAME_TOKEN_TEXT = @"Algorithm: RSA (RS256) 2048bit
Claims: vrcName (Hashed by SHA256),
             iat (unix time when generate)
Token expiration period: forever
";
        //In this web app, user can paste token to clipboard by one click. for utilize VR controller.
        const string CLIPBOARD_BASE_URL = "https://nuruwo8.github.io/web-clipboard-pasting/?t=";

        public VrcJwtUtil()
        {
            InitializeComponent();
            if (!Directory.Exists(VRC_NAME_MODE_KEYS_DIRECTORY_PATH))
            {
                Directory.CreateDirectory(VRC_NAME_MODE_KEYS_DIRECTORY_PATH);
            }

            //check generated.
            if (File.Exists(VRC_NAME_MODE_PUBLIC_KEY_PATH) && File.Exists(VRC_NAME_MODE_PRIVATE_KEY_PATH))
            {
                var readPublicKey = File.ReadAllText(VRC_NAME_MODE_PUBLIC_KEY_PATH);
                textBoxVrcNameModePublicKey.Text = readPublicKey.Replace("\n", "\r\n");
                groupBoxVrcNameToken.Enabled = true;
            }
            else
            {
                groupBoxVrcNameToken.Enabled = false;
            }
            textBoxSpec.Text = SPEC_ONE_TOKEN_TEXT;
            textBoxVrcNameModeSpec.Text = SPEC_VRC_NAME_TOKEN_TEXT;
        }

        /// <summary>
        /// generate RSA keys.
        /// </summary>
        /// <returns>RSA keys PEM format (private key , public key) </returns>
        private static (string, string) GenerateRsaKeyPair()
        {
            var rsa = RSA.Create(2048); //generate RSA keys
            //convert PEM format
            var parameter = rsa.ExportParameters(true);
            return (RsaPemMaker.GetPrivatePemString(parameter), RsaPemMaker.GetPublicPemString(parameter));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="privateKey"></param>
        /// <param name="validPeriodMinutes"></param>
        /// <param name="claims"></param>
        /// <returns></returns>
        private static string GenerateJwtToken(string privateKey, Dictionary<string, object>? claims = null, uint? validPeriodMinutes = null, DateTime? iat = null)
        {
            string token = "";
            using (var rsa = RSA.Create())
            {
                if (claims == null)
                {
                    claims = new Dictionary<string, object>() { };
                }

                DateTime? expires = null;
                if (validPeriodMinutes != null)
                {
                    expires = DateTime.UtcNow.AddMinutes((double)validPeriodMinutes);
                }

                if (iat == null)
                {
                    iat = DateTime.UtcNow;
                }

                var signingCredentials = new SigningCredentials(new RsaSecurityKey(rsa), SecurityAlgorithms.RsaSha256)
                {
                    CryptoProviderFactory = new CryptoProviderFactory { CacheSignatureProviders = false }
                };

                rsa.ImportFromPem(privateKey);
                var descriptor = new SecurityTokenDescriptor()
                {
                    Claims = claims,
                    SigningCredentials = signingCredentials,
                    IssuedAt = iat,
                    Expires = expires,
                };

                var handler = new System.IdentityModel.Tokens.Jwt.JwtSecurityTokenHandler();
                handler.SetDefaultTimesOnTokenCreation = false;
                token = handler.WriteToken(handler.CreateJwtSecurityToken(descriptor));
            }
            return token;
        }

        /// <summary>
        /// generate token from one time RSA keys
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFixedOneToken_Click(object sender, EventArgs e)
        {
            //generate one time RSA keys
            (var privateKey, var publicKey) = GenerateRsaKeyPair();
            //generate token. no custom claim , no exp (forever)
            var token = GenerateJwtToken(privateKey);
            textBoxPublicKeyForFixedToken.Text = publicKey.Replace("\n", "\r\n");
            textBoxTokenForFixedToken.Text = token.Replace("\n", "\r\n");
            groupBoxOneTokenResults.Enabled = true;
        }

        /// <summary>
        /// paste public key to clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClipboardPublicKeyForFixedToken_Click(object sender, EventArgs e)
        {
            try
            {
                string text = textBoxPublicKeyForFixedToken.Text;
                Clipboard.SetText(text: text);
            }
            catch (Exception ex) { Debug.WriteLine(ex.ToString()); }
        }

        /// <summary>
        /// paste token to clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClipboardTokenForFixedToken_Click(object sender, EventArgs e)
        {
            try
            {
                string text = textBoxTokenForFixedToken.Text;
                Clipboard.SetText(text: text);
            }
            catch (Exception ex) { Debug.WriteLine(ex.ToString()); }
        }

        /// <summary>
        /// paste token with URL to clipboard(for one click clipboardfor VR user)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClipboardTokenWithUrlForFixedToken_Click(object sender, EventArgs e)
        {
            try
            {
                string text = CLIPBOARD_BASE_URL + textBoxTokenForFixedToken.Text;
                Clipboard.SetText(text: text);
            }
            catch (Exception ex) { Debug.WriteLine(ex.ToString()); }
        }

        /// <summary>
        /// generate public key and private key.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGenerateAdvancedKeys_Click(object sender, EventArgs e)
        {
            //generate RSA keys
            //check generated keys are exists.
            if (File.Exists(VRC_NAME_MODE_PUBLIC_KEY_PATH) && File.Exists(VRC_NAME_MODE_PRIVATE_KEY_PATH))
            {
                DialogResult result = MessageBox.Show("A key has already been generated.\n If you continue with the generation, the existing key will be overwritten and the tokens generated so far will be invalid.\n Do you want to continue generating?",
                    "confirmation",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2);

                if (result == DialogResult.No || result == DialogResult.Cancel) return; // no or cancel or close message box.
                //yes is proceed process.
            }

            (var privateKey, var publicKey) = GenerateRsaKeyPair();
            File.WriteAllText(VRC_NAME_MODE_PUBLIC_KEY_PATH, publicKey);
            File.WriteAllText(VRC_NAME_MODE_PRIVATE_KEY_PATH, privateKey);
            var readPublicKey = File.ReadAllText(VRC_NAME_MODE_PUBLIC_KEY_PATH);
            textBoxVrcNameModePublicKey.Text = readPublicKey.Replace("\n", "\r\n");
            groupBoxVrcNameToken.Enabled = true;
        }

        /// <summary>
        /// paste public key to clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClipboardAdvancedPublicKey_Click(object sender, EventArgs e)
        {
            try
            {
                string text = textBoxVrcNameModePublicKey.Text;
                Clipboard.SetText(text: text);
            }
            catch (Exception ex) { Debug.WriteLine(ex.ToString()); }
        }

        /// <summary>
        /// generate token with vrchat name. using from generated private key.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGenerateVrcNameToken_Click(object sender, EventArgs e)
        {
            //check VrcName
            var input = textBoxVrcName.Text;
            var vrcName = input.Trim();
            if (vrcName.Length < 1)
            {
                MessageBox.Show("VRChat name is too short.(available 1 to 37 characters)",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            else if (vrcName.Length > 37)
            {
                MessageBox.Show("VRChat name is too long.(available 1 to 37 characters)",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            //get hash
            var nowDateTime = DateTime.UtcNow;
            var hashedVrcName = GetSHA256Hash(ToUnixTime(nowDateTime).ToString() + vrcName);
            Debug.WriteLine(ToUnixTime(nowDateTime).ToString() + vrcName);
            //generate token. vrcName claim , no exp (forever)
            var privateKey = File.ReadAllText(VRC_NAME_MODE_PRIVATE_KEY_PATH);
            var claims = new Dictionary<string, object>() { { "vrcName", hashedVrcName } };
            var token = GenerateJwtToken(privateKey, claims, null, nowDateTime);
            textBoxVrcNameModeToken.Text = token.Replace("\n", "\r\n");
        }

        /// <summary>
        /// get UnixTime from Datatime
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static ulong ToUnixTime(DateTime dt)
        {
            return (ulong)((dt.Subtract(new DateTime(1970, 1, 1))).TotalSeconds);
        }

        /// <summary>
        /// get SHA256 hex strings from string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static string GetSHA256Hash(string input)
        {
            byte[] data = System.Text.Encoding.UTF8.GetBytes(input);
            var sha256 = SHA256.Create();
            var bs = sha256.ComputeHash(data);
            sha256.Clear();
            string result = BitConverter.ToString(bs).ToLower().Replace("-", "");
            return result;
        }

        /// <summary>
        /// paste token to clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClipboardAdvancedToken_Click(object sender, EventArgs e)
        {
            try
            {
                string text = textBoxVrcNameModeToken.Text;
                Clipboard.SetText(text: text);
            }
            catch (Exception ex) { Debug.WriteLine(ex.ToString()); }
        }

        /// <summary>
        /// paste token with URL to clipboard(for one click clipboardfor VR user)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClipboardWithUrlAdvancedToken_Click(object sender, EventArgs e)
        {
            try
            {
                string text = CLIPBOARD_BASE_URL + textBoxVrcNameModeToken.Text;
                Clipboard.SetText(text: text);
            }
            catch (Exception ex) { Debug.WriteLine(ex.ToString()); }
        }
    }
}