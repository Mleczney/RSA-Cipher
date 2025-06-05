using System;
using System.Numerics;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RSA
{
    public partial class Form1 : Form
    {
        private BigInteger n, publicExponent, d; // Pøejmenováno "e" na "publicExponent"
        private int blockSize = 3; // Poèet znakù na blok (lze upravit podle zadání)

        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateKeysButton_Click(object sender, EventArgs e)
        {
            // Generování klíèù
            var random = new Random();
            BigInteger p = GenerateLargePrime(random);
            BigInteger q = GenerateLargePrime(random);

            n = p * q;
            BigInteger phi = (p - 1) * (q - 1);

            do
            {
                publicExponent = GenerateRandomCoprime(phi, random); // Opraveno z "e" na "publicExponent"
            } while (publicExponent <= 1 || publicExponent >= phi);

            d = ModInverse(publicExponent, phi);

            // Aktualizace textových polí
            PublicKeyTextBox.Text = $"Public Key (n, e): ({n}, {publicExponent})";
            PrivateKeyTextBox.Text = $"Private Key (n, d): ({n}, {d})";

            // Zobrazit hodnoty n, e (publicExponent) a d v samostatných textových polích
            nTextBox.Text = n.ToString();
            eTextBox.Text = publicExponent.ToString();
            dTextBox.Text = d.ToString();
        }


        private void EncryptButton_Click(object sender, EventArgs e)
        {
            string input = InputTextBox.Text;
            BigInteger[] blocks = ConvertTextToBlocks(input, Encoding.UTF8);
            StringBuilder encryptedBlocks = new StringBuilder();

            foreach (BigInteger block in blocks)
            {
                BigInteger encryptedBlock = BigInteger.ModPow(block, publicExponent, n);
                encryptedBlocks.Append(encryptedBlock + "-");
            }

            EncryptedTextBox.Text = encryptedBlocks.ToString().TrimEnd('-');
        }


        private void DecryptButton_Click(object sender, EventArgs e)
        {
            string[] encryptedBlocks = EncryptedTextBox.Text.Split('-');
            StringBuilder decryptedText = new StringBuilder();

            foreach (string encryptedBlock in encryptedBlocks)
            {
                BigInteger block = BigInteger.Parse(encryptedBlock);
                BigInteger decryptedBlock = BigInteger.ModPow(block, d, n);
                decryptedText.Append(ConvertBlockToText(decryptedBlock, Encoding.UTF8));
            }

            DecryptedTextBox.Text = decryptedText.ToString();
        }

        // Pomocné funkce
        private BigInteger GenerateLargePrime(Random random)
        {
            while (true)
            {
                BigInteger candidate = GenerateRandomBigInteger(50, random);
                if (IsPrime(candidate)) return candidate;
            }
        }

        private BigInteger GenerateRandomBigInteger(int bitLength, Random random)
        {
            byte[] bytes = new byte[(bitLength + 7) / 8];
            random.NextBytes(bytes);
            bytes[^1] &= (byte)((1 << (bitLength % 8)) - 1);
            return new BigInteger(bytes);
        }

        private bool IsPrime(BigInteger number)
        {
            if (number <= 1) return false;
            if (number <= 3) return true;
            if (number % 2 == 0 || number % 3 == 0) return false;

            for (BigInteger i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }
            return true;
        }

        private BigInteger GenerateRandomCoprime(BigInteger phi, Random random)
        {
            BigInteger candidate;
            do
            {
                candidate = GenerateRandomBigInteger((int)BigInteger.Log(phi, 2), random);
            } while (BigInteger.GreatestCommonDivisor(candidate, phi) != 1);

            return candidate;
        }

        private BigInteger ModInverse(BigInteger a, BigInteger m)
        {
            BigInteger m0 = m, t, q;
            BigInteger x0 = 0, x1 = 1;

            if (m == 1) return 0;

            while (a > 1)
            {
                q = a / m;
                t = m;
                m = a % m;
                a = t;
                t = x0;
                x0 = x1 - q * x0;
                x1 = t;
            }

            if (x1 < 0) x1 += m0;
            return x1;
        }

        private BigInteger[] ConvertTextToBlocks(string text, Encoding encoding)
        {
            byte[] bytes = encoding.GetBytes(text);
            int bytesPerBlock = blockSize; // Poèet bajtù na blok
            int numberOfBlocks = (bytes.Length + bytesPerBlock - 1) / bytesPerBlock;

            BigInteger[] blocks = new BigInteger[numberOfBlocks];

            for (int i = 0; i < numberOfBlocks; i++)
            {
                byte[] blockBytes = bytes.Skip(i * bytesPerBlock).Take(bytesPerBlock).ToArray();
                blocks[i] = new BigInteger(blockBytes.Reverse().Concat(new byte[] { 0 }).ToArray());
            }

            return blocks;
        }

        private string ConvertBlockToText(BigInteger block, Encoding encoding)
        {
            byte[] blockBytes = block.ToByteArray().Reverse().SkipWhile(b => b == 0).ToArray(); // Odebrání doplòkových nul
            return encoding.GetString(blockBytes);
        }


    }
}
