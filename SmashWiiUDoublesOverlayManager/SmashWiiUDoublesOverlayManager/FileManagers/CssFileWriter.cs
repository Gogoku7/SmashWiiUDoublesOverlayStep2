using System;
using System.IO;

namespace SmashWiiUDoublesOverlayManager.FileManagers
{
    public class CssFileWriter
    {
        public void WriteFile(string filePath, string cssText)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentNullException(filePath);
            }
            try
            {
                File.WriteAllText(filePath, cssText);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
