using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yun_Qiao_We_Shi
{
    public class CallReciveryJobViewModel : System.ComponentModel.INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// 属性值变化时发生
        /// </summary>
        /// <param name="propertyName"></param>
        protected void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }

        private ObservableCollection<CallReciveryJobModel> callReciveryJobOrders = new ObservableCollection<CallReciveryJobModel>();
        public ObservableCollection<CallReciveryJobModel> CallReciveryJobOrders
        {
            get { return callReciveryJobOrders; }
            set
            {
                var oldvalue = callReciveryJobOrders;
                if (oldvalue != value)
                {
                    callReciveryJobOrders = value;
                    OnPropertyChanged("CallReciveryJobOrders");

                }
            }
        }



    }

    public class CallReciveryJobModel : System.ComponentModel.INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// 属性值变化时发生
        /// </summary>
        /// <param name="propertyName"></param>
        protected void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }

        private int number = 0;
        public int Number
        {
            get { return number; }
            set
            {
                var oldvalue = number;
                if (oldvalue != value)
                {
                    number = value;
                    OnPropertyChanged("Number");

                }
            }
        }
        private string taskerpid = "";
        public string TaskErpid
        {
            get { return taskerpid; }
            set
            {
                var oldvalue = taskerpid;
                if (oldvalue != value)
                {
                    taskerpid = value;
                    OnPropertyChanged("TaskErpid");

                }
            }
        }

        private string carNumber = "";
        public string CarNumber
        {
            get { return carNumber; }
            set
            {
                var oldvalue = carNumber;
                if (oldvalue != value)
                {
                    carNumber = value;
                    OnPropertyChanged("CarNumber");

                }
            }
        }


        private string notifyerpid = "";
        public string Notifyerpid
        {
            get { return notifyerpid; }
            set
            {
                var oldvalue = notifyerpid;
                if (oldvalue != value)
                {
                    notifyerpid = value;
                    OnPropertyChanged("Notifyerpid");

                }
            }
        }



        private string mariteral = "";

        public string Mariteral
        {
            get { return mariteral; }
            set
            {
                var oldvalue = mariteral;
                if (oldvalue != value)
                {
                    mariteral = value;
                    OnPropertyChanged("Mariteral");

                }
            }
        }

        private bool isselect = false;
        public bool Isselect
        {
            get { return isselect; }
            set
            {
                var oldvalue = isselect;
                if (oldvalue != value)
                {
                    isselect = value;
                    OnPropertyChanged("Isselect");

                }
            }
        }

        private string states = "";
        public string Sates
        {
            get { return states; }
            set
            {
                var oldvalue = states;
                if (oldvalue != value)
                {
                    states = value;
                    OnPropertyChanged("Sates");

                }
            }
        }
        private DateTime createTime = new DateTime();
        public DateTime CreateTime
        {
            get { return createTime; }
            set
            {
                var oldvalue = createTime;
                if (oldvalue != value)
                {
                    createTime = value;
                    OnPropertyChanged("CreateTime");

                }
            }
        }
    }
}
