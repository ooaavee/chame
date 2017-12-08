using System.Collections.Generic;

namespace Chame.ContentLoaders
{
    /// <summary>
    /// Supported content by the default.
    /// </summary>
    public class DefaultContentModel : IContentModel
    {
        public virtual IList<IContentInfo> SupportedContent { get; } = new List<IContentInfo>();

        public DefaultContentModel()
        {
            Use("application/vnd.hzn-3d-crossword", "x3d");
            Use("video/3gpp", "3gp");
            Use("video/3gpp2", "3g2");
            Use("application/vnd.mseq", "mseq");
            Use("application/vnd.3m.post-it-notes", "pwn");
            Use("application/vnd.3gpp.pic-bw-large", "plb");
            Use("application/vnd.3gpp.pic-bw-small", "psb");
            Use("application/vnd.3gpp.pic-bw-var", "pvb");
            Use("application/vnd.3gpp2.tcap", "tcap");
            Use("application/x-7z-compressed", "7z");
            Use("application/x-abiword", "abw");
            Use("application/x-ace-compressed", "ace");
            Use("application/vnd.americandynamics.acc", "acc");
            Use("application/vnd.acucobol", "acu");
            Use("application/vnd.acucorp", "atc");
            Use("audio/adpcm", "adp");
            Use("application/x-authorware-bin", "aab");
            Use("application/x-authorware-map", "aam");
            Use("application/x-authorware-seg", "aas");
            Use("application/vnd.adobe.air-application-installer-package+zip", "air");
            Use("application/x-shockwave-flash", "swf");
            Use("application/vnd.adobe.fxp", "fxp");
            Use("application/pdf", "pdf");
            Use("application/vnd.cups-ppd", "ppd");
            Use("application/x-director", "dir");
            Use("application/vnd.adobe.xdp+xml", "xdp");
            Use("application/vnd.adobe.xfdf", "xfdf");
            Use("audio/x-aac", "aac");
            Use("application/vnd.ahead.space", "ahead");
            Use("application/vnd.airzip.filesecure.azf", "azf");
            Use("application/vnd.airzip.filesecure.azs", "azs");
            Use("application/vnd.amazon.ebook", "azw");
            Use("application/vnd.amiga.ami", "ami");
            Use("application/vnd.android.package-archive", "apk");
            Use("application/vnd.anser-web-certificate-issue-initiation", "cii");
            Use("application/vnd.anser-web-funds-transfer-initiation", "fti");
            Use("application/vnd.antix.game-component", "atx");
            Use("application/x-apple-diskimage", "dmg");
            Use("application/vnd.apple.installer+xml", "mpkg");
            Use("application/applixware", "aw");
            Use("application/vnd.hhe.lesson-player", "les");
            Use("application/vnd.aristanetworks.swi", "swi");
            Use("text/x-asm", "s");
            Use("application/atomcat+xml", "atomcat");
            Use("application/atomsvc+xml", "atomsvc");
            Use("application/atom+xml", "atom, .xml");
            Use("application/pkix-attr-cert", "ac");
            Use("audio/x-aiff", "aif");
            Use("video/x-msvideo", "avi");
            Use("application/vnd.audiograph", "aep");
            Use("image/vnd.dxf", "dxf");
            Use("model/vnd.dwf", "dwf");
            Use("text/plain-bas", "par");
            Use("application/x-bcpio", "bcpio");
            Use("application/octet-stream", "bin");
            Use("image/bmp", "bmp");
            Use("application/x-bittorrent", "torrent");
            Use("application/vnd.rim.cod", "cod");
            Use("application/vnd.blueice.multipass", "mpm");
            Use("application/vnd.bmi", "bmi");
            Use("application/x-sh", "sh");
            Use("image/prs.btif", "btif");
            Use("application/vnd.businessobjects", "rep");
            Use("application/x-bzip", "bz");
            Use("application/x-bzip2", "bz2");
            Use("application/x-csh", "csh");
            Use("text/x-c", "c");
            Use("application/vnd.chemdraw+xml", "cdxml");
            Use("text/css", "css", true);
            Use("chemical/x-cdx", "cdx");
            Use("chemical/x-cml", "cml");
            Use("chemical/x-csml", "csml");
            Use("application/vnd.contact.cmsg", "cdbcmsg");
            Use("application/vnd.claymore", "cla");
            Use("application/vnd.clonk.c4group", "c4g");
            Use("image/vnd.dvb.subtitle", "sub");
            Use("application/cdmi-capability", "cdmia");
            Use("application/cdmi-container", "cdmic");
            Use("application/cdmi-domain", "cdmid");
            Use("application/cdmi-object", "cdmio");
            Use("application/cdmi-queue", "cdmiq");
            Use("application/vnd.cluetrust.cartomobile-config", "c11amc");
            Use("application/vnd.cluetrust.cartomobile-config-pkg", "c11amz");
            Use("image/x-cmu-raster", "ras");
            Use("model/vnd.collada+xml", "dae");
            Use("text/csv", "csv");
            Use("application/mac-compactpro", "cpt");
            Use("application/vnd.wap.wmlc", "wmlc");
            Use("image/cgm", "cgm");
            Use("x-conference/x-cooltalk", "ice");
            Use("image/x-cmx", "cmx");
            Use("application/vnd.xara", "xar");
            Use("application/vnd.cosmocaller", "cmc");
            Use("application/x-cpio", "cpio");
            Use("application/vnd.crick.clicker", "clkx");
            Use("application/vnd.crick.clicker.keyboard", "clkk");
            Use("application/vnd.crick.clicker.palette", "clkp");
            Use("application/vnd.crick.clicker.template", "clkt");
            Use("application/vnd.crick.clicker.wordbank", "clkw");
            Use("application/vnd.criticaltools.wbs+xml", "wbs");
            Use("application/vnd.rig.cryptonote", "cryptonote");
            Use("chemical/x-cif", "cif");
            Use("chemical/x-cmdf", "cmdf");
            Use("application/cu-seeme", "cu");
            Use("application/prs.cww", "cww");
            Use("text/vnd.curl", "curl");
            Use("text/vnd.curl.dcurl", "dcurl");
            Use("text/vnd.curl.mcurl", "mcurl");
            Use("text/vnd.curl.scurl", "scurl");
            Use("application/vnd.curl.car", "car");
            Use("application/vnd.curl.pcurl", "pcurl");
            Use("application/vnd.yellowriver-custom-menu", "cmp");
            Use("application/dssc+der", "dssc");
            Use("application/dssc+xml", "xdssc");
            Use("application/x-debian-package", "deb");
            Use("audio/vnd.dece.audio", "uva");
            Use("image/vnd.dece.graphic", "uvi");
            Use("video/vnd.dece.hd", "uvh");
            Use("video/vnd.dece.mobile", "uvm");
            Use("video/vnd.uvvu.mp4", "uvu");
            Use("video/vnd.dece.pd", "uvp");
            Use("video/vnd.dece.sd", "uvs");
            Use("video/vnd.dece.video", "uvv");
            Use("application/x-dvi", "dvi");
            Use("application/vnd.fdsn.seed", "seed");
            Use("application/x-dtbook+xml", "dtb");
            Use("application/x-dtbresource+xml", "res");
            Use("application/vnd.dvb.ait", "ait");
            Use("application/vnd.dvb.service", "svc");
            Use("audio/vnd.digital-winds", "eol");
            Use("image/vnd.djvu", "djvu");
            Use("application/xml-dtd", "dtd");
            Use("application/vnd.dolby.mlp", "mlp");
            Use("application/x-doom", "wad");
            Use("application/vnd.dpgraph", "dpg");
            Use("audio/vnd.dra", "dra");
            Use("application/vnd.dreamfactory", "dfac");
            Use("audio/vnd.dts", "dts");
            Use("audio/vnd.dts.hd", "dtshd");
            Use("image/vnd.dwg", "dwg");
            Use("application/vnd.dynageo", "geo");
            Use("application/ecmascript", "es");
            Use("application/vnd.ecowin.chart", "mag");
            Use("image/vnd.fujixerox.edmics-mmr", "mmr");
            Use("image/vnd.fujixerox.edmics-rlc", "rlc");
            Use("application/exi", "exi");
            Use("application/vnd.proteus.magazine", "mgz");
            Use("application/epub+zip", "epub");
            Use("message/rfc822", "eml");
            Use("application/vnd.enliven", "nml");
            Use("application/vnd.is-xpr", "xpr");
            Use("image/vnd.xiff", "xif");
            Use("application/vnd.xfdl", "xfdl");
            Use("application/emma+xml", "emma");
            Use("application/vnd.ezpix-album", "ez2");
            Use("application/vnd.ezpix-package", "ez3");
            Use("image/vnd.fst", "fst");
            Use("video/vnd.fvt", "fvt");
            Use("image/vnd.fastbidsheet", "fbs");
            Use("application/vnd.denovo.fcselayout-link", "fe_launch");
            Use("video/x-f4v", "f4v");
            Use("video/x-flv", "flv");
            Use("image/vnd.fpx", "fpx");
            Use("image/vnd.net-fpx", "npx");
            Use("text/vnd.fmi.flexstor", "flx");
            Use("video/x-fli", "fli");
            Use("application/vnd.fluxtime.clip", "ftc");
            Use("application/vnd.fdf", "fdf");
            Use("text/x-fortran", "f");
            Use("application/vnd.mif", "mif");
            Use("application/vnd.framemaker", "fm");
            Use("image/x-freehand", "fh");
            Use("application/vnd.fsc.weblaunch", "fsc");
            Use("application/vnd.frogans.fnc", "fnc");
            Use("application/vnd.frogans.ltf", "ltf");
            Use("application/vnd.fujixerox.ddd", "ddd");
            Use("application/vnd.fujixerox.docuworks", "xdw");
            Use("application/vnd.fujixerox.docuworks.binder", "xbd");
            Use("application/vnd.fujitsu.oasys", "oas");
            Use("application/vnd.fujitsu.oasys2", "oa2");
            Use("application/vnd.fujitsu.oasys3", "oa3");
            Use("application/vnd.fujitsu.oasysgp", "fg5");
            Use("application/vnd.fujitsu.oasysprs", "bh2");
            Use("application/x-futuresplash", "spl");
            Use("application/vnd.fuzzysheet", "fzs");
            Use("image/g3fax", "g3");
            Use("application/vnd.gmx", "gmx");
            Use("model/vnd.gtw", "gtw");
            Use("application/vnd.genomatix.tuxedo", "txd");
            Use("application/vnd.geogebra.file", "ggb");
            Use("application/vnd.geogebra.tool", "ggt");
            Use("model/vnd.gdl", "gdl");
            Use("application/vnd.geometry-explorer", "gex");
            Use("application/vnd.geonext", "gxt");
            Use("application/vnd.geoplan", "g2w");
            Use("application/vnd.geospace", "g3w");
            Use("application/x-font-ghostscript", "gsf");
            Use("application/x-font-bdf", "bdf");
            Use("application/x-gtar", "gtar");
            Use("application/x-texinfo", "texinfo");
            Use("application/x-gnumeric", "gnumeric");
            Use("application/vnd.google-earth.kml+xml", "kml");
            Use("application/vnd.google-earth.kmz", "kmz");
            Use("application/vnd.grafeq", "gqf");
            Use("image/gif", "gif");
            Use("text/vnd.graphviz", "gv");
            Use("application/vnd.groove-account", "gac");
            Use("application/vnd.groove-help", "ghf");
            Use("application/vnd.groove-identity-message", "gim");
            Use("application/vnd.groove-injector", "grv");
            Use("application/vnd.groove-tool-message", "gtm");
            Use("application/vnd.groove-tool-template", "tpl");
            Use("application/vnd.groove-vcard", "vcg");
            Use("video/h261", "h261");
            Use("video/h263", "h263");
            Use("video/h264", "h264");
            Use("application/vnd.hp-hpid", "hpid");
            Use("application/vnd.hp-hps", "hps");
            Use("application/x-hdf", "hdf");
            Use("audio/vnd.rip", "rip");
            Use("application/vnd.hbci", "hbci");
            Use("application/vnd.hp-jlyt", "jlt");
            Use("application/vnd.hp-pcl", "pcl");
            Use("application/vnd.hp-hpgl", "hpgl");
            Use("application/vnd.yamaha.hv-script", "hvs");
            Use("application/vnd.yamaha.hv-dic", "hvd");
            Use("application/vnd.yamaha.hv-voice", "hvp");
            Use("application/vnd.hydrostatix.sof-data", "sfd-hdstx");
            Use("application/hyperstudio", "stk");
            Use("application/vnd.hal+xml", "hal");
            Use("text/html", "html");
            Use("application/vnd.ibm.rights-management", "irm");
            Use("application/vnd.ibm.secure-container", "sc");
            Use("text/calendar", "ics");
            Use("application/vnd.iccprofile", "icc");
            Use("image/x-icon", "ico");
            Use("application/vnd.igloader", "igl");
            Use("image/ief", "ief");
            Use("application/vnd.immervision-ivp", "ivp");
            Use("application/vnd.immervision-ivu", "ivu");
            Use("application/reginfo+xml", "rif");
            Use("text/vnd.in3d.3dml", "3dml");
            Use("text/vnd.in3d.spot", "spot");
            Use("model/iges", "igs");
            Use("application/vnd.intergeo", "i2g");
            Use("application/vnd.cinderella", "cdy");
            Use("application/vnd.intercon.formnet", "xpw");
            Use("application/vnd.isac.fcs", "fcs");
            Use("application/ipfix", "ipfix");
            Use("application/pkix-cert", "cer");
            Use("application/pkixcmp", "pki");
            Use("application/pkix-crl", "crl");
            Use("application/pkix-pkipath", "pkipath");
            Use("application/vnd.insors.igm", "igm");
            Use("application/vnd.ipunplugged.rcprofile", "rcprofile");
            Use("application/vnd.irepository.package+xml", "irp");
            Use("text/vnd.sun.j2me.app-descriptor", "jad");
            Use("application/java-archive", "jar");
            Use("application/java-vm", "class");
            Use("application/x-java-jnlp-file", "jnlp");
            Use("application/java-serialized-object", "ser");
            Use("text/x-java-source,java", "java");
            Use("application/javascript", "js", true);
            Use("application/json", "json");
            Use("application/vnd.joost.joda-archive", "joda");
            Use("video/jpm", "jpm");
            Use("image/jpeg", "jpeg");
            Use("image/jpeg", "jpg");
            Use("image/pjpeg", "pjpeg");
            Use("video/jpeg", "jpgv");
            Use("application/vnd.kahootz", "ktz");
            Use("application/vnd.chipnuts.karaoke-mmd", "mmd");
            Use("application/vnd.kde.karbon", "karbon");
            Use("application/vnd.kde.kchart", "chrt");
            Use("application/vnd.kde.kformula", "kfo");
            Use("application/vnd.kde.kivio", "flw");
            Use("application/vnd.kde.kontour", "kon");
            Use("application/vnd.kde.kpresenter", "kpr");
            Use("application/vnd.kde.kspread", "ksp");
            Use("application/vnd.kde.kword", "kwd");
            Use("application/vnd.kenameaapp", "htke");
            Use("application/vnd.kidspiration", "kia");
            Use("application/vnd.kinar", "kne");
            Use("application/vnd.kodak-descriptor", "sse");
            Use("application/vnd.las.las+xml", "lasxml");
            Use("application/x-latex", "latex");
            Use("application/vnd.llamagraphics.life-balance.desktop", "lbd");
            Use("application/vnd.llamagraphics.life-balance.exchange+xml", "lbe");
            Use("application/vnd.jam", "jam");
            Use("application/vnd.lotus-1-2-3", "123");
            Use("application/vnd.lotus-approach", "apr");
            Use("application/vnd.lotus-freelance", "pre");
            Use("application/vnd.lotus-notes", "nsf");
            Use("application/vnd.lotus-organizer", "org");
            Use("application/vnd.lotus-screencam", "scm");
            Use("application/vnd.lotus-wordpro", "lwp");
            Use("audio/vnd.lucent.voice", "lvp");
            Use("audio/x-mpegurl", "m3u");
            Use("video/x-m4v", "m4v");
            Use("application/mac-binhex40", "hqx");
            Use("application/vnd.macports.portpkg", "portpkg");
            Use("application/vnd.osgeo.mapguide.package", "mgp");
            Use("application/marc", "mrc");
            Use("application/marcxml+xml", "mrcx");
            Use("application/mxf", "mxf");
            Use("application/vnd.wolfram.player", "nbp");
            Use("application/mathematica", "ma");
            Use("application/mathml+xml", "mathml");
            Use("application/mbox", "mbox");
            Use("application/vnd.medcalcdata", "mc1");
            Use("application/mediaservercontrol+xml", "mscml");
            Use("application/vnd.mediastation.cdkey", "cdkey");
            Use("application/vnd.mfer", "mwf");
            Use("application/vnd.mfmp", "mfm");
            Use("model/mesh", "msh");
            Use("application/mads+xml", "mads");
            Use("application/mets+xml", "mets");
            Use("application/mods+xml", "mods");
            Use("application/metalink4+xml", "meta4");
            Use("application/vnd.mcd", "mcd");
            Use("application/vnd.micrografx.flo", "flo");
            Use("application/vnd.micrografx.igx", "igx");
            Use("application/vnd.eszigno3+xml", "es3");
            Use("application/x-msaccess", "mdb");
            Use("video/x-ms-asf", "asf");
            Use("application/x-msdownload", "exe");
            Use("application/vnd.ms-artgalry", "cil");
            Use("application/vnd.ms-cab-compressed", "cab");
            Use("application/vnd.ms-ims", "ims");
            Use("application/x-ms-application", "application");
            Use("application/x-msclip", "clp");
            Use("image/vnd.ms-modi", "mdi");
            Use("application/vnd.ms-fontobject", "eot");
            Use("application/vnd.ms-excel", "xls");
            Use("application/vnd.ms-excel.addin.macroenabled.12", "xlam");
            Use("application/vnd.ms-excel.sheet.binary.macroenabled.12", "xlsb");
            Use("application/vnd.ms-excel.template.macroenabled.12", "xltm");
            Use("application/vnd.ms-excel.sheet.macroenabled.12", "xlsm");
            Use("application/vnd.ms-htmlhelp", "chm");
            Use("application/x-mscardfile", "crd");
            Use("application/vnd.ms-lrm", "lrm");
            Use("application/x-msmediaview", "mvb");
            Use("application/x-msmoney", "mny");
            Use("application/vnd.openxmlformats-officedocument.presentationml.presentation", "pptx");
            Use("application/vnd.openxmlformats-officedocument.presentationml.slide", "sldx");
            Use("application/vnd.openxmlformats-officedocument.presentationml.slideshow", "ppsx");
            Use("application/vnd.openxmlformats-officedocument.presentationml.template", "potx");
            Use("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "xlsx");
            Use("application/vnd.openxmlformats-officedocument.spreadsheetml.template", "xltx");
            Use("application/vnd.openxmlformats-officedocument.wordprocessingml.document", "docx");
            Use("application/vnd.openxmlformats-officedocument.wordprocessingml.template", "dotx");
            Use("application/x-msbinder", "obd");
            Use("application/vnd.ms-officetheme", "thmx");
            Use("application/onenote", "onetoc");
            Use("audio/vnd.ms-playready.media.pya", "pya");
            Use("video/vnd.ms-playready.media.pyv", "pyv");
            Use("application/vnd.ms-powerpoint", "ppt");
            Use("application/vnd.ms-powerpoint.addin.macroenabled.12", "ppam");
            Use("application/vnd.ms-powerpoint.slide.macroenabled.12", "sldm");
            Use("application/vnd.ms-powerpoint.presentation.macroenabled.12", "pptm");
            Use("application/vnd.ms-powerpoint.slideshow.macroenabled.12", "ppsm");
            Use("application/vnd.ms-powerpoint.template.macroenabled.12", "potm");
            Use("application/vnd.ms-project", "mpp");
            Use("application/x-mspublisher", "pub");
            Use("application/x-msschedule", "scd");
            Use("application/x-silverlight-app", "xap");
            Use("application/vnd.ms-pki.stl", "stl");
            Use("application/vnd.ms-pki.seccat", "cat");
            Use("application/vnd.visio", "vsd");
            Use("application/vnd.visio2013", "vsdx");
            Use("video/x-ms-wm", "wm");
            Use("audio/x-ms-wma", "wma");
            Use("audio/x-ms-wax", "wax");
            Use("video/x-ms-wmx", "wmx");
            Use("application/x-ms-wmd", "wmd");
            Use("application/vnd.ms-wpl", "wpl");
            Use("application/x-ms-wmz", "wmz");
            Use("video/x-ms-wmv", "wmv");
            Use("video/x-ms-wvx", "wvx");
            Use("application/x-msmetafile", "wmf");
            Use("application/x-msterminal", "trm");
            Use("application/msword", "doc");
            Use("application/vnd.ms-word.document.macroenabled.12", "docm");
            Use("application/vnd.ms-word.template.macroenabled.12", "dotm");
            Use("application/x-mswrite", "wri");
            Use("application/vnd.ms-works", "wps");
            Use("application/x-ms-xbap", "xbap");
            Use("application/vnd.ms-xpsdocument", "xps");
            Use("audio/midi", "mid");
            Use("application/vnd.ibm.minipay", "mpy");
            Use("application/vnd.ibm.modcap", "afp");
            Use("application/vnd.jcp.javame.midlet-rms", "rms");
            Use("application/vnd.tmobile-livetv", "tmo");
            Use("application/x-mobipocket-ebook", "prc");
            Use("application/vnd.mobius.mbk", "mbk");
            Use("application/vnd.mobius.dis", "dis");
            Use("application/vnd.mobius.plc", "plc");
            Use("application/vnd.mobius.mqy", "mqy");
            Use("application/vnd.mobius.msl", "msl");
            Use("application/vnd.mobius.txf", "txf");
            Use("application/vnd.mobius.daf", "daf");
            Use("text/vnd.fly", "fly");
            Use("application/vnd.mophun.certificate", "mpc");
            Use("application/vnd.mophun.application", "mpn");
            Use("video/mj2", "mj2");
            Use("audio/mpeg", "mpga");
            Use("video/vnd.mpegurl", "mxu");
            Use("video/mpeg", "mpeg");
            Use("application/mp21", "m21");
            Use("audio/mp4", "mp4a");
            Use("video/mp4", "mp4");
            Use("application/vnd.apple.mpegurl", "m3u8");
            Use("application/vnd.musician", "mus");
            Use("application/vnd.muvee.style", "msty");
            Use("application/xv+xml", "mxml");
            Use("application/vnd.nokia.n-gage.data", "ngdat");
            Use("application/vnd.nokia.n-gage.symbian.install", "n-gage");
            Use("application/x-dtbncx+xml", "ncx");
            Use("application/x-netcdf", "nc");
            Use("application/vnd.neurolanguage.nlu", "nlu");
            Use("application/vnd.dna", "dna");
            Use("application/vnd.noblenet-directory", "nnd");
            Use("application/vnd.noblenet-sealer", "nns");
            Use("application/vnd.noblenet-web", "nnw");
            Use("application/vnd.nokia.radio-preset", "rpst");
            Use("application/vnd.nokia.radio-presets", "rpss");
            Use("text/n3", "n3");
            Use("application/vnd.novadigm.edm", "edm");
            Use("application/vnd.novadigm.edx", "edx");
            Use("application/vnd.novadigm.ext", "ext");
            Use("application/vnd.flographit", "gph");
            Use("audio/vnd.nuera.ecelp4800", "ecelp4800");
            Use("audio/vnd.nuera.ecelp7470", "ecelp7470");
            Use("audio/vnd.nuera.ecelp9600", "ecelp9600");
            Use("application/oda", "oda");
            Use("application/ogg", "ogx");
            Use("audio/ogg", "oga");
            Use("video/ogg", "ogv");
            Use("application/vnd.oma.dd2+xml", "dd2");
            Use("application/vnd.oasis.opendocument.text-web", "oth");
            Use("application/oebps-package+xml", "opf");
            Use("application/vnd.intu.qbo", "qbo");
            Use("application/vnd.openofficeorg.extension", "oxt");
            Use("application/vnd.yamaha.openscoreformat", "osf");
            Use("audio/webm", "weba");
            Use("video/webm", "webm");
            Use("application/vnd.oasis.opendocument.chart", "odc");
            Use("application/vnd.oasis.opendocument.chart-template", "otc");
            Use("application/vnd.oasis.opendocument.database", "odb");
            Use("application/vnd.oasis.opendocument.formula", "odf");
            Use("application/vnd.oasis.opendocument.formula-template", "odft");
            Use("application/vnd.oasis.opendocument.graphics", "odg");
            Use("application/vnd.oasis.opendocument.graphics-template", "otg");
            Use("application/vnd.oasis.opendocument.image", "odi");
            Use("application/vnd.oasis.opendocument.image-template", "oti");
            Use("application/vnd.oasis.opendocument.presentation", "odp");
            Use("application/vnd.oasis.opendocument.presentation-template", "otp");
            Use("application/vnd.oasis.opendocument.spreadsheet", "ods");
            Use("application/vnd.oasis.opendocument.spreadsheet-template", "ots");
            Use("application/vnd.oasis.opendocument.text", "odt");
            Use("application/vnd.oasis.opendocument.text-master", "odm");
            Use("application/vnd.oasis.opendocument.text-template", "ott");
            Use("image/ktx", "ktx");
            Use("application/vnd.sun.xml.calc", "sxc");
            Use("application/vnd.sun.xml.calc.template", "stc");
            Use("application/vnd.sun.xml.draw", "sxd");
            Use("application/vnd.sun.xml.draw.template", "std");
            Use("application/vnd.sun.xml.impress", "sxi");
            Use("application/vnd.sun.xml.impress.template", "sti");
            Use("application/vnd.sun.xml.math", "sxm");
            Use("application/vnd.sun.xml.writer", "sxw");
            Use("application/vnd.sun.xml.writer.global", "sxg");
            Use("application/vnd.sun.xml.writer.template", "stw");
            Use("application/x-font-otf", "otf");
            Use("application/vnd.yamaha.openscoreformat.osfpvg+xml", "osfpvg");
            Use("application/vnd.osgi.dp", "dp");
            Use("application/vnd.palm", "pdb");
            Use("text/x-pascal", "p");
            Use("application/vnd.pawaafile", "paw");
            Use("application/vnd.hp-pclxl", "pclxl");
            Use("application/vnd.picsel", "efif");
            Use("image/x-pcx", "pcx");
            Use("image/vnd.adobe.photoshop", "psd");
            Use("application/pics-rules", "prf");
            Use("image/x-pict", "pic");
            Use("application/x-chat", "chat");
            Use("application/pkcs10", "p10");
            Use("application/x-pkcs12", "p12");
            Use("application/pkcs7-mime", "p7m");
            Use("application/pkcs7-signature", "p7s");
            Use("application/x-pkcs7-certreqresp", "p7r");
            Use("application/x-pkcs7-certificates", "p7b");
            Use("application/pkcs8", "p8");
            Use("application/vnd.pocketlearn", "plf");
            Use("image/x-portable-anymap", "pnm");
            Use("image/x-portable-bitmap", "pbm");
            Use("application/x-font-pcf", "pcf");
            Use("application/font-tdpfr", "pfr");
            Use("application/x-chess-pgn", "pgn");
            Use("image/x-portable-graymap", "pgm");
            Use("image/png", "png");
            Use("image/x-portable-pixmap", "ppm");
            Use("application/pskc+xml", "pskcxml");
            Use("application/vnd.ctc-posml", "pml");
            Use("application/postscript", "ai");
            Use("application/x-font-type1", "pfa");
            Use("application/vnd.powerbuilder6", "pbd");
            Use("application/pgp-encrypted", "pgp");
            Use("application/vnd.previewsystems.box", "box");
            Use("application/vnd.pvi.ptid1", "ptid");
            Use("application/pls+xml", "pls");
            Use("application/vnd.pg.format", "str");
            Use("application/vnd.pg.osasli", "ei6");
            Use("text/prs.lines.tag", "dsc");
            Use("application/x-font-linux-psf", "psf");
            Use("application/vnd.publishare-delta-tree", "qps");
            Use("application/vnd.pmi.widget", "wg");
            Use("application/vnd.quark.quarkxpress", "qxd");
            Use("application/vnd.epson.esf", "esf");
            Use("application/vnd.epson.msf", "msf");
            Use("application/vnd.epson.ssf", "ssf");
            Use("application/vnd.epson.quickanime", "qam");
            Use("application/vnd.intu.qfx", "qfx");
            Use("video/quicktime", "qt");
            Use("application/x-rar-compressed", "rar");
            Use("audio/x-pn-realaudio", "ram");
            Use("audio/x-pn-realaudio-plugin", "rmp");
            Use("application/rsd+xml", "rsd");
            Use("application/vnd.rn-realmedia", "rm");
            Use("application/vnd.realvnc.bed", "bed");
            Use("application/vnd.recordare.musicxml", "mxl");
            Use("application/vnd.recordare.musicxml+xml", "musicxml");
            Use("application/relax-ng-compact-syntax", "rnc");
            Use("application/vnd.data-vision.rdz", "rdz");
            Use("application/rdf+xml", "rdf");
            Use("application/vnd.cloanto.rp9", "rp9");
            Use("application/vnd.jisp", "jisp");
            Use("application/rtf", "rtf");
            Use("text/richtext", "rtx");
            Use("application/vnd.route66.link66+xml", "link66");
            Use("application/rss+xml", "rss, .xml");
            Use("application/shf+xml", "shf");
            Use("application/vnd.sailingtracker.track", "st");
            Use("image/svg+xml", "svg");
            Use("application/vnd.sus-calendar", "sus");
            Use("application/sru+xml", "sru");
            Use("application/set-payment-initiation", "setpay");
            Use("application/set-registration-initiation", "setreg");
            Use("application/vnd.sema", "sema");
            Use("application/vnd.semd", "semd");
            Use("application/vnd.semf", "semf");
            Use("application/vnd.seemail", "see");
            Use("application/x-font-snf", "snf");
            Use("application/scvp-vp-request", "spq");
            Use("application/scvp-vp-response", "spp");
            Use("application/scvp-cv-request", "scq");
            Use("application/scvp-cv-response", "scs");
            Use("application/sdp", "sdp");
            Use("text/x-setext", "etx");
            Use("video/x-sgi-movie", "movie");
            Use("application/vnd.shana.informed.formdata", "ifm");
            Use("application/vnd.shana.informed.formtemplate", "itp");
            Use("application/vnd.shana.informed.interchange", "iif");
            Use("application/vnd.shana.informed.package", "ipk");
            Use("application/thraud+xml", "tfi");
            Use("application/x-shar", "shar");
            Use("image/x-rgb", "rgb");
            Use("application/vnd.epson.salt", "slt");
            Use("application/vnd.accpac.simply.aso", "aso");
            Use("application/vnd.accpac.simply.imp", "imp");
            Use("application/vnd.simtech-mindmapper", "twd");
            Use("application/vnd.commonspace", "csp");
            Use("application/vnd.yamaha.smaf-audio", "saf");
            Use("application/vnd.smaf", "mmf");
            Use("application/vnd.yamaha.smaf-phrase", "spf");
            Use("application/vnd.smart.teacher", "teacher");
            Use("application/vnd.svd", "svd");
            Use("application/sparql-query", "rq");
            Use("application/sparql-results+xml", "srx");
            Use("application/srgs", "gram");
            Use("application/srgs+xml", "grxml");
            Use("application/ssml+xml", "ssml");
            Use("application/vnd.koan", "skp");
            Use("text/sgml", "sgml");
            Use("application/vnd.stardivision.calc", "sdc");
            Use("application/vnd.stardivision.draw", "sda");
            Use("application/vnd.stardivision.impress", "sdd");
            Use("application/vnd.stardivision.math", "smf");
            Use("application/vnd.stardivision.writer", "sdw");
            Use("application/vnd.stardivision.writer-global", "sgl");
            Use("application/vnd.stepmania.stepchart", "sm");
            Use("application/x-stuffit", "sit");
            Use("application/x-stuffitx", "sitx");
            Use("application/vnd.solent.sdkm+xml", "sdkm");
            Use("application/vnd.olpc-sugar", "xo");
            Use("audio/basic", "au");
            Use("application/vnd.wqd", "wqd");
            Use("application/vnd.symbian.install", "sis");
            Use("application/smil+xml", "smi");
            Use("application/vnd.syncml+xml", "xsm");
            Use("application/vnd.syncml.dm+wbxml", "bdm");
            Use("application/vnd.syncml.dm+xml", "xdm");
            Use("application/x-sv4cpio", "sv4cpio");
            Use("application/x-sv4crc", "sv4crc");
            Use("application/sbml+xml", "sbml");
            Use("text/tab-separated-values", "tsv");
            Use("image/tiff", "tiff");
            Use("application/vnd.tao.intent-module-archive", "tao");
            Use("application/x-tar", "tar");
            Use("application/x-tcl", "tcl");
            Use("application/x-tex", "tex");
            Use("application/x-tex-tfm", "tfm");
            Use("application/tei+xml", "tei");
            Use("text/plain", "txt");
            Use("application/vnd.spotfire.dxp", "dxp");
            Use("application/vnd.spotfire.sfs", "sfs");
            Use("application/timestamped-data", "tsd");
            Use("application/vnd.trid.tpt", "tpt");
            Use("application/vnd.triscape.mxs", "mxs");
            Use("text/troff", "t");
            Use("application/vnd.trueapp", "tra");
            Use("application/x-font-ttf", "ttf");
            Use("text/turtle", "ttl");
            Use("application/vnd.umajin", "umj");
            Use("application/vnd.uoml+xml", "uoml");
            Use("application/vnd.unity", "unityweb");
            Use("application/vnd.ufdl", "ufd");
            Use("text/uri-list", "uri");
            Use("application/vnd.uiq.theme", "utz");
            Use("application/x-ustar", "ustar");
            Use("text/x-uuencode", "uu");
            Use("text/x-vcalendar", "vcs");
            Use("text/x-vcard", "vcf");
            Use("application/x-cdlink", "vcd");
            Use("application/vnd.vsf", "vsf");
            Use("model/vrml", "wrl");
            Use("application/vnd.vcx", "vcx");
            Use("model/vnd.mts", "mts");
            Use("model/vnd.vtu", "vtu");
            Use("application/vnd.visionary", "vis");
            Use("video/vnd.vivo", "viv");
            Use("application/ccxml+xml,", "ccxml");
            Use("application/voicexml+xml", "vxml");
            Use("application/x-wais-source", "src");
            Use("application/vnd.wap.wbxml", "wbxml");
            Use("image/vnd.wap.wbmp", "wbmp");
            Use("audio/x-wav", "wav");
            Use("application/davmount+xml", "davmount");
            Use("font/woff", "woff");
            Use("font/woff2", "woff2");
            Use("application/wspolicy+xml", "wspolicy");
            Use("image/webp", "webp");
            Use("application/vnd.webturbo", "wtb");
            Use("application/widget", "wgt");
            Use("application/winhlp", "hlp");
            Use("text/vnd.wap.wml", "wml");
            Use("text/vnd.wap.wmlscript", "wmls");
            Use("application/vnd.wap.wmlscriptc", "wmlsc");
            Use("application/vnd.wordperfect", "wpd");
            Use("application/vnd.wt.stf", "stf");
            Use("application/wsdl+xml", "wsdl");
            Use("image/x-xbitmap", "xbm");
            Use("image/x-xpixmap", "xpm");
            Use("image/x-xwindowdump", "xwd");
            Use("application/x-x509-ca-cert", "der");
            Use("application/x-xfig", "fig");
            Use("application/xhtml+xml", "xhtml");
            Use("application/xml", "xml");
            Use("application/xcap-diff+xml", "xdf");
            Use("application/xenc+xml", "xenc");
            Use("application/patch-ops-error+xml", "xer");
            Use("application/resource-lists+xml", "rl");
            Use("application/rls-services+xml", "rs");
            Use("application/resource-lists-diff+xml", "rld");
            Use("application/xslt+xml", "xslt");
            Use("application/xop+xml", "xop");
            Use("application/x-xpinstall", "xpi");
            Use("application/xspf+xml", "xspf");
            Use("application/vnd.mozilla.xul+xml", "xul");
            Use("chemical/x-xyz", "xyz");
            Use("text/yaml", "yaml");
            Use("application/yang", "yang");
            Use("application/yin+xml", "yin");
            Use("application/vnd.zul", "zir");
            Use("application/zip", "zip");
            Use("application/vnd.handheld-entertainment+xml", "zmm");
            Use("application/vnd.zzazz.deck+xml", "zaz");
        }
      
        protected virtual bool IsSupported(IContentInfo content)
        {
            return true;
        }

        protected void Use(string mimeType, string extension, bool allowBundling = false)
        {
            var content = new DefaultContentInfo(mimeType, extension, allowBundling);

            if (IsSupported(content))
            {
                SupportedContent.Add(content);
            }
        }

    }
}