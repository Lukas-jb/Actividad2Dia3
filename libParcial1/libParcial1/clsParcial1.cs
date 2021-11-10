using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libParcial1
{
    public class clsParcial1
    {
        #region Atrubutos
        private float fltSalario;
        private float fltHorasL;
        private float fltPocReten;
        private float fltPorcBonifi;
        private float fltRecargo1;
        private float fltRecargo2;
        private int intAxTransporte;
        private float fltHordinaria;
        private float fltHDoblres;
        private float flrHTiples;
        private float fltVRetencion;
        private float fltVBonifi;
        private float fltSalarioTot;
        private string strError;

        #endregion
        #region Constructor
        public clsParcial1()
        {
            this.fltSalario = 0;
            this.fltHorasL = 0; ;
            this.fltPocReten = 0; ;
            this.fltPorcBonifi = 0; ;
            this.fltRecargo1 = 0; ;
            this.fltRecargo2 = 0; ;
            this.intAxTransporte = 0; ;
            this.fltHordinaria = 0; ;
            this.fltHDoblres = 0; ;
            //this.flrHTriples = 0; ;
            this.fltVRetencion = 0; ;
            this.fltVBonifi = 0; ;
            this.fltSalarioTot = 0; ;
            //this.intError = string.Empty;
        }

        #endregion
        #region Propiedades
        //entrada
        public float Salario
        {
            set { fltSalario = value; }
        }
        public float Horasl
        {
            set { fltHorasL = value; }
        }
        public float PorcReten
        {
            set { PorcReten = value; }
        }
        public float PorcBoni
        {
            set { PorcBoni = value; }
        }
        public float Recargo1
        {
            set { Recargo1 = value; }
        }
        public float Recargo2
        {
            set { Recargo2 = value; }
        }

        //salida

        public float HoraOrdnaria
        {
            get { return fltHordinaria; }
        }
        public float HDoble
        {
            get { return fltHDoblres; }
        }
        public float HTriple
        {
            get { return flrHTiples; }
        }
        public float VrRetencion
        {
            get { return fltPocReten; }
        }
        public float AuxTransporte
        {
            get { return intAxTransporte; }
        }
        public float SalarioTot
        {
            get { return fltSalarioTot; }
        }

        #endregion
        #region Metodos Privados
        public bool Validar()
        {
            if (fltSalario < 0)
            {
                strError = ("SalarioBase no valido");
                return false;
            }
            if (fltHorasL < 0)
            {
                strError = ("Horas totales no valido");
                return false;
            }
            if (fltRecargo1 < 0 && fltRecargo1 > 100)
            {
                strError = ("Porcetaje Recargo H1 no valido, Ingrese un valor ente 0 y 100");
                return false;
            }
            if (fltRecargo2 < 0 && fltRecargo2 > 100)
            {
                strError = ("Porcetaje Recargo H2 valido, Ingrese un valor ente 0 y 100");
                return false;
            }
            if (fltPorcBonifi < 0 && fltPorcBonifi > 100)
            {
                strError = ("Porcentaje de bonificacion no valido,, Ingrese un valor ente 0 y 100");
                return false;
            }
            if (fltVRetencion < 0 && fltVRetencion > 100)
            {
                strError = ("Porcentaje de Retencion no valido,, Ingrese un valor ente 0 y 100");
                return false;
            }

            return true;
        }

        public bool Calcular(float salario, float horasl,float pRete,float pVoni, float pRec1, float pRec2)
        {
            try
            {
                if (fltHorasL > 240)
                {
                    fltHordinaria = fltSalario;
                       
                }

            }
            catch (Exception ex)
            {
               
                throw;
            }
            return true;
        }

        #endregion
        #region Metodos Publicos

        #endregion
    }
}
