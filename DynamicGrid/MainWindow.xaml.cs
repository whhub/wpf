using System.Windows.Controls;

namespace DynamicGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private const int MaxItemCount = 8;

        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < MaxItemCount; i++)
            {
                MainfGrid.Children.Add(new Button());
            }

            SetGrid(4);
        }

        private void SetGrid(int count)
        {
            int row = count%2 == 0 ? 2 : 1;
            int col = count/row;
            SetGrid(row, col);

            PlaceSubItemsInGrid(row, col);
        }

        private void PlaceSubItemsInGrid(int row, int col)
        {
            int index = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    var element = MainfGrid.Children[index];
                    Grid.SetRow(element, i);
                    Grid.SetColumn(element, j);
                    index++;
                }
            }
        }

        private void SetGrid(int row, int col)
        {
            var rows = MainfGrid.RowDefinitions;
            var curRow = rows.Count;

            var cols = MainfGrid.ColumnDefinitions;
            var curCol = cols.Count;

            var deltaRow = row - curRow;
            var deltaCol = col - curCol;

            for (int i = 0; i < deltaRow; i++)
            {
                rows.Add(new RowDefinition());
            }

            for (int j = 0; j < deltaCol; j++)
            {
                cols.Add(new ColumnDefinition());
            }

            if(deltaRow<0) rows.RemoveRange(row, -deltaRow);
            if(deltaCol<0) cols.RemoveRange(col, -deltaCol);
        }
    }
}
