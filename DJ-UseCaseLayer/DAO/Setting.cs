namespace DJ_UseCaseLayer.DAO
{
    public class Setting
    {
        public static string url()
        {
            return "Data Source=192.168.1.101;Initial Catalog=djxuyenc_ladatabase;User ID=sa;password=1231234;encrypt=true;trustservercertificate=true;";
        }
        public static string urlWin()
        {
            return "Data Source=192.168.1.13;Initial Catalog=djxuyenc_ladatabase;User ID=sa;password=Mamama99;encrypt=true;trustservercertificate=true;";
        }
        public static string urlLC()
        {
            return "Data Source=localhost;Initial Catalog=djxuyenc_ladatabase;User ID=sa;password=1231234;encrypt=true;trustservercertificate=true;";
        }
    }
}

