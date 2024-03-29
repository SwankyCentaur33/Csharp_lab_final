﻿using System;
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

namespace lab_final_attempt2.View.UserControls
{
    /// <summary>
    /// Логика взаимодействия для PointsDistance.xaml
    /// </summary>

    //Код как в PointsSum, но с методом Distance
    public partial class PointsDistance : UserControl
    {
        public PointsDistance()
        {
            InitializeComponent();
        }

        private void ResButton_Click(object sender, RoutedEventArgs e) //Когда была нажата кнопка
        {
            Point point1 = (Point)SelPoint1.SelectedItem; //Берём выбранную точку из листа 1
            Point point2 = (Point)SelPoint2.SelectedItem; //Берём выбранную точку из листа 2
            double distance = Math.Round(point1.Distance(point2), 4); //Проверка метода Distance
            ResText.Text = distance.ToString(); //Вывод результата
        }

        private void SelPoint_SelectionChanged(object sender, SelectionChangedEventArgs e) //Если изменился выбор в каком-то листе
        {
            if (SelPoint1.SelectedItem != null && SelPoint2.SelectedItem != null) //Если в обеих ListBox что-то выбрано
            {
                ResButton.IsEnabled = true; //то включить кнопку
            }
            else
            {
                ResButton.IsEnabled = false;//Если хоть в одном ничего не выбрано, то выключить кнопку
            }
        }
    }
}
