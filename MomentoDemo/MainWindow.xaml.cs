using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace MomentoDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Stack<IMomento> states = new Stack<IMomento>();

        public MainWindow()
        {
            InitializeComponent();
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Undo, OnExecutedCommands));
            inkCanvasWithUndo1.MouseUp += InkCanvasWithUndo1_MouseUp;

            StoreState();
        }

        private void InkCanvasWithUndo1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            StoreState();
        }

        public void OnExecutedCommands(object sender, ExecutedRoutedEventArgs e)
        {
            var myWindow = (MainWindow)sender;
            if (e.Command == ApplicationCommands.Undo)
                myWindow.Undo(sender, e);
        }

        private void Undo(object sender, ExecutedRoutedEventArgs e)
        {
            if (states.Count > 1)
            {
                states.Pop();
                var lastState = states.Peek();
                inkCanvasWithUndo1.SetMomento(lastState);
            }
        }

        private void StoreState()
        {
            var momento = inkCanvasWithUndo1.CreateMomento();
            states.Push(momento);
            stokeCountLabel.Content = states.Count;
        }
    }

    public interface IMomento
    {
        object State { get; set; }
    }
}
