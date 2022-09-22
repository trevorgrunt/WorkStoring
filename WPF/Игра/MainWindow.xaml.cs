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
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Windows.Threading;

namespace Игра
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer gameTimer = new DispatcherTimer(); // Таймер для того чтобы элипс расширялся

        List<Ellipse> removeThis = new List<Ellipse>(); // Список элипсов, которые появляются по ходу

        int spawnRate = 60; 
        int currentRate; 
        int lastScore = 0; 
        int health = 350;
        int posX; 
        int posY;
        int score = 0; 

        double growthRate = 0.6; 

        Random rand = new Random(); 

        Brush brush; // цвет для кругов

        public MainWindow()
        {
            InitializeComponent();

            gameTimer.Tick += GameLoop; // Игровой цикл
            gameTimer.Interval = TimeSpan.FromMilliseconds(20); // Это время будет отмечаться каждые 20 секунд
            gameTimer.Start();  // Запуск таймера

            currentRate = spawnRate; 
        }

        private void GameLoop(object sender, EventArgs e)
        {
            // это событие игрового цикла, все инструкции внутри этого события будут выполняться каждый раз, когда тикает таймер
            // сначала мы обновляем счет и показываем последний счет на ярлыках
            txtScore.Content = "Результат: " + score; 
            txtLastScore.Content = "Последний результат: " + lastScore;

            currentRate -= 2;

            if (currentRate < 1) 
            {
                currentRate = spawnRate; // Сбрасываем скорость к начальной

                posX = rand.Next(15, 700);
                posY = rand.Next(50, 350);

                // Случайный цвет для элипса 
                brush = new SolidColorBrush(Color.FromRgb((byte)rand.Next(1, 255), (byte)rand.Next(1, 255), (byte)rand.Next(1, 255)));

                Ellipse circle = new Ellipse
                {

                    Tag = "circle",
                    Height = 10,
                    Width = 10,
                    Stroke = Brushes.Black,
                    StrokeThickness = 1,
                    Fill = brush

                };

                // Размещение элипсов по координатам
                Canvas.SetLeft(circle, posX);
                Canvas.SetTop(circle, posY);
                MyCanvas.Children.Add(circle);
            }

            // Увеличение элипсов
            foreach (var x in MyCanvas.Children.OfType<Ellipse>())
            {
                x.Height += growthRate; 
                x.Width += growthRate; 
                x.RenderTransformOrigin = new Point(0.5, 0.5); 

                // Если больше, то элипс удаляется, а хп снимается
                if (x.Width > 70)
                {
                    removeThis.Add(x);
                    health -= 15; 
                }

            } 

            // Связываем хп с полоской в окне
            if (health > 1)
            {
                healthBar.Width = health;
            }
            else
            {
                GameOverFunction();
            }

            // Чтобы удалить этот эллипс из игры, нам нужен другой для каждого цикла

            foreach (Ellipse i in removeThis)
            {
                MyCanvas.Children.Remove(i);  // Для каждого цикла будет искать каждый эллипс, который существует внутри списка удаления
            }

            if (score > 5)
            {
                spawnRate = 25; // Скорость увеличивается 
            }
           
            if (score > 20)
            {
                spawnRate = 15;
                growthRate = 1.5; // Элипс растет быстрее
            }


        }

        private void ClickOnCanvas(object sender, MouseButtonEventArgs e)
        {
            // Если клик на элипс
            if (e.OriginalSource is Ellipse)
            {
                Ellipse circle = (Ellipse)e.OriginalSource; // создается локальный эллипс и связывается его с исходным источником

                MyCanvas.Children.Remove(circle); // теперь можно удалить элипс

                score++;             
            }
        }

        private void GameOverFunction()
        {
            gameTimer.Stop();

            MessageBox.Show("Игра окончена" + Environment.NewLine + "Результат: " + score + Environment.NewLine + "Нажмите Ok, чтобы начать с начала!");

            foreach (var y in MyCanvas.Children.OfType<Ellipse>())
            {
                removeThis.Add(y);  // Находим все существующие эллипсы, которые находятся на экране, и добавляем их в список удаления
            }
            foreach (Ellipse i in removeThis) // Очищаем список удаления для того, чтобы при следующей игре все работало правильно
            {
                MyCanvas.Children.Remove(i);
            }

            // Сбрасываем все значения к тому, что было в начале
            growthRate = .6;
            spawnRate = 60;
            lastScore = score;
            score = 0;
            currentRate = 5;
            health = 350;
            removeThis.Clear();
            gameTimer.Start();
        }
    }
}
