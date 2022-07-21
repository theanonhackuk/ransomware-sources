import javax.crypto.IllegalBlockSizeException;
import java.security.NoSuchAlgorithmException;
import javax.crypto.NoSuchPaddingException;
import java.security.InvalidKeyException;
import javax.crypto.BadPaddingException;
import javax.crypto.spec.SecretKeySpec;
import javax.crypto.SecretKey;
import javax.crypto.Cipher;
import java.util.*;
import java.io.*;

public class CryptoUtils {
  // encryption settings
  private static final String ALGORITHM = "AES";
  private static final String TRANSFORMATION = "AES";
  // encrypt method
  public static void encrypt(String key, File inputFile, File outputFile) throws CryptoException {
    doCrypto(Cipher.ENCRYPT_MODE, key, inputFile, outputFile);
  }

  // decrypt method
  public static void decrypt(String key, File inputFile, File outputFile) throws CryptoException {
    doCrypto(Cipher.DECRYPT_MODE, key, inputFile, outputFile);
  }

  // do Crypto handler
  private static void doCrypto(int cipherMode, String key, File inputFile, File outputFile) throws CryptoException {
    try {
      // init process of c
      SecretKeySpec secretKey = new SecretKeySpec(key.getBytes(), ALGORITHM);
      Cipher cipher = Cipher.getInstance(TRANSFORMATION);
      cipher.init(cipherMode, secretKey);
      // generating file streams
      FileInputStream inputStream = new FileInputStream(inputFile);
      byte[] inputBytes = new byte[(int) inputFile.length()];
      inputStream.read(inputBytes);
      // same but for output
      byte[] outputBytes = cipher.doFinal(inputBytes);
      FileOutputStream outputStream = new FileOutputStream(outputFile);
      outputStream.write(outputBytes);
      // closing streams
      inputStream.close();
      outputStream.close();
    } catch(NoSuchPaddingException | NoSuchAlgorithmException | InvalidKeyException | BadPaddingException | IllegalBlockSizeException | IOException ex) {
        throw new CryptoException("Error encrypting/decrypting file", ex);
    }
  }
}
