using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace RED_putty
{
	class RSA_coder_encoder
	{

		public byte[] RSA_coder(string password)
		{
			UnicodeEncoding ByteConverter = new UnicodeEncoding();
			RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();


			byte[] dataToEncrypt = ByteConverter.GetBytes(password);
			byte[] encryptedData;
			byte[] decryptedData;

			// encryptedData = RSAEncrypt(dataToEncrypt, RSA.ExportParameters(false), false); //dupa


			return null;// encryptedData;
		}
	
	
	}
}
