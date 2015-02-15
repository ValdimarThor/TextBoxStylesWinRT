using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace BlendRocksTextInput.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private string stringValue1 = "";
        private string stringValue2 = "";
        private string stringValue3 = "";
        public const string StringValue2PropertyName = "StringValue2";
        public const string StringValue3PropertyName = "StringValue3";

        private RelayCommand clearCommand;

        public MainViewModel()
        {
        }

        public string StringValue1
        {
            get
            {
                return stringValue1;
            }

            set
            {
                if (stringValue1 == value)
                {
                    return;
                }

                stringValue1 = value;
                RaisePropertyChanged("StringValue1");
            }
        }

        public string StringValue2
        {
            get
            {
                return stringValue2;
            }

            set
            {
                if (stringValue2 == value)
                {
                    return;
                }

                stringValue2 = value;
                RaisePropertyChanged(StringValue2PropertyName);
            }
        }

        public string StringValue3
        {
            get
            {
                return stringValue3;
            }

            set
            {
                if (stringValue3 == value)
                {
                    return;
                }

                stringValue3 = value;
                RaisePropertyChanged(StringValue3PropertyName);
            }
        }

        public RelayCommand ClearCommand
        {
            get
            {
                return clearCommand ?? (clearCommand = new RelayCommand(
                    ExecuteClearCommand,
                    CanExecuteClearCommand));
            }
        }

        private void ExecuteClearCommand()
        {
            if (!ClearCommand.CanExecute(null))
            {
                return;
            }

            StringValue1 = string.Empty;
        }

        private bool CanExecuteClearCommand()
        {
            return true;
        }

        private bool CanExecuteMyCommand()
        {
            return true;
        }

    }
}