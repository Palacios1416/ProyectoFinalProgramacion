using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Enums
{
    public enum Ingresos
    {
    // Factores para el cálculo de ingresos
    private double factorAntiguedad = 0.05;
    private double factorRiesgoLaboral = 0.1;
    private double factorNocturnidad = 0.2;
    private double factorHorasExtras = 15.0;
    private double factorViatico = 30.0;
    private double factorComision = 0.02;
    private double factorDiasExtras = 20.0;
    private double factorIndemnizacion = 200.0;
    private double factorDepreciacion = 100.0;

    // Método para calcular los ingresos
    public double CalcularIngresos(double salarioBase, int antiguedad, bool riesgoLaboral,
                                   int horasExtras, bool nocturnidad, double viatico,
                                   double comision, int diasExtras, double indemnizacion,
                                   double depreciacion)
    {
        double ingresos = salarioBase;

        // Calcular ingresos por antigüedad
        ingresos += salarioBase * antiguedad * factorAntiguedad;

        // Calcular ingresos por riesgo laboral
        if (riesgoLaboral)
        {
            ingresos += salarioBase * factorRiesgoLaboral;
        }

        // Calcular ingresos por nocturnidad
        if (nocturnidad)
        {
            ingresos += salarioBase * factorNocturnidad;
        }

        // Calcular ingresos por horas extras
        ingresos += horasExtras * factorHorasExtras;

        // Calcular ingresos por viático
        ingresos += viatico * factorViatico;

        // Calcular ingresos por comisión
        ingresos += comision * factorComision;

        // Calcular ingresos por días extras
        ingresos += diasExtras * factorDiasExtras;

        // Calcular ingresos por indemnización
        ingresos += indemnizacion * factorIndemnizacion;

        // Calcular ingresos por depreciación
        ingresos += depreciacion * factorDepreciacion;

        return ingresos;
    }
    }
}
