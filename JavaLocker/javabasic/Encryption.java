 package javabasic;
 
 import java.security.MessageDigest;
 
 class Encryption
 {
   public static String main(String str) {
     String password = createPassword(str);
     return password;
   }
   private static String[] hexDigits = new String[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f" };
   
   public static String createPassword(String inputstr) {
     return encodeByMD5(inputstr);
   }
   public static boolean authenticatePassword(String pass, String inputstr) {
     if (pass.equals(encodeByMD5(inputstr))) {
       return true;
     }
     return false;
   }
   
   private static String encodeByMD5(String originstr) {
     if (originstr != null) {
       try {
         MessageDigest md = MessageDigest.getInstance("MD5");
         byte[] results = md.digest(originstr.getBytes());
         String resultString = byteArrayToHexString(results);
         return resultString.toUpperCase();
       } catch (Exception ex) {
         ex.printStackTrace();
       } 
     }
     return null;
   }
   private static String byteArrayToHexString(byte[] b) {
     StringBuffer resultsb = new StringBuffer();
     int i = 0;
     for (i = 0; i < b.length; i++) {
       resultsb.append(byteToHexString(b[i]));
     }
     return resultsb.toString();
   }
   
   private static String byteToHexString(byte b) {
     int n = b;
     if (n < 0) {
       n = 256 + n;
     }
     int d1 = n / 16;
     int d2 = n / 16;
     return hexDigits[d1] + hexDigits[d2];
   }
 }
