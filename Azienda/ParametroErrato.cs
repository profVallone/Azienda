using System;
using System.Runtime.Serialization;

namespace GestioneAzienda
{
    [Serializable]
    internal class ParametroErrato : Exception
    {
        private int param;

        public ParametroErrato()
        {
        }

        public ParametroErrato(int param)
        {
            this.param = param;
        }

        public ParametroErrato(int param, string message) : base(message)
        {
            this.param = param;
        }

        public ParametroErrato(string message) : base(message)
        {
        }

        public ParametroErrato(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ParametroErrato(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "Valore parametro: " + this.param;
            return s;
        }
    }
}