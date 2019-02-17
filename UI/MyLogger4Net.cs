namespace UI
{
    public static class MyLogger4Net
    {
        //ubicacion: ...\AppPublicitaria\UI\bin\Debug\CarteleriaDigital.log
        public static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    }
}
