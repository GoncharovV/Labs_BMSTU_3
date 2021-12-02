using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinearAlgebra;

namespace IrisCalculator
{
    public interface IIrisDrawer
    {
        /// <summary>
        /// Строит график на основе получаемых данных
        /// </summary>
        /// <param name="vector">Значение конкретного параметра ириса для каждого из трех типов ириса</param>
        /// <param name="metric">Тип параметра (длинна, ширина и тд)</param>
        /// <param name="captions">Подписи для графиков</param>
        void DrawGraphics(double[] vector, IrisMetrics metric, string[] captions);

        void DrawPieGraphic(double[] list, string[] captions);
    }
}
