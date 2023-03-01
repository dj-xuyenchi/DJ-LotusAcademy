using System;
using Microsoft.Extensions.Configuration;

namespace DJ_UseCaseLayer.DAO
{
	public class Setting
	{
        public static string url()
        {
<<<<<<< Updated upstream
            return "Data Source=192.168.1.101;Initial Catalog=djxuyenc_ladatabase;User ID=sa;password=1231234;encrypt=true;trustservercertificate=true;";
=======
            return "Data Source=192.168.1.13;Initial Catalog=djxuyenc_ladatabase;User ID=hieu_remote;password=1231234;encrypt=true;trustservercertificate=true;";
>>>>>>> Stashed changes
        }
        public static string urlWin()
        {
            return "Data Source=192.168.1.101;Initial Catalog=djxuyenc_ladatabase;User ID=sa;password=mamama99;encrypt=true;trustservercertificate=true;MultipleActiveResultSets=true";
        }
        public static string urlLC()
        {
            return "Data Source=localhost;Initial Catalog=djxuyenc_ladatabase;User ID=sa;password=1231234;encrypt=true;trustservercertificate=true;MultipleActiveResultSets=true";
        }
    }
}

