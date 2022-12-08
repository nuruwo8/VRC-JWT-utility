using Microsoft.IdentityModel.Tokens;
using System.Diagnostics;
using System.Security.Cryptography;

namespace VRC_JWT_utility
{
    public partial class VrcJwtUtil : Form
    {
        const string SPEC_TEXT = @"Algorithm: RSA (RS256) 2048bit
Claims: iat (unix time when generate)
Token expiration period: forever
";
        //In this web app, user can paste token to clipboard by one click. for utilize VR controller.
        const string CLIPBOARD_BASE_URL = "https://nuruo789.github.io/web-clipboard-pasting/?t=";

        public VrcJwtUtil()
        {
            InitializeComponent();
            textBoxSpec.Text = SPEC_TEXT;
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
        private static string GenerateJwtToken(string privateKey, uint? validPeriodMinutes = null, Dictionary<string, object>? claims = null)
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

                rsa.ImportFromPem(privateKey);
                var descriptor = new SecurityTokenDescriptor()
                {
                    Claims = claims,
                    SigningCredentials = new SigningCredentials(new RsaSecurityKey(rsa), "RS256"),
                    IssuedAt = DateTime.UtcNow,
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
        /// paste public key to clipboad 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClipboadPublicKeyForFixedToken_Click(object sender, EventArgs e)
        {
            try
            {
                string text = textBoxPublicKeyForFixedToken.Text;
                Clipboard.SetText(text: text);
            }
            catch (Exception ex) { Debug.WriteLine(ex.ToString()); }
        }

        /// <summary>
        /// paste token to clipboad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClipboadTokenForFixedToken_Click(object sender, EventArgs e)
        {
            try
            {
                string text = textBoxTokenForFixedToken.Text;
                Clipboard.SetText(text: text);
            }
            catch (Exception ex) { Debug.WriteLine(ex.ToString()); }
        }

        /// <summary>
        /// paste token with URL to clipboad (for one click clipboad for VR user)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClipboadTokenWithUrlForFixedToken_Click(object sender, EventArgs e)
        {
            try
            {
                string text = CLIPBOARD_BASE_URL + textBoxTokenForFixedToken.Text;
                Clipboard.SetText(text: text);
            }
            catch (Exception ex) { Debug.WriteLine(ex.ToString()); }
        }

        private void buttonGenerateAdvancedKeys_Click(object sender, EventArgs e)
        {
            //generate RSA keys
            (var privateKey, var publicKey) = GenerateRsaKeyPair();

        }
    }
}