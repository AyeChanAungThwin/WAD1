using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WindowsAppDevelopmentVM
{
    public class MainVM: ViewModelBase
    {
        private string _textOutput = "Hello";

        public string TextOutput
        {
            get => _textOutput;
            set
            {
                _textOutput = value;
                OnPropertyChanged();
            }
        }

        private string _inputText;

        public string InputText
        {
            get => _inputText;

            set
            {
                _inputText = value;
                OnPropertyChanged();
            }
        }

        private bool _englishCheck = true;

        public bool EnglishCheck
        {
            get => _englishCheck;
            set
            {
                _englishCheck = value;
                OnPropertyChanged();
            }
        }
        
        private bool _myanmarCheck;

        public bool MyanmarCheck
        {
            get => _myanmarCheck;
            set
            {
                _myanmarCheck = value;
                OnPropertyChanged();
            }
        }
        
        private bool _chineseCheck;

        public bool ChineseCheck
        {
            get => _chineseCheck;
            set
            {
                _chineseCheck = value;
                OnPropertyChanged();
            }
        }
        
        public ICommand BtnClick { get; set; }
        
        public ICommand EnglishCommand { get; set; }
        public ICommand MyanmarCommand { get; set; }
        public ICommand ChineseCommand { get; set; }

        public MainVM()
        {
            BtnClick = new RelayCommand(OnBtnClick, isActivated);

            EnglishCommand = new RelayCommand(OnEnglishCmd, isActivated);
            MyanmarCommand = new RelayCommand(OnMyanmarCmd, isActivated);
            ChineseCommand = new RelayCommand(OnChineseCmd, isActivated);
        }

        private void OnEnglishCmd(object obj)
        {
            
        }
        
        private void OnMyanmarCmd(object obj)
        {
            
        }
        
        private void OnChineseCmd(object obj)
        {
            
        }

        private void OnBtnClick(object obj)
        {
            if (EnglishCheck) MessageBox.Show("English!");
            if (MyanmarCheck) MessageBox.Show("Myanmar!");
            if (ChineseCheck) MessageBox.Show("Chinese");
            /*var tb = obj as TextBox;
            if (!String.IsNullOrEmpty(tb.Text))
            {
                MessageBox.Show(tb.Text);
            }
            if (String.IsNullOrEmpty(InputText)) return;

            TextOutput = InputText;*/
        }

        private bool isActivated(object obj)
        {
            //Activated statements;
            return true;
        }
    }
}