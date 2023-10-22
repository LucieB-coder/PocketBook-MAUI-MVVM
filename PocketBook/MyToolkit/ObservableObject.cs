using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyToolkit
{
    public class ObservableObject : INotifyPropertyChanged

    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public void SetProperty<T>(ref T member, T value)
        {
            if(EqualityComparer<T>.Default.Equals(member, value)) return;
            member = value;
            OnPropertyChanged(nameof(member));
        }

        public void SetProperty<T>(ref T member, T value, Action? action, [CallerMemberName] string propertyName = null)
        {     
            if(EqualityComparer<T>.Default.Equals(member,value)) return;     
            if(action != null)     
            {         
                action();
            }     
            OnPropertyChanged(propertyName); 
        }
    }
}