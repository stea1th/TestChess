using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestChess.Figures
{
    class FigureRegistry
    {

        public Dictionary<string, IFigure> Figures { get; set; }

        public void LoadFigures()
        {
            var asm = Assembly.Load("TestChess");
            var types = asm.GetTypes();
            var result = types.Where(x => x.GetInterface("IFigure") != null && !x.IsAbstract).ToList();
            //result.ForEach(x => Figures.Add(x.Name.ToLower(), Create(x)));
            result.ForEach(x =>
            {
                var fig = Create(x);
                Console.WriteLine(fig.Name + " " + fig.Position+ " " + fig.White);
            });
            

            //result.ForEach(x => Console.WriteLine(x.Name));
        }

        private IFigure Create(Type type) 
        {
            //return (IFigure)Activator.CreateInstance(type);
            return (IFigure)type.GetConstructor(new Type[] { typeof(int), typeof(bool) }).Invoke(new object[] { 2, true });
        }
    }
}
