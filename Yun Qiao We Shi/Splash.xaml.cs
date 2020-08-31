using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Yun_Qiao_We_Shi
{
    /// <summary>
    /// Splash.xaml 的交互逻辑
    /// </summary>
    public partial class Splash : Window
    {
        Action<string> m_updateMessageAction = null;

        public Splash()
        {
            InitializeComponent();
            Loaded += (s, e) =>
            {
                //Trace.Listeners.Add(new OutputTraceListener(new Action<string>(UpdateMessage)));
            };

            image1.Loaded += (s, e) =>
            {
                (base.Resources["waiting"] as Storyboard).Begin(this.image1, true);
            };
        }

        public Splash(string defaultInfo) : this()
        {
            txtInfo.Text = defaultInfo;
        }

        public bool EnableProgress
        {
            get
            {
                return this.progressBar.Visibility == Visibility.Visible ? true : false;
            }
            set
            {
                this.progressBar.Visibility = value ? Visibility.Visible : Visibility.Collapsed;
            }
        }

        public void SetProgress(double progress)
        {
            Dispatcher.BeginInvoke(new Action(() => { progressBar.Value = progress; }));
        }

        public void UpdateMessage(string message)
        {
            try
            {
                if (m_updateMessageAction == null)
                {
                    m_updateMessageAction = new Action<string>(x =>
                    {
                        try
                        {
                            this.txtInfo.Text = x;
                        }
                        catch (Exception)
                        {
                        }
                    });
                }
                this.Dispatcher.BeginInvoke(m_updateMessageAction, message);
            }
            catch (Exception)
            {
            }
        }

        private void StackPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

    }
}
