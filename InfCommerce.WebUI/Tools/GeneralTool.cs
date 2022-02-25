namespace InfCommerce.WebUI.Tools
{
    public class GeneralTool
    {
        public static string ConvertURL(string text)
        {
            return text.ToLower().Replace(" ", "-").Replace("ü", "u").Replace("ö", "o").Replace("ş", "s").Replace("ç", "c").Replace("ğ", "g").Replace("ı", "i");
        }
    }
}