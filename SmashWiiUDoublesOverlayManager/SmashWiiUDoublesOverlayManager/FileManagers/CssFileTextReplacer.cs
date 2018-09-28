using System;

namespace SmashWiiUDoublesOverlayManager.FileManagers
{
    public class CssFileTextReplacer
    {
        public string ReplaceTemplateFileText(string templateCss, string cssValue)
        {
            if (templateCss == null)
            {
                throw new ArgumentException(nameof(templateCss));
            }
            if (string.IsNullOrEmpty(cssValue))
            {
                cssValue = "";
            }
            try
            {
                return templateCss.Replace("PLACEHOLDER", cssValue);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public string ReplaceTemplateFileTextForTeam(string cssteamNameTextTemplateCss, string player1Sponsor, string player1Name, string player2Sponsor, string player2Name)
        {
            string player1FullName;
            string player2FullName;
            if (string.IsNullOrEmpty(player1Name))
            {
                player1Name = "???";
            }
            if (string.IsNullOrEmpty(player1Name))
            {
                player2Name = "???";
            }
            if (string.IsNullOrEmpty(player1Sponsor))
            {
                player1FullName = player1Name;
            }
            else
            {
                player1FullName = $"{player1Sponsor} | {player1Name}";
            }
            if (string.IsNullOrEmpty(player2Sponsor))
            {
                player2FullName = player2Name;
            }
            else
            {
                player2FullName = $"{player2Sponsor} | {player2Name}";
            }

            return cssteamNameTextTemplateCss.Replace("PLACEHOLDER", $"{player1FullName} + {player2FullName}");
        }
    }
}
