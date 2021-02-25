using InfiniteScrolling.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace InfiniteScrolling.ViewModels
{
    public class StudentListPageViewModel : INotifyPropertyChanged
    {
        #region Properties
        private bool _isLoading;
        public bool IsLoading
        {
            get => _isLoading;
            set { _isLoading = value; OnPropertyChanged(); }
        }

        private bool _isLock;
        private bool _isAllItemLoaded;

        private List<StudentModel> _allStudentList = new List<StudentModel>();
        private const int PageSize = 10;

        public ObservableCollection<StudentModel> StudentList { get; set; } = new ObservableCollection<StudentModel>();

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
        #region Constructor
        public StudentListPageViewModel()
        {
            AddStudentInfo();
            LoadStudentList();
        }
        #endregion

        #region Methods
        private void AddStudentInfo()
        {
            StudentModel obj = new StudentModel();
            obj.Name = "Test1";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test2";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test3";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test4";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test5";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test6";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test7";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test8";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test9";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test10";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test11";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test12";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test13";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test14";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test15";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test16";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test17";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test18";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test19";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test20";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test21";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test22";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test23";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test24";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test25";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test26";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test27";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test28";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test29";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test30";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test31";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test32";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test33";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test34";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test35";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test36";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test37";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);
            
            obj = new StudentModel();
            obj.Name = "Test38";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test39";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test40";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test41";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test42";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test43";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test44";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test45";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test46";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test47";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test48";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test49";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test50";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test51";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test52";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test53";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test54";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test55";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test56";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test57";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test58";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test59";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);

            obj = new StudentModel();
            obj.Name = "Test60";
            obj.Email = "test@gmail.com";
            _allStudentList.Add(obj);
        }

        private void LoadStudentList()
        {
            if (!_isAllItemLoaded && !_isLock)
            {
                IsLoading = _isLock = true;
                Task.Run(async () =>
                {
                    await Task.Delay(2000);
                    var studentList = _allStudentList.Skip(StudentList.Count).Take(PageSize).ToList();

                    Device.BeginInvokeOnMainThread(() =>
                    {
                        if (studentList.Count < PageSize)
                            _isAllItemLoaded = true;

                        if (studentList.Count > 0)
                        {
                            foreach (var student in studentList)
                            {
                                StudentList.Add(student);
                            }
                        }
                        _isLock = IsLoading = false;
                    });

                });
            }


        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Commands
        public ICommand RemainThresholdReachCommand
        {
            get => new Command(() =>
            {
                if (StudentList.Count > 0)
                {
                    LoadStudentList();
                }
            });
        }
        #endregion
    }
}
