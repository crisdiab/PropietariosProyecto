using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace ProyectoPropietarios
{
    class ConsultasBaseDatos
    {
        ConexiónBaseDatos conex = new ConexiónBaseDatos();

        //solo para consultas 
        public DataTable consultar(String consulta)
        {
            DataSet DS = conex.ExecuteDataSet(consulta);
            DataTable DT = DS.Tables[0];
            return DT;

        }


        //insert delet update
        public void counsultaTodoTipo(String ingreso)
        {
            DataSet DS = conex.ExecuteDataSet(ingreso);
        }
    }

}
