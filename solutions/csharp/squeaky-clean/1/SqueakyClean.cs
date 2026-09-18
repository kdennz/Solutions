using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var sb = new StringBuilder();
        bool capitalizeNext = false;

        foreach (char c in identifier)
        {
            if (c == '-')
            {
                capitalizeNext = true;
                continue;
            }

            if (c == ' ')
            {
                sb.Append('_');
                continue;
            }

            if (char.IsControl(c))
            {
                sb.Append("CTRL");
                continue;
            }

            if (c >= 'α' && c <= 'ω')
            {
                continue; // omite letras griegas minúsculas
            }

            if (!char.IsLetter(c) && c != '_')
            {
                continue; // omite lo que no sea letra ni guion bajo
            }

            if (capitalizeNext)
            {
                sb.Append(char.ToUpper(c));
                capitalizeNext = false;
            }
            else
            {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }
}