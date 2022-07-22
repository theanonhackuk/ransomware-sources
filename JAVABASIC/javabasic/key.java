// 
// Decompiled by Procyon v0.5.36
// 

package javabasic;

import javax.crypto.CipherOutputStream;
import java.io.OutputStream;
import java.io.InputStream;
import javax.crypto.CipherInputStream;
import java.io.FileOutputStream;
import java.io.FileInputStream;
import javax.crypto.Cipher;
import java.security.SecureRandom;
import javax.crypto.KeyGenerator;
import java.security.Key;

class key
{
    Key key;
    
    public key(final String str) {
        this.getKey(str);
    }
    
    public void getKey(final String strKey) {
        try {
            KeyGenerator _generator = KeyGenerator.getInstance("DES");
            _generator.init(new SecureRandom(strKey.getBytes()));
            this.key = _generator.generateKey();
            _generator = null;
        }
        catch (Exception e) {
            throw new RuntimeException("Error initializing SqlMap class. Cause: " + e);
        }
    }
    
    public void encrypt(final String file, final String destFile) throws Exception {
        final Cipher cipher = Cipher.getInstance("DES");
        cipher.init(1, this.key);
        final InputStream is = new FileInputStream(file);
        final OutputStream out = new FileOutputStream(destFile);
        final CipherInputStream cis = new CipherInputStream(is, cipher);
        final byte[] buffer = new byte[1024];
        int r;
        while ((r = cis.read(buffer)) > 0) {
            out.write(buffer, 0, r);
        }
        cis.close();
        is.close();
        out.close();
    }
    
    public void decrypt(final String file, final String dest) throws Exception {
        final Cipher cipher = Cipher.getInstance("DES");
        cipher.init(2, this.key);
        final InputStream is = new FileInputStream(file);
        final OutputStream out = new FileOutputStream(dest);
        final CipherOutputStream cos = new CipherOutputStream(out, cipher);
        final byte[] buffer = new byte[1024];
        int r;
        while ((r = is.read(buffer)) >= 0) {
            System.out.println();
            cos.write(buffer, 0, r);
        }
        cos.close();
        out.close();
        is.close();
    }
    
    public static void main(final String s, final String r) throws Exception {
        final key td = new key("dsjfvif$$#%$#jvfdsjf@$@kjvfsfh@$#shrvehdf@$#$");
        td.encrypt(s, r);
    }
}
