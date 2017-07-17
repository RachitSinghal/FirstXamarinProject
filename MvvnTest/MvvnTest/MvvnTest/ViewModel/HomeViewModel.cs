using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MvvnTest.ViewModel
{
    class HomeViewModel : INotifyPropertyChanged
    {
        private TaskModel tk;
        private String message;
        public TaskModel Tk
        {
            get
            {
                return tk;
            }
            set
            {
                tk = value;
                OnPropertyChanged();
            }
        }
        public HomeViewModel()
        {
            tk = new TaskModel
            {
                Name = "More To Come !",
                Tech = "Something New"
            };
        }
        public String Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
                OnPropertyChanged();
            }
        }
        public Command JoinComm {
            get
            {
                return new Command(() =>
                {
                    Message = "Xebia welcomes you " + Tk.Name + ", you will work on " + Tk.Tech;
                });
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] String propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
