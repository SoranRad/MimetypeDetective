using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TwentyDevs.MimeTypeDetective
{
    /// <summary>
    /// Declared about 600 mimetypes in a static list.
    /// if you want to add another mimetype use add method.Or create a new issue in github repository.
    /// </summary>
    public static class MimeTypes
    {
        /// <summary>
        /// A list of all mimetype about 600
        /// </summary>
        private static List<MimeTypeInfo> mimeTypeList;

        /// <summary>
        /// A list of all mimetype about 600
        /// </summary>
        public static IEnumerable<MimeTypeInfo> MimeTypeList => mimeTypeList.AsEnumerable();

        //public static readonly MimeTypeInfo TXT = new MimeTypeInfo(new byte?[0], "txt", "text/plain", "text file", false);
        public static readonly MimeTypeInfo _3GP = new MimeTypeInfo(new byte?[] { 0x00, 0x00, 0x00, 0x14, 0x66, 0x74, 0x79, 0x70 }, 0, "3gp", "video/3gpp", "3GPP multimedia files",false);
        public static readonly MimeTypeInfo _3GP2 = new MimeTypeInfo(new byte?[] { 0x00, 0x00, 0x00, 0x20, 0x66, 0x74, 0x79, 0x70 }, 0, "3gp2", "video/3gpp2", "3GPP2 multimedia files",false);
        public static readonly MimeTypeInfo _4XM = new MimeTypeInfo(new byte?[] { 0x52, 0x49, 0x46, 0x46 }, 0, "4xm", "application/octet-stream", "4X Movie video",true);
        public static readonly MimeTypeInfo _7Z = new MimeTypeInfo(new byte?[] { 0x37, 0x7A, 0xBC, 0xAF, 0x27, 0x1C }, 0, "7z", "application/x-7z-compressed", "7-Zip compressed file",false);
        public static readonly MimeTypeInfo ABA = new MimeTypeInfo(new byte?[] { 0x00, 0x01, 0x42, 0x41 }, 0, "aba", "", "Palm Address Book Archive",false);
        public static readonly MimeTypeInfo ABD = new MimeTypeInfo(new byte?[] { 0x51, 0x57, 0x20, 0x56, 0x65, 0x72, 0x2E, 0x20 }, 0, "abd", "", "ABD | QSD Quicken data file",true);
        public static readonly MimeTypeInfo ABI_1 = new MimeTypeInfo(new byte?[] { 0x41, 0x4F, 0x4C, 0x49, 0x4E, 0x44, 0x45, 0x58 }, 0, "abi", "application/abi", "AOL address book index",false);
        public static readonly MimeTypeInfo ABI_2 = new MimeTypeInfo(new byte?[] { 0x41, 0x4F, 0x4C }, 0, "abi", "application/abi", "AOL config files",true);
        public static readonly MimeTypeInfo ABY_1 = new MimeTypeInfo(new byte?[] { 0x41, 0x4F, 0x4C, 0x44, 0x42 }, 0, "aby", "", "AOL address book",true);
        public static readonly MimeTypeInfo ABY_2 = new MimeTypeInfo(new byte?[] { 0x41, 0x4F, 0x4C }, 0, "aby", "", "AOL config files",true);
        public static readonly MimeTypeInfo AC = new MimeTypeInfo(new byte?[] { 0x72, 0x69, 0x66, 0x66 }, 0, "ac", "application/pkix-attr-cert", "Sonic Foundry Acid Music File", false);
        public static readonly MimeTypeInfo ACCDB = new MimeTypeInfo(new byte?[] { 0x00, 0x01, 0x00, 0x00, 0x53, 0x74, 0x61, 0x6E, 0x64, 0x61, 0x72, 0x64, 0x20, 0x41, 0x43, 0x45, 0x20, 0x44, 0x42 }, 0, "accdb", "application/msaccess", "Microsoft Access 2007", false);
        public static readonly MimeTypeInfo ACM = new MimeTypeInfo(new byte?[] { 0x4D, 0x5A }, 0, "acm", "", "MS audio compression manager driver", true);
        public static readonly MimeTypeInfo ACS = new MimeTypeInfo(new byte?[] { 0xC3, 0xAB, 0xCD, 0xAB }, 0, "acs", "", "MS Agent Character file", false);
        public static readonly MimeTypeInfo AD = new MimeTypeInfo(new byte?[] { 0x52, 0x45, 0x56, 0x4E, 0x55, 0x4D, 0x3A, 0x2C }, 0, "ad", "", "Antenna data file", false);
        public static readonly MimeTypeInfo ADF = new MimeTypeInfo(new byte?[] { 0x44, 0x4F, 0x53 }, 0, "adf", "", "Amiga disk file", false);
        public static readonly MimeTypeInfo ADP = new MimeTypeInfo(new byte?[] { 0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, 0, "adp", "application/msaccess", "Access project file", true);
        public static readonly MimeTypeInfo ADX_1 = new MimeTypeInfo(new byte?[] { 0x03, 0x00, 0x00, 0x00, 0x41, 0x50, 0x50, 0x52 }, 0, "adx", "", "Approach index file", false);
        public static readonly MimeTypeInfo ADX_2 = new MimeTypeInfo(new byte?[] { 0x80, 0x00, 0x00, 0x20, 0x03, 0x12, 0x04 }, 0, "adx", "", "Dreamcast audio", false);
        public static readonly MimeTypeInfo AIFF = new MimeTypeInfo(new byte?[] { 0x46, 0x4F, 0x52, 0x4D, 0x00 }, 0, "aiff", "audio/aiff", "Audio Interchange File", false);
        public static readonly MimeTypeInfo AIN = new MimeTypeInfo(new byte?[] { 0x21, 0x12 }, 0, "ain", "", "AIN Compressed Archive",false);
        public static readonly MimeTypeInfo AMR = new MimeTypeInfo(new byte?[] { 0x23, 0x21, 0x41, 0x4D, 0x52 }, 0, "amr", "audio/amr", "Adaptive Multi-Rate ACELP Codec (GSM)", false);
        public static readonly MimeTypeInfo ANI = new MimeTypeInfo(new byte?[] { 0x52, 0x49, 0x46, 0x46 }, 0, "ani", "application/x-navi-animation", "Windows animated cursor", true);
        public static readonly MimeTypeInfo API = new MimeTypeInfo(new byte?[] { 0x4D, 0x5A, 0x90, 0x00, 0x03, 0x00, 0x00, 0x00 }, 0, "api", "", "Acrobat plug-in", true);
        public static readonly MimeTypeInfo APR = new MimeTypeInfo(new byte?[] { 0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, 0, "apr", "", "Lotus|IBM Approach 97 file", true);
        public static readonly MimeTypeInfo ARC_1 = new MimeTypeInfo(new byte?[] { 0x41, 0x72, 0x43, 0x01 }, 0, "arc", "application/octet-stream", "FreeArc compressed file", false);
        public static readonly MimeTypeInfo ARC_2 = new MimeTypeInfo(new byte?[] { 0x1A, 0x02 }, 0, "arc", "application/octet-stream", "LH archive (old vers.|type 1)", false);
        public static readonly MimeTypeInfo ARC_3 = new MimeTypeInfo(new byte?[] { 0x1A, 0x03 }, 0, "arc", "application/octet-stream", "LH archive (old vers.|type 2)", false);
        public static readonly MimeTypeInfo ARC_4 = new MimeTypeInfo(new byte?[] { 0x1A, 0x04 }, 0, "arc", "application/octet-stream", "LH archive (old vers.|type 3)", false);
        public static readonly MimeTypeInfo ARC_5 = new MimeTypeInfo(new byte?[] { 0x1A, 0x08 }, 0, "arc", "application/octet-stream", "LH archive (old vers.|type 4)", false);
        public static readonly MimeTypeInfo ARC_6 = new MimeTypeInfo(new byte?[] { 0x1A, 0x09 }, 0, "arc", "application/octet-stream", "LH archive (old vers.|type 5)", false);
        public static readonly MimeTypeInfo ARJ = new MimeTypeInfo(new byte?[] { 0x60, 0xEA }, 0, "arj", "application/x-arj", "ARJ Compressed archive file", false);
        public static readonly MimeTypeInfo ARL = new MimeTypeInfo(new byte?[] { 0xD4, 0x2A }, 0, "arl", "", "AOL history|typed URL files", true);
        public static readonly MimeTypeInfo ASF = new MimeTypeInfo(new byte?[] { 0x30, 0x26, 0xB2, 0x75, 0x8E, 0x66, 0xCF, 0x11 }, 0, "asf", "video/x-ms-asf", "Windows Media Audio|Video File", true);
        public static readonly MimeTypeInfo AST = new MimeTypeInfo(new byte?[] { 0x53, 0x43, 0x48, 0x6C }, 0, "ast", "", "Underground Audio", false);
        public static readonly MimeTypeInfo ASX = new MimeTypeInfo(new byte?[] { 0x3C }, 0, "asx", "video/x-ms-asf", "Advanced Stream Redirector", true);
        public static readonly MimeTypeInfo AU_1 = new MimeTypeInfo(new byte?[] { 0x64, 0x6E, 0x73, 0x2E }, 0, "au", "audio/basic", "Audacity audio file", false);
        public static readonly MimeTypeInfo AU_2 = new MimeTypeInfo(new byte?[] { 0x2E, 0x73, 0x6E, 0x64 }, 0, "au", "audio/basic", "NeXT|Sun Microsystems audio file", false);
        public static readonly MimeTypeInfo AUT = new MimeTypeInfo(new byte?[] { 0xD4, 0X2A }, 0, "aut", "", "AOL history|typed URL files", true);
        public static readonly MimeTypeInfo AVI = new MimeTypeInfo(new byte?[] { 0x52, 0x49, 0x46, 0x46 }, 0, "avi", "video/x-msvideo", "Resource Interchange File Format", true);
        public static readonly MimeTypeInfo AW = new MimeTypeInfo(new byte?[] { 0x8A, 0x01, 0x09, 0x00, 0x00, 0x00, 0xE1, 0x08 }, 0, "aw", "application/x-applix-word", "MS Answer Wizard", false);
        public static readonly MimeTypeInfo AX_1 = new MimeTypeInfo(new byte?[] { 0x4D, 0x5A, 0x90, 0x00, 0x03, 0x00, 0x00, 0x00 }, 0, "ax", "", "DirectShow filter", true);
        public static readonly MimeTypeInfo AX_2 = new MimeTypeInfo(new byte?[] { 0x4D, 0x5A }, 0, "ax", "", "Library cache file", true);
        public static readonly MimeTypeInfo BAG_1 = new MimeTypeInfo(new byte?[] { 0x41, 0x4F, 0x4C, 0x20, 0x46, 0x65, 0x65, 0x64 }, 0, "bag", "", "AOL and AIM buddy list", false);
        public static readonly MimeTypeInfo BAG_2 = new MimeTypeInfo(new byte?[] { 0x41, 0x4F, 0x4C }, 0, "bag", "", "AOL config files", true);
        public static readonly MimeTypeInfo BDR = new MimeTypeInfo(new byte?[] { 0x58, 0x54 }, 0, "bdr", "", "MS Publisher", false);
        public static readonly MimeTypeInfo BIN = new MimeTypeInfo(new byte?[] { 0x42, 0x4C, 0x49, 0x32, 0x32, 0x33, 0x51 }, 0, "bin", "application/octet-stream", "Speedtouch router firmware", false);
        public static readonly MimeTypeInfo BMP = new MimeTypeInfo(new byte?[] { 0x42, 0x4D }, 0, "bmp", "image/bmp", "Bitmap image", true);
        public static readonly MimeTypeInfo BZ2 = new MimeTypeInfo(new byte?[] { 0x42, 0x5A, 0x68 }, 0, "bz2", "application/x-bzip", "bzip2 compressed archive", true);
        public static readonly MimeTypeInfo CAB = new MimeTypeInfo(new byte?[] { 0x49, 0x53, 0x63, 0x28 }, 0, "cab", "application/octet-stream", "Install Shield compressed file", true);
        public static readonly MimeTypeInfo CAB_2 = new MimeTypeInfo(new byte?[] { 0x4D, 0x53, 0x43, 0x46 }, 0, "cab", "application/octet-stream", "Microsoft cabinet file", true);
        public static readonly MimeTypeInfo CAL_1 = new MimeTypeInfo(new byte?[] { 0x73, 0x72, 0x63, 0x64, 0x6F, 0x63, 0x69, 0x64 }, 0, "cal", "", "CALS raster bitmap", false);
        public static readonly MimeTypeInfo CAL_2 = new MimeTypeInfo(new byte?[] { 0x53, 0x75, 0x70, 0x65, 0x72, 0x43, 0x61, 0x6C }, 0, "cal", "", "SuperCalc worksheet", false);
        public static readonly MimeTypeInfo CAL_3 = new MimeTypeInfo(new byte?[] { 0xB5, 0xA2, 0xB0, 0xB3, 0xB3, 0xB0, 0xA5, 0xB5 }, 0, "cal", "", "Windows calendar", false);
        public static readonly MimeTypeInfo CAP_1 = new MimeTypeInfo(new byte?[] { 0x58, 0x43, 0x50, 0x00 }, 0, "cap", "", "Packet sniffer files", false);
        public static readonly MimeTypeInfo CAP_2 = new MimeTypeInfo(new byte?[] { 0x52, 0x54, 0x53, 0x53 }, 0, "cap", "", "WinNT Netmon capture file", false);
        public static readonly MimeTypeInfo CAS = new MimeTypeInfo(new byte?[] { 0x5F, 0x43, 0x41, 0x53, 0x45, 0x5F }, 0, "cas", "", "EnCase case file", true);
        public static readonly MimeTypeInfo CAT = new MimeTypeInfo(new byte?[] { 0x30 }, 0, "cat", "application/vnd.ms-pki.seccat", "MS security catalog file", false);
        public static readonly MimeTypeInfo CBD = new MimeTypeInfo(new byte?[] { 0x43, 0x42, 0x46, 0x49, 0x4C, 0x45 }, 0, "cbd", "", "WordPerfect dictionary", false);
        public static readonly MimeTypeInfo CBK = new MimeTypeInfo(new byte?[] { 0x5F, 0x43, 0x41, 0x53, 0x45, 0x5F }, 0, "cbk", "", "EnCase case file", true);
        public static readonly MimeTypeInfo CDA = new MimeTypeInfo(new byte?[] { 0x52, 0x49, 0x46, 0x46 }, 0, "cda", "", "Resource Interchange File Format", true);
        public static readonly MimeTypeInfo CDR_1 = new MimeTypeInfo(new byte?[] { 0x52, 0x49, 0x46, 0x46 }, 0, "cdr", "application/vnd.corel-draw", "CorelDraw document", true);
        public static readonly MimeTypeInfo CDR_2 = new MimeTypeInfo(new byte?[] { 0x45, 0x4C, 0x49, 0x54, 0x45, 0x20, 0x43, 0x6F }, 0, "cdr", "application/vnd.corel-draw", "Elite Plus Commander game file", false);
        public static readonly MimeTypeInfo CDR_3 = new MimeTypeInfo(new byte?[] { 0x4D, 0x53, 0x5F, 0x56, 0x4F, 0x49, 0x43, 0x45 }, 0, "cdr", "application/vnd.corel-draw", "Sony Compressed Voice File", true);
        public static readonly MimeTypeInfo CFG = new MimeTypeInfo(new byte?[] { 0x5B, 0x66, 0x6C, 0x74, 0x73, 0x69, 0x6D, 0x2E }, 0, "cfg", "text/plain", "Flight Simulator Aircraft Configuration", false);
        public static readonly MimeTypeInfo CHI = new MimeTypeInfo(new byte?[] { 0x49, 0x54, 0x53, 0x46 }, 0, "chi", "", "MS Compiled HTML Help File", true);
        public static readonly MimeTypeInfo CHM = new MimeTypeInfo(new byte?[] { 0x49, 0x54, 0x53, 0x46 }, 0, "chm", "application/octet-stream", "MS Compiled HTML Help File", true);
        public static readonly MimeTypeInfo CLASS = new MimeTypeInfo(new byte?[] { 0xCA, 0xFE, 0xBA, 0xBE }, 0, "class", "application/x-java-applet", "Java bytecode", false);
        public static readonly MimeTypeInfo CLB_1 = new MimeTypeInfo(new byte?[] { 0x43, 0x4F, 0x4D, 0x2B }, 0, "clb", "", "COM+ Catalog", false);
        public static readonly MimeTypeInfo CLB_2 = new MimeTypeInfo(new byte?[] { 0x43, 0x4D, 0x58, 0x31 }, 0, "clb", "", "Corel Binary metafile", false);
        public static readonly MimeTypeInfo CMX = new MimeTypeInfo(new byte?[] { 0x52, 0x49, 0x46, 0x46 }, 0, "cmx", "image/x-cmx", "Corel Presentation Exchange metadata", true);
        public static readonly MimeTypeInfo CNV = new MimeTypeInfo(new byte?[] { 0x53, 0x51, 0x4C, 0x4F, 0x43, 0x4F, 0x4E, 0x56 }, 0, "cnv", "", "DB2 conversion file", false);
        public static readonly MimeTypeInfo COD = new MimeTypeInfo(new byte?[] { 0x4E, 0x61, 0x6D, 0x65, 0x3A, 0x20 }, 0, "cod", "image/cis-cod", "Agent newsreader character map", false);
        public static readonly MimeTypeInfo COM_1 = new MimeTypeInfo(new byte?[] { 0x4D, 0X5A }, 0, "com", "application/x-msdownload", "Windows|DOS executable file", true);
        public static readonly MimeTypeInfo COM_2 = new MimeTypeInfo(new byte?[] { 0xE8 }, 0, "com", "application/x-msdownload", "Windows executable file_1", true);
        public static readonly MimeTypeInfo COM_3 = new MimeTypeInfo(new byte?[] { 0xE9 }, 0, "com", "application/x-msdownload", "Windows executable file_2", true);
        public static readonly MimeTypeInfo COM_4 = new MimeTypeInfo(new byte?[] { 0xEB }, 0, "com", "application/x-msdownload", "Windows executable file_3", true);
        public static readonly MimeTypeInfo CPE = new MimeTypeInfo(new byte?[] { 0x46, 0x41, 0x58, 0x43, 0x4F, 0x56, 0x45, 0x52 }, 0, "cpe", "", "MS Fax Cover Sheet", false);
        public static readonly MimeTypeInfo CPI_1 = new MimeTypeInfo(new byte?[] { 0x53, 0x49, 0x45, 0x54, 0x52, 0x4F, 0x4E, 0x49 }, 0, "cpi", "", "Sietronics CPI XRD document", false);
        public static readonly MimeTypeInfo CPI_2 = new MimeTypeInfo(new byte?[] { 0xFF, 0x46, 0x4F, 0x4E, 0x54 }, 0, "cpi", "", "Windows international code page", false);
        public static readonly MimeTypeInfo CPX = new MimeTypeInfo(new byte?[] { 0x5B, 0x57, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x73 }, 0, "cpx", "", "Microsoft Code Page Translation file", false);
        public static readonly MimeTypeInfo CRU = new MimeTypeInfo(new byte?[] { 0x43, 0x52, 0x55, 0x53, 0x48, 0x20, 0x76 }, 0, "cru", "", "Crush compressed archive", false);
        public static readonly MimeTypeInfo CRW = new MimeTypeInfo(new byte?[] { 0x49, 0x49, 0x1A, 0x00, 0x00, 0x00, 0x48, 0x45 }, 0, "crw", "image/x-canon-crw", "Canon RAW file", false);
        public static readonly MimeTypeInfo CSH = new MimeTypeInfo(new byte?[] { 0x63, 0x75, 0x73, 0x68, 0x00, 0x00, 0x00, 0x02 }, 0, "csh", "application/x-csh", "Photoshop Custom Shape", false);
        public static readonly MimeTypeInfo CTF = new MimeTypeInfo(new byte?[] { 0x43, 0x61, 0x74, 0x61, 0x6C, 0x6F, 0x67, 0x20 }, 0, "ctf", "", "WhereIsIt Catalog", false);
        public static readonly MimeTypeInfo CTL = new MimeTypeInfo(new byte?[] { 0x56, 0x45, 0x52, 0x53, 0x49, 0x4F, 0x4E, 0x20 }, 0, "ctl", "", "Visual Basic User-defined Control file", false);
        public static readonly MimeTypeInfo CUIX = new MimeTypeInfo(new byte?[] { 0x50, 0x4B, 0x03, 0x04 }, 0, "cuix", "", "Customization files", true);
        public static readonly MimeTypeInfo CUR = new MimeTypeInfo(new byte?[] { 0x00, 0x00, 0x02, 0x00 }, 0, "cur", "application/octet-stream", "Windows cursor", true);
        public static readonly MimeTypeInfo DAT_1 = new MimeTypeInfo(new byte?[] { 0x52, 0x49, 0x46, 0x46 }, 0, "dat", "application/octet-stream", "Video CD MPEG movie", true);
        public static readonly MimeTypeInfo DAT_2 = new MimeTypeInfo(new byte?[] { 0xA9, 0x0D, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }, 0, "dat", "application/octet-stream", "Access Data FTK evidence", false);
        public static readonly MimeTypeInfo DAT_3 = new MimeTypeInfo(new byte?[] { 0x73, 0x6C, 0x68, 0x21 }, 0, "dat", "application/octet-stream", "Allegro Generic Packfile (compressed)", false);
        public static readonly MimeTypeInfo DAT_4 = new MimeTypeInfo(new byte?[] { 0x73, 0x6C, 0x68, 0x2E }, 0, "dat", "application/octet-stream", "Allegro Generic Packfile (uncompressed)", false);
        public static readonly MimeTypeInfo DAT_5 = new MimeTypeInfo(new byte?[] { 0x41, 0x56, 0x47, 0x36, 0x5F, 0x49, 0x6E, 0x74 }, 0, "dat", "application/octet-stream", "AVG6 Integrity database", false);
        public static readonly MimeTypeInfo DAT_6 = new MimeTypeInfo(new byte?[] { 0x03 }, 0, "dat", "application/octet-stream", "MapInfo Native Data Format", true);
        public static readonly MimeTypeInfo DAT_7 = new MimeTypeInfo(new byte?[] { 0x45, 0x52, 0x46, 0x53, 0x53, 0x41, 0x56, 0x45 }, 0, "dat", "application/octet-stream", "EasyRecovery Saved State file", false);
        public static readonly MimeTypeInfo DAT_8 = new MimeTypeInfo(new byte?[] { 0x43, 0x6C, 0x69, 0x65, 0x6E, 0x74, 0x20, 0x55 }, 0, "dat", "application/octet-stream", "IE History file", false);
        public static readonly MimeTypeInfo DAT_9 = new MimeTypeInfo(new byte?[] { 0x49, 0x6E, 0x6E, 0x6F, 0x20, 0x53, 0x65, 0x74 }, 0, "dat", "application/octet-stream", "Inno Setup Uninstall Log", false);
        public static readonly MimeTypeInfo DAT_10 = new MimeTypeInfo(new byte?[] { 0x50, 0x4E, 0x43, 0x49, 0x55, 0x4E, 0x44, 0x4F }, 0, "dat", "application/octet-stream", "Norton Disk Doctor undo file", false);
        public static readonly MimeTypeInfo DAT_11 = new MimeTypeInfo(new byte?[] { 0x50, 0x45, 0x53, 0x54 }, 0, "dat", "application/octet-stream", "PestPatrol data|scan strings", false);
        public static readonly MimeTypeInfo DAT_12 = new MimeTypeInfo(new byte?[] { 0x1A, 0x52, 0x54, 0x53, 0x20, 0x43, 0x4F, 0x4D }, 0, "dat", "application/octet-stream", "Runtime Software disk image", false);
        public static readonly MimeTypeInfo DAT_13 = new MimeTypeInfo(new byte?[] { 0x52, 0x41, 0x5A, 0x41, 0x54, 0x44, 0x42, 0x31 }, 0, "dat", "application/octet-stream", "Shareaza (P2P) thumbnail", false);
        public static readonly MimeTypeInfo DAT_14 = new MimeTypeInfo(new byte?[] { 0x4E, 0x41, 0x56, 0x54, 0x52, 0x41, 0x46, 0x46 }, 0, "dat", "application/octet-stream", "TomTom traffic data", false);
        public static readonly MimeTypeInfo DAT_15 = new MimeTypeInfo(new byte?[] { 0x55, 0x46, 0x4F, 0x4F, 0x72, 0x62, 0x69, 0x74 }, 0, "dat", "application/octet-stream", "UFO Capture map file", false);
        public static readonly MimeTypeInfo DAT_16 = new MimeTypeInfo(new byte?[] { 0x57, 0x4D, 0x4D, 0x50 }, 0, "dat", "application/octet-stream", "Walkman MP3 file", false);
        public static readonly MimeTypeInfo DAT_17 = new MimeTypeInfo(new byte?[] { 0x43, 0x52, 0x45, 0x47 }, 0, "dat", "application/octet-stream", "Win9x registry hive", false);
        public static readonly MimeTypeInfo DAT_18 = new MimeTypeInfo(new byte?[] { 0x72, 0x65, 0x67, 0x66 }, 0, "dat", "application/octet-stream", "WinNT registry file", false);
        public static readonly MimeTypeInfo DB_1 = new MimeTypeInfo(new byte?[] { 0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, 0, "db", "application/vnd.sqlite3", "MSWorks database file", true);
        public static readonly MimeTypeInfo DB_2 = new MimeTypeInfo(new byte?[] { 0x08 }, 0, "db", "application/vnd.sqlite3", "dBASE IV or dBFast configuration file", false);
        public static readonly MimeTypeInfo DB_3 = new MimeTypeInfo(new byte?[] { 0x00, 0x06, 0x15, 0x61, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x04, 0xD2, 0x00, 0x00, 0x10, 0x00 }, 0, "db", "application/vnd.sqlite3", "Netscape Navigator (v4) database", false);
        public static readonly MimeTypeInfo DB_4 = new MimeTypeInfo(new byte?[] { 0x44, 0x42, 0x46, 0x48 }, 0, "db", "application/vnd.sqlite3", "Palm Zire photo database", false);
        public static readonly MimeTypeInfo DB_5 = new MimeTypeInfo(new byte?[] { 0x53, 0x51, 0x4C, 0x69, 0x74, 0x65, 0x20, 0x66, 0x6F, 0x72, 0x6D, 0x61, 0x74, 0x20, 0x33, 0x00 }, 0, "db", "application/vnd.sqlite3", "SQLite database file", false);
        public static readonly MimeTypeInfo DB_6 = new MimeTypeInfo(new byte?[] { 0xFD, 0xFF, 0xFF, 0xFF }, 512, "db", "application/vnd.sqlite3", "Thumbs.db subheader", false);
        public static readonly MimeTypeInfo DB3 = new MimeTypeInfo(new byte?[] { 0x03 }, 0, "db3", "", "dBASE III file", true);
        public static readonly MimeTypeInfo DB4 = new MimeTypeInfo(new byte?[] { 0x04 }, 0, "db4", "", "dBASE IV file", false);
        public static readonly MimeTypeInfo DBA = new MimeTypeInfo(new byte?[] { 0x00, 0x01, 0x42, 0x44 }, 0, "dba", "", "Palm DateBook Archive", false);
        public static readonly MimeTypeInfo DBB = new MimeTypeInfo(new byte?[] { 0x6C, 0x33, 0x33, 0x6C }, 0, "dbb", "", "Skype user data file", false);
        public static readonly MimeTypeInfo DBF = new MimeTypeInfo(new byte?[] { 0x4F, 0x50, 0x4C, 0x44, 0x61, 0x74, 0x61, 0x62 }, 0, "dbf", "", "Psion Series 3 Database", false);
        public static readonly MimeTypeInfo DBX = new MimeTypeInfo(new byte?[] { 0xCF, 0xAD, 0x12, 0xFE }, 0, "dbx", "", "Outlook Express e-mail folder", false);
        public static readonly MimeTypeInfo DCI = new MimeTypeInfo(new byte?[] { 0x3C, 0x21, 0x64, 0x6F, 0x63, 0x74, 0x79, 0x70 }, 0, "dci", "", "AOL HTML mail", false);
        public static readonly MimeTypeInfo DCX = new MimeTypeInfo(new byte?[] { 0xB1, 0x68, 0xDE, 0x3A }, 0, "dcx", "", "PCX bitmap", false);
        public static readonly MimeTypeInfo DEX = new MimeTypeInfo(new byte?[] { 0x64, 0x65, 0x78, 0x0A, 0x30, 0x30, 0x39, 0x00 }, 0, "dex", "", "Dalvik (Android) executable file", false);
        public static readonly MimeTypeInfo DIB = new MimeTypeInfo(new byte?[] { 0x42, 0x4D }, 0, "dib", "image/bmp", "Bitmap image", true);
        public static readonly MimeTypeInfo DLL = new MimeTypeInfo(new byte?[] { 0x4D, 0x5A }, 0, "dll", "application/x-msdownload", "Windows|DOS executable file", true);
        public static readonly MimeTypeInfo DMG = new MimeTypeInfo(new byte?[] { 0x78 }, 0, "dmg", "application/x-apple-diskimage", "MacOS X image file", false);
        public static readonly MimeTypeInfo DMP_1 = new MimeTypeInfo(new byte?[] { 0x4D, 0x44, 0x4D, 0x50, 0x93, 0xA7 }, 0, "dmp", "", "Windows dump file", true);
        public static readonly MimeTypeInfo DMP_2 = new MimeTypeInfo(new byte?[] { 0x50, 0x41, 0x47, 0x45, 0x44, 0x55 }, 0, "dmp", "", "Windows memory dump", false);
        public static readonly MimeTypeInfo DMS = new MimeTypeInfo(new byte?[] { 0x44, 0x4D, 0x53, 0x21 }, 0, "dms", "application/octet-stream", "Amiga DiskMasher compressed archive", false);
        public static readonly MimeTypeInfo DOC_1 = new MimeTypeInfo(new byte?[] { 0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, 0, "doc", "application/msword", "Microsoft Office document", true);
        public static readonly MimeTypeInfo DOC_2 = new MimeTypeInfo(new byte?[] { 0x0D, 0x44, 0x4F, 0x43 }, 0, "doc", "application/msword", "DeskMate Document", true);
        public static readonly MimeTypeInfo DOC_3 = new MimeTypeInfo(new byte?[] { 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1, 0x00 }, 0, "doc", "application/msword", "Perfect Office document", true);
        public static readonly MimeTypeInfo DOC_4 = new MimeTypeInfo(new byte?[] { 0xDB, 0xA5, 0x2D, 0x00 }, 0, "doc", "application/msword", "Word 2.0 file", true);
        public static readonly MimeTypeInfo DOC_5 = new MimeTypeInfo(new byte?[] { 0xEC, 0xA5, 0xC1, 0x00 }, 512, "doc", "application/msword", "Word document subheader", true);
        public static readonly MimeTypeInfo DOCX_1 = new MimeTypeInfo(new byte?[] { 0x50, 0x4B, 0x03, 0x04 }, 0, "docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document", "MS Office Open XML Format Document", true);
        public static readonly MimeTypeInfo DOCX_2 = new MimeTypeInfo(new byte?[] { 0x50, 0x4B, 0x03, 0x04, 0x14, 0x00, 0x06, 0x00 }, 0, "docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document", "MS Office 2007 documents", true);
        public static readonly MimeTypeInfo DOT = new MimeTypeInfo(new byte?[] { 0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, 0, "dot", "application/msword", "Microsoft Office document", true);
        public static readonly MimeTypeInfo DRV = new MimeTypeInfo(new byte?[] { 0x4D, 0x5A }, 0, "drv", "", "Windows|DOS executable file", true);
        public static readonly MimeTypeInfo DRW_1 = new MimeTypeInfo(new byte?[] { 0x07 }, 0, "drw", "", "Generic drawing programs", false);
        public static readonly MimeTypeInfo DRW_2 = new MimeTypeInfo(new byte?[] { 0x01, 0xFF, 0x02, 0x04, 0x03, 0x02 }, 0, "drw", "", "Micrografx vector graphic file", false);
        public static readonly MimeTypeInfo DS4 = new MimeTypeInfo(new byte?[] { 0x52, 0x49, 0x46, 0x46 }, 0, "ds4", "", "Micrografx Designer graphic", true);
        public static readonly MimeTypeInfo DSN = new MimeTypeInfo(new byte?[] { 0x4D, 0x56 }, 0, "dsn", "", "CD Stomper Pro label file", false);
        public static readonly MimeTypeInfo DSP = new MimeTypeInfo(new byte?[] { 0x23, 0x20, 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73 }, 0, "dsp", "application/octet-stream", "MS Developer Studio project file", false);
        public static readonly MimeTypeInfo DSS = new MimeTypeInfo(new byte?[] { 0x02, 0x64, 0x73, 0x73 }, 0, "dss", "", "Digital Speech Standard file", false);
        public static readonly MimeTypeInfo DSW = new MimeTypeInfo(new byte?[] { 0x64, 0x73, 0x77, 0x66, 0x69, 0x6C, 0x65 }, 0, "dsw", "text/plain", "MS Visual Studio workspace file", false);
        public static readonly MimeTypeInfo DTD = new MimeTypeInfo(new byte?[] { 0x07, 0x64, 0x74, 0x32, 0x64, 0x64, 0x74, 0x64 }, 0, "dtd", "text/xml", "DesignTools 2D Design file", false);
        public static readonly MimeTypeInfo DUN = new MimeTypeInfo(new byte?[] { 0x5B, 0x50, 0x68, 0x6F, 0x6E, 0x65, 0x5D }, 0, "dun", "", "Dial-up networking file", false);
        public static readonly MimeTypeInfo DVF = new MimeTypeInfo(new byte?[] { 0x4D, 0x53, 0x5F, 0x56, 0x4F, 0x49, 0x43, 0x45 }, 0, "dvf", "", "Sony Compressed Voice File", true);
        public static readonly MimeTypeInfo DVR = new MimeTypeInfo(new byte?[] { 0x44, 0x56, 0x44 }, 0, "dvr", "", "DVR-Studio stream file", true);
        public static readonly MimeTypeInfo DW4 = new MimeTypeInfo(new byte?[] { 0x4F, 0x7B }, 0, "dw4", "", "Visio|DisplayWrite 4 text file", false);
        public static readonly MimeTypeInfo DWG = new MimeTypeInfo(new byte?[] { 0x41, 0x43, 0x31, 0x30 }, 0, "dwg", "application/acad", "Generic AutoCAD drawing", false);
        public static readonly MimeTypeInfo E01_1 = new MimeTypeInfo(new byte?[] { 0x45, 0x56, 0x46, 0x09, 0x0D, 0x0A, 0xFF, 0x00 }, 0, "e01", "application/encase", "Expert Witness Compression Format", false);
        public static readonly MimeTypeInfo E01_2 = new MimeTypeInfo(new byte?[] { 0x4C, 0x56, 0x46, 0x09, 0x0D, 0x0A, 0xFF, 0x00 }, 0, "e01", "application/encase", "Logical File Evidence Format", false);
        public static readonly MimeTypeInfo ECF = new MimeTypeInfo(new byte?[] { 0x5B, 0x47, 0x65, 0x6E, 0x65, 0x72, 0x61, 0x6C }, 0, "ecf", "", "MS Exchange configuration file", false);
        public static readonly MimeTypeInfo EFX = new MimeTypeInfo(new byte?[] { 0xDC, 0xFE }, 0, "efx", "image/efax", "eFax file", false);
        public static readonly MimeTypeInfo EML_1 = new MimeTypeInfo(new byte?[] { 0x58, 0x2D }, 0, "eml", "message/rfc822", "Exchange e-mail", false);
        public static readonly MimeTypeInfo EML_2 = new MimeTypeInfo(new byte?[] { 0x52, 0x65, 0x74, 0x75, 0x72, 0x6E, 0x2D, 0x50 }, 0, "eml", "message/rfc822", "Generic e-mail_1", false);
        public static readonly MimeTypeInfo EML_3 = new MimeTypeInfo(new byte?[] { 0x46, 0x72, 0x6F, 0x6D }, 0, "eml", "message/rfc822", "Generic e-mail_2", false);
        public static readonly MimeTypeInfo ENL = new MimeTypeInfo(new byte?[] { 0x40, 0x40, 0x40, 0x20, 0x00, 0x00, 0x40, 0x40, 0x40, 0x40 }, 32, "enl", "", "EndNote Library File", false);
        public static readonly MimeTypeInfo EPS_1 = new MimeTypeInfo(new byte?[] { 0xC5, 0xD0, 0xD3, 0xC6 }, 0, "eps", "application/postscript", "Adobe encapsulated PostScript", false);
        public static readonly MimeTypeInfo EPS_2 = new MimeTypeInfo(new byte?[] { 0x25, 0x21, 0x50, 0x53, 0x2D, 0x41, 0x64, 0x6F }, 0, "eps", "application/postscript", "Encapsulated PostScript file", false);
        public static readonly MimeTypeInfo ETH = new MimeTypeInfo(new byte?[] { 0x1A, 0x35, 0x01, 0x00 }, 0, "eth", "application/octet-stream", "WinPharoah capture file", false);
        public static readonly MimeTypeInfo EVT = new MimeTypeInfo(new byte?[] { 0x30, 0x00, 0x00, 0x00, 0x4C, 0x66, 0x4C, 0x65 }, 0, "evt", "application/octet-stream", "Windows Event Viewer file", false);
        public static readonly MimeTypeInfo EVTX = new MimeTypeInfo(new byte?[] { 0x45, 0x6C, 0x66, 0x46, 0x69, 0x6C, 0x65, 0x00 }, 0, "evtx", "application/octet-stream", "Windows Vista event log", false);
        public static readonly MimeTypeInfo EXE = new MimeTypeInfo(new byte?[] { 0x4D, 0x5A }, 0, "exe", "application/vnd.microsoft.portable-executable", "Windows|DOS executable file", true);
        public static readonly MimeTypeInfo FDF = new MimeTypeInfo(new byte?[] { 0x25, 0x50, 0x44, 0x46 }, 0, "fdf", "application/vnd.fdf", "PDF file", true);
        public static readonly MimeTypeInfo FLAC = new MimeTypeInfo(new byte?[] { 0x66, 0x4C, 0x61, 0x43, 0x00, 0x00, 0x00, 0x22 }, 0, "flac", "audio/flac", "Free Lossless Audio Codec file", false);
        public static readonly MimeTypeInfo FLI = new MimeTypeInfo(new byte?[] { 0x00, 0x11 }, 0, "fli", "video/x-fli", "FLIC animation", false);
        public static readonly MimeTypeInfo FLT_1 = new MimeTypeInfo(new byte?[] { 0x4D, 0x5A, 0x90, 0x00, 0x03, 0x00, 0x00, 0x00 }, 0, "flt", "audio/x-mod", "Audition graphic filter", true);
        public static readonly MimeTypeInfo FLT_2 = new MimeTypeInfo(new byte?[] { 0x76, 0x32, 0x30, 0x30, 0x33, 0x2E, 0x31, 0x30 }, 0, "flt", "audio/x-mod", "Qimage filter", false);
        public static readonly MimeTypeInfo FLV = new MimeTypeInfo(new byte?[] { 0x46, 0x4C, 0x56 }, 0, "flv", "video/x-flv", "Flash video file", false);
        public static readonly MimeTypeInfo FM = new MimeTypeInfo(new byte?[] { 0x3C, 0x4D, 0x61, 0x6B, 0x65, 0x72, 0x46, 0x69 }, 0, "fm", "application/vnd.framemaker", "Adobe FrameMaker", true);
        public static readonly MimeTypeInfo FON = new MimeTypeInfo(new byte?[] { 0x4D, 0x5A }, 0, "fon", "application/octet-stream", "Font file", true);
        public static readonly MimeTypeInfo FTR = new MimeTypeInfo(new byte?[] { 0xD2, 0x0A, 0x00, 0x00 }, 0, "ftr", "application/octet-stream", "	WinPharoah filter file", false);
        public static readonly MimeTypeInfo GHO = new MimeTypeInfo(new byte?[] { 0xFE, 0xEF }, 0, "gho", "", "Symantex Ghost image file", true);
        public static readonly MimeTypeInfo GHS = new MimeTypeInfo(new byte?[] { 0xFE, 0xEF }, 0, "ghs", "", "Symantex Ghost image file", true);
        public static readonly MimeTypeInfo GID_1 = new MimeTypeInfo(new byte?[] { 0x3F, 0x5F, 0x03, 0x00 }, 0, "gid", "application/x-winhelp", "Windows help file_2", true);
        public static readonly MimeTypeInfo GID_2 = new MimeTypeInfo(new byte?[] { 0x4C, 0x4E, 0x02, 0x00 }, 0, "gid", "application/x-winhelp", "Windows help file_3", true);
        public static readonly MimeTypeInfo GIF = new MimeTypeInfo(new byte?[] { 0x47, 0x49, 0x46, 0x38 }, 0, "gif", "image/gif", "GIF file", false);
        public static readonly MimeTypeInfo GPG = new MimeTypeInfo(new byte?[] { 0x99 }, 0, "gpg", "application/gpg-keys", "GPG public keyring", false);
        public static readonly MimeTypeInfo GRP = new MimeTypeInfo(new byte?[] { 0x50, 0x4D, 0x43, 0x43 }, 0, "grp", "application/octet-stream", "Windows Program Manager group file", false);
        public static readonly MimeTypeInfo GX2 = new MimeTypeInfo(new byte?[] { 0x47, 0x58, 0x32 }, 0, "gx2", "", "Show Partner graphics file", false);
        public static readonly MimeTypeInfo GZ = new MimeTypeInfo(new byte?[] { 0x1F, 0x8B, 0x08 }, 0, "gz", "application/x-gzip", "GZIP archive file", false);
        public static readonly MimeTypeInfo HAP = new MimeTypeInfo(new byte?[] { 0x91, 0x33, 0x48, 0x46 }, 0, "hap", "", "Hamarsoft compressed archive", false);
        public static readonly MimeTypeInfo HDMP = new MimeTypeInfo(new byte?[] { 0x4D, 0x44, 0x4D, 0x50, 0x93, 0xA7 }, 0, "hdmp", "", "Windows dump file", true);
        public static readonly MimeTypeInfo HDR_1 = new MimeTypeInfo(new byte?[] { 0x49, 0x53, 0x63, 0x28 }, 0, "hdr", "", "Install Shield compressed file", true);
        public static readonly MimeTypeInfo HDR_2 = new MimeTypeInfo(new byte?[] { 0x23, 0x3F, 0x52, 0x41, 0x44, 0x49, 0x41, 0x4E }, 0, "hdr", "", "Radiance High Dynamic Range image file", false);
        public static readonly MimeTypeInfo HIP = new MimeTypeInfo(new byte?[] { 0x48, 0x69, 0x50, 0x21 }, 0, "hip", "", "Houdini image file. Three-dimensional modeling and animation", false);
        public static readonly MimeTypeInfo HLP_1 = new MimeTypeInfo(new byte?[] { 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF }, 0, "hlp", "application/x-winhelp", "Windows help file_1", false);
        public static readonly MimeTypeInfo HLP_2 = new MimeTypeInfo(new byte?[] { 0x3F, 0x5F, 0x03, 0x00 }, 0, "hlp", "application/x-winhelp", "Windows help file_2", true);
        public static readonly MimeTypeInfo HLP_3 = new MimeTypeInfo(new byte?[] { 0x4C, 0x4E, 0x02, 0x00 }, 0, "hlp", "application/x-winhelp", "Windows help file_3", true);
        public static readonly MimeTypeInfo HQX = new MimeTypeInfo(new byte?[] { 0x28, 0x54, 0x68, 0x69, 0x73, 0x20, 0x66, 0x69 }, 0, "hqx", "application/mac-binhex40", "BinHex 4 Compressed Archive", false);
        public static readonly MimeTypeInfo ICO = new MimeTypeInfo(new byte?[] { 0x00, 0x00, 0x01, 0x00 }, 0, "ico", "image/x-icon", "Windows icon|printer spool file", true);
        public static readonly MimeTypeInfo IDX_1 = new MimeTypeInfo(new byte?[] { 0x41, 0x4F, 0x4C, 0x44, 0x42 }, 0, "idx", "", "AOL user configuration", true);
        public static readonly MimeTypeInfo IDX_2 = new MimeTypeInfo(new byte?[] { 0x41, 0x4F, 0x4C }, 0, "idx", "", "AOL config files", true);
        public static readonly MimeTypeInfo IDX_3 = new MimeTypeInfo(new byte?[] { 0x50, 0x00, 0x00, 0x00, 0x20, 0x00, 0x00, 0x00 }, 0, "idx", "", "Quicken QuickFinder Information File", false);
        public static readonly MimeTypeInfo IFO = new MimeTypeInfo(new byte?[] { 0x44, 0x56, 0x44 }, 0, "ifo", "", "DVD info file", true);
        public static readonly MimeTypeInfo IMG_1 = new MimeTypeInfo(new byte?[] { 0x50, 0x49, 0x43, 0x54, 0x00, 0x08 }, 0, "img", "image/x-gem", "ChromaGraph Graphics Card Bitmap", false);
        public static readonly MimeTypeInfo IMG_2 = new MimeTypeInfo(new byte?[] { 0xEB, 0x3C, 0x90, 0x2A }, 0, "img", "image/x-gem", "GEM Raster file", false);
        public static readonly MimeTypeInfo IMG_3 = new MimeTypeInfo(new byte?[] { 0x53, 0x43, 0x4D, 0x49 }, 0, "img", "image/x-gem", "Img Software Bitmap", false);
        public static readonly MimeTypeInfo IND_1 = new MimeTypeInfo(new byte?[] { 0x41, 0x4F, 0x4C, 0x49, 0x44, 0x58 }, 0, "ind", "application/x-latex", "AOL client preferences|settings file", false);
        public static readonly MimeTypeInfo IND_2 = new MimeTypeInfo(new byte?[] { 0x41, 0x4F, 0x4C }, 0, "ind", "application/x-latex", "AOL config files", true);
        public static readonly MimeTypeInfo INFO_1 = new MimeTypeInfo(new byte?[] { 0xE3, 0x10, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00 }, 0, "info", "application/x-texinfo", "Amiga icon", false);
        public static readonly MimeTypeInfo INFO_2 = new MimeTypeInfo(new byte?[] { 0x54, 0x68, 0x69, 0x73, 0x20, 0x69, 0x73, 0x20 }, 0, "info", "application/x-texinfo", "GNU Info Reader file", false);
        public static readonly MimeTypeInfo INFO_3 = new MimeTypeInfo(new byte?[] { 0x7A, 0x62, 0x65, 0x78 }, 0, "info", "application/x-texinfo", "ZoomBrowser Image Index", false);
        public static readonly MimeTypeInfo ISO = new MimeTypeInfo(new byte?[] { 0x43, 0x44, 0x30, 0x30, 0x31 }, 0, "iso", "application/octet-stream", "ISO-9660 CD Disc Image", false);
        public static readonly MimeTypeInfo IVR = new MimeTypeInfo(new byte?[] { 0x2E, 0x52, 0x45, 0x43 }, 0, "ivr", "application/vnd.rn-realplayer", "RealPlayer video file (V11+)", false);
        public static readonly MimeTypeInfo JAR_1 = new MimeTypeInfo(new byte?[] { 0x50, 0x4B, 0x03, 0x04 }, 0, "jar", "application/java-archive", "Java archive_1", true);
        public static readonly MimeTypeInfo JAR_2 = new MimeTypeInfo(new byte?[] { 0x5F, 0x27, 0xA8, 0x89 }, 0, "jar", "application/java-archive", "Jar archive", false);
        public static readonly MimeTypeInfo JAR_3 = new MimeTypeInfo(new byte?[] { 0x4A, 0x41, 0x52, 0x43, 0x53, 0x00 }, 0, "jar", "application/java-archive", "JARCS compressed archive", false);
        public static readonly MimeTypeInfo JAR_4 = new MimeTypeInfo(new byte?[] { 0x50, 0x4B, 0x03, 0x04, 0x14, 0x00, 0x08, 0x00 }, 0, "jar", "application/java-archive", "Java archive_2", false);
        public static readonly MimeTypeInfo JFIF = new MimeTypeInfo(new byte?[] { 0xFF, 0xD8, 0xFF, 0xE0 }, 0, "jfif", "image/pjpeg", "JFIF IMAGE FILE - jpeg", true);
        public static readonly MimeTypeInfo JG_1 = new MimeTypeInfo(new byte?[] { 0x4A, 0x47, 0x03, 0x0E }, 0, "jg", "application/octet-stream", "AOL ART file_1", false);
        public static readonly MimeTypeInfo JG_2 = new MimeTypeInfo(new byte?[] { 0x4A, 0x47, 0x04, 0x0E }, 0, "jg", "application/octet-stream", "AOL ART file_2", false);
        public static readonly MimeTypeInfo JNT = new MimeTypeInfo(new byte?[] { 0x4E, 0x42, 0x2A, 0x00 }, 0, "jnt", "", "MS Windows journal", true);
        public static readonly MimeTypeInfo JP2 = new MimeTypeInfo(new byte?[] { 0x00, 0x00, 0x00, 0x0C, 0x6A, 0x50, 0x20, 0x20 }, 0, "jp2", "image/jp2", "JPEG2000 image files", false);
        public static readonly MimeTypeInfo JPE = new MimeTypeInfo(new byte?[] { 0xFF, 0xD8, 0xFF, 0xE0 }, 0, "jpe", "image/jpeg", "JPEG IMAGE", true);
        public static readonly MimeTypeInfo JPEG_1 = new MimeTypeInfo(new byte?[] { 0xFF, 0xD8, 0xFF, 0xE0 }, 0, "jpeg", "image/jpeg", "JPEG IMAGE", true);
        public static readonly MimeTypeInfo JPEG_2 = new MimeTypeInfo(new byte?[] { 0xFF, 0xD8, 0xFF, 0xE2 }, 0, "jpeg", "image/jpeg", "CANNON EOS JPEG FILE", false);
        public static readonly MimeTypeInfo JPEG_3 = new MimeTypeInfo(new byte?[] { 0xFF, 0xD8, 0xFF, 0xE3 }, 0, "jpeg", "image/jpeg", "SAMSUNG D500 JPEG FILE", false);
        public static readonly MimeTypeInfo JPG_1 = new MimeTypeInfo(new byte?[] { 0xFF, 0xD8, 0xFF, 0xE0 }, 0, "jpg", "image/jpeg", "JPEG IMAGE", true);
        public static readonly MimeTypeInfo JPG_2 = new MimeTypeInfo(new byte?[] { 0xFF, 0xD8, 0xFF, 0xE1 }, 0, "jpg", "image/jpeg", "Digital camera JPG using Exchangeable Image File Format (EXIF)", false);
        public static readonly MimeTypeInfo JPG_3 = new MimeTypeInfo(new byte?[] { 0xFF, 0xD8, 0xFF, 0xE8 }, 0, "jpg", "image/jpeg", "Still Picture Interchange File Format (SPIFF)", false);
        public static readonly MimeTypeInfo JTP = new MimeTypeInfo(new byte?[] { 0x4E, 0x42, 0x2A, 0x00 }, 0, "jtp", "", "MS Windows journal", true);
        public static readonly MimeTypeInfo KGB = new MimeTypeInfo(new byte?[] { 0x4B, 0x47, 0x42, 0x5F, 0x61, 0x72, 0x63, 0x68 }, 0, "kgb", "application/x-kgb-compressed", "KGB archive", false);
        public static readonly MimeTypeInfo KOZ = new MimeTypeInfo(new byte?[] { 0x49, 0x44, 0x33, 0x03, 0x00, 0x00, 0x00 }, 0, "koz", "audio/vnd.audiokoz", "Sprint Music Store audio", false);
        public static readonly MimeTypeInfo KWD = new MimeTypeInfo(new byte?[] { 0x50, 0x4B, 0x03, 0x04 }, 0, "kwd", "application/vnd.kde.kword", "KWord document", true);
        public static readonly MimeTypeInfo LBK = new MimeTypeInfo(new byte?[] { 0xC8, 0x00, 0x79, 0x00 }, 0, "lbk", "", "Jeppesen FliteLog file", false);
        public static readonly MimeTypeInfo LGC = new MimeTypeInfo(new byte?[] { 0x7B, 0x0D, 0x0A, 0x6F, 0x20 }, 0, "lgc", "", "Windows application log", false);
        public static readonly MimeTypeInfo LHA = new MimeTypeInfo(new byte?[] { 0x2D, 0x6C, 0x68 }, 0, "lha", "application/x-compress", "Compressed archive", true);
        public static readonly MimeTypeInfo LIB = new MimeTypeInfo(new byte?[] { 0x21, 0x3C, 0x61, 0x72, 0x63, 0x68, 0x3E, 0x0A }, 0, "lib", "application/octet-stream", "Unix archiver (ar)|MS Program Library Common Object File Format (COFF)", false);
        public static readonly MimeTypeInfo LIT = new MimeTypeInfo(new byte?[] { 0x49, 0x54, 0x4F, 0x4C, 0x49, 0x54, 0x4C, 0x53 }, 0, "lit", "application/x-ms-reader", "MS Reader eBook", false);
        public static readonly MimeTypeInfo LNK = new MimeTypeInfo(new byte?[] { 0x4C, 0x00, 0x00, 0x00, 0x01, 0x14, 0x02, 0x00 }, 0, "lnk", "application/x-ms-shortcut", "Windows shortcut file", false);
        public static readonly MimeTypeInfo LOG = new MimeTypeInfo(new byte?[] { 0x2A, 0x2A, 0x2A, 0x20, 0x20, 0x49, 0x6E, 0x73 }, 0, "log", "text/x-log", "Symantec Wise Installer log", false);
        public static readonly MimeTypeInfo LWP = new MimeTypeInfo(new byte?[] { 0x57, 0x6F, 0x72, 0x64, 0x50, 0x72, 0x6F }, 0, "lwp", "application/vnd.lotus-wordpro", "Lotus WordPro file", false);
        public static readonly MimeTypeInfo LZH = new MimeTypeInfo(new byte?[] { 0x2D, 0x6C, 0x68 }, 0, "lzh", "application/octet-stream", "Compressed archive", true);
        public static readonly MimeTypeInfo M4A = new MimeTypeInfo(new byte?[] { 0x00, 0x00, 0x00, 0x20, 0x66, 0x74, 0x79, 0x70, 0x4D, 0x34, 0x41 }, 0, "m4a", "audio/m4a", "Apple audio and video files", false);
        public static readonly MimeTypeInfo MANIFEST = new MimeTypeInfo(new byte?[] { 0x3C, 0x3F, 0x78, 0x6D, 0x6C, 0x20, 0x76, 0x65, 0x72, 0x73, 0x69, 0x6F, 0x6E, 0x3D }, 0, "manifest", "application/x-ms-manifest", "Windows Visual Stylesheet", false);
        public static readonly MimeTypeInfo MAR_1 = new MimeTypeInfo(new byte?[] { 0x4D, 0x41, 0x72, 0x30, 0x00 }, 0, "mar", "", "MAr compressed archive", false);
        public static readonly MimeTypeInfo MAR_2 = new MimeTypeInfo(new byte?[] { 0x4D, 0x41, 0x52, 0x43 }, 0, "mar", "", "Microsoft|MSN MARC archive", false);
        public static readonly MimeTypeInfo MAR_3 = new MimeTypeInfo(new byte?[] { 0x4D, 0x41, 0x52, 0x31, 0x00 }, 0, "mar", "", "Mozilla archive", false);
        public static readonly MimeTypeInfo MDB = new MimeTypeInfo(new byte?[] { 0x00, 0x01, 0x00, 0x00, 0x53, 0x74, 0x61, 0x6E, 0x64, 0x61, 0x72, 0x64, 0x20, 0x4A, 0x65, 0x74, 0x20, 0x44, 0x42 }, 0, "mdb", "application/x-msaccess", "Microsoft Access", false);
        public static readonly MimeTypeInfo MDF = new MimeTypeInfo(new byte?[] { 0x01, 0x0F, 0x00, 0x00 }, 0, "mdf", "application/octet-stream", "SQL Data Base", false);
        public static readonly MimeTypeInfo MDI = new MimeTypeInfo(new byte?[] { 0x45, 0x50 }, 0, "mdi", "image/vnd.ms-modi", "MS Document Imaging file", false);
        public static readonly MimeTypeInfo MID = new MimeTypeInfo(new byte?[] { 0x4D, 0x54, 0x68, 0x64 }, 0, "mid", "audio/mid", "MIDI sound file", true);
        public static readonly MimeTypeInfo MIDI = new MimeTypeInfo(new byte?[] { 0x4D, 0x54, 0x68, 0x64 }, 0, "midi", "audio/mid", "MIDI sound file", true);
        public static readonly MimeTypeInfo MIF_1 = new MimeTypeInfo(new byte?[] { 0x3C, 0x4D, 0x61, 0x6B, 0x65, 0x72, 0x46, 0x69 }, 0, "mif", "application/vnd.mif", "Adobe FrameMaker", true);
        public static readonly MimeTypeInfo MIF_2 = new MimeTypeInfo(new byte?[] { 0x56, 0x65, 0x72, 0x73, 0x69, 0x6F, 0x6E, 0x20 }, 0, "mif", "application/vnd.mif", "MapInfo Interchange Format file", false);
        public static readonly MimeTypeInfo MKV = new MimeTypeInfo(new byte?[] { 0x1A, 0x45, 0xDF, 0xA3, 0x93, 0x42, 0x82, 0x88 }, 0, "mkv", "application/x-matroska", "Matroska stream file", false);
        public static readonly MimeTypeInfo MLS_1 = new MimeTypeInfo(new byte?[] { 0x4D, 0x49, 0x4C, 0x45, 0x53 }, 0, "mls", "", "Milestones project management file", false);
        public static readonly MimeTypeInfo MLS_2 = new MimeTypeInfo(new byte?[] { 0x4D, 0x56, 0x32, 0x31, 0x34 }, 0, "mls", "", "Milestones project management file_1", false);
        public static readonly MimeTypeInfo MLS_3 = new MimeTypeInfo(new byte?[] { 0x4D, 0x56, 0x32, 0x43 }, 0, "mls", "", "Milestones project management file_2", false);
        public static readonly MimeTypeInfo MLS_4 = new MimeTypeInfo(new byte?[] { 0x4D, 0x4C, 0x53, 0x57 }, 0, "mls", "", "Skype localization data file", false);
        public static readonly MimeTypeInfo MMF = new MimeTypeInfo(new byte?[] { 0x4D, 0x4D, 0x4D, 0x44, 0x00, 0x00 }, 0, "mmf", "application/x-smaf", "Yamaha Synthetic music Mobile Application Format", false);
        public static readonly MimeTypeInfo MNY = new MimeTypeInfo(new byte?[] { 0x00, 0x01, 0x00, 0x00, 0x4D, 0x53, 0x49, 0x53, 0x41, 0x4D, 0x20, 0x44, 0x61, 0x74, 0x61, 0x62, 0x61, 0x73, 0x65 }, 0, "mny", "application/x-msmoney", "Microsoft Money file", false);
        public static readonly MimeTypeInfo MOF = new MimeTypeInfo(new byte?[] { 0xFF, 0xFE, 0x23, 0x00, 0x6C, 0x00, 0x69, 0x00 }, 0, "mof", "", "MSinfo file", false);
        public static readonly MimeTypeInfo MOV_1 = new MimeTypeInfo(new byte?[] { 0x6D, 0x6F, 0x6F, 0x76 }, 4, "mov", "video/quicktime", "QuickTime movie_1", false);
        public static readonly MimeTypeInfo MOV_2 = new MimeTypeInfo(new byte?[] { 0x66, 0x72, 0x65, 0x65 }, 4, "mov", "video/quicktime", "QuickTime movie_2", false);
        public static readonly MimeTypeInfo MOV_3 = new MimeTypeInfo(new byte?[] { 0x6D, 0x64, 0x61, 0x74 }, 4, "mov", "video/quicktime", "QuickTime movie_3", false);
        public static readonly MimeTypeInfo MOV_4 = new MimeTypeInfo(new byte?[] { 0x77, 0x69, 0x64, 0x65 }, 4, "mov", "video/quicktime", "QuickTime movie_4", false);
        public static readonly MimeTypeInfo MOV_5 = new MimeTypeInfo(new byte?[] { 0x70, 0x6E, 0x6F, 0x74 }, 4, "mov", "video/quicktime", "QuickTime movie_5", false);
        public static readonly MimeTypeInfo MOV_6 = new MimeTypeInfo(new byte?[] { 0x73, 0x6B, 0x69, 0x70 }, 4, "mov", "video/quicktime", "QuickTime movie_6", false);
        public static readonly MimeTypeInfo MP = new MimeTypeInfo(new byte?[] { 0x0C, 0xED }, 0, "mp", "", "Monochrome Picture TIFF bitmap", false);
        public static readonly MimeTypeInfo MP3 = new MimeTypeInfo(new byte?[] { 0x49, 0x44, 0x33 }, 0, "mp3", "audio/mpeg", "MP3 audio file", false);
        public static readonly MimeTypeInfo MPG_1 = new MimeTypeInfo(new byte?[] { 0x00, 0x00, 0x01, 0xBA }, 0, "mpg", "video/mpeg", "DVD video file", true);
        public static readonly MimeTypeInfo MPG_2 = new MimeTypeInfo(new byte?[] { 0x00, 0x00, 0x01, 0xB3 }, 0, "mpg", "video/mpeg", "MPEG video file", false);
        public static readonly MimeTypeInfo MSC_1 = new MimeTypeInfo(new byte?[] { 0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, 0, "msc", "", "Microsoft Common Console Document", true);
        public static readonly MimeTypeInfo MSC_2 = new MimeTypeInfo(new byte?[] { 0x3C, 0x3F, 0x78, 0x6D, 0x6C, 0x20, 0x76, 0x65, 0x72, 0x73, 0x69, 0x6F, 0x6E, 0x3D, 0x22, 0x31, 0x2E, 0x30, 0x22, 0x3F, 0x3E, 0x0D, 0x0A, 0x3C, 0x4D, 0x4D, 0x43, 0x5F, 0x4, 0x6F, 0x6E, 0x73, 0x6F, 0x6C, 0x65, 0x46, 0x69, 0x6C, 0x65, 0x20, 0x43, 0x6F, 0x6E, 0x73, 0x6F, 0x6C, 0x65, 0x56, 0x65, 0x72 }, 0, "msc", "", "MMC Snap-in Control file", false);
        public static readonly MimeTypeInfo MSI_1 = new MimeTypeInfo(new byte?[] { 0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, 0, "msi", "application/octet-stream", "Microsoft Installer package", true);
        public static readonly MimeTypeInfo MSI_2 = new MimeTypeInfo(new byte?[] { 0x23, 0x20 }, 0, "msi", "application/octet-stream", "Cerius2 file", false);
        public static readonly MimeTypeInfo MSV = new MimeTypeInfo(new byte?[] { 0x4D, 0x53, 0x5F, 0x56, 0x4F, 0x49, 0x43, 0x45 }, 0, "msv", "audio/x-msv", "Sony Compressed Voice File", true);
        public static readonly MimeTypeInfo MTW = new MimeTypeInfo(new byte?[] { 0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, 0, "mtw", "", "Minitab data file", true);
        public static readonly MimeTypeInfo NRI = new MimeTypeInfo(new byte?[] { 0x0E, 0x4E, 0x65, 0x72, 0x6F, 0x49, 0x53, 0x4F }, 0, "nri", "application/octet-stream", "Nero CD compilation", false);
        public static readonly MimeTypeInfo NSF_1 = new MimeTypeInfo(new byte?[] { 0x1A, 0x00, 0x00, 0x04, 0x00, 0x00 }, 0, "nsf", "application/vnd.lotus-notes", "Lotus Notes database", false);
        public static readonly MimeTypeInfo NSF_2 = new MimeTypeInfo(new byte?[] { 0x4E, 0x45, 0x53, 0x4D, 0x1A, 0x01 }, 0, "nsf", "application/vnd.lotus-notes", "NES Sound file", false);
        public static readonly MimeTypeInfo NTF_1 = new MimeTypeInfo(new byte?[] { 0x1A, 0x00, 0x00 }, 0, "ntf", "", "Lotus Notes database template", false);
        public static readonly MimeTypeInfo NTF_2 = new MimeTypeInfo(new byte?[] { 0x4E, 0x49, 0x54, 0x46, 0x30 }, 0, "ntf", "", "National Imagery Transmission Format file", false);
        public static readonly MimeTypeInfo NTF_3 = new MimeTypeInfo(new byte?[] { 0x30, 0x31, 0x4F, 0x5, 0x44, 0x4E, 0x41, 0x4E }, 0, "ntf", "", "National Transfer Format Map", false);
        public static readonly MimeTypeInfo NVRAM = new MimeTypeInfo(new byte?[] { 0x4D, 0x52, 0x56, 0x4E }, 0, "nvram", "", "VMware BIOS state file", false);
        public static readonly MimeTypeInfo OBJ_1 = new MimeTypeInfo(new byte?[] { 0x4C, 0x01 }, 0, "obj", "application/octet-stream", "MS COFF relocatable object code", false);
        public static readonly MimeTypeInfo OBJ_2 = new MimeTypeInfo(new byte?[] { 0x80 }, 0, "obj", "application/octet-stream", "Relocatable object code", false);
        public static readonly MimeTypeInfo OCX = new MimeTypeInfo(new byte?[] { 0x4D, 0x5A }, 0, "ocx", "application/octet-stream", "ActiveX|OLE Custom Control", true);
        public static readonly MimeTypeInfo ODP = new MimeTypeInfo(new byte?[] { 0x50, 0x4B, 0x03, 0x04 }, 0, "odp", "application/vnd.oasis.opendocument.presentation", "OpenDocument template", true);
        public static readonly MimeTypeInfo ODT = new MimeTypeInfo(new byte?[] { 0x50, 0x4B, 0x03, 0x04 }, 0, "odt", "application/vnd.oasis.opendocument.text", "OpenDocument template", true);
        public static readonly MimeTypeInfo OGA = new MimeTypeInfo(new byte?[] { 0x4F, 0x67, 0x67, 0x53, 0x00, 0x02, 0x00, 0x00 }, 0, "oga", "audio/ogg", "Ogg Vorbis Codec compressed file", true);
        public static readonly MimeTypeInfo OGG = new MimeTypeInfo(new byte?[] { 0x4F, 0x67, 0x67, 0x53, 0x00, 0x02, 0x00, 0x00 }, 0, "ogg", "audio/ogg", "Ogg Vorbis Codec compressed file", true);
        public static readonly MimeTypeInfo OGV = new MimeTypeInfo(new byte?[] { 0x4F, 0x67, 0x67, 0x53, 0x00, 0x02, 0x00, 0x00 }, 0, "ogv", "video/ogg", "Ogg Vorbis Codec compressed file", true);
        public static readonly MimeTypeInfo OLB = new MimeTypeInfo(new byte?[] { 0x4D, 0x5A }, 0, "olb", "", "OLE object library", true);
        public static readonly MimeTypeInfo ONE = new MimeTypeInfo(new byte?[] { 0xE4, 0x52, 0x5C, 0x7B, 0x8C, 0xD8, 0xA7, 0x4D }, 0, "one", "application/onenote", "MS OneNote note", false);
        public static readonly MimeTypeInfo OPT_1 = new MimeTypeInfo(new byte?[] { 0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, 0, "opt", "", "Developer Studio File Options file", true);
        public static readonly MimeTypeInfo OPT_2 = new MimeTypeInfo(new byte?[] { 0xFD, 0xFF, 0xFF, 0xFF, 0x20 }, 0, "opt", "", "Developer Studio subheader", false);
        public static readonly MimeTypeInfo ORG = new MimeTypeInfo(new byte?[] { 0x41, 0x4F, 0x4C, 0x56, 0x4D, 0x31, 0x30, 0x30 }, 0, "org", "application/vnd.lotus-organizer", "AOL personal file cabinet", true);
        public static readonly MimeTypeInfo OTT = new MimeTypeInfo(new byte?[] { 0x50, 0x4B, 0x03, 0x04 }, 0, "ott", "application/vnd.oasis.opendocument.text-template", "OpenDocument template", true);
        public static readonly MimeTypeInfo P10 = new MimeTypeInfo(new byte?[] { 0x64, 0x00, 0x00, 0x00 }, 0, "p10", "application/pkcs10", "Intel PROset|Wireless Profile", false);
        public static readonly MimeTypeInfo PAK_1 = new MimeTypeInfo(new byte?[] { 0x1A, 0x0B }, 0, "pak", "", "PAK Compressed archive file", false);
        public static readonly MimeTypeInfo PAK_2 = new MimeTypeInfo(new byte?[] { 0x50, 0x41, 0x43, 0x4B }, 0, "pak", "", "Quake archive file", false);
        public static readonly MimeTypeInfo PAT = new MimeTypeInfo(new byte?[] { 0x47, 0x50, 0x41, 0x54 }, 0, "pat", "", "GIMP pattern file", false);
        public static readonly MimeTypeInfo PAX = new MimeTypeInfo(new byte?[] { 0x50, 0x41, 0x58 }, 0, "pax", "application/octet-stream", "PAX password protected bitmap", false);
        public static readonly MimeTypeInfo PCH = new MimeTypeInfo(new byte?[] { 0x56, 0x43, 0x50, 0x43, 0x48, 0x30 }, 0, "pch", "", "Visual C PreCompiled header", false);
        public static readonly MimeTypeInfo PCX_1 = new MimeTypeInfo(new byte?[] { 0x0A, 0x02, 0x01, 0x01 }, 0, "pcx", "image/pict", "ZSOFT Paintbrush file_1", false);
        public static readonly MimeTypeInfo PCX_2 = new MimeTypeInfo(new byte?[] { 0x0A, 0x03, 0x01, 0x01 }, 0, "pcx", "image/pict", "ZSOFT Paintbrush file_2", false);
        public static readonly MimeTypeInfo PCX_3 = new MimeTypeInfo(new byte?[] { 0x0A, 0x05, 0x01, 0x01 }, 0, "pcx", "image/pict", "ZSOFT Paintbrush file_3", false);
        public static readonly MimeTypeInfo PDB_1 = new MimeTypeInfo(new byte?[] { 0xAC, 0xED, 0x00, 0x05, 0x73, 0x72, 0x00, 0x12 }, 0, "pdb", "application/vnd.palm", "BGBlitz position database file", false);
        public static readonly MimeTypeInfo PDB_2 = new MimeTypeInfo(new byte?[] { 0x4D, 0x2D, 0x57, 0x20, 0x50, 0x6F, 0x63, 0x6B }, 0, "pdb", "application/vnd.palm", "Merriam-Webster Pocket Dictionary", false);
        public static readonly MimeTypeInfo PDB_3 = new MimeTypeInfo(new byte?[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x43, 0x2F, 0x43, 0x2B, 0x2B, 0x20 }, 0, "pdb", "application/vnd.palm", "MS C++ debugging symbols file", false);
        public static readonly MimeTypeInfo PDB_4 = new MimeTypeInfo(new byte?[] { 0x73, 0x6D, 0x5F }, 0, "pdb", "application/vnd.palm", "PalmOS SuperMemo", false);
        public static readonly MimeTypeInfo PDB_5 = new MimeTypeInfo(new byte?[] { 0x73, 0x7A, 0x65, 0x7A }, 0, "pdb", "application/vnd.palm", "PowerBASIC Debugger Symbols", false);
        public static readonly MimeTypeInfo PDF = new MimeTypeInfo(new byte?[] { 0x25, 0x50, 0x44, 0x46 }, 0, "pdf", "application/pdf", "PDF file", true);
        public static readonly MimeTypeInfo PF = new MimeTypeInfo(new byte?[] { 0x11, 0x00, 0x00, 0x00, 0x53, 0x43, 0x43, 0x41 }, 0, "pf", "application/x-pf", "Windows prefetch file", false);
        public static readonly MimeTypeInfo PFC_1 = new MimeTypeInfo(new byte?[] { 0x41, 0x4F, 0x4C }, 0, "pfc", "application/octet-stream", "AOL config files", true);
        public static readonly MimeTypeInfo PFC_2 = new MimeTypeInfo(new byte?[] { 0x41, 0x4F, 0x4C, 0x56, 0x4D, 0x31, 0x30, 0x30 }, 0, "pfc", "application/octet-stream", "AOL personal file cabinet", true);
        public static readonly MimeTypeInfo PGD = new MimeTypeInfo(new byte?[] { 0x50, 0x47, 0x50, 0x64, 0x4D, 0x41, 0x49, 0x4E }, 0, "pgd", "", "PGP disk image", false);
        public static readonly MimeTypeInfo PGM = new MimeTypeInfo(new byte?[] { 0x50, 0x35, 0x0A }, 0, "pgm", "image/x-portable-graymap", "Portable Graymap Graphic", false);
        public static readonly MimeTypeInfo PIF = new MimeTypeInfo(new byte?[] { 0x4D, 0x5A }, 0, "pif", "", "Windows|DOS executable file", true);
        public static readonly MimeTypeInfo PKR = new MimeTypeInfo(new byte?[] { 0x99, 0x01 }, 0, "pkr", "application/pgp-keys", "PGP public keyring", false);
        public static readonly MimeTypeInfo PNG = new MimeTypeInfo(new byte?[] { 0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A }, 0, "png", "image/png", "PNG image", false);
        public static readonly MimeTypeInfo PPS = new MimeTypeInfo(new byte?[] { 0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, 0, "pps", "application/vnd.ms-powerpoint", "Microsoft Office document", true);
        public static readonly MimeTypeInfo PPT_1 = new MimeTypeInfo(new byte?[] { 0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, 0, "ppt", "application/vnd.ms-powerpoint", "Microsoft Office document", true);
        public static readonly MimeTypeInfo PPT_2 = new MimeTypeInfo(new byte?[] { 0x00, 0x6E, 0x1E, 0xF0 }, 512, "ppt", "application/vnd.ms-powerpoint", "PowerPoint presentation subheader_1", false);
        public static readonly MimeTypeInfo PPT_3 = new MimeTypeInfo(new byte?[] { 0x0F, 0x00, 0xE8, 0x03 }, 512, "ppt", "application/vnd.ms-powerpoint", "PowerPoint presentation subheader_2", false);
        public static readonly MimeTypeInfo PPT_4 = new MimeTypeInfo(new byte?[] { 0xA0, 0x46, 0x1D, 0xF0 }, 512, "ppt", "application/vnd.ms-powerpoint", "PowerPoint presentation subheader_3", false);
        public static readonly MimeTypeInfo PPT_5 = new MimeTypeInfo(new byte?[] { 0xFD, 0xFF, 0xFF, 0xFF, 0x0E, 0x00, 0x00, 0x00 }, 512, "ppt", "application/vnd.ms-powerpoint", "PowerPoint presentation subheader_4", false);
        public static readonly MimeTypeInfo PPT_6 = new MimeTypeInfo(new byte?[] { 0xFD, 0xFF, 0xFF, 0xFF, 0x1C, 0x00, 0x00, 0x00 }, 512, "ppt", "application/vnd.ms-powerpoint", "PowerPoint presentation subheader_5", false);
        public static readonly MimeTypeInfo PPT_7 = new MimeTypeInfo(new byte?[] { 0xFD, 0xFF, 0xFF, 0xFF, 0x43, 0x00, 0x00, 0x00 }, 512, "ppt", "application/vnd.ms-powerpoint", "PowerPoint presentation subheader_6", false);
        public static readonly MimeTypeInfo PPTX_1 = new MimeTypeInfo(new byte?[] { 0x50, 0x4B, 0x03, 0x04 }, 0, "pptx", "application/vnd.openxmlformats-officedocument.presentationml.presentation", "MS Office Open XML Format Document", true);
        public static readonly MimeTypeInfo PPTX_2 = new MimeTypeInfo(new byte?[] { 0x50, 0x4B, 0x03, 0x04, 0x14, 0x00, 0x06, 0x00 }, 0, "pptx", "application/vnd.openxmlformats-officedocument.presentationml.presentation", "MS Office 2007 documents", true);
        public static readonly MimeTypeInfo PPZ = new MimeTypeInfo(new byte?[] { 0x4D, 0x53, 0x43, 0x46 }, 0, "ppz", "application/vnd.ms-powerpoint", "Powerpoint Packaged Presentation", true);
        public static readonly MimeTypeInfo PRC_1 = new MimeTypeInfo(new byte?[] { 0x42, 0x4F, 0x4F, 0x4B, 0x4D, 0x4F, 0x42, 0x49 }, 0, "prc", "application/x-mobipocket-ebook", "Palmpilot resource file", false);
        public static readonly MimeTypeInfo PRC_2 = new MimeTypeInfo(new byte?[] { 0x74, 0x42, 0x4D, 0x50, 0x4B, 0x6E, 0x57, 0x72 }, 60, "prc", "application/x-mobipocket-ebook", "PathWay Map file", false);
        public static readonly MimeTypeInfo PSD = new MimeTypeInfo(new byte?[] { 0x38, 0x42, 0x50, 0x53 }, 0, "psd", "image/vnd.adobe.photoshop", "Photoshop image", false);
        public static readonly MimeTypeInfo PSP = new MimeTypeInfo(new byte?[] { 0x7E, 0x42, 0x4B, 0x00 }, 0, "psp", "application/octet-stream", "Corel Paint Shop Pro image", false);
        public static readonly MimeTypeInfo PUB = new MimeTypeInfo(new byte?[] { 0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, 0, "pub", "application/x-mspublisher", "MS Publisher file", true);
        public static readonly MimeTypeInfo PWI = new MimeTypeInfo(new byte?[] { 0x7B, 0x5C, 0x70, 0x77, 0x69 }, 0, "pwi", "", "MS WinMobile personal note", false);
        public static readonly MimeTypeInfo PWL_1 = new MimeTypeInfo(new byte?[] { 0xB0, 0x4D, 0x46, 0x43 }, 0, "pwl", "", "Win95 password file", false);
        public static readonly MimeTypeInfo PWL_2 = new MimeTypeInfo(new byte?[] { 0xE3, 0x82, 0x85, 0x96 }, 0, "pwl", "", "Win98 password file", false);
        public static readonly MimeTypeInfo QBB = new MimeTypeInfo(new byte?[] { 0x45, 0x86, 0x00, 0x00, 0x06, 0x00 }, 0, "qbb", "", "QuickBooks backup", false);
        public static readonly MimeTypeInfo QCP = new MimeTypeInfo(new byte?[] { 0x52, 0x49, 0x46, 0x46 }, 0, "qcp", "audio/vnd.qcelp", "Resource Interchange File Format", true);
        public static readonly MimeTypeInfo QDF = new MimeTypeInfo(new byte?[] { 0xAC, 0x9E, 0xBD, 0x8F, 0x00, 0x00 }, 0, "qdf", "", "QDF Quicken data", false);
        public static readonly MimeTypeInfo QEL = new MimeTypeInfo(new byte?[] { 0x51, 0x45, 0x4C, 0x20 }, 0, "qel", "", "QDL Quicken data", false);
        public static readonly MimeTypeInfo QEMU = new MimeTypeInfo(new byte?[] { 0x51, 0x46, 0x49 }, 0, "qemu", "", "Qcow Disk Image", false);
        public static readonly MimeTypeInfo QPH = new MimeTypeInfo(new byte?[] { 0x03, 0x00, 0x00, 0x00 }, 0, "qph", "", "Quicken price history", false);
        public static readonly MimeTypeInfo QSD = new MimeTypeInfo(new byte?[] { 0x51, 0x57, 0x20, 0x56, 0x65, 0x72, 0x2E, 0x20 }, 0, "qsd", "", "ABD | QSD Quicken data file", true);
        public static readonly MimeTypeInfo QTS = new MimeTypeInfo(new byte?[] { 0x4D, 0x5A }, 0, "qts", "", "Windows|DOS executable file", true);
        public static readonly MimeTypeInfo QXD_1 = new MimeTypeInfo(new byte?[] { 0x00, 0x00, 0x49, 0x49, 0x58, 0x50, 0x52 }, 0, "qxd", "application/vnd.quark.quarkxpress", "Quark Express (Intel)", false);
        public static readonly MimeTypeInfo QXD_2 = new MimeTypeInfo(new byte?[] { 0x00, 0x00, 0x4D, 0x4D, 0x58, 0x50, 0x52 }, 0, "qxd", "application/vnd.quark.quarkxpress", "Quark Express (Motorola)", false);
        public static readonly MimeTypeInfo RA_1 = new MimeTypeInfo(new byte?[] { 0x2E, 0x52, 0x4D, 0x46, 0x00, 0x00, 0x00, 0x12 }, 0, "ra", "audio/x-pn-realaudio", "RealAudio file", false);
        public static readonly MimeTypeInfo RA_2 = new MimeTypeInfo(new byte?[] { 0x2E, 0x72, 0x61, 0xFD, 0x00 }, 0, "ra", "audio/x-pn-realaudio", "RealAudio streaming media", false);
        public static readonly MimeTypeInfo RAM = new MimeTypeInfo(new byte?[] { 0x72, 0x74, 0x73, 0x70, 0x3A, 0x2F, 0x2F }, 0, "ram", "audio/x-pn-realaudio", "RealMedia metafile", false);
        public static readonly MimeTypeInfo RAR = new MimeTypeInfo(new byte?[] { 0x52, 0x61, 0x72, 0x21, 0x1A, 0x07, 0x00 }, 0, "rar", "application/x-rar-compressed", "WinRAR compressed archive", false);
        public static readonly MimeTypeInfo REG_1 = new MimeTypeInfo(new byte?[] { 0xFF, 0xFE }, 0, "reg", "text/plain", "Windows Registry file", false);
        public static readonly MimeTypeInfo REG_2 = new MimeTypeInfo(new byte?[] { 0x52, 0x45, 0x47, 0x45, 0x44, 0x49, 0x54 }, 0, "reg", "text/plain", "WinNT Registry|Registry Undo files", true);
        public static readonly MimeTypeInfo RGB = new MimeTypeInfo(new byte?[] { 0x01, 0xDA, 0x01, 0x01, 0x00, 0x03 }, 0, "rgb", "image/x-rgb", "Silicon Graphics RGB Bitmap", false);
        public static readonly MimeTypeInfo RM = new MimeTypeInfo(new byte?[] { 0x2E, 0x52, 0x4D, 0x46 }, 0, "rm", "application/vnd.rn-realmedia", "RealMedia streaming media", true);
        public static readonly MimeTypeInfo RMI = new MimeTypeInfo(new byte?[] { 0x52, 0x49, 0x46, 0x46 }, 0, "rmi", "audio/mid", "Resource Interchange File Format", true);
        public static readonly MimeTypeInfo RMVB = new MimeTypeInfo(new byte?[] { 0x2E, 0x52, 0x4D, 0x46 }, 0, "rmvb", "application/vnd.rn-realmedia-vbr", "RealMedia streaming media", true);
        public static readonly MimeTypeInfo RPM = new MimeTypeInfo(new byte?[] { 0xED, 0xAB, 0xEE, 0xDB }, 0, "rpm", "audio/x-pn-realaudio-plugin", "RedHat Package Manager", false);
        public static readonly MimeTypeInfo RTD = new MimeTypeInfo(new byte?[] { 0x43, 0x23, 0x2B, 0x44, 0xA4, 0x43, 0x4D, 0xA5 }, 0, "rtd", "", "RagTime document", false);
        public static readonly MimeTypeInfo RTF = new MimeTypeInfo(new byte?[] { 0x7B, 0x5C, 0x72, 0x74, 0x66, 0x31 }, 0, "rtf", "application/rtf", "RTF file", false);
        public static readonly MimeTypeInfo RVT = new MimeTypeInfo(new byte?[] { 0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, 0, "rvt", "application/octet-stream", "Revit Project file", true);
        public static readonly MimeTypeInfo SAM_1 = new MimeTypeInfo(new byte?[] { 0x5B, 0x56, 0x45, 0x52, 0x5D }, 0, "sam", "application/x-amipro", "Lotus AMI Pro document_1", false);
        public static readonly MimeTypeInfo SAM_2 = new MimeTypeInfo(new byte?[] { 0x5B, 0x76, 0x65, 0x72, 0x5D }, 0, "sam", "application/x-amipro", "Lotus AMI Pro document_2", false);
        public static readonly MimeTypeInfo SAV = new MimeTypeInfo(new byte?[] { 0x24, 0x46, 0x4C, 0x32, 0x40, 0x28, 0x23, 0x29 }, 0, "sav", "", "SPSS Data file", false);
        public static readonly MimeTypeInfo SCR = new MimeTypeInfo(new byte?[] { 0x4D, 0x5A }, 0, "scr", "text/plain", "Screen saver", true);
        public static readonly MimeTypeInfo SH3 = new MimeTypeInfo(new byte?[] { 0x48, 0x48, 0x47, 0x42, 0x31 }, 0, "sh3", "", "Harvard Graphics presentation file", false);
        public static readonly MimeTypeInfo SHD_1 = new MimeTypeInfo(new byte?[] { 0x68, 0x49, 0x00, 0x00 }, 0, "shd", "", "Win Server 2003 printer spool file", false);
        public static readonly MimeTypeInfo SHD_2 = new MimeTypeInfo(new byte?[] { 0x4B, 0x49, 0x00, 0x00 }, 0, "shd", "", "Win9x printer spool file", false);
        public static readonly MimeTypeInfo SHD_3 = new MimeTypeInfo(new byte?[] { 0x67, 0x49, 0x00, 0x00 }, 0, "shd", "", "Win2000|XP printer spool file", false);
        public static readonly MimeTypeInfo SHD_4 = new MimeTypeInfo(new byte?[] { 0x66, 0x49, 0x00, 0x00 }, 0, "shd", "", "WinNT printer spool file", false);
        public static readonly MimeTypeInfo SHW = new MimeTypeInfo(new byte?[] { 0x53, 0x48, 0x4F, 0x57 }, 0, "shw", "application/vnd.corel-presentations", "Harvard Graphics presentation", false);
        public static readonly MimeTypeInfo SIT_1 = new MimeTypeInfo(new byte?[] { 0x53, 0x49, 0x54, 0x21, 0x00 }, 0, "sit", "application/x-stuffit", "StuffIt archive", false);
        public static readonly MimeTypeInfo SIT_2 = new MimeTypeInfo(new byte?[] { 0x53, 0x74, 0x75, 0x66, 0x66, 0x49, 0x74, 0x20 }, 0, "sit", "application/x-stuffit", "StuffIt compressed archive", false);
        public static readonly MimeTypeInfo SKF = new MimeTypeInfo(new byte?[] { 0x07, 0x53, 0x4B, 0x46 }, 0, "skf", "", "SkinCrafter skin", false);
        public static readonly MimeTypeInfo SKR_1 = new MimeTypeInfo(new byte?[] { 0x95, 0x00 }, 0, "skr", "application/pgp-keys", "PGP secret keyring_1", false);
        public static readonly MimeTypeInfo SKR_2 = new MimeTypeInfo(new byte?[] { 0x95, 0x01 }, 0, "skr", "application/pgp-keys", "PGP secret keyring_2", false);
        public static readonly MimeTypeInfo SLE_1 = new MimeTypeInfo(new byte?[] { 0x41, 0x43, 0x76 }, 0, "sle", "", "Steganos virtual secure drive", false);
        public static readonly MimeTypeInfo SLE_2 = new MimeTypeInfo(new byte?[] { 0x3A, 0x56, 0x45, 0x52, 0x53, 0x49, 0x4F, 0x4E }, 0, "sle", "", "Surfplan kite project file", false);
        public static readonly MimeTypeInfo SLN = new MimeTypeInfo(new byte?[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x56, 0x69, 0x73, 0x75, 0x61, 0x6C }, 0, "sln", "text/plain", "Visual Studio .NET file", false);
        public static readonly MimeTypeInfo SNM = new MimeTypeInfo(new byte?[] { 0x00, 0x1E, 0x84, 0x90, 0x00, 0x00, 0x00, 0x00 }, 0, "snm", "", "Netscape Communicator (v4) mail folder", false);
        public static readonly MimeTypeInfo SNP = new MimeTypeInfo(new byte?[] { 0x4D, 0x53, 0x43, 0x46 }, 0, "snp", "application/vnd.ms-access", "MS Access Snapshot Viewer file", true);
        public static readonly MimeTypeInfo SOU = new MimeTypeInfo(new byte?[] { 0xD0, 0xCF, 0x1, 0xE0, 0xA, 0xB1, 0x1A, 0xE1 }, 0, "sou", "", "Visual Studio Solution User Options file", false);
        public static readonly MimeTypeInfo SPL = new MimeTypeInfo(new byte?[] { 0x00, 0x00, 0x01, 0x00 }, 0, "spl", "application/futuresplash", "Windows icon|printer spool file", true);
        public static readonly MimeTypeInfo SPO = new MimeTypeInfo(new byte?[] { 0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, 0, "spo", "", "SPSS output file", true);
        public static readonly MimeTypeInfo SUD = new MimeTypeInfo(new byte?[] { 0x52, 0x45, 0x47, 0x45, 0x44, 0x49, 0x54 }, 0, "sud", "", "WinNT Registry|Registry Undo files", true);
        public static readonly MimeTypeInfo SUO = new MimeTypeInfo(new byte?[] { 0xFD, 0xFF, 0xFF, 0xFF, 0x04 }, 512, "suo", "", "Visual Studio Solution subheader", false);
        public static readonly MimeTypeInfo SWF_1 = new MimeTypeInfo(new byte?[] { 0x43, 0x57, 0x53 }, 0, "swf", "application/x-shockwave-flash", "Shockwave Flash file", false);
        public static readonly MimeTypeInfo SWF_2 = new MimeTypeInfo(new byte?[] { 0x46, 0x57, 0x53 }, 0, "swf", "application/x-shockwave-flash", "Shockwave Flash player", false);
        public static readonly MimeTypeInfo SXC = new MimeTypeInfo(new byte?[] { 0x50, 0x4B, 0x03, 0x04 }, 0, "sxc", "application/vnd.sun.xml.calc", "StarOffice spreadsheet", true);
        public static readonly MimeTypeInfo SXD = new MimeTypeInfo(new byte?[] { 0x50, 0x4B, 0x03, 0x04 }, 0, "sxd", "application/vnd.sun.xml.draw", "OpenOffice documents", true);
        public static readonly MimeTypeInfo SXI = new MimeTypeInfo(new byte?[] { 0x50, 0x4B, 0x03, 0x04 }, 0, "sxi", "application/vnd.sun.xml.impress", "OpenOffice documents", true);
        public static readonly MimeTypeInfo SXW = new MimeTypeInfo(new byte?[] { 0x50, 0x4B, 0x03, 0x04 }, 0, "sxw", "application/vnd.sun.xml.writer", "OpenOffice documents", true);
        public static readonly MimeTypeInfo SYS_1 = new MimeTypeInfo(new byte?[] { 0x4D, 0x5A }, 0, "sys", "text/plain", "Windows|DOS executable file", true);
        public static readonly MimeTypeInfo SYS_2 = new MimeTypeInfo(new byte?[] { 0xFF, 0xFF, 0xFF, 0xFF }, 0, "sys", "text/plain", "DOS system driver", false);
        public static readonly MimeTypeInfo SYS_3 = new MimeTypeInfo(new byte?[] { 0xFF, 0x4B, 0x45, 0x59, 0x42, 0x20, 0x20, 0x20 }, 0, "sys", "text/plain", "Keyboard driver file", false);
        public static readonly MimeTypeInfo SYS_4 = new MimeTypeInfo(new byte?[] { 0xE8 }, 0, "sys", "text/plain", "Windows executable file_1", true);
        public static readonly MimeTypeInfo SYS_5 = new MimeTypeInfo(new byte?[] { 0xE9 }, 0, "sys", "text/plain", "Windows executable file_2", true);
        public static readonly MimeTypeInfo SYS_6 = new MimeTypeInfo(new byte?[] { 0xEB }, 0, "sys", "text/plain", "Windows executable file_3", true);
        public static readonly MimeTypeInfo SYS_7 = new MimeTypeInfo(new byte?[] { 0xFF }, 0, "sys", "text/plain", "Windows executable", false);
        public static readonly MimeTypeInfo SYW = new MimeTypeInfo(new byte?[] { 0x41, 0x4D, 0x59, 0x4F }, 0, "syw", "", "Harvard Graphics symbol graphic", false);
        public static readonly MimeTypeInfo TAR = new MimeTypeInfo(new byte?[] { 0x75, 0x73, 0x74, 0x61, 0x72 }, 0, "tar", "application/x-tar", "Tape Archive", false);
        public static readonly MimeTypeInfo TARBZ2 = new MimeTypeInfo(new byte?[] { 0x42, 0x5A, 0x68 }, 0, "tar.bz2", "application/x-bzip2", "bzip2 compressed archive", true);
        public static readonly MimeTypeInfo TARZ_1 = new MimeTypeInfo(new byte?[] { 0x1F, 0x9D, 0x90 }, 0, "tar.z", "application/x-compressed-tar", "Compressed tape archive_1", false);
        public static readonly MimeTypeInfo TARZ_2 = new MimeTypeInfo(new byte?[] { 0x1F, 0xA0 }, 0, "tar.z", "application/x-compressed-tar", "Compressed tape archive_2", false);
        public static readonly MimeTypeInfo TB2 = new MimeTypeInfo(new byte?[] { 0x42, 0x5A, 0x68 }, 0, "tb2", "", "bzip2 compressed archive", true);
        public static readonly MimeTypeInfo TIB = new MimeTypeInfo(new byte?[] { 0xB4, 0x6E, 0x68, 0x44 }, 0, "tib", "", "Acronis True Image", false);
        public static readonly MimeTypeInfo TIF_1 = new MimeTypeInfo(new byte?[] { 0x49, 0x20, 0x49 }, 0, "tif", "image/tiff", "TIFF file_1", true);
        public static readonly MimeTypeInfo TIF_2 = new MimeTypeInfo(new byte?[] { 0x49, 0x49, 0x2A, 0x00 }, 0, "tif", "image/tiff", "TIFF file_2", true);
        public static readonly MimeTypeInfo TIF_3 = new MimeTypeInfo(new byte?[] { 0x4D, 0x4D, 0x00, 0x2A }, 0, "tif", "image/tiff", "TIFF file_3", true);
        public static readonly MimeTypeInfo TIF_4 = new MimeTypeInfo(new byte?[] { 0x4D, 0x4D, 0x00, 0x2B }, 0, "tif", "image/tiff", "TIFF file_4", true);
        public static readonly MimeTypeInfo TIFF_1 = new MimeTypeInfo(new byte?[] { 0x49, 0x20, 0x49 }, 0, "tiff", "image/tiff", "TIFF file_1", true);
        public static readonly MimeTypeInfo TIFF_2 = new MimeTypeInfo(new byte?[] { 0x49, 0x49, 0x2A, 0x00 }, 0, "tiff", "image/tiff", "TIFF file_2", true);
        public static readonly MimeTypeInfo TIFF_3 = new MimeTypeInfo(new byte?[] { 0x4D, 0x4D, 0x00, 0x2A }, 0, "tiff", "image/tiff", "TIFF file_3", true);
        public static readonly MimeTypeInfo TIFF_4 = new MimeTypeInfo(new byte?[] { 0x4D, 0x4D, 0x00, 0x2B }, 0, "tiff", "image/tiff", "TIFF file_4", true);
        public static readonly MimeTypeInfo TLB = new MimeTypeInfo(new byte?[] { 0x4D, 0x53, 0x46, 0x54, 0x00, 0x01, 0x00 }, 0, "tlb", "application/octet-stream", "OLE|SPSS|Visual C++ library file", false);
        public static readonly MimeTypeInfo TR1 = new MimeTypeInfo(new byte?[] { 0x01, 0x10 }, 0, "tr1", "", "Novell LANalyzer capture file", false);
        public static readonly MimeTypeInfo UCE = new MimeTypeInfo(new byte?[] { 0x55, 0x43, 0x45, 0x58 }, 0, "uce", "application/octet-stream", "Unicode extensions", false);
        public static readonly MimeTypeInfo UFA = new MimeTypeInfo(new byte?[] { 0x55, 0x46, 0x41, 0xC6, 0xD2, 0xC1 }, 0, "ufa", "", "UFA compressed archive", false);
        public static readonly MimeTypeInfo VBX = new MimeTypeInfo(new byte?[] { 0x4D, 0x5A }, 0, "vbx", "application/octet-stream", "VisualBASIC application", true);
        public static readonly MimeTypeInfo VCD = new MimeTypeInfo(new byte?[] { 0x45, 0x4E, 0x54, 0x52, 0x59, 0x56, 0x43, 0x44 }, 0, "vcd", "application/x-cdlink", "VideoVCD|VCDImager file", false);
        public static readonly MimeTypeInfo VCF = new MimeTypeInfo(new byte?[] { 0x42, 0x45, 0x47, 0x49, 0x4E, 0x3A, 0x56, 0x43 }, 0, "vcf", "text/x-vcard", "vCard", false);
        public static readonly MimeTypeInfo VCW = new MimeTypeInfo(new byte?[] { 0x5B, 0x4D, 0x53, 0x56, 0x43 }, 0, "vcw", "", "Visual C++ Workbench Info File", false);
        public static readonly MimeTypeInfo VHD = new MimeTypeInfo(new byte?[] { 0x63, 0x6F, 0x6E, 0x65, 0x63, 0x74, 0x69, 0x78 }, 0, "vhd", "", "Virtual PC HD image", false);
        public static readonly MimeTypeInfo VMDK_1 = new MimeTypeInfo(new byte?[] { 0x43, 0x4F, 0x57, 0x44 }, 0, "vmdk", "", "VMware 3 Virtual Disk", false);
        public static readonly MimeTypeInfo VMDK_2 = new MimeTypeInfo(new byte?[] { 0x23, 0x20, 0x44, 0x69, 0x73, 0x6B, 0x20, 0x44 }, 0, "vmdk", "", "VMware 4 Virtual Disk description", false);
        public static readonly MimeTypeInfo VMDK_3 = new MimeTypeInfo(new byte?[] { 0x4B, 0x44, 0x4D }, 0, "vmdk", "", "VMware 4 Virtual Disk", false);
        public static readonly MimeTypeInfo VOB = new MimeTypeInfo(new byte?[] { 0x00, 0x00, 0x01, 0xBA }, 0, "vob", "video/mpeg", "DVD video file", true);
        public static readonly MimeTypeInfo VSD = new MimeTypeInfo(new byte?[] { 0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, 0, "vsd", "application/vnd.visio", "Visio file", true);
        public static readonly MimeTypeInfo VXD = new MimeTypeInfo(new byte?[] { 0x4D, 0x5A }, 0, "vxd", "", "Windows virtual device drivers", true);
        public static readonly MimeTypeInfo WAB_1 = new MimeTypeInfo(new byte?[] { 0x9C, 0xCB, 0xCB, 0x8D, 0x13, 0x75, 0xD2, 0x11 }, 0, "wab", "", "Outlook address file", false);
        public static readonly MimeTypeInfo WAB_2 = new MimeTypeInfo(new byte?[] { 0x81, 0x32, 0x84, 0xC1, 0x85, 0x05, 0xD0, 0x11 }, 0, "wab", "", "Outlook Express address book (Win95)", false);
        public static readonly MimeTypeInfo WAV = new MimeTypeInfo(new byte?[] { 0x52, 0x49, 0x46, 0x46 }, 0, "wav", "audio/wav", "Resource Interchange File Format", true);
        public static readonly MimeTypeInfo WB2 = new MimeTypeInfo(new byte?[] { 0x00, 0x00, 0x02, 0x00 }, 0, "wb2", "application/x-quattropro", "QuattroPro spreadsheet", true);
        public static readonly MimeTypeInfo WB3 = new MimeTypeInfo(new byte?[] { 0x3E, 0x00, 0x03, 0x00, 0xFE, 0xFF, 0x09, 0x00, 0x06 }, 0, "wb3", "application/x-quattropro", "Quatro Pro for Windows 7.0", false);
        public static readonly MimeTypeInfo WIZ = new MimeTypeInfo(new byte?[] { 0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, 0, "wiz", "application/msword", "Microsoft Office document", true);
        public static readonly MimeTypeInfo WK1 = new MimeTypeInfo(new byte?[] { 0x00, 0x00, 0x02, 0x00, 0x06, 0x04, 0x06, 0x00 }, 0, "wk1", "application/vnd.lotus-1-2-3", "Lotus 1-2-3 (v1)", false);
        public static readonly MimeTypeInfo WK3 = new MimeTypeInfo(new byte?[] { 0x00, 0x00, 0x1A, 0x00, 0x00, 0x10, 0x04, 0x00 }, 0, "wk3", "application/vnd.lotus-1-2-3", "Lotus 1-2-3 (v3)", false);
        public static readonly MimeTypeInfo WK4 = new MimeTypeInfo(new byte?[] { 0x00, 0x00, 0x1A, 0x00, 0x02, 0x10, 0x04, 0x00 }, 0, "wk4", "application/vnd.lotus-1-2-3", "Lotus 1-2-3 (v4|v5)", true);
        public static readonly MimeTypeInfo WK5 = new MimeTypeInfo(new byte?[] { 0x00, 0x00, 0x1A, 0x00, 0x02, 0x10, 0x04, 0x00 }, 0, "wk5", "application/vnd.lotus-1-2-3", "Lotus 1-2-3 (v4|v5)", true);
        public static readonly MimeTypeInfo WKS_1 = new MimeTypeInfo(new byte?[] { 0x0E, 0x57, 0x4B, 0x53 }, 0, "wks", "application/vnd.ms-works", "DeskMate Worksheet", false);
        public static readonly MimeTypeInfo WKS_2 = new MimeTypeInfo(new byte?[] { 0xFF, 0x00, 0x02, 0x00, 0x04, 0x04, 0x05, 0x54 }, 0, "wks", "application/vnd.ms-works", "Works for Windows spreadsheet", false);
        public static readonly MimeTypeInfo WMA = new MimeTypeInfo(new byte?[] { 0x30, 0x26, 0xB2, 0x75, 0x8E, 0x66, 0xCF, 0x11 }, 0, "wma", "audio/x-ms-wma", "Windows Media Audio|Video File", true);
        public static readonly MimeTypeInfo WMF = new MimeTypeInfo(new byte?[] { 0xD7, 0xCD, 0xC6, 0x9A }, 0, "wmf", "application/x-msmetafile", "Windows graphics metafile", false);
        public static readonly MimeTypeInfo WMV = new MimeTypeInfo(new byte?[] { 0x30, 0x26, 0xB2, 0x75, 0x8E, 0x66, 0xCF, 0x11 }, 0, "wmv", "video/x-ms-wmv", "Windows Media Audio|Video File", true);
        public static readonly MimeTypeInfo WMZ = new MimeTypeInfo(new byte?[] { 0x50, 0x4B, 0x03, 0x04 }, 0, "wmz", "application/x-ms-wmz", "Windows Media compressed skin file", true);
        public static readonly MimeTypeInfo WP = new MimeTypeInfo(new byte?[] { 0xFF, 0x57, 0x50, 0x43 }, 0, "wp", "", "WordPerfect text and graphics", true);
        public static readonly MimeTypeInfo WP5 = new MimeTypeInfo(new byte?[] { 0xFF, 0x57, 0x50, 0x43 }, 0, "wp5", "", "WordPerfect text and graphics", true);
        public static readonly MimeTypeInfo WP6 = new MimeTypeInfo(new byte?[] { 0xFF, 0x57, 0x50, 0x43 }, 0, "wp6", "", "WordPerfect text and graphics", true);
        public static readonly MimeTypeInfo WPD = new MimeTypeInfo(new byte?[] { 0xFF, 0x57, 0x50, 0x43 }, 0, "wpd", "application/vnd.wordperfect", "WordPerfect text and graphics", true);
        public static readonly MimeTypeInfo WPF = new MimeTypeInfo(new byte?[] { 0x81, 0xCD, 0xAB }, 0, "wpf", "", "WordPerfect text", false);
        public static readonly MimeTypeInfo WPG = new MimeTypeInfo(new byte?[] { 0xFF, 0x57, 0x50, 0x43 }, 0, "wpg", "application/x-wpg", "WordPerfect text and graphics", true);
        public static readonly MimeTypeInfo WPL = new MimeTypeInfo(new byte?[] { 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, 0x74, 0x20, 0x57, 0x69, 0x6E, 0x64, 0x6F, 0x77, 0x73, 0x20, 0x4D, 0x65, 0x64, 0x69, 0x61, 0x20, 0x50, 0x6C, 0x61, 0x79, 0x65, 0x72, 0x2, 0x2D, 0x2D, 0x20 }, 84, "wpl", "application/vnd.ms-wpl", "Windows Media Player playlist", false);
        public static readonly MimeTypeInfo WPP = new MimeTypeInfo(new byte?[] { 0xFF, 0x57, 0x50, 0x43 }, 0, "der", "", "WordPerfect text and graphics", true);
        public static readonly MimeTypeInfo WPS = new MimeTypeInfo(new byte?[] { 0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, 0, "wps", "application/vnd.ms-works", "MSWorks text document", true);
        public static readonly MimeTypeInfo WRI_1 = new MimeTypeInfo(new byte?[] { 0x31, 0xBE }, 0, "wri", "application/x-mswrite", "MS Write file_1", false);
        public static readonly MimeTypeInfo WRI_2 = new MimeTypeInfo(new byte?[] { 0x32, 0xBE }, 0, "wri", "application/x-mswrite", "MS Write file_2", false);
        public static readonly MimeTypeInfo WRI_3 = new MimeTypeInfo(new byte?[] { 0xBE, 0x00, 0x00, 0x00, 0xAB }, 0, "wri", "application/x-mswrite", "MS Write file_3", false);
        public static readonly MimeTypeInfo WS = new MimeTypeInfo(new byte?[] { 0x1D, 0x7D }, 0, "ws", "", "WordStar Version 5.0|6.0 document", false);
        public static readonly MimeTypeInfo WS2 = new MimeTypeInfo(new byte?[] { 0x57, 0x53, 0x32, 0x30, 0x30, 0x30 }, 0, "ws2", "", "WordStar for Windows file", false);
        public static readonly MimeTypeInfo XDR = new MimeTypeInfo(new byte?[] { 0x3C }, 0, "xdr", "text/plain", "BizTalk XML-Data Reduced Schema", true);
        public static readonly MimeTypeInfo XLA = new MimeTypeInfo(new byte?[] { 0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, 0, "xla", "application/vnd.ms-excel", "Microsoft Office document", true);
        public static readonly MimeTypeInfo XLS_1 = new MimeTypeInfo(new byte?[] { 0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, 0, "xls", "application/vnd.ms-excel", "Microsoft Office document", true);
        public static readonly MimeTypeInfo XLS_2 = new MimeTypeInfo(new byte?[] { 0x09, 0x08, 0x10, 0x00, 0x00, 0x06, 0x05, 0x00 }, 512, "xls", "application/vnd.ms-excel", "Excel spreadsheet subheader_1", false);
        public static readonly MimeTypeInfo XLS_3 = new MimeTypeInfo(new byte?[] { 0xFD, 0xFF, 0xFF, 0xFF, 0x10 }, 512, "xls", "application/vnd.ms-excel", "Excel spreadsheet subheader_2", false);
        public static readonly MimeTypeInfo XLS_4 = new MimeTypeInfo(new byte?[] { 0xFD, 0xFF, 0xFF, 0xFF, 0x1F }, 512, "xls", "application/vnd.ms-excel", "Excel spreadsheet subheader_3", false);
        public static readonly MimeTypeInfo XLS_5 = new MimeTypeInfo(new byte?[] { 0xFD, 0xFF, 0xFF, 0xFF, 0x22 }, 512, "xls", "application/vnd.ms-excel", "Excel spreadsheet subheader_4", false);
        public static readonly MimeTypeInfo XLS_6 = new MimeTypeInfo(new byte?[] { 0xFD, 0xFF, 0xFF, 0xFF, 0x23 }, 512, "xls", "application/vnd.ms-excel", "Excel spreadsheet subheader_5", false);
        public static readonly MimeTypeInfo XLS_7 = new MimeTypeInfo(new byte?[] { 0xFD, 0xFF, 0xFF, 0xFF, 0x28 }, 512, "xls", "application/vnd.ms-excel", "Excel spreadsheet subheader_6", false);
        public static readonly MimeTypeInfo XLS_8 = new MimeTypeInfo(new byte?[] { 0xFD, 0xFF, 0xFF, 0xFF, 0x29 }, 512, "xls", "application/vnd.ms-excel", "Excel spreadsheet subheader_7", false);
        public static readonly MimeTypeInfo XLSX_1 = new MimeTypeInfo(new byte?[] { 0x50, 0x4B, 0x03, 0x04 }, 0, "xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "MS Office Open XML Format Document", true);
        public static readonly MimeTypeInfo XLSX_2 = new MimeTypeInfo(new byte?[] { 0x50, 0x4B, 0x03, 0x04, 0x14, 0x00, 0x06, 0x00 }, 0, "xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "MS Office 2007 documents", true);
        public static readonly MimeTypeInfo XML = new MimeTypeInfo(new byte?[] { 0x3C, 0x3F, 0x78, 0x6D, 0x6C, 0x20, 0x76, 0x65, 0x72, 0x73, 0x69, 0x6F, 0x6E, 0x3D, 0x22, 0x31, 0x2E, 0x30, 0x22, 0x3F, 0x3E }, 0, "xml", "text/xml", "User Interface Language", false);
        public static readonly MimeTypeInfo XPI = new MimeTypeInfo(new byte?[] { 0x50, 0x4B, 0x03, 0x04 }, 0, "xpi", "application/x-xpinstall", "Mozilla Browser Archive", true);
        public static readonly MimeTypeInfo XPS = new MimeTypeInfo(new byte?[] { 0x50, 0x4B, 0x03, 0x04 }, 0, "xps", "application/vnd.ms-xpsdocument", "XML paper specification file", true);
        public static readonly MimeTypeInfo XPT_1 = new MimeTypeInfo(new byte?[] { 0x50, 0x4B, 0x03, 0x04 }, 0, "xpt", "", "eXact Packager Models", true);
        public static readonly MimeTypeInfo XPT_2 = new MimeTypeInfo(new byte?[] { 0x58, 0x50, 0x43, 0x4F, 0x4D, 0x0A, 0x54, 0x79 }, 0, "xpt", "", "XPCOM libraries", false);
        public static readonly MimeTypeInfo ZAP = new MimeTypeInfo(new byte?[] { 0x4D, 0x5A, 0x90, 0x00, 0x03, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0xFF, 0xFF }, 0, "zap", "", "ZoneAlam data file", false);
        public static readonly MimeTypeInfo ZIP_1 = new MimeTypeInfo(new byte?[] { 0x50, 0x4B, 0x03, 0x04 }, 0, "zip", "application/zip", "PKZIP archive_1", true);
        public static readonly MimeTypeInfo ZIP_2 = new MimeTypeInfo(new byte?[] { 0x50, 0x4B, 0x4C, 0x49, 0x54, 0x45 }, 30, "zip", "application/zip", "PKLITE archive", false);
        public static readonly MimeTypeInfo ZIP_3 = new MimeTypeInfo(new byte?[] { 0x50, 0x4B, 0x53, 0x70, 0x58 }, 526, "zip", "application/zip", "PKSFX self-extracting archive", false);
        public static readonly MimeTypeInfo ZIP_4 = new MimeTypeInfo(new byte?[] { 0x50, 0x4B, 0x05, 0x06 }, 0, "zip", "application/zip", "PKZIP archive_2", false);
        public static readonly MimeTypeInfo ZIP_5 = new MimeTypeInfo(new byte?[] { 0x50, 0x4B, 0x07, 0x08 }, 0, "zip", "application/zip", "PKZIP archive_3", false);
        public static readonly MimeTypeInfo ZIP_6 = new MimeTypeInfo(new byte?[] { 0x57, 0x69, 0x6E, 0x5A, 0x69, 0x70 }, 29152, "zip", "application/zip", "WinZip compressed archive", false);
        public static readonly MimeTypeInfo ZIP_7 = new MimeTypeInfo(new byte?[] { 0x50, 0x4B, 0x03, 0x04, 0x14, 0x00, 0x01, 0x00 }, 0, "zip", "application/zip", "ZLock Pro encrypted ZIP", false);
        public static readonly MimeTypeInfo ZOO = new MimeTypeInfo(new byte?[] { 0x5A, 0x4F, 0x4F, 0x20 }, 0, "zoo", "application/x-zoo", "ZOO compressed archive", false);
        // ****************** 482 ******************


        /// <summary>
        /// Initialize to create mimetype in a list.
        /// </summary>
        static MimeTypes()
        {
            mimeTypeList = new List<MimeTypeInfo>()
            {
                //TXT,
                _3GP,
                _3GP2,
                _4XM,
                _7Z,
                ABA,
                ABD,
                ABI_1,
                ABI_2,
                ABY_1,
                ABY_2,
                AC,
                ACCDB,
                ACM,
                ACS,
                AD,
                ADF,
                ADP,
                ADX_1,
                ADX_2,
                AIFF,
                AIN,
                AMR,
                ANI,
                API,
                APR,
                ARC_1,
                ARC_2,
                ARC_3,
                ARC_4,
                ARC_5,
                ARC_6,
                ARJ,
                ARL,
                ASF,
                AST,
                ASX,
                AU_1,
                AU_2,
                AUT,
                AVI,
                AW,
                AX_1,
                AX_2,
                BAG_1,
                BAG_2,
                BDR,
                BIN,
                BMP,
                BZ2,
                CAB,
                CAB_2,
                CAL_1,
                CAL_2,
                CAL_3,
                CAP_1,
                CAP_2,
                CAS,
                CAT,
                CBD,
                CBK,
                CDA,
                CDR_1,
                CDR_2,
                CDR_3,
                CFG,
                CHI,
                CHM,
                CLASS,
                CLB_1,
                CLB_2,
                CMX,
                CNV,
                COD,
                COM_1,
                COM_2,
                COM_3,
                COM_4,
                CPE,
                CPI_1,
                CPI_2,
                CPX,
                CRU,
                CRW,
                CSH,
                CTF,
                CTL,
                CUIX,
                CUR,
                DAT_1,
                DAT_2,
                DAT_3,
                DAT_4,
                DAT_5,
                DAT_6,
                DAT_7,
                DAT_8,
                DAT_9,
                DAT_10,
                DAT_11,
                DAT_12,
                DAT_13,
                DAT_14,
                DAT_15,
                DAT_16,
                DAT_17,
                DAT_18,
                DB_1,
                DB_2,
                DB_3,
                DB_4,
                DB_5,
                DB_6,
                DB3,
                DB4,
                DBA,
                DBB,
                DBF,
                DBX,
                DCI,
                DCX,
                DEX,
                DIB,
                DLL,
                DMG,
                DMP_1,
                DMP_2,
                DMS,
                DOC_1,
                DOC_2,
                DOC_3,
                DOC_4,
                DOC_5,
                DOCX_1,
                DOCX_2,
                DOT,
                DRV,
                DRW_1,
                DRW_2,
                DS4,
                DSN,
                DSP,
                DSS,
                DSW,
                DTD,
                DUN,
                DVF,
                DVR,
                DW4,
                DWG,
                E01_1,
                E01_2,
                ECF,
                EFX,
                EML_1,
                EML_2,
                EML_3,
                ENL,
                EPS_1,
                EPS_2,
                ETH,
                EVT,
                EVTX,
                EXE,
                FDF,
                FLAC,
                FLI,
                FLT_1,
                FLT_2,
                FLV,
                FM,
                FON,
                FTR,
                GHO,
                GHS,
                GID_1,
                GID_2,
                GIF,
                GPG,
                GRP,
                GX2,
                GZ,
                HAP,
                HDMP,
                HDR_1,
                HDR_2,
                HIP,
                HLP_1,
                HLP_2,
                HLP_3,
                HQX,
                ICO,
                IDX_1,
                IDX_2,
                IDX_3,
                IFO,
                IMG_1,
                IMG_2,
                IMG_3,
                IND_1,
                IND_2,
                INFO_1,
                INFO_2,
                INFO_3,
                ISO,
                IVR,
                JAR_1,
                JAR_2,
                JAR_3,
                JAR_4,
                JFIF,
                JG_1,
                JG_2,
                JNT,
                JP2,
                JPE,
                JPEG_1,
                JPEG_2,
                JPEG_3,
                JPG_1,
                JPG_2,
                JPG_3,
                JTP,
                KGB,
                KOZ,
                KWD,
                LBK,
                LGC,
                LHA,
                LIB,
                LIT,
                LNK,
                LOG,
                LWP,
                LZH,
                M4A,
                MANIFEST,
                MAR_1,
                MAR_2,
                MAR_3,
                MDB,
                MDF,
                MDI,
                MID,
                MIDI,
                MIF_1,
                MIF_2,
                MKV,
                MLS_1,
                MLS_2,
                MLS_3,
                MLS_4,
                MMF,
                MNY,
                MOF,
                MOV_1,
                MOV_2,
                MOV_3,
                MOV_4,
                MOV_5,
                MOV_6,
                MP,
                MP3,
                MPG_1,
                MPG_2,
                MSC_1,
                MSC_2,
                MSI_1,
                MSI_2,
                MSV,
                MTW,
                NRI,
                NSF_1,
                NSF_2,
                NTF_1,
                NTF_2,
                NTF_3,
                NVRAM,
                OBJ_1,
                OBJ_2,
                OCX,
                ODP,
                ODT,
                OGA,
                OGG,
                OGV,
                OLB,
                ONE,
                OPT_1,
                OPT_2,
                ORG,
                OTT,
                P10,
                PAK_1,
                PAK_2,
                PAT,
                PAX,
                PCH,
                PCX_1,
                PCX_2,
                PCX_3,
                PDB_1,
                PDB_2,
                PDB_3,
                PDB_4,
                PDB_5,
                PDF,
                PF,
                PFC_1,
                PFC_2,
                PGD,
                PGM,
                PIF,
                PKR,
                PNG,
                PPS,
                PPT_1,
                PPT_2,
                PPT_3,
                PPT_4,
                PPT_5,
                PPT_6,
                PPT_7,
                PPTX_1,
                PPTX_2,
                PPZ,
                PRC_1,
                PRC_2,
                PSD,
                PSP,
                PUB,
                PWI,
                PWL_1,
                PWL_2,
                QBB,
                QCP,
                QDF,
                QEL,
                QEMU,
                QPH,
                QSD,
                QTS,
                QXD_1,
                QXD_2,
                RA_1,
                RA_2,
                RAM,
                RAR,
                REG_1,
                REG_2,
                RGB,
                RM,
                RMI,
                RMVB,
                RPM,
                RTD,
                RTF,
                RVT,
                SAM_1,
                SAM_2,
                SAV,
                SCR,
                SH3,
                SHD_1,
                SHD_2,
                SHD_3,
                SHD_4,
                SHW,
                SIT_1,
                SIT_2,
                SKF,
                SKR_1,
                SKR_2,
                SLE_1,
                SLE_2,
                SLN,
                SNM,
                SNP,
                SOU,
                SPL,
                SPO,
                SUD,
                SUO,
                SWF_1,
                SWF_2,
                SXC,
                SXD,
                SXI,
                SXW,
                SYS_1,
                SYS_2,
                SYS_3,
                SYS_4,
                SYS_5,
                SYS_6,
                SYS_7,
                SYW,
                TAR,
                TARBZ2,
                TARZ_1,
                TARZ_2,
                TB2,
                TIB,
                TIF_1,
                TIF_2,
                TIF_3,
                TIF_4,
                TIFF_1,
                TIFF_2,
                TIFF_3,
                TIFF_4,
                TLB,
                TR1,
                UCE,
                UFA,
                VBX,
                VCD,
                VCF,
                VCW,
                VHD,
                VMDK_1,
                VMDK_2,
                VMDK_3,
                VOB,
                VSD,
                VXD,
                WAB_1,
                WAB_2,
                WAV,
                WB2,
                WB3,
                WIZ,
                WK1,
                WK3,
                WK4,
                WK5,
                WKS_1,
                WKS_2,
                WMA,
                WMF,
                WMV,
                WMZ,
                WP,
                WP5,
                WP6,
                WPD,
                WPF,
                WPG,
                WPL,
                WPP,
                WPS,
                WRI_1,
                WRI_2,
                WRI_3,
                WS,
                WS2,
                XDR,
                XLA,
                XLS_1,
                XLS_2,
                XLS_3,
                XLS_4,
                XLS_5,
                XLS_6,
                XLS_7,
                XLS_8,
                XLSX_1,
                XLSX_2,
                XML,
                XPI,
                XPS,
                XPT_1,
                XPT_2,
                ZAP,
                ZIP_1,
                ZIP_2,
                ZIP_3,
                ZIP_4,
                ZIP_5,
                ZIP_6,
                ZIP_7,
                ZOO,
            };
        }

        /// <summary>
        /// Add new mimetype to the list of mimetypes.
        /// </summary>
        /// <param name="mimeType">New mimetype add to list of mimetypes.</param>
        public static void Add(MimeTypeInfo mimeType)
        {
            mimeTypeList.Add(mimeType);
        }

        /// <summary>
        /// Add new mimetype to the list of mimetypes from a file path.
        /// </summary>
        /// <param name="filePath">path of the file that want to add the list.</param>
        /// <param name="headerOffset">how far is the header from begin of file content</param>
        /// <param name="headerSize">size of header to read.length fo the header</param>
        /// <param name="extension">mimetype extention like "mp3","avi",... </param>
        /// <param name="mimeType">
        /// Mimetype of file.a MimeType most-commonly consists of just two parts,
        /// a type and a subtype,
        /// separated by a slash (/) — with no whitespace between:
        ///  "video/3gpp","image/x-icon"
        /// </param>
        /// <param name="description">description text to the mimetype </param>
        /// <param name="mustBeDetectByExtention"> Determine Yes if the mimetype magic number is equal with some other one else False</param>
        public static void Add(
            string filePath, 
            int headerOffset,
            int headerSize,
            string extension,
            string mimeType,
            string description,
            bool mustBeDetectByExtention
            )
        {
            byte[] headerContent = new byte[headerSize];
            using (FileStream fsSource = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                fsSource.Read(headerContent, headerOffset, headerSize);
            }

            var header = Array.ConvertAll<byte, byte?>(headerContent, input => input);

            mimeTypeList.Add
            (
                new MimeTypeInfo(header, headerOffset, extension, mimeType, description, mustBeDetectByExtention)
            );
        }

        /// <summary>
        /// Add new mimetype to the list of mimetypes from a fileInfo class. 
        /// </summary>
        /// <param name="fileInfo">determine the file that needs its mimetype</param>
        /// <param name="headerOffset">how far is the header from begin of file content</param>
        /// <param name="headerSize">size of header to read.length fo the header</param>
        /// <param name="extension">mimetype extention like "mp3","avi",... </param>
        /// <param name="mimeType">
        /// Mimetype of file.a MimeType most-commonly consists of just two parts,
        /// a type and a subtype,
        /// separated by a slash (/) — with no whitespace between:
        ///  "video/3gpp","image/x-icon"
        /// </param>
        /// <param name="description">description text to the mimetype </param>
        /// <param name="mustBeDetectByExtention"> Determine Yes if the mimetype magic number is equal with some other one else False</param>
        public static void Add(
            FileInfo fileInfo,
            int headerOffset,
            int headerSize,
            string extension,
            string mimeType,
            string description,
            bool mustBeDetectByExtention
        )
        {
            byte[] headerContent = new byte[headerSize];
            using (FileStream stream = fileInfo.OpenRead())
            {
                stream.Read(headerContent, headerOffset, headerSize);
            }

            var header = Array.ConvertAll<byte, byte?>(headerContent, input => input);

            mimeTypeList.Add
                (
                new MimeTypeInfo(header, headerOffset,extension,mimeType, description, mustBeDetectByExtention)    
                );
        }

        /// <summary>
        /// Add new mimetype to the list of mimetypes from a stream. 
        /// </summary>
        /// <param name="stream">determine stream that needs </param>
        /// <param name="headerOffset">how far is the header from begin of file content</param>
        /// <param name="headerSize">size of header to read.length fo the header</param>
        /// <param name="extension">mimetype extention like "mp3","avi",... </param>
        /// <param name="mimeType">
        /// Mimetype of file.a MimeType most-commonly consists of just two parts,
        /// a type and a subtype,
        /// separated by a slash (/) — with no whitespace between:
        ///  "video/3gpp","image/x-icon"
        /// </param>
        /// <param name="description">description text to the mimetype </param>
        /// <param name="mustBeDetectByExtention"> Determine Yes if the mimetype magic number is equal with some other one else False</param>
        public static void Add(
            Stream stream,
            int headerOffset,
            int headerSize,
            string extension,
            string mimeType,
            string description,
            bool mustBeDetectByExtention
        )
        {
            byte[] headerContent = new byte[headerSize];
           
            stream.Read(headerContent, headerOffset, headerSize);

            var header = Array.ConvertAll<byte, byte?>(headerContent, input => input);

            mimeTypeList.Add
            (
                new MimeTypeInfo(header, headerOffset, extension, mimeType, description, mustBeDetectByExtention)
            );
        }

        /// <summary>
        /// Add new mimetype to the list of mimetypes from a stream. 
        /// </summary>
        /// <param name="stream">determine stream that needs </param>
        /// <param name="headerOffset">how far is the header from begin of file content</param>
        /// <param name="headerSize">size of header to read.length fo the header</param>
        /// <param name="extension">mimetype extention like "mp3","avi",... </param>
        /// <param name="mimeType">
        /// Mimetype of file.a MimeType most-commonly consists of just two parts,
        /// a type and a subtype,
        /// separated by a slash (/) — with no whitespace between:
        ///  "video/3gpp","image/x-icon"
        /// </param>
        /// <param name="description">description text to the mimetype </param>
        /// <param name="mustBeDetectByExtention"> Determine Yes if the mimetype magic number is equal with some other one else False</param>
        public static void Add(
            byte?[] fileContent,
            int headerOffset,
            int headerSize,
            string extension,
            string mimeType,
            string description,
            bool mustBeDetectByExtention
        )
        {
            if(fileContent == null)
                return;

            var header  = new byte?[headerSize];

            Array.Copy(fileContent, headerOffset, header, 0, headerSize);

            mimeTypeList.Add
            (
                new MimeTypeInfo(header, headerOffset, extension, mimeType, description, mustBeDetectByExtention)
            );
        }

    }
}
