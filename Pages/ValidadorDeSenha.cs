namespace OrangeHRM.Utils
{
    public static class ValidadorDeSenha
    {
        public static bool SenhaEhForte(string senha)
        {
            if (string.IsNullOrWhiteSpace(senha)) return false;

            return senha.Length >= 8 &&
                   senha.Any(char.IsUpper) &&
                   senha.Any(char.IsLower) &&
                   senha.Any(char.IsDigit) &&
                   senha.Any(c => "!@#$%^&*".Contains(c));
        }
    }
}
