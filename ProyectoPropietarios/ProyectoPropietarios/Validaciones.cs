using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPropietarios
{
    class Validaciones
    {
        bool valida = false;
        public void soloLetras(KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        public void soloNumeros(KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        public bool validarCedula(string cedulaIngresada)
        {
            


            /**
             * Algoritmo para validar cedulas de Ecuador
             * @Author : Victor Diaz De La Gasca.
             * @Fecha  : Quito, 15 de Marzo del 2013
             * @Email  : vicmandlagasca@gmail.com
             * @Pasos  del algoritmo
             * 1.- Se debe validar que tenga 10 numeros
             * 2.- Se extrae los dos primero digitos de la izquierda y compruebo que existan las regiones
             * 3.- Extraigo el ultimo digito de la cedula
             * 4.- Extraigo Todos los pares y los sumo
             * 5.- Extraigo Los impares los multiplico x 2 si el numero resultante es mayor a 9 le restamos 9 al resultante
             * 6.- Extraigo el primer Digito de la suma (sumaPares + sumaImpares)
             * 7.- Conseguimos la decena inmediata del digito extraido del paso 6 (digito + 1) * 10
             * 8.- restamos la decena inmediata - suma / si la suma nos resulta 10, el decimo digito es cero
             * 9.- Paso 9 Comparamos el digito resultante con el ultimo digito de la cedula si son iguales todo OK sino existe error.
             */

            //      var cedula = '0931811087';

            //Preguntamos si la cedula consta de 10 digitos
            if (cedulaIngresada.Length == 10)
            {

                //Obtenemos el digito de la region que sonlos dos primeros digitos
                int digito_region = Int32.Parse(cedulaIngresada.Substring(0, 2));

                //Pregunto si la region existe ecuador se divide en 24 regiones
                if (digito_region >= 1 && digito_region <= 24)
                {

                    // Extraigo el ultimo digito
                    int ultimo_digito = Int32.Parse(cedulaIngresada.Substring(9, 1));


                    //Agrupo todos los pares y los sumo
                    int pares = Int32.Parse(cedulaIngresada.Substring(1, 1)) + Int32.Parse(cedulaIngresada.Substring(3, 1)) + Int32.Parse(cedulaIngresada.Substring(5, 1)) + Int32.Parse(cedulaIngresada.Substring(7, 1));

                    //Agrupo los impares, los multiplico por un factor de 2, si la resultante es > que 9 le restamos el 9 a la resultante
                    int numero1 = Int32.Parse(cedulaIngresada.Substring(0, 1));
                    numero1 = (numero1 * 2);
                    if (numero1 > 9)
                    {
                        numero1 = (numero1 - 9);
                    }

                    int numero3 = Int32.Parse(cedulaIngresada.Substring(2, 1));
                    numero3 = (numero3 * 2);
                    if (numero3 > 9)
                    {
                        numero3 = (numero3 - 9);
                    }

                    int numero5 = Int32.Parse(cedulaIngresada.Substring(4, 1));
                    numero5 = (numero5 * 2);
                    if (numero5 > 9)
                    {
                        numero5 = (numero5 - 9);
                    }

                    int numero7 = Int32.Parse(cedulaIngresada.Substring(6, 1));
                    numero7 = (numero7 * 2);
                    if (numero7 > 9)
                    {
                        numero7 = (numero7 - 9);
                    }

                    int numero9 = Int32.Parse(cedulaIngresada.Substring(8, 1));
                    numero9 = (numero9 * 2);
                    if (numero9 > 9)
                    {
                        numero9 = (numero9 - 9);
                    }

                    int impares = numero1 + numero3 + numero5 + numero7 + numero9;

                    //Suma total
                    int suma_total = (pares + impares);

                    //extraemos el primero digito
                    string primer_digito_suma = suma_total.ToString().Substring(0, 1);

                    //Obtenemos la decena inmediata
                    int decena = (Int32.Parse(primer_digito_suma) + 1) * 10;

                    //Obtenemos la resta de la decena inmediata - la suma_total esto nos da el digito validador
                    int digito_validador = decena - suma_total;

                    //Si el digito validador es = a 10 toma el valor de 0
                    if (digito_validador == 10)
                        digito_validador = 0;

                    //Validamos que el digito validador sea igual al de la cedula
                    if (digito_validador == ultimo_digito)
                    {
                        //toastr.success('La cedula ingresada es valida')
                        valida = true;
                        
                      //  MessageBox.Show("Cedula Valida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return valida;

                        //console.log('la cedula:' + cedula + ' es correcta');
                    }
                    else
                    {
                        valida = false;

                        // toastr.error('La cedula ingresada no es valida')
                       // MessageBox.Show("Cedula ingresada invalida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // console.log('la cedula:' + cedula + ' es incorrecta');
                        return valida;
                    }

                }
                else
                {
                    // imprimimos en consola si la region no pertenece
                    //  console.log('Esta cedula no pertenece a ninguna region');
                    valida = false;
                    //MessageBox.Show("La cedula ingresada no pertenece a ninguna region del ecuador", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //toastr.error('La cedula ingresada no pertenece a ninguna provincia')
                    return valida;
                }
            }
            else
            {
                valida = false;
               // MessageBox.Show("La cedula ingresada tiene menos de 10 digitos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //imprimimos en consola si la cedula tiene mas o menos de 10 digitos
                // console.log('Esta cedula tiene menos de 10 Digitos');
                // toastr.options.preventDuplicates = true
                //        toastr.options.positionClass ='toast-bottom-center'
                // toastr.warning('La cedula ingresada tiene menos de 10 digitos')
                return valida;
            }


        }
    }
}
