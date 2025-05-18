namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rubro1, rubro2, rubro3, rubro4, rubro5, nVenta, nRubro, pVendidos, nVentaMayor, cantidad_ventas, pTotales;
            double monto,recTotal, ventaMayor, prcRubro1, prcRubro2, prcRubro3, prcRubro4, prcRubro5;

            Console.WriteLine("Ingrese el Nº DE VENTA: (-1 P/FINALIZAR)");
            nVenta = Convert.ToInt32(Console.ReadLine());

            rubro1 = 0;
            rubro2 = 0;
            rubro3 = 0;
            rubro4 = 0;
            rubro5 = 0;
            ventaMayor = 0;
            nVentaMayor = 0;
            recTotal = 0;
            cantidad_ventas = 0;
            pTotales = 0;
            while (nVenta != -1)
            {
                Console.WriteLine("Ingrese el Nº DEL RUBRO: (1/2/3/4/5)");
                nRubro = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad de productos vendidos:");
                pVendidos = Convert.ToInt32(Console.ReadLine());
                pTotales += pVendidos;
                switch (nRubro)
                {
                    case 1:
                        rubro1 += pVendidos;
                        break;
                    case 2:
                        rubro2 += pVendidos;
                        break;
                    case 3:
                        rubro3 += pVendidos;
                        break;
                    case 4:
                        rubro4 += pVendidos;
                        break;
                    case 5:
                        rubro5 += pVendidos;
                        break;
                }

                Console.WriteLine("Ingrese el monto del rubro:");
                monto = Convert.ToDouble(Console.ReadLine());

                cantidad_ventas ++;
                recTotal += monto;

                if (monto > ventaMayor) {
                    ventaMayor = monto;
                    nVentaMayor = nVenta;
                }

                Console.WriteLine("Ingrese el Nº DE VENTA: (-1 P/FINALIZAR)");
                nVenta = Convert.ToInt32(Console.ReadLine());
            }

            if (cantidad_ventas > 0)
            {
                prcRubro1 = (rubro1 * 1.0 / pTotales) * 100;
                prcRubro2 = (rubro2 * 1.0 / pTotales) * 100;
                prcRubro3 = (rubro3 * 1.0 / pTotales) * 100;
                prcRubro4 = (rubro4 * 1.0 / pTotales) * 100;
                prcRubro5 = (rubro5 * 1.0 / pTotales) * 100;
                Console.WriteLine($"Recaudación total: ${recTotal}");
                Console.WriteLine($"Porcentaje del Rubro 1 en cantidad: {prcRubro1:f2}%");
                Console.WriteLine($"Porcentaje del Rubro 2 en cantidad: {prcRubro2:f2}%");
                Console.WriteLine($"Porcentaje del Rubro 3 en cantidad: {prcRubro3:f2}%");
                Console.WriteLine($"Porcentaje del Rubro 4 en cantidad: {prcRubro4:f2}%");
                Console.WriteLine($"Porcentaje del Rubro 5 en cantidad: {prcRubro5:f2}%");
                Console.WriteLine($"Nº VENTA con Mayor Monto: {nVentaMayor}, Monto: ${ventaMayor}");
                Console.WriteLine($"Cantidad de ventas: {cantidad_ventas}");
            }
            else
            {
                Console.WriteLine("No hubo ventas.");
            }
           

            

        }
    }
}
