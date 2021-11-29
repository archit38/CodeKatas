# CodeKatas

# Password Verifier
See PasswordVerifierTest for example usage. Basic usage:

var passwordVerifier = new PasswordVerifier(password, 
                                    new List<IPasswordRule> { new PasswordLengthRule() { Count = 8 } });
passwordVerifier.Verify();
