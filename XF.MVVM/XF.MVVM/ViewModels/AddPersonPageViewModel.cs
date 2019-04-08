using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XF.MVVM.ViewModels
{
    public class AddPersonPageViewModel : BaseViewModel
    {
        #region Properties

        private string firstName = string.Empty;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Message));
            }
        }

        private string lastName = string.Empty;
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Message));
            }
        }

        private string website = string.Empty;
        public string Website
        {
            get { return website; }
            set
            {
                website = value;
                OnPropertyChanged();
            }
        }

        private bool isFavourite;
        public bool IsFavourite
        {
            get { return isFavourite; }
            set
            {
                isFavourite = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Message));
            }
        }

        public string Message
        {
            get
            {
                return $"Your new contact is named {FirstName} {LastName} and he/she" +
                           $"{(IsFavourite ? "is" : "is not")} your favourite contact.";
            }
        }

        private bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                OnPropertyChanged();
                SaveContactCommand.ChangeCanExecute();
            }
        }

        #endregion

        #region Commands

        public Command SaveContactCommand { get; set; }
        public Command OpenWebsiteCommand { get; set; }

        #endregion

        public AddPersonPageViewModel()
        {
            SaveContactCommand = new Command(async () => await SaveContact(), () => IsBusy == false);
            OpenWebsiteCommand = new Command(OpenWebiste);
        }

        private void OpenWebiste(object obj)
        {
            try
            {
                Device.OpenUri(new Uri(Website));
            }
            catch (Exception e)
            {
                // Log this Exception somehow :D
            }
        }

        private async Task SaveContact()
        {
            // Show activity indicator
            IsBusy = true;

            // Long running task
            await Task.Delay(4000);

            // Hide activity indicator
            IsBusy = false;

            // Display alert
            await Application.Current.MainPage.DisplayAlert("Save", "Contact has been saved", "OK");
        }
    }
}
