namespace Blog
{
    public static class Configuration
    {
        // TOKEN - JWT (pronuncia em ingles jowt)
        public static string JwtKey { get; set; } = "MDgzODIyYTQtYjU5YS00NjYzLTkwODMtZmUwOGRjNzFkNzk2";
        public static string ApiKeyName { get; set; } = "api_key";
        public static string ApiKey { get; set; } = "curso_api_DgzODIyYTQtYjU5YS00NjY";
        public static SmtpConfiguration Smtp { get; set; }

        public class SmtpConfiguration
        {
            public string Host { get; set; }
            public int Port { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
        }
    }
}
