using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yun_Qiao_We_Shi
{
    public class SelectReciveryJobViewModel : System.ComponentModel.INotifyPropertyChanged
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

        private IDCardManage cardManage = new IDCardManage();

        public IDCardManage CardManage
        {
            get { return cardManage; }
            set
            {
                var oldvalue = cardManage;
                if (oldvalue != value)
                {
                    cardManage = value;
                    OnPropertyChanged("CardManage");
                }
            }
        }

        private ReceivingJobViewModel receivingJobViewModel = default;
        public ReceivingJobViewModel ReceivingJobViewModel
        {
            get { return receivingJobViewModel; }
            set
            {
                var oldvalue = receivingJobViewModel;
                if (oldvalue != value)
                {
                    receivingJobViewModel = value;
                    OnPropertyChanged("ReceivingJobViewModel");

                }
            }
        }

        private ObservableCollection<ReceivingJobChildViewModel> receivingJobChildViewModels = default;
        public ObservableCollection<ReceivingJobChildViewModel> ReceivingJobChildViewModels
        {
            get { return receivingJobChildViewModels; }
            set
            {
                var oldvalue = receivingJobChildViewModels;
                if (oldvalue != value)
                {
                    receivingJobChildViewModels = value;
                    OnPropertyChanged("ReceivingJobChildViewModels");
                    if (receivingJobChildViewModels.Count > 0)
                    {
                        Visual = Visibility.Visible;
                        VisualRfid = Visibility.Collapsed;
                    }
                    else
                    {
                        Visual = Visibility.Collapsed;
                        VisualRfid = Visibility.Visible;
                    }
                }
            }
        }

        private string message = default;
        public string Message
        {
            get { return message; }
            set
            {
                var oldvalue = message;
                if (oldvalue != value)
                {
                    message = value;
                    OnPropertyChanged("Message");
                }
            }
        }

        private Visibility visual = default;
        public Visibility Visual
        {
            get { return visual; }
            set
            {
                var oldvalue = visual;
                if (oldvalue != value)
                {
                    visual = value;
                    OnPropertyChanged("Visual");
                }
            }
        }

        private Visibility visualrfid = default;
        public Visibility VisualRfid
        {
            get { return visualrfid; }
            set
            {
                var oldvalue = visualrfid;
                if (oldvalue != value)
                {
                    visualrfid = value;
                    OnPropertyChanged("VisualRfid");
                }
            }
        }
    }
}
