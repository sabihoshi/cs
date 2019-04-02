using Caliburn.Micro;
using MVVMTest.Models;

namespace MVVMTest.ViewModels
{
    public class ShellViewModel : Screen
    {
        private string _firstName = "Kao";
        private BindableCollection<ImageModel> _images = new BindableCollection<ImageModel>();
        private string _lastName;
        private BindableCollection<PersonModel> _people = new BindableCollection<PersonModel>();
        private ImageModel _selectedImage;
        private PersonModel _selectedPerson;

        public ShellViewModel()
        {
            People.Add(new PersonModel("Kao", "Miyazono", 17));
            People.Add(new PersonModel("Azusa", "Nakano", 16));
            People.Add(new PersonModel("Mio", "Akiyama", 14));
            string albumPath =
                @"C:\Users\ciit\source\repos\Conversion_Types\Conversion Types\Day 8\MVVMTest\Images\Albums";
            Images.Add(new ImageModel($@"{albumPath}\daily_mix_1.png", "Album 1"));
            Images.Add(new ImageModel($@"{albumPath}\daily_mix_2.png", "Album 2"));
            Images.Add(new ImageModel($@"{albumPath}\daily_mix_3.png", "Album 3"));
            Images.Add(new ImageModel($@"{albumPath}\daily_mix_4.png", "Album 4"));
            Images.Add(new ImageModel($@"{albumPath}\daily_mix_5.png", "Album 5"));
        }

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public string FullName => $"{FirstName} {LastName}";

        public BindableCollection<ImageModel> Images
        {
            get => _images;
            set
            {
                _images = value;
                NotifyOfPropertyChange(() => Images);
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public BindableCollection<PersonModel> People
        {
            get => _people;
            set
            {
                _people = value;
                NotifyOfPropertyChange(() => People);
            }
        }

        public ImageModel SelectedImage
        {
            get => _selectedImage;
            set
            {
                _selectedImage = value;
                NotifyOfPropertyChange(() => SelectedImage);
            }
        }

        public PersonModel SelectedPerson
        {
            get => _selectedPerson;
            set
            {
                _selectedPerson = value;
                NotifyOfPropertyChange(() => SelectedPerson);
            }
        }

        public bool CanClearText(string firstName, string lastName)
        {
            return !string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName);
        }

        public void ClearText(string firstName, string lastName)
        {
            FirstName = "";
            LastName = "";
        }
    }
}