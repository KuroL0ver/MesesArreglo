namespace MesesArreglo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número :3");
            string[] mesecito = new string[12];

            mesecito[0] = "Enero";
            mesecito[1] = "Febrero";
            mesecito[2] = "Marzo";
            mesecito[3] = "Abril";
            mesecito[4] = "Mayo";
            mesecito[5] = "Junio";
            mesecito[6] = "Julio";
            mesecito[7] = "Agosto";
            mesecito[8] = "Septiembre";
            mesecito[9] = "Octubre";
            mesecito[10] = "Noviembre";
            mesecito[11] = "Diciembre";

            string input = Console.ReadLine();
            int.TryParse(input, out int result);

            if (result > 0 && result <= 12)
            {
                Console.WriteLine(mesecito[result -1]);
            }
            else 
            {
                Console.WriteLine("EH! Esta mal :c");
            }
        }

    }
}
