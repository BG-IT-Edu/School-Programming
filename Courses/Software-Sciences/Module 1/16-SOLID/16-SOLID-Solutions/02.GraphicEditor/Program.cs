using System;

namespace P02.Graphic_Editor
{
    class Program
    {
        static void Main()
        {
            GraphicEditor graphicEditor = new GraphicEditor();

            IShape shape = new Square();
            graphicEditor.DrawShape(shape);

            shape = new Rectangle();
            graphicEditor.DrawShape(shape);

            shape = new Circle();
            graphicEditor.DrawShape(shape);

            shape = new Triangle();
            graphicEditor.DrawShape(shape);

        }
    }
}
