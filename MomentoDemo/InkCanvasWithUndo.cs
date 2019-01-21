using System.Linq;
using System.Windows.Controls;
using System.Windows.Ink;

namespace MomentoDemo
{
    public class InkCanvasWithUndo : InkCanvas
    {
        public IMomento CreateMomento()
        {
            Stroke[] copy = Strokes.ToArray();
            return new InkCanvasMomento() { State = copy };
        }

        public void SetMomento(IMomento momento)
        {
            Strokes = new StrokeCollection((Stroke[])momento.State);
        }

        public class InkCanvasMomento : IMomento
        {
            public object State { get; set; }
        }
    }
}
