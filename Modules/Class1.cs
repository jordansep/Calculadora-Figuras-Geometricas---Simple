using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FiguraGeometrica
{
    private float ancho;
    private float largo;
    private float area;
    private float lados;


    public FiguraGeometrica(float ancho, float largo, float area, float lados) { 
        this.ancho = ancho;
        this.largo = largo;
        this.area = area;
        this.lados = lados;
    }
}

interface IFigurasBidimensionales
{
    void CalcularArea();

}
