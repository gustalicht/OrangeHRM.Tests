public static class ConversorDeData
{
    public static string ConverterParaFormatoBrasileiro(DateTime data)
    {
        return data.ToString("dd/MM/yyyy");
    }

    public static string ConverterParaFormatoISO(DateTime data)
    {
        return data.ToString("yyyy-MM-dd");
    }
}
