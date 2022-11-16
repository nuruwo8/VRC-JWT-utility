using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;

namespace VRC_JWT_utility
{
    public static class RsaPemMaker
    {
        public static string GetPrivatePemString(RSAParameters p)
        {
            var key = new RsaPrivateCrtKeyParameters(
              new BigInteger(1, p.Modulus),
              new BigInteger(1, p.Exponent),
              new BigInteger(1, p.D),
              new BigInteger(1, p.P),
              new BigInteger(1, p.Q),
              new BigInteger(1, p.DP),
              new BigInteger(1, p.DQ),
              new BigInteger(1, p.InverseQ));

            using (var stream = new MemoryStream())
            {
                using (var writer = new StreamWriter(stream, new UTF8Encoding()))
                {
                    var pemWriter = new Org.BouncyCastle.OpenSsl.PemWriter(writer);
                    pemWriter.WriteObject(key);
                }

                return new UTF8Encoding().GetString(stream.ToArray()).Replace("\r\n", "\n");
            }
        }

        public static string GetPublicPemString(RSAParameters p)
        {
            var key = new RsaKeyParameters(
              false,
              new BigInteger(1, p.Modulus),
              new BigInteger(1, p.Exponent));

            using (var stream = new MemoryStream())
            {
                using (var writer = new StreamWriter(stream, new UTF8Encoding()))
                {
                    var pemWriter = new Org.BouncyCastle.OpenSsl.PemWriter(writer);
                    pemWriter.WriteObject(key);
                }

                return new UTF8Encoding().GetString(stream.ToArray()).Replace("\r\n", "\n");
            }
        }
    }
}
