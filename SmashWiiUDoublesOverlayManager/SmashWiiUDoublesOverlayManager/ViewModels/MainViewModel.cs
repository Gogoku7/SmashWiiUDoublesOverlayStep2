using SmashWiiUDoublesOverlayManager.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SmashWiiUDoublesOverlayManager.ViewModels
{
    public class MainViewModel
    {
        private string _team1Player1Name;
        public string Team1Player1Name
        {
            get
            {
                return _team1Player1Name;
            }
            set
            {
                _team1Player1Name = value;
                OnPropertyChanged();
            }
        }

        private string _team1Player2Name;
        public string Team1Player2Name
        {
            get
            {
                return _team1Player2Name;
            }
            set
            {
                _team1Player2Name = value;
                OnPropertyChanged();
            }
        }

        private string _team2Player1Name;
        public string Team2Player1Name
        {
            get
            {
                return _team2Player1Name;
            }
            set
            {
                _team2Player1Name = value;
                OnPropertyChanged();
            }
        }

        private string _team2Player2Name;
        public string Team2Player2Name
        {
            get
            {
                return _team2Player2Name;
            }
            set
            {
                _team2Player2Name = value;
                OnPropertyChanged();
            }
        }

        private string _team1Player1Sponsor;
        public string Team1Player1Sponsor
        {
            get
            {
                return _team1Player1Sponsor;
            }
            set
            {
                _team1Player1Sponsor = value;
                OnPropertyChanged();
            }
        }

        private string _team1Player2Sponsor;
        public string Team1Player2Sponsor
        {
            get
            {
                return _team1Player2Sponsor;
            }
            set
            {
                _team1Player2Sponsor = value;
                OnPropertyChanged();
            }
        }

        private string _team2Player1Sponsor;
        public string Team2Player1Sponsor
        {
            get
            {
                return _team2Player1Sponsor;
            }
            set
            {
                _team2Player1Sponsor = value;
                OnPropertyChanged();
            }
        }

        private string _team2Player2Sponsor;
        public string Team2Player2Sponsor
        {
            get
            {
                return _team2Player2Sponsor;
            }
            set
            {
                _team2Player2Sponsor = value;
                OnPropertyChanged();
            }
        }

        private string _team1Player1Twitter;
        public string Team1Player1Twitter
        {
            get
            {
                return _team1Player1Twitter;
            }
            set
            {
                _team1Player1Twitter = value;
                OnPropertyChanged();
            }
        }

        private string _team1Player2Twitter;
        public string Team1Player2Twitter
        {
            get
            {
                return _team1Player2Twitter;
            }
            set
            {
                _team1Player2Twitter = value;
                OnPropertyChanged();
            }
        }

        private string _team2Player2Twitter;
        public string Team2Player2Twitter
        {
            get
            {
                return _team2Player2Twitter;
            }
            set
            {
                _team2Player2Twitter = value;
                OnPropertyChanged();
            }
        }

        private string _team1Score;
        public string Team1Score
        {
            get
            {
                return _team1Score;
            }
            set
            {
                _team1Score = value;
                OnPropertyChanged();
            }
        }

        private string _team2Score;
        public string Team2Score
        {
            get
            {
                return _team2Score;
            }
            set
            {
                _team2Score = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Character> _characterList;
        public ObservableCollection<Character> CharacterList
        {
            get
            {
                return _characterList;
            }
            set
            {
                _characterList = value;
                OnPropertyChanged();
            }
        }

        private Character _team1Player1SelectedCharacter;
        public Character Team1Player1SelectedCharacter
        {
            get
            {
                return _team1Player1SelectedCharacter;
            }
            set
            {
                _team1Player1SelectedCharacter = value;
                OnPropertyChanged();
            }
        }

        private Character _team1player2SelectedCharacter;
        public Character Team1Player2SelectedCharacter
        {
            get
            {
                return _team1player2SelectedCharacter;
            }
            set
            {
                _team1player2SelectedCharacter = value;
                OnPropertyChanged();
            }
        }

        private Character _team2Player1SelectedCharacter;
        public Character Team2Player1SelectedCharacter
        {
            get
            {
                return _team2Player1SelectedCharacter;
            }
            set
            {
                _team2Player1SelectedCharacter = value;
                OnPropertyChanged();
            }
        }

        private Character _team2Player2SelectedCharacter;
        public Character Team2Player2SelectedCharacter
        {
            get
            {
                return _team2Player2SelectedCharacter;
            }
            set
            {
                _team2Player2SelectedCharacter = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Port> _portList;
        public ObservableCollection<Port> PortList
        {
            get
            {
                return _portList;
            }
            set
            {
                _portList = value;
                OnPropertyChanged();
            }
        }

        private Port _team1player1SelectedPort;
        public Port Team1Player1SelectedPort
        {
            get
            {
                return _team1player1SelectedPort;
            }
            set
            {
                _team1player1SelectedPort = value;
                OnPropertyChanged();
            }
        }

        private Port _team1player2SelectedPort;
        public Port Team1Player2SelectedPort
        {
            get
            {
                return _team1player2SelectedPort;
            }
            set
            {
                _team1player2SelectedPort = value;
                OnPropertyChanged();
            }
        }

        private Port _team2player1SelectedPort;
        public Port Team2Player1SelectedPort
        {
            get
            {
                return _team2player1SelectedPort;
            }
            set
            {
                _team2player1SelectedPort = value;
                OnPropertyChanged();
            }
        }

        private Port _team2player2SelectedPort;
        public Port Team2Player2SelectedPort
        {
            get
            {
                return _team2player2SelectedPort;
            }
            set
            {
                _team2player2SelectedPort = value;
                OnPropertyChanged();
            }
        }

        private string _tournamentName;
        public string TournamentName
        {
            get
            {
                return _tournamentName;
            }
            set
            {
                _tournamentName = value;
                OnPropertyChanged();
            }
        }

        private string _round;
        public string Round
        {
            get
            {
                return _round;
            }
            set
            {
                _round = value;
                OnPropertyChanged();
            }
        }

        private string _bestOf;
        public string BestOf
        {
            get
            {
                return _bestOf;
            }
            set
            {
                _bestOf = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public MainViewModel()
        {
            CharacterList = Character.InitiateSmashWiiUCharacterList();
            PortList = Port.InitiateSmashWiiUPortList();
        }

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
