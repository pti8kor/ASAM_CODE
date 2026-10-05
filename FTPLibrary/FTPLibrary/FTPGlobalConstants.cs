using System;
using System.Text;

namespace RB.FTPLibrary
{
	public static class GlobalConstants
	{
        public const string CONF_FILE = "D:\\ASAM-IF-IMPORT\\Import\\910 - BTConfigurations\\BT_FTP_Config.xml";

        public const string FTP_LOCAL_BASE_DIR = "D:\\ASAM-IF-IMPORT\\Import\\010 - TransferedFiles\\";

        //Filename length must not exceed this value as it cannot be stored in 010 - TransferedFiles
        //Windows 2012 r2 allows total Pathname-Length (Dirname\Filename) of 259 chars 

        public const int FTP_MAX_FILENAME_LENGTH = 137; 
        //only 142 chars allowed considering case of DAI 20 digit folder convention

        public const int MAX_ATTNAMELENGTH = 137;

        public const string CHARMAPPING_FILE = "D:\\ASAM-IF-IMPORT\\Import\\910 - BTConfigurations\\RO-ASAM_CharacterMappingTable.xml";

        public const string FTP_ACK_BASE_DIR = "D:\\ASAM-IF-IMPORT\\Import\\082 - TransferAcknowledgment\\";
        public const string FTP_ACK_TARGET_DIR = "D:\\FTP Simulation\\DaimlerExport\\";

        public const string DECLARATION_ISO = "ISO-8859-1";

        public const string NORMAL_MODE = "Normal";
        public const string AUTOMIZED_MODE = "Automatic";

        public const string INTERFACE_CONFIG_PATTERN = "_BT_RO_INTERFACE_CONFIG";

        public const string EMAILSETTINGS = "EMAIL_SETTINGS";
        public const string TRANSMITTERALERT = "TRANSMITTER_ALERT_EMAIL";
        public const string BTEMAIL = "BT_EMAIL_ADDRESS";
        public const string ADMINEMAIL = "ADMIN_EMAIL_ADDRESS";
        public const string SMTP = "SMTP";
        public const string EMAIL = "EMAIL";
        public const string SUBJECT = "SUBJECT";
        public const string MESSAGE = "STATIC_MESSAGE";
        public const string FOOTER = "FOOTER";
        public const string MSGACKFILE = "${MSGACKFILE}";
        public const string ENABLEALERT = "ENABLE_ALERT";
    }
}
