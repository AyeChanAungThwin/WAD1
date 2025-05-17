using System;
using System.Collections.Generic;

namespace Encryptor.ViewModel
{
    public class MainVM: ViewModelBase
    {
        private string _salt;

        public string Salt
        {
            get => _salt;
            set
            {
                _salt = value;
                OnPropertyChanged();
            }
        }

        private string _code1;
        public string Code1
        {
            get => _code1;
            set
            {
                _code1 = value;
                OnPropertyChanged();
            }
        }

        private string _code2;
        public string Code2
        {
            get => _code2;
            set
            {
                _code2 = value;
                OnPropertyChanged();
            }
        }

        private string _code3;
        public string Code3
        {
            get => _code3;
            set
            {
                _code3 = value;
                OnPropertyChanged();
            }
        }

        private string _code4;
        public string Code4
        {
            get => _code4;
            set
            {
                _code4 = value;
                OnPropertyChanged();
            }
        }

        private string _code5;
        public string Code5
        {
            get => _code5;
            set
            {
                _code5 = value;
                OnPropertyChanged();
            }
        }

        private string _code6;
        public string Code6
        {
            get => _code6;
            set
            {
                _code6 = value;
                OnPropertyChanged();
            }
        }

        private string _code7;
        public string Code7
        {
            get => _code7;
            set
            {
                _code7 = value;
                OnPropertyChanged();
            }
        }

        private string _code8;
        public string Code8
        {
            get => _code8;
            set
            {
                _code8 = value;
                OnPropertyChanged();
            }
        }

        private string _code9;
        public string Code9
        {
            get => _code9;
            set
            {
                _code9 = value;
                OnPropertyChanged();
            }
        }

        private string _code10;
        public string Code10
        {
            get => _code10;
            set
            {
                _code10 = value;
                OnPropertyChanged();
            }
        }

        private string _code11;
        public string Code11
        {
            get => _code11;
            set
            {
                _code11 = value;
                OnPropertyChanged();
            }
        }

        private string _code12;
        public string Code12
        {
            get => _code12;
            set
            {
                _code12 = value;
                OnPropertyChanged();
            }
        }
        
        private string _code13;
        public string Code13
        {
            get => _code13;
            set
            {
                _code13 = value;
                OnPropertyChanged();
            }
        }

        private string _code14;
        public string Code14
        {
            get => _code14;
            set
            {
                _code14 = value;
                OnPropertyChanged();
            }
        }

        private string _code15;
        public string Code15
        {
            get => _code15;
            set
            {
                _code15 = value;
                OnPropertyChanged();
            }
        }

        private string _code16;
        public string Code16
        {
            get => _code16;
            set
            {
                _code16 = value;
                OnPropertyChanged();
            }
        }

        private string _code17;
        public string Code17
        {
            get => _code17;
            set
            {
                _code17 = value;
                OnPropertyChanged();
            }
        }

        private string _code18;
        public string Code18
        {
            get => _code18;
            set
            {
                _code18 = value;
                OnPropertyChanged();
            }
        }

        private string _code19;
        public string Code19
        {
            get => _code19;
            set
            {
                _code19 = value;
                OnPropertyChanged();
            }
        }

        private string _code20;
        public string Code20
        {
            get => _code20;
            set
            {
                _code20 = value;
                OnPropertyChanged();
            }
        }

        private string _code21;
        public string Code21
        {
            get => _code21;
            set
            {
                _code21 = value;
                OnPropertyChanged();
            }
        }

        private string _code22;
        public string Code22
        {
            get => _code22;
            set
            {
                _code22 = value;
                OnPropertyChanged();
            }
        }

        private string _code23;
        public string Code23
        {
            get => _code23;
            set
            {
                _code23 = value;
                OnPropertyChanged();
            }
        }

        private string _code24;
        public string Code24
        {
            get => _code24;
            set
            {
                _code24 = value;
                OnPropertyChanged();
            }
        }

        public MainVM()
        {
            var salt = Salt;
            foreach (var result in salt)
            {
                int val = result;
                var ascii = val.ToString();
                if (ascii.Length > 1)
                {
                    var charArr = ascii.ToCharArray();
                    foreach (var intChar in charArr)
                    {
                        
                    }
                }
            }
        }

        private List<string> Codes()
        {
            var codes = new List<string>();
            codes.Add(Code1);
            codes.Add(Code2);
            codes.Add(Code3);
            codes.Add(Code4);
            codes.Add(Code5);
            codes.Add(Code6);
            codes.Add(Code7);
            codes.Add(Code8);
            codes.Add(Code9);
            codes.Add(Code10);
            codes.Add(Code11);
            codes.Add(Code12);
            codes.Add(Code13);
            codes.Add(Code14);
            codes.Add(Code15);
            codes.Add(Code16);
            codes.Add(Code17);
            codes.Add(Code18);
            codes.Add(Code19);
            codes.Add(Code20);
            codes.Add(Code21);
            codes.Add(Code22);
            codes.Add(Code23);
            codes.Add(Code24);

            return codes;
        } 
    }
}