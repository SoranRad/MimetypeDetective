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

        public static IEnumerable<MimeTypeInfo> MimeTypeList => mimeTypeList.AsEnumerable();

        public static readonly MimeTypeInfo TXT = new MimeTypeInfo(new byte?[0], "txt", "text/plain","text file",false);
        public static readonly MimeTypeInfo ZIP = new MimeTypeInfo(new byte?[] { 0x50, 0x4B, 0x03, 0x04 }, "zip", "application/x-compressed", "PKZIP archive_1", true);

        public static readonly MimeTypeInfo _3GP = new MimeTypeInfo(new byte?[] { 0x00, 0x00, 0x00, 0x14, 0x66, 0x74, 0x79, 0x70 }, 0, "3gp", "video/3gpp", "3GPP multimedia files",false);
        public static readonly MimeTypeInfo _3GP2 = new MimeTypeInfo(new byte?[] { 0x00, 0x00, 0x00, 0x20, 0x66, 0x74, 0x79, 0x70 }, 0, "3gp2", "video/3gpp2", "3GPP2 multimedia files",false);
        public static readonly MimeTypeInfo _4XM = new MimeTypeInfo(new byte?[] { 0x52, 0x49, 0x46, 0x46 }, 0, "4xm", "application/octet-stream", "4X Movie video",true);
        public static readonly MimeTypeInfo _7Z = new MimeTypeInfo(new byte?[] { 0x37, 0x7A, 0xBC, 0xAF, 0x27, 0x1C }, 0, "7z", "application/x-7z-compressed", "7-Zip compressed file",false);
        public static readonly MimeTypeInfo ABA = new MimeTypeInfo(new byte?[] { 0x00, 0x01, 0x42, 0x41 }, 0, "aba", "", "Palm Address Book Archive",false);
        public static readonly MimeTypeInfo ABD = new MimeTypeInfo(new byte?[] { 0x51, 0x57, 0x20, 0x56, 0x65, 0x72, 0x2E, 0x20 }, 0, "abd", "", "ABD | QSD Quicken data file",false);
        public static readonly MimeTypeInfo ABI_1 = new MimeTypeInfo(new byte?[] { 0x41, 0x4F, 0x4C, 0x49, 0x4E, 0x44, 0x45, 0x58 }, 0, "abi", "application/abi", "AOL address book index",false);
        public static readonly MimeTypeInfo ABI_2 = new MimeTypeInfo(new byte?[] { 0x41, 0x4F, 0x4C }, 0, "abi", "application/abi", "AOL config files",true);
        public static readonly MimeTypeInfo ABY_1 = new MimeTypeInfo(new byte?[] { 0x41, 0x4F, 0x4C, 0x44, 0x42 }, 0, "aby", "", "AOL address book",false);
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
        public static readonly MimeTypeInfo ASX = new MimeTypeInfo(new byte?[] { 0x3C }, 0, "asx", "video/x-ms-asf", "Advanced Stream Redirector", false);
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
        public static readonly MimeTypeInfo BZ2 = new MimeTypeInfo(new byte?[] { 0x42, 0x5A, 0x68 }, 0, "bz2", "application/x-bzip", "bzip2 compressed archive", false);
        public static readonly MimeTypeInfo CAB = new MimeTypeInfo(new byte?[] { 0x49, 0x53, 0x63, 0x28 }, 0, "cab", "application/octet-stream", "Install Shield compressed file", false);
        public static readonly MimeTypeInfo CAB_2 = new MimeTypeInfo(new byte?[] { 0x4D, 0x53, 0x43, 0x46 }, 0, "cab", "application/octet-stream", "Microsoft cabinet file", false);
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
        public static readonly MimeTypeInfo CDR_3 = new MimeTypeInfo(new byte?[] { 0x4D, 0x53, 0x5F, 0x56, 0x4F, 0x49, 0x43, 0x45 }, 0, "cdr", "application/vnd.corel-draw", "Sony Compressed Voice File", false);
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
        public static readonly MimeTypeInfo COM_2 = new MimeTypeInfo(new byte?[] { 0xE8 }, 0, "com", "application/x-msdownload", "Windows executable file_1", false);
        public static readonly MimeTypeInfo COM_3 = new MimeTypeInfo(new byte?[] { 0xE9 }, 0, "com", "application/x-msdownload", "Windows executable file_2", false);
        public static readonly MimeTypeInfo COM_4 = new MimeTypeInfo(new byte?[] { 0xEB }, 0, "com", "application/x-msdownload", "Windows executable file_3", false);
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
        public static readonly MimeTypeInfo CUR = new MimeTypeInfo(new byte?[] { 0x00, 0x00, 0x02, 0x00 }, 0, "cur", "application/octet-stream", "Windows cursor", false);
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
        public static readonly MimeTypeInfo DMP_1 = new MimeTypeInfo(new byte?[] { 0x4D, 0x44, 0x4D, 0x50, 0x93, 0xA7 }, 0, "dmp", "", "Windows dump file", false);
        public static readonly MimeTypeInfo DMP_2 = new MimeTypeInfo(new byte?[] { 0x50, 0x41, 0x47, 0x45, 0x44, 0x55 }, 0, "dmp", "", "Windows memory dump", false);
        public static readonly MimeTypeInfo DMS = new MimeTypeInfo(new byte?[] { 0x44, 0x4D, 0x53, 0x21 }, 0, "dms", "application/octet-stream", "Amiga DiskMasher compressed archive", false);
        public static readonly MimeTypeInfo DOC_1 = new MimeTypeInfo(new byte?[] { 0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, 0, "doc", "application/msword", "Microsoft Office document", true);
        public static readonly MimeTypeInfo DOC_2 = new MimeTypeInfo(new byte?[] { 0x0D, 0x44, 0x4F, 0x43 }, 0, "doc", "application/msword", "DeskMate Document", true);
        public static readonly MimeTypeInfo DOC_3 = new MimeTypeInfo(new byte?[] { 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1, 0x00 }, 0, "doc", "application/msword", "Perfect Office document", true);
        public static readonly MimeTypeInfo DOC_4 = new MimeTypeInfo(new byte?[] { 0xDB, 0xA5, 0x2D, 0x00 }, 0, "doc", "application/msword", "Word 2.0 file", true);
        public static readonly MimeTypeInfo DOC_5 = new MimeTypeInfo(new byte?[] { 0xEC, 0xA5, 0xC1, 0x00 }, 512, "doc", "application/msword", "Word document subheader", true);
        public static readonly MimeTypeInfo DOCX_1 = new MimeTypeInfo(new byte?[] { 0x50, 0x4B, 0x03, 0x04 }, 0, "docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document", "MS Office Open XML Format Document", true);
        public static readonly MimeTypeInfo DOCX_2 = new MimeTypeInfo(new byte?[] { 0x50, 0x4B, 0x03, 0x04, 0x14, 0x00, 0x06, 0x00 }, 0, "docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document", "MS Office 2007 documents", false);
        public static readonly MimeTypeInfo DOT = new MimeTypeInfo(new byte?[] { 0xD0, 0xCF, 0x11, 0xE0, 0xA1, 0xB1, 0x1A, 0xE1 }, 0, "dot", "application/msword", "Microsoft Office document", true);
        public static readonly MimeTypeInfo DRV = new MimeTypeInfo(new byte?[] { 0x4D, 0x5A }, 0, "drv", "", "Windows|DOS executable file", true);
        public static readonly MimeTypeInfo DRW_1 = new MimeTypeInfo(new byte?[] { 0x07 }, 0, "drw", "", "Generic drawing programs", false);
        public static readonly MimeTypeInfo DRW_2 = new MimeTypeInfo(new byte?[] { 0x01, 0xFF, 0x02, 0x04, 0x03, 0x02 }, 0, "drw", "", "Micrografx vector graphic file", false);
        public static readonly MimeTypeInfo DS4 = new MimeTypeInfo(new byte?[] { 0x52, 0x49, 0x46, 0x46 }, 0, "ds4", "", "Micrografx Designer graphic", true);
        public static readonly MimeTypeInfo DSN = new MimeTypeInfo(new byte?[] { 0x4D, 0x56 }, 0, "dsn", "", "CD Stomper Pro label file", false);
        public static readonly MimeTypeInfo DSP = new MimeTypeInfo(new byte?[] { 0x23, 0x20, 0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73 }, 0, "dsp", "application/octet-stream", "MS Developer Studio project file", false);
        public static readonly MimeTypeInfo DSS = new MimeTypeInfo(new byte?[] { 0x02, 0x64, 0x73, 0x73 }, 0, "dss", "", "Digital Speech Standard file", false);
        public static readonly MimeTypeInfo DSW = new MimeTypeInfo(new byte?[] { 0x64, 0x73, 0x77, 0x66, 0x69, 0x6C, 0x65 }, 0, "dsw", "text/plain", "MS Visual Studio workspace file", false);
        // ****************** 143 ******************
        // Page 6

        /// <summary>
        /// Initialize to create mimetype in a list.
        /// </summary>
        static MimeTypes()
        {
            mimeTypeList = new List<MimeTypeInfo>()
            {
                TXT,
                ZIP,
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
                DAT_10
                ,DAT_11
                ,DAT_12,
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
                DSW
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
        /// <param name="description">description</param>
        public static void Add(
            string filePath, 
            int headerOffset,
            int headerSize,
            string extension,
            string mimeType,
            string description
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
                new MimeTypeInfo(header, headerOffset, extension, mimeType, description, false)
            );
        }

        /// <summary>
        /// 
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
        /// <param name="description">description</param>
        public static void Add(
            FileInfo fileInfo,
            int headerOffset,
            int headerSize,
            string extension,
            string mimeType,
            string description
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
                new MimeTypeInfo(header, headerOffset,extension,mimeType, description, false)    
                );
        }

        /// <summary>
        /// 
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
        /// <param name="description">description</param>
        public static void Add(
            Stream stream,
            int headerOffset,
            int headerSize,
            string extension,
            string mimeType,
            string description
        )
        {
            byte[] headerContent = new byte[headerSize];
           
            stream.Read(headerContent, headerOffset, headerSize);

            var header = Array.ConvertAll<byte, byte?>(headerContent, input => input);

            mimeTypeList.Add
            (
                new MimeTypeInfo(header, headerOffset, extension, mimeType, description, false)
            );
        }



    }
}
