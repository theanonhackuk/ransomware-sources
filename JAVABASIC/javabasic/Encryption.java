import java.security.MessageDigest;

class Encryption {
   private static String[] hexDigits = new String[]{"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f"};

   public static String main(String str) {
      String password = createPassword(str);
      return password;
   }

   public static String createPassword(String inputstr) {
      return encodeByMD5(inputstr);
   }

   public static boolean authenticatePassword(String pass, String inputstr) {
      return pass.equals(encodeByMD5(inputstr));
   }

   private static String encodeByMD5(String originstr) {
      if (originstr != null) {
         try {
            MessageDigest md = MessageDigest.getInstance("MD5");
            byte[] results = md.digest(originstr.getBytes());
            String resultString = byteArrayToHexString(results);
            return resultString.toUpperCase();
         } catch (Exception var4) {
            var4.printStackTrace();
         }
      }

      return null;
   }

   private static String byteArrayToHexString(byte[] b) {
      StringBuffer resultsb = new StringBuffer();
      int i = false;

      for(int i = 0; i < b.length; ++i) 
      {
         resultsb.append(byteToHexString(b[i]));
      }

      return resultsb.toString();
   }

   private static String byteToHexString(byte b) {
      int n = b;
      if (b < 0) {
         n = 256 + b;
      }

      int d1 = n / 16;
      int d2 = n / 16;
      return hexDigits[d1] + hexDigits[d2];
   }
}
