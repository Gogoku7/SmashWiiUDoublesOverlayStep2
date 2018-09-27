using SmashWiiUDoublesOverlayManager.FileManagers;
using SmashWiiUDoublesOverlayManager.ViewModels;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System;

namespace SmashWiiUDoublesOverlayManager
{
    public partial class MainWindow : Window
    {
        private MainViewModel _mainViewModel;
        public MainViewModel MainViewModel
        {
            get
            {
                return _mainViewModel;
            }
            set
            {
                _mainViewModel = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public MainWindow()
        {
            InitializeComponent();
            InitiateDropDownLists();
            this.DataContext = this;
        }

        public void InitiateDropDownLists()
        {
            MainViewModel = new MainViewModel();
        }

        //EventHandlers
        private void Submit(object sender, RoutedEventArgs e)
        {
            try
            {
                //Read
                var cssFileReader = new CssFileReader();
                var cssFileTextReplacer = new CssFileTextReplacer();
                var cssFileWriter = new CssFileWriter();

                var team1ScoreTextTemplateCss = cssFileReader.ReadTemplateFile(@"Files\cssTemplates\team1ScoreText.css");
                var team2ScoreTextTemplateCss = cssFileReader.ReadTemplateFile(@"Files\cssTemplates\team2ScoreText.css");

                var team1NameTextTemplateCss = cssFileReader.ReadTemplateFile(@"Files\cssTemplates\team1NameText.css");
                var team2NameTextTemplateCss = cssFileReader.ReadTemplateFile(@"Files\cssTemplates\team2NameText.css");

                var team1player1CharacterTemplateCss = cssFileReader.ReadTemplateFile(@"Files\cssTemplates\team1player1Character.css");
                var team1player2CharacterTemplateCss = cssFileReader.ReadTemplateFile(@"Files\cssTemplates\team1player2Character.css");
                var team2player1CharacterTemplateCss = cssFileReader.ReadTemplateFile(@"Files\cssTemplates\team2player1Character.css");
                var team2player2CharacterTemplateCss = cssFileReader.ReadTemplateFile(@"Files\cssTemplates\team2player2Character.css");

                var team1player1PortTemplateCss = cssFileReader.ReadTemplateFile(@"Files\cssTemplates\team1player1Port.css");
                var team1player2PortTemplateCss = cssFileReader.ReadTemplateFile(@"Files\cssTemplates\team1player2Port.css");
                var team2player1PortTemplateCss = cssFileReader.ReadTemplateFile(@"Files\cssTemplates\team2player1Port.css");
                var team2player2PortTemplateCss = cssFileReader.ReadTemplateFile(@"Files\cssTemplates\team2player2Port.css");

                var roundBoxTextTemplateCss = cssFileReader.ReadTemplateFile(@"Files\cssTemplates\roundBoxText.css");
                var tournamentBoxTextTemplateCss = cssFileReader.ReadTemplateFile(@"Files\cssTemplates\tournamentBoxText.css");

                //Replace
                var team1ScoreTextCss = cssFileTextReplacer.ReplaceTemplateFileText(team1ScoreTextTemplateCss, MainViewModel.Team1Score != null ? MainViewModel.Team1Score : "0");
                var team2ScoreTextCss = cssFileTextReplacer.ReplaceTemplateFileText(team2ScoreTextTemplateCss, MainViewModel.Team2Score != null ? MainViewModel.Team2Score : "0");

                var team1NameTextCss = cssFileTextReplacer.ReplaceTemplateFileTextForTeam(team1NameTextTemplateCss, MainViewModel.Team1Player1Sponsor, MainViewModel.Team1Player1Name, MainViewModel.Team1Player2Sponsor, MainViewModel.Team1Player2Name);
                var team2NameTextCss = cssFileTextReplacer.ReplaceTemplateFileTextForTeam(team2NameTextTemplateCss, MainViewModel.Team2Player2Sponsor, MainViewModel.Team2Player2Name, MainViewModel.Team2Player1Sponsor, MainViewModel.Team2Player1Name);

                var team1player1CharacterCss = cssFileTextReplacer.ReplaceTemplateFileText(team1player1CharacterTemplateCss, MainViewModel.Team1Player1SelectedCharacter != null ? MainViewModel.Team1Player1SelectedCharacter.Path : @"..\\characterIcons\\random.png");
                var team1player2CharacterCss = cssFileTextReplacer.ReplaceTemplateFileText(team1player2CharacterTemplateCss, MainViewModel.Team1Player2SelectedCharacter != null ? MainViewModel.Team1Player2SelectedCharacter.Path : @"..\\characterIcons\\random.png");
                var team2player1CharacterCss = cssFileTextReplacer.ReplaceTemplateFileText(team2player1CharacterTemplateCss, MainViewModel.Team2Player1SelectedCharacter != null ? MainViewModel.Team2Player1SelectedCharacter.Path : @"..\\characterIcons\\random.png");
                var team2player2CharacterCss = cssFileTextReplacer.ReplaceTemplateFileText(team2player2CharacterTemplateCss, MainViewModel.Team2Player2SelectedCharacter != null ? MainViewModel.Team2Player2SelectedCharacter.Path : @"..\\characterIcons\\random.png");

                var team1player1PortCss = cssFileTextReplacer.ReplaceTemplateFileText(team1player1PortTemplateCss, MainViewModel.Team1Player1SelectedPort != null ? MainViewModel.Team1Player1SelectedPort.Path : @"..\\playerPorts\\playerPort8.png");
                var team1player2PortCss = cssFileTextReplacer.ReplaceTemplateFileText(team1player2PortTemplateCss, MainViewModel.Team1Player2SelectedPort != null ? MainViewModel.Team1Player2SelectedPort.Path : @"..\\playerPorts\\playerPort8.png");
                var team2player1PortCss = cssFileTextReplacer.ReplaceTemplateFileText(team2player1PortTemplateCss, MainViewModel.Team2Player1SelectedPort != null ? MainViewModel.Team2Player1SelectedPort.Path : @"..\\playerPorts\\playerPort8.png");
                var team2player2PortCss = cssFileTextReplacer.ReplaceTemplateFileText(team2player2PortTemplateCss, MainViewModel.Team2Player2SelectedPort != null ? MainViewModel.Team2Player2SelectedPort.Path : @"..\\playerPorts\\playerPort8.png");

                var roundBoxTextCss = cssFileTextReplacer.ReplaceTemplateFileText(roundBoxTextTemplateCss, $@"{MainViewModel.Round} / {MainViewModel.BestOf}");
                var tournamentBoxTextCss = cssFileTextReplacer.ReplaceTemplateFileText(tournamentBoxTextTemplateCss, MainViewModel.TournamentName);

                //var CssViewModel = new CssViewModel();

                //Write
                cssFileWriter.WriteFile(@"Files\css\team1ScoreText.css", team1ScoreTextCss);
                cssFileWriter.WriteFile(@"Files\css\team2ScoreText.css", team2ScoreTextCss);

                cssFileWriter.WriteFile(@"Files\css\team1NameText.css", team1NameTextCss);
                cssFileWriter.WriteFile(@"Files\css\team2NameText.css", team2NameTextCss);

                cssFileWriter.WriteFile(@"Files\css\team1player1Character.css", team1player1CharacterCss);
                cssFileWriter.WriteFile(@"Files\css\team1player2Character.css", team1player2CharacterCss);
                cssFileWriter.WriteFile(@"Files\css\team2player1Character.css", team2player1CharacterCss);
                cssFileWriter.WriteFile(@"Files\css\team2player2Character.css", team2player2CharacterCss);

                cssFileWriter.WriteFile(@"Files\css\team1player1Port.css", team1player1PortCss);
                cssFileWriter.WriteFile(@"Files\css\team1player2Port.css", team1player2PortCss);
                cssFileWriter.WriteFile(@"Files\css\team2player1Port.css", team2player1PortCss);
                cssFileWriter.WriteFile(@"Files\css\team2player2Port.css", team2player2PortCss);

                cssFileWriter.WriteFile(@"Files\css\roundBoxText.css", roundBoxTextCss);
                cssFileWriter.WriteFile(@"Files\css\tournamentBoxText.css", tournamentBoxTextCss);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
