using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CalculadoraWCFServer
{
    [ServiceContract]
    public class Service1
    {
        [OperationContract]
        public String Calcular(String n1, String n2, String op)
        {
            String resultado = "";
            try
            {
                if (op.Equals("+"))
                    resultado = (Convert.ToDouble(n1) + Convert.ToDouble(n2)).ToString();
                if (op.Equals("-"))
                    resultado = (Convert.ToDouble(n1) - Convert.ToDouble(n2)).ToString();
                if (op.Equals("*"))
                    resultado = (Convert.ToDouble(n1) * Convert.ToDouble(n2)).ToString();
                if (op.Equals("/"))
                    resultado = (Convert.ToDouble(n1) / Convert.ToDouble(n2)).ToString();
            }
            catch (Exception e)
            {
                resultado = "Erro de conversão";
            }
            return resultado;
        }

    }
}
