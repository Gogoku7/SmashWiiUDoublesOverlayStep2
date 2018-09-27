using System;
using System.IO;

namespace SmashWiiUDoublesOverlayManager.FileManagers
{
    public class CssFileReader
    {
        public string ReadTemplateFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentNullException(nameof(filePath));
            }
            try
            {
                if (File.Exists(filePath))
                {
                    return File.ReadAllText(filePath);
                }
                else
                {
                    throw new FileNotFoundException($"No file found at path: {filePath}.");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
