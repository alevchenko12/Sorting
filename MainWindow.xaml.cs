using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sorting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    /// <summary>
    /// abstract factory 
    /// sorting anything
    /// </summary>
    abstract class Sorting
    {
        public abstract AbstractSortMerge CreateSortMerge();
        public abstract AbstractSortQuick CreateSortQuick();
    }

    /// <summary>
    /// conctere factory #1
    /// sorting numbers
    /// </summary>
    class SortNum: Sorting
    {
        public override AbstractSortMerge CreateSortMerge()
        {
            return new MergeSortNum();
        }

        public override AbstractSortQuick CreateSortQuick()
        {
            return new QuickSortNum();
        }
    }


    /// <summary>
    /// conctere factory #2
    /// sorting strings
    /// </summary>
    class SortStr : Sorting
    {
        public override AbstractSortMerge CreateSortMerge()
        {
            return new MergeSortStr();
        }

        public override AbstractSortQuick CreateSortQuick()
        {
            return new QuickSortStr();
        }
    }

    /// <summary>
    /// abstract product A
    /// merge sorting
    /// </summary>
    abstract class AbstractSortMerge { }

    /// <summary>
    /// abstract product B
    /// quick sort
    /// </summary>
    abstract class AbstractSortQuick { }


    /// <summary>
    /// realisation of class MergeSort for numbers
    /// </summary>
    class MergeSortNum : AbstractSortMerge { }

    /// <summary>
    /// realisation of class QuickSort for numbers
    /// </summary>
    class QuickSortNum : AbstractSortQuick { }

    /// <summary>
    /// realisation of class MergeSort for strings
    /// </summary>
    class MergeSortStr : AbstractSortMerge { }

    /// <summary>
    /// realisation of class QuickSort for strings
    /// </summary>
    class QuickSortStr : AbstractSortQuick { }  

}