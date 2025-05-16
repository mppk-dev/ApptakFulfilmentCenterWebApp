using ApptakFulfilmentCenterWebApp.Business.Repositories.AuthRepository;
using ApptakFulfilmentCenterWebApp.Models;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Text;
using ApptakFulfilmentCenterWebApp.Models.Dto;

namespace ApptakFulfilmentCenterWebApp.Business.Services.AuthService
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepo _authRepository;

        public AuthService(IAuthRepo authRepository)
        {
            _authRepository = authRepository;
        }

        public async Task<TaUsersAdmin?> AuthenticateUserAsync(string email, string plainPassword)
        {
            string userKey = UserPassKey(email);
            string encryptedPassword = Encrypt_admin(userKey, plainPassword);

            return await _authRepository.ValidateUserAsync(email, encryptedPassword);
        }

        private string Encrypt_admin(string sKey, string sPainText)
        {
            // string sKey = Session["sUser_Code"].ToString();
            //string sKey = "920000050277";
            // sKey = "920000050277";
            //sKey = "920000057860";
            if (sPainText.Length == 0)
                return (sPainText);
            return (EncryptString(sPainText, sKey));
        }

        private string EncryptString(string InputText, string Password)
        {
            // "Password" string variable is nothing but the key(your secret key) value which is sent from the front end.
            // "InputText" string variable is the actual password sent from the login page.
            // We are now going to create an instance of the
            // Rihndael class.
            RijndaelManaged RijndaelCipher = new RijndaelManaged();
            // First we need to turn the input strings into a byte array.
            byte[] PlainText = System.Text.Encoding.Unicode.GetBytes(InputText);
            // We are using Salt to make it harder to guess our key
            // using a dictionary attack.
            byte[] Salt = Encoding.ASCII.GetBytes(Password.Length.ToString());
            // The (Secret Key) will be generated from the specified
            // password and Salt.
            //PasswordDeriveBytes -- It Derives a key from a password
            PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(Password, Salt);
            // Create a encryptor from the existing SecretKey bytes.
            // We use 32 bytes for the secret key
            // (the default Rijndael key length is 256 bit = 32 bytes) and
            // then 16 bytes for the IV (initialization vector),
            // (the default Rijndael IV length is 128 bit = 16 bytes)
            ICryptoTransform Encryptor = RijndaelCipher.CreateEncryptor(SecretKey.GetBytes(16), SecretKey.GetBytes(16));
            // Create a MemoryStream that is going to hold the encrypted bytes
            MemoryStream memoryStream = new MemoryStream();
            // Create a CryptoStream through which we are going to be processing our data.
            // CryptoStreamMode.Write means that we are going to be writing data
            // to the stream and the output will be written in the MemoryStream
            // we have provided. (always use write mode for encryption)
            CryptoStream cryptoStream = new CryptoStream(memoryStream, Encryptor, CryptoStreamMode.Write);
            // Start the encryption process.
            cryptoStream.Write(PlainText, 0, PlainText.Length);
            // Finish encrypting.
            cryptoStream.FlushFinalBlock();
            // Convert our encrypted data from a memoryStream into a byte array.
            byte[] CipherBytes = memoryStream.ToArray();
            // Close both streams.
            memoryStream.Close();
            cryptoStream.Close();
            // Convert encrypted data into a base64-encoded string.
            // A common mistake would be to use an Encoding class for that.
            // It does not work, because not all byte values can be
            // represented by characters. We are going to be using Base64 encoding
            // That is designed exactly for what we are trying to do.
            string EncryptedData = Convert.ToBase64String(CipherBytes);
            // Return encrypted string.
            return EncryptedData;
        }

        private string UserPassKey(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                return string.Empty;

            var usernamePart = email.Split('@')[0];

            // Remove all non-alphanumeric characters
            var cleanedUsername = Regex.Replace(usernamePart, "[^a-zA-Z0-9]", "");

            return cleanedUsername;
        }

        public async Task<(bool Success, string Message)> SignUpAsync(SignUpDto signUpDto)
        {
            if (await _authRepository.IsEmailExistsAsync(signUpDto.UserEmail))
            {
                return (false, "Email already exists.");
            }

            string userKey = UserPassKey(signUpDto.UserEmail);
            string encryptedPassword = Encrypt_admin(userKey, signUpDto.UserPassword);

            TaUsersAdmin adminUser = new TaUsersAdmin
            {
                CompanyCode = "01",
                FirstName = signUpDto.UserFirstName,
                LastName = signUpDto.UserLastName,
                Email = signUpDto.UserEmail,
                Password = encryptedPassword,
                PhoneNo = signUpDto.UserPhoneNo,
                JoiningDate = DateOnly.FromDateTime(DateTime.Today),
                Status = "0",
                DateEntry = DateOnly.FromDateTime(DateTime.Today),
                Phone = signUpDto.UserPhoneNo,
                Country = "1",
                Province = "1",
                City = "1",
                Area = "97",
                Keydate = DateTime.Now,
                UserType = "1",
                FullName = $"{signUpDto.UserFirstName} {signUpDto.UserLastName}",
                CreatedBy = DateTime.Now.ToString(),
                Cnic = "00000-0000000-0",
                RCode = "RS04",
                ChangePassword = "N"
            };
            bool created = await _authRepository.RegisterUserAsync(adminUser);

            if (created)
            {
                var emailBody = $"<p>Dear {adminUser.FullName},</p><p>Welcome! Your account has been created successfully.</p>";
                //await _emailService.SendEmailAsync(adminUser.Email, "Welcome to Our Platform", emailBody);

                return (true, "User registered successfully.");
            }

            return (false, "Registration failed. Please try again.");
        }
    }
}
