using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Практическая_работа__7._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Timer timer; // Объявление таймера

        public MainWindow()
        {

            timer = new Timer();
            timer.Interval = 5000; // Устанавливаем интервал срабатывания таймера (в миллисекундах)
            timer.Elapsed += Timer_Elapsed; // Добавляем обработчик события срабатывания таймера
            timer.Start(); // Запускаем таймер
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Dispatcher.Invoke(() =>
            {
                MessageBox.Show("Рецепт оказался опасным для жизни"); // Выводим сообщение при срабатывании таймера
            });
        }
    }
}