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

namespace Battleships
{
    /// <summary>
    /// Logique d'interaction pour Battefield.xaml
    /// </summary>
    public partial class Battefield : Page
    {
        public Battefield()
        {
            InitializeComponent();

            GenerateGrid();
            GenerateLabels();
            GenerateButtons();
        }

        private void GenerateGrid()
        {
            for(int i = 0; i < 11; i++)
            {
                gridBattleField.RowDefinitions.Add(new RowDefinition());
                gridBattleField.ColumnDefinitions.Add(new ColumnDefinition());
            }
        }

        private void GenerateLabels()
        {
            for(int i = 1; i < 11; i++)
            {
                Label labelH = new Label();
                Label labelV = new Label();

                labelH.HorizontalContentAlignment = HorizontalAlignment.Center;
                labelH.VerticalContentAlignment = VerticalAlignment.Center;
                labelV.HorizontalContentAlignment = HorizontalAlignment.Center;
                labelV.VerticalContentAlignment = VerticalAlignment.Center;

                labelH.Content = (char)(i + 64);
                labelV.Content = i;

                Grid.SetColumn(labelH, i);
                Grid.SetRow(labelV, i);
                gridBattleField.Children.Add(labelH);
                gridBattleField.Children.Add(labelV);
            }
        }

        private void GenerateButtons()
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Button b = new Button();
                    Grid.SetRow(b, i);
                    Grid.SetColumn(b, j);
                    gridBattleField.Children.Add(b);
                }
            }
        }
    }
}
