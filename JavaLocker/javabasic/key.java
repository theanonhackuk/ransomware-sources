 package javabasic;
 
 import java.io.FileInputStream;
 import java.io.FileOutputStream;
 import java.io.InputStream;
 import java.io.OutputStream;
 import java.security.Key;
 import java.security.SecureRandom;
 import javax.crypto.Cipher;
 import javax.crypto.CipherInputStream;
 import javax.crypto.CipherOutputStream;
 import javax.crypto.KeyGenerator;
 
 class key
 {
   Key key;
   
   public key(String str) {
     getKey(str);
   }
 
 
   
   public void getKey(String strKey) {
     try {
       KeyGenerator _generator = KeyGenerator.getInstance("DES");
       _generator.init(new SecureRandom(strKey.getBytes()));
       this.key = _generator.generateKey();
       _generator = null;
     } catch (Exception e) {
       throw new RuntimeException("Error initializing SqlMap class. Cause: " + e);
     } 
   }

   public void encrypt(String file, String destFile) throws Exception {
     Cipher cipher = Cipher.getInstance("DES");
     
     cipher.init(1, this.key);
     InputStream is = new FileInputStream(file);
     OutputStream out = new FileOutputStream(destFile);
     CipherInputStream cis = new CipherInputStream(is, cipher);
     byte[] buffer = new byte[1024];
     int r;
     while ((r = cis.read(buffer)) > 0) {
       out.write(buffer, 0, r);
     }
     cis.close();
     is.close();
     out.close();
   }
 
   public void decrypt(String file, String dest) throws Exception {
     Cipher cipher = Cipher.getInstance("DES");
     cipher.init(2, this.key);
     InputStream is = new FileInputStream(file);
     OutputStream out = new FileOutputStream(dest);
     CipherOutputStream cos = new CipherOutputStream(out, cipher);
     byte[] buffer = new byte[1024];
     int r;
     while ((r = is.read(buffer)) >= 0) {
       System.out.println();
       cos.write(buffer, 0, r);
     } 
     cos.close();
     out.close();
     is.close();
   }
   
   public static void main(String s, String r) throws Exception {
     key td = new key("dsjfvif$$#%$#jvfdsjf@$@kjvfsfh@$#shrvehdf@$#$");
     td.encrypt(s, r);
   }
 }
